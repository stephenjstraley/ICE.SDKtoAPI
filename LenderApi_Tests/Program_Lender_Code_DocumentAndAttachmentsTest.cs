using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void DocumentAndAttachmentsTest()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();
            if (_api.HasLoanGuid)
            {
                #region Code to show difference in V1 vs V3 creating documents
                //var oldDoc = new LoanContractDocuments()
                //{
                //    ApplicationId = "All",
                //    DateReceived = DateTime.Now.ToString("u"),
                //    DateRequested = DateTime.Now.ToString("u"),
                //    Description = "My description",
                //    RequestedFrom = "0ss0",
                //    Title = "V1 FolderName 6"
                //};
                //var v1Doc = _api.CreateDocAsync(oldDoc).Result;   // V1 way of creating documents

                //var newDoc = new LoanContractDocumentsV3()
                //{
                //    ReceivedDate = DateTime.Now.ToString("s")+"Z",
                //    RequestedDate = DateTime.Now.ToString("s")+"Z",
                //    Desription = "My description",
                //    RequestedFrom = "0ss0",
                //    Title = "V3 FolderName 6a"
                //};
                //var v3Doc = _api.CreateDocumentAsync(newDoc).Result;
                #endregion

                // get a loan
                // lock the loan
                // get the lockID
                // Create the document with the lockId

                Console.WriteLine("--- Locking Loan and Document ---");
                var worked = _api.LockLoanAsync(_api.LoanGuid, true).Result;
                if (worked)
                {
                    var lockId = _api.LastLoanLockId;
                    var newDoc = new ICE.SDKtoAPI.LenderApiContractsV3.DocumentContract()
                    {
                        ReceivedDate = DateTime.Now.ToString("s") + "Z",
                        RequestedDate = DateTime.Now.ToString("s") + "Z",
                        Description = "My NEW description",
                        RequestedFrom = "0ss0",
                        Title = "V3 NEW FolderName"
                    };
                    var newValue = _api.CreateDocumentAsync(_api.LoanGuid, lockId, newDoc).Result;

                    Console.WriteLine(_api.LastResponse.StatusCode);
                    Console.WriteLine(_api.LastResponse.Message);

                    if (_api.LastResponse.IsSuccess)
                    {
                        // Now upload a document with lockID

                        Console.WriteLine();
                        Console.WriteLine("Enter Name of File to Upload");
                        var file = Console.ReadLine();

                        FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                        MemoryStream ms = new MemoryStream();
                        fs.CopyTo(ms);

                        Console.WriteLine();
                        Console.WriteLine("Uploading Document");

                        // upload attachment  - NO lock ID
                        var newAttachmentId = _api.UploadAttachmentAsync(_api.LoanGuid, lockId, file,
                                    "TestFile2.pdf", FileAttachmentContentTypeCloud.ApplicationPdf, "Try This 2").Result;

                        Console.Write("File Upload Status:" + _api.LastResponse.StatusCode);
                    }
                }
                var temp = _api.ForceUnlockAsync().Result;


                Console.WriteLine("---- List of Documents to Loan ----");
                var docs = _api.GetDocumentsAsync(_api.LoanGuid).Result;  //loan.Log.TrackedDcouments;
                foreach (var i in docs)
                    Console.WriteLine($"{i.Title} - {i.Id} - {i.ReceivedDate}");   // {_api.LoanGuid} - 

                var tempDoc = _api.GetDocumentAsync(_api.LoanGuid, "c277368d-bf12-4beb-a920-de7767fb90dc").Result;


                Console.WriteLine();
                Console.WriteLine("--- Use Helper/SDK LOG TRACKED DOCUMENTS ----");
                var customDoc = _api.Log.TrackedDocumentAdd("Closing Doc History", "Processing");

                Console.WriteLine($"{customDoc?.Id} - {customDoc?.Description}");

                customDoc.OrderDateUtc = DateTime.UtcNow;
                customDoc.DaysDue = 7;

                Console.WriteLine();
                Console.WriteLine("--- Document By Title ----");
                if (docs.Count > 0)
                {
                    var theDoc = _api.GetDocumentsByTitleAsync(docs[0].Title).Result;
                    Console.WriteLine($"Documents found with title [{docs[0].Title}] - count = {theDoc.Count}");
                }
                else
                    Console.Write("No Documents Found");

                Console.WriteLine();
                Console.WriteLine("--- Attachments in each Document ----");
                foreach (var i in docs)
                {
                    Console.WriteLine($"Document Title: {i.Title}");
                    var attachments = _api.GetAttachmentsForDocIdAsync(i.Id).Result;
                    foreach (var att in attachments)
                    {
                        Console.WriteLine($"     Attachment Type [{att.Type}] - Title [{att.Title}]");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("---- Create Document ----");
                var createdDoc = _api.CreateDocumentAsync("Test Doc 5", "This is a test document with API").Result;
                if (_api.IsOkStatus && createdDoc != null)
                {
                    Console.WriteLine("Document Created");

                    var updateDoc = _api.PrepareUpdateDocument(createdDoc);

                    updateDoc.Roles = new List<ICE.SDKtoAPI.LenderApiContractsV3.EntityReferenceContract>();

                    Console.WriteLine("Adding/Modify Role Assignments for Document");
                    updateDoc.Roles.Add(new ICE.SDKtoAPI.LenderApiContractsV3.EntityReferenceContract()
                    {
                        EntityId = "14"
                    });

                    Console.WriteLine("Updating Document Roles");
                    _api.UpdateDocumentAsync(updateDoc).Wait();

                    Console.WriteLine("Changed Days Due");
                    updateDoc.DaysDue = 7;

                    Console.WriteLine("Updating Document");
                    _api.UpdateDocumentAsync(updateDoc).Wait();

                    Console.WriteLine();
                    Console.WriteLine("Enter Name of File to Upload");
                    var file = Console.ReadLine();

                    FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                    MemoryStream ms = new MemoryStream();
                    fs.CopyTo(ms);

                    Console.WriteLine();
                    Console.WriteLine("Uploading Document");

                    // upload attachment  - NO lock ID
                    var newAttachmentId = _api.UploadAttachmentAsync(_api.LoanGuid, "", file,
                                "TestFile2.pdf", FileAttachmentContentTypeCloud.ApplicationPdf, "Try This 2").Result;

                    var path = new FileInfo(file).Directory.FullName;

                    Console.WriteLine();
                    Console.WriteLine("Downloading the same Document");

                    var newFile = _api.DownloadAttachmentAsync(newAttachmentId, path, "TryMe2.Pdf").Result;
                    if (_api.IsOkStatus)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Attaching document to updated documented");
                        _api.AssignAtachmentToDocumentAsync(createdDoc.Id, newAttachmentId).Wait();

                        if (_api.IsOkStatus)
                            Console.WriteLine("Uploaded");
                        else
                            Console.WriteLine($"Error: {_api.LastErrorMessage}");
                    }
                    else
                        Console.WriteLine($"Error: {_api.LastErrorMessage}");

                    Console.WriteLine();
                    Console.WriteLine("Now refind the Document");
                    var reFindDoc = _api.GetDocumentsByTitleAsync(createdDoc.Title).Result;

                    Console.WriteLine();
                    Console.WriteLine("Now delete the Document");
                    _api.DeleteDocumentAsync(reFindDoc[0].Id).Wait();

                    Console.WriteLine($"Last API Status Code: {_api.LastStatus}");
                }
                else
                    Console.WriteLine($"Document NOT created - error: {_api.LastErrorMessage}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }

    }
}
