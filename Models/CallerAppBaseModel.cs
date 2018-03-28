using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CallerAppServer.Models
{
    public class CallerAppBaseModel
    {
        private String TimeZone { get; set; }
        private String TimeStamp { get; set; }
        private String PhoneModel { get; set; }
        private String PhoneManufacturer { get; set; }
        private String Version { get; set; }
        private String PhoneType { get; set; }

        public CallerAppBaseModel(String time_zone, String time_stamp, String phone_model, 
            String phone_manufacturer, String version, String phone_type)
        {
            this.TimeZone = time_zone;
            this.TimeStamp = time_stamp;
            this.PhoneModel = phone_model;
            this.PhoneManufacturer = phone_manufacturer;
            this.PhoneType = phone_type;
            this.Version = version;
        }

    }
}