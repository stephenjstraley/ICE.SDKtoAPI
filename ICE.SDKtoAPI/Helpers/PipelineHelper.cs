using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.Helpers
{
    public static class PipelineHelper
    {
        #region Pipeline Terms
        public static PipelineTerm GetPipelineTerm(string canonicalName, string dateMatchType)
        {
            return new PipelineTerm()
            {
                CanonicalName = canonicalName,
                Value = "01/01/1970",
                MatchType = dateMatchType,
                Precision = "exact"
            };
        }

        public static PipelineTerm GetPipelineTerm(string canonicalName, object matchValue, string matchType, bool include, string precision)
        {
            var val = GetPipelineTerm(canonicalName, matchValue, matchType, include);
            val.Precision = precision;
            return val;
        }
        public static PipelineTerm GetPipelineTerm(string canonicalName, object matchValue, string matchType, string precision)
        {
            var val = GetPipelineTerm(canonicalName, matchValue, matchType);
            val.Include = true;
            val.Precision = precision;
            return val;
        }
        public static PipelineTerm GetPipelineTerm(string canonicalName, object matchValue, string matchType, bool include)
        {
            var val = GetPipelineTerm(canonicalName, matchValue, matchType);
            val.Include = include;
            return val;
        }
        public static PipelineTerm GetPipelineTerm(string canonicalName, object matchValue, string matchType)
        {
            return new PipelineTerm()
            {
                CanonicalName = canonicalName,
                Value = matchValue,
                MatchType = matchType,
                Precision = "day",
                Include = true
            };
        }
        #endregion

        #region Pipeline Filter Contract

        public static PipelineFilter GetFilterContractAnd(params object[] terms) => GetFilterContract(Operator.AND, terms);
        public static PipelineFilter GetFilterContractOr(params object[] terms) => GetFilterContract(Operator.OR, terms);
        public static PipelineFilter GetFilterContract(List<object> terms)
        {
            if (terms != null && terms.Count > 0)
            {
                var filter = new PipelineFilter
                {
                    Operator = Operator.OR,
                    Terms = terms
                };
                return filter;
            }
            return new PipelineFilter();
        }
        public static PipelineFilter GetFilterContract(string compOp, params object[] terms)
        {
            if (terms != null && terms.Length > 0)
            {
                var filt = new PipelineFilter
                {
                    Operator = compOp,
                    Terms = new List<object>()
                };
                foreach (var item in terms)
                {
                    if (item.GetType() == typeof(PipelineTerm))
                    {
                        filt.Terms.Add(item);
                    }
                    else if (item.GetType() == typeof(PipelineFilter))
                    {
                        filt.Terms.Add(item);
                    }
                    return filt;
                }
            }
            return new PipelineFilter();
        }
        #endregion

        #region Pipeline View Contract
        public static PipelineQueryWithFields GetContract(PipelineFilter filter, params string[] fields) => GetPipelineContract(filter, fields);
        public static PipelineQueryWithFields GetContract(List<PipelineSortOrder> order, PipelineFilter filter, params string[] fields) => GetPipelineContract(order, filter, fields);
        public static PipelineQueryWithFields GetContract(List<string> fields, List<string> guids) => GetPipelineContract(fields, guids);
        public static PipelineQueryWithFields GetPipelineContract(PipelineFilter filter, params string[] fields)
        {
            PipelineQueryWithFields query;

            if (fields == null || fields.Length == 0)
            {
                query = new PipelineQueryWithFields
                {
                    Fields = new List<string> { "Loan.GUID" },
                    Filter = filter
                };
            }
            else
            {
                var theFields = new List<string>(fields);
                if (!theFields.Contains("Loan.GUID"))
                    theFields.Add("Loan.GUID");

                query = new PipelineQueryWithFields
                {
                    Filter = filter,
                    Fields = new List<string>(fields)
                };
            }

            return query;
        }
        public static PipelineQueryWithFields GetPipelineContract(List<PipelineSortOrder> order, PipelineFilter filter, params string[] fields)
        {
            var view = GetPipelineContract(filter, fields);
            view.SortOrder = order;
            return view;
        }
        public static PipelineQueryWithFields GetPipelineContract(List<string> fields, List<string> guids)
        {
            return new PipelineQueryWithFields
            {
                Fields = fields,
                LoanGuids = guids
            };
        }
        #endregion

        #region Pipeline Sort
        public static List<PipelineSortOrder> SortCriterionList() => new List<PipelineSortOrder>();
        public static PipelineSortOrder SortCriterionList(string field, string order = "asc")
        {
            return new PipelineSortOrder
            {
                CanonicalName = field,
                Order = order
            };
        }
        #endregion

        public static T PipelineField<T>(LoanPipelineItemContract data, string field)
        {
            if (data == null) return default(T);

            var things = Newtonsoft.Json.JsonConvert.SerializeObject(data.Fields);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(things);
            if (dictionary != null)
            {
                if (dictionary.ContainsKey(field))
                {
                    var value = dictionary[field];
                    try
                    {
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                    catch
                    {
                        try
                        {
                            return (T)Convert.ChangeType(value, Nullable.GetUnderlyingType(typeof(T)));
                        }
                        catch
                        {
                            return default(T);
                        }
                    }
                }
                else
                    return default(T);
            }
            else
                return default(T);
        }

        public static T PipelineField<T>(GuidCursor data, string field)
        {
            if (data == null) return default(T);

            var things = Newtonsoft.Json.JsonConvert.SerializeObject(data.Fields);
            var dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(things);
            if (dictionary != null)
            {
                if (dictionary.ContainsKey(field))
                {
                    var value = dictionary[field];
                    try
                    {
                        return (T)Convert.ChangeType(value, typeof(T));
                    }
                    catch
                    {
                        try
                        {
                            return (T)Convert.ChangeType(value, Nullable.GetUnderlyingType(typeof(T)));
                        }
                        catch
                        {
                            return default(T);
                        }

                    }
                }
                else
                    return default(T);
            }
            else
                return default(T);
        }

        public class PipelineQuery
        {
            public PipelineFilter Filter { get; set; }
        }
        public class PipelineQueryWithFields
        {
            public PipelineFilter Filter { get; set; }
            public List<string> Fields { get; set; }
            public List<PipelineSortOrder> SortOrder { get; set; }
            public List<string> LoanGuids { get; set; }
        }
        public class PipelineSortOrder
        {
            public string CanonicalName { get; set; }
            public object Order { get; set; }
        }
        public class PipelineFilter
        {
            public string Operator { get; set; }
            public List<object> Terms { get; set; }
        }
        public class PipelineTerm
        {
            public string CanonicalName { get; set; }
            public object Value { get; set; }
            public string MatchType { get; set; }
            public bool Include { get; set; }
            public string Precision { get; set; }
        }
        public static class StringFieldMatchType
        {
            public static readonly string Exact = "exact";
            public static readonly string IsNotEmpty = "isNotEmpty";
            public static readonly string IsEmpty = "isEmpty";
            public new static readonly string Equals = "equals";
            public static readonly string NotEquals = "notEquals";
            public static readonly string StartsWith = "startsWith";
            public static readonly string Contains = "contains";
            public static readonly string IsNull = "isNull";
            public static readonly string CaseInsensitive = "exact";
        }
        public static class OrdinalFieldMatchType
        {
            public static readonly string GreaterThanOrEquals = "greaterThenOrEquals";
            public static readonly string Exact = "exact";
            public static readonly string GreaterThan = "greaterThan";
            public static readonly string LessThan = "lessThen";
            public static readonly string LessThanOrEquals = "lessThanOrEquals";
            public new static readonly string Equals = "equals";
            public static readonly string NotEquals = "notEquals";
            public static readonly string StartsWith = "startsWith";
            public static readonly string Contains = "contains";
        }
        public static class DateFieldMatchPrecision
        {
            public static readonly string Exact = "exact";
            public static readonly string Day = "day";
            public static readonly string Month = "month";
            public static readonly string Year = "year";
            public static readonly string Recurring = "recurring";
        }
        public static class Operator
        {
            public static readonly string OR = "or";
            public static readonly string AND = "and";
        }
        public static class DateFieldCriterion
        {
            public static readonly string IsEmpty = "isEmpty";
            public static readonly string IsNotEmpty = "isNotEmpty";
        }
    }
}
