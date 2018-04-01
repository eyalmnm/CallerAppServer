using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CallerAppServer.Models;
using CallerAppServer.Utils;

// Ref: https://stackoverflow.com/questions/9017498/calculating-how-many-minutes-there-are-between-two-times

namespace CallerAppServer.Managers
{
    public class SmsRequestsManager
    {
        private static int MINIMUM_MINUTES_BETWEEN_SMS = 1;   // In Minutes

        // Request Temporary storage.
        private static Dictionary<String, RequestData> requests = new Dictionary<string, RequestData>();


        /*
         * Check if the given phone number is free to get sms
         */ 
        public static bool CanSendRequest(String phoneNumber)
        {
            if (false == requests.ContainsKey(phoneNumber))
            {
                return true;
            } else
            {
                RequestData reqData = requests[phoneNumber];
                DateTime currentTime = new System.DateTime();
                TimeSpan span = currentTime.Subtract(reqData.getCreationTime());
                return (MINIMUM_MINUTES_BETWEEN_SMS < span.TotalMinutes) ? true : false;
            }
        }

        public static void AddRequest(String phoneNumber, String otp)
        {
            if(true == requests.ContainsKey(phoneNumber))
            {
                requests.Remove(phoneNumber);                         
            }
            requests[phoneNumber] = new RequestData(phoneNumber, otp);
        }

        public static bool RemoveRequest(String phoneNumber, String otp)
        {
            if ((false == StringUtils.IsNullOrEmpty(phoneNumber)) && (false == StringUtils.IsNullOrEmpty(otp))) {
                if (true == requests.ContainsKey(phoneNumber))
                {
                    RequestData request = requests[phoneNumber];
                    if (true == otp.Equals(request.getOtp()))
                    {
                        requests.Remove(phoneNumber);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}