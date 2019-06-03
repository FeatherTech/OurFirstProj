using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using System.Configuration;

namespace _3dcartToTpro.MessageHandler
{
    public class APIKeyMessageHandler : DelegatingHandler
    {
        /// <summary>
        /// Hard coded it here, however, we think it will be 
        /// different for different Merchants and will be 
        /// managed via storing this key in DB for the merchant
        /// </summary>
        private string _APIKeyToCheck = ConfigurationManager.AppSettings[Constants.ApiKey];

        /// <summary>
        /// Cross cutting message handler to check the APIKey sent in
        /// the request.
        /// </summary>
        /// <returns>Returns respose to the caller or passes the control to controller methods beign called</returns>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken token)
        {
            bool validKey = false;
            IEnumerable<string> requestHeaders;
            HttpResponseMessage response;
            
            // find the Api Key presence in the Request headers
            var checkApiKeyExists = request.Headers.TryGetValues(Constants.ApiKey, out requestHeaders);
            // check if Api Key is present in the Request headers
            if (checkApiKeyExists)
            {
                // if the api key is present and matches the ApiKey, validate the request
                if (requestHeaders.FirstOrDefault().Equals(_APIKeyToCheck))
                {
                    validKey = true;
                }
            }

            response = new HttpResponseMessage();
            if (!validKey)
                response = request.CreateResponse(HttpStatusCode.Forbidden, Constants.InvalidApiKey);
            else
                response = await base.SendAsync(request, token);

            return response;
        }
    }
}