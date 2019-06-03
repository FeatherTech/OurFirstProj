using _3dcartToTpro.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _3dcartToTpro.Controllers
{
    [RoutePrefix("api/Checkout")]
    public class CheckoutController : ApiController
    {
        [Route("InitiateCheckout")]
        [HttpPost]
        public CheckoutResponse InitiateCheckout(CheckoutRequest Request)
        {
            CheckoutResponse response = new CheckoutResponse();

            // TODO - Logic to call TPro3 and get the response of it
            // create the responce to send to 3dcart with the responce recieved from TPro3
            
            #region Test Data
            #if DEBUG
            response = new CheckoutResponse
            {
                paymenttoken = "abc123xyz321",
                redirecturl = "https://www.someurlpointingtotheircheckoutpage.com/script.asp",
                errorcode = "abc123",
                errormessage = "error message",
                randomkey = "999azswed23xyz",
                redirectmethod = "GET",
                signature = "md5(randomkey + app_privatekey + paymenttoken + redirecturl)"
            };
            #endif
            #endregion

            return response;
        }

        [Route("InitiateRefund")]
        [HttpPost]
        public RefundResponse InitiateRefund(RefundRequest Request)
        {
            RefundResponse response = new RefundResponse();

            // TODO - Logic to call TPro3 and get the response of it
            // create the responce to send to 3dcart with the responce recieved from TPro3

            #region Test Data
            #if DEBUG
            response = new RefundResponse
            {
                approved = 1,
                transactionid = "abc12345",
                errorcode = "abc123",
                errormessage = "error message",
                randomkey = "999azswed23xyz",
                signature = "md5(randomkey + app_privatekey + orderid + invoice + transactionid)"
            };
            #endif
            #endregion

            return response;
        }

        [Route("IsAlive")]
        public string IsAlive()
        {
            return DateTime.Now.ToString();
        }
    }
}