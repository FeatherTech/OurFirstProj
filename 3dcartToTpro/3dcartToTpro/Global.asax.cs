﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Mvc;
using _3dcartToTpro.MessageHandler;

namespace _3dcartToTpro
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configuration.MessageHandlers.Add(new APIKeyMessageHandler());
            GlobalConfiguration.Configure(WebApiConfig.Register);            
        }
    }
}
