﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
    public class VerifyOtpCode : CallerAppBaseModel
    {
        private String Otp { get; set; }
        private String PhoneNumber { get; set; }
        private String DeviceId { get; set; }

        public VerifyOtpCode(String otp, String phoneNumber, String deviceId,
             String time_zone, String time_stamp, String phone_model,
            String phone_manufacturer, String version, String phone_type)
            : base(time_zone, time_stamp, phone_model, phone_manufacturer, version, phone_type)
        {
            this.Otp = otp;
            this.PhoneNumber = phoneNumber;
            this.DeviceId = deviceId;
        }

        public String getOtp()
        {
            return this.Otp;
        }

        public String getPhoneNumber()
        {
            return this.PhoneNumber;
        }

        public String getDeviceId()
        {
            return this.DeviceId;
        }
    }
}