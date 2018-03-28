using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
    public class VerifyOtpCode : CallerAppBaseModel
    {
        private String Opt { get; set; }
        private String PhoneNumber { get; set; }
        private String DeviceId { get; set; }

        public VerifyOtpCode(String otp, String phoneNumber, String deviceId,
             String time_zone, String time_stamp, String phone_model,
            String phone_manufacturer, String version, String phone_type)
            : base(time_zone, time_stamp, phone_model, phone_manufacturer, version, phone_type)
        {
            this.Opt = otp;
            this.PhoneNumber = phoneNumber;
            this.DeviceId = deviceId;
        }
    }
}