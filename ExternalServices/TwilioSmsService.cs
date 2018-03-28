using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace CallerAppServer.ExternalServices
{
    public class TwilioSmsService
    {
        public static void sendOtpTo(String phoneNumber, String otp)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            const string authToken = "your_auth_token";
            const string myPhone = "+15_my_phone_number";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber(phoneNumber);
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber(myPhone),
                body: "callerAppOtp:" + otp);

            Console.WriteLine(message.Sid);
        }
    }
}