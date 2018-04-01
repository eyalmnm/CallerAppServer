using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
    // Ref: https://stackoverflow.com/questions/22208413/generate-random-6-digit-number

    public class RequestSmsVerification : CallerAppBaseModel
    {
        private String DeviceId { get; set; }
        private String PhoneNumber { get; set; }
        private String FullName { get; set; }

        public RequestSmsVerification(String deviceId, String phoneNumber, String fullName, 
            String time_zone, String time_stamp, String phone_model,
            String phone_manufacturer, String version, String phone_type) 
            : base (time_zone, time_stamp, phone_model, phone_manufacturer, version, phone_type)
        {
            this.DeviceId = deviceId;
            this.PhoneNumber = phoneNumber;
            this.FullName = fullName;
        }

        public String getDeviceId()
        {
            return this.DeviceId;
        }

        public String getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public String getFullName()
        {
            return this.FullName;
        }


        private String GeneratedOtp()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999).ToString("D6");
            return r;
        }
    }
}