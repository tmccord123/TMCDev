// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceConstants.cs" company="Nagarro">
//   
// </copyright>
// <summary>
//   Defines the ResourceConstants type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TMC.Shared
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Constants defined for resources.
    /// </summary>
    public static class ResourceConstants
    {
        /// <summary>
        /// Class for Constants for Commonly used messages
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Shared
        {
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Warning
            {
                public const string WithWarning = "JCCSems_Shared_Warning_WithWarning";
                public const string WithOutWarning = "JCCSems_Shared_Warning_WithOutWarning";
                public const string AllWarning = "JCCSems_Shared_Warning_AllWarning";
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Documents
            {
                public const string WithDocuments = "JCCSems_Shared_Warning_WithDocuments";
                public const string WithOutDocuments = "JCCSems_Shared_Warning_WithOutDocuments";
                public const string AllDocuments = "JCCSems_Shared_Warning_AllDocuments";
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ReviewNotes
            {
                public const string ShowReviewNotes = "JCCSems_Shared_Warning_ShowReviewNotes";
                public const string HideReviewNotes = "JCCSems_Shared_Warning_HideReviewNotes";
            }

            /// <summary>
            /// Class for Constants for Home
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Labels
            {
                public const string FooterTextLine1 = "JCCSems_Shared_Labels_FooterTextLine1";
                public const string FooterTextLine2 = "JCCSems_Shared_Labels_FooterTextLine2";
                public const string FooterTextLine3 = "JCCSems_Shared_Labels_FooterTextLine3";
                public const string FooterText = "JCCSems_Shared_Labels_FooterText";
                public const string PrivacyPolicyLink = "JCCSems_Shared_Labels_PrivacyPolicyLink";
                public const string TermsAndConditionsLink = "JCCSems_Shared_Labels_TermsAndConditionsLink";
                public const string JCCSemsUnauthorizedTitle = "JCCSems_Shared_Labels_JCCSemsUnauthorizedTitle";
                public const string JCCSemsUnauthorizedBody = "JCCSems_Shared_Labels_JCCSemsUnauthorizedBody";
                public const string AdminModule = "JCCSems_Shared_Labels_AdminModule";
                public const string Preferences = "JCCSems_Shared_Labels_Preferences";
                public const string Dashboard = "JCCSems_Shared_Labels_Dashboard";
                public const string ReturnToLogOn = "JCCSems_Shared_Labels_ReturnToLogin";
                public const string CustomErrorMessage = "JCCSems_Shared_Labels_CustomErrorMessage";
                public const string CustomErrorStackTrace = "JCCSems_Shared_Labels_CustomErrorStackTrace";
                public const string IndicateRequiredField = "JCCSems_Shared_Labels_IndicateRequiredField";
                public const string NoModuleAvailable = "JCCSems_Shared_Labels_NoModuleAvailable";
                public const string BackToHomePage = "JCCSems_Shared_Labels_BackToHomePage";
                public const string ErrorTitle = "JCCSems_Shared_Labels_ErrorTitle";
                public const string Select = "JCCSems_Shared_Labels_Select";
                public const string Back = "JCCSems_Shared_Labels_Back";
                public const string ReadOnly = "JCCSems_Shared_Labels_ReadOnly";
                public const string FullAccess = "JCCSems_Shared_Labels_FullAccess";
                public const string AllFeaturesSubscription = "JCCSems_Shared_Labels_AllFeaturesSubscription";
                public const string TrainingPlanSubscription = "JCCSems_Shared_Labels_TrainingPlanSubscription";
                public const string EmployeeListSubscription = "JCCSems_Shared_Labels_EmployeeListSubscription";
                public const string ExportedReport = "JCCSems_Shared_Labels_ExportedReport";
                public const string DoNotShow = "JCCSems_Shared_Labels_DoNotShow";
                public const string Search = "JCCSems_Shared_Labels_Search";
                public const string SessionTimedOutHeader = "JCCSems_Shared_Labels_SessionTimedOutHeader";
                public const string SessionTimedOutMessage = "JCCSems_Shared_Labels_SessionTimedOutMessage";
                public const string SearchAsYouType = "JCCSems_Shared_Labels_SearchAsYouType";

                /// <summary>
                /// Class for Constants for DateInputControl
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class DateInputControl
                {
                    public const string Jan = "JCCSems_Shared_Labels_DateInputControl_Jan";
                    public const string Feb = "JCCSems_Shared_Labels_DateInputControl_Feb";
                    public const string Mar = "JCCSems_Shared_Labels_DateInputControl_Mar";
                    public const string Apr = "JCCSems_Shared_Labels_DateInputControl_Apr";
                    public const string May = "JCCSems_Shared_Labels_DateInputControl_May";
                    public const string Jun = "JCCSems_Shared_Labels_DateInputControl_Jun";
                    public const string Jul = "JCCSems_Shared_Labels_DateInputControl_Jul";
                    public const string Aug = "JCCSems_Shared_Labels_DateInputControl_Aug";
                    public const string Sep = "JCCSems_Shared_Labels_DateInputControl_Sep";
                    public const string Oct = "JCCSems_Shared_Labels_DateInputControl_Oct";
                    public const string Nov = "JCCSems_Shared_Labels_DateInputControl_Nov";
                    public const string Dec = "JCCSems_Shared_Labels_DateInputControl_Dec";

                    public const string MonthDisplay = "JCCSems_Shared_Labels_DateInputControl_MonthDisplay";
                    public const string DayDisplay = "JCCSems_Shared_Labels_DateInputControl_DayDisplay";
                    public const string DateDisplay = "JCCSems_Shared_Labels_DateInputControl_DateDisplay";
                    public const string YearDisplay = "JCCSems_Shared_Labels_DateInputControl_YearDisplay";
                }

                /// <summary>
                /// Class for Constants for Message Box
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class MessageBox
                {
                    public const string ButtonCancel = "JCCSems_Shared_Labels_MessageBox_ButtonCancel";
                    public const string ButtonNo = "JCCSems_Shared_Labels_MessageBox_ButtonNo";
                    public const string ButtonOk = "JCCSems_Shared_Labels_MessageBox_ButtonOk";
                    public const string ButtonYes = "JCCSems_Shared_Labels_MessageBox_ButtonYes";
                    public const string Faliure = "JCCSems_Shared_Labels_MessageBox_Faliure";
                    public const string Success = "JCCSems_Shared_Labels_MessageBox_Success";
                    public const string ConfirmationMessageHeader = "JCCSems_Shared_Labels_MessageBox_ConfirmationMessageHeader";
                }

                /// <summary>
                /// Class for Constants for Message Box
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string PageNotFoundTitle = "JCCSems_Shared_Labels_NotificationMessage_PageNotFoundTitle";
                    public const string LeaveStayMessage = "JCCSems_Shared_Labels_NotificationMessage_LeaveStayMessage";
                }
            }

            /// <summary>
            /// Class for Constants for Grid view
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class GridView
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Error = "JCCSems_Shared_GridView_Labels_Error";
                }

                /// <summary>
                /// Class for Constants for Validations
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string FilterSearchTextRequired = "JCCSems_Shared_GridView_Validation_FilterSearchTextRequired";
                }
            }
            /// <summary>
            /// Class for Constants for Collapsible List.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CollapsibleList
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string ExpandAll = "JCCSems_Shared_CollapsibleList_Labels_ExpandAll";
                    public const string CollapseAll = "JCCSems_Shared_CollapsibleList_Labels_CollapseAll";
                    public const string Print = "JCCSems_Shared_CollapsibleList_Labels_Print";
                    public const string ExportPdf = "JCCSems_Shared_CollapsibleList_Labels_ExportPdf";
                }
            }
            /// <summary>
            /// Class for Constants for Dual List
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class DualList
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Add = "JCCSems_Shared_DualList_Labels_Add";
                    public const string AddAll = "JCCSems_Shared_DualList_Labels_AddAll";
                    public const string AddAllTitle = "JCCSems_Shared_DualList_Labels_AddAllTitle";
                    public const string AddTitle = "JCCSems_Shared_DualList_Labels_AddTitle";
                    public const string DuplicateErrorText = "JCCSems_Shared_DualList_Labels_DuplicateErrorText";
                    public const string NoSearchResultsFound = "JCCSems_Shared_DualList_Labels_NoSearchResultsFound";
                    public const string Remove = "JCCSems_Shared_DualList_Labels_Remove";
                    public const string RemoveAll = "JCCSems_Shared_DualList_Labels_RemoveAll";
                    public const string RemoveAllTitle = "JCCSems_Shared_DualList_Labels_RemoveAllTitle";
                    public const string RemoveTitle = "JCCSems_Shared_DualList_Labels_RemoveTitle";
                    public const string Reset = "JCCSems_Shared_DualList_Labels_Reset";
                    public const string Search = "JCCSems_Shared_DualList_Labels_Search";
                    public const string SearchResultsFound = "JCCSems_Shared_DualList_Labels_SearchResultsFound";
                }
            }

            /// <summary>
            /// Class for Constants for Dyna tree
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class DynaTree
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string NoSearchResultFound = "JCCSems_Shared_DynaTree_Labels_NoSearchResultFound";
                    public const string Reset = "JCCSems_Shared_DynaTree_Labels_Reset";
                    public const string SearchResult = "JCCSems_Shared_DynaTree_Labels_SearchResult";
                    public const string SingleSearchResult = "JCCSems_Shared_DynaTree_Labels_SingleSearchResult";
                }
            }

            /// <summary>
            /// Class for Constants for Custom Error
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CustomError
            {
                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Index
                {
                    public const string Title = "JCCSems_Account_CustomError_Index_Title";
                    public const string Heading = "JCCSems_Account_CustomError_Index_Heading";
                    public const string ErrorMessage = "JCCSems_Account_CustomError_Index_ErrorMessage";
                    public const string StackTrace = "JCCSems_Account_CustomError_Index_StackTrace";
                }
            }

            /// <summary>
            /// Class for Constants of shared controls buttons
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Buttons
            {
                /// <summary>
                /// Upload image buttons text
                /// </summary>
                public const string UploadImage = "JCCSems_Shared_Buttons_UploadImage";
            }

            /// <summary>
            /// file uploader static class containg all resource constants
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class FileUploader
            {
                /// <summary>
                /// Labels static class conatins all resource keys for labels to be shown on file uploader
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    /// <summary>
                    /// File uploader drag drop file message
                    /// </summary>
                    public const string DragDropFileMessage = "JCCSems_Shared_FileUploader_Labels_DragDropFileMessage";

                    /// <summary>
                    /// File edit and save message
                    /// </summary>
                    public const string EditAndSaveMessage = "JCCSems_Shared_FileUploader_Labels_EditAndSaveMessage";

                    /// <summary>
                    /// File uploader file detail header label text
                    /// </summary>
                    public const string Header = "JCCSems_Shared_FileUploader_Labels_Header";

                    /// <summary>
                    /// File uploader file detail header label text
                    /// </summary>
                    public const string EditFileHeader = "JCCSems_Shared_FileUploader_Labels_EditFileHeader";

                    public const string RequiredFieldMessage = "JCCSems_Shared_FileUploader_Labels_RequiredFieldMessage";

                    /// <summary>
                    /// Choose file button text
                    /// </summary>
                    public const string ExtensionErrorString = "JCCSems_Shared_FileUploader_Labels_ExtensionErrorString";

                    /// <summary>
                    /// Choose file button text
                    /// </summary>
                    public const string ExtensionPlaceHolderInExtensionErrorString = "JCCSems_Shared_FileUploader_Labels_ExtensionPlaceHolderInExtensionErrorString";

                    /// <summary>
                    /// File edit and save message
                    /// </summary>
                    public const string MaxFileSizeForCompanyDocumentErrorMessage = "JCCSems_Shared_FileUploader_Labels_MaxFileSizeForCompanyDocumentErrorMessage";

                    /// <summary>
                    /// File edit and save message
                    /// </summary>
                    public const string MaxFileSizeForCompanyLogoErrorMessage = "JCCSems_Shared_FileUploader_Labels_MaxFileSizeForCompanyLogoErrorMessage";

                    /// <summary>
                    /// File edit and save message
                    /// </summary>
                    public const string MaxFileSizePlaceHolderInErrorMessage = "JCCSems_Shared_FileUploader_Labels_MaxFileSizePlaceHolderInErrorMessage";
                }

                /// <summary>
                /// Button static class conatins all resource keys for button to be shown on file uploader
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    /// <summary>
                    /// Select file button text
                    /// </summary>
                    public const string SelectFile = "JCCSems_Shared_FileUploader_Button_SelectFile";

                    /// <summary>
                    /// Proceed button text
                    /// </summary>
                    public const string Save = "JCCSems_Shared_FileUploader_Buttons_Save";

                    /// <summary>
                    /// Discard button text
                    /// </summary>
                    public const string Cancel = "JCCSems_Shared_FileUploader_Buttons_Cancel";

                    /// <summary>
                    /// Choose file button text
                    /// </summary>
                    public const string ChooseFile = "JCCSems_Shared_FileUploader_Buttons_ChooseFile";
                }

                /// <summary>
                /// Class for Constants key for file detail notifications messages need to show for operation result
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    /// <summary>
                    /// File title required validation message
                    /// </summary>
                    public const string FileUploadConfirmationMessage = "JCCSems_Shared_FileUploader_NotificationMessage_FileUploadConfirmationMessage";

                    /// <summary>
                    /// File title required validation message
                    /// </summary>
                    public const string FileUploaderNoFileSelectedWarningMessage = "JCCSems_Shared_FileUploader_NotificationMessage_FileUploaderNoFileSelectedWarningMessage";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string FileNotFountOnDownloadErrorMessage = "JCCSems_Shared_FileUploader_NotificationMessage_FileNotFountOnDownloadErrorMessage";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string FileNotFountOnDownloadLoggingMessage = "JCCSems_Shared_FileUploader_NotificationMessage_FileNotFountOnDownloadLoggingMessage";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string FileDetailsForDownloadNotFoundErrorMessage = "JCCSems_Shared_FileUploader_NotificationMessage_FileDetailsForDownloadNotFoundErrorMessage";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string FileVersionCannotBeBlank = "JCCSems_Shared_FileUploader_NotificationMessage_FileVersionCannotBeBlank";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string NewFileVersionUploadedSuccess = "JCCSems_Shared_FileUploader_NotificationMessage_NewFileVersionUploadedSuccess";

                    /// <summary>
                    /// File not found error message while downloading file
                    /// </summary>
                    public const string NewFileVersionUploadedFailure = "JCCSems_Shared_FileUploader_NotificationMessage_NewFileVersionUploadedFailure";
                }

                /// <summary>
                /// File detail static class conatins all resource keys for button and labels to be shown on file detail at file uploader
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class FileDetail
                {
                    /// <summary>
                    /// Labels static class conatins all resource keys for labels to be shown on file uploader
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        /// <summary>
                        /// File uploader file detail title label text
                        /// </summary>
                        public const string Header = "JCCSems_Shared_FileUploader_FileDetail_Labels_Header";

                        /// <summary>
                        /// File uploader file detail title label text
                        /// </summary>
                        public const string Title = "JCCSems_Shared_FileUploader_FileDetail_Labels_Title";

                        /// <summary>
                        /// File uploader file detail file name label text
                        /// </summary>
                        public const string FileName = "JCCSems_Shared_FileUploader_FileDetail_Labels_FileName";

                        /// <summary>
                        /// File uploader file detail file type label text
                        /// </summary>
                        public const string FileType = "JCCSems_Shared_FileUploader_FileDetail_Labels_FileType";

                        /// <summary>
                        /// File uploader file detail file type label text
                        /// </summary>
                        public const string DocumentType = "JCCSems_Shared_FileUploader_FileDetail_Labels_DocumentType";

                        /// <summary>
                        /// File uploader file detail type label text
                        /// </summary>
                        public const string Type = "JCCSems_Shared_FileUploader_FileDetail_Labels_Type";

                        /// <summary>
                        /// File uploader file detail uploaded date label text
                        /// </summary>
                        public const string UploadedDate = "JCCSems_Shared_FileUploader_FileDetail_Labels_UploadedDate";

                        /// <summary>
                        /// File uploader file detail description label text
                        /// </summary>
                        public const string Description = "JCCSems_Shared_FileUploader_FileDetail_Labels_Description";

                        /// <summary>
                        /// File uploader file detail upload document label text
                        /// </summary>
                        public const string UploadDocument = "JCCSems_Shared_FileUploader_FileDetail_Labels_UploadDocument";

                        /// <summary>
                        /// File uploader file detail file type label text
                        /// </summary>
                        public const string FileTypeDropDownDefaultValue = "JCCSems_Shared_FileUploader_FileDetail_Labels_FileTypeDropDownDefaultValue";
                    }

                    /// <summary>
                    /// Button static class conatins all resource keys for button to be shown on file detail at file uploader
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Buttons
                    {
                        /// <summary>
                        /// Close button text
                        /// </summary>
                        public const string Close = "JCCSems_Shared_FileUploader_FileDetail_Buttons_Close";

                        /// <summary>
                        /// Save changes button text
                        /// </summary>
                        public const string SaveChanges = "JCCSems_Shared_FileUploader_FileDetail_Buttons_SaveChanges";

                        /// <summary>
                        /// Save changes button text
                        /// </summary>
                        public const string Save = "JCCSems_Shared_FileUploader_FileDetail_Buttons_Save";

                        /// <summary>
                        /// Delete changes button text
                        /// </summary>
                        public const string Delete = "JCCSems_Shared_FileUploader_FileDetail_Buttons_Delete";
                    }

                    /// <summary>
                    /// Class for validation message 
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Validation
                    {
                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileTitleRequired = "JCCSems_Shared_FileUploader_FileDetail_Validation_FileTitleRequired";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileTitleMaxLength = "JCCSems_Shared_FileUploader_FileDetail_Validation_FileTitleMaxLength";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDescriptionMaxLength = "JCCSems_Shared_FileUploader_FileDetail_Validation_FileDescriptionMaxLength";

                        /// <summary>
                        /// File description required validation message
                        /// </summary>
                        public const string FileDescriptionRequired = "JCCSems_Shared_FileUploader_FileDetail_Validation_FileDescriptionRequired";

                        /// <summary>
                        /// File type required validation message
                        /// </summary>
                        public const string FileTypeRequired = "JCCSems_Shared_FileUploader_FileDetail_Validation_FileTypeRequired";
                    }

                    /// <summary>
                    /// Class for Constants key for file detail notifications messages need to show for operation result
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDataUpdateSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDataUpdateSuccess";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDataUpdateFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDataUpdateFailure";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDeleteFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDeleteFailure";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDeleteSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDeleteSuccess";

                        /// <summary>
                        /// File types fetched successfully
                        /// </summary>
                        public const string FileTypesFetchedSuccessfully = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileTypesFetchedSuccessfully";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileTypesFetchedFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileTypesFetchedFailure";

                        /// <summary>
                        /// File types fetched successfully
                        /// </summary>
                        public const string FileDetailFetchedSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDetailFetchedSuccess";

                        /// <summary>
                        /// File title required validation message
                        /// </summary>
                        public const string FileDetailFetchedFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDetailFetchedFailure";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string FileDetailsSavedSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDetailsSavedSuccess";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string FileDetailsSavedFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FileDetailsSavedFailure";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string FetchFileExtensiosnSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FetchFileExtensiosnSuccess";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string FetchFileExtensiosnFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_FetchFileExtensiosnFailure";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string UpdateFileDataSuccess = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_UpdateFileDataSuccess";

                        /// <summary>
                        /// File not found error message while downloading file
                        /// </summary>
                        public const string UpdateFileDataFailure = "JCCSems_Shared_FileUploader_FileDetail_NotificationMessage_UpdateFileDataFailure";
                    }
                }
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Portal
            {
                public const string Admin = "JCCSems_Shared_Portal_AdminPortal";
                public const string Client = "JCCSems_Shared_Portal_ClientPortal";
            }
        }

        /// <summary>
        /// Class for Constants for Layout
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Layout
        {
            /// <summary>
            /// Class for Constants for Preferences
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Preferences
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string DefaultClient = "JCCSems_Layout_Preferences_Labels_DefaultClient";
                    public const string DefaultModule = "JCCSems_Layout_Preferences_Labels_DefaultModule";
                    public const string SelectClient = "JCCSems_Layout_Preferences_Labels_SelectClient";
                }
                /// <summary>
                /// Class for Constants for messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string SettingsUpdatedSuccess = "JCCSems_Layout_Preferences_Labels_SettingsUpdated";
                    public const string SettingsUpdateFailure = "JCCSems_Layout_Preferences_Labels_SettingsUpdateFailure";
                    public const string SettingsNotAvailable = "JCCSems_Layout_Preferences_Labels_SettingsNotAvailable";
                }
            }

            /// <summary>
            /// Class for Constants for Main menu
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class MainMenu
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string NoClientsSubscribed = "JCCSems_Layout_Preferences_Labels_NoClientsSubscribed";
                    public const string NoRecordFound = "JCCSems_Layout_Preferences_Labels_NoRecordFound";
                }
            }
        }

        /// <summary>
        /// Class for Constants for Account
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Account
        {
            /// <summary>
            /// Class for Constants for Login
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Login
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string ToggleNavigation = "JCCSems_Account_Login_Labels_ToggleNavigation";
                    public const string Actions = "JCCSems_Account_Login_Labels_Actions";
                    public const string UserNamePlaceholder = "JCCSems_Account_Login_Labels_UserNamePlaceholder";
                    public const string PasswordPlaceholder = "JCCSems_Account_Login_Labels_PasswordPlaceholder";
                    public const string RememberMe = "JCCSems_Account_Login_Labels_RememberMe";
                    public const string ForgotPassword = "JCCSems_Account_Login_Labels_ForgotPassword";
                    public const string Login = "JCCSems_Account_Login_Labels_Login";
                    public const string Logout = "JCCSems_Account_Login_Labels_Logout";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string UserNameRequired = "JCCSems_Account_Login_Validation_UserNameRequired";
                    public const string PasswordRequired = "JCCSems_Account_Login_Validation_PasswordRequired";
                    public const string UserNameLength = "JCCSems_Account_Login_Validation_UserNameLength";
                    public const string InvalidUser = "JCCSems_Account_Login_Validation_InvalidUser";
                    public const string Locked = "JCCSems_Account_Login_Validation_Locked";
                    public const string LockedTime = "JCCSems_Account_Login_Validation_LockedTime";
                }
            }

            /// <summary>
            /// Class for Constants for Account Content
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AccountContent
            {
                /// <summary>
                /// Class for Constants for Home
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Home
                {
                    /// <summary>
                    /// Class for Constants for Home
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string LeftHeader = "JCCSems_Account_AccountContent_Home_Labels_LeftHeader";
                        public const string LeftLink = "JCCSems_Account_AccountContent_Home_Labels_LeftLink";
                        public const string LeftContent = "JCCSems_Account_AccountContent_Home_Labels_LeftContent";
                        public const string RightHeader = "JCCSems_Account_AccountContent_Home_Labels_RightHeader";
                        public const string RightLink = "JCCSems_Account_AccountContent_Home_Labels_RightLink";
                        public const string RightContent = "JCCSems_Account_AccountContent_Home_Labels_RightContent";
                        public const string LearnAboutTrainingCourses = "JCCSems_Account_AccountContent_Home_Labels_LearnAboutTrainingCourses";
                    }
                }
            }

            /// <summary>
            /// Class for Constants for Navigation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Navigation
            {
                public const string Home = "JCCSems_Account_Navigation_Home";
                public const string About = "JCCSems_Account_Navigation_About";
                public const string Contact = "JCCSems_Account_Navigation_Contact";
            }

            /// <summary>
            /// Class for Constants for Change password
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ChangePassword
            {
                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Index
                {
                    public const string Title = "JCCSems_Account_ChangePassword_Index_Title";
                    public const string Heading = "JCCSems_Account_ChangePassword_Index_Heading";
                }

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string OldPassword = "JCCSems_Account_ChangePassword_Labels_OldPassword";
                    public const string NewPassword = "JCCSems_Account_ChangePassword_Labels_NewPassword";
                    public const string ConfirmPassword = "JCCSems_Account_ChangePassword_Labels_ConfirmPassword";
                    public const string Save = "JCCSems_Account_ChangePassword_Labels_Save";
                    public const string Cancel = "JCCSems_Account_ChangePassword_Labels_Cancel";

                    public const string Success = "JCCSems_Account_ChangePassword_Labels_Success";
                    public const string Faliure = "JCCSems_Account_ChangePassword_Labels_Faliure";
                    public const string Ok = "JCCSems_Account_ChangePassword_Labels_Ok";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string OldPasswordRequired = "JCCSems_Account_ChangePassword_Validation_OldPasswordRequired";
                    public const string NewPasswordRequired = "JCCSems_Account_ChangePassword_Validation_NewPasswordRequired";
                    public const string ConfirmPasswordRequired = "JCCSems_Account_ChangePassword_Validation_ConfirmPasswordRequired";
                    public const string OldPasswordLengthExceeds = "JCCSems_Account_ChangePassword_Validation_OldPasswordLengthExceeds";
                    public const string NewPasswordLengthExceeds = "JCCSems_Account_ChangePassword_Validation_NewPasswordLengthExceeds";
                    public const string ConfirmPasswordLengthExceeds = "JCCSems_Account_ChangePassword_Validation_ConfirmPasswordLengthExceeds";
                    public const string ConfirmPasswordNotMatch = "JCCSems_Account_ChangePassword_Validation_ConfirmPasswordNotMatch";
                    public const string OldPasswordNotMatched = "JCCSems_Account_ChangePassword_Validation_OldPasswordNotMatched";
                    public const string ModelInvalid = "JCCSems_Account_ChangePassword_Validation_ModelInvalid";
                    public const string UserNotExists = "JCCSems_Account_ChangePassword_Validation_UserNotExists";
                    public const string NewAndOldPasswordIsSame = "JCCSems_Account_ChangePassword_Validation_NewAndOldPasswordIsSame";
                    public const string PasswordFormatInvalid = "JCCSems_Account_ChangePassword_Validation_PasswordFormatInvalid";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string PasswordChangedSuccessfully = "JCCSems_Account_ChangePassword_NotificationMessage_PasswordChangedSuccessfully";
                }
            }

            /// <summary>
            /// Class for Constants for Dispatching Email
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class EmailDispatch
            {

                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string TemplateBodyExpression = "JCCSems_Account_EmailDispatch_Labels_TemplateBodyExpression";
                }
            }

            /// <summary>
            /// Class for Constants for Forgot password
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ForgotPassword
            {
                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Index
                {
                    public const string Title = "JCCSems_Account_ForgotPassword_Index_Title";
                    public const string Heading = "JCCSems_Account_ForgotPassword_Index_Heading";
                }

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string UserNameOrEmail = "JCCSems_Account_ForgotPassword_Labels_UserNameOrEmail";
                    public const string BackToLogin = "JCCSems_Account_ForgotPassword_Labels_BackToLogin";
                    public const string Proceed = "JCCSems_Account_ForgotPassword_Labels_Proceed";
                    public const string PasswordAssistance = "JCCSems_Account_ForgotPassword_Labels_PasswordAssistance";
                    public const string ClickToLogin = "JCCSems_Account_ForgotPassword_Labels_ClickToLogin";
                    public const string PasswordContext = "JCCSems_Account_ForgotPassword_Labels_PasswordContext";
                    public const string Success = "JCCSems_Account_ForgotPassword_Labels_Success";
                    public const string Faliure = "JCCSems_Account_ForgotPassword_Labels_Faliure";
                    public const string Ok = "JCCSems_Account_ForgotPassword_Labels_Ok";
                    public const string TemplateBodyExpression = "JCCSems_Account_ForgotPassword_Labels_TemplateBodyExpression";
                    public const string ForgotPassword = "JCCSems_Account_ForgotPassword_Labels_ForgotPassword";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string EmailRequired = "JCCSems_Account_ForgotPassword_Validation_EmailRequired";
                    public const string EmailInvalidFormat = "JCCSems_Account_ForgotPassword_Validation_EmailInvalid";
                    public const string EmailLengthExceeds = "JCCSems_Account_ForgotPassword_Validation_EmailLengthExceeds";
                    public const string UserNotExists = "JCCSems_Account_ForgotPassword_Validation_UserNotExists";
                    public const string ModelInvalid = "JCCSems_Account_ForgotPassword_Validation_ModelInvalid";
                }

                /// <summary>
                /// Class for Constants for Notification Message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string PasswordSendSuccessfully = "JCCSems_Account_ForgotPassword_NotificationMessage_PasswordSendSuccessfully";
                }

                /// <summary>
                /// Class for Constants for Error
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Error
                {
                    public const string EmailSendFaliure = "JCCSems_Account_ForgotPassword_Error_EmailSendFaliure";
                }
            }
        }

        /// <summary>
        /// Class for Constants for Role
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Role
        {
            /// <summary>
            /// Class for Constants for Index
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_Role_Index_Title";
                public const string Heading = "JCCSems_Role_Index_Heading";

                /// <summary>
                /// Class for Constants for Label
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string ManageRoles = "JCCSems_Role_Index_Labels_ManageRoles";
                    public const string AddRole = "JCCSems_Role_Index_Labels_AddRole";
                    public const string EmptyResultText = "JCCSems_Role_Index_Labels_EmptyResultText";
                    public const string FailedToFetchRoles = "JCCSems_Role_Index_Labels_FailedToFetchRoles";
                }
                /// <summary>
                /// Class for Constants for Tooltip
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Tooltip
                {
                    public const string Edit = "JCCSems_Role_Index_Tooltip_Edit";
                    public const string NoPermissionToEdit = "JCCSems_Role_Index_Tooltip_NoPermissionToEdit";
                    public const string AssignUsers = "JCCSems_Role_Index_Tooltip_AssignUsers";
                    public const string NoPermissionToAssignUsers = "JCCSems_Role_Index_Tooltip_NoPermissionToAssignUsers";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string ActivateRoleOnAllSystemTitle = "JCCSems_Role_Index_NotificationMessage_ActivateRoleOnAllSystemTitle";
                    public const string ActivateRoleOnAllSystemMessageText = "JCCSems_Role_Index_NotificationMessage_ActivateRoleOnAllSystemMessageText";
                    public const string DeActivateRoleOnAllSystemTitle = "JCCSems_Role_Index_NotificationMessage_DeActivateRoleOnAllSystemTitle";
                    public const string DeActivateRoleOnAllSystemMessageText = "JCCSems_Role_Index_NotificationMessage_DeActivateRoleOnAllSystemMessageText";
                    public const string RoleNotFound = "JCCSems_Role_Index_NotificationMessage_RoleNotFound";
                    public const string SaveSuccessfully = "JCCSems_Role_Index_NotificationMessage_SaveSuccessfully";
                    public const string ActivateRoleStatusSuccessText = "JCCSems_Role_Index_NotificationMessage_ActivateRoleStatusSuccessText";
                    public const string DeactivateRoleStatusSuccessText = "JCCSems_Role_Index_NotificationMessage_DeactivateRoleStatusSuccessText";
                    public const string UpdateRoleFailedText = "JCCSems_Role_Index_NotificationMessage_UpdateRoleFailedText";
                }

                /// <summary>
                /// Class for Constants for Role user association
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class RoleUserAssociation
                {
                    public const string Heading = "JCCSems_Role_Index_RoleUserAssociation_Heading";
                    /// <summary>
                    /// Class for Constants for Label
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string SaveChanges = "JCCSems_Role_Index_RoleUserAssociation_Labels_SaveChanges";
                        public const string Close = "JCCSems_Role_Index_RoleUserAssociation_Labels_Close";
                        public const string LeftListHeader = "JCCSems_Role_Index_RoleUserAssociation_Labels_LeftListHeader";
                        public const string RightListHeader = "JCCSems_Role_Index_RoleUserAssociation_Labels_RightListHeader";
                        public const string FailedToFetchResult = "JCCSems_Role_Index_RoleUserAssociation_Labels_FailedToFetchResult";
                    }

                    /// <summary>
                    /// Class for Constants for notification messages
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessages
                    {
                        public const string SaveSuccess = "JCCSems_Role_Index_RoleUserAssociation_NotificationMessages_SaveSuccess";
                        public const string SaveFailure = "JCCSems_Role_Index_RoleUserAssociation_NotificationMessages_SaveFailure";
                    }
                }
            }

            /// <summary>
            /// Class for Constants for CreateEditRole
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CreateEditRole
            {

                public const string AddRoleTitle = "JCCSems_Role_CreateEditRole_AddRoleTitle";
                public const string EditRoleTitle = "JCCSems_Role_CreateEditRole_EditRoleTitle";
                public const string AddRoleHeading = "JCCSems_Role_CreateEditRole_AddRoleHeading";
                public const string EditRoleHeading = "JCCSems_Role_CreateEditRole_EditRoleHeading";
                public const string CreateRolePostAction = "JCCSems_Role_CreateEditRole_CreateRolePostAction";
                public const string EditRolePostAction = "JCCSems_Role_CreateEditRole_EditRolePostAction";
                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string RoleNameRequired = "JCCSems_Role_CreateEditRole_Validation_RoleNameRequired";
                    public const string RoleRankMandatory = "JCCSems_Role_CreateEditRole_Validation_RoleRankMandatory";
                    public const string RoleNameUnique = "JCCSems_Role_CreateEditRole_Validation_RoleNameUnique";
                    public const string RoleNameLength = "JCCSems_Role_CreateEditRole_Validation_RoleNameLength";
                    public const string RoleDescriptionLength = "JCCSems_Role_CreateEditRole_Validation_RoleDescriptionLength";
                    public const string FailedToCreateRole = "JCCSems_Role_CreateEditRole_Validation_FailedToCreateRole";
                    public const string FailedToUpdateRole = "JCCSems_Role_CreateEditRole_Validation_FailedToUpdateRole";
                    public const string SelectAtleastOneCompany = "JCCSems_Role_CreateEditRole_Validation_SelectAtleastOneCompany";
                    public const string FailedToRetrieveAllFeatures = "JCCSems_Role_CreateEditRole_Validation_FailedToRetrieveAllFeatures";
                }

                /// <summary>
                /// Class for Constants for Label
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Label
                {
                    public const string RoleName = "JCCSems_Role_CreateEditRole_Label_RoleName";
                    public const string RoleDescription = "JCCSems_Role_CreateEditRole_Label_RoleDescription";
                    public const string RoleRank = "JCCSems_Role_CreateEditRole_Label_RoleRank";
                    public const string IsActive = "JCCSems_Role_CreateEditRole_Label_IsActive";
                    public const string IsActiveRoleCondition = "JCCSems_Role_CreateEditRole_Label_IsActiveRoleCondition";
                    public const string IsGlobal = "JCCSems_Role_CreateEditRole_Label_IsGlobal";
                    public const string IsGlobalApplicableMessage = "JCCSems_Role_CreateEditRole_Label_IsGlobalApplicableMessage";
                    public const string AddEditRoleTitle = "JCCSems_Role_CreateEditRole_Label_AddEditRoleTitle";
                    public const string IndicateRequiredField = "JCCSems_Role_CreateEditRole_Label_IndicateRequiredField";
                    public const string AssignFeature = "JCCSems_Role_CreateEditRole_Label_AssignFeature";
                    public const string SelectAll = "JCCSems_Role_CreateEditRole_Label_SelectAll";
                    public const string LeftListHeader = "JCCSems_Role_CreateEditRole_Label_LeftListHeader";
                    public const string RightListHeader = "JCCSems_Role_CreateEditRole_Label_RightListHeader";
                    public const string SelectCompanies = "JCCSems_Role_CreateEditRole_Label_SelectCompanies";
                }

                /// <summary>
                /// Class for Constants for NotificationMessages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string LoggedInUserHasHigherRank = "JCCSems_Role_CreateEditRole_NotificationMessages_LoggedInUserHasHigherRank";
                    public const string FailedToReadRoleDetails = "JCCSems_Role_CreateEditRole_NotificationMessages_FailedToReadRoleDetails";
                    public const string FailedToReadAllFeatureActions = "JCCSems_Role_CreateEditRole_NotificationMessages_FailedToReadAllFeatureActions";
                    public const string SavedRoleSuccessfully = "JCCSems_Role_CreateEditRole_NotificationMessages_SavedRoleSuccessfully";
                    public const string DetachedRoleConfirmation = "JCCSems_Role_CreateEditRole_NotificationMessages_DetachedRoleConfirmation";
                    public const string DetachedRoleConfirmationTitle = "JCCSems_Role_CreateEditRole_NotificationMessages_DetachedRoleConfirmationTitle";
                    public const string SaveRoleConfirmationTitle = "JCCSems_Role_CreateEditRole_NotificationMessages_SaveRoleConfirmationTitle";
                    public const string NoOrganizationFound = "JCCSems_Role_CreateEditRole_NotificationMessages_NoOrganizationFound";
                }

                /// Class for Constants for Label
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Button
                {
                    public const string Save = "JCCSems_Role_CreateEditRole_Button_Save";
                    public const string Cancel = "JCCSems_Role_CreateEditRole_Button_Cancel";
                }
            }
        }

        /// <summary>
        /// Class NewCompanyVerification.
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class NewCompanyVerification
        {
            /// <summary>
            /// Class NewCompanyRequest.
            /// </summary>
            public static class NewCompanyRequest
            {
                /// <summary>
                /// Class Labels.
                /// </summary>
                public static class Labels
                {
                    public const string NewCompanyRequestMessage = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_NewCompanyRequestMessage";
                    public const string UserEnteredInformation = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_UserEnteredInformation";
                    public const string SystemInformation = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_SystemInformation";
                    public const string CompanyName = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_CompanyName";
                    public const string PointOfContact = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_PointOfContact";
                    public const string Email = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_Email";
                    public const string Subscriber = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_Subscriber";
                    public const string Comments = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_Comments";
                    public const string SelectCompany = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_SelectCompany";
                    public const string SelectPointOfContact = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_SelectPointOfContact";
                    public const string NewCompanyViewMessage = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_NewCompanyViewMessage";
                    public const string ClickToViewAffiliationDetails = "JCCSems_NewCompanyVerification_NewCompanyRequest_Labels_ClickToViewAffiliationDetails";
                }

                /// <summary>
                /// Class Buttons.
                /// </summary>
                public static class Buttons
                {
                    public const string Verify = "JCCSems_NewCompanyVerification_NewCompanyRequest_Buttons_Verify";
                    public const string MergeAndVerify = "JCCSems_NewCompanyVerification_NewCompanyRequest_Buttons_MergeAndVerify";
                    public const string Cancel = "JCCSems_NewCompanyVerification_NewCompanyRequest_Buttons_Cancel";
                }
            }
            /// <summary>
            /// Class Index.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_NewCompanyVerification_Index_Title";
                public const string Heading = "JCCSems_NewCompanyVerification_Index_Heading";
            };

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Labels
            {
                public const string NewCompanyRequest = "JCCSems_NewCompanyVerification_Labels_NewCompanyRequest";
                public const string EmptyResultText = "JCCSems_NewCompanyVerification_Labels_EmptyResultText";
                public const string FailedToFetchNewCompanyVerifyData =
                                   "JCCSems_NewCompanyVerification_Labels_FailedToFetchNewCompanyVerifyData";
                public const string NewCompanyVerification = "JCCSems_NewCompanyVerification_Labels_NewCompanyVerification";
                public const string PendingNewCompanyVerification = "JCCSems_NewCompanyVerification_Labels_PendingNewCompanyVerification";
                public const string VerifiedCompany = "JCCSems_NewCompanyVerification_Labels_VerifiedCompany";
                public const string NewCompanyReview = "JCCSems_NewCompanyVerification_Labels_NewCompanyReview";
            };

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ToolTipText
            {
                public const string VerifyNewCompany = "JCCSems_NewCompanyVerification_ToolTipText_ReviewNewCompany";
                public const string NoPermissionToVerifyNewCompany =
                                    "JCCSems_NewCompanyVerification_ToolTipText_NoPermissionToVerifyNewCompany";
                public const string ViewNewCompany = "JCCSems_NewCompanyVerification_ToolTipText_ViewNewCompany";
                public const string NoPermissionToViewNewCompany =
                                    "JCCSems_NewCompanyVerification_ToolTipText_NoPermissionToViewNewCompany";
            }
        }


        /// <summary>
        /// Class Merge POB Records.
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class MergePOBRecords
        {
            /// <summary>
            /// Class Index.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_MergePOBRecords_Index_Title";
                public const string Heading = "JCCSems_MergePOBRecords_Index_Heading";
            };

            /// <summary>
            /// Class Labels.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Labels
            {
                public const string NewEmployeeRecords = "JCCSems_MergePOBRecords_Labels_NewEmployeeRecords";
                public const string SelectOperatorCompany = "JCCSems_MergePOBRecords_Labels_SelectOperatorCompany";
                public const string SelectedEmployeesToMerge = "JCCSems_MergePOBRecords_Labels_SelectedEmployeesToMerge";
                public const string EmptyResultText = "JCCSems_MergePOBRecords_Labels_EmptyResultText";
                public const string Continue = "JCCSems_MergePOBRecords_Labels_Continue";
                public const string SelectCompanyFromTrainingRecords = "JCCSems_MergePOBRecords_Labels_SelectCompanyFromTrainingRecords";
                public const string CompanyRecords = "JCCSems_MergePOBRecords_Labels_CompanyRecords";
                public const string FailedToFetchOperatorCompanyData = "JCCSems_MergePOBRecords_Labels_FailedToFetchOperatorCompanyData";
                public const string FailedToFetchTrainingRecordsData = "JCCSems_MergePOBRecords_Labels_FailedToFetchTrainingRecordsData";
                public const string SearchAsYouType = "JCCSems_MergePOBRecords_Labels_SearchAsYouType";
                public const string ReviewAndMerge = "JCCSems_MergePOBRecords_Labels_ReviewAndMerge";
                public const string SelectEmployees = "JCCSems_MergePOBRecords_Labels_SelectEmployees";
                public const string POBUserEnteredInformation = "JCCSems_MergePOBRecords_Labels_POBUserEnteredInformation";
                public const string LeftListHeader = "JCCSems_MergePOBRecords_Labels_LeftListHeader";
                public const string RightListHeader = "JCCSems_MergePOBRecords_Labels_RightListHeader";
                public const string CompanyEmployees = "JCCSems_MergePOBRecords_Labels_CompanyEmployees";
                public const string POBEmployees = "JCCSems_MergePOBRecords_Labels_POBEmployees";
                public const string JobTitle = "JCCSems_MergePOBRecords_Labels_JobTitle";
                public const string JobTitles = "JCCSems_MergePOBRecords_Labels_JobTitles";
                public const string LastName = "JCCSems_MergePOBRecords_Labels_LastName";
                public const string FirstName = "JCCSems_MergePOBRecords_Labels_FirstName";
                public const string CompanyName = "JCCSems_MergePOBRecords_Labels_CompanyName";
                public const string IndicatesRequiredField = "JCCSems_MergePOBRecords_Labels_IndicatesRequiredField";
                public const string Merge = "JCCSems_MergePOBRecords_Labels_Merge";
                public const string Cancel = "JCCSems_MergePOBRecords_Labels_Cancel";
                public const string SelectCompany = "JCCSems_MergePOBRecords_Labels_SelectCompany";
                public const string SelectCompanyHeader = "JCCSems_MergePOBRecords_Labels_SelectCompanyHeader";
            };

            /// <summary>
            /// Class Validation.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Validation
            {
                public const string FirstNameRequired = "JCCSems_MergePOBRecords_Validation_FirstNameRequired";
                public const string LastNameRequired = "JCCSems_MergePOBRecords_Validation_LastNameRequired";
                public const string CompanyNameIsRequired = "JCCSems_MergePOBRecords_Validation_CompanyNameIsRequired";
                public const string FirstNameLengthExceeds = "JCCSems_MergePOBRecords_Validation_FirstNameLengthExceeds";
                public const string LastNameLengthExceeds = "JCCSems_MergePOBRecords_Validation_LastNameLengthExceeds";
            };

            /// <summary>
            /// Class NotificationMessages.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class NotificationMessages
            {
                public const string CompanyDetailsNotFound = "JCCSems_MergePOBRecords_NotificationMessages_CompanyDetailsNotFound";
                public const string SelectOneMoreEmployeeToMerge = "JCCSems_MergePOBRecords_NotificationMessages_SelectOneMoreEmployeeToMerge";
                public const string SelectMoreThanOneOperatorCompanyEmployee =
                                "JCCSems_MergePOBRecords_NotificationMessages_SelectMoreThanOneOperatorCompanyEmployee";
                public const string SelectMoreThanOneEmployee =
                                "JCCSems_MergePOBRecords_NotificationMessages_SelectMoreThanOneEmployee";
                public const string FacilityIndividualDetailsNotFound =
                                "JCCSems_MergePOBRecords_NotificationMessages_FacilityIndividualDetailsNotFound";
                public const string EmployeeTrainingInfoRecordsNotFound =
                                "JCCSems_MergePOBRecords_NotificationMessages_EmployeeTrainingInfoRecordsNotFound";
                public const string JobTitlesForOrganizationNotFound =
                                "JCCSems_MergePOBRecords_NotificationMessages_JobTitlesForOrganizationNotFound";
                public const string EmployeeMergedSuccessfully =
                                "JCCSems_MergePOBRecords_NotificationMessages_EmployeeMergedSuccessfully";
                public const string EmployeeRecordsNotMerged =
                                 "JCCSems_MergePOBRecords_NotificationMessages_EmployeeRecordsNotMerged";
            }
        }

        /// <summary>
        /// Class for Constants for Subscription Requests
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class SubscriptionRequests
        {
            /// Class for Constants for Index of Subscription Requests
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_SubscriptionRequests_Index_Title";
                public const string Heading = "JCCSems_SubscriptionRequests_Index_Heading";
            }

            /// Class for Constants for Labels of Subscription Requests
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Labels
            {
                public const string EmptyResultText = "JCCSems_SubscriptionRequests_Labels_EmptyResultText";
                public const string SubscriptionRequests = "JCCSems_SubscriptionRequests_Labels_SubscriptionRequests";
                public const string PendingSubscriptionRequests = "JCCSems_SubscriptionRequests_Labels_PendingSubscriptionRequests";
                public const string ApprovedOrDeclinedSubscriptionRequests =
                                    "JCCSems_SubscriptionRequests_Labels_ApprovedOrDeclinedSubscriptionRequests";
                public const string FailedToFetchSubscriptionData =
                                    "JCCSems_SubscriptionRequests_Labels_FailedToFetchSubscriptionData";
                public const string SubscriptionReview = "JCCSems_SubscriptionRequests_Labels_SubscriptionReview";
                public const string CompanySubscriptionRequestDenied = "JCCSems_SubscriptionRequests_Labels_CompanySubscriptionRequestDenied";
                public const string CompanySubscriptionRequestAccepted = "JCCSems_SubscriptionRequests_Labels_CompanySubscriptionRequestAccepted";
                public const string ApproveSubscription = "JCCSems_SubscriptionRequests_Labels_ApproveSubscription";
                public const string BillingAdminComments = "JCCSems_SubscriptionRequests_Labels_BillingAdminComments";
                public const string Approve = "JCCSems_SubscriptionRequests_Labels_Approve";
                public const string Decline = "JCCSems_SubscriptionRequests_Labels_Decline";
                public const string Cancel = "JCCSems_SubscriptionRequests_Labels_Cancel";
                public const string CommentsNotProvided = "JCCSems_SubscriptionRequests_Labels_CommentsNotProvided";
            };

            /// Class for Constants for ToolTipText of Subscription Requests
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ToolTipText
            {
                public const string ReviewSubscription = "JCCSems_SubscriptionRequests_ToolTipText_ReviewSubscription";
                public const string NoPermissionToReviewSubscription =
                                    "JCCSems_SubscriptionRequests_ToolTipText_NoPermissionToReviewSubscription";
                public const string ViewSubscription = "JCCSems_SubscriptionRequests_ToolTipText_ViewSubscription";
                public const string NoPermissionToViewSubscription =
                                    "JCCSems_SubscriptionRequests_ToolTipText_NoPermissionToViewSubscription";
            }

            /// Class for Constants for Notification Messages of Subscription Requests
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class NotificationMessages
            {
                public const string SubscriptionApprovalEmailNotSent =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionApprovalEmailNotSent";
                public const string SubscriptionDeclineEmailNotSent =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionDeclineEmailNotSent";
                public const string SubscriptionApproved =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionApproved";
                public const string SubscriptionDeclined =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionDeclined";
                public const string SubscriptionNotApproved =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionNotApproved";
                public const string SubscriptionNotDeclined =
                                        "JCCSems_SubscriptionRequests_NotificationMessages_SubscriptionNotDeclined";

            }

            /// Class for Constants for Validation of Subscription Requests
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Validation
            {
                public const string CommentsLengthExceeds = "JCCSems_SubscriptionRequests_Validation_CommentsLengthExceeds";
            }
        }

        /// <summary>
        /// Class for Constants for Training
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Training
        {
            /// <summary>
            /// Class for Constants for TrainingPlan
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class TrainingPlan
            {
                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Index
                {
                    public const string TrainingPlanHeading = "JCCSems_Training_TrainingPlan_Index_TrainingPlanHeading";
                    public const string PageTitle = "JCCSems_Training_TrainingPlan_Index_PageTitle";

                    /// <summary>
                    /// Class for Constants for Error
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Messages
                    {
                        public const string FetchAffiliationTypesSuccess = "JCCSems_Training_TrainingPlan_Index_Error_FetchAffiliationTypesSuccess";
                        public const string FailedToFetchAffiliationTypes = "JCCSems_Training_TrainingPlan_Index_Error_FailedToFetchAffiliationTypes";
                        public const string FailedToFetchTrainingCompanies = "JCCSems_Training_TrainingPlan_Index_Error_FailedToFetchTrainingCompanies";
                        public const string FetchCertificateRegulationsSuccess = "JCCSems_Training_TrainingPlan_Index_Error_FetchCertificateRegulationsSuccess";
                        public const string FetchCertificateRegulationsFailure = "JCCSems_Training_TrainingPlan_Index_Error_FetchCertificateRegulationsFailure";

                        public const string FetchCertificateFrequenciesSuccess = "JCCSems_Training_TrainingPlan_Index_Error_FetchCertificateFrequenciesSuccess";
                        public const string FetchCertificateFrequenciesFailure = "JCCSems_Training_TrainingPlan_Index_Error_FetchCertificateFrequenciesFailure";
                        public const string FetchAffiliationFailure = "JCCSems_Training_TrainingPlan_Index_Error_FetchAffiliationFailure";
                    }

                    /// <summary>
                    /// Class for Constants for Error
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string ManageJobTitleHeading = "JCCSems_Training_TrainingPlan_Index_Labels_ManageJobTitleHeading";
                        public const string Actions = "JCCSems_Training_TrainingPlan_Index_Labels_Actions";
                        public const string JobTitle = "JCCSems_Training_TrainingPlan_Index_Labels_JobTitle";
                        public const string TrainingPlanHeading = "JCCSems_Training_TrainingPlan_Index_Labels_TrainingPlanHeading";
                        public const string PleaseSelectACompanyFirst = "JCCSems_Training_TrainingPlan_Index_Labels_PleaseSelectACompanyFirst";
                        public const string MyCompany = "JCCSems_Training_TrainingPlan_Index_Labels_MyCompany";
                        public const string Unknown = "JCCSems_Training_TrainingPlan_Index_Labels_Unknown";
                        public const string Other = "JCCSems_Training_TrainingPlan_Index_Labels_Other";
                        public const string ViewAffiliation = "JCCSems_Training_TrainingPlan_Index_Labels_ViewAffiliation";

                    }
                }

                /// <summary>
                /// Class for Constants for CreateEditJobTitle
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class CreateEditJobTitle
                {
                    public const string CreateJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_CreateJobTitle";
                    public const string CreateJobTitleHeading = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_CreateJobTitleHeading";
                    public const string EditJobTitleHeading = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_EditJobTitleHeading";
                    public const string EditJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_EditJobTitle";

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string IndicateRequiredField = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_IndicateRequiredField";
                        public const string JobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_JobTitle";
                        public const string JobTitleRequiredForAllCertifications = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_JobTitleRequiredForAllCertifications";
                        public const string Certifications = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_Certifications";
                        public const string LeftListHeader = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_LeftListHeader";
                        public const string RightListHeader = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_RightListHeader";
                        public const string CertificatesForAllJobTitles = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_CertificatesForAllJobTitles";
                        public const string EditJobTitleTooltip = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_EditJobTitleTooltip";
                        public const string NoPermissionToEditJobTitleTooltip = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_NoPermissionToEditJobTitleTooltip";
                        public const string DeleteJobTitleTooltip = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_DeleteJobTitleTooltip";
                        public const string NoPermissionToDeleteJobTitleTooltip = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_NoPermissionToDeleteJobTitleTooltip";
                        public const string AddNewCertification = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_AddNewCertification";
                        public const string JobTitleNotMapped = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_JobTitleNotMapped";
                        public const string JobTitleDropDownPlaceHolder = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_JobTitleDropDownPlaceHolder";
                        public const string SelectJobTitleItem = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Labels_SelectJobTitleItem";
                    }

                    /// <summary>
                    /// Class for Constants for tool tips
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory,SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory,SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class ToolTips
                    {
                        public const string AddJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_ToolTips_AddJobTitle";
                        public const string Edit = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_ToolTips_EditJobTitle";
                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Buttons
                    {
                        public const string CheckAvailability = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_CheckAvailability";
                        public const string Save = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_Save";
                        public const string Cancel = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_Cancel";
                        public const string AddNewCertification = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_AddNewCertification";
                        public const string New = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_New";
                        public const string SaveMappingButtonText = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_SaveMappingButtonText";
                        public const string CancelMappingButtonText = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_CancelMappingButtonText";
                        public const string AddJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_AddJobTitle";
                        public const string Edit = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Buttons_EditJobTitle";
                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        public const string JobTitleAlreadyExist = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_JobTitleAlreadyExist";
                        public const string DeletedJobTitleSuccessfully = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_DeletedJobTitleSuccessfully";
                        public const string FailedToDeleteJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_FailedToDeleteJobTitle";
                        public const string UpdatedJobTitleSuccessfully = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_UpdatedJobTitleSuccessfully";
                        public const string FailedToUpdateJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_FailedToUpdateJobTitle";
                        public const string SavedJobTitleSuccessfully = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_SavedJobTitleSuccessfully";
                        public const string FailedToSaveJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_FailedToSaveJobTitle";
                        public const string SaveJobTitleConfirmationTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_SaveJobTitleConfirmationTitle";
                        public const string DeleteJobTitleConfirmationTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_DeleteJobTitleConfirmationTitle";
                        public const string JobTitleIsAvailable = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_JobTitleIsAvailable";
                        public const string SavedJobTitleMappingSuccessfully = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_SavedJobTitleMappingSuccessfully";
                        public const string FailedToSaveJobTitleMapping = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_FailedToSaveJobTitleMapping";
                        public const string DeletedJobTitleConfirmationMessage = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_DeletedJobTitleConfirmationMessage";
                        public const string SaveJobTitleMappingConfirmationTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_SaveJobTitleMappingConfirmationTitle";
                        public const string NoRecordFound = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_NotificationMessage_NoRecordFound";
                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Validation
                    {
                        public const string JobTitleRequired = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_JobTitleRequired";
                        public const string JobTitleLength = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_JobTitleLength";
                        public const string SelectAtleastOneCertificate = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_SelectAtleastOneCertificate";
                        public const string JobTitleNameUnique = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_JobTitleNameUnique";
                        public const string FailedToRetrieveJobTitleList = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveJobTitleList";
                        public const string FailedToRetrieveOrganizations = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveOrganizations";
                        public const string FailedToRetrieveJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveJobTitle";
                        public const string FailedToRetrieveJobTitles = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveJobTitles";
                        public const string FailedToRetrieveCerListReqForAllJobTitle = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveCerListReqForAllJobTitle";
                        public const string FailedToRetrieveAvailableCertificatesForOrganization = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_FailedToRetrieveAvailableCertificatesForOrganization";
                    }
                }

                /// <summary>
                /// Class for Constants for CreateEditTrainingCertificate
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class CreateEditTrainingCertificate
                {
                    public const string CreateEditTrainingCertificateTitle = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_CreateEditTrainingCertificateTitle";
                    public const string CreateJobTitleHeading = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_CreateJobTitleHeading";
                    public const string EditJobTitleHeading = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_EditJobTitleHeading";

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string IndicateRequiredField = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_IndicateRequiredField";
                        public const string EditCertificationToTrainingPlan = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_EditCertificationToTrainingPlan";
                        public const string AddCertificationToTrainingPlan = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_AddCertificationToTrainingPlan";
                        public const string CertificationNameAlreadyExist = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CertificationNameAlreadyExist";
                        public const string CertificationDateShouldBelessThanTodaysDate = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CertificationDateShouldBelessThanTodaysDate";
                        /// <summary>
                        /// Certification Type
                        /// </summary>
                        public const string CertificationType = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CertificationType";
                        public const string Regulation = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_Regulation";
                        /// <summary>
                        /// Frequency
                        /// </summary>
                        public const string Frequency = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_Frequency";

                        /// <summary>
                        /// Frequency in months
                        /// </summary>
                        public const string FrequencyInMonths = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_FrequencyInMonths";


                        /// <summary>
                        /// Enter frequency in months
                        /// </summary>
                        public const string EnterFrequencyInMonths = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_FrequencyInMonths";

                        /// <summary>
                        /// Certification required for all Job Titles
                        /// </summary>
                        public const string CertificationRequiredForAllJobTitles = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CertificationRequiredForAllJobTitles";

                        /// <summary>
                        /// Add New Job Title
                        /// </summary>
                        public const string AddNewJobTitleHeader = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_AddNewJobTitleHeader";

                        /// <summary>
                        /// Certification Name
                        /// </summary>
                        public const string CertificationName = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CertificationName";

                        /// <summary>
                        /// Available Job Titles
                        /// </summary>
                        public const string AvailableJobTitlesHeader = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_AvailableJobTitlesHeader";

                        /// <summary>
                        ///  Current Required Job Titles
                        /// </summary>
                        public const string CurrentRequiredJobTitlesHeader = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_CurrentRequiredJobTitlesHeader";

                        public const string NotificationHeader = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_NotificationHeader";
                        public const string SelectCertificateName = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Labels_SelectCertificateName";



                    }
                    /// <summary>
                    /// Class for Constants for placeholders
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Placeholders
                    {

                        /// <summary>
                        /// Enter frequency in months
                        /// </summary>
                        public const string EnterFrequencyInMonths = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Placeholders_EnterFrequencyInMonths";

                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Buttons
                    {
                        public const string CheckAvailability = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Buttons_CheckAvailability";
                        public const string Cancel = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Buttons_Cancel";
                        public const string Save = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Buttons_Save";
                        public const string New = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Buttons_New";


                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        /// <summary>
                        ///  Certificate Name is available
                        /// </summary>
                        public const string CertificateNameIsAvailable = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_CertificateNameIsAvailable";

                        /// <summary>
                        ///  Certification Name already exist. Please choose another certification name.
                        /// </summary>
                        public const string CertificateNameAlreadyExist = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_CertificateNameAlreadyExist";

                        public const string DeletedTrainingCertificateSuccessfully
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_DeletedTrainingCertificateSuccessfully";

                        /// <summary>
                        /// Failed to delete certificate
                        /// </summary>
                        public const string FailedToDeleteCertificate
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_FailedToDeleteCertificate";

                        /// <summary>
                        ///Training certificate saved successfully
                        /// </summary>
                        public const string TrainingCertificateSavedSuccessfully
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_TrainingCertificateSavedSuccessfully";

                        /// <summary>
                        /// Failed to save certificate
                        /// </summary>
                        public const string FailedToSaveCertificate
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_FailedToSaveCertificate";

                        /// <summary>
                        ///Training certificate updated successfully
                        /// </summary>
                        public const string TrainingCertificateUpdatedSuccessfully
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_TrainingCertificateUpdatedSuccessfully";

                        /// <summary>
                        /// Failed to save certificate
                        /// </summary>
                        public const string FailedToUpdateCertificate
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_FailedToUpdateCertificate";

                        /// <summary>
                        ///Training certificates fetched successfully
                        /// </summary>
                        public const string TrainingCertificatesFetchedSuccessfully
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_TrainingCertificatseFetchedSuccessfully";

                        /// <summary>
                        /// Failed to fetch certificate
                        /// </summary>
                        public const string FailedToFetchCertificates
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_FailedToFetchCertificates";

                        /// <summary>
                        /// Are you sure you want to delete certificate <certificate name> from training plan?. This will also remove mapping of all job titles associated with it.”
                        /// </summary>
                        public const string CertificateDeleteConfirmationMessage
                            = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_CertificateDeleteConfirmationMessage";
                        public const string FailedToFetchCeertificationData
                          = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_NotificationMessage_FailedToFetchCeertificationData";

                    }

                    /// <summary>
                    /// Class for Constants for labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Validation
                    {
                        public const string CertificateNameRequired = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_CertificateNameRequired";
                        public const string SelectCertificateFrequencyMonth = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_SelectCertificateFrequencyMonth";
                        public const string CertificateFrequencyMonthRequired = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_CertificateFrequencyMonthRequired";
                        public const string SelectCertificationType = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_SelectCertificationType";
                        public const string SelectCertificate = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_SelectCertificate";
                        public const string CertificateFrequencyMonthValue = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_CertificateFrequencyMonthValue";


                        public const string JobTitleLength = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_JobTitleLength";
                        public const string SelectAtleastOneCertificate = "JCCSems_Training_TrainingPlan_CreateEditJobTitle_Validation_SelectAtleastOneCertificate";

                        public const string CertificateNameMaxLengthRequired = "JCCSems_Training_TrainingPlan_CreateEditTrainingCertificate_Validation_CertificateNameMaxLengthRequired";
                    }
                }

                /// <summary>
                /// The training plan certificate tree.
                /// </summary>
                public static class TrainingPlanCertificateTree
                {
                    /// <summary>
                    /// The labels.
                    /// </summary>
                    public static class Labels
                    {
                        /// <summary>
                        /// The training plan header.
                        /// </summary>
                        public const string TrainingPlanHeader = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_TrainingPlanHeader";

                        /// <summary>
                        /// The add certificate.
                        /// </summary>
                        public const string AddCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_AddCertificate";

                        /// <summary>
                        /// The edit certificate.
                        /// </summary>
                        public const string EditCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_EditCertificate";

                        /// <summary>
                        /// The delete certificate.
                        /// </summary>
                        public const string DeleteCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_DeleteCertificate";

                        /// <summary>
                        /// The add job title.
                        /// </summary>
                        public const string AddJobTitle = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_AddJobTitle";

                        /// <summary>
                        /// The tree search place holder.
                        /// </summary>
                        public const string TreeSearchPlaceHolder = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_TreeSearchPlaceHolder";

                        /// <summary>
                        /// The company header suffix.
                        /// </summary>
                        public const string CompanyHeaderSuffix = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_CompanyHeaderSuffix";

                        public const string CertificateFrequencyAppendedString = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_CertificateFrequencyAppendedString";

                        public const string CertificateFrequencySuffix = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_CertificateFrequencySuffix";

                        public const string CertificateFrequencyNotProvided = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_CertificateFrequencyNotProvided";

                        public const string CertificateFrequencyPrefix = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_CertificateFrequencyPrefix";

                        public const string InheritedCertificates = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Labels_InheritedCertificates";
                    }

                    /// <summary>
                    /// The tool tips.
                    /// </summary>
                    public static class ToolTips
                    {
                        /// <summary>
                        /// The add training plan.
                        /// </summary>
                        public const string AddTrainingPlan = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_ToolTips_AddTrainingPlan";

                        /// <summary>
                        /// The add certificate.
                        /// </summary>
                        public const string AddCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_ToolTips_AddCertificate";

                        /// <summary>
                        /// The edit certificate.
                        /// </summary>
                        public const string EditCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_ToolTips_EditCertificate";

                        /// <summary>
                        /// The delete certificate.
                        /// </summary>
                        public const string DeleteCertificate = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_ToolTips_DeleteCertificate";
                    }

                    /// <summary>
                    /// The validation.
                    /// </summary>
                    public static class Validation
                    {
                        /// <summary>
                        /// The failed to load training plan certificates.
                        /// </summary>
                        public const string FailedToLoadTrainingPlanCertificates = "JCCSems_Training_TrainingPlan_TrainingPlanCertificateTree_Validation_FailedToLoadTrainingPlanCertificates";
                    }
                }
            }

            /// <summary>
            /// Class for Constants for EmployeeTraining
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class EmployeeTraining
            {
                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Index
                {
                    public const string Title = "JCCSems_Training_EmployeeTraining_Index_Title";
                    public const string Heading = "JCCSems_Training_EmployeeTraining_Index_Heading";

                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string EmptyResultText = "JCCSems_Training_EmployeeTraining_Index_Labels_EmptyResultText";
                        public const string EmployeeList = "JCCSems_Training_EmployeeTraining_Index_Labels_EmployeeList";
                    }

                    /// <summary>
                    /// Class for Constants for Error
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Error
                    {
                        public const string FailedToFetchResult = "JCCSems_Training_EmployeeTraining_Index_Error_FailedToFetchResult";
                        public const string FailedToFetchCompanies = "JCCSems_Training_EmployeeTraining_Index_Error_FailedToFetchCompanies";
                    }

                    /// <summary>
                    /// Class for Constants for Tooltip
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Tooltip
                    {
                        public const string Add = "JCCSems_Training_EmployeeTraining_Index_Tooltip_Add";
                        public const string Edit = "JCCSems_Training_EmployeeTraining_Index_Tooltip_Edit";
                        public const string Remove = "JCCSems_Training_EmployeeTraining_Index_Tooltip_Remove";
                        public const string Verification = "JCCSems_Training_EmployeeTraining_Index_Tooltip_Verification";
                        public const string NoPermissionToEdit = "JCCSems_Training_EmployeeTraining_Index_Tooltip_NoPermissionToEdit";
                        public const string NoPermissionToOpenVerification = "JCCSems_Training_EmployeeTraining_Index_Tooltip_NoPermissionToOpenVerification";
                    }

                    /// <summary>
                    /// Class for Constants for Notification message
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        public const string PleaseSelectACompanyFirst = "JCCSems_Training_EmployeeTraining_Index_NotificationMessage_PleaseSelectACompanyFirst";
                    }
                }

                /// <summary>
                /// Class for Constants for EmployeeVerification
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Verification
                {
                    /// <summary>
                    /// Class for Constants for RequiredCertifications
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class RequiredCertifications
                    {
                        public const string DisplayName = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_DisplayName";
                        public const string RequiredCertificationsTitle =
                              "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_RequiredCertificationsTitle";
                        public const string RequiredCertificationsHeading =
                                "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_RequiredCertificationsHeading";
                        public const string RequiredCertificationsSubHeading =
                               "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_RequiredCertificationsSubHeading";
                        public const string EditEmployeeRequiredCertificationTitle =
                                "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_EditEmployeeRequiredCertificationTitle";

                        /// <summary>
                        /// Class for Constants for ToolTipText
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class ToolTipText
                        {
                            public const string Edit = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_ToolTipText_Edit";
                            public const string NoPermissionToEdit =
                                            "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_ToolTipText_NoPermissionToEdit";

                            public const string CertificateExpired = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_ToolTipText_CertificateExpired";
                        }

                        /// <summary>
                        /// Class for Constants for Labels
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class Labels
                        {
                            public const string Filters = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_Filters";
                            public const string DefaultItemAllOrganizations = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_DefaultItemAllOrganization";
                            public const string DefaultItemAllJobTitles = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_DefaultItemAllJobTitle";
                            public const string DefaultItemAllCertifications = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_DefaultItemAllCertification";
                            public const string EmptyResultText = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_EmptyResultText";
                            public const string FailedToFetchEmployeeCertificates = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_FailedToFetchEmployeeCertificates";
                            public const string FailedToFetchEmployeeJobTitles = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_FailedToFetchEmployeeJobTitles";
                            public const string FailedToFetchOrganizations = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_FailedToFetchOrganizations";
                            public const string FailedToFetchEmployeeDetails = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_FailedToFetchEmployeeDetails";
                            public const string FailedToFetchRequiredCertificates = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_FailedToFetchRequiredCertificates";
                            public const string TrainingPlanCertification = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_TrainingPlanCertification";
                            public const string EmployeeCertification = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_EmployeeCertification";
                            public const string InheritedCompanyNameText = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Labels_InheritedCompanyNameText";
                        }

                        /// <summary>
                        /// Class for Constants for Buttons
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class Buttons
                        {
                            public const string ApplyFilter = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Buttons_ApplyFilter";
                            public const string ClearFilter = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Buttons_ClearFilter";
                            public const string Save = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Buttons_Save";
                            public const string Cancel = "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_Buttons_Cancel";
                        }

                        /// <summary>
                        /// Class for Constants for notification Messages
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class NotificationMessages
                        {
                            public const string FailedToFetchRequiredCertificationData =
                                "JCCSems_Training_EmployeeTraining_Verification_RequiredCertifications_NotificationMessages_FailedToFetchRequiredCertificationData";
                        }
                    }

                    /// <summary>
                    /// Class for Constants for EmployeeCertifications
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class EmployeeCertifications
                    {
                        public const string DisplayName = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_DisplayName";
                        public const string EmployeeCertificationsTitle =
                               "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeCertificationsTitle";
                        public const string EmployeeCertificationsHeading =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeCertificationsHeading";
                        public const string EmployeeCertificationsSubHeading =
                               "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeCertificationsSubHeading";
                        public const string AddEmployeeCertificationTitle =
                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_AddEmployeeCertificationTitle";
                        public const string EditEmployeeCertificationTitle =
                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_EditEmployeeCertificationTitle";

                        public const string OneTimeCertification =
                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_OneTimeCertification";
                        public const string CertificateNotPresentinTrainingPlan =
                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_CertificateNotPresentinTrainingPlan";
                        public const string Never =
                           "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Never";

                        /// <summary>
                        /// Class for Constants for ToolTipText
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class ToolTipText
                        {
                            public const string Add = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_ToolTipText_Add";
                            public const string Edit = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_ToolTipText_Edit";
                            public const string NoPermissionToEdit =
                                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_ToolTipText_NoPermissionToEdit";
                            public const string CertificateExpired =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_ToolTipText_CertificateExpired";
                        }

                        // <summary>
                        /// Class for Constants for Labels
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class Labels
                        {
                            public const string Title = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_Title";
                            public const string FilterByJobTitle = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_FilterByJobTitle";
                            public const string DefaultItemAllJobTitle = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_DefaultItemAllJobTitle";
                            public const string EmptyResultText = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_EmptyResultText";
                            public const string EmployeeName = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_EmployeeName";
                            public const string CompanyName = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_CompanyName";
                            public const string JobTitle = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_JobTitle";
                            public const string CertificationDate = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_CertificationDate";
                            public const string ExpirationDate = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_ExpirationDate";
                            public const string FrequencyInMonths = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_FrequencyInMonths";

                            public const string Notes = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_Notes";
                            public const string Documents = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_Documents";
                            public const string FailedToFetchCertifications =
                                               "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_FailedToFetchCertifications";
                            public const string DocumentUploaderTitle = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_DocumentUploaderTitle";
                            public const string FailedToFetchJobTitles = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_FailedToFetchJobTitles";
                            public const string FailedToFetchEmployee = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Labels_FailedToFetchEmployee";
                            //Expiration Date


                        }

                        /// <summary>
                        /// Class for Constants for Buttons
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class Buttons
                        {
                            public const string ApplyFilter = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_ApplyFilter";
                            public const string Save = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_Save";
                            public const string Cancel = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_Cancel";
                            public const string New = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_New";
                            public const string ClearFilter = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_ClearFilter";
                            public const string AddFiles = "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_Buttons_AddFiles";
                        }

                        /// <summary>
                        /// Class for Constants for notification Messages
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class NotificationMessages
                        {
                            public const string EmployeeCertificationsFetchSuccess =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_EmployeeCertificationsFetchSuccess";
                            public const string EmployeeCertificationsFetchFailure =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_NotificationMessages_EmployeeCertificationsFetchFailure";
                            public const string EmployeeDocumentsFetchFailure =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_EmployeeDocumentsFetchFailure";
                            public const string EmployeeDocumentsFetchSuccess =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_EmployeeDocumentsFetchSuccess";
                            public const string SaveEmployeeCertificationsSuccess =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_SaveEmployeeCertificationsSuccess";
                            public const string SaveEmployeeCertificationsFailure =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_NotificationMessages_SaveEmployeeCertificationsFailure";
                            public const string CreateEditEmployeeCertificationsNotesLength =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_CreateEditEmployeeCertificationsNotesLength";
                            public const string CertificateDateRequired =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_CertificateDateRequired";

                            public const string FailToAddNewCertificate =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_FailToAddNewCertificate";
                            public const string CertificateCreatedSuccessFully =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_CertificateCreatedSuccessFully";

                            public const string EmployeeRequiredCertificateUpdatedSuccessFully =
                           "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_EmployeeRequiredCertificateUpdatedSuccessFully";

                            public const string EmployeeRequiredCertificateUpdateFailure =
                              "JCCSems_Training_EmployeeTraining_Verification_EmployeeCertifications_NotificationMessages_EmployeeRequiredCertificateUpdateFailure";


                        }
                    }

                    /// <summary>
                    /// Class for Constants for EmployeeDocuments
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class EmployeeDocuments
                    {
                        public const string DisplayName = "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_DisplayName";
                        public const string EmployeeDocumentTitle =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeDocumentTitle";
                        public const string EmployeeDocumentHeading =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeDocumentHeading";
                        public const string EmployeeDocumentSubHeading =
                               "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_EmployeeDocumentSubHeading";

                        /// <summary>
                        /// Class for Constants for ToolTipText
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class NotificationMessages
                        {
                            public const string EmployeeFileMappingSuccess =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_NotificationMessages_EmployeeFileMappingSuccess";
                            public const string EmployeeFileMappingFailure =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_NotificationMessages_EmployeeFileMappingFailure";
                        }


                        /// <summary>
                        /// Class for Constants for ToolTipText
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class ToolTipText
                        {
                            public const string Edit = "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_ToolTipText_Edit";
                            public const string NoPermissionToEdit =
                                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_ToolTipText_NoPermissionToEdit";
                            public const string Download =
                                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_ToolTipText_Download";
                            public const string NoPermissionToDownload =
                                            "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_ToolTipText_NoPermissionToDownload";
                        }

                        /// <summary>
                        /// Class for Constants for Labels
                        /// </summary>
                        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                        public static class Labels
                        {
                            public const string EmployeeDocuments =
                                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_EmployeeDocuments";
                            public const string Add = "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_Add";
                            public const string NoPermissionToAdd =
                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_NoPermissionToAdd";
                            public const string FailedToFetchDocuments =
                                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_FailedToFetchDocuments";
                            public const string EmptyResultText =
                                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_EmptyResultText";
                            public const string FailedToFetchEmployeeDetails =
                                                "JCCSems_Training_EmployeeTraining_Verification_EmployeeDocuments_Labels_FailedToFetchEmployeeDetails";
                        }
                    }
                }

                /// <summary>
                /// Class for Constants for CreateEdit Employee
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class CreateEdit
                {
                    public const string CreateHeading = "JCCSems_Training_EmployeeTraining_CreateEdit_CreateHeading";
                    public const string EditHeading = "JCCSems_Training_EmployeeTraining_CreateEdit_EditHeading";

                    /// <summary>
                    /// Class for Constants for Notification message
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        public const string EmployeeNotFound = "JCCSems_Training_EmployeeTraining_CreateEdit_NotificationMessage_EmployeeNotFound";
                        public const string SavedSuccessfully = "JCCSems_Training_EmployeeTraining_CreateEdit_NotificationMessage_SavedSuccessfully";
                    }

                    /// <summary>
                    /// Class for Constants for Error
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Error
                    {
                        public const string FailedToSave = "JCCSems_Training_EmployeeTraining_CreateEdit_Error_FailedToSave";
                        public const string FailedToFetchEmployee = "JCCSems_Training_EmployeeTraining_CreateEdit_Error_FailedToFetchEmployee";
                        public const string FailedToFetchJobTitle = "JCCSems_Training_EmployeeTraining_CreateEdit_Error_FailedToFetchJobTitle";
                        public const string FailedToFetchResult = "JCCSems_Training_EmployeeTraining_CreateEdit_Error_FailedToFetchResult";
                        public const string FailedToFetchOrganization = "JCCSems_Training_EmployeeTraining_CreateEdit_Error_FailedToFetchOrganization";
                    }

                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string Company = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_Company";
                        public const string Name = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_Name";
                        public const string FirstName = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_FirstName";
                        public const string LastName = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_LastName";
                        public const string DateOfBirth = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_DateOfBirth";
                        public const string PrimaryEmail = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_PrimaryEmail";
                        public const string JobTitles = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_JobTitles";
                        public const string LeftListHeader = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_LeftListHeader";
                        public const string RightListHeader = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_RightListHeader";
                        public const string Save = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_Save";
                        public const string Close = "JCCSems_Training_EmployeeTraining_CreateEdit_Labels_Close";
                    }

                    /// <summary>
                    /// Class for Constants for Validation
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Validation
                    {
                        public const string FirstNameRequired = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_FirstNameRequired";
                        public const string LastNameRequired = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_LastNameRequired";
                        public const string PrimaryEmailInvalidFormat = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_PrimaryEmailInvalidFormat";
                        public const string FirstNameLengthExceeds = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_FirstNameLengthExceeds";
                        public const string LastNameLengthExceeds = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_LastNameLengthExceeds";
                        public const string PrimaryEmailLengthExceeds = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_PrimaryEmailLengthExceeds";
                        public const string ModelInvalid = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_ModelInvalid";
                        public const string DateInvalid = "JCCSems_Training_EmployeeTraining_CreateEdit_Validation_DateInvalid";
                        public const string SelectProperDate = "JCCSems_Training_EmployeeTraining_CreateEdit_SelectProperDate";
                        public const string FutureDateMustNotSelect = "JCCSems_Training_EmployeeTraining_CreateEdit_FutureDateMustNotSelect";
                    }
                }
            }

            /// <summary>
            /// Class for Constants for EmployeeTraining
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class TrainingReports
            {
                public const string Title = "JCCSems_Training_TrainingReports_Title";
                public const string Heading = "JCCSems_Training_TrainingReports_Heading";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string ExpiredCertifications = "JCCSems_Training_TrainingReports_Labels_ExpiredCertifications";
                    public const string ActivePOBProjectsEmployeeTraining = "JCCSems_Training_TrainingReports_Labels_ActivePOBProjectsEmployeeTraining";
                    public const string ViewCompleteCompanyReport = "JCCSems_Training_TrainingReports_Labels_ViewCompleteCompanyReport";
                    /// <summary>
                    /// Company Training Reports
                    /// </summary>
                    public const string CompanyTrainingReports = "JCCSems_Training_TrainingReports_Labels_CompanyTrainingReports";
                    public const string Back = "JCCSems_Training_TrainingReports_Labels_Back";
                    public const string Warnings = "JCCSems_Training_TrainingReports_Labels_Warnings";
                    public const string Documents = "JCCSems_Training_TrainingReports_Labels_Documents";
                    public const string ReviewNotes = "JCCSems_Training_TrainingReports_Labels_ReviewNotes";
                    public const string UpdateReports = "JCCSems_Training_TrainingReports_Labels_UpdateReports";
                    public const string ReportAlert = "JCCSems_Training_TrainingReports_Labels_ReportAlert";
                    public const string ExpiredCertificateAlert = "JCCSems_Training_TrainingReports_Labels_ExpiredCertificateAlert";
                    public const string DocumentAlert = "JCCSems_Training_TrainingReports_Labels_DocumentAlert";

                    public const string SelectAllText = "JCCSems_Training_TrainingReports_Labels_SelectAllText";
                    public const string NonSelectedAllEmployeesText = "JCCSems_Training_TrainingReports_Labels_NonSelectedAllEmployeesText";
                    public const string NonSelectedAllCompanieesText = "JCCSems_Training_TrainingReports_Labels_NonSelectedAllCompanieesText";
                    public const string NonSelectedAllJobTitlesText = "JCCSems_Training_TrainingReports_Labels_NonSelectedAllJobTitlesText";
                    public const string FilterPlaceholder = "JCCSems_Training_TrainingReports_Labels_FilterPlaceholder";

                    public const string NotesPrefix = "JCCSems_Training_TrainingReports_Labels_ReportGrid_NotesPrefix";
                    public const string ReviewNotesPrefix = "JCCSems_Training_TrainingReports_Labels_ReportGrid_ReviewNotesPrefix";

                }

                /// <summary>
                /// Class for Constants for Notification Messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string FailedToFetchData = "JCCSems_Training_TrainingReports_NotificationMessages_FailedToFetchData";
                    public const string NoResultsFound = "JCCSems_Training_TrainingReports_NotificationMessages_NoResultsFound";
                    public const string ResultsFound = "JCCSems_Training_TrainingReports_NotificationMessages_ResultsFound";
                    public const string NoCertificateFound = "JCCSems_Training_TrainingReports_NotificationMessages_NoCertificateFound";
                    public const string NoRecordFound = "JCCSems_Training_TrainingReports_NotificationMessages_NoRecordFound";
                }

                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class ExpiredCertifications
                {
                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string FailedToFetchExpiredCertifications = "JCCSems_Training_TrainingReports_ExpiredCertifications_Labels_FailedToFetchExpiredCertifications";
                        public const string EmptyResultText = "JCCSems_Training_TrainingReports_ExpiredCertifications_Labels_EmptyResultText";

                    }

                    /// <summary>
                    /// Class for Constants for Tool Tip
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class ToolTipText
                    {
                        public const string Verification = "JCCSems_Training_TrainingReports_ExpiredCertifications_ToolTipText_View";
                        public const string NoPermissionToView = "JCCSems_Training_TrainingReports_ExpiredCertifications_ToolTipText_NoPermissionToView";
                    }
                }

                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class EmployeeTrainingForPOBProjects
                {
                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string FailedToFetchEmployeeListForPOBProject = "JCCSems_Training_TrainingReports_EmployeeTrainingForPOBProjects_Labels_FailedToFetchEmployeeListForPOBProject";
                        public const string FailedToFetchJobTitleListForPOBProject = "JCCSems_Training_TrainingReports_EmployeeTrainingForPOBProjects_Labels_FailedToFetchJobTitleListForPOBProject";

                    }
                }

                /// <summary>
                /// Class for Constants for Index
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class ActivePOBProjectsEmployeeTraining
                {
                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string FailedToFetchActivePOBProjects = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_FailedToFetchActivePOBProjects";
                        public const string EmptyResultText = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_EmptyResultText";
                        public const string POBProjectsDropDownPlaceHolder = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_POBProjectsDropDownPlaceHolder";
                        public const string POBProjectItem = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_POBProjectItem";
                        public const string POBProjectTitle = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_POBProjectTitle";
                        public const string FailedToFetchPOBProjectOrganization = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_FailedToFetchPOBProjectOrganization";
                        public const string SelectAllText = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_SelectAllText";
                        public const string FilterPlaceholder = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_FilterPlaceholder";
                        public const string NonSelectedAllCompanyText = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_NonSelectedAllCompanyText";
                        public const string NonSelectedAllEmployeesText = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_NonSelectedAllEmployeesText";
                        public const string NonSelectedAllJobTitlesText = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Labels_NonSelectedAllJobTitlesText";
                    }

                    /// <summary>
                    /// Class for Constants for Buttons
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Buttons
                    {
                        public const string Back = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_Buttons_Back";
                    }

                    /// <summary>
                    /// Class for Constants for Tool Tip
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class ToolTipText
                    {
                        public const string View = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_ToolTipText_View";
                        public const string NoPermissionToView = "JCCSems_Training_TrainingReports_ActivePOBProjectsEmployeeTraining_ToolTipText_NoPermissionToView";
                    }
                }
            }
        }

        /// <summary>
        /// Class for Constants for My Profile
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class MyProfile
        {
            /// <summary>
            /// Class for Constants for Index
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_MyProfile_Index_Title";
                public const string Heading = "JCCSems_MyProfile_Index_Heading";
            }

            /// <summary>
            /// Class for Constants for Labels
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CreateEdit
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string UserName = "JCCSems_MyProfile_CreateEdit_Labels_UserName";
                    public const string FullName = "JCCSems_MyProfile_CreateEdit_Labels_FullName";
                    public const string Email = "JCCSems_MyProfile_CreateEdit_Labels_Email";
                    public const string Password = "JCCSems_MyProfile_CreateEdit_Labels_Password";
                    public const string ChangePassword = "JCCSems_MyProfile_CreateEdit_Labels_ChangePassword";
                    public const string Save = "JCCSems_MyProfile_CreateEdit_Labels_Save";
                    public const string Cancel = "JCCSems_MyProfile_CreateEdit_Labels_Cancel";

                    public const string Success = "JCCSems_MyProfile_CreateEdit_Labels_Success";
                    public const string Faliure = "JCCSems_MyProfile_CreateEdit_Labels_Faliure";
                    public const string Ok = "JCCSems_MyProfile_CreateEdit_Labels_Ok";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string EmailRequired = "JCCSems_MyProfile_CreateEdit_Validation_EmailRequired";
                    public const string EmailInvalidFormat = "JCCSems_MyProfile_CreateEdit_Validation_EmailInvalid";
                    public const string EmailLengthExceeds = "JCCSems_MyProfile_CreateEdit_Validation_EmailLengthExceeds";
                    public const string ModelInvalid = "JCCSems_MyProfile_CreateEdit_Validation_ModelInvalid";
                    public const string UserNotExists = "JCCSems_MyProfile_CreateEdit_Validation_UserNotExists";
                }

                /// <summary>
                /// Class for Constants for Validation
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string SavedSuccessfully = "JCCSems_MyProfile_CreateEdit_NotificationMessage_SavedSuccessfully";
                }
            }


        }

        /// <summary>
        /// Class for Constants for User Information
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class UserInformation
        {
            /// <summary>
            /// Class for Constants for Labels
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Labels
            {
                /// <summary>
                /// Class for Constants for DualList
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class DualList
                {
                    public const string LeftListHeader = "JCCSems_UserInformation_Labels_DualList_LeftListHeader";
                    public const string RightListHeader = "JCCSems_UserInformation_Labels_DualList_RightListHeader";
                }

                /// <summary>
                /// Class for Constants for DynaTree
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class DynaTree
                {
                    public const string SearchText = "JCCSems_UserInformation_Labels_DynaTree_SearchText";
                }
            }

            /// <summary>
            /// Class for Constants for Validation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Validation
            {
                public const string SearchTextRequired = "JCCSems_UserInformation_Labels_SearchTextRequired";
            }
        }

        /// <summary>
        /// Class for Constants for company.
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Company
        {
            /// <summary>
            /// Class for Constants for CompanyProfile.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CompanyProfile
            {
                /// <summary>
                /// Class for Constants for CompanyProfile labels.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    /// <summary>
                    /// The company business location.
                    /// </summary>
                    public const string CompanyBusinessLocation = "JCCSems_Company_CompanyProfile_Labels_CompanyBusinessLocation";

                    /// <summary>
                    /// The company name.
                    /// </summary>
                    public const string CompanyName = "JCCSems_Company_CompanyProfile_Labels_CompanyName";

                    /// <summary>
                    /// The relationship manager.
                    /// </summary>
                    public const string RelationshipManager = "JCCSems_Company_CompanyProfile_Labels_RelationshipManager";

                    /// <summary>
                    /// The company type.
                    /// </summary>
                    public const string CompanyType = "JCCSems_Company_CompanyProfile_Labels_CompanyType";

                    /// <summary>
                    /// The header.
                    /// </summary>
                    public const string Header = "JCCSems_Company_CompanyProfile_Labels_Header";

                    /// <summary>
                    /// The policies of insurance.
                    /// </summary>
                    public const string PoliciesOfInsurance = "JCCSems_Company_CompanyProfile_Labels_PoliciesOfInsurance";

                    /// <summary>
                    /// The top tab title.
                    /// </summary>
                    public const string TopTabTitle = "JCCSems_Company_CompanyProfile_Labels_TopTabTitle";

                    /// <summary>
                    /// The training requirement.
                    /// </summary>
                    public const string TrainingRequirement = "JCCSems_Company_CompanyProfile_Labels_TrainingRequirement";

                    /// <summary>
                    /// The training requirement message.
                    /// </summary>
                    public const string TrainingRequirementMessage = "JCCSems_Company_CompanyProfile_Labels_TrainingRequirementMessage";

                    /// <summary>
                    /// Delete file confirmation message
                    /// </summary>
                    public const string DeleteFileConfirmationMessage = "JCCSems_Company_CompanyProfile_Labels_DeleteFileConfirmationMessage";

                    /// <summary>
                    /// Delete file confirmation message
                    /// </summary>
                    public const string RelationShipManagerNotAssign = "JCCSems_Company_CompanyProfile_Labels_RelationShipManagerNotAssign";

                    /// <summary>
                    /// Delete file confirmation message
                    /// </summary>
                    public const string RequiredFieldMessage = "JCCSems_Company_CompanyProfile_Labels_RequiredFieldMessage";

                    /// <summary>
                    /// Text message for no file uploaded yet 
                    /// </summary>
                    public const string FilesNotUploadedYet = "JCCSems_Company_CompanyProfile_Labels_FilesNotUploadedYet";

                    /// <summary>
                    /// Page title for company profile page
                    /// </summary>
                    public const string PageTitle = "JCCSems_Company_CompanyProfile_Labels_PageTitle";

                    /// <summary>
                    /// Delete file confirmation message
                    /// </summary>
                    public const string PrimaryAddressNotAssigned = "JCCSems_Company_CompanyProfile_Labels_PrimaryAddressNotAssigned";
                }

                /// <summary>
                /// Class for Constants for CompanyProfile buttons.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    /// <summary>
                    /// The add file.
                    /// </summary>
                    public const string AddFile = "JCCSems_Company_CompanyProfile_Buttons_AddFile";

                    /// <summary>
                    /// The save.
                    /// </summary>
                    public const string Save = "JCCSems_Company_CompanyProfile_Buttons_Save";

                    /// <summary>
                    /// The cancel.
                    /// </summary>
                    public const string Cancel = "JCCSems_Company_CompanyProfile_Buttons_Cancel";

                    /// <summary>
                    /// The upload logo.
                    /// </summary>
                    public const string UploadLogo = "JCCSems_Company_CompanyProfile_Buttons_UploadLogo";

                }

                /// <summary>
                /// Class for Constants key for Company Profile notifications messages need to show for operation result
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    /// <summary>
                    /// Company profile updation failed 
                    /// </summary>
                    public const string CompanyProfileUpdateFail = "JCCSems_Company_CompanyProfile_NotificationMessage_CompanyProfileUpdateFail";

                    /// <summary>
                    /// Company profile updation success
                    /// </summary>
                    public const string CompanyProfileUpdateSuccess = "JCCSems_Company_CompanyProfile_NotificationMessage_CompanyProfileUpdateSuccess";

                    /// <summary>
                    /// Company profile updation failed 
                    /// </summary>
                    public const string OrganizationFileMappingFail = "JCCSems_Company_CompanyProfile_NotificationMessage_OrganizationFileMappingFail";

                    /// <summary>
                    /// Company profile updation success
                    /// </summary>
                    public const string OrganizationFileMappingSuccess = "JCCSems_Company_CompanyProfile_NotificationMessage_OrganizationFileMappingSuccess";

                    /// <summary>
                    /// Company profile details fetched success
                    /// </summary>
                    public const string OrganizationDetailsFetchedSuccess = "JCCSems_Company_CompanyProfile_NotificationMessage_OrganizationDetailsFetchedSuccess";

                    /// <summary>
                    /// Company profile details fetched failure
                    /// </summary>
                    public const string OrganizationDetailsFetchedFailure = "JCCSems_Company_CompanyProfile_NotificationMessage_OrganizationDetailsFetchedFailure";

                    /// <summary>
                    /// fetch organization files success
                    /// </summary>
                    public const string FetchOrganizationFilesSuccess = "JCCSems_Company_CompanyProfile_NotificationMessage_FetchOrganizationFilesSuccess";

                    /// <summary>
                    /// fetch organization files failure
                    /// </summary>
                    public const string FetchOrganizationFilesFailure = "JCCSems_Company_CompanyProfile_NotificationMessage_FetchOrganizationFilesFailure";

                    /// <summary>
                    /// fetch organization files success
                    /// </summary>
                    public const string FetchAllCompanyTypeSuccess = "JCCSems_Company_CompanyProfile_NotificationMessage_FetchAllCompanyTypeSuccess";

                    /// <summary>
                    /// fetch organization files failure
                    /// </summary>
                    public const string FetchAllCompanyTypeFailure = "JCCSems_Company_CompanyProfile_NotificationMessage_FetchAllCompanyTypeFailure";
                }

                /// <summary>
                /// Class for Constants key for Company Profile tool tips
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class ToolTips
                {

                    /// <summary>
                    /// Company profile edit file Policy of insurance 
                    /// </summary>
                    public const string Edit = "JCCSems_Company_CompanyProfile_ToolTips_Edit";

                    /// <summary>
                    /// Company profile delete file Policy of insurance 
                    /// </summary>
                    public const string Delete = "JCCSems_Company_CompanyProfile_ToolTips_Delete";
                }
            }

            /// <summary>
            /// Class for Constants for Business Contact 
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory,
                SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class BusinessContact
            {
                /// <summary>
                /// Class for Constants for Validation 
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    /// <summary>
                    /// Primary contact exist validation message.
                    /// </summary>
                    public const string PrimaryContactExist = "JCCSems_Company_BusinessContact_Validation_PrimaryContactExist";

                    /// <summary>
                    /// Cannot delete primary contact validation message.
                    /// </summary>
                    public const string CannotDeletePrimaryContact = "JCCSems_Company_BusinessContact_Validation_CannotDeletePrimaryContact";

                    /// <summary>
                    /// The cannot delete primary relationship manager.
                    /// </summary>
                    public const string CannotDeletePrimaryRelationshipManager = "JCCSems_Company_BusinessContact_Validation_CannotDeletePrimaryRelationshipManager";

                    public const string CanRemovePrimaryRelationshipManagerWhileUpdating = "JCCSems_Company_BusinessContact_Validation_CanRemovePrimaryRelationshipManagerWhileUpdating";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string FirstNameRequired = "JCCSems_Company_BusinessContact_Validation_IndividualFirstNameRequired";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string FirstNameMaxLength = "JCCSems_Company_BusinessContact_Validation_IndividualFirstNameMaxLength";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string LastNameRequired = "JCCSems_Company_BusinessContact_Validation_IndividualLastNameRequired";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string LastNameMaxLength = "JCCSems_Company_BusinessContact_Validation_IndividualLastNameMaxLength";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string EmailRequired = "JCCSems_Company_BusinessContact_Validation_IndividualEmailRequired";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string EmailMaxLength = "JCCSems_Company_BusinessContact_Validation_IndividualEmailMaxLength";

                    /// <summary>
                    /// job title max length error message
                    /// </summary>
                    public const string JobTitleMaxLength = "JCCSems_Company_BusinessContact_Validation_JobTitleMaxLength";

                    /// <summary>
                    /// office direct line max length error message
                    /// </summary>
                    public const string OfficeDirectLineMaxLength = "JCCSems_Company_BusinessContact_Validation_OfficeDirectLineMaxLength";

                    /// <summary>
                    /// cellular phone max length error message
                    /// </summary>
                    public const string CellularPhoneMaxLength = "JCCSems_Company_BusinessContact_Validation_CellularPhoneMaxLength";

                    /// <summary>
                    /// first name required error message
                    /// </summary>
                    public const string ValidEmailAddress = "JCCSems_Company_BusinessContact_Validation_ValidEmailAddress";

                    /// <summary>
                    /// Contact added successfully.
                    /// </summary>
                    public const string ContactAddedSuccessfully = "JCCSems_Company_BusinessContact_Validation_ContactAddedSuccessfully";

                    /// <summary>
                    /// Contact updated successfully.
                    /// </summary>
                    public const string ContactUpdatedSuccessfully = "JCCSems_Company_BusinessContact_Validation_ContactUpdatedSuccessfully";

                    /// <summary>
                    /// Contact deleted successfully.
                    /// </summary>
                    public const string ContactDeletedSuccessfully = "JCCSems_Company_BusinessContact_Validation_ContactDeletedSuccessfully";

                    /// <summary>
                    /// Contact fetched successfully.
                    /// </summary>
                    public const string ContactFetchedSuccessfully = "JCCSems_Company_BusinessContact_Validation_ContactFetchedSuccessfully";

                    /// <summary>
                    /// Fail to update contact.
                    /// </summary>
                    public const string FailedToUpdateContact = "JCCSems_Company_BusinessContact_Validation_FailToUpdateContact";

                    /// <summary>
                    /// Fail to add contact.
                    /// </summary>
                    public const string FailedToAddContact = "JCCSems_Company_BusinessContact_Validation_FailToAddContact";

                    /// <summary>
                    /// Fail to delete contact.
                    /// </summary>
                    public const string FailedToDeleteContact = "JCCSems_Company_BusinessContact_Validation_FailToDeleteContact";

                    /// <summary>
                    /// Fail to fetch contact.
                    /// </summary>
                    public const string FailedToFetchContact = "JCCSems_Company_BusinessContact_Validation_FailedToFetchContact";

                    /// <summary>
                    /// Contact type required.
                    /// </summary>
                    public const string ContactTypeRequired = "JCCSems_Company_BusinessContact_Validation_ContactTypeRequired";

                    /// <summary>
                    /// The failed to fetch contactTypes.
                    /// </summary>
                    public const string FailedToFetchContactTypes = "JCCSems_Company_BusinessContact_Validation_FailedToFetchContactTypes";

                    /// <summary>
                    /// The contact type fetched successfully.
                    /// </summary>
                    public const string ContactTypeFetchedSuccessfully = "JCCSems_Company_BusinessContact_Validation_ContactTypeFetchedSuccessfully";

                    /// <summary>
                    /// The delete contact confirmation.
                    /// </summary>
                    public const string DeleteContactConfirmation = "JCCSems_Company_BusinessContact_Validation_DeleteContactConfirmation";

                    /// <summary>
                    /// The no contacts found.
                    /// </summary>
                    public const string NoContactsFound = "JCCSems_Company_BusinessContact_Validation_NoContactsFound";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    /// <summary>
                    /// The required filed indicator message.
                    /// </summary>
                    public const string RequiredFiledIndicatorMessage = "JCCSems_Company_BusinessContact_Labels_RequiredFiledIndicatorMessage";

                    /// <summary>
                    /// The business location.
                    /// </summary>
                    public const string BusinessLocation = "JCCSems_Company_BusinessContact_Labels_BusinessLocation";

                    /// <summary>
                    /// The first name.
                    /// </summary>
                    public const string FirstName = "JCCSems_Company_BusinessContact_Labels_FirstName";

                    /// <summary>
                    /// The last name.
                    /// </summary>
                    public const string LastName = "JCCSems_Company_BusinessContact_Labels_LastName";

                    /// <summary>
                    /// The first name placeholder.
                    /// </summary>
                    public const string FirstNamePlaceholder = "JCCSems_Company_BusinessContact_Labels_FirstNamePlaceholder";

                    /// <summary>
                    /// The first name placeholder.
                    /// </summary>
                    public const string LastNamePlaceholder = "JCCSems_Company_BusinessContact_LastNamePlaceholder";

                    /// <summary>
                    /// The position.
                    /// </summary>
                    public const string Position = "JCCSems_Company_BusinessContact_Labels_Position";

                    /// <summary>
                    /// The position placeholder.
                    /// </summary>
                    public const string PositionPlaceholder = "JCCSems_Company_BusinessContact_PositionPlaceholder";

                    /// <summary>
                    /// The office direct line.
                    /// </summary>
                    public const string OfficeDirectLine = "JCCSems_Company_BusinessContact_OfficeDirectLine";

                    /// <summary>
                    /// The office direct line placeholder.
                    /// </summary>
                    public const string OfficeDirectLinePlaceholder = "JCCSems_Company_BusinessContact_OfficeDirectLinePlaceholder";

                    /// <summary>
                    /// The cell phone.
                    /// </summary>
                    public const string CellPhone = "JCCSems_Company_BusinessContact_CellPhone";

                    /// <summary>
                    /// The cell phone placeholder.
                    /// </summary>
                    public const string CellPhonePlaceholder = "JCCSems_Company_BusinessContact_CellPhonePlaceholder";

                    /// <summary>
                    /// The primary email.
                    /// </summary>
                    public const string PrimaryEmail = "JCCSems_Company_BusinessContact_PrimaryEmail";

                    /// <summary>
                    /// The primary email placeholder.
                    /// </summary>
                    public const string PrimaryEmailPlaceholder = "JCCSems_Company_BusinessContact_PrimaryEmailPlaceholder";

                    public const string PrimaryContact = "JCCSems_Company_BusinessContact_PrimaryContact";

                    /// <summary>
                    /// The primary contact text.
                    /// </summary>
                    public const string PrimaryContactText = "JCCSems_Company_BusinessContact_PrimaryContactText";

                    /// <summary>
                    /// The update page name.
                    /// </summary>
                    public const string UpdatePageName = "JCCSems_Company_BusinessContact_UpdatePageName";

                    /// <summary>
                    /// The add page name.
                    /// </summary>
                    public const string AddPageName = "JCCSems_Company_BusinessContact_AddPageName";

                    /// <summary>
                    /// The add page title.
                    /// </summary>
                    public const string AddPageTitle = "JCCSems_Company_BusinessContact_AddPageTitle";

                    /// <summary>
                    /// The update page title.
                    /// </summary>
                    public const string UpdatePageTitle = "JCCSems_Company_BusinessContact_UpdatePageTitle";

                    /// <summary>
                    /// The add from existing page title.
                    /// </summary>
                    public const string AddFromExistingPageTitle = "JCCSems_Company_BusinessContact_AddFromExistingPageTitle";

                    /// <summary>
                    /// The add page name.
                    /// </summary>
                    public const string AddFromExistingPageName = "JCCSems_Company_BusinessContact_AddFromExistingPageName";

                    /// <summary>
                    /// The submit button update name.
                    /// </summary>
                    public const string SubmitButtonUpdateName = "JCCSems_Company_BusinessContact_SubmitButtonUpdateName";

                    /// <summary>
                    /// The submit button add name.
                    /// </summary>
                    public const string SubmitButtonAddName = "JCCSems_Company_BusinessContact_SubmitButtonAddName";

                    /// <summary>
                    /// The button cancel.
                    /// </summary>
                    public const string ButtonCancel = "JCCSems_Company_BusinessContact_ButtonCancel";

                    /// <summary>
                    /// The message box button cancel.
                    /// </summary>
                    public const string MessageBoxButtonCancel = "JCCSems_Company_BusinessContact_MessageBoxButtonCancel";

                    /// <summary>
                    /// The message box button ok.
                    /// </summary>
                    public const string MessageBoxButtonOk = "JCCSems_Company_BusinessContact_MessageBoxButtonOk";

                    /// <summary>
                    /// The message box button yes.
                    /// </summary>
                    public const string MessageBoxButtonYes = "JCCSems_Company_BusinessContact_MessageBoxButtonYes";

                    /// <summary>
                    /// The message box confirmation header.
                    /// </summary>
                    public const string MessageBoxConfirmationHeader = "JCCSems_Company_BusinessContact_MessageBoxConfirmationHeader";

                    /// <summary>
                    /// The message box notification header.
                    /// </summary>
                    public const string MessageBoxNotificationHeader = "JCCSems_Company_BusinessContact_MessageBoxNotificationHeader";

                    public const string BusinessContactsHeader = "JCCSems_Company_BusinessContact_BusinessContactsHeader";
                    public const string AddFromExisting = "JCCSems_Company_BusinessContact_AddFromExisting";
                    public const string AddNew = "JCCSems_Company_BusinessContact_AddNew";

                    /// <summary>
                    /// Class for Constants for DualList
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class DualList
                    {
                        /// <summary>
                        /// The contact type left list header.
                        /// </summary>
                        public const string ContactTypeLeftListHeader = "JCCSems_Company_BusinessContact_Labels_DualList_ContactTypeLeftListHeader";

                        /// <summary>
                        /// The contact type left list header.
                        /// </summary>
                        public const string ListMainHeader = "JCCSems_Company_BusinessContact_Labels_DualList_ListMainHeader";

                        /// <summary>
                        /// The contact type right list header.
                        /// </summary>
                        public const string ContactTypeRightListHeader = "JCCSems_Company_BusinessContact_Labels_DualList_ContactTypeRightListHeader";
                    }
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Tooltips
                {
                    /// <summary>
                    /// The update contact.
                    /// </summary>
                    public const string UpdateContact = "JCCSems_Company_BusinessContact_Tooltips_UpdateContact";

                    /// <summary>
                    /// The add contact.
                    /// </summary>
                    public const string AddContact = "JCCSems_Company_BusinessContact_Tooltips_AddContact";

                    /// <summary>
                    /// The delete contact.
                    /// </summary>
                    public const string DeleteContact = "JCCSems_Company_BusinessContact_Tooltips_DeleteContact";
                }
            }


            /// <summary>
            /// Class for Constants for Business Location 
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory,
                SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class BusinessLocation
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Title
                {
                    public const string PageTitle = "JCCSems_Company_BusinessLocation_Title_PageTitle";
                }

                /// <summary>
                /// Class for Constants for Validation 
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory,
                    SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string PrimaryLocationExist = "JCCSems_Company_BusinessLocation_Validation_PrimaryLocationExist";
                    public const string LocationNameRequired = "JCCSems_Company_BusinessLocation_Validation_LocationNameRequired";
                    public const string AddressRequired = "JCCSems_Company_BusinessLocation_Validation_AddressRequired";
                    public const string StateRequired = "JCCSems_Company_BusinessLocation_Validation_StateRequired";
                    public const string LocationTypeRequired = "JCCSems_Company_BusinessLocation_Validation_LocationTypeRequired";
                    public const string CityRequired = "JCCSems_Company_BusinessLocation_Validation_CityRequired";
                    public const string ZIPRequired = "JCCSems_Company_BusinessLocation_Validation_ZIPRequired";

                    public const string NameMaxLength = "JJCCSems_Company_BusinessLocation_Validation_NameMaxLength";
                    public const string Address1MaxLength = "JJCCSems_Company_BusinessLocation_Validation_Address1MaxLength";
                    public const string Address2MaxLength = "JJCCSems_Company_BusinessLocation_Validation_Address2MaxLength";
                    public const string CityMaxLength = "JJCCSems_Company_BusinessLocation_Validation_CityMaxLength";
                    public const string ZIPMaxLength = "JJCCSems_Company_BusinessLocation_Validation_ZIPMaxLength";
                    public const string ZIPInvalidFormat = "JJCCSems_Company_BusinessLocation_Validation_ZIPInvalidFormat";

                    public const string MainPhoneMaxLength = "JJCCSems_Company_BusinessLocation_Validation_MainPhoneMaxLength";
                    public const string FaxMaxLength = "JJCCSems_Company_BusinessLocation_Validation_FaxMaxLength";



                }

                /// <summary>
                /// Class for Constants for Message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory,
                    SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Message
                {
                    public const string LocationDataSavedSuccessfully = "JCCSems_Company_BusinessLocation_message_LocationDataSavedSuccessfully";
                    public const string LocationTypeNotAvailable = "JCCSems_Company_BusinessLocation_message_LocationTypeNotAvailable";
                    public const string StateInformationNotAvailable = "JCCSems_Company_BusinessLocation_message_StateInformationNotAvailable";

                }

                /// <summary>
                /// Class for Constants for BusinessLocation labels.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    /// <summary>
                    /// The location name.
                    /// </summary>
                    public const string LocationName = "JCCSems_Company_BusinessLocation_Labels_LocationName";

                    /// <summary>
                    /// The location type.
                    /// </summary>
                    public const string LocationType = "JCCSems_Company_BusinessLocation_Labels_LocationType";

                    /// <summary>
                    /// The Address.
                    /// </summary>
                    public const string Address = "JCCSems_Company_BusinessLocation_Labels_Address";

                    public const string AddressLine1 = "JCCSems_Company_BusinessLocation_Labels_AddressLine1";
                    public const string AddressLine2 = "JCCSems_Company_BusinessLocation_Labels_AddressLine2";

                    /// <summary>
                    /// The main phone.
                    /// </summary>
                    public const string MainPhone = "JCCSems_Company_BusinessLocation_Labels_MainPhone";

                    /// <summary>
                    /// The header.
                    /// </summary>
                    public const string Header = "JCCSems_Company_BusinessLocation_Labels_Header";

                    /// <summary>
                    /// The fax.
                    /// </summary>
                    public const string Fax = "JCCSems_Company_BusinessLocation_Labels_Fax";

                    /// <summary>
                    /// The city.
                    /// </summary>
                    public const string City = "JCCSems_Company_BusinessLocation_Labels_City";

                    /// <summary>
                    /// The state.
                    /// </summary>
                    public const string State = "JCCSems_Company_BusinessLocation_Labels_State";

                    /// <summary>
                    /// The ZIP.
                    /// </summary>
                    public const string ZIP = "JCCSems_Company_BusinessLocation_Labels_ZIP";

                    /// <summary>
                    /// Delete file confirmation message
                    /// </summary>
                    public const string DeleteFileConfirmationMessage = "JCCSems_Company_BusinessLocation_Labels_DeleteFileConfirmationMessage";

                    /// <summary>
                    /// Required Field Message
                    /// </summary>
                    public const string RequiredFieldMessage = "JCCSems_Company_BusinessLocation_Labels_RequiredFieldMessage";

                    /// <summary>
                    /// Primary Location
                    /// </summary>
                    public const string PrimaryLocation = "JCCSems_Company_BusinessLocation_Labels_PrimaryLocation";

                    /// <summary>
                    /// Please select a Business Location
                    /// </summary>
                    public const string SelectABusinessLocationHeader = "JCCSems_Company_BusinessLocation_Labels_SelectABusinessLocationHeader";


                    /// <summary>
                    /// Add Business Location Details
                    /// </summary>
                    public const string AddBusinessLocationDetailsHeader = "JCCSems_Company_BusinessLocation_Labels_AddBusinessLocationDetailsHeader";

                    /// <summary>
                    /// Business Locations 
                    /// </summary>
                    public const string BusinessLocationsHeader = "JCCSems_Company_BusinessLocation_Labels_BusinessLocationsHeader";

                    /// <summary>
                    /// Business Locations 
                    /// </summary>
                    public const string Primary = "JCCSems_Company_BusinessLocation_Labels_Primary";

                    public const string NoRecordFound = "JCCSems_Company_BusinessLocation_Labels_NoRecordFound";

                }

                /// <summary>
                /// Class for Constants for Business Location buttons.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    /// <summary>
                    /// The save.
                    /// </summary>
                    public const string Save = "JCCSems_Company_BusinessLocation_Buttons_Save";

                    /// <summary>
                    /// The cancel.
                    /// </summary>
                    public const string Cancel = "JCCSems_Company_BusinessLocation_Buttons_Cancel";

                }

                /// <summary>
                /// Class for Constants key for Business Location notifications messages need to show for operation result
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory,
                    SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    /// <summary>
                    /// "Fetch organization locations failed"
                    /// </summary>
                    public const string FetchOrganizationLocationsFailed = "JCCSems_Company_BusinessLocation_NotificationMessage_FetchOrganizationLocationsFailed";
                    /// <summary>
                    ///  Fetch organization location detail failed
                    /// </summary>
                    public const string FetchOrganizationLocationDetailFailed = "JCCSems_Company_BusinessLocation_NotificationMessage_FetchOrganizationLocationDetailFailed";
                    /// <summary>
                    /// Update Organization location detail failed
                    /// </summary>
                    public const string UpdateOrganizationLocationDetailFailure = "JCCSems_Company_BusinessLocation_NotificationMessage_UpdateOrganizationLocationDetailFailure";

                    /// <summary>
                    /// All states fetching failure
                    /// </summary>
                    public const string FetchAllStatesFailure = "JCCSems_Company_BusinessLocation_NotificationMessage_FetchAllStatesFailure";

                    /// <summary>
                    /// "Fetch all location types failed"
                    /// </summary>
                    public const string FetchAlllocationTypesFailure = "JCCSems_Company_BusinessLocation_NotificationMessage_FetchAlllocationTypesFailure";

                    /// <summary>
                    /// "Checking primary location validity failed"
                    /// </summary>
                    public const string PrimaryLocationValidityCheckingFailed = "JCCSems_Company_BusinessLocation_NotificationMessage_primaryLocationValidityCheckingFailed";


                }

                /// <summary>
                /// Class for Constants key for Company Profile Business location tooltips
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class ToolTips
                {
                    /// <summary>
                    /// Company profile Business location Add
                    /// </summary>
                    public const string Add = "JCCSems_Company_BusinessLocation_ToolTips_Add";

                    /// <summary>
                    /// Company profile Business location Edit
                    /// </summary>
                    public const string Edit = "JCCSems_Company_BusinessLocation_ToolTips_Edit";

                }
            }
        }

        /// <summary>
        /// Class for Constants for Client Users
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class ClientUsers
        {

            /// <summary>
            /// Class for Constants for AssignCompanies
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AssignCompanies
            {
                public const string DisplayName = "JCCSems_User_AssignCompanies_DisplayName";
                public const string CreateUserHeading = "JCCSems_User_AssignCompanies_CreateUserHeading";
                public const string CreateUserTitle = "JCCSems_User_AssignCompanies_CreateUserTitle";
                public const string EditUserHeading = "JCCSems_User_AssignCompanies_EditUserHeading";
                public const string EditUserTitle = "JCCSems_User_AssignCompanies_EditUserTitle";
                public const string DualListLeftListHeader = "JCCSems_User_AssignCompanies_DualListLeftListHeader";
                public const string DualListRightListHeader = "JCCSems_User_AssignCompanies_DualListRightListHeader";
            }

            /// <summary>
            /// Class for Constants for EmailNotification
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class EmailNotification
            {
                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string EmailSentSuccessfully = "JCCSems_User_EmailNotification_NotificationMessages_EmailSentSuccessfully";
                    public const string NoCheckBoxIsChecked = "JCCSems_User_EmailNotification_NotificationMessages_NoCheckBoxIsChecked";
                    public const string DefaultEmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_DefaultEmailNotSent";
                    public const string AddtionalEmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_AddtionalEmailNotSent";
                    public const string EmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_EmailNotSent";
                    public const string ConfirmationBoxHeader = "JCCSems_User_EmailNotification_NotificationMessages_ConfirmationBoxHeader";
                    public const string Ok = "JCCSems_User_EmailNotification_NotificationMessages_Ok";
                }
            }

            /// <summary>
            /// Class for Constants for AssignRoles
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AssignRoles
            {
                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string PreviousButtonText = "JCCSems_User_AssignRoles_Labels_PreviousButtonText";
                    public const string SaveButtonText = "JCCSems_User_AssignRoles_Labels_SaveButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_AssignRoles_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_AssignRoles_Labels_CancelButtonText";
                    public const string LeftListHeader = "JCCSems_User_AssignRoles_Labels_LeftListHeader";
                    public const string RightListHeader = "JCCSems_User_AssignRoles_Labels_RightListHeader";
                    public const string AssignRoles = "JCCSems_User_AssignRoles_Labels_AssignRoles";
                }
            }

            /// <summary>
            /// Class for Constants for Index
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_ClientUsers_Index_Title";
                public const string Heading = "JCCSems_ClientUsers_Index_Heading";

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string EmptyResultText = "JCCSems_ClientUsers_Index_Labels_EmptyResultText";
                    public const string FailedToFetchUsers = "JCCSems_ClientUsers_Index_Labels_FailedToFetchUsers";
                }

                /// <summary>
                /// Class for Constants for Tooltip
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Tooltip
                {
                    public const string Edit = "JCCSems_ClientUsers_Index_Tooltip_Edit";
                    public const string NoPermissionToEdit = "JCCSems_ClientUsers_Index_Tooltip_NoPermissionToEdit";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string LockNotAllowedTitle = "JCCSems_ClientUsers_Index_NotificationMessage_LockNotAllowedTitle";
                    public const string LockNotAllowedMessageText = "JCCSems_ClientUsers_Index_NotificationMessage_LockNotAllowedMessageText";
                    public const string ConfirmBoxUnlockTitle = "JCCSems_ClientUsers_Index_NotificationMessage_ConfirmBoxUnlockTitle";
                    public const string ConfirmBoxUnlockMessageText = "JCCSems_ClientUsers_Index_NotificationMessage_ConfirmBoxUnlockMessageText";
                    public const string ActivateUserOnAllSystemTitle = "JCCSems_ClientUsers_Index_NotificationMessage_ActivateUserOnAllSystemTitle";
                    public const string ActivateUserOnAllSystemMessageText = "JCCSems_ClientUsers_Index_NotificationMessage_ActivateUserOnAllSystemMessageText";
                    public const string DeActivateUserOnAllSystemTitle = "JCCSems_ClientUsers_Index_NotificationMessage_DeActivateUserOnAllSystemTitle";
                    public const string DeActivateUserOnAllSystemMessageText = "JCCSems_ClientUsers_Index_NotificationMessage_DeActivateUserOnAllSystemMessageText";
                }
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ContactInformation
            {
                public const string DisplayName = "JCCSems_User_ContactInformation_DisplayName";
                public const string CreateTitle = "JCCSems_User_ContactInformation_CreateTitle";
                public const string CreateHeading = "JCCSems_User_ContactInformation_CreateHeading";
                public const string EditTitle = "JCCSems_User_ContactInformation_EditTitle";
                public const string EditHeading = "JCCSems_User_ContactInformation_EditHeading";

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string SaveSuccess = "JCCSems_User_ContactInformation_NotificationMessages_SaveSuccess";
                    public const string SaveFailure = "JCCSems_User_ContactInformation_NotificationMessages_SaveFailure";
                    public const string ContactInformationFetchFailed =
                        "JCCSems_User_ContactInformation_NotificationMessages_ContactInformationFetchFailed";
                    public const string FailToLoadContactForm = "JCCSems_User_ContactInformation_NotificationMessages_FailToLoadContactForm";
                    public const string ContactsNotLoaded = "JCCSems_User_ContactInformation_NotificationMessages_ContactsNotLoaded";
                }
            }

            /// <summary>
            /// Class for Constants for User Notification Message
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class NotificationMessages
            {
                public const string UserNotAuthorized = "JCCSems_User_Wizard_UserNotAuthorized";
                public const string NoUserFound = "JCCSems_User_Wizard_NoUserFound";
                public const string ResetPasswordErrorText = "JCCSems_User_EditUser_ResetPasswordFailure";
                public const string UserUpdateSuccess = "JCCSems_User_EditUser_UserUpdateSuccess";
                public const string ResetPasswordSuccess = "JCCSems_User_EditUser_ResetPasswordSuccess";
                public const string RoleCanNotRemove = "JCCSems_User_EditUser_RoleCanNotRemove";
                public const string NoAssignedCompanies = "JCCSems_User_NotificationMessages_NoAssignedCompanies";
            }
        }

        /// <summary>
        /// Class for Constants for User
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class User
        {
            /// <summary>
            /// Class for Constants for Index
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Index
            {
                public const string Title = "JCCSems_User_Index_Title";
                public const string Heading = "JCCSems_User_Index_Heading";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string ManageUsers = "JCCSems_User_Index_Labels_ManageUsers";
                    public const string AddUser = "JCCSems_User_Index_Labels_AddUser";
                    public const string EmptyResultText = "JCCSems_User_Index_Labels_EmptyResultText";
                    public const string FailedToFetchUsers = "JCCSems_User_Index_Labels_FailedToFetchUsers";
                }

                /// <summary>
                /// Class for Constants for Tooltip
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Tooltip
                {
                    public const string Edit = "JCCSems_User_Index_Tooltip_Edit";
                    public const string Remove = "JCCSems_User_Index_Tooltip_Remove";
                    public const string NoPermissionToEdit = "JCCSems_User_Index_Tooltip_NoPermissionToEdit";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string LockNotAllowedTitle = "JCCSems_User_Index_NotificationMessage_LockNotAllowedTitle";
                    public const string LockNotAllowedMessageText = "JCCSems_User_Index_NotificationMessage_LockNotAllowedMessageText";
                    public const string ConfirmBoxUnlockTitle = "JCCSems_User_Index_NotificationMessage_ConfirmBoxUnlockTitle";
                    public const string ConfirmBoxUnlockMessageText = "JCCSems_User_Index_NotificationMessage_ConfirmBoxUnlockMessageText";
                    public const string ActivateUserOnAllSystemTitle = "JCCSems_User_Index_NotificationMessage_ActivateUserOnAllSystemTitle";
                    public const string ActivateUserOnAllSystemMessageText = "JCCSems_User_Index_NotificationMessage_ActivateUserOnAllSystemMessageText";
                    public const string DeActivateUserOnAllSystemTitle = "JCCSems_User_Index_NotificationMessage_DeActivateUserOnAllSystemTitle";
                    public const string DeActivateUserOnAllSystemMessageText = "JCCSems_User_Index_NotificationMessage_DeActivateUserOnAllSystemMessageText";
                    public const string UserNotFound = "JCCSems_User_Index_NotificationMessage_UserNotFound";
                    public const string SaveSuccessfully = "JCCSems_User_Index_NotificationMessage_SaveSuccessfully";
                    public const string ActivateUserStatusSuccessText = "JCCSems_User_Index_NotificationMessage_ActivateUserStatusSuccessText";
                    public const string DeactivateUserStatusSuccessText = "JCCSems_User_Index_NotificationMessage_DeactivateUserStatusSuccessText";
                    public const string UpdateUserFailedText = "JCCSems_User_Index_NotificationMessage_UpdateUserFailedText";
                    public const string UserUnlockedSuccessfully = "JCCSems_User_Index_NotificationMessage_UserUnlockedSuccessfully";
                    public const string UserUnlockedFailed = "JCCSems_User_Index_NotificationMessage_UserUnlockedFailed";
                    public const string IndividualNotAssociatedWithUser = "JCCSems_User_Index_NotificationMessage_IndividualNotAssociatedWithUser";
                }
            }

            /// <summary>
            /// Class for Constants for ContactInformation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class ContactInformation
            {
                public const string DisplayName = "JCCSems_User_ContactInformation_DisplayName";
                public const string CreateTitle = "JCCSems_User_ContactInformation_CreateTitle";
                public const string CreateHeading = "JCCSems_User_ContactInformation_CreateHeading";
                public const string EditTitle = "JCCSems_User_ContactInformation_EditTitle";
                public const string EditHeading = "JCCSems_User_ContactInformation_EditHeading";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string SaveButtonText = "JCCSems_User_ContactInformation_Labels_SaveButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_ContactInformation_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_ContactInformation_Labels_CancelButtonText";
                    public const string BusinessLocation = "JCCSems_User_ContactInformation_Labels_BusinessLocation";
                    public const string New = "JCCSems_User_ContactInformation_Labels_New";
                    public const string Name = "JCCSems_User_ContactInformation_Labels_Name";
                    public const string Position = "JCCSems_User_ContactInformation_Labels_Position";
                    public const string PrimaryEmail = "JCCSems_User_ContactInformation_Labels_PrimaryEmail";
                    public const string OfficeDirectLine = "JCCSems_User_ContactInformation_Labels_OfficeDirectLine";
                    public const string SecondaryEmail = "JCCSems_User_ContactInformation_Labels_SecondaryEmail";
                    public const string CellPhone = "JCCSems_User_ContactInformation_Labels_CellPhone";
                    public const string PositionPlaceholder = "JCCSems_User_ContactInformation_Labels_PositionPlaceholder";
                    public const string PrimaryEmailPlaceholder = "JCCSems_User_ContactInformation_Labels_PrimaryEmailPlaceholder";
                    public const string OfficeDirectLinePlaceholder = "JCCSems_User_ContactInformation_Labels_OfficeDirectLinePlaceholder";
                    public const string SecondaryEmailPlaceholder = "JCCSems_User_ContactInformation_Labels_SecondaryEmailPlaceholder";
                    public const string CellPhonePlaceholder = "JCCSems_User_ContactInformation_Labels_CellPhonePlaceholder";
                    public const string Company = "JCCSems_User_ContactInformation_Labels_Company";
                    public const string AddBusinessLocationDetailsHeader = "JCCSems_User_ContactInformation_Labels_AddBusinessLocationDetailsHeader";
                    public const string AddNewContactHeader = "JCCSems_User_ContactInformation_Labels_AddNewContactHeader";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string SaveSuccess = "JCCSems_User_ContactInformation_NotificationMessages_SaveSuccess";
                    public const string SaveFailure = "JCCSems_User_ContactInformation_NotificationMessages_SaveFailure";
                    public const string ContactInformationFetchFailed =
                        "JCCSems_User_ContactInformation_NotificationMessages_ContactInformationFetchFailed";
                    public const string ContactsNotLoaded = "JCCSems_User_ContactInformation_NotificationMessages_ContactsNotLoaded";
                    public const string FailToLoadContactForm = "JCCSems_User_ContactInformation_NotificationMessages_FailToLoadContactForm";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validations
                {
                    public const string BusinessLocationRequired = "JCCSems_User_ContactInformation_Validations_BusinessLocationRequired";
                    public const string ContactNameRequired = "JCCSems_User_ContactInformation_Validations_ContactNameRequired";
                    public const string PrimaryEmailRequired = "JCCSems_User_ContactInformation_Validations_PrimaryEmailRequired";
                    public const string PrimaryEmailLength = "JCCSems_User_ContactInformation_Validations_PrimaryEmailLength";
                    public const string PrimaryEmailRegex = "JCCSems_User_ContactInformation_Validations_PrimaryEmailRegex";
                    public const string OfficeDirectLineLength = "JCCSems_User_ContactInformation_Validations_OfficeDirectLineLength";
                    public const string SecondaryEmailLength = "JCCSems_User_ContactInformation_Validations_SecondaryEmailLength";
                    public const string SecondaryEmailRegex = "JCCSems_User_ContactInformation_Validations_SecondaryEmailRegex";
                    public const string CellPhoneLength = "JCCSems_User_ContactInformation_Validations_CellPhoneLength";
                    public const string OrganizationRequired = "JCCSems_User_ContactInformation_Validations_OrganizationRequired";
                    public const string PrimaryContactExist = "JCCSems_User_ContactInformation_Validations_PrimaryContactExist";
                    public const string PositionLength = "JCCSems_User_ContactInformation_Validations_PositionLength";
                }
            }

            /// <summary>
            /// Class for Constants for Create Edit User
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class CreateEditUser
            {
                public const string DisplayName = "JCCSems_User_CreateEdit_DisplayName";
                public const string CreateUserHeading = "JCCSems_User_CreateEdit_CreateUserHeading";
                public const string CreateUserTitle = "JCCSems_User_CreateEdit_CreateUserTitle";
                public const string FetchFailed = "JCCSems_User_CreateEdit_FetchFailed";
                public const string GenerateNewPasswordText = "JCCSems_User_CreateEdit_GenerateNewPasswordText";
                public const string ConfirmBoxMessage = "JCCSems_User_CreateEdit_ConfirmBoxMessage";
                public const string ConfirmBoxTitle = "JCCSems_User_CreateEdit_ConfirmBoxTitle";
                public const string EditUserTitle = "JCCSems_User_CreateEdit_EditUserTitle";
                public const string EditUserHeading = "JCCSems_User_CreateEdit_EditUserHeading";

                /// <summary>
                /// Class for add edit user validations
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string UserNameRequired = "JCCSems_User_CreateEdit_Validation_UserNameRequired";
                    public const string UserNameUnique = "JCCSems_User_CreateEdit_Validation_UserNameUnique";
                    public const string UserNameLength = "JCCSems_User_CreateEdit_Validation_UserNameLength";
                }

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string UserName = "JCCSems_User_CreateEdit_UserName";
                    public const string Active = "JCCSems_User_CreateEdit_Active";
                    public const string Unlock = "JCCSems_User_CreateEdit_Unlock";

                    public const string PreviousButtonText = "JCCSems_User_CreateEdit_Labels_PreviousButtonText";
                    public const string SaveButtonText = "JCCSems_User_CreateEdit_Labels_SaveButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_CreateEdit_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_CreateEdit_Labels_CancelButtonText";
                }
            }

            /// <summary>
            /// Class for Constants for AssignCompanies
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AssignCompanies
            {
                public const string DisplayName = "JCCSems_User_AssignCompanies_DisplayName";
                public const string CreateUserHeading = "JCCSems_User_AssignCompanies_CreateUserHeading";
                public const string CreateUserTitle = "JCCSems_User_AssignCompanies_CreateUserTitle";
                public const string EditUserHeading = "JCCSems_User_AssignCompanies_EditUserHeading";
                public const string EditUserTitle = "JCCSems_User_AssignCompanies_EditUserTitle";
                public const string DualListLeftListHeader = "JCCSems_User_AssignCompanies_DualListLeftListHeader";
                public const string DualListRightListHeader = "JCCSems_User_AssignCompanies_DualListRightListHeader";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string PreviousButtonText = "JCCSems_User_AssignCompanies_Labels_PreviousButtonText";
                    public const string SaveButtonText = "JCCSems_User_AssignCompanies_Labels_SaveButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_AssignCompanies_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_AssignCompanies_Labels_CancelButtonText";
                    public const string AssignCompanies = "JCCSems_User_AssignCompanies_Labels_AssignCompanies";
                    public const string AllowAllOrganizations = "JCCSems_User_AssignCompanies_Labels_AllowAllOrganizations";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string CompaniesAssignedSuccessfully = "JCCSems_User_AssignCompanies_NotificationMessage_CompaniesAssignedSuccessfully";
                    public const string CompaniesAssignedFailure = "JCCSems_User_AssignCompanies_NotificationMessage_CompaniesAssignedFailure";
                    public const string ConfirmCompanyRemove = "JCCSems_User_AssignCompanies_NotificationMessage_ConfirmCompanyRemove";
                    public const string ConfirmCompanyRemoveTitle = "JCCSems_User_AssignCompanies_NotificationMessage_ConfirmCompanyRemoveTitle";
                    public const string ConfirmCompanyYes = "JCCSems_User_AssignCompanies_NotificationMessage_ConfirmCompanyYes";
                    public const string ConfirmCompanyCancel = "JCCSems_User_AssignCompanies_NotificationMessage_ConfirmCompanyCancel";
                }
            }

            /// <summary>
            /// Class for Constants for AssignRoles
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AssignRoles
            {
                public const string DisplayName = "JCCSems_User_AssignRoles_DisplayName";
                public const string CreateUserHeading = "JCCSems_User_AssignRoles_CreateUserHeading";
                public const string CreateUserTitle = "JCCSems_User_AssignRoles_CreateUserTitle";
                public const string EditUserHeading = "JCCSems_User_AssignRoles_EditUserHeading";
                public const string EditUserTitle = "JCCSems_User_AssignRoles_EditUserTitle";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string PreviousButtonText = "JCCSems_User_AssignRoles_Labels_PreviousButtonText";
                    public const string SaveButtonText = "JCCSems_User_AssignRoles_Labels_SaveButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_AssignRoles_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_AssignRoles_Labels_CancelButtonText";
                    public const string LeftListHeader = "JCCSems_User_AssignRoles_Labels_LeftListHeader";
                    public const string RightListHeader = "JCCSems_User_AssignRoles_Labels_RightListHeader";
                    public const string AssignRoles = "JCCSems_User_AssignRoles_Labels_AssignRoles";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string RolesAssignedSuccessfully = "JCCSems_User_AssignRoles_NotificationMessage_RolesAssignedSuccessfully";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                }
            }

            /// <summary>
            /// Class for Constants for EmailNotification
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class EmailNotification
            {
                public const string DisplayName = "JCCSems_User_EmailNotification_DisplayName";
                public const string CreateUserTitle = "JCCSems_User_EmailNotification_CreateUserTitle";
                public const string EditUserTitle = "JCCSems_User_EmailNotification_EditUserTitle";
                public const string CreateUserHeading = "JCCSems_User_EmailNotification_CreateUserHeading";
                public const string EditUserHeading = "JCCSems_User_EmailNotification_EditUserHeading";

                /// <summary>
                /// Class for Constants for Validation of EmailNotification
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string SubjectRequired = "JCCSems_User_EmailNotification_SubjectRequired";
                    public const string MessageRequired = "JCCSems_User_EmailNotification_MessageRequired";
                    public const string SubjectMaxLength = "JCCSems_User_EmailNotification_Validation_SubjectMaxLength";
                    public const string MessageMaxLength = "JCCSems_User_EmailNotification_Validation_MessageMaxLength";
                    public const string ContactDetailsNotFound = "JCCSems_User_EmailNotification_Validation_ContactDetailsNotFound";

                }

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string EmailId = "JCCSems_User_EmailNotification_Labels_EmailId";
                    public const string DefaultEmail = "JCCSems_User_EmailNotification_Labels_DefaultEmail";
                    public const string DefaultEmailHelpBlock = "JCCSems_User_EmailNotification_Labels_DefaultEmailHelpBlock";
                    public const string AdditionalEmail = "JCCSems_User_EmailNotification_Labels_AdditionalEmail";
                    public const string AdditionalEmailSubject = "JCCSems_User_EmailNotification_Labels_AdditionalEmailSubject";
                    public const string AddtionalEmailMessage = "JCCSems_User_EmailNotification_Labels_AddtionalEmailMessage";
                    public const string PreviousButtonText = "JCCSems_User_EmailNotification_Labels_PreviousButtonText";
                    public const string SendButtonText = "JCCSems_User_EmailNotification_Labels_SendButtonText";
                    public const string SaveAndNextButtonText = "JCCSems_User_EmailNotification_Labels_SaveAndNextButtonText";
                    public const string CancelButtonText = "JCCSems_User_EmailNotification_Labels_CancelButtonText";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string EmailSentSuccessfully = "JCCSems_User_EmailNotification_NotificationMessages_EmailSentSuccessfully";
                    public const string NoCheckBoxIsChecked = "JCCSems_User_EmailNotification_NotificationMessages_NoCheckBoxIsChecked";
                    public const string DefaultEmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_DefaultEmailNotSent";
                    public const string AddtionalEmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_AddtionalEmailNotSent";
                    public const string EmailNotSent = "JCCSems_User_EmailNotification_NotificationMessages_EmailNotSent";
                    public const string ConfirmationBoxHeader = "JCCSems_User_EmailNotification_NotificationMessages_ConfirmationBoxHeader";
                    public const string Ok = "JCCSems_User_EmailNotification_NotificationMessages_Ok";
                }
            }

            /// <summary>
            /// Class for Constants for User Notification Message
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class NotificationMessages
            {
                public const string UserNotAuthorized = "JCCSems_User_Wizard_UserNotAuthorized";
                public const string NoUserFound = "JCCSems_User_Wizard_NoUserFound";
                public const string ResetPasswordErrorText = "JCCSems_User_EditUser_ResetPasswordFailure";
                public const string UserUpdateSuccess = "JCCSems_User_EditUser_UserUpdateSuccess";
                public const string ResetPasswordSuccess = "JCCSems_User_EditUser_ResetPasswordSuccess";
                public const string NoAssignedCompanies = "JCCSems_User_NotificationMessages_NoAssignedCompanies";
            }

        }

        /// <summary>
        /// Class for Constants for Affiliations
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Affiliations
        {
            /// <summary>
            /// Class AddNewContact.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AddNewContact
            {
                public const string Title = "JCCSems_Affiliations_AddNewContact_Title";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string BusinessLocation = "JCCSems_Affiliations_AddNewContact_Labels_BusinessLocation";
                    public const string FirstName = "JCCSems_Affiliations_AddNewContact_Labels_FirstName";
                    public const string LastName = "JCCSems_Affiliations_AddNewContact_Labels_LastName";

                    public const string Position = "JCCSems_Affiliations_AddNewContact_Labels_Position";
                    public const string OfficeDirectLine = "JCCSems_Affiliations_AddNewContact_Labels_OfficeDirectLine";
                    public const string CellPhone = "JCCSems_Affiliations_AddNewContact_Labels_CellPhone";

                    public const string PrimaryEmail = "JCCSems_Affiliations_AddNewContact_Labels_PrimaryEmail";
                    public const string PrimaryEmailPlaceHolder = "JCCSems_Affiliations_AddNewContact_Labels_PrimaryEmailPlaceHolder";

                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    public const string ButtonSave = "JCCSems_Affiliations_AddNewContact_Buttons_ButtonSave";
                    public const string ButtonClose = "JCCSems_Affiliations_AddNewContact_Buttons_ButtonClose";
                }

                /// <summary>
                /// Class Validations.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validations
                {
                    public const string CancelConfirmationMessage = "JCCSems_Affiliations_AddNewContact_Validations_CancelConfirmationMessage";
                }
            }

            /// <summary>
            /// Class AddNewCompany.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory,
                SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class AddNewCompany
            {
                public const string Title = "JCCSems_Affiliations_AddNewCompany_Title";
                public const string IndicateRequireField = "JCCSems_Affiliations_AddNewCompany_IndicateRequireField";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string CompanyName = "JCCSems_Affiliations_AddNewCompany_Labels_CompanyName";
                    public const string FirstName = "JCCSems_Affiliations_AddNewCompany_Labels_FirstName";
                    public const string LastName = "JCCSems_Affiliations_AddNewCompany_Labels_LastName";

                    public const string JobTitle = "JCCSems_Affiliations_AddNewCompany_Labels_JobTitle";
                    public const string OfficeDirectLine = "JCCSems_Affiliations_AddNewCompany_Labels_OfficeDirectLine";
                    public const string CellPhone = "JCCSems_Affiliations_AddNewCompany_Labels_CellPhone";

                    public const string PrimaryEmail = "JCCSems_Affiliations_AddNewCompany_Labels_PrimaryEmail";
                    public const string PrimaryEmailPlaceHolder = "JCCSems_Affiliations_AddNewCompany_Labels_PrimaryEmailPlaceHolder";

                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    public const string ButtonSave = "JCCSems_Affiliations_AddNewCompany_Buttons_ButtonSave";
                    public const string ButtonCancel = "JCCSems_Affiliations_AddNewCompany_Buttons_ButtonCancel";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Error
                {
                    public const string FailToSaveCompany = "JCCSems_Affiliations_AddNewCompany_Error_FailToSaveCompany";
                }

                /// <summary>
                /// Class Validations.
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validations
                {
                    public const string OrganizationRequired = "JCCSems_Affiliations_AddNewCompany_Validations_OrganizationRequired";
                    public const string CompanyMaxlength = "JCCSems_Affiliations_AddNewCompany_Validations_CompanyMaxlength";
                    public const string CancelConfirmationMessage = "JCCSems_Affiliations_AddNewCompany_Validations_CancelConfirmationMessage";
                }

            }

            /// <summary>
            /// Class for Constants for Dashboard
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Dashboard
            {
                public const string Title = "JCCSems_Affiliations_Dashboard_Title";
                public const string Heading = "JCCSems_Affiliations_Dashboard_Heading";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Dashboard = "JCCSems_Affiliations_Dashboard_Labels_Dashboard";
                    public const string MyAffiliations = "JCCSems_Affiliations_Dashboard_Labels_MyAffiliations";
                    public const string ExpandAll = "JCCSems_Affiliations_Dashboard_Labels_ExpandAll";
                    public const string CollapseAll = "JCCSems_Affiliations_Dashboard_Labels_CollapseAll";
                    public const string PendingMyReview = "JCCSems_Affiliations_Dashboard_Labels_PendingMyReview";
                    public const string AffiliationRequests = "JCCSems_Affiliations_Dashboard_Labels_AffiliationRequests";
                    public const string ArchievedAffiliationRequests = "JCCSems_Affiliations_Dashboard_Labels_ArchievedAffiliationRequests";
                    public const string EmptyResultText = "JCCSems_Affiliations_Dashboard_Labels_EmptyResultText";

                    public const string FailedToFetchPendingMyReviewsGridResult =
                        "JCCSems_Affiliations_Dashboard_Labels_FailedToFetchPendingMyReviewsGridResult";
                    public const string FailedToFetchAffiliationRequestsGridResult =
                        "JCCSems_Affiliations_Dashboard_Labels_FailedToFetchAffiliationRequestsGridResult";
                    public const string FailedToFetchArchivedAffiliationRequestGridResult =
                        "JCCSems_Affiliations_Dashboard_Labels_FailedToFetchArchivedAffiliationRequestGridResult";
                    public const string AddNewAffiliation = "JCCSems_Affiliations_Dashboard_Labels_AddNewAffiliation";
                }

                /// <summary>
                /// Class for Constants for Tooltip
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Tooltip
                {
                    public const string Review = "JCCSems_Affiliations_Dashboard_Tooltip_Review";
                    public const string View = "JCCSems_Affiliations_Dashboard_Tooltip_View";
                    public const string Archive = "JCCSems_Affiliations_Dashboard_Tooltip_Archive";
                    public const string UndoArchive = "JCCSems_Affiliations_Dashboard_Tooltip_UndoArchive";
                    public const string SubscriptionReview = "JCCSems_Affiliations_Dashboard_Tooltip_SubscriptionReview";

                    public const string NoPermissionToReview = "JCCSems_Affiliations_Dashboard_Tooltip_NoPermissionToReview";
                    public const string NoPermissionToView = "JCCSems_Affiliations_Dashboard_Tooltip_NoPermissionToView";
                    public const string NoPermissionToEdit = "JCCSems_Affiliations_Dashboard_Tooltip_NoPermissionToEdit";
                }

                /// <summary>
                /// Class for Constants for Notification message
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessage
                {
                    public const string DoYouWantToArchiveTitle = "JCCSems_Affiliations_Dashboard_NotificationMessage_DoYouWantToArchiveTitle";
                    public const string DoYouWantToUndoArchiveTitle = "JCCSems_Affiliations_Dashboard_NotificationMessage_DoYouWantToUndoArchiveTitle";
                    public const string DoYouWantToArchiveMessage = "JCCSems_Affiliations_Dashboard_NotificationMessage_DoYouWantToArchiveMessage";
                    public const string DoYouWantToUndoArchiveMessage = "JCCSems_Affiliations_Dashboard_NotificationMessage_DoYouWantToUndoArchiveMessage";

                    public const string AffiliationNotExists = "JCCSems_Affiliations_Dashboard_NotificationMessage_AffiliationNotExists";
                    public const string FailedToUpdateAffiliation = "JCCSems_Affiliations_Dashboard_NotificationMessage_FailedToUpdateAffiliation";
                    public const string ArchivedSuccessfully = "JCCSems_Affiliations_Dashboard_NotificationMessage_ArchivedSuccessfully";
                    public const string UndoArchivedSuccessfully = "JCCSems_Affiliations_Dashboard_NotificationMessage_UndoArchivedSuccessfully";
                }

                /// <summary>
                /// Class for Constants for Subscription Review
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class SubscriptionReview
                {
                    public const string Title = "JCCSems_Affiliations_Dashboard_SubscriptionReview_Title";
                    public const string Heading = "JCCSems_Affiliations_Dashboard_SubscriptionReview_Heading";

                    /// <summary>
                    /// Class for Constants for Labels
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Labels
                    {
                        public const string CommentsForBillingAdministrator =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_CommentsForBillingAdministrator";
                        public const string AddSubscription = "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_AddSubscription";
                        public const string EndAffiliation = "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_EndAffiliation";
                        public const string Cancel = "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_Cancel";

                        public const string SubscriptionReviewDisplayText1 =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_SubscriptionReviewDisplayText1";
                        public const string SubscriptionReviewDisplayText2 =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_SubscriptionReviewDisplayText2";
                        public const string SubscriptionReviewDisplayText3 =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Labels_SubscriptionReviewDisplayText3";
                    }

                    /// <summary>
                    /// Class for Constants for Notification message
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class NotificationMessage
                    {
                        public const string SubscriptionNotExists =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_NotificationMessage_SubscriptionNotExists";
                        public const string FailedToSaveSubscription =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_NotificationMessage_FailedToSaveSubscription";
                        public const string SubscriptionSavedSuccessfully =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_NotificationMessage_SubscriptionSavedSuccessfully";
                        public const string SubscriptionEndedSuccessfully =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_NotificationMessage_SubscriptionEndedSuccessfully";
                    }

                    /// <summary>
                    /// Class for Constants for Validation
                    /// </summary>
                    [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                    [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                    public static class Validation
                    {
                        public const string CommentsForBillingAdministratorRequired =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Validation_CommentsForBillingAdministratorRequired";
                        public const string CommentForBillingAdministratorLengthExceeds =
                            "JCCSems_Affiliations_Dashboard_SubscriptionReview_Validation_CommentForBillingAdministratorLengthExceeds";
                    }
                }

            }

            /// <summary>
            /// Class for resource keys for New Affiliation Request
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class NewRequest
            {
                public const string Title = "JCCSems_Affiliations_NewRequest_Title";
                public const string Heading = "JCCSems_Affiliations_NewRequest_Heading";
                public const string FeatureName = "JCCSems_Affiliations_NewRequest_FeatureName";

                /// <summary>
                /// Class for resource keys for Button text
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Buttons
                {
                    public const string Submit = "JCCSems_Affiliations_NewRequest_Buttons_Submit";
                    public const string Reset = "JCCSems_Affiliations_NewRequest_Buttons_Reset";
                }

                /// <summary>
                /// Class for resource keys for labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string CompanyConnectionRequest = "JCCSems_Affiliations_NewRequest_Labels_CompanyConnectionRequest";
                    public const string SubscriptionInformation = "JCCSems_Affiliations_NewRequest_Labels_SubscriptionInformation";
                    public const string SubscriptionInformationHeading = "JCCSems_Affiliations_NewRequest_Labels_SubscriptionInformationHeading";
                    public const string Subscribe = "JCCSems_Affiliations_NewRequest_Labels_Subscribe";
                    public const string DoNotWishToSubscribe = "JCCSems_Affiliations_NewRequest_Labels_DoNotWishToSubscribe";
                    public const string RegisterNow = "JCCSems_Affiliations_NewRequest_Labels_RegisterNow";
                    public const string Name = "JCCSems_Affiliations_NewRequest_Labels_Name";
                    public const string PrimaryEmail = "JCCSems_Affiliations_NewRequest_Labels_PrimaryEmail";
                    public const string UserName = "JCCSems_Affiliations_NewRequest_Labels_UserName";
                    public const string Password = "JCCSems_Affiliations_NewRequest_Labels_Password";
                    public const string ConfirmPassword = "JCCSems_Affiliations_NewRequest_Labels_ConfirmPassword";
                    public const string NewUserRegistration = "JCCSems_Affiliations_NewRequest_Labels_NewUserRegistration";
                }

                /// <summary>
                /// Class for resource keys for Validation messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Validation
                {
                    public const string UserNameRequired = "JCCSems_Affiliations_NewRequest_Validation_UserNameRequired";
                    public const string UserNameLength = "JCCSems_Affiliations_NewRequest_Validation_UserNameLength";
                    public const string PasswordRequired = "JCCSems_Affiliations_NewRequest_Validation_PasswordRequired";
                    public const string InvalidPasswordLength = "JCCSems_Affiliations_NewRequest_Validation_InvalidPasswordLength";
                    public const string PasswordFormatInvalid = "JCCSems_Affiliations_NewRequest_Validation_PasswordFormatInvalid";
                    public const string ConfirmPasswordRequired = "JCCSems_Affiliations_NewRequest_Validation_ConfirmPasswordRequired";
                    public const string ConfirmPasswordNotMatch = "JCCSems_Affiliations_NewRequest_Validation_ConfirmPasswordNotMatch";
                    public const string ConfirmPasswordLengthExceeds = "JCCSems_Affiliations_NewRequest_Validation_ConfirmPasswordLengthExceeds";
                    public const string InvalidAffiliationSubscription = "JCCSems_Affiliations_NewRequest_Validation_InvalidAffiliationSubscription";
                }

                /// <summary>
                /// Class for resource keys for Notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string IndividualNotAssociated = "JCCSems_Affiliations_NewRequest_NotificationMessages_IndividualNotAssociated";
                    public const string FailedToUpdateAffiliationStatus = "JCCSems_Affiliations_NewRequest_NotificationMessages_FailedToUpdateAffiliationStatus";
                    public const string AffiliationNotExists = "JCCSems_Affiliations_NewRequest_NotificationMessages_AffiliationNotExists";
                    public const string FailedToUpdateAffiliationRequest = "JCCSems_Affiliations_NewRequest_NotificationMessages_FailedToUpdateAffiliationRequest";
                    public const string FailedToAddCompanySubscription = "JCCSems_Affiliations_NewRequest_NotificationMessages_FailedToAddCompanySubscription";
                    public const string SubscribedSuccessfully = "JCCSems_Affiliations_NewRequest_NotificationMessages_SubscribedSuccessfully";
                    public const string SubscriptionReject = "JCCSems_Affiliations_NewRequest_NotificationMessages_SubscriptionReject";
                    public const string SubscriptionAcceptEmailNotSent = "JCCSems_Affiliations_NewRequest_NotificationMessages_SubscriptionAcceptEmailNotSent";
                    public const string SubscriptionRejectEmailNotSent = "JCCSems_Affiliations_NewRequest_NotificationMessages_SubscriptionRejectEmailNotSent";
                    public const string ResetHeader = "JCCSems_Affiliations_NewRequest_NotificationMessages_ResetHeader";
                    public const string ResetMessage = "JCCSems_Affiliations_NewRequest_NotificationMessages_ResetMessage";
                    public const string SubscriptionRequestExpired = "JCCSems_Affiliations_NewRequest_NotificationMessages_SubscriptionRequestExpired";
                }
            }

            /// <summary>
            /// Class for resource keys for my affiliation Tab
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class MyAffiliationTab
            {
                public const string Title = "JCCSems_Affiliations_MyAffiliationTab_Title";
                public const string Heading = "JCCSems_Affiliations_MyAffiliationTab_Heading";

                /// <summary>
                /// Class for resource keys for adding a my affiliation tabs labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string PleaseSelectACompanyFirst = "JCCSems_Affiliations_MyAffiliationTab_Labels_PleaseSelectACompanyFirst";
                    public const string AffiliationDetails = "JCCSems_Affiliations_MyAffiliationTab_Labels_AffiliationDetails";
                    public const string Downwards = "JCCSems_Affiliations_MyAffiliationTab_Labels_Downwards";
                    public const string Upwards = "JCCSems_Affiliations_MyAffiliationTab_Labels_Upwards";
                    public const string Update = "JCCSems_Affiliations_MyAffiliationTab_Labels_Update";
                    public const string Cancel = "JCCSems_Affiliations_MyAffiliationTab_Labels_Cancel";
                    public const string EndAffiliation = "JCCSems_Affiliations_MyAffiliationTab_Labels_EndAffiliation";
                }

                /// <summary>
                /// Class for resource keys for adding a my affiliation tabs tooltip
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class ToolTip
                {
                    public const string Edit = "JCCSems_Affiliations_MyAffiliationTab_ToolTip_Edit";
                }

                /// <summary>
                /// Class for Constants for Error
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Error
                {
                    public const string FailedToFetchCompanies = "JCCSems_Affiliations_MyAffiliationTab_Error_FailedToFetchCompanies";
                }
            }

            /// <summary>
            /// Class for resource keys for adding a new affiliation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Add
            {
                public const string Title = "JCCSems_Affiliations_Add_Title";
                public const string Heading = "JCCSems_Affiliations_Add_Heading";

                /// <summary>
                /// Class for resource keys for adding a new affiliation labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Company = "JCCSems_Affiliations_Add_Labels_Company";
                    public const string NatureOfWork = "JCCSems_Affiliations_Add_Labels_NatureOfWork";
                    public const string New = "JCCSems_Affiliations_Add_Labels_New";
                    public const string Go = "JCCSems_Affiliations_Add_Labels_Go";
                    public const string Cancel = "JCCSems_Affiliations_Add_Labels_Cancel";
                    public const string IsPerformingWorkFor = "JCCSems_Affiliations_Add_Labels_IsPerformingWorkFor";
                    public const string AddAffiliation = "JCCSems_Affiliations_Add_Labels_AddAffiliation";
                }

                /// <summary>
                /// Class for resource keys for adding a new affiliation notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string CheckExistingAffiliationHeader =
                        "JCCSems_Affiliations_Add_NotificationMessages_CheckExistingAffiliationHeader";
                    public const string CheckExistingAffiliationMessage =
                        "JCCSems_Affiliations_Add_NotificationMessages_CheckExistingAffiliationMessage";
                    public const string SelectNatureOfWorkHeader = "JCCSems_Affiliations_Add_NotificationMessages_SelectNatureOfWorkHeader";
                    public const string SelectNatureOfWorkMessage = "JCCSems_Affiliations_Add_NotificationMessages_SelectNatureOfWorkMessage";
                    public const string ConfirmNatureOfWorkGoHeader = "JCCSems_Affiliations_Add_NotificationMessages_ConfirmNatureOfWorkGoHeader";
                    public const string ConfirmNatureOfWorkGoMessage = "JCCSems_Affiliations_Add_NotificationMessages_ConfirmNatureOfWorkGoMessage";
                    public const string FailedToFetchDataForAddAffiliation =
                        "JCCSems_Affiliations_Add_NotificationMessages_FailedToFetchDataForAddAffiliation";
                    public const string ConfirmationMessageForFileDeletion =
                        "JCCSems_Affiliations_Add_NotificationMessages_ConfirmationMessageForFileDeletion";
                    public const string SaveAffiliationFailed =
                        "JCCSems_Affiliations_Add_NotificationMessages_SaveAffiliationFailed";
                    public const string AddAffiliationHeader = "JCCSems_Affiliations_Add_NotificationMessages_AddAffiliationHeader";
                    public const string AddAffiliationMessage = "JCCSems_Affiliations_Add_NotificationMessages_AddAffiliationMessage";
                    public const string SendMailFailed = "JCCSems_Affiliations_Add_NotificationMessages_SendMailFailed";
                }
            }

            /// <summary>
            /// Class for resource keys for view affiliation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class View
            {
                public const string Title = "JCCSems_Affiliations_View_Title";
                public const string Heading = "JCCSems_Affiliations_View_Heading";

                /// <summary>
                /// Class for resource keys for viewing affiliation labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Back = "JCCSems_Affiliations_View_Labels_Back";
                }

                /// <summary>
                /// Class for resource keys for viewing affiliation notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string FailedToFetchData =
                        "JCCSems_Affiliations_View_NotificationMessages_FailedToFetchData";
                }
            }

            /// <summary>
            /// Class for resource keys for review affiliation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Review
            {
                public const string Title = "JCCSems_Affiliations_Review_Title";
                public const string Heading = "JCCSems_Affiliations_Review_Heading";

                /// <summary>
                /// Class for resource keys for reviewing affiliation labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string Back = "JCCSems_Affiliations_Review_Labels_Back";
                    public const string UpdateAndAccept = "JCCSems_Affiliations_Review_Labels_UpdateAndAccept";
                    public const string Decline = "JCCSems_Affiliations_Review_Labels_Decline";
                    public const string Cancel = "JCCSems_Affiliations_Review_Labels_Cancel";
                }

                /// <summary>
                /// Class for resource keys for reviewing affiliation notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string FailedToFetchData =
                        "JCCSems_Affiliations_Review_NotificationMessages_FailedToFetchData";
                    public const string UpdateAndAcceptAffiliationHeader =
                        "JCCSems_Affiliations_Review_NotificationMessages_UpdateAndAcceptAffiliationHeader";
                    public const string UpdateAndAcceptAffiliationMessage =
                        "JCCSems_Affiliations_Review_NotificationMessages_UpdateAndAcceptAffiliationMessage";
                    public const string DeclineAffiliationHeader =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationHeader";
                    public const string DeclineAffiliationMessage =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationMessage";
                    public const string DeclineAffiliationFailed =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationFailed";
                    public const string UpdateAndAcceptAffiliationFailed =
                        "JCCSems_Affiliations_Review_NotificationMessages_UpdateAndAcceptAffiliationFailed";
                    public const string DeclineAffiliationConfirmationHeader =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationConfirmationHeader";
                    public const string DeclineAffiliationConfirmationMessage =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationConfirmationMessage";
                    public const string AcceptAffiliationSendMailFailed =
                        "JCCSems_Affiliations_Review_NotificationMessages_AcceptAffiliationSendMailFailed";
                    public const string DeclineAffiliationSendMailFailed =
                        "JCCSems_Affiliations_Review_NotificationMessages_DeclineAffiliationSendMailFailed";
                }
            }

            /// <summary>
            /// Class for resource keys for edit affiliation
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Edit
            {
                /// <summary>
                /// Class for resource keys for editting affiliation labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                }

                /// <summary>
                /// Class for resource keys for editting affiliation notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string FailedToFetchData =
                        "JCCSems_Affiliations_Edit_NotificationMessages_FailedToFetchData";
                    public const string UpdateAffiliationFailed = "JCCSems_Affiliations_Edit_NotificationMessages_UpdateAffiliationFailed";
                    public const string EndAffiliationFailed = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationFailed";
                    public const string EndAffiliationHeader = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationHeader";
                    public const string EndAffiliationMessage = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationMessage";
                    public const string UpdateAffiliationHeader = "JCCSems_Affiliations_Edit_NotificationMessages_UpdateAffiliationHeader";
                    public const string UpdateAffiliationMessage = "JCCSems_Affiliations_Edit_NotificationMessages_UpdateAffiliationMessage";
                    public const string EndAffiliationConfirmationHeader = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationConfirmationHeader";
                    public const string EndAffiliationConfirmationMessage = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationConfirmationMessage";
                    public const string EndAffiliationSendMailFailed = "JCCSems_Affiliations_Edit_NotificationMessages_EndAffiliationSendMailFailed";
                }
            }

            /// <summary>
            /// Class for resource keys for affiliation details
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Details
            {
                /// <summary>
                /// Class for resource keys for affiliation details labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string CompanyDetails = "JCCSems_Affiliations_Details_Labels_CompanyDetails";
                    public const string IsPerformingWorkFor = "JCCSems_Affiliations_Details_Labels_IsPerformingWorkFor";
                    public const string NatureOfWorkTitle = "JCCSems_Affiliations_Details_Labels_NatureOfWorkTitle";
                    public const string NatureOfWorkDescription = "JCCSems_Affiliations_Details_Labels_NatureOfWorkDescription";
                    public const string AffiliationTypeTitle = "JCCSems_Affiliations_Details_Labels_AffiliationTypeTitle";
                    public const string AffiliationTypeDescription = "JCCSems_Affiliations_Details_Labels_AffiliationTypeDescription";
                    public const string PointOfContactTitle = "JCCSems_Affiliations_Details_Labels_PointOfContactTitle";
                    public const string PointOfContactDescription = "JCCSems_Affiliations_Details_Labels_PointOfContactDescription";
                    public const string New = "JCCSems_Affiliations_Details_Labels_New";
                    public const string Operator = "JCCSems_Affiliations_Details_Labels_Operator";
                    public const string Contractor = "JCCSems_Affiliations_Details_Labels_Contractor";
                    public const string CommentsTitle = "JCCSems_Affiliations_Details_Labels_CommentsTitle";
                    public const string CommentsDescription = "JCCSems_Affiliations_Details_Labels_CommentsDescription";
                    public const string FilesTitle = "JCCSems_Affiliations_Details_Labels_FilesTitle";
                    public const string FilesDescription = "JCCSems_Affiliations_Details_Labels_FilesDescription";
                    public const string Upload = "JCCSems_Affiliations_Details_Labels_Upload";
                    public const string CompaniesTitle = "JCCSems_Affiliations_Details_Labels_CompaniesTitle";
                    public const string CompaniesDescription = "JCCSems_Affiliations_Details_Labels_CompaniesDescription";
                    public const string Select = "JCCSems_Affiliations_Details_Labels_Select";
                    public const string CompaniesForWhichChildIsWorking = "JCCSems_Affiliations_Details_Labels_CompaniesForWhichChildIsWorking";
                    public const string CompaniesWorkingForParent = "JCCSems_Affiliations_Details_Labels_CompaniesWorkingForParent";
                    public const string InformationSharingTitle = "JCCSems_Affiliations_Details_Labels_InformationSharingTitle";
                    public const string InformationSharingDescription = "JCCSems_Affiliations_Details_Labels_InformationSharingDescription";
                    public const string TrainingTitle = "JCCSems_Affiliations_Details_Labels_TrainingTitle";
                    public const string TrainingDescription = "JCCSems_Affiliations_Details_Labels_TrainingDescription";
                    public const string TrainingPlan = "JCCSems_Affiliations_Details_Labels_TrainingPlan";
                    public const string EmployeeRecords = "JCCSems_Affiliations_Details_Labels_EmployeeRecords";
                    public const string ShareSelectedCompaniesWith = "JCCSems_Affiliations_Details_Labels_ShareSelectedCompaniesWith";
                    public const string RequiredTrainingDescription = "JCCSems_Affiliations_Details_Labels_RequiredTrainingDescription";
                    public const string FollowTrainingRequirements = "JCCSems_Affiliations_Details_Labels_FollowTrainingRequirements";
                    public const string SelectCompanies = "JCCSems_Affiliations_Details_Labels_SelectCompanies";
                    public const string PendingForApproval = "JCCSems_Affiliations_Details_Labels_PendingForApproval";
                    public const string Approved = "JCCSems_Affiliations_Details_Labels_Approved";
                    public const string Denied = "JCCSems_Affiliations_Details_Labels_Denied";
                    public const string SubscriptionDeclined = "JCCSems_Affiliations_Details_Labels_SubscriptionDeclined";
                    public const string Ended = "JCCSems_Affiliations_Details_Labels_Ended";
                    public const string Delete = "JCCSems_Affiliations_Details_Labels_Delete";
                    public const string Edit = "JCCSems_Affiliations_Details_Labels_Edit";
                    public const string TargetCompanyHasNotSharedCompanyNames = "JCCSems_Affiliations_Details_Labels_TargetCompanyHasNotSharedCompanyNames";
                    public const string SelectCompaniesWhichWillBeWorkingForTarget =
                        "JCCSems_Affiliations_Details_Labels_SelectCompaniesWhichWillBeWorkingForTarget";
                    public const string SelectCompaniesForWhichTargetWillBeWorking =
                        "JCCSems_Affiliations_Details_Labels_SelectCompaniesForWhichTargetWillBeWorking";
                    public const string AvailableCompanies = "JCCSems_Affiliations_Details_Labels_AvailableCompanies";
                    public const string AssignedCompanies = "JCCSems_Affiliations_Details_Labels_AssignedCompanies";
                    public const string ShowMore = "JCCSems_Affiliations_Details_Labels_ShowMore";
                    public const string ShowLess = "JCCSems_Affiliations_Details_Labels_ShowLess";
                    public const string Email = "JCCSems_Affiliations_Details_Labels_Email";
                    public const string OfficeDirectLine = "JCCSems_Affiliations_Details_Labels_OfficeDirectLine";
                    public const string OfficePhone = "JCCSems_Affiliations_Details_Labels_OfficePhone";
                }

                /// <summary>
                /// Class for resource keys for affiliation details notification messages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMessages
                {
                    public const string AffiliationSelectCompaniesCancelConfirmationMessage =
                        "JCCSems_Affiliations_Details_NotificationMessages_AffiliationSelectCompaniesCancelConfirmationMessage";
                }
            }

            /// <summary>
            /// Class for resource keys for affiliation validations.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class Validations
            {
                public const string CommentsLength = "JCCSems_Affiliations_Validations_CommentsLength";
                public const string PointOfContactRequired = "JCCSems_Affiliations_Validations_PointOfContactRequired";
            }
        }

        /// <summary>
        /// Class for Constants for Equipment
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Equipment
        {
            /// <summary>
            /// Class for Constants for EquipmentProfile
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
            public static class EquipmentProfile
            {
                public const string Heading = "JCCSems_Equipment_EquipmentProfile_Heading";
                public const string Title = "JCCSems_Equipment_EquipmentProfile_Title";

                /// <summary>
                /// Class for Constants for Labels
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class Labels
                {
                    public const string AllEquipmentLocations = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_AllEquipmentLocations";
                    public const string SelectClient = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_SelectClient";
                    public const string SelectEquipment = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_SelectEquipment";
                    public const string Identification = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Identification";
                    public const string Contacts = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Contacts";
                    public const string Maintenance = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Maintenance";
                    public const string Locations = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Locations";
                    public const string RelatedEquipment = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_RelatedEquipment";
                    public const string Documents = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Documents";
                    public const string Qualifications = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_Qualifications";
                }

                /// <summary>
                /// Class for Constants for NotificationMeassages
                /// </summary>
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
                public static class NotificationMeassages
                {
                    public const string DataFetchFailed = "JCCSems_Equipment_EquipmentProfile_NotificationMeassages_DataFetchFailed";
                }
            }
        }
    }
}