using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMC.Shared;

namespace TMC.Web.Shared
{
    public static class GlobalConstants
    {
        public const string LoaderImagePath = "\\Content\\Images\\ajaxloader.gif";
        public const int HTTPPageNotFoundErrorCode = 404;

        public const string EmailRegularExpression = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        public const string ClientRoute = "ClientRoute";

        public const int SuperRoleRank = -1;
        public const int ValueNotPassedId = -1;
        public const int DefaultCreateId = -1;
        public const int NoOfDisplayItemsInDualList = 10;

        public const string RequestedWithKey = "X-Requested-With";
        public const string XmlHttpRequest = "XMLHttpRequest";
        public const string PasswordRegularExpression = @"^\S+$";

        /// <summary>
        /// Static class for database table columns releated constant
        /// </summary>
        public static class DBConstant
        {
            /// <summary>
            /// Constant for file table
            /// </summary>
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
            public static class Individual
            {
                /// <summary>
                /// first name max length
                /// </summary>
                public const int FirstNameMaxLength = 255;

                /// <summary>
                /// last name max length
                /// </summary>
                public const int LastNameMaxLength = 255;

                /// <summary>
                /// last name max length
                /// </summary>
                public const int EmailMaxLength = 255;
            }

            public static class User
            {
                /// <summary>
                /// The user name max length
                /// </summary>
                public const int UserNameMaxLength = 255;
            }

            public static class EmailNotification
            {
                /// <summary>
                /// The user name max length
                /// </summary>
                public const int SubjectMaxLength = 255;
                public const int MessageMaxlength = 1024;
            }


            /// <summary>
            /// Constant for BusinessLocation table
            /// </summary>
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
                /// City max length
                /// </summary>
                public const int CityMaxLength = 255;

                /// <summary>
                /// ZIP max length
                /// </summary>
                public const int ZIPMaxLength = 6;
            }

        }
    }
}