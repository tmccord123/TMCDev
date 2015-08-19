using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace TMC.Shared
{
    public static class ValidationConstants
    {
        public const string EmailRegexJS =
            @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

        public const string BookmarkPrefixRegex = @"^bk\S*$";
        public const decimal MaximumLatitudeValue = 90;
        public const decimal MinimumLatitudeValue = -90;
        public const decimal MaximumLongitudeValue = 180;
        public const decimal MinimumLongitudeValue = -180;
        public const int DefaultValueForNullableFields = -1;

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class FieldSize
        {
            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class EplansSchema
            {
                public const int TextBoxMinLength = 0;
                public const int SmallTextBoxMaxLength = 20;
                public const int MediumTextBoxMaxLength = 50;
                public const int MediumTextBoxMaxLength100 = 100;
                public const int LargeTextBoxMaxLength = 255;
                public const int DescriptionFieldMaxLength = 1055;
            }

            [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
            public static class JCCSemsSchema
            {
                public const int TextBoxMinLength = 0;
                public const int InputFieldMaxLength = 200;
                public const int NumberCustomTextFieldMaxLength = 16;
                public const int DataEntryInputFieldMaxLength = 4000;
                public const int NameFieldMaxLength = 128;
                public const int DescriptionFieldMaxLength = 1024;
                public const int RoleNameMaxLength = 50;
                public const int RoleDescriptionMaxLength = 1024;
                public const int JobTitleMaxLength = 255;
                public const int TrainingCertificateMaxLength = 100;
                public const int EmployeeTrainingCertificateNotesMaxLength = 1024;

            }
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class Password
        {
            public const int OldPasswordMinLength = 1;
            public const int PasswordMinLength = 8;
            public const int PasswordMaxLength = 50;
        }

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class OrganizationLocation
        {
            public const int InputFieldMaxLength = 255;
        }
    }
}