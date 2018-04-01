using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
    public class RequestData
    {
        private String PhoneNumber { get; set; }
        private DateTime CreationTime { get; set; }
        private String Otp { get; set; }

        public RequestData(String phoneNumber, String otp)
        {
            this.PhoneNumber = phoneNumber;
            this.CreationTime = new System.DateTime();
            this.Otp = otp;
        }

        public String getPhoneNuber()
        {
            return PhoneNumber;
        }

        public DateTime getCreationTime()
        {
            return CreationTime;
        }

        public String getOtp()
        {
            return Otp;
        }
    }
}