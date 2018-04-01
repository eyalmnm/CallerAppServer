using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.MyConfig
{
    public static class ErrorsCode
    {
        // User 1000 - 1099
        public const int USER_NOT_FOUND = 1000;
        public const int USER_NOT_LOGGED_IN = 1001;

        // Registration 1100 - 1199
        public const int PREVIUOS_REQUEST_VALID = 1100;
        public const int PREVIUOS_REQUEST_EXPIRED = 1101;
    }
}