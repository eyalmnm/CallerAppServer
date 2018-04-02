using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Ref: https://stackoverflow.com/questions/22208413/generate-random-6-digit-number

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