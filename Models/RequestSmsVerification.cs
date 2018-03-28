using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
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
    }
}