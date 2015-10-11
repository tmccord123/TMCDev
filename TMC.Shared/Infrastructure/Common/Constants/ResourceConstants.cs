// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceConstants.cs" company="TMC">
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
        public static class Common
        {
            public static class ErrorMessages
            {
                public const string FailedToFetchCities = "TMC_Common_ErrorMessages_FailedToFetchCities";
                public const string FailedToFetchCategories = "TMC_Common_ErrorMessages_FailedToFetchCategories";
            }

            public static class Labels
            {
                public const string MoreCategories = "TMC_Common_Labels_MoreCategories";
               
            }
        }

        /// <summary>
        /// The listing.
        /// </summary>
        public static class Listing
        {
            public static class ErrorMessages
            {
                public const string FailedToFetchListings = "TMC_Listing_ErrorMessages_FailedToFetchListings";
            }

            public static class Labels
            {

                public const string LocalBoardSearchHeading = "TMC_Listing_Labels_LocalBoardSearchHeading";
                public const string LocalBoardTrendsHeading = "TMC_Listing_Labels_LocalBoardTrendsHeading";
            }
        }

        /// <summary>
        /// Class for Constants for Layout
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Layout
        {
           
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class Vendor
        {
            public static class ErrorMessages
            {
                public const string FailedToFetchListing = "TMC_Common_ErrorMessages_FailedToFetchListing";
               
            }
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.IdentifiersShouldNotMatchKeywords)]
        public static class User
        {
            public static class ErrorMessages
            {
                public const string FailedToFetchUser = "TMC_Common_ErrorMessages_FailedToFetchUser";

            }
        }

    }
}