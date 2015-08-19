using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Shared
{
    /// <summary>
    /// Contains rule set validator constants.    
    /// Author: Nagarro
    /// </summary>
    public static class RuleSetConstants
    {
        /// <summary>
        /// Contains rule set validator constants for User validator
        /// </summary>   
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class UserValidator
        {
            public const string InvalidUser = "InvalidUser";
            public const string CheckLockedIndicator = "CheckLockedIndicator";
            public const string ValidUser = "ValidUser";
            public const string CreateUser = "CreateUser";
        }

        /// <summary>
        /// Contains rule set validator constants for individual validator.
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class IndividualValidator
        {
            /// <summary>
            /// Validation rule Primary contact exist.
            /// </summary>
            public const string PrimaryContactExist = "PrimaryContactExist";

            /// <summary>
            /// Validation rule primary email.
            /// </summary>
            public const string PrimaryEmail = "PrimaryEmail";

            /// <summary>
            /// Validation rule Cannot Delete Primary Contact.
            /// </summary>
            public const string CanDeletePrimaryContact = "CanDeletePrimaryContact";

            /// <summary>
            /// Validation rule can delete relationship manager.
            /// </summary>
            public const string CanDeleteRelationshipManager = "CanDeleteRelationshipManager";

            /// <summary>
            /// The can remove primary relationship manager while updating.
            /// </summary>
            public const string CanRemovePrimaryRelationshipManagerWhileUpdating = "CanRemovePrimaryRelationshipManagerWhileUpdating";
            

        }
    }
}