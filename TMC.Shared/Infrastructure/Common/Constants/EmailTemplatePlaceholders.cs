using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Shared
{
    public static class EmailTemplatePlaceholders
    {
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class ForgotPassword
        {
            public const string UserName = "pl_UserName";
            public const string Password = "pl_Password";
            public const string BodyPlaceholder = "pl_BodyPlaceHolder";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class UserCreation
        {
            public const string UserName = "pl_UserName";
            public const string Password = "pl_Password";
            public const string BodyPlaceholder = "pl_BodyPlaceHolder";
        }
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class AdditionalDetails
        {
            public const string SubjectPlaceholder = "pl_Subject";
            public const string BodyPlaceholder = "pl_BodyPlaceHolder";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class ResetPassword
        {
            public const string UserName = "pl_UserName";
            public const string NewPassword = "pl_NewPassword";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class Template
        {
            public const string DomainPath = "pl_DomainPath";
            public const string FirstName = "pl_FirstName";
        }
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class CompanySubscription
        {
            public const string FirstName = "pl_FirstName";
            public const string CompanyNamePlaceholder = "pl_CompanyName";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class AffiliationSubscription
        {
            public const string CompanyName = "pl_CompanyName";
            public const string TargetPOCName = "pl_TargetPOCName";
            public const string SourcePOCName = "pl_SourcePOCName";
            public const string SourceClientId = "pl_ClientId";
            public const string SourceCompanyName = "pl_SourceCompanyName";
            public const string TargetCompanyName = "pl_TargetCompanyName";
            public const string SubscriptionName = "pl_SubscriptionName";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class NewAffiliationRequest
        {
            public const string TargetPoCName = "pl_TargetPOCName";
            public const string SourcePoCName = "pl_SourcePOCName";
            public const string SourceCompanyName = "pl_SourceCompanyName";
            public const string ReviewUrl = "pl_reviewLink";
        }
    }

    public static class EmailConstants
    {
        public const string templatePlaceholderStart = "{#(";
        public const string templatePlaceholderEnd = ")#}";
    }
}