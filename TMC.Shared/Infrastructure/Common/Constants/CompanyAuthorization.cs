using System.Diagnostics.CodeAnalysis;

namespace TMC.Shared
{
    public static class CompanyAuthorization
    {
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class Feature
        {
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class CompanyProfile
            {
                public const string View = "CompanyProfileView";
                public const string Edit = "CompanyProfileEdit";
                public const string Add = "CompanyProfileAdd";
                public const string Delete = "CompanyProfileAdd";
            }
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class BusinessLocation
            {
                public const string View = "BusinessLocationView";
                public const string Edit = "BusinessLocationEdit";
                public const string Add = "BusinessLocationAdd";
                public const string Delete = "BusinessLocationDelete";
            }

           
        }
    }
}