using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Shared
{
    public static class UserAuthorization
    {
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class Roles
        {
            public const string SystemAdmin = "SystemAdmin";
            public const string SiteAdmin = "SiteAdmin";
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static class Feature
        {
            [SuppressMessage(SuppressMessageConstants.DesignCategory,
                SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.TypeNamesShouldNotMatchNamespaces)]
            public static class Security
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class User
                {
                    public const string View = "UsersView";
                    public const string Edit = "UsersEdit";
                    public const string Add = "UsersAdd";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class Role
                {
                    public const string View = "RolesView";
                    public const string Edit = "RolesEdit";
                    public const string Add = "RolesAdd";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class ClientUser
                {
                    public const string View = "ClientUsersView";
                    public const string Edit = "ClientUsersEdit";
                    public const string Add = "ClientUsersAdd";
                }               
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory,
               SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.TypeNamesShouldNotMatchNamespaces)]
            public static class Training
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class EmployeeTraining
                {
                    public const string View = "EmployeeTrainingView";
                    public const string Edit = "EmployeeTrainingEdit";
                    public const string Add = "EmployeeTrainingAdd";
                    public const string FullAccess = "EmployeeTrainingAffiliateFullAccess";
                }

             
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory,
              SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.TypeNamesShouldNotMatchNamespaces)]
            public static class Affiliation
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class CompanyAffiliation
                {
                    public const string View = "CompanyAffiliationView";
                    public const string Edit = "CompanyAffiliationEdit";
                    public const string Add = "CompanyAffiliationAdd";
                    public const string ReviewAffiliation = "CompanyAffiliationReviewAffiliation";
                    public const string AddSubscription = "CompanyAffiliationAddSubscription";
                }
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory,
              SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory,
                SuppressMessageConstants.TypeNamesShouldNotMatchNamespaces)]
            public static class AdminTasks
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class SubscriptionRequests
                {
                    public const string View = "SubscriptionRequestsView";
                    public const string Edit = "SubscriptionRequestsEdit";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                    SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class NewCompanyVerification
                {
                    public const string View = "NewCompanyVerificationView";
                    public const string Edit = "NewCompanyVerificationEdit";
                }

                [SuppressMessage(SuppressMessageConstants.DesignCategory,
                   SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class MergePOBReports
                {
                    public const string View = "MergePOBRecordsView";
                    public const string Edit = "MergePOBRecordsEdit";
                }

            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            [SuppressMessage(SuppressMessageConstants.NamingCategory, SuppressMessageConstants.TypeNamesShouldNotMatchNamespaces)]
            public static class Equipment
            {
                [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
                public static class EquipmentProfile
                {
                    public const string View = "EquipmentProfileView";
                    public const string Edit = "EquipmentProfileEdit";
                    public const string Add = "EquipmentProfileAdd";
                }
            }
        }
    }
}