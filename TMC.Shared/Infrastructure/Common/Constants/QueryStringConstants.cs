using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    public static class QueryStringConstants
    {
        public const string QueryStringStartDelimitter = "?";

        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)]
        public static class Keys
        {
            public const string AppId = "AppId";
            public const string UserName = "UserName";
            public const string RememberMe = "RememberMe";
            public const string SecurityStamp = "SecurityStamp";
            public const string LoginSuccessHandler = "LoginSuccessHandler";
            public const string LoginFailureHandler = "LoginFailureHandler";
            public const string LogoutHandler = "LogoutHandler";
            public const string ReturnUrl = "ReturnUrl";
        }
    }
}
