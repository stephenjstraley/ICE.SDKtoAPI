using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        #region V3 GETS
        public async Task<List<LenderApiContractsV3.DocumentContract>> GetDocumentsAsync() => await GetDocumentsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.DocumentContract>> GetDocumentsAsync(string guid)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var results = await provider.GetDocumentsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.DocumentContract>> GetDocumentsByTitleAsync(string title) => await GetDocumentsByTitleAsync(LoanGuid, title);
        public async Task<List<LenderApiContractsV3.DocumentContract>> GetDocumentsByTitleAsync(string guid, string title)
        {
            List<LenderApiContractsV3.DocumentContract> docs = new List<LenderApiContractsV3.DocumentContract>();

            var results = await GetDocumentsAsync(guid);
            if (LastStatus == HttpStatusCode.OK)
            {
                foreach (var item in results)
                {
                    if (item.Title.ToUpper().Contains(title.ToUpper()))
                        docs.Add(item);
                }
            }
            return docs;
        }

        public async Task<LenderApiContractsV3.DocumentContract> GetDocumentAsync(string guid, string id)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var results = await provider.GetDocumentAsync(guid, id);
            _lastResponse = results.Item2;
            return results.Item1;
        }

        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentsAsync() => await GetAttachmentsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentsAsync(string guid)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var results = await provider.GetAttachmentsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentsForDocIdAsync(string docId) => await GetAttachmentsForDocIdAsync(LoanGuid, docId);
        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentsForDocIdAsync(string guid, string docId)
        {
            List<LenderApiContractsV3.FileAttachmentContract> list = new List<LenderApiContractsV3.FileAttachmentContract>();
            var items = await GetAttachmentsAsync(guid);
            if (LastStatus == HttpStatusCode.OK)
            {
                foreach (var item in items)
                    if (item.AssignedTo.EntityId == docId && item.AssignedTo.EntityType.ToUpper() == "DOCUMENT")
                        list.Add(item);
            }
            return list;
        }
        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentByTitleAsync(string title) => await GetAttachmentByTitleAsync(LoanGuid, title);
        public async Task<List<LenderApiContractsV3.FileAttachmentContract>> GetAttachmentByTitleAsync(string guid, string title)
        {
            List<LenderApiContractsV3.FileAttachmentContract> list = new List<LenderApiContractsV3.FileAttachmentContract>();
            var items = await GetAttachmentsAsync(guid);
            if (LastStatus == HttpStatusCode.OK)
            {
                foreach (var item in items)
                {
                    if (item.Title.ToUpper().Contains(title.ToUpper()))
                        list.Add(item);
                }
            }

            return list;
        }
        #endregion

        #region V3 downloads
        public async Task<string> DownloadAttachmentAsync(LenderApiContractsV3.FileAttachmentContract contract, string path, string fileName) => await DownloadAttachmentAsync(LoanGuid, contract, path, fileName);
        public async Task<string> DownloadAttachmentAsync(string guid, LenderApiContractsV3.FileAttachmentContract contract, string path, string fileName)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.DownloadAttachment(guid, contract, path, fileName);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<string> DownloadAttachmentAsync(string attachmentId, string path, string fileName) => await DownloadAttachmentAsync(LoanGuid, attachmentId, path, fileName);
        public async Task<string> DownloadAttachmentAsync(string guid, string attachmentId, string path, string fileName)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.DownloadAttachment(guid, attachmentId, path, fileName);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        #endregion

        public async Task<LenderApiContractsV1.LoanContractDocuments> CreateDocAsync(string title, string description) => await CreateDocAsync(LoanGuid, title, description);
        public async Task<LenderApiContractsV1.LoanContractDocuments> CreateDocAsync(string guid, string title, string description)
        {
            SetResponse();
            var newDoc = new LenderApiContractsV1.LoanContractDocuments()
            {
                Title = title,
                ApplicationId = "All",
                Description = description
            };

            return await CreateDocAsync(guid, newDoc);
        }

        public async Task<LenderApiContractsV1.LoanContractDocuments> CreateDocAsync(LenderApiContractsV1.LoanContractDocuments doc) => await CreateDocAsync(LoanGuid, doc);
        public async Task<LenderApiContractsV1.LoanContractDocuments> CreateDocAsync(string guid, LenderApiContractsV1.LoanContractDocuments doc)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.CreateDocumentAsync(guid, doc);
            _lastResponse = result.Item2;
            return result.Item1;

        }

        #region V3 Creates
        public async Task<LenderApiContractsV3.DocumentContract> CreateDocumentAsync(string title, string description) => await CreateDocumentAsync(LoanGuid, "", title, description);
        public async Task<LenderApiContractsV3.DocumentContract> CreateDocumentAsync(string lockId, string title, string description) => await CreateDocumentAsync(LoanGuid, lockId, title, description);
        public async Task<LenderApiContractsV3.DocumentContract> CreateDocumentAsync(string guid, string lockId, string title, string description)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.CreateDocumentsAsync(guid, lockId, title, description);
            _lastResponse = result.Item2;

            if (result.Item1.Count > 0)
                return result.Item1[0];
            else
                return null;
        }
        public async Task<LenderApiContractsV3.DocumentContract> CreateDocumentAsync(string lockId, LenderApiContractsV3.DocumentContract doc) => await CreateDocumentAsync(LoanGuid, lockId, doc);
        public async Task<LenderApiContractsV3.DocumentContract> CreateDocumentAsync(string guid, string lockId, LenderApiContractsV3.DocumentContract doc)
        {
            SetResponse();
            List<LenderApiContractsV3.DocumentContract> docs = new List<LenderApiContractsV3.DocumentContract>();
            docs.Add(doc);
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.CreateDocumentsAsync(guid, lockId, docs);
            _lastResponse = result.Item2;
            if (_lastResponse.IsSuccess)
                return result.Item1[0];
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.DocumentContract>> CreateDocumentsAsync(string guid, string lockId, Dictionary<string, string> docs)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.CreateDocumentsAsync(guid, lockId, docs);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        public async Task<List<LenderApiContractsV3.DocumentContract>> CreateDocumentsAsync(string guid, string lockId, List<LenderApiContractsV3.DocumentContract> docs)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.CreateDocumentsAsync(guid, lockId, docs);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        #endregion


        #region V3 Updte Document
        #endregion

        #region Delete Document
        public LenderApiContractsV3.DocumentContract PrepareUpdateDocument(LenderApiContractsV3.DocumentContract cont)
        {
            LenderApiContractsV3.DocumentContract ret = new LenderApiContractsV3.DocumentContract()
            {
                Id = cont.Id,
                Title = cont.Title
            };
            return ret;
        }
        public async Task DeleteDocumentAsync(string documentID) => await DeleteDocumentAsync(LoanGuid, documentID);
        public async Task DeleteDocumentAsync(string guid, string documentID)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.RemoveDocumentAsync(guid, documentID);
            _lastResponse = result;
        }
        #endregion

        #region Update Document(s)
        public async Task<bool> UpdateDocumentAsync(LenderApiContractsV3.DocumentContract doc) => await UpdateDocumentAsync(LoanGuid, doc);
        public async Task<bool> UpdateDocumentAsync(string guid, LenderApiContractsV3.DocumentContract doc)
        {
            List<LenderApiContractsV3.DocumentContract> docs = new List<LenderApiContractsV3.DocumentContract>();
            docs.Add(doc);
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.UpdateDocumentAsync(guid, docs);
            _lastResponse = result.Item2;
            return result.Item1;
        }
        #endregion

        #region Assign Attachment To Document
        public async Task AssignAtachmentToDocumentAsync(string docId, string attachId) => await AssignAtachmentToDocumentAsync(LoanGuid, docId, attachId);
        public async Task AssignAtachmentToDocumentAsync(string guid, string docId, string attachId)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var result = await provider.AssignAttachmentToDocumentAsync(guid, docId, attachId);
            _lastResponse = result;
        }
        #endregion

        #region Upload Attachment
        public async Task<string> UploadAttachmentAsync(string file, string fileName, string fileType, string fileTitle) => await UploadAttachmentAsync(LoanGuid, "", file, fileName, fileType, fileTitle);
        public async Task<string> UploadAttachmentAsync(string lockId, string file, string fileName, string fileType, string fileTitle) => await UploadAttachmentAsync(LoanGuid, lockId, file, fileName, fileType, fileTitle);
        public async Task<string> UploadAttachmentAsync(string guid, string lockId, string file, string fileName, string fileType, string fileTitle)
        {
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            MemoryStream ms = new MemoryStream();
            fs.CopyTo(ms);

            return await UploadAttachmentAsync(guid, lockId, ms, fileName, fileType, fileTitle);
        }
        public async Task<string> UploadAttachmentAsync(string lockId, MemoryStream stream, string fileName, string fileType, string fileTitle) => await UploadAttachmentAsync(LoanGuid, lockId, stream, fileName, fileType, fileTitle);
        public async Task<string> UploadAttachmentAsync(string guid, string lockId, MemoryStream stream, string fileName, string fileType, string fileTitle)
        {
            SetResponse();
            var provider = new DocumentProviderService(_accessToken);
            var results = await provider.UploadAttachemntAsync(guid, lockId, stream, fileName, fileType, fileTitle);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        //public string CreateEmptyLoanInFolder(string loanFolder)
        //{
        //    var loansApiClient = ApiClientProvider.GetApiClient<LoansApi>(_accessToken);
        //    var rtn = (JObject)loansApiClient.CreateLoan(loanFolder, templatePath: null, persistent: null, view: "id", loanContract: new LoanContract());
        //    if (rtn != null && rtn.ContainsKey("id"))
        //    {
        //        return rtn["id"].ToString();
        //    }
        //    return null;
        //}

        public bool MoveToFolder(string newName) => MoveToFolder(LoanGuid, newName);
        public bool MoveToFolder(string guid, string newName)
        {
            SetResponse();
            LenderApiResponse results = MoveToFolderAsync(guid, newName).Result;
            if (!results.IsSuccess)
            {
                _lastResponse = results;
            }
            return results.IsSuccess;
        }
        public async Task<LenderApiResponse> MoveToFolderAsync(string guid, string newName)
        {
            SetResponse();
            var provider = new FolderProviderService(_accessToken);
            var resp = await provider.MoveToFolderAsync(guid, newName);
            _lastResponse = resp;
            return resp;
        }

        public async Task<List<LenderApiContractsV1.PlanCode>> GetOpeningPlanCodes()
        {
            SetResponse();
            var provider = new ClosingDisclosuresService(_accessToken);
            var resp = await provider.GetPlanCodesAsync("Opening");
            _lastResponse = resp.Item2;
            return resp.Item1;
        }
        public async Task<List<LenderApiContractsV1.PlanCode>> GetClosingPlanCodes()
        {
            SetResponse();
            var provider = new ClosingDisclosuresService(_accessToken);
            var resp = await provider.GetPlanCodesAsync("Closing");
            _lastResponse = resp.Item2;
            return resp.Item1;
        }


        //        public void AddAttachmentsToDocument(string documentId, List<EFolderEntityRefContract> attachments)
        //        {
        //            var docApiClient = ApiClientProvider.GetApiClient<DocumentsApi>(_accessToken);
        //            docApiClient.UpdateDocAttachments(documentId, LoanGuid, "add", attachments);
        //        }

        //        public string UploadAttachment(EFolderMediaUrlContract attachment, string filePath)
        //        {
        //            var content = File.ReadAllBytes(filePath);
        //            var attachmentApiClient = ApiClientProvider.GetApiClient<AttachmentsApi>(_accessToken);
        //            var urlContract = attachmentApiClient.UploadAttachment(LoanGuid, "entity", attachment);
        //            if (urlContract != null && !string.IsNullOrEmpty(urlContract.MediaUrl))
        //            {
        //                var token = _accessToken.BearerToken;
        //                var response = urlContract.MediaUrl
        //                    .WithHeader("Authorization", token)
        //                    .PutAsync(new ByteArrayContent(content))
        //                    .Result;
        //                if (response != null && response.IsSuccessStatusCode)
        //                {
        //                    var basePath = attachmentApiClient.GetBasePath();
        //                    var fullPath = $"{basePath}encompass{response.Headers.Location.OriginalString}";
        //                    var json = fullPath
        //                        .WithHeader("Authorization", token)
        //                        .GetJsonAsync()
        //                        .Result;
        //                    if (json != null && !string.IsNullOrEmpty(json.attachmentId))
        //                    {
        //                        //Example of json object:
        //                        /*
        //						 {
        //						  "title": "111222.pdf",
        //						  "attachmentId": "Attachment-bede180d-4ca4-430a-8d76-a2520ff6eb4f.pdf",
        //						  "dateCreated": "2019-08-21T22:06:20Z",
        //						  "createdBy": "0ss0",
        //						  "createdByName": "Straley, Steve",
        //						  "isRemoved": false,
        //						  "attachmentType": 0,
        //						  "fileSize": 73026,
        //						  "isActive": true,
        //						  "rotation": 0
        //						}
        //* 
        //						 */
        //                        return json.attachmentId.ToString();
        //                    }
        //                }
        //            }
        //            return null;

        //        }

        //public string DownloadAttachment(EFolderDocumentContractAttachments attach, string filePath, string fileName) // EFolderDocumentContractAttachments att)
        //{
        //    string returnFileName = null;

        //    if (_accessToken == null)
        //    {
        //        throw new EllieBaseAccessTokenException("No access token defined")
        //        {
        //            LoanId = _loan?.EncompassId,
        //            LoanNumber = _loan?.LoanNumber
        //        };
        //    }

        //    try
        //    {
        //        var baseUrl = $"https://api.elliemae.com/encompass/v1/loans/{_guid}/attachments/{attach.EntityId}/url";
        //        var token = _accessToken.BearerToken;
        //        var response = baseUrl

        //            .WithHeader("Authorization", token)
        //            .PostAsync(null).Result;
        //        //                    .DownloadFileAsync(@"C:\Temp", "FooBar").Result;

        //        if (response != null && response.IsSuccessStatusCode)
        //        {
        //            var content = response.Content.ReadAsStringAsync().Result;
        //            dynamic json = JsonConvert.DeserializeObject(content);
        //            string newUrl = json.mediaUrl;
        //            returnFileName = newUrl.DownloadFileAsync(filePath, fileName).Result;
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        var fff = e.Message;
        //        throw e;
        //    }

        //    return returnFileName;
        //}
        //public List<EFolderUnderwritingConditionContract> GetUnderwritingConditions() => GetUnderwritingConditions(LoanGuid);

        //public List<EFolderUnderwritingConditionContract> GetUnderwritingConditions(string guid)
        //{
        //    try
        //    {
        //        var conditionsApiClient = ApiClientProvider.GetApiClient<ConditionsApi>(_accessToken);
        //        return conditionsApiClient.GetEFolderUnderwritingConditions(guid);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

    }
}
