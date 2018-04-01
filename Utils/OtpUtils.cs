using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Utils
{
    public class OtpUtils
    {
        public static String GenerateOtp()
        {
            Random generator = new Random();
            String otp = generator.Next(0, 999999).ToString("D6");
            return otp;
        }
    }
}