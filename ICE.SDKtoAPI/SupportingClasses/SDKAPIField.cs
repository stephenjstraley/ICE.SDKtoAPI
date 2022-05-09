using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Reflection;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;

namespace ICE.SDKtoAPI.SupportingClasses
{
    public class SDKAPIField
    {
        //        protected Dictionary<string, string> _fields = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        //        protected Dictionary<string, string> _dynamicFields = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        protected Dictionary<string, APISchema> _fields = new Dictionary<string, APISchema>(StringComparer.InvariantCultureIgnoreCase);
        protected Dictionary<string, APISchema> _dynamicFields = new Dictionary<string, APISchema>(StringComparer.InvariantCultureIgnoreCase);
        protected Dictionary<string, string> _virtualFields = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        protected List<CustomFieldMeta> _customFields;
        protected LenderApiContractsV1.LoanContract _loanV1;
        protected LenderApiContractsV1.LoanContract _loanToUpdateV1 = new LenderApiContractsV1.LoanContract();

        protected LenderApiContractsV3.LoanContract _loanV3;
        protected LenderApiContractsV3.LoanContract _loanToUpdateV3 = new LenderApiContractsV3.LoanContract();

        protected string _lastCallId = string.Empty;

        protected AccessToken _accessToken;

        public bool LoanWasUpdated => _loanWasUpdated;
        protected bool _loanWasUpdated = false;
        protected List<Tuple<string, string>> _badFields = new List<Tuple<string, string>>();
        public bool _successfullyLoaded = false;
        protected bool _loadV3 = false;
        protected bool _loadV1 => (!_loadV3);

        public List<APISchema> FieldSchema
        {
            get
            {
                if (_fields.Count < 1)
                    LoadDictionary();

                return _fields.Values.ToList();
            }
        }

        public void ReloadDictionary()
        {
            _fields = new Dictionary<string, APISchema>();
            LoadDictionary();
        }

        public List<APISchema> DynamicSchema => _dynamicFields.Values.ToList();
        public List<string> VirtualSchema => _virtualFields.Keys.ToList();
        //public List<Tuple<string, string>> InvalidFields => _badFields;
        public void SetLoanVersion(bool v3 = false) => _loadV3 = v3;

        public SDKAPIField()
        {
            //LoadDictionary();

        }
        public void ClearLoan()
        {
            _loanV1 = null;
            _loanV3 = null;
        }

        public void ClearPreviousUpdatedLoan()
        {
            _loanWasUpdated = false;
            if (_loadV3)
                _loanToUpdateV3 = new LenderApiContractsV3.LoanContract();
            else
                _loanToUpdateV1 = new LenderApiContractsV1.LoanContract();
        }
        public void SetLoan(LenderApiContractsV1.LoanContract loan)
        {
            _loanV1 = loan;
            _loanToUpdateV1.EncompassId = _loanV1.EncompassId;
        }
        public void SetLoan(LenderApiContractsV3.LoanContract loan)
        {
            _loanV3 = loan;
            _loanToUpdateV3.Id = _loanV3.Id;
        }

        public void SetAccessToken(AccessToken token) => _accessToken = token;
        public void SetCustomFields(List<CustomFieldMeta> meta) => _customFields = meta;
        public void SetVirtualFields(List<VirtualFieldMeta> meta)
        {
            _virtualFields = new Dictionary<string, string>();
            foreach (var item in meta)
            {
                _virtualFields.Add(item.Id, item.Description);
            }
        }
        public void ClearCustomFields() => _customFields = null;
        public object UpdatedLoan
        {
            get
            {
                if (_loadV3)
                    return _loanToUpdateV3;
                else
                    return _loanToUpdateV1;
            }
        }
        private void LoadDictionary()
        {
            _fields = new Dictionary<string, APISchema>();
            _dynamicFields = new Dictionary<string, APISchema>();
            _successfullyLoaded = true;

            var currentId = "";

            try
            {
                string[] file = null;
                if (_loadV3)
                    file = Properties.Resources.DictionaryFieldsV3.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                else
                    file = Properties.Resources.DictionaryFieldsV1.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None); ;


                foreach (var line in file)
                {
//                    System.Diagnostics.Debug.WriteLine($"Reading line: [{line}]");
                    try
                    {
                        //                    #if DEBUG
                        //                    System.Diagnostics.Debug.WriteLine(line);
                        //                    #endif

                        //                    if (line.Contains("OPTIMAL.HISTORY"))
                        //                    {
                        //                        var stophere = true;
                        //                    }

                        if (!string.IsNullOrEmpty(line) && line?.Trim().Length > 10)  // just in case
                        {
                            if (!line.StartsWith("#"))
                            {
                                var item = line.Split('~');

                                currentId = item[0];

                                APISchema schema = new APISchema
                                {
                                    Key = item[0],
                                    Meta = item[1],
                                    ReadOnly = Convert.ToBoolean(item[2]),
                                    Type = item[3],
                                    Nullable = Convert.ToBoolean(item[4]),
                                    Description = item[5],
                                    LockedField = Convert.ToBoolean(item[6]),
                                    ENum = item[7]
                                };
                                if (item.Count() == 9)
                                    schema.Format = item[8];

                                if (schema.Meta.Contains("Applications{current}"))  // Add the #'s
                                {
                                    for (int x = 1; x < 5; x++)
                                    {
                                        APISchema poundSchema = new APISchema()
                                        {
                                            Key = schema.Key + $"#{x}",
                                            Meta = schema.Meta,
                                            ReadOnly = schema.ReadOnly,
                                            Type = schema.Type,
                                            Nullable = schema.Nullable,
                                            Description = schema.Description,
                                            LockedField = schema.LockedField,
                                            ENum = schema.ENum,
                                            Format = schema.Format
                                        };

                                        Add(poundSchema);
                                    }

                                }

                                // Now check to see if it is special
                                if (line.StartsWith("^"))
                                {
                                    // Replicate these lines 4 times for dictionary
                                    var parts = line.Substring(1).Split(')');
                                    // there should be 3 parts
                                    var first = parts[0].Replace("(", "");
                                    var end = parts[2].Replace("(", "").Replace("$", "");
                                    for (int x = 0; x < 4; x++)
                                    {
                                        var newField = first + x.ToString().PadLeft(2, '0') + end;
                                        // now fix the indexer in the old schema
                                        var newMeta = schema.Meta.Replace("(X)", $"({x + 1})");
                                        // now create new dictionary
                                        var temp = new APISchema
                                        {
                                            Key = newField,
                                            Meta = newMeta,
                                            ReadOnly = schema.ReadOnly,
                                            Type = schema.Type,
                                            Nullable = schema.Nullable,
                                            Description = schema.Description,
                                            LockedField = schema.LockedField,
                                            ENum = schema.ENum,
                                            Format = schema.Format
                                        };
                                        Add(temp);
                                    }
                                }
                                else
                                    Add(schema);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        _successfullyLoaded = false;
                        if (!string.IsNullOrEmpty(currentId))
                            System.Diagnostics.Debug.WriteLine($"Error Loading: [{currentId}] - {e.Message}");
                        else
                            System.Diagnostics.Debug.WriteLine($"Error reading ling: [{line}] - {e.Message}");
                        break;
                    }
                }

                // now add custom fields to the dictionary
                SetCustomFields();
                foreach(var cField in _customFields)
                {
//                    if (cField.Id.StartsWith("CX")) // OUR custom fields
//                    {
                        APISchema schema = new APISchema
                        {
                            Key = cField.Id,
                            Meta = cField.ModelPath,
                            ReadOnly = false,
                            Type = cField.Format,
                            Nullable = false,
                            Description = cField.Description,
                            LockedField = false,
                            ENum = ""
                        };
                        Add(schema);
//                    }
                }                

            }
            catch (Exception ex)
            {
                _successfullyLoaded = false;
                System.Diagnostics.Debug.WriteLine($"Error Loading: [{currentId}] - {ex.Message}");
            }
        }
        private void Add(APISchema schema)
        {
            if (schema.Key.StartsWith("^"))
            {
                if (!_dynamicFields.ContainsKey(schema.Key))
                    _dynamicFields.Add(schema.Key, schema);
                else
                    System.Diagnostics.Debug.WriteLine($"Dynamic Field skipped - already present {schema.Key}");
            }
            else
            {
                if (!_fields.ContainsKey(schema.Key))
                    _fields.Add(schema.Key, schema);
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Field skipped - already present {schema.Key}");
                }
            }
        }

        public object this[string idField]
        {
            get 
            {
                if (_fields.Count == 0 || _dynamicFields.Count == 0)
                    LoadDictionary();

                APISchema item = _fields[idField];
                //var value = MainField<string>(idField);
                var value = MainField<object>(idField);
                if (value != null)
                {
                    switch (item.Type.ToUpper())
                    {
                        case "DECIMAL":
                            if (string.IsNullOrEmpty(value.ToString()))
                                return value.ToString();
                            else
                                return Convert.ToDecimal(value);

                        case "BOOL":
                            if (string.IsNullOrEmpty(value.ToString()))
                                return value.ToString();
                            else
                                return Convert.ToBoolean(value);
                            
                        case "DATE":
                        case "DATETIME":  // check for V1 if "//" for empty
                            {
                                if (string.IsNullOrEmpty(value.ToString()))
                                    return value.ToString();
                                else
                                {
                                    if (value.ToString() == "//") // V1 Loans
                                    {
                                        return null;
                                    }
                                    else
                                        return Convert.ToDateTime(value);
                                }
                            }

                        case "INT":
                            if (string.IsNullOrEmpty(value.ToString()))
                                return value.ToString();
                            else
                                return Convert.ToInt32(value);

                        default:
                            return value.ToString();
                    }
                }

                return value; // default to return null
            }
            set 
            {
                if (_fields.Count == 0 || _dynamicFields.Count == 0)
                    LoadDictionary();

                if (_customFields == null)
                    PrepCustomFields();

                SetTheFields(idField, value); 
            }
        }

        public APISchema GetDictionaryItem(string id)
        {
            var tempId = id;
            if (!(id.StartsWith("CX.") || (id.StartsWith("CUST") && id.EndsWith("FV"))))
            {
                if (id.Contains("#"))
                {
                    var spliiter = id.Split('#');
                    tempId = spliiter[0];
                }

                if (_fields.ContainsKey(tempId))
                    return _fields[tempId];

                else if (_dynamicFields.Count > 0)
                {
                    foreach (var dyno in _dynamicFields)
                    {
                        var matched = System.Text.RegularExpressions.Regex.Match(id, dyno.Key);
                        if (matched.Success)
                        {
                            return dyno.Value;
                        }
                    }
                }
            }

            return null;
        }

