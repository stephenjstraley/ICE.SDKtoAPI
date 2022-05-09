using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using ICE.SDKtoAPI.LenderApiContractsV3;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class DocumentProviderService : BaseProviderService
    {
        public DocumentProviderService(AccessToken token) : base(token) { paths.SetV3(); }

        public async Task<Tuple<List<DocumentContract>, LenderApiResponse>> GetDocumentsAsync(string guid)
        {
            List<DocumentContract> list = null;

            var usePath = paths.Documents(guid);

            try
            {
                list = await Get<List<DocumentContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<DocumentContract>, LenderApiResponse>(list, _response);
        }
        public async Task<Tuple<DocumentContract, LenderApiResponse>> GetDocumentAsync(string guid, string docId)
        {
            DocumentContract item = null;

            var usePath = paths.Document(guid, docId);

            try
            {
                item = await Get<DocumentContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<DocumentContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<List<FileAttachmentContract>, LenderApiResponse>> GetAttachmentsAsync(string guid)
        {
            List<FileAttachmentContract> list = null;

            var usePath = paths.Attachments(guid);

            try
            {
                list = await Get<List<FileAttachmentContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<FileAttachmentContract>, LenderApiResponse>(list, _response);
        }
        public async Task<Tuple<List<FileAttachmentContract>, LenderApiResponse>> GetAttachmentsWithRemovedAsync(string guid)
        {
            List<FileAttachmentContract> list = null;

            var usePath = paths.AttachmentsIncludingRemoved(guid);

            try
            {
                list = await Get<List<FileAttachmentContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<FileAttachmentContract>, LenderApiResponse>(list, _response);
        }

        public async Task<Tuple<AttachmentUrlDownloadContract, LenderApiResponse>> GetDownloadAttachmentByIdAsync(string guid, string id)
        {
            LenderApiResponse apiResponse;
            AttachmentUrlDownloadContract item = null;

            var usePath = paths.DocumentAttachmentDownloadUrl(guid);

            try
            {
                var contract = new AttachmentIdContract();
                contract.Attachments.Add(id);

                var url = Authenticate(usePath);

                var resp = await url.PostJsonAsync(contract);

                item = resp.ReceiveJson<AttachmentUrlDownloadContract>();

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return new Tuple<AttachmentUrlDownloadContract, LenderApiResponse>(item, apiResponse);
        }

        // V1 Document
        public async Task<Tuple<LenderApiContractsV1.LoanContractDocuments, LenderApiResponse>> CreateDocumentAsync(string guid, LenderApiContractsV1.LoanContractDocuments document)
        {
            LenderApiContractsV1.LoanContractDocuments doc = document;
            paths.SetV1();

            var usePath = paths.Documents(guid);

            try
            {
                doc = await Post<LenderApiContractsV1.LoanContractDocuments>(document, usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.LoanContractDocuments, LenderApiResponse>(doc, _response);
        }

        public async Task<Tuple<string, LenderApiResponse>> DownloadAttachment(string guid, FileAttachmentContract contract, string path, string fileName)
        {
            LenderApiResponse apiResponse;
            var savedFile = string.Empty;

            var url = await GetDownloadAttachmentByIdAsync(guid, contract.Id);
            AttachmentUrlDownloadContract fileAttachment = url.Item1;
            apiResponse = url.Item2;

            if (apiResponse.IsSuccess)  // now that we have the URL for the attachment...
            {
                savedFile = await fileAttachment.Attachments[0].Url.DownloadFileAsync(path, fileName);
            }

            return new Tuple<string, LenderApiResponse>(savedFile, apiResponse);
        }
        public async Task<Tuple<string, LenderApiResponse>> DownloadAttachment(string guid, string attachmentId, string path, string fileName)
        {
            LenderApiResponse apiResponse;
            var savedFile = string.Empty;
            var url = await GetDownloadAttachmentByIdAsync(guid, attachmentId);
            AttachmentUrlDownloadContract fileAttachment = url.Item1;
            apiResponse = url.Item2;
            if (apiResponse.IsSuccess)  // now that we have the URL for the attachment...
                savedFile = await fileAttachment.Attachments[0].Url.DownloadFileAsync(path, fileName);

            return new Tuple<string, LenderApiResponse>(savedFile, apiResponse);
        }
        public async Task<Tuple<List<DocumentContract>, LenderApiResponse>> CreateDocumentsAsync(string guid, string docTitle, string description)
        {
            var documents = new Dictionary<string, string>();
            documents.Add(docTitle, description);

            return await CreateDocumentsAsync(guid, "", documents);
        }
        public async Task<Tuple<List<DocumentContract>, LenderApiResponse>> CreateDocumentsAsync(string guid, string lockId, string docTitle, string description)
        {
            var documents = new Dictionary<string, string>();
            documents.Add(docTitle, description);

            return await CreateDocumentsAsync(guid, lockId, documents);
        }
        public async Task<Tuple<List<DocumentContract>, LenderApiResponse>> CreateDocumentsAsync(string guid, string lockId, Dictionary<string, string> documents)
        {
            List<DocumentContract> adoc = new List<DocumentContract>();
            foreach (var item in documents)
            {
                adoc.Add(new DocumentContract()
                {
                    Title = item.Key,
                    Description = item.Value
                });
            }

            return await CreateDocumentsAsync(guid, lockId, adoc);
        }
        public async Task<Tuple<List<DocumentContract>, LenderApiResponse>> CreateDocumentsAsync(string guid, string lockId, List<DocumentContract> documents)
        {
            LenderApiResponse apiResponse;
            List<DocumentContract> docs = new List<DocumentContract>();
            var usePath = string.Empty;

            if (!string.IsNullOrEmpty(lockId))
                usePath = paths.Documents(guid) + $"?action=add&view=entity&lockId={lockId}";
            else
                usePath = paths.Documents(guid) + "?action=add&view=entity";

            try
            {
                var url = Authenticate(usePath);

                //var temp = JsonConvert.SerializeObject(documents);

                var resp = await url.PatchJsonAsync(documents);

                docs = resp.ReceiveJson<List<DocumentContract>>();

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return new Tuple<List<DocumentContract>, LenderApiResponse>(docs, apiResponse);
        }

        public async Task<Tuple<bool, LenderApiResponse>> UpdateDocumentAsync(string guid, List<DocumentContract> documents)
        {
            var retValue = false;
            LenderApiResponse apiResponse;

            var usePath = paths.Documents(guid) + "?action=update&view=entity";

            try
            {
                var url = Authenticate(usePath);

                var response = await url.PatchJsonAsync(documents);

                var temp = response.ReceiveJson<List<DocumentContract>>();  // this may be used at a later time

                apiResponse = OkResponse(response.Headers, usePath);
                retValue = true;
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return new Tuple<bool, LenderApiResponse>(retValue, apiResponse);
        }
        public async Task<LenderApiResponse> RemoveDocumentAsync(string guid, string documentId)
        {
            LenderApiResponse apiResponse;
            List<DocumentContract> docs = new List<DocumentContract>();

            var usePath = paths.Documents(guid) + "?action=remove";

            try
            {
                var url = Authenticate(usePath);

                docs.Add(new DocumentContract()
                {
                    Id = documentId
                });

                var response = await url.PatchJsonAsync(docs);

                var temp = response.ReceiveJson<List<DocumentContract>>();

                apiResponse = OkResponse(response.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return apiResponse;
        }

        public async Task<LenderApiResponse> AssignAttachmentToDocumentAsync(string guid, string documentId, string attachId)
        {
            LenderApiResponse apiResponse;

            var usePath = paths.DocumentAttachments(guid, documentId) + "?action=add";

            try
            {
                var url = Authenticate(usePath);

                List<EntityReferenceContract> adoc = new List<EntityReferenceContract>();
                adoc.Add(new EntityReferenceContract()
                {
                    EntityId = attachId,
                    EntityType = "attachment"
                });

                var resp = await url.PatchJsonAsync(adoc);

                var items = resp.ReceiveJson<List<DocumentContract>>();

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return apiResponse;
        }

        public async Task<Tuple<string, LenderApiResponse>> UploadAttachemntAsync(string guid, string lockId, MemoryStream stream, string fileName, string fileType, string title)
        {
            var attachmentId = string.Empty;
            LenderApiResponse apiResponse;

            var usePath = paths.AttachmentUploadUrl(guid);

            if (!string.IsNullOrEmpty(lockId))
            {
                usePath += $"?lockId={lockId}";
            }

            try
            {
                // this has to handle V1 and V3 = single and multiple chunks

                // build contract
                var contract = new AttachmentUploadContract()
                {
                    File = new AttachmentUploadFileContract()
                    {
                        ContentType = fileType,
                        Name = fileName,
                        Size = stream.Length
                    },
                    Title = title
                };

                var url = Authenticate(usePath);

                var response = await url.PostJsonAsync(contract);

                string result = await response.Content.ReadAsStringAsync();

                // now the string of the response may be different based on multichunk or not

                var urlResponse = JsonConvert.DeserializeObject<UploadAttachmentResponse>(result);

                attachmentId = urlResponse.AttachmentId;

                if (urlResponse.V1Loan)  // this is a V1 Loan
                {
                    var urlCall = urlResponse.UploadUrl; //.WithHeader("Authorization", urlResponse.AuthorizationHeader);
                    stream.Position = 0;
                    HttpContent content = new StreamContent(stream);
                    var whatValue = urlCall.PutAsync(content).Result;
                }
                else
                {
                    if (urlResponse.MultiChunkRequired)
                    {
                        throw new Exception("60MB files not yet supported");
                    }
                    {
                        var urlCall = urlResponse.UploadUrl.WithHeader("Authorization", urlResponse.AuthorizationHeader);
                        stream.Position = 0;
                        HttpContent content = new StreamContent(stream);
                        var whatValue = urlCall.PutAsync(content).Result;
                    }
                }
                apiResponse = OkResponse(response, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
                attachmentId = string.Empty;
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
                attachmentId = string.Empty;
            }

            return new Tuple<string, LenderApiResponse>(attachmentId, apiResponse);
        }
    }
}
