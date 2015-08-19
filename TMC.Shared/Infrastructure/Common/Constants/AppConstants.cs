using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace TMC.Shared
{
    /// <summary>
    /// Contains application level constants.    
    /// Author: Nagarro
    /// </summary>
    public static class AppConstants
    {
        /// <summary>
        /// Contains configuration keys constants
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public struct ConfigurationKeys
        {
            #region "Properties"

            /// <summary>
            /// Constant representing the assemblies' output bin folder name.
            /// </summary>
            public static readonly string OutputBinFolderName;

            /// <summary>
            /// 
            /// </summary>
            public static readonly string IsTestMail;

            /// <summary>
            /// Company profile images upload folder path
            /// </summary>
            public static readonly string CompanyProfileImagesUploadFolderPath;

            /// <summary>
            /// SSO IsLoggedIn Url
            /// </summary>
            public static readonly string SSOIsLoggedInUrl;

            /// <summary>
            /// SSOLoginUrl
            /// </summary>
            public static readonly string SSOLoginUrl;

            /// <summary>
            /// SSOLogoutUrl
            /// </summary>
            public static readonly string SSOLogoutUrl;

            /// <summary>
            /// To set Maximum Number of Invalid Login Attemps
            /// </summary>
            public static readonly short MaxInvalidLogOnAttempts;

            /// <summary>
            /// To set Maximum Time for Locked Account
            /// </summary>
            public static readonly short MaxTimeForLockedAccount;

            /// <summary>
            /// UserStatusToCheck
            /// </summary>
            public static readonly short UserStatusToCheck;

            /// <summary>
            /// Carousel Images Source Path
            /// </summary>
            public static readonly string CarouselImagesSourcePath;

            /// <summary>
            /// Carousel Images Number to be displayed
            /// </summary>
            public static readonly int CarouselImagesNumber;

            /// <summary>
            /// Domain Name used by Email template
            /// </summary>
            public static readonly string JCCSemsDomainNameForEmailTemplate;

            /// <summary>
            /// Default Email address to be used for 'From'
            /// </summary>
            public static readonly string DefaultEmailFromAddress;

            /// <summary>
            /// Email address to be used for sending email to when an exception occurs  
            /// </summary>
            public static readonly string ExceptionEmailToAddress;

            /// <summary>
            /// period for which a security stamp will be valid
            /// </summary>
            public static readonly int SecurityStampValidityPeriod;

            /// <summary>
            /// lear about training courses url.
            /// </summary>
            public static readonly string LearnAboutTrainingCoursesUrl;

            /// <summary>
            /// Return jcc project Id.
            /// </summary>
            public static readonly int JCCProjectId;

            /// <summary>
            /// LoginAboutUrl
            /// </summary>
            public static readonly string LoginAboutUrl;

            /// <summary>
            /// LoginContactUrl
            /// </summary>
            public static readonly string LoginContactUrl;

            /// <summary>
            /// DefaultUser
            /// </summary>
            public static readonly string DefaultUser;

            /// <summary>
            /// MaximumRoleRank
            /// </summary>
            public static readonly string MaximumRoleRank;

            /// <summary>
            /// JCCSemsV1IntegrationMode
            /// </summary>
            public static readonly bool JCCSemsV1IntegrationMode;

            /// <summary>
            /// JCCSemsV1LoginSuccessRedirectUrl
            /// </summary>
            public static readonly string JCCSemsV1LoginSuccessRedirectUrl;

            /// <summary>
            /// File types allowed for company logo
            /// </summary>
            public static readonly string FileTypesAllowedForCompanyLogo;

            /// <summary>
            /// File types allowed for company document
            /// </summary>
            public static readonly string FileTypesAllowedForCompanyDocument;

            /// <summary>
            /// Max file size allowed for company document uploader
            /// </summary>
            public static readonly int MaxFileSizeForCompanyDocumentUploader;


            /// <summary>
            /// Max file size allowed for company logo
            /// </summary>
            public static readonly int MaxFileSizeForCompanyLogo;

            /// <summary>
            /// GridPageSize
            /// </summary>
            public static readonly string GridPageSize;

            /// <summary>
            /// GridMaximumNumberOfVisiblePages
            /// </summary>
            public static readonly string GridMaximumNumberOfVisiblePages;

            /// <summary>
            /// The JCC sems v1 application path
            /// </summary>
            public static readonly string JCCSemsV1ApplicationPath;

            /// <summary>
            /// ShowStackTraceOnErrorPage
            /// </summary>
            public static readonly bool ShowStackTraceOnErrorPage;

            /// <summary>
            /// SessionIdCookieValidityPeriod
            /// </summary>
            public static readonly int SessionIdCookieValidityPeriod;

            /// <summary>
            /// DefaultLogoutUrl
            /// </summary>
            public static readonly string DefaultLogoutUrl;

            /// <summary>
            /// AccountManagerRole
            /// </summary>
            public static readonly int AccountManagerRole;

            /// <summary>
            /// The new subscription default roles
            /// </summary>
            public static IList<int> NewSubscriptionDefaultRoles;

            /// <summary>
            /// The billing admin email address
            /// </summary>
            public static string BillingAdminEmailAddress;

            /// <summary>
            /// Default Individual Id
            /// </summary>
            public static readonly int DefaultIndividualId;

            /// <summary>
            /// The debug mode.
            /// </summary>
            public static readonly string DebugMode;

            /// <summary>
            /// To Set Time span for the trigger of Job to Export Plan Section
            /// </summary>
            public static readonly string JobTriggerTimeSpan;

            /// <summary>
            /// Enable employee required certificates Export job.
            /// </summary>
            public static readonly string EnableEmployeeRequiredCertificatesExportJob;

            /// <summary>
            /// ExportedReportsPath
            /// </summary>
            public static readonly string ExportedReportsPath;

            /// <summary>
            /// The JCC sems v1 relative path
            /// </summary>
            public static readonly string JCCSemsV1RelativePath;

            #endregion

            #region "Constructor"

            static ConfigurationKeys()
            {
                if (ConfigurationManager.AppSettings.AllKeys.Contains("OutputBinFolderName"))
                {
                    OutputBinFolderName = ConfigurationManager.AppSettings["OutputBinFolderName"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("IsTestMail"))
                {
                    IsTestMail = ConfigurationManager.AppSettings["IsTestMail"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("CompanyProfileImagesUploadFolderPath"))
                {
                    CompanyProfileImagesUploadFolderPath = ConfigurationManager.AppSettings["CompanyProfileImagesUploadFolderPath"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("SSOIsLoggedInUrl"))
                {
                    SSOIsLoggedInUrl = ConfigurationManager.AppSettings["SSOIsLoggedInUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("SSOLoginUrl"))
                {
                    SSOLoginUrl = ConfigurationManager.AppSettings["SSOLoginUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("SSOLogoutUrl"))
                {
                    SSOLogoutUrl = ConfigurationManager.AppSettings["SSOLogoutUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("MaxInvalidLogOnAttempts"))
                {
                    MaxInvalidLogOnAttempts = Convert.ToInt16(ConfigurationManager.AppSettings["MaxInvalidLogOnAttempts"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("MaxTimeForLockedAccount"))
                {
                    MaxTimeForLockedAccount = Convert.ToInt16(ConfigurationManager.AppSettings["MaxTimeForLockedAccount"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("UserStatusToCheck"))
                {
                    UserStatusToCheck = Convert.ToInt16(ConfigurationManager.AppSettings["UserStatusToCheck"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("CarouselImagesSourcePath"))
                {
                    CarouselImagesSourcePath = ConfigurationManager.AppSettings["CarouselImagesSourcePath"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("CarouselImagesNumber"))
                {
                    CarouselImagesNumber = Convert.ToInt32(ConfigurationManager.AppSettings["CarouselImagesNumber"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCSemsDomainNameForEmailTemplate"))
                {
                    JCCSemsDomainNameForEmailTemplate = ConfigurationManager.AppSettings["JCCSemsDomainNameForEmailTemplate"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("DefaultEmailFromAddress"))
                {
                    DefaultEmailFromAddress = ConfigurationManager.AppSettings["DefaultEmailFromAddress"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("ExceptionEmailToAddress"))
                {
                    ExceptionEmailToAddress = ConfigurationManager.AppSettings["ExceptionEmailToAddress"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("SecurityStampValidityPeriod"))
                {
                    SecurityStampValidityPeriod = Convert.ToInt32(ConfigurationManager.AppSettings["SecurityStampValidityPeriod"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("LearnAboutTrainingCoursesUrl"))
                {
                    LearnAboutTrainingCoursesUrl = ConfigurationManager.AppSettings["LearnAboutTrainingCoursesUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCProjectId"))
                {
                    JCCProjectId = Convert.ToInt32(ConfigurationManager.AppSettings["JCCProjectId"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("LoginAboutUrl"))
                {
                    LoginAboutUrl = ConfigurationManager.AppSettings["LoginAboutUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("LoginContactUrl"))
                {
                    LoginContactUrl = ConfigurationManager.AppSettings["LoginContactUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("DefaultUser"))
                {
                    DefaultUser = ConfigurationManager.AppSettings["DefaultUser"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("MaximumRoleRank"))
                {
                    MaximumRoleRank = ConfigurationManager.AppSettings["MaximumRoleRank"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCSemsV1IntegrationMode"))
                {
                    JCCSemsV1IntegrationMode = Convert.ToBoolean(ConfigurationManager.AppSettings["JCCSemsV1IntegrationMode"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCSemsV1LoginSuccessRedirectUrl"))
                {
                    JCCSemsV1LoginSuccessRedirectUrl = ConfigurationManager.AppSettings["JCCSemsV1LoginSuccessRedirectUrl"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("FileTypesAllowedForCompanyLogo"))
                {
                    FileTypesAllowedForCompanyLogo = ConfigurationManager.AppSettings["FileTypesAllowedForCompanyLogo"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("FileTypesAllowedForCompanyDocument"))
                {
                    FileTypesAllowedForCompanyDocument = ConfigurationManager.AppSettings["FileTypesAllowedForCompanyDocument"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("MaxFileSizeAllowedForCompanyDocumentUploader"))
                {
                    MaxFileSizeForCompanyDocumentUploader = Convert.ToInt32(ConfigurationManager.AppSettings["MaxFileSizeAllowedForCompanyDocumentUploader"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("MaxFileSizeForCompanyLogo"))
                {
                    MaxFileSizeForCompanyLogo = Convert.ToInt32(ConfigurationManager.AppSettings["MaxFileSizeForCompanyLogo"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("GridPageSize"))
                {
                    GridPageSize = ConfigurationManager.AppSettings["GridPageSize"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("GridMaximumNumberOfVisiblePages"))
                {
                    GridMaximumNumberOfVisiblePages = ConfigurationManager.AppSettings["GridMaximumNumberOfVisiblePages"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCSemsV1ApplicationPath"))
                {
                    JCCSemsV1ApplicationPath = ConfigurationManager.AppSettings["JCCSemsV1ApplicationPath"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("ShowStackTraceOnErrorPage"))
                {
                    ShowStackTraceOnErrorPage = Convert.ToBoolean(ConfigurationManager.AppSettings["ShowStackTraceOnErrorPage"]);
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("SessionIdCookieValidityPeriod"))
                {
                    SessionIdCookieValidityPeriod = Convert.ToInt32(ConfigurationManager.AppSettings["SessionIdCookieValidityPeriod"].ToString());
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("DefaultLogoutUrl"))
                {
                    DefaultLogoutUrl = ConfigurationManager.AppSettings["DefaultLogoutUrl"].ToString();
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("AccountManagerRole"))
                {
                    AccountManagerRole = Convert.ToInt32(ConfigurationManager.AppSettings["AccountManagerRole"].ToString());
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("NewSubscriptionDefaultRoles"))
                {
                    NewSubscriptionDefaultRoles = Convert.ToString(ConfigurationManager.AppSettings["NewSubscriptionDefaultRoles"])
                                                    .Split(',')
                                                    .Select(role => Convert.ToInt32(role))
                                                    .ToList();
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("BillingAdminEmailAddress"))
                {
                    BillingAdminEmailAddress = ConfigurationManager.AppSettings["BillingAdminEmailAddress"].ToString();
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("DefaultIndividualId"))
                {
                    DefaultIndividualId = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultIndividualId"].ToString());
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("DebugMode"))
                {
                    DebugMode = ConfigurationManager.AppSettings["DebugMode"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JobTriggerTimeSpan"))
                {
                    JobTriggerTimeSpan = ConfigurationManager.AppSettings["JobTriggerTimeSpan"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("EnableEmployeeRequiredCertificatesExportJob"))
                {
                    EnableEmployeeRequiredCertificatesExportJob = ConfigurationManager.AppSettings["EnableEmployeeRequiredCertificatesExportJob"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("ExportedReportsPath"))
                {
                    ExportedReportsPath = ConfigurationManager.AppSettings["ExportedReportsPath"];
                }

                if (ConfigurationManager.AppSettings.AllKeys.Contains("JCCSemsV1RelativePath"))
                {
                    JCCSemsV1RelativePath = ConfigurationManager.AppSettings["JCCSemsV1RelativePath"];
                }
            }

            #endregion
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.PerformanceCategory, SuppressMessageConstants.OverrideEqualsAndOperatorEqualsOnValueTypes)]
        public struct EMAILREDIRECTIONURL
        {
            public static readonly string ReturnToDashboard = "returnToDashboard";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.PerformanceCategory, SuppressMessageConstants.OverrideEqualsAndOperatorEqualsOnValueTypes)]
        public struct Common
        {
            public static readonly string Url = "http://{0}/{1}";
            public static readonly string DataNotAvailable = "DataNotAvailable";
            public static readonly string PrintBodyPlaceholder = "pl_PrintBody";
            public static readonly char UnderScore = '_';
            public static readonly char Comma = ',';
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class Delimiters
        {
            public const string StartDelimiter = "##";
            public const string EndDelimiter = "##";
        }
    }
}