        #region Set Field and Property
        private void SetTheFields(string id, object value)
        {
            // Determine TYPE of object (date, string, decimal, bool)
            var theType = value.GetType();
            if (id.StartsWith("CX.") || (id.StartsWith("CUST") && id.EndsWith("FV")))
            {
                // now check to see if ID is an actual custom field that can be assigned

                if (CustomFieldDefined(id))
                {
                    switch (theType.Name)
                    {
                        case "String":
                            SetCustomFields(id, (string)value);
                            break;
                        case "Int32":
                            SetCustomFields(id, (int)value);
                            break;
                        case "Boolean":
                            SetCustomFields(id, (bool)value);
                            break;
                        case "Double":
                            SetCustomFields(id, (float)value);
                            break;
                        case "DateTime":
                            SetCustomFields(id, (DateTime)value);
                            break;
                    }
                }
            }
            else
            {
                var bracketIndex = -1;
                bool withPoundSign = false;

                // If there is a # we need to take it out
                var tempId = id;
                if (id.Contains("#"))
                {
                    var spliiter = id.Split('#');
                    tempId = spliiter[0];
                    bracketIndex = Convert.ToInt32(spliiter[1]) - 1;
                    withPoundSign = true;
                }

                if (_loadV1)
                {
                    if (_fields.ContainsKey(tempId))
                    {
                        var item = _fields[tempId];                        // Update a regular field

                        if (!item.ReadOnly)  // read only fields cannot be set
                        {
                            var metaData = item.Meta;

                            var innerIndex = ParseInnerIndexer(ref metaData);      // Process Indexers that may appear

                            if (metaData.Contains("{") && metaData.Contains("}"))
                            {
                                string left, right;
                                bracketIndex = ParseWithInnerBraces(metaData, withPoundSign, bracketIndex, out left, out right);
                                var property = (IList)_loanV1.GetType().GetProperty(left).GetValue(_loanV1);
                                if (property.Count > bracketIndex)
                                {
                                    var applicationProperty = property[bracketIndex];

                                    if (right.Contains("["))
                                    {
                                        if (!right.StartsWith("["))
                                        {
                                            var applicationId = "";

                                            if (_loadV3)
                                                applicationId = ((LenderApiContractsV3.ApplicationContract)applicationProperty).Id;
                                            else
                                                applicationId = ((LenderApiContractsV1.LoanContractApplications)applicationProperty).Id;

                                            metaData = right;
                                            right = metaData.Split(']')[1];
                                            right = right.Replace(".", string.Empty);
                                            var middle = metaData.Split(']')[0] + "]";
                                            left = metaData.Split('[')[0];
                                            middle = middle.Substring(left.Length);

                                            // check to see if it is an INDEX property

                                            if (innerIndex != -1 && middle == "[]")
                                            {

                                            }
                                            else
                                            {
                                                // Now get property of the array

                                                var innerArray = GetPropertyValue<IList>(applicationProperty, left, id);
                                                var foundObject = FindIndexedObject(innerArray, middle, right, innerIndex);

                                                if (foundObject == null) { } // Cant find the item to begin with     loan.Fields["IRS4506.X4"]
                                                else
                                                    SetPropertyValue(applicationId, foundObject, middle, right, value);
                                            }

                                        } // This is an indexed def
                                    }
                                    else
                                    {
                                        SetPropertyValue(applicationProperty, right, value);
                                    }

                                }
                            }
                            else if (metaData.Contains("[") && metaData.Contains("]"))
                            {
                                var left = ParseInnerBrackets(metaData)[0];
                                var middle = ParseInnerBrackets(metaData)[1];
                                var right = ParseInnerBrackets(metaData)[2];

                                var property = GetPropertyValue<IList>(_loanV1, left, id);
                                ////                        ProcessList<T>(_loan, item, innerIndex);
                                if (innerIndex != -1 && middle == "[]")  // just pull the INDEXER item
                                {
                                    if (property.Count > innerIndex)
                                    {
                                        var theObject = property[innerIndex];
                                        SetPropertyValue(theObject, right, value);
                                        //        var foundValue = theObject.GetType()?.GetProperty(right)?.GetValue(theObject)?.ToString();
                                    }
                                }
                                else // Property Values, not APPLICATION based
                                {
                                    var foundObject = FindIndexedObject(property, middle, right, innerIndex);
                                    if (foundObject != null)
                                    {
                                        SetPropertyValue(null, foundObject, middle, right, value);
                                    }
                                }
                            }
                            else
                            {
                                if (PropertyExists(metaData))
                                {
                                    SetPropertyValue(metaData, value);
                                }
                            }
                        }
                    }
                    else if (_dynamicFields.Count > 0) // need some check to see if it is a dynamic field
                    {
                        foreach (var dyno in _dynamicFields)
                        {
                            var matched = System.Text.RegularExpressions.Regex.Match(id, dyno.Key);
                            if (matched.Success)
                            {
                                // pull the indexer out
                                var innerIndex = Convert.ToInt32(matched.Groups[2].Value) + 1;

                                var schema = dyno.Value;

                                var tempMeta = schema.Meta.Replace("(X)", $"({innerIndex})");    // DO NOT REPLACE THE META - it will screw things up!

                                if (!dyno.Value.ReadOnly)
                                {
                                    var metaData = tempMeta;

                                    var dynInnerIndex = ParseInnerIndexer(ref metaData);      // Process Indexers that may appear

                                    if (metaData.Contains("{") && metaData.Contains("}"))
                                    {
                                        string left, right;
                                        bracketIndex = ParseWithInnerBraces(metaData, withPoundSign, bracketIndex, out left, out right);
                                        var property = (IList)_loanV1.GetType().GetProperty(left).GetValue(_loanV1);
                                        if (property.Count > bracketIndex)
                                        {
                                            var applicationProperty = property[bracketIndex];

                                            if (right.Contains("["))
                                            {
                                                if (!right.StartsWith("["))
                                                {
                                                    var applicationId = "";

                                                    if (_loadV3)
                                                        applicationId = ((LenderApiContractsV3.ApplicationContract)applicationProperty).Id;
                                                    else
                                                        applicationId = ((LenderApiContractsV1.LoanContractApplications)applicationProperty).Id;

                                                    metaData = right;
                                                    right = metaData.Split(']')[1];
                                                    right = right.Replace(".", string.Empty);
                                                    var middle = metaData.Split(']')[0] + "]";
                                                    left = metaData.Split('[')[0];
                                                    middle = middle.Substring(left.Length);

                                                    // check to see if it is an INDEX property

                                                    if (dynInnerIndex != -1 && middle == "[]")  // LEFT has ASSETS array ref, dynInnerIndex points to the array instances
                                                    {
                                                        var innerArray = GetPropertyValue<IList>(applicationProperty, left, id);
                                                        if (innerArray != null && innerArray.Count > dynInnerIndex)
                                                        {
                                                            var foundInstance = innerArray[dynInnerIndex];
                                                            SetPropertyValue(applicationId, foundInstance, middle, right, value);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        // Now get property of the array

                                                        var innerArray = GetPropertyValue<IList>(applicationProperty, left, id);
                                                        var foundObject = FindIndexedObject(innerArray, middle, right, dynInnerIndex);

                                                        if (foundObject == null) { } // Cant find the item to begin with     loan.Fields["IRS4506.X4"]
                                                        else
                                                            SetPropertyValue(applicationId, foundObject, middle, right, value);
                                                    }

                                                } // This is an indexed def
                                            }
                                            else
                                            {
                                                SetPropertyValue(applicationProperty, right, value);
                                            }

                                        }

                                    }
                                    else if (metaData.Contains("[") && metaData.Contains("]"))
                                    {
                                        var left = ParseInnerBrackets(metaData)[0];
                                        var middle = ParseInnerBrackets(metaData)[1];
                                        var right = ParseInnerBrackets(metaData)[2];

                                        var property = GetPropertyValue<IList>(_loanV1, left, id);

                                        if (property != null)
                                        {
                                            if (dynInnerIndex != -1 && middle == "[]")  // just pull the INDEXER item
                                            {
                                                if (property.Count > dynInnerIndex)
                                                {
                                                    var theObject = property[dynInnerIndex];
                                                    SetPropertyValue(theObject, right, value);
                                                    //        var foundValue = theObject.GetType()?.GetProperty(right)?.GetValue(theObject)?.ToString();
                                                }
                                            }
                                            else // Property Values, not APPLICATION based
                                            {
                                                var foundObject = FindIndexedObject(property, middle, right, dynInnerIndex);
                                                if (foundObject != null)
                                                {
                                                    SetPropertyValue(null, foundObject, middle, right, value);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (PropertyExists(metaData))
                                        {
                                            SetPropertyValue(metaData, value);
                                        }
                                    }

                                }

                                break; // no need to loop more, we've matched
                            }
                        }
                    }
                }
                else
                {
                    ///TODO add V3 stuff
                }
            }
        }

        private void SetPropertyValue(string applicationId, object instance, string middle, string right, object value)
        {
            middle = middle.Replace("[", "").Replace("]", "");
            var foundProp = instance.GetType()?.GetProperty(right);

            foundProp.SetValue(instance, GetAPIValue(foundProp, value), null);

            var idProp = instance.GetType()?.GetProperty("Id");
            var instanceId = idProp?.GetValue(instance);

            var className = instance.GetType().Name;

            if (!string.IsNullOrEmpty(applicationId))
            {
                // check to see if APPLICATIONS is created and if not, do it with the above ID
                CheckApplicationObject(applicationId);
            }

            if (_loadV1)
            {
                switch (className)
                {
                    case "LoanContractContacts":
                        {
                            if (_loanToUpdateV1.Contacts == null)
                            {
                                _loanToUpdateV1.Contacts = new List<LenderApiContractsV1.LoanContractContacts>();
                            }
                            var isThere = _loanToUpdateV1.Contacts.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractContacts()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Contacts.Add(newInstance);
                                // now update the properties in the type and the specified property
                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractFees":
                        {
                            if (_loanToUpdateV1.Fees == null)
                            {
                                _loanToUpdateV1.Fees = new List<LenderApiContractsV1.LoanContractFees>();
                            }
                            var isThere = _loanToUpdateV1.Fees.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractFees()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Fees.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractHomeCounselingProviders":
                        {
                            if (_loanToUpdateV1.HomeCounselingProviders == null)
                            {
                                _loanToUpdateV1.HomeCounselingProviders = new List<LenderApiContractsV1.LoanContractHomeCounselingProviders>();
                            }
                            var isThere = _loanToUpdateV1.HomeCounselingProviders.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractHomeCounselingProviders()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.HomeCounselingProviders.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractLoanSubmissionLoanSubmissionFees":
                        {
                            if (_loanToUpdateV1.LoanSubmission == null)
                            {
                                _loanToUpdateV1.LoanSubmission = new LenderApiContractsV1.LoanContractLoanSubmission();
                            }
                            if (_loanToUpdateV1.LoanSubmission.LoanSubmissionFees == null)
                            {
                                _loanToUpdateV1.LoanSubmission.LoanSubmissionFees = new List<LenderApiContractsV1.LoanContractLoanSubmissionLoanSubmissionFees>();
                            }
                            var isThere = _loanToUpdateV1.LoanSubmission.LoanSubmissionFees.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractLoanSubmissionLoanSubmissionFees()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.LoanSubmission.LoanSubmissionFees.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractGfeGfeFees":
                        {
                            if (_loanToUpdateV1.Gfe == null)
                            {
                                _loanToUpdateV1.Gfe = new LenderApiContractsV1.LoanContractGfe();
                            }
                            if (_loanToUpdateV1.Gfe.GfeFees == null)
                            {
                                _loanToUpdateV1.Gfe.GfeFees = new List<LenderApiContractsV1.LoanContractGfeGfeFees>();
                            }
                            var isThere = _loanToUpdateV1.Gfe.GfeFees.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractGfeGfeFees()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Gfe.GfeFees.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractRegulationZRegulationZPayments":
                        {
                            if (_loanToUpdateV1.RegulationZ == null)
                            {
                                _loanToUpdateV1.RegulationZ = new LenderApiContractsV1.LoanContractRegulationZ();
                            }
                            if (_loanToUpdateV1.RegulationZ.RegulationZPayments == null)
                            {
                                _loanToUpdateV1.RegulationZ.RegulationZPayments = new List<LenderApiContractsV1.LoanContractRegulationZRegulationZPayments>();
                            }
                            var isThere = _loanToUpdateV1.RegulationZ.RegulationZPayments.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractRegulationZRegulationZPayments()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.RegulationZ.RegulationZPayments.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingDocumentClosingEntities":
                        {
                            if (_loanToUpdateV1.ClosingDocument == null)
                            {
                                _loanToUpdateV1.ClosingDocument = new LenderApiContractsV1.LoanContractClosingDocument();
                            }
                            if (_loanToUpdateV1.ClosingDocument.ClosingEntities == null)
                            {
                                _loanToUpdateV1.ClosingDocument.ClosingEntities = new List<LenderApiContractsV1.LoanContractClosingDocumentClosingEntities>();
                            }
                            var isThere = _loanToUpdateV1.ClosingDocument.ClosingEntities.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingDocumentClosingEntities()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingDocument.ClosingEntities.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingCostClosingDisclosure3UCDDetails":
                        {
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.ClosingDisclosure3 == null)
                            {
                                _loanToUpdateV1.ClosingCost.ClosingDisclosure3 = new LenderApiContractsV1.LoanContractClosingCostClosingDisclosure3();
                            }
                            if (_loanToUpdateV1.ClosingCost.ClosingDisclosure3.UCDDetails == null)
                            {
                                _loanToUpdateV1.ClosingCost.ClosingDisclosure3.UCDDetails = new List<LenderApiContractsV1.LoanContractClosingCostClosingDisclosure3UCDDetails>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.ClosingDisclosure3.UCDDetails.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostClosingDisclosure3UCDDetails()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.ClosingDisclosure3.UCDDetails.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                        }
                        break;

                    case "LoanContractClosingDocumentAdditionalStateDisclosures":
                        {
                            //ClosingDocument.AdditionalStateDisclosures
                            if (_loanToUpdateV1.ClosingDocument == null)
                            {
                                _loanToUpdateV1.ClosingDocument = new LenderApiContractsV1.LoanContractClosingDocument();
                            }
                            if (_loanToUpdateV1.ClosingDocument.AdditionalStateDisclosures == null)
                            {
                                _loanToUpdateV1.ClosingDocument.AdditionalStateDisclosures = new List<LenderApiContractsV1.LoanContractClosingDocumentAdditionalStateDisclosures>();
                            }
                            var isThere = _loanToUpdateV1.ClosingDocument.AdditionalStateDisclosures.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingDocumentAdditionalStateDisclosures()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingDocument.AdditionalStateDisclosures.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractClosingDocumentStateLicenses":
                        {
                            //ClosingDocument.StateLicense
                            if (_loanToUpdateV1.ClosingDocument == null)
                            {
                                _loanToUpdateV1.ClosingDocument = new LenderApiContractsV1.LoanContractClosingDocument();
                            }
                            if (_loanToUpdateV1.ClosingDocument.StateLicenses == null)
                            {
                                _loanToUpdateV1.ClosingDocument.StateLicenses = new List<LenderApiContractsV1.LoanContractClosingDocumentStateLicenses>();
                            }
                            var isThere = _loanToUpdateV1.ClosingDocument.StateLicenses.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingDocumentStateLicenses()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingDocument.StateLicenses.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingCostGfe2010Gfe2010Fees":
                        {
                            //ClosingCost.Gfe2010.Gfe2010Fees
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010 == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010 = new LenderApiContractsV1.LoanContractClosingCostGfe2010();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010Fees == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010Fees = new List<LenderApiContractsV1.LoanContractClosingCostGfe2010Gfe2010Fees>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010Fees.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostGfe2010Gfe2010Fees()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010Fees.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingCostGfe2010PageGfe2010GfeCharges":
                        {
                            //ClosingCost.Gfe2010Page.Gfe2010GfeCharges
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010Page == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010Page = new LenderApiContractsV1.LoanContractClosingCostGfe2010Page();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010GfeCharges == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010GfeCharges = new List<LenderApiContractsV1.LoanContractClosingCostGfe2010PageGfe2010GfeCharges>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010GfeCharges.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostGfe2010PageGfe2010GfeCharges()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010GfeCharges.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs":
                        {
                            // ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010Page == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010Page = new LenderApiContractsV1.LoanContractClosingCostGfe2010Page();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs = new List<LenderApiContractsV1.LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingCostGfe2010Gfe2010WholePocs":
                        {
                            // ClosingCost.Gfe2010.Gfe2010WholePocs
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010 == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010 = new LenderApiContractsV1.LoanContractClosingCostGfe2010();
                            }
                            if (_loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010WholePocs == null)
                            {
                                _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010WholePocs = new List<LenderApiContractsV1.LoanContractClosingCostGfe2010Gfe2010WholePocs>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010WholePocs.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostGfe2010Gfe2010WholePocs()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.Gfe2010.Gfe2010WholePocs.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractProfitManagementProfitManagementItems":
                        {
                            //ProfitManagement.ProfitManagementItems
                            if (_loanToUpdateV1.ProfitManagement == null)
                            {
                                _loanToUpdateV1.ProfitManagement = new LenderApiContractsV1.LoanContractProfitManagement();
                            }
                            if (_loanToUpdateV1.ProfitManagement.ProfitManagementItems == null)
                            {
                                _loanToUpdateV1.ProfitManagement.ProfitManagementItems = new List<LenderApiContractsV1.LoanContractProfitManagementProfitManagementItems>();
                            }
                            var isThere = _loanToUpdateV1.ProfitManagement.ProfitManagementItems.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractProfitManagementProfitManagementItems()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ProfitManagement.ProfitManagementItems.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractGfeGfePayoffs":
                        {
                            // Gfe.GfePayoffs
                            if (_loanToUpdateV1.Gfe == null)
                            {
                                _loanToUpdateV1.Gfe = new LenderApiContractsV1.LoanContractGfe();
                            }
                            if (_loanToUpdateV1.Gfe.GfePayoffs == null)
                            {
                                _loanToUpdateV1.Gfe.GfePayoffs = new List<LenderApiContractsV1.LoanContractGfeGfePayoffs>();
                            }
                            var isThere = _loanToUpdateV1.Gfe.GfePayoffs.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractGfeGfePayoffs()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Gfe.GfePayoffs.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractGfeGfeLiens":
                        {
                            // Gfe.GfeLiens
                            if (_loanToUpdateV1.Gfe == null)
                            {
                                _loanToUpdateV1.Gfe = new LenderApiContractsV1.LoanContractGfe();
                            }
                            if (_loanToUpdateV1.Gfe.GfeLiens == null)
                            {
                                _loanToUpdateV1.Gfe.GfeLiens = new List<LenderApiContractsV1.LoanContractGfeGfeLiens>();
                            }
                            var isThere = _loanToUpdateV1.Gfe.GfeLiens.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractGfeGfeLiens()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Gfe.GfeLiens.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractGfeGfePayments":
                        {
                            //Gfe.GfePayments
                            if (_loanToUpdateV1.Gfe == null)
                            {
                                _loanToUpdateV1.Gfe = new LenderApiContractsV1.LoanContractGfe();
                            }
                            if (_loanToUpdateV1.Gfe.GfePayments == null)
                            {
                                _loanToUpdateV1.Gfe.GfePayments = new List<LenderApiContractsV1.LoanContractGfeGfePayments>();
                            }
                            var isThere = _loanToUpdateV1.Gfe.GfePayments.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractGfeGfePayments()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Gfe.GfePayments.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractUsdaUsdaHouseholdIncomes":
                        {
                            // Usda.UsdaHouseholdIncomes
                            if (_loanToUpdateV1.Usda == null)
                            {
                                _loanToUpdateV1.Usda = new LenderApiContractsV1.LoanContractUsda();
                            }
                            if (_loanToUpdateV1.Usda.UsdaHouseholdIncomes == null)
                            {
                                _loanToUpdateV1.Usda.UsdaHouseholdIncomes = new List<LenderApiContractsV1.LoanContractUsdaUsdaHouseholdIncomes>();
                            }
                            var isThere = _loanToUpdateV1.Usda.UsdaHouseholdIncomes.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractUsdaUsdaHouseholdIncomes()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Usda.UsdaHouseholdIncomes.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractVaLoanDataMilitaryServices":
                        {
                            // VaLoanData.MilitaryServices
                            if (_loanToUpdateV1.VaLoanData == null)
                            {
                                _loanToUpdateV1.VaLoanData = new LenderApiContractsV1.LoanContractVaLoanData();
                            }
                            if (_loanToUpdateV1.VaLoanData.MilitaryServices == null)
                            {
                                _loanToUpdateV1.VaLoanData.MilitaryServices = new List<LenderApiContractsV1.LoanContractVaLoanDataMilitaryServices>();
                            }
                            var isThere = _loanToUpdateV1.VaLoanData.MilitaryServices.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractVaLoanDataMilitaryServices()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.VaLoanData.MilitaryServices.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractVaLoanDataPreviousVaLoans":
                        {
                            // VaLoanData.PreviousVaLoans
                            if (_loanToUpdateV1.VaLoanData == null)
                            {
                                _loanToUpdateV1.VaLoanData = new LenderApiContractsV1.LoanContractVaLoanData();
                            }
                            if (_loanToUpdateV1.VaLoanData.PreviousVaLoans == null)
                            {
                                _loanToUpdateV1.VaLoanData.PreviousVaLoans = new List<LenderApiContractsV1.LoanContractVaLoanDataPreviousVaLoans>();
                            }
                            var isThere = _loanToUpdateV1.VaLoanData.PreviousVaLoans.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractVaLoanDataPreviousVaLoans()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.VaLoanData.PreviousVaLoans.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        };
                        break;

                    case "LoanContractHud1EsHud1EsPayTos":
                        {
                            // Hud1Es.Hud1EsPayTos
                            if (_loanToUpdateV1.Hud1Es == null)
                            {
                                _loanToUpdateV1.Hud1Es = new LenderApiContractsV1.LoanContractHud1Es();
                            }
                            if (_loanToUpdateV1.Hud1Es.Hud1EsPayTos == null)
                            {
                                _loanToUpdateV1.Hud1Es.Hud1EsPayTos = new List<LenderApiContractsV1.LoanContractHud1EsHud1EsPayTos>();
                            }
                            var isThere = _loanToUpdateV1.Hud1Es.Hud1EsPayTos.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractHud1EsHud1EsPayTos()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Hud1Es.Hud1EsPayTos.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractHud1EsHud1EsDates":
                        {
                            // Hud1Es.Hud1EsDates
                            if (_loanToUpdateV1.Hud1Es == null)
                            {
                                _loanToUpdateV1.Hud1Es = new LenderApiContractsV1.LoanContractHud1Es();
                            }
                            if (_loanToUpdateV1.Hud1Es.Hud1EsDates == null)
                            {
                                _loanToUpdateV1.Hud1Es.Hud1EsDates = new List<LenderApiContractsV1.LoanContractHud1EsHud1EsDates>();
                            }
                            var isThere = _loanToUpdateV1.Hud1Es.Hud1EsDates.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractHud1EsHud1EsDates()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Hud1Es.Hud1EsDates.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractShippingShippingContacts":
                        {
                            // Shipping.ShippingContacts
                            if (_loanToUpdateV1.Shipping == null)
                            {
                                _loanToUpdateV1.Shipping = new LenderApiContractsV1.LoanContractShipping();
                            }
                            if (_loanToUpdateV1.Shipping.ShippingContacts == null)
                            {
                                _loanToUpdateV1.Shipping.ShippingContacts = new List<LenderApiContractsV1.LoanContractShippingShippingContacts>();
                            }
                            var isThere = _loanToUpdateV1.Shipping.ShippingContacts.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractShippingShippingContacts()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.Shipping.ShippingContacts.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                            }
                            else { } // update a value
                        }
                        break;

                    case "LoanContractClosingCostFeeVariances":
                        {
                            //ClosingCost.FeeVariances
                            if (_loanToUpdateV1.ClosingCost == null)
                            {
                                _loanToUpdateV1.ClosingCost = new LenderApiContractsV1.LoanContractClosingCost();
                            }
                            if (_loanToUpdateV1.ClosingCost.FeeVariances == null)
                            {
                                _loanToUpdateV1.ClosingCost.FeeVariances = new List<LenderApiContractsV1.LoanContractClosingCostFeeVariances>();
                            }
                            var isThere = _loanToUpdateV1.ClosingCost.FeeVariances.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingCostFeeVariances()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingCost.FeeVariances.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractClosingDocumentRespaHudDetails":
                        {
                            //ClosingDocument.RespaHudDetails
                            if (_loanToUpdateV1.ClosingDocument == null)
                            {
                                _loanToUpdateV1.ClosingDocument = new LenderApiContractsV1.LoanContractClosingDocument();
                            }
                            if (_loanToUpdateV1.ClosingDocument.RespaHudDetails == null)
                            {
                                _loanToUpdateV1.ClosingDocument.RespaHudDetails = new List<LenderApiContractsV1.LoanContractClosingDocumentRespaHudDetails>();
                            }
                            var isThere = _loanToUpdateV1.ClosingDocument.RespaHudDetails.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractClosingDocumentRespaHudDetails()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingDocument.RespaHudDetails.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractHudLoanDataSecondaryFinancingProviders":
                        {
                            if (_loanToUpdateV1.HudLoanData == null)
                            {
                                _loanToUpdateV1.HudLoanData = new LenderApiContractsV1.LoanContractHudLoanData();
                            }
                            if (_loanToUpdateV1.HudLoanData.SecondaryFinancingProviders == null)
                            {
                                _loanToUpdateV1.HudLoanData.SecondaryFinancingProviders = new List<LenderApiContractsV1.LoanContractHudLoanDataSecondaryFinancingProviders>();
                            }
                            var isThere = _loanToUpdateV1.HudLoanData.SecondaryFinancingProviders.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                var newInstance = new LenderApiContractsV1.LoanContractHudLoanDataSecondaryFinancingProviders()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.HudLoanData.SecondaryFinancingProviders.Add(newInstance);

                                UpdateInnerProperties(newInstance, middle);

                                var propertyInfo = newInstance.GetType().GetProperty(right);
                                propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);

                            }
                            else { } // update a value

                        }
                        break;

                    case "LoanContractIncome":
                        {
                            // LoanContractIncome
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Income == null)
                                {
                                    item.Income = new List<LenderApiContractsV1.LoanContractIncome>();
                                }
                                var isThere = item.Income.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractIncome()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Income.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractAssets":
                        {
                            //LoanContractAssets
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Assets == null)
                                {
                                    item.Assets = new List<LenderApiContractsV1.LoanContractAssets>();
                                }
                                var isThere = item.Assets.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractAssets()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Assets.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractLiabilities":
                        {
                            //LoanContractLiabilities
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Liabilities == null)
                                {
                                    item.Liabilities = new List<LenderApiContractsV1.LoanContractLiabilities>();
                                }
                                var isThere = item.Liabilities.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractLiabilities()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Liabilities.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractResidences":
                        {
                            //LoanContractResidences
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Residences == null)
                                {
                                    item.Residences = new List<LenderApiContractsV1.LoanContractResidences>();
                                }
                                var isThere = item.Residences.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractResidences()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Residences.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractEmployment":
                        {
                            //LoanContractEmployment
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Employment == null)
                                {
                                    item.Employment = new List<LenderApiContractsV1.LoanContractEmployment>();
                                }
                                var isThere = item.Employment.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractEmployment()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Employment.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractSelfEmployedIncomes":
                        {
                            //LoanContractEmployment
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.SelfEmployedIncomes == null)
                                {
                                    item.SelfEmployedIncomes = new List<LenderApiContractsV1.LoanContractSelfEmployedIncomes>();
                                }
                                var isThere = item.SelfEmployedIncomes.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractSelfEmployedIncomes()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.SelfEmployedIncomes.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }
                        }
                        break;

                    case "LoanContractReoProperties":
                        {
                            //LoanContractReoProperties
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.ReoProperties == null)
                                {
                                    item.ReoProperties = new List<LenderApiContractsV1.LoanContractReoProperties>();
                                }
                                var isThere = item.ReoProperties.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractReoProperties()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.ReoProperties.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }

                        }
                        break;

                    case "LoanContractTax4506s":
                        {
                            //LoanContractTax4506s
                            var item = _loanToUpdateV1.Applications.Where(t => t.Id == applicationId).FirstOrDefault(); // application instance
                            if (item != null)
                            {
                                if (item.Tax4506s == null)
                                {
                                    item.Tax4506s = new List<LenderApiContractsV1.LoanContractTax4506s>();
                                }
                                var isThere = item.Tax4506s.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    var newInstance = new LenderApiContractsV1.LoanContractTax4506s()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    item.Tax4506s.Add(newInstance);

                                    UpdateInnerProperties(newInstance, middle);

                                    var propertyInfo = newInstance.GetType().GetProperty(right);
                                    propertyInfo.SetValue(newInstance, GetAPIValue(propertyInfo, value), null);
                                }
                            }

                        }
                        break;

                    default:
                        //var xas = 1;
                        break;
                }
            }
            else
            {

            }
            _loanWasUpdated = true;
        }

        public object GetInstance(string strFullyQualifiedName)
        {
            Type t = Type.GetType(strFullyQualifiedName);
            return Activator.CreateInstance(t);
        }

        private void SetPropertyValue(object instance, string right, object value)
        {
            var instanceType = instance.GetType();
            var propId = instanceType.GetProperty("Id");

            var className = instanceType.Name;

            var instanceId = propId.GetValue(instance);

            object owningObj = instance;
            var properties = right.Split('.').ToList();

            var propertyCount = properties.Count() - 1;

            var actualProperty = properties[propertyCount];
            // get the object holding the property

            for (int i = 0; i < propertyCount; i++)
            {
                owningObj = owningObj.GetType().GetProperty(properties[i]).GetValue(owningObj);
            }

            // Test this
            if (owningObj.GetType().Name != className)
            {
                if (owningObj.GetType().Name == "LoanContractBorrower")
                {
                    className = owningObj.GetType().Name;
                }
            }


            // obj should now hold the owning object
            var propertyInfo = owningObj.GetType().GetProperty(actualProperty);
            var tempType = propertyInfo.PropertyType.FullName;

            propertyInfo.SetValue(owningObj, GetAPIValue(propertyInfo, value), null);

            if (_loadV1)
            {
                // see if list object is there
                var loanToUpdateProperty = _loanToUpdateV1.GetType().GetProperty(instanceType.Name);

                //if (loanToUpdateProperty == null)
                //{
                //    var newInstance = Activator.CreateInstance(instanceType);
                //    Type genericListType = typeof(List<>).MakeGenericType(instanceType);
                //    var fee = (IList)Activator.CreateInstance(genericListType);
                //    fee.Add(newInstance);
                //    //_loanToUpdate.Applications = new List<typeof(ilistType)>();
                //}

                // This is what needs to get replaced
                switch (className)
                {
                    case "LoanContractBorrower":
                        {
                            var id = ((LenderApiContractsV1.LoanContractBorrower)owningObj).AltId;
                            LenderApiContractsV1.LoanContractApplications appInstance;
                            if (_loanToUpdateV1.Applications == null)
                            {
                                _loanToUpdateV1.Applications = new List<LenderApiContractsV1.LoanContractApplications>();
                            }
                            var isThere = _loanToUpdateV1.Applications.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                appInstance = new LenderApiContractsV1.LoanContractApplications()
                                {
                                    Id = id
                                };
                                _loanToUpdateV1.Applications.Add(appInstance);

                                // Need to figure out which property to add
                                if (appInstance.Borrower == null)
                                {
                                    var newinstance = new LenderApiContractsV1.LoanContractBorrower()
                                    {
                                        AltId = id.ToString(),
                                    };

                                    if (right.ToUpper().Contains("COBORROWER"))
                                    {
                                        appInstance.Coborrower = newinstance;
                                    }
                                    else
                                    {
                                        appInstance.Borrower = newinstance;
                                    }
                                    instance = appInstance;
                                }
                            }
                            else
                                instance = isThere;

                            _loanWasUpdated = true;
                            break;
                        }

                    case "LoanContractApplications":
                        {
                            var newObject = (LenderApiContractsV1.LoanContractApplications)owningObj;
                            var id = ((LenderApiContractsV1.LoanContractApplications)owningObj).ApplicationId;
                            if (_loanToUpdateV1.Applications == null)
                            {
                                _loanToUpdateV1.Applications = new List<LenderApiContractsV1.LoanContractApplications>();
                            }
                            var isThere = _loanToUpdateV1.Applications.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                instance = new LenderApiContractsV1.LoanContractApplications()
                                {
                                    Id = id
                                };
                                _loanToUpdateV1.Applications.Add((LenderApiContractsV1.LoanContractApplications)instance);
                            }
                            break;
                        }

                    case "LoanContractLoanProductDataBuydowns":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.LoanProductData == null)
                            {
                                _loanToUpdateV1.LoanProductData = new LenderApiContractsV1.LoanContractLoanProductData();
                                _loanToUpdateV1.LoanProductData.Buydowns = new List<LenderApiContractsV1.LoanContractLoanProductDataBuydowns>();
                                instance = new LenderApiContractsV1.LoanContractLoanProductDataBuydowns()
                                {
                                    Id = instanceId.ToString(),
                                    BuydownIndex = Convert.ToInt32(indexLevel) + 1
                                };
                                _loanToUpdateV1.LoanProductData.Buydowns.Add((LenderApiContractsV1.LoanContractLoanProductDataBuydowns)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.LoanProductData.Buydowns.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractLoanProductDataBuydowns()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.LoanProductData.Buydowns.Add((LenderApiContractsV1.LoanContractLoanProductDataBuydowns)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;
                            break;
                        }

                    case "LoanContractLoanProductDataHelocRepaymentDrawPeriods":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.LoanProductData == null)
                            {
                                _loanToUpdateV1.LoanProductData = new LenderApiContractsV1.LoanContractLoanProductData();
                                _loanToUpdateV1.LoanProductData.HelocRepaymentDrawPeriods = new List<LenderApiContractsV1.LoanContractLoanProductDataHelocRepaymentDrawPeriods>();
                                instance = new LenderApiContractsV1.LoanContractLoanProductDataHelocRepaymentDrawPeriods()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.LoanProductData.HelocRepaymentDrawPeriods.Add((LenderApiContractsV1.LoanContractLoanProductDataHelocRepaymentDrawPeriods)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.LoanProductData.HelocRepaymentDrawPeriods.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractLoanProductDataHelocRepaymentDrawPeriods()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.LoanProductData.HelocRepaymentDrawPeriods.Add((LenderApiContractsV1.LoanContractLoanProductDataHelocRepaymentDrawPeriods)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;
                            break;
                        }

                    case "LoanContractRateLockPurchaseAdvicePayouts":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.RateLock == null)
                            {
                                _loanToUpdateV1.RateLock = new LenderApiContractsV1.LoanContractRateLock();
                                _loanToUpdateV1.RateLock.PurchaseAdvicePayouts = new List<LenderApiContractsV1.LoanContractRateLockPurchaseAdvicePayouts>();
                                instance = new LenderApiContractsV1.LoanContractRateLockPurchaseAdvicePayouts()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.RateLock.PurchaseAdvicePayouts.Add((LenderApiContractsV1.LoanContractRateLockPurchaseAdvicePayouts)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.RateLock.PurchaseAdvicePayouts.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractRateLockPurchaseAdvicePayouts()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.RateLock.PurchaseAdvicePayouts.Add((LenderApiContractsV1.LoanContractRateLockPurchaseAdvicePayouts)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }

                            }
                            _loanWasUpdated = true;
                        }
                        break;

                    case "LoanContractRateLockLockRequestBorrowers":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.RateLock == null)
                            {
                                _loanToUpdateV1.RateLock = new LenderApiContractsV1.LoanContractRateLock();
                                _loanToUpdateV1.RateLock.LockRequestBorrowers = new List<LenderApiContractsV1.LoanContractRateLockLockRequestBorrowers>();
                                instance = new LenderApiContractsV1.LoanContractRateLockLockRequestBorrowers()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.RateLock.LockRequestBorrowers.Add((LenderApiContractsV1.LoanContractRateLockLockRequestBorrowers)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.RateLock.PurchaseAdvicePayouts.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractRateLockLockRequestBorrowers()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.RateLock.LockRequestBorrowers.Add((LenderApiContractsV1.LoanContractRateLockLockRequestBorrowers)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }

                            }
                            _loanWasUpdated = true;

                        }
                        break;
                    case "LoanContractPurchaseCredits":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.PurchaseCredits == null)
                            {
                                _loanToUpdateV1.PurchaseCredits = new List<LenderApiContractsV1.LoanContractPurchaseCredits>();
                                instance = new LenderApiContractsV1.LoanContractPurchaseCredits()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.PurchaseCredits.Add((LenderApiContractsV1.LoanContractPurchaseCredits)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.PurchaseCredits.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractPurchaseCredits()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.PurchaseCredits.Add((LenderApiContractsV1.LoanContractPurchaseCredits)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;
                        }
                        break;

                    case "LoanContractSettlementServiceCharges":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.SettlementServiceCharges == null)
                            {
                                _loanToUpdateV1.SettlementServiceCharges = new List<LenderApiContractsV1.LoanContractSettlementServiceCharges>();
                                instance = new LenderApiContractsV1.LoanContractSettlementServiceCharges()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.SettlementServiceCharges.Add((LenderApiContractsV1.LoanContractSettlementServiceCharges)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.SettlementServiceCharges.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractSettlementServiceCharges()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.SettlementServiceCharges.Add((LenderApiContractsV1.LoanContractSettlementServiceCharges)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;
                        }
                        break;

                    case "LoanContractStateDisclosureNewYorkPrimaryLenders":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.StateDisclosure == null)
                            {
                                _loanToUpdateV1.StateDisclosure = new LenderApiContractsV1.LoanContractStateDisclosure();
                                _loanToUpdateV1.StateDisclosure.NewYorkPrimaryLenders = new List<LenderApiContractsV1.LoanContractStateDisclosureNewYorkPrimaryLenders>();
                                instance = new LenderApiContractsV1.LoanContractStateDisclosureNewYorkPrimaryLenders()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.StateDisclosure.NewYorkPrimaryLenders.Add((LenderApiContractsV1.LoanContractStateDisclosureNewYorkPrimaryLenders)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.StateDisclosure.NewYorkPrimaryLenders.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractStateDisclosureNewYorkPrimaryLenders()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.StateDisclosure.NewYorkPrimaryLenders.Add((LenderApiContractsV1.LoanContractStateDisclosureNewYorkPrimaryLenders)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;
                        }
                        break;

                    case "LoanContractClosingDocumentAntiSteeringLoanOptions":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.ClosingDocument == null)
                            {
                                _loanToUpdateV1.ClosingDocument = new LenderApiContractsV1.LoanContractClosingDocument();
                                _loanToUpdateV1.ClosingDocument.AntiSteeringLoanOptions = new List<LenderApiContractsV1.LoanContractClosingDocumentAntiSteeringLoanOptions>();
                                instance = new LenderApiContractsV1.LoanContractClosingDocumentAntiSteeringLoanOptions()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.ClosingDocument.AntiSteeringLoanOptions.Add((LenderApiContractsV1.LoanContractClosingDocumentAntiSteeringLoanOptions)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.ClosingDocument.AntiSteeringLoanOptions.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractClosingDocumentAntiSteeringLoanOptions()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.ClosingDocument.AntiSteeringLoanOptions.Add((LenderApiContractsV1.LoanContractClosingDocumentAntiSteeringLoanOptions)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;

                        }
                        break;
                    case "LoanContractFhaVaLoanEnergyEfficientMortgageItems":
                        {
                            var indexLevel = instanceId.ToString().Split('/')[1];
                            if (_loanToUpdateV1.FhaVaLoan == null)
                            {
                                _loanToUpdateV1.FhaVaLoan = new LenderApiContractsV1.LoanContractFhaVaLoan();
                                _loanToUpdateV1.FhaVaLoan.EnergyEfficientMortgageItems = new List<LenderApiContractsV1.LoanContractFhaVaLoanEnergyEfficientMortgageItems>();
                                instance = new LenderApiContractsV1.LoanContractFhaVaLoanEnergyEfficientMortgageItems()
                                {
                                    Id = instanceId.ToString()
                                };
                                _loanToUpdateV1.FhaVaLoan.EnergyEfficientMortgageItems.Add((LenderApiContractsV1.LoanContractFhaVaLoanEnergyEfficientMortgageItems)instance);
                            }
                            else
                            {
                                var isThere = _loanToUpdateV1.FhaVaLoan.EnergyEfficientMortgageItems.Where(t => t.Id == instanceId.ToString()).FirstOrDefault();
                                if (isThere == null)
                                {
                                    instance = new LenderApiContractsV1.LoanContractFhaVaLoanEnergyEfficientMortgageItems()
                                    {
                                        Id = instanceId.ToString()
                                    };
                                    _loanToUpdateV1.FhaVaLoan.EnergyEfficientMortgageItems.Add((LenderApiContractsV1.LoanContractFhaVaLoanEnergyEfficientMortgageItems)instance);
                                }
                                else
                                {
                                    instance = isThere;
                                }
                            }
                            _loanWasUpdated = true;

                        }
                        break;


                    case "LoanContractHud1EsHud1EsDates":
                        {
                            var id = ((LenderApiContractsV1.LoanContractHud1EsHud1EsDates)owningObj).Id;
                            if (_loanToUpdateV1.Hud1Es == null)
                            {
                                _loanToUpdateV1.Hud1Es = new LenderApiContractsV1.LoanContractHud1Es();
                            }
                            if (_loanToUpdateV1.Hud1Es.Hud1EsDates == null)
                            {
                                _loanToUpdateV1.Hud1Es.Hud1EsDates = new List<LenderApiContractsV1.LoanContractHud1EsHud1EsDates>();
                            }
                            var isThere = _loanToUpdateV1.Hud1Es.Hud1EsDates.Where(t => t.Id == id.ToString()).FirstOrDefault();
                            if (isThere == null)
                            {
                                instance = new LenderApiContractsV1.LoanContractHud1EsHud1EsDates()
                                {
                                    Id = id.ToString()
                                };
                                _loanToUpdateV1.Hud1Es.Hud1EsDates.Add((LenderApiContractsV1.LoanContractHud1EsHud1EsDates)instance);
                            }
                            else
                                instance = isThere;

                            _loanWasUpdated = true;
                            break;
                        }


                    default:
                        System.Diagnostics.Debug.WriteLine(className);
                        System.Diagnostics.Debug.WriteLine("HERE");
                        break;

                }

            }
            // Now work with a new application on loanToUpdate
            if (propertyCount == 0)
            {
                propertyInfo.SetValue(instance, GetAPIValue(propertyInfo, value), null);
            }
            else
            {
                // check to see if the main object being added is already in the updatedLoan schema
                owningObj = instance;
                object nextObj = instance;

                // Walk through the properties (less last one) to get object information
                for (int i = 0; i < propertyCount; i++)
                {
                    var activeProperty = properties[i];                     // Name of new class
                    var owningType = owningObj.GetType();                   // get type of class
                    propertyInfo = owningType.GetProperty(activeProperty);  // Property info on new class
                    nextObj = propertyInfo.GetValue(owningObj);             // get value

                    if (nextObj == null)  // the updated loan object needs an instance of new class
                    {
                        if (propertyInfo != null)  // and we have property info of new class
                        {
                            var newInstance = Activator.CreateInstance(propertyInfo.PropertyType);  // Create new instance

                            propertyInfo.SetValue(owningObj, newInstance, null);                    // assign instance to owning object
                            nextObj = propertyInfo.GetValue(owningObj);                             // get value again
                            owningObj = nextObj;
                        }
                    }
                    else
                    {
                        owningObj = nextObj;
                    }
                }

                owningObj = instance;
                for (int i = 0; i < propertyCount; i++)
                {
                    owningObj = owningObj.GetType().GetProperty(properties[i]).GetValue(owningObj);
                }

                // obj should now hold the owning object
                propertyInfo = owningObj.GetType().GetProperty(actualProperty);

                propertyInfo.SetValue(owningObj, GetAPIValue(propertyInfo, value), null);

                //var thing = _loanToUpdate;

                _loanWasUpdated = true;
            }
        }

        private void SetPropertyValue(string propertyName, object value)
        {
            object owningObj;
            if (_loadV1)
                owningObj = _loanV1;
            else
                owningObj = _loanV3;

            var properties = propertyName.Split('.').ToList();

            var propertyCount = properties.Count() - 1;

            var actualProperty = properties[propertyCount];
            // get the object holding the property

            for (int i = 0; i < propertyCount; i++)
            {
                owningObj = owningObj.GetType().GetProperty(properties[i]).GetValue(owningObj);
            }

            // obj should now hold the owning object
            var propertyInfo = owningObj.GetType().GetProperty(actualProperty);

            var newType = ConvertValue(propertyInfo.PropertyType, value);

            propertyInfo.SetValue(owningObj, newType, null);

            if (propertyCount == 0)
            {
                //propertyInfo.SetValue(_loanToUpdate, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                if (_loadV1)
                    propertyInfo.SetValue(_loanToUpdateV1, newType, null);
                else
                    propertyInfo.SetValue(_loanToUpdateV3, newType, null);
                _loanWasUpdated = true;
            }
            else
            {
                // check to see if the main object being added is already in the updatedLoan schema
                object nextObj;
                if (_loadV1)
                {
                    owningObj = _loanToUpdateV1;
                    nextObj = _loanToUpdateV1;
                }
                else
                {
                    owningObj = _loanToUpdateV3;
                    nextObj = _loanToUpdateV3;
                }

                // Walk through the properties (less last one) to get object information
                for (int i = 0; i < propertyCount; i++)
                {
                    var activeProperty = properties[i];                     // Name of new class
                    var owningType = owningObj.GetType();                   // get type of class
                    propertyInfo = owningType.GetProperty(activeProperty);  // Property info on new class
                    nextObj = propertyInfo.GetValue(owningObj);             // get value

                    if (nextObj == null)  // the updated loan object needs an instance of new class
                    {
                        if (propertyInfo != null)  // and we have property info of new class
                        {
                            var newInstance = Activator.CreateInstance(propertyInfo.PropertyType);  // Create new instance
                            propertyInfo.SetValue(owningObj, newInstance, null);                    // assign instance to owning object
                            nextObj = propertyInfo.GetValue(owningObj);                             // get value again
                            owningObj = nextObj;
                        }
                    }
                    else
                    {
                        owningObj = nextObj;
                    }
                }

                if (_loadV1)
                    owningObj = _loanToUpdateV1;
                else
                    owningObj = _loanToUpdateV3;

                for (int i = 0; i < propertyCount; i++)
                {
                    owningObj = owningObj.GetType().GetProperty(properties[i]).GetValue(owningObj);
                }

                // obj should now hold the owning object
                propertyInfo = owningObj.GetType().GetProperty(actualProperty);

                newType = ConvertValue(propertyInfo.PropertyType, value);


                propertyInfo.SetValue(owningObj, newType, null);
                _loanWasUpdated = true;
            }
        }
        #endregion

        #region Set Custom Field Stuff
        public void SetCustomFields(string name, string value)
        {
            PrepCustomFields();   // THIS IS FOR UPDATE

            var foundField = CustomFieldExists(name);  // see if in the original loan pulled from Encompass

            if (foundField != null)  
            {
                // Field is already in loan so just update the current value
                if (foundField.DateValue != null)
                {
                    foundField.DateValue = Convert.ToDateTime(value);
                }
                else
                {
                    if (foundField.NumericValue != null)
                    {
                        foundField.NumericValue = Convert.ToDouble(value);
                    }
                    else
                    {
                        foundField.StringValue = value;
                    }
                }

                //var temp = _loanToUpdate.CustomFields;
                // THIS IS FOR UPDATE
                // check to see if it is already in updated loan

                if (_loadV3)
                { }
                else
                {
                    var isAlreadyThere = UpdateCustomFieldsExist(name);
                    if (isAlreadyThere == null) // not there so add it to the loanUpdated contract
                    {
                        if (string.IsNullOrWhiteSpace(foundField.Id))
                        {
                            foundField.Id = foundField.FieldName;
                        }
                        if (_loadV1)
                            _loanToUpdateV1.CustomFields.Add(foundField);
                        //else
                            //_loanToUpdateV3.CustomFields.Add(foundField);  // THIS needs to be converted
                    }
                    else
                    {
                        // already in the loanUpdated contract so just change it's value to
                        isAlreadyThere.StringValue = value;
                    }

                    _loanWasUpdated = true;
                }
            }
            else  
            {
                if (_loadV3)
                { }
                else
                { 
                    // Field is NOT in the loan that was loaded so we need to look in
                    // loan META and get that definition and use it only in the _loanUpdated contract
                    //var temp = _loanToUpdate.CustomFields;
                    var newFoundField = CustomFieldMetaExists(name); //  _customFields.Where(t => t.Id.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();  // the original loan
                    if (newFoundField != null)
                    {
                        // The custom field has a meta data definition so...

                        // add it to the original loan

                        var add = new LenderApiContractsV1.LoanContractCustomFields()
                        {
                            //Id = $"CustomField/{_loan.CustomFields.Count + 1}",
                            FieldName = newFoundField.Id,
                            StringValue = value
                        };
                        _loanV1.CustomFields.Add(add);

                        // double checking to make sure it is not there before adding

                        List<LenderApiContractsV1.LoanContractCustomFields> items = _loanToUpdateV1.CustomFields.FindAll(t => t.FieldName.ToUpper() == newFoundField.Id.ToUpper());
                        foreach (var item in items)
                            _loanToUpdateV1.CustomFields.Remove(item);   // _loanToUpdate.CustomFields.RemoveAll(items);  Can't get this to work


                        //add.Id = null;  // let the system create the field with proper ID
                        _loanToUpdateV1.CustomFields.Add(add);

                        _loanWasUpdated = true;
                    }
                }
            }
        }
        public void SetCustomFields(string name, int value)
        {
            PrepCustomFields();   // THIS IS FOR UPDATE

            var foundField = CustomFieldExists(name); // see if in the original loan pulled from Encompass

            if (foundField != null)
            {
                foundField.NumericValue = value;
                foundField.StringValue = value.ToString();

                // THIS IS FOR UPDATE
                // check to see if it is already in updated loan
                var isAlreadyThere = UpdateCustomFieldsExist(name);
                if (isAlreadyThere == null) // not there so add it to the loanUpdated contract
                {
                    if (string.IsNullOrWhiteSpace(foundField.Id))
                    {
                        foundField.Id = foundField.FieldName;
                    }

                    if (_loadV3) { }
                    else
                        _loanToUpdateV1.CustomFields.Add(foundField);
                }
                else
                {
                    isAlreadyThere.NumericValue = value;
                }

                _loanWasUpdated = true;
            }
            else
            {
                if (_loadV3)
                { }
                else
                {
                    var newFoundField = CustomFieldMetaExists(name); // _customFields.Where(t => t.Id.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();
                    if (newFoundField != null)
                    {
                        var add = new LenderApiContractsV1.LoanContractCustomFields()
                        {
                            //Id = $"CustomField/{_loan.CustomFields.Count + 1}",
                            FieldName = name.ToUpper(),
                            NumericValue = value,
                            StringValue = value.ToString()
                        };
                        _loanV1.CustomFields.Add(add);

                        // double checking to make sure it is not there before adding

                        List<LenderApiContractsV1.LoanContractCustomFields> items = _loanToUpdateV1.CustomFields.FindAll(t => t.FieldName.ToUpper() == newFoundField.Id.ToUpper());
                        foreach (var item in items)
                            _loanToUpdateV1.CustomFields.Remove(item);   // _loanToUpdate.CustomFields.RemoveAll(items);  Can't get this to work


                        //add.Id = null;
                        _loanToUpdateV1.CustomFields.Add(add);

                        _loanWasUpdated = true;
                    }
                }
            }
        }
        public void SetCustomFields(string name, bool value)
        {
            SetCustomFields(name, value ? "Y" : "N");
        }
        public void SetCustomFields(string name, double value)
        {
            PrepCustomFields();   // THIS IS FOR UPDATE

            var foundField = CustomFieldExists(name); // see if in the original loan pulled from Encompass

            if (foundField != null)
            {
                foundField.NumericValue = value;
                foundField.StringValue = value.ToString();

                // THIS IS FOR UPDATE
                // check to see if it is already in updated loan
                var isAlreadyThere = UpdateCustomFieldsExist(name);
                if (isAlreadyThere == null) // not there so add it
                {
                    if (string.IsNullOrWhiteSpace(foundField.Id))
                    {
                        foundField.Id = foundField.FieldName;
                    }

                    if (_loadV3) { }
                    else
                        _loanToUpdateV1.CustomFields.Add(foundField);
                }
                else
                {
                    isAlreadyThere.NumericValue = value;
                }

                _loanWasUpdated = true;
            }
            else
            {
                // Field is NOT in the loan that was loaded so we need to look in
                // loan META and get that definition and use it only in the _loanUpdated contract

                if (_loadV3)
                { }
                else
                {
                    var newFoundField = CustomFieldMetaExists(name); // _customFields.Where(t => t.Id.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();
                    if (newFoundField != null)
                    {
                        var add = new LenderApiContractsV1.LoanContractCustomFields()
                        {
                            //Id = $"CustomField/{_loan.CustomFields.Count + 1}",
                            FieldName = name.ToUpper(),
                            NumericValue = value,
                            StringValue = value.ToString()
                        };
                        _loanV1.CustomFields.Add(add);

                        // double checking to make sure it is not there before adding

                        List<LenderApiContractsV1.LoanContractCustomFields> items = _loanToUpdateV1.CustomFields.FindAll(t => t.FieldName.ToUpper() == newFoundField.Id.ToUpper());
                        foreach (var item in items)
                            _loanToUpdateV1.CustomFields.Remove(item);   // _loanToUpdate.CustomFields.RemoveAll(items);  Can't get this to work


                        //                    add.Id = null;  // let the system create the field with proper ID
                        _loanToUpdateV1.CustomFields.Add(add);

                        _loanWasUpdated = true;
                    }
                }
            }
        }
        public void SetCustomFields(string name, DateTime value)
        {
            PrepCustomFields();   // THIS IS FOR UPDATE

            var foundField = CustomFieldExists(name); // see if in the original loan pulled from Encompass

            if (foundField != null)
            {
                foundField.DateValue = value;

                // THIS IS FOR UPDATE
                // check to see if it is already in updated loan
                var isAlreadyThere = UpdateCustomFieldsExist(name);
                if (isAlreadyThere == null) // not there so add it
                {
                    if (string.IsNullOrWhiteSpace(foundField.Id))
                    {
                        foundField.Id = foundField.FieldName;
                    }

                    _loanToUpdateV1.CustomFields.Add(foundField);
                }
                else
                {
                    isAlreadyThere.DateValue = value;
                }

                _loanWasUpdated = true;
            }
            else
            {
                if (_loadV3)
                { }
                else
                {
                    // Field is NOT in the loan that was loaded so we need to look in
                    // loan META and get that definition and use it only in the _loanUpdated contract
                    var newFoundField = CustomFieldMetaExists(name); //  _customFields.Where(t => t.Id.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();
                    if (newFoundField != null)
                    {
                        var add = new LenderApiContractsV1.LoanContractCustomFields()
                        {
                            //                        Id = $"CustomField/{_loan.CustomFields.Count + 1}",
                            FieldName = name.ToUpper(),
                            DateValue = value
                        };
                        _loanV1.CustomFields.Add(add);

                        // double checking to make sure it is not there before adding

                        List<LenderApiContractsV1.LoanContractCustomFields> items = _loanToUpdateV1.CustomFields.FindAll(t => t.FieldName.ToUpper() == newFoundField.Id.ToUpper());
                        foreach (var item in items)
                            _loanToUpdateV1.CustomFields.Remove(item);   // _loanToUpdate.CustomFields.RemoveAll(items);  Can't get this to work

                        //                    add.Id = null;  // let the system create the field with proper ID
                        _loanToUpdateV1.CustomFields.Add(add);

                        _loanWasUpdated = true;
                    }
                }
            }

        }
        #endregion

        #region Translation Stuff
        public CustomFieldMeta CustomFieldMetaExists(string name)
        {
            var value = _customFields.Where(t => t.Id.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();
            return value;
        }
        public LenderApiContractsV1.LoanContractCustomFields CustomFieldExists(string id)
        {
            var value = _loanV1.CustomFields.Where(t => t.FieldName.Trim().ToUpper() == id.Trim().ToUpper()).FirstOrDefault();
            return value;
        }
        public LenderApiContractsV3.CustomFieldContract CustomFieldV3Exists(string id)
        {
            var value = _loanV3.CustomFields.Where(t => t.FieldName.Trim().ToUpper() == id.Trim().ToUpper()).FirstOrDefault();
            return value;
        }
        public LenderApiContractsV1.LoanContractCustomFields UpdateCustomFieldsExist(string name)
        {
            var value = _loanToUpdateV1.CustomFields.Where(t => t.FieldName.Trim().ToUpper() == name.Trim().ToUpper()).FirstOrDefault();
            return value;
        }
        public bool CustomFieldDefined(string id)
        {
            var value = _customFields.Where(t => t.Id.Trim().ToUpper() == id.Trim().ToUpper()).FirstOrDefault() != null;
            return value;
        }
        public void PrepCustomFields()
        {
            if (_customFields == null)
            {
                SetCustomFields();
            }

            if (_loadV3)
            {
                if (_loanToUpdateV3.CustomFields == null)
                    _loanToUpdateV3.CustomFields = new List<LenderApiContractsV3.CustomFieldContract>();
            }
            else
            {
                if (_loanToUpdateV1.CustomFields == null)                                   // THIS IS FOR UPDATE
                {
                    _loanToUpdateV1.CustomFields = new List<LenderApiContractsV1.LoanContractCustomFields>();    // THIS IS FOR UPDATE
                }
            }
        }
        public void SetCustomFields()
        {
            _customFields = GetCustomFields().Result;
        }
        
        //public string MainField(string id)
        //{
        //    return MainField<string>(id);
        //}
        public T MainField<T>(string id)
        {
            //if (id.StartsWith("CX.TQLGS"))
            //{
               // var stopHere = true;
            //}

            _lastCallId = id;
            var tempId = id;

            // check custom fields first
            if (id.StartsWith("CX.") || (id.StartsWith("CUST") && id.EndsWith("FV")))
            {
                return CustomFields<T>(id);
            }

            if (id.Contains("#"))
            {
                var spliiter = id.Split('#');
                tempId = spliiter[0];
            }

            if (_fields.ContainsKey(tempId))
            {
                APISchema item = _fields[tempId];

                //if (item.Type == null)  // redirect
                //{
                //    // translate
                //    return default(T);
                //}
                //else
                //{
                    return ProcessObject<T>(item.Meta, id);   //return ProcessObject<T>(item, id);
                //}
            }
            else if (_dynamicFields.Count > 0)
            {
                foreach (var dyno in _dynamicFields)
                {
                    var matched = System.Text.RegularExpressions.Regex.Match(id, dyno.Key);
                    if (matched.Success)
                    {
                        // pull the indexer out
                        var innerIndex = Convert.ToInt32(matched.Groups[2].Value) + 1;

                        var schema = dyno.Value;

                        var tempMeta = schema.Meta.Replace("(X)", $"({innerIndex})");    // DO NOT REPLACE THE META - it will screw things up!

                        return ProcessObject<T>(tempMeta);
                    }
                }
            }

            // check virtual fields
            if (_virtualFields.Count > 0)
            {
                if (_virtualFields.ContainsKey(id))
                {
                    return ReturnValue<T>(_virtualFields[id]);
                }
            }


            return default(T);
        }

        public object GetVirtualFieldValue(string id)
        {
            if (_virtualFields.Count > 0)
            {
                if (_virtualFields.ContainsKey(id))
                {
                    return ReturnValue<object>(_virtualFields[id]);
                }
            }
            return null;
        }

        public void LoadVirtualFields()
        {
            var fields = (JObject)_loanV1.VirtualFields;
            foreach (var property in fields.Properties())
            {
                if (!_virtualFields.ContainsKey(property.Name))
                {
                    _virtualFields.Add(property.Name, property.Value.ToString());
                }
            }
        }
        public void LoadVirtualFields(object fields)  // for V3 loans only
        {
            var walkFields = ((JToken)fields).Children();
            // walk through the fields
            foreach (JProperty property in walkFields)
            {
                if (!_virtualFields.ContainsKey(property.Name))
                {
                    _virtualFields.Add(property.Name, property.Value.ToString());
                }
            }
        }
        public void ClearVirtualFields() => _virtualFields.Clear();

        public T CustomFields<T>(string name)
        {
            if (_customFields == null)
            {
                _customFields = GetCustomFields().Result;
            }

            if (_loadV3)
            {
                LenderApiContractsV3.CustomFieldContract foundField = CustomFieldV3Exists(name);
                if (foundField != null)
                {
                    return (T)(object)foundField.Value;
                }
                else
                    return default(T);
                //                else  // if not,now see if it is in the meta 
                //                {
                //                    var tempt = _customFields.Where(t => t.Id.ToUpper() == name.ToUpper());
                //                    return default(T);
                //                }
            }
            else
            {
                var foundField = CustomFieldExists(name);
                if (foundField != null)
                {
                    return (T)(object)foundField.StringValue;
                } // if not,now see if it is in the meta 
                else
//                {
//                    var tempt = _customFields.Where(t => t.Id.ToUpper() == name.ToUpper());
                    return default(T);
//                }
            }
        }
//        private T ProcessObject<T>(APISchema schema, string id = "")
//        {
//            return ProcessObject<T>(schema.Meta, id);
//        }
        private T ProcessObject<T>(string item, string id = "")
        {
            var tempItem = item;
            var bracketIndex = -1;
            bool withPoundSign = false;

            if (id.Contains("#"))
            {
                var spliiter = id.Split('#');
                id = spliiter[0];
                bracketIndex = Convert.ToInt32(spliiter[1]) - 1;
                withPoundSign = true;
            }

            try
            {
                var innerIndex = ParseInnerIndexer(ref tempItem);

                if (tempItem.Contains("{"))
                {
                    string left, right;

                    bracketIndex = ParseWithInnerBraces(tempItem, withPoundSign, bracketIndex, out left, out right);

                    //PropertyInfo q = null;
                    //object qq = null;
                    IList property = null;

                    if (_loadV3)
                    {
                        //    q = _loanV3.GetType().GetProperty("Applications");
                        //    qq = q.GetValue(_loanV3);
                        property = (IList)_loanV3.GetType().GetProperty(left).GetValue(_loanV3);
                    }
                    else
                    {
                        //    q = _loan.GetType().GetProperty("Applications");
                        //    qq = q.GetValue(_loan);
                        property = (IList)_loanV1.GetType().GetProperty(left).GetValue(_loanV1);
                    }

                    if (property.Count > bracketIndex)
                    {
                        var arrayProperty = property[bracketIndex];

                        // Add here is there is a []
                        if (right.Contains("["))
                        {
                            if (!right.StartsWith("["))
                                return ProcessList<T>(arrayProperty, right, innerIndex);
                        }
                        else
                        {
                            return GetPropertyValue<T>(arrayProperty, right, id);
                        }
                    }
                    else
                    {
                        return default(T);
                    }
                }
                else if (tempItem.Contains("["))
                {
                    if (_loadV3)
                        return ProcessList<T>(_loanV3, tempItem, innerIndex);
                    else
                        return ProcessList<T>(_loanV1, tempItem, innerIndex);
                }
                else
                {
                    if (_loadV3)
                    {
                        var retValue = GetPropertyValue<T>(_loanV3, tempItem, id);
                        return retValue;
                    }
                    else
                    {
                        var retValue = GetPropertyValue<T>(_loanV1, tempItem, id);
                        return retValue;
                    }
                }
            }
            catch (Exception exp)
            {
                System.Diagnostics.Debug.WriteLine($"Specified Property (possible LIST object) [{_lastCallId}] errored with parsing error for [{tempItem}] for object [{item}] - exception [{exp.Message}]");
            }

            return default(T);
        }
        private T ProcessList<T>(object loanContext, string item, int indexer)
        {
            var left = item.Substring(0, item.IndexOf("["));
            var leftLength = left.Length;
            var temp = item.Substring(leftLength);
            var middle = temp.Substring(0, temp.IndexOf("]") + 1);
            var right = item.Substring(leftLength).Replace(middle, string.Empty).Substring(1);

            var property = GetPropertyValue<IList>(loanContext, left, "");

            if (property == null)
            {
                System.Diagnostics.Debug.WriteLine($"Specified Property [{_lastCallId}] does NOT exist [{left}] for object [{item}]");
                //                throw new Exception($"Specified Property does NOT exist [{left}]");
                return default(T);
            }

            if (indexer != -1 && middle == "[]")  // just pull the INDEXER item
            {
                if (property.Count > indexer)
                {
                    var theObject = property[indexer];
                    var foundValue = theObject.GetType()?.GetProperty(right)?.GetValue(theObject)?.ToString();

                    return ReturnValue<T>(foundValue);
                }
                else  // return null
                {
                    return default(T);
                }
            }
            else
            {
                var foundObject = FindIndexedObject(property, middle, right, indexer);
                if (foundObject != null)
                {
                    var foundProp = foundObject.GetType()?.GetProperty(right);
                    var foundValue = foundProp?.GetValue(foundObject);
                    return ReturnValue<T>(foundValue);
                }

                ReturnFinalValue<T>();
            }
            return default(T);
        }
        private T ReturnValue<T>(object foundValue)
        {
            if (foundValue == null)
            {
                return default(T);
            }
            else
            {
                try
                {
                    return (T)Convert.ChangeType(foundValue, typeof(T));
                }
                catch  // it really isn't nullable
                {
                    return (T)Convert.ChangeType(foundValue, Nullable.GetUnderlyingType(typeof(T)));
                }
            }
        }
        private object GetAPIValue(PropertyInfo info, object value)
        {
            try
            {
                return Convert.ChangeType(value, info.PropertyType);
            }
            catch  // it really isn't nullable
            {
                return Convert.ChangeType(value, Nullable.GetUnderlyingType(info.PropertyType));
            }
        }
        private T ReturnFinalValue<T>()
        {
            try
            {
                return (T)Convert.ChangeType(string.Empty, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        private T GetPropertyValue<T>(object obj, string propertyName, string id)
        {
            //if (id == "2")
            //{
            //    if (!char.IsUpper(propertyName[0]))
            //    {
            //        propertyName = "BaseLoanAmount";
            //        var tt = propertyName.Split('.').Select(s => obj?.GetType()?.GetProperty(s));
            //    }
            //}
            //try
            //{
            //    foreach (var prop in propertyName.Split('.').Select(s => obj.GetType().GetProperty(s)))
            //        obj = prop.GetValue(obj, null);

            //    return (T)obj;
            //}
            //catch (Exception ex)
            //{
            //    var asasd = ex.Message;
            //    return default(T);
            //}
            object tempDisp = null;
            try
            {
                foreach (var prop in propertyName.Split('.').Select(s => obj?.GetType()?.GetProperty(s)))
                {
                    if (prop == null)
                    {
                        System.Diagnostics.Debug.WriteLine($"[{_lastCallId}] - property [{propertyName}] = Not Found - Last Found was [{tempDisp?.GetType().Name}]");
                        //_badFields.Add(new Tuple<string, string>(id, (string)obj));
                        obj = null;
                        break;
                    }
                    else
                        obj = prop.GetValue(obj, null);

                    tempDisp = obj;
                }

                if (typeof(T) == typeof(string))
                {
                    return (T)(object)Convert.ToString(obj);
                }

                return (T)obj;
            }
            catch (InvalidCastException cExp)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine($"[{_lastCallId}] - property [{propertyName}] = Error: {cExp.Message} - {obj}");
#endif

                if (typeof(T) == typeof(string))
                {
                    return (T)(object)string.Empty;
                }
                return default(T);

            }
            catch //(Exception e)
            {
                if (typeof(T) == typeof(string))
                {
                    return (T)(object)string.Empty;
                }
                return default(T);
            }
        }
        #endregion

        private bool PropertyExists(string propertyName)
        {
            try
            {
                object obj;

                if (_loadV1)
                    obj = _loanV1;
                else
                    obj = _loanV3;

                foreach (var prop in propertyName.Split('.').Select(s => obj.GetType().GetProperty(s)))
                {
                    if (prop != null)
                    {
                        obj = prop.GetValue(obj, null);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true; // (obj != null);
            }
            catch
            {
                return false;
            }
        }

        #region Parsing Routines
        public int ParseWithInnerBraces(string source, bool withPound, int index, out string left, out string right)
        {
            left = source.Substring(0, source.IndexOf("{"));
            var temp = source.Replace(left, string.Empty);
            var middle = temp.Substring(0, temp.IndexOf("}") + 1);
            right = source.Replace(left, string.Empty).Replace(middle, string.Empty).Substring(1);
            var innerIndex = middle.Replace("{", string.Empty).Replace("}", string.Empty);

            return innerIndex.ToUpper() == "CURRENT" ? !withPound ? 0 : index : Convert.ToInt32(innerIndex);
        }
        public int ParseInnerIndexer(ref string item)
        {
            var tempindexer = -1;

            if (item.Contains("(") && item.Contains(")"))
            {
                var leftIndexer = item.Substring(0, item.IndexOf("("));
                var leftIndexerLength = leftIndexer.Length;
                var tempIndexer = item.Substring(leftIndexerLength);
                var middleIndexer = tempIndexer.Substring(0, tempIndexer.IndexOf(")") + 1);
                // now remove indexer from the item
                item = item.Replace(middleIndexer, "");
                middleIndexer = middleIndexer.Replace("(", "").Replace(")", "");
                tempindexer = Convert.ToInt32(middleIndexer.Trim()) - 1;  // this may need to be change back without -1
            }

            return tempindexer;

        }
        public string[] ParseInnerBrackets(string innerData)
        {
            var left = innerData.Substring(0, innerData.IndexOf("["));
            var leftLength = left.Length;
            var temp = innerData.Substring(leftLength);
            var middle = temp.Substring(0, temp.IndexOf("]") + 1);
            var right = innerData.Substring(leftLength).Replace(middle, string.Empty).Substring(1);
            return new[] { left, middle, right };
        }
        #endregion

        protected void UpdateInnerProperties(object owningObject, string propertyList)
        {
            propertyList = propertyList.Replace("[", "").Replace("]", "");

            if (!string.IsNullOrEmpty(propertyList))
            {
                var setTypes = propertyList.Split('|');
                foreach (string declaredType in setTypes)
                {
                    var items = declaredType.Split('=');
                    // get each property in ITEMS[0]
                    var propertyToSetInfo = owningObject.GetType().GetProperty(items[0]);
                    // set the property in ITEMS[1]
                    propertyToSetInfo.SetValue(owningObject, GetAPIValue(propertyToSetInfo, items[1]), null);
                }
            }
        }

        public async Task<List<CustomFieldMeta>> GetCustomFields()
        {
            try
            {
                if (_customFields == null)
                {
                    var provider = new LoanProviderService(_accessToken);
                    //if (_loadV3)
                    //{
                    //    var results = await provider.GetCustomFieldsAsync(true);
                    //    _customFields = results.Item1;
                    //}
                    //else
                    //{
                    //    var results = await provider.GetCustomFieldsAsync();
                    //    _customFields = results.Item1;
                    //}
                    var results = await provider.GetCustomFieldsAsync(_loadV3);
                    _customFields = results.Item1;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            //            _lastCode = System.Net.HttpStatusCode.NotImplemented;

            return _customFields;
        }

        private object FindIndexedObject(IList context, string typeProperties, string findProperty, int indexer)
        {
            var processCount = 0;
            var innerProps = typeProperties.Replace("[", string.Empty).Replace("]", string.Empty).Split('|');

            foreach (var thing in context)
            {
                var useThisObject = true;
                foreach (var theProperty in innerProps)
                {
                    var theItem = theProperty.Split('=');

                    var foundPropertyValue = thing.GetType()?.GetProperty(theItem[0])?.GetValue(thing)?.ToString();
                    if (foundPropertyValue == null)
                    {
                        if (!string.IsNullOrEmpty(theItem[1]))
                        {
                            useThisObject = false;
                            break;
                        }
                    }
                    else
                    {
                        if (foundPropertyValue != theItem[1])
                        {
                            useThisObject = false;
                            break;
                        }
                    }

                }

                if (useThisObject)
                {
                    if (indexer == -1 || indexer == processCount++)  // may be able to get rid of -1 test
                    {
                        return thing;
                    }
                }
            }
            return null;
        }

        private void CheckApplicationObject(string id)
        {
            if (_loadV3)
            {
                if (_loanToUpdateV3.Applications == null)
                {
                    _loanToUpdateV3.Applications = new List<LenderApiContractsV3.ApplicationContract>();
                }

                var item = _loanToUpdateV3.Applications.Where(t => t.Id == id).FirstOrDefault();
                if (item == null)
                {
                    _loanToUpdateV3.Applications.Add(new LenderApiContractsV3.ApplicationContract()
                    {
                        Id = id
                    });
                }
            }
            else
            {
                if (_loanToUpdateV1.Applications == null)
                {
                    _loanToUpdateV1.Applications = new List<LenderApiContractsV1.LoanContractApplications>();
                }

                var item = _loanToUpdateV1.Applications.Where(t => t.Id == id).FirstOrDefault();
                if (item == null)
                {
                    _loanToUpdateV1.Applications.Add(new LenderApiContractsV1.LoanContractApplications()
                    {
                        Id = id
                    });
                }
            }
        }

        private object ConvertValue(Type propertyType, object value)
        {
            // Check each type You need to handle
            // In this way You have control on conversion operation, before assigning value
            if (propertyType == typeof(int) || propertyType == typeof(int?))
            {
                int intValue;
                if (int.TryParse(value.ToString(), out intValue))
                {
                    value = intValue;
                }
            }
            else if (propertyType == typeof(double) || propertyType == typeof(double?))
            {
                double dValue;
                if (double.TryParse(value.ToString(), out dValue))
                {
                    value = dValue;
                }
            }
            else if (propertyType == typeof(bool) || propertyType == typeof(bool?))
            {
                bool bValue;
                if (value.ToString().ToUpper() == "Y" || value.ToString().ToUpper() == "T" || value.ToString().ToUpper() == "TRUE")
                    value = true;
                else if (value.ToString().ToUpper() == "N" || value.ToString().ToUpper() == "F" || value.ToString().ToUpper() == "FALSE")
                    value = false;
                else if (value == null)
                    value = null;
                else if (bool.TryParse(value.ToString(), out bValue))
                {
                    value = bValue;
                }
            }
            else if (propertyType == typeof(DateTime) || propertyType == typeof(DateTime?))
            {
                DateTime dtValue;
                if (DateTime.TryParse(value.ToString(), out dtValue))
                {
                    value = dtValue;
                }
            }
            else if (propertyType == typeof(byte) || propertyType == typeof(byte?))
            {
                byte byteValue;
                if (byte.TryParse(value.ToString(), out byteValue))
                {
                    value = byteValue;
                }
            }
            else if (propertyType == typeof(string))
            {
                value = value.ToString();
            }

            return value;
        }
    }
}
