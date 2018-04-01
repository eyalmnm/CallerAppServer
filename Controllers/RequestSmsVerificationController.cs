using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CallerAppServer.ExternalServices;
using CallerAppServer.Models;
using CallerAppServer.Managers;
using CallerAppServer.Utils;
using CallerAppServer.MyConfig;


// Ref: https://stackoverflow.com/questions/22208413/generate-random-6-digit-number

namespace CallerAppServer.Controllers
{
    public class RequestSmsVerificationController : ApiController
    {
        // GET: api/RequestSmsVerification
        public String Get()
        {
            return "value1";
        }

        // POST: api/RequestSmsVerification
        public IHttpActionResult Post(RequestSmsVerification requestSmsVerification)
        {
            Dictionary<String, object> response = new Dictionary<String, object>();

            String phoneNamber = requestSmsVerification.getPhoneNumber();
            if (true == SmsRequestsManager.CanSendRequest(phoneNamber))
            {
                // Generate Otp
                String otp = OtpUtils.GenerateOtp();
                // Add to SMS Requests Manager
                SmsRequestsManager.AddRequest(phoneNamber, otp);
                // Send SMS
                TwilioSmsService.sendOtpTo(phoneNamber, otp);

                // Generate Response               
                response.Add("PhoneNumber", phoneNamber);
            } else
            {
                // Generate Response               
                response.Add("error", ErrorsCode.PREVIUOS_REQUEST_VALID);                
            }
            // Send respons
            return Ok(JsonUtils.toJsonStr(response));
        }
    }
}
