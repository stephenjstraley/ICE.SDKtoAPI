using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class UrlPaths
    {
        string _version = "v1";
        string _basePath = "https://api.elliemae.com";
        string _encompassPath = "/encompass/";
        string _tokenPath = "/oauth2/";
        string _loanApiPath = "/loans";
        string _webHook = "/webhook";
        string _resourceLockApiPath = "/resourceLocks";
        string _loanPipeline = "/loanPipeline";
        string _customFieldsPath = "/settings/loan/customFields";
        string _folderPath = "/loanfolders";
        string _userPath = "/company/users";
        string _pipelineFieldDef = "/loanPipeline/fieldDefinitions";
        string _batch = "/loanBatch/updateRequest";
        string _settings = "/settings";

        public string BasePath { get => _basePath; }
        public string EncompassPath { get => _encompassPath + _version;   }
        public string EncompassPathFull { get => BasePath + EncompassPath; }
        public string WebHookFull { get => BasePath + _webHook + $"/{_version}"; }
        public string Settings { get => EncompassPathFull + _settings; }
        public string SettingConditions { get => Settings + "/loan/conditions";  }
        public string TokenPath { get => _tokenPath + $"{_version}/token";  }
        public string TokenPathFull { get => BasePath + TokenPath; }
        public string TokenValid { get => TokenPathFull + "/introspection"; }
        public string UpdateBatch { get => _batch;  }
        public string UpdateBatchFull { get => EncompassPathFull + UpdateBatch; }
        public string LoanPipelinePath { get => _loanPipeline;  }
        public string LoanPipelinePathFull { get => EncompassPathFull + LoanPipelinePath; }
        public string LoanPipelinePathFullWithLimit(string limit) => LoanPipelinePathFull + $"?limit={limit}";
        public string PipelineFieldDefs { get { return _pipelineFieldDef; } }
        public string PipelineFieldDefsFull { get { return EncompassPathFull + PipelineFieldDefs; } }
        public string LoanPath { get => _loanApiPath;  }
        public string LoanPathFull { get => EncompassPathFull + LoanPath; }
        public string FolderPath { get => _folderPath;  }
        public string FolderPathFull { get => EncompassPath + FolderPath; }
        public string FolderPathFullWithName(string name) => FolderPathFull + $"{name}";
        public string ResourceLocksFull { get => EncompassPathFull + _resourceLockApiPath; }
        public string UserPath { get => _userPath; }
        public string UserPathFull { get => EncompassPathFull + UserPath; }
        public string UserPathFullLimit(int limit) => EncompassPathFull + UserPath + $"?limit={limit}";
        public string CustomFieldPath { get => _customFieldsPath; }
        public string CustomFieldPathFull { get => EncompassPath + CustomFieldPath; }
        public string VirtualFieldPathFull { get => EncompassPathFull + "/schemas/loan/virtualFields"; }
        public string BatchPath { get => EncompassPathFull + "/loanBatch/updateRequests"; }
        public string OrganizationsPath { get => EncompassPath + "/organizations"; }
        public string OrganizationPath(string guid) => EncompassPathFull + $"/organizations/{guid}?view=entity";
        public string ApplicationsPath(string guid) => LoanPathFull + $"/{guid}/applications";


        public string ConversationsPath(string guid) => LoanPathFull + $"/{guid}/conversationLogs";
        public string DisclosureTrackingPath(string guid) => LoanPathFull + $"/{guid}/disclosureTracking2015";


        public string MilestonesPath(string guid) => LoanPathFull + $"/{guid}/milestones";
        public string MilestonePath(string guid, string logId) => LoanPathFull + $"/{guid}/milestones/{logId}";
        public string MilestoneFreeRolesPath(string guid) => LoanPathFull + $"/{guid}/milestoneFreeRoles";
        public string MilestoneFreeRolePath(string guid, string logId) => LoanPathFull + $"/{guid}/milestoneFreeRoles/{logId}";
        public string UnderwritingConditionsPath(string guid) => LoanPathFull + $"/{guid}/conditions/underwriting";
        public string AssociatesPath(string guid) => LoanPathFull + $"/{guid}/associates";
        public string AssociatePath(string guid, string logId) => LoanPathFull + $"/{guid}/associates/{logId}";

        public string Residences(string guid, string appGuid, string appType) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/{appType}/residences";
        public string GiftsGrants(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/giftsGrants";
        public string AdditionaLoans(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/additionalLoans";
        public string OtherAssets(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/otherAssets";
        public string OtherIncomeSources(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/otherIncomeSources";
        public string OtherLiabilities(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/otherLiabilities";
        public string NonVols(string guid) => EncompassPathFull + $"/loans/{guid}/nonVols";
        public string AffiliatedBusinessArrangements(string guid) => EncompassPathFull + $"/loans/{guid}/affiliatedBusinessArrangements";
        public string ServiceProviders(string guid) => EncompassPathFull + $"/loans/{guid}/serviceProviderContacts";
        public string HomeCouncelingProviders(string guid) => EncompassPathFull + $"/loans/{guid}/homeCounselingProviders";
        public string Employments(string guid, string appGuid, string appType) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/{appType}/employment";
        public string ReoProperties(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/reoProperties";
        public string Vols(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/vols";
        public string Vods(string guid, string appGuid) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/vods";
        public string URLAAlternateNames(string guid, string appGuid, string appType) => EncompassPathFull + $"/loans/{guid}/applications/{appGuid}/{appType}/urlaAlternateNames";
        public string EnhancedConditionTypes => EncompassPathFull + "/settings/loan/conditions/types";



        public string ResourceLock(string guid, string id, string force) => EncompassPathFull + $"/resourceLocks/{id}?resourceType=loan&resourceId={guid}&force={force}";
        public string ResourceLockList(string guid) => EncompassPathFull + $"/resourceLocks?resourceType=loan&resourceId={guid}";
        public string RateLockRequests(string guid) => LoanPathFull + $"/{guid}/ratelockRequests";
        public string RateLockRequest(string guid, string resourceId) => LoanPathFull + $"/{guid}/ratelockRequests/{resourceId}?view=detailed";
        public string LockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/lockRequests/{resourceGuid}";
        public string RateLockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/ratelockRequests/{resourceGuid}";
        public string ExtendLockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/RateLockRequests?action=extend&requestId={resourceGuid}&view=entity";
        public string ReviseLockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/RateLockRequests?action=revise&requestId={resourceGuid}&view=entity";
        public string ReLockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/RateLockRequests?action=relock&requestId={resourceGuid}&view=entity";
        public string ConfirmLockRequestForResource(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/rateLockRequests/{resourceGuid}/Confirmation?view=entity";
        public string UnlockResource(string lockId) => ResourceLocksFull + $"/{lockId}";
        public string RateLockRequestsSnapshot(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/ratelockRequests/{resourceGuid}/snapshot";
        public string CancelRateLockRequest(string guid, string resourceGuid) => LoanPathFull + $"/{guid}/rateLockRequests/{resourceGuid}/cancellation?view=entity";


        public string UserGroupPath(string userId) => UserPathFull + $"/{userId}/groups";
        public string UserCompensationPath(string userId) => UserPathFull + $"/{userId}/compensation";
        public string UserLicensesPath(string userId) => UserPathFull + $"/{userId}/licenses";
        public string UserProfilePath(string userId) => UserPathFull + $"/{userId}";



        public string CreateLoan(string folder) => EncompassPathFull + $"/loans?loanFolder={folder}&view=entity";

        public string BorrowCorBorrowEntityPath(string guid) => LoanPathFull + $"/{guid}?entities=Borrower,CoBorrower";

        public string Documents(string guid) => LoanPathFull + $"/{guid}/documents";
        public string DocumentsActiveAttachments(string guid) => Documents(guid) + "?includeRemoved=true&requireActiveAttachments=false";
        public string Document(string guid, string docId) => Documents(guid) + $"/{docId}";
        public string DocumentAttachments(string guid, string id) => LoanPathFull + $"/{guid}/documents/{id}/attachments";
        public string DocumentAttachmentUrl(string guid, string attachmentId) => LoanPathFull + $"/{guid}/attachments/{attachmentId}/url";
        public string DocumentAttachment(string guid, string attachmentId) => LoanPathFull + $"/{guid}/attachments/{attachmentId}";
        public string DocumentAttachmentDownloadUrl(string guid) => LoanPathFull + $"/{guid}/attachmentDownloadUrl";
        public string Attachments(string guid) => LoanPathFull + $"/{guid}/attachments";
        public string AttachmentsIncludingRemoved(string guid) => Attachments(guid) + "?includeRemoved=true";
        public string Attachment(string guid, string attachmentId) => LoanPathFull + $"/{guid}/attachments/{attachmentId}";
        public string AttachmentUploadUrl(string guid) => LoanPathFull + $"/{guid}/attachmentUploadUrl";

        public string MoveFolderPath(string name) => FolderPathFull + $"/{name}/loans?action=add";

        public string GetMetaData(string guid) => LoanPathFull + $"/{guid}/metadata";


        public string FieldSchemaV3Path => BasePath + _encompassPath + "v3/schemas/loan/standardFields";
        public string FieldSchemaV1Path => BasePath + _encompassPath + "v1/scheam/loan";

        public string ReadFieldValues(string guid) => EncompassPathFull + $"/loans/{guid}/fieldReader";

        public void SetV3() => _version = "v3";
        public void SetV1() => _version = "v1";
    }

}
