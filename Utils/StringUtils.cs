﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Utils
{
    public class StringUtils
    {
        /*
         * Check whether the given string is null or empty.
         */ 
        public static bool IsNullOrEmpty(String str)
        {
            if (null == str) return true;
            if (0 == str.Trim().Length) return true;
            String stri = str.Replace("?", "").Replace("<", "").Replace(">", "").Replace("&", "")
                .Replace("\"", "").Replace("\'", "").Replace(";", "").Replace("\n", "").Replace("\r", "")
                .Replace("\t", "").Trim();
            if (0 == stri.Length) return true;
            return false;
        }
    }
}