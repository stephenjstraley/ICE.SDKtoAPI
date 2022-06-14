using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void Folders()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                Console.WriteLine("--- Get Loan Template Folders ---");
                var tempFolders = _api.GetLoanTemplateFoldersAsync().Result;
                if (tempFolders != null)
                {
                    foreach (var t in tempFolders)
                        Console.WriteLine(t.EntityName);
                }

                Console.WriteLine();
                Console.WriteLine("--- Get Template Files in Public Folder ---");
                var tempFiles = _api.GetLoanTemplatesAsync().Result;
                if (tempFiles != null)
                {
                    foreach (var t in tempFiles)
                        Console.WriteLine(t.EntityName);
                }

                Console.WriteLine();
                Console.WriteLine("---- Get All Folders ----");
                var folders = _api.GetLoanFoldersAsync().Result;
                foreach (var f in folders)
                    Console.WriteLine($"{f.FolderName} - {f.FolderType} = {f.IsArchiveFolder} - {f.CanLoansByOriginatedInto}");

                Console.WriteLine();
                Console.WriteLine("---- Get Specific Folder ----");
                var folder = _api.GetLoanFolderAsync("(Trash)").Result;
                if (folder != null && _api.IsOkStatus)
                {
                    Console.WriteLine($"{folder.FolderName} - {folder.FolderType} = {folder.IsArchiveFolder} - {folder.CanLoansByOriginatedInto}");
                    Console.WriteLine($"You {(folder.CanLoansByOriginatedInto ? "CAN" : "CAN NOT")} CREATE a new Loan in this folder");
                }
                else
                    Console.WriteLine($"Errpr: {_api.LastResponse.Message}");

                Console.WriteLine();
                Console.WriteLine("---- Move Loan to Folder ----");

                var temp = _api.MoveToFolderAsync(_api.LoanGuid, "(Trash)").Result;

                if (_api.IsOkStatus)
                {
                    Console.WriteLine("Loan moved to (Trash) - now let's move back");
                    temp = _api.MoveToFolderAsync(_api.LoanGuid, "My Pipeline").Result;

                    if (_api.IsOkStatus)
                        Console.WriteLine("Loan moved to My Pipeline)");
                    else
                        Console.WriteLine($"Error: {_api.LastErrorMessage}");
                }
                else
                    Console.WriteLine($"Error: {_api.LastErrorMessage}");
            }
            else
                Console.WriteLine($"Unable to get guid for loan {UseThisLoan} on instance {_instanceId}");

        }

    }
}
