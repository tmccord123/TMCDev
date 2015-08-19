using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using TMC.Shared;

namespace TMC.Shared
{
    public static class GlobalConstants
    {
        public const string LoaderImagePath = "\\Content\\Images\\ajaxloader.gif";
        public const string DateFormatMMddyyyy = "MM/dd/yyyy";

        public const int HTTPPageNotFoundErrorCode = 404;


        public const string EmailRegularExpression = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        public const string ClientRoute = "ClientRoute";

        public const int SuperRoleRank = -1;
        public const int ValueNotPassedId = -1;
        public const int DefaultCreateId = -1;
        public const int NoOfDisplayItemsInDualList = 10;
        public const int OtherFrequencyIntValue = -999;
        public const int DefaultIntValue = default(int);



        public const string RequestedWithKey = "X-Requested-With";
        public const string XmlHttpRequest = "XMLHttpRequest";
        public const string PasswordRegularExpression = @"^\S+$";
        public const string ZIPRegularExpression = @"^\d+$";

        public const int YearStartFrom = 1901;
        public const int MonthStartFrom = 1;
        public const int MonthEndTo = 12;
        public const int DayStartFrom = 1;
        public const int DayEndTo = 31;

        public const string PdfMimeType = "application/pdf";

        /// <summary>
        /// The Image Output Cache duration default is 30 minutes
        /// </summary>
        public const int ImageOutputCacheDuration = 1800;

        /// <summary>
        /// Static class for database table columns releated constant
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class DBConstant
        {
            /// <summary>
            /// Constant for file table
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class File
            {
                /// <summary>
                /// file title max length
                /// </summary>
                public const int FileTitleMaxLength = 255;

                /// <summary>
                /// file description max length
                /// </summary>
                public const int FileDescriptionMaxLength = 1024;
            }

            /// <summary>
            /// Constant for file table
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class Individual
            {
                /// <summary>
                /// first name max length
                /// </summary>
                public const int FirstNameMaxLength = 100;

                /// <summary>
                /// last name max length
                /// </summary>
                public const int LastNameMaxLength = 100;

                /// <summary>
                /// last name max length
                /// </summary>
                public const int EmailMaxLength = 100;

                /// <summary>
                /// job title max length
                /// </summary>
                public const int JobTitle = 100;

                /// <summary>
                /// office direct line max length
                /// </summary>
                public const int OfficeDirectLine = 50;


                /// <summary>
                /// cellular phone max length
                /// </summary>
                public const int CellularPhone = 50;
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class User
            {
                /// <summary>
                /// The user name max length
                /// </summary>
                public const int UserNameMaxLength = 100;
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class EmailNotification
            {
                public const int SubjectMaxLength = 255;
                public const int MessageMaxlength = 1024;
            }

            /// <summary>
            /// Constant for BusinessLocation table
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class OrganizationLocation
            {
                /// <summary>
                /// Name max length
                /// </summary>
                public const int NameMaxLength = 255;

                /// <summary>
                /// address1 max length
                /// </summary>
                public const int Address1NameMaxLength = 255;

                /// <summary>
                /// address1 max length
                /// </summary>
                public const int Address2NameMaxLength = 255;

                /// <summary>
                /// City max length
                /// </summary>
                public const int CityMaxLength = 255;

                /// <summary>
                /// ZIP max length
                /// </summary>
                public const int ZIPMaxLength = 6;

                /// <summary>
                /// MainPhone Max Length
                /// </summary>
                public const int MainPhoneMaxLength = 50;

                /// <summary>
                /// Fax  max length
                /// </summary>
                public const int FaxMaxLength = 50;
            }

            /// <summary>
            /// Constant for training
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class Training
            {
                /// <summary>
                /// Certificate Frequency Month Min value
                /// </summary>
                public const int CertificateFrequencyMonthMinValue = 1;

                /// <summary>
                /// Certificate Frequency Month Min value
                /// </summary>
                public const int CertificateFrequencyMonthMaxValue = 1200;

            }

            /// <summary>
            /// Class Affiliation.
            /// </summary>
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class Affiliation
            {
                /// <summary>
                /// The company name
                /// </summary>
                public const int CompanyName = 255;
            }
        }
    }
}