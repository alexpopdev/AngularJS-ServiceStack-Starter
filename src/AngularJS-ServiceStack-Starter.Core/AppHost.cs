using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Funq;
using ServiceStack;
using ServiceStack.Common.Web;
using ServiceStack.ServiceInterface.Cors;
using ServiceStack.Text;
using ServiceStack.WebHost.Endpoints;

namespace AngularJS_ServiceStack_Starter.Core
{
    public abstract class AppHost : AppHostHttpListenerBase
    {
        internal static string TestUserName;

        protected AppHost(string serviceName, params Assembly[] assembliesWithServices)
            : base(serviceName, assembliesWithServices)
        {
        }

        public AppHost()
            : this("AngularJS ServiceStack Starter", typeof(AppHost).Assembly)
        {

        }

        public override void Configure(Funq.Container container)
        {
            SetConfig(CreateEndpointHostConfig());

            Plugins.Add(new CorsFeature()); //Registers global CORS Headers

            JsConfig.EmitCamelCaseNames = true;
            JsConfig.DateHandler = JsonDateHandler.ISO8601;

            // we assume that the container is already initialised at this point
            RegisterDependencies(container);

            ConfigureFiltersAndEventHandlers();
        }

        private void RegisterDependencies(Container container)
        {
        }

        private void ConfigureFiltersAndEventHandlers()
        {
            RequestFilters.Add((httpReq, httpRes, requestDto) =>
            {
                //Handles Request and closes Responses after emitting global HTTP Headers
                if (httpReq.HttpMethod == "OPTIONS" || httpReq.PathInfo.ToLowerInvariant() == "/requestlogs")
                {
                    
                    httpRes.EndRequest();
                    return;
                }


                if (HttpContext.Current == null || HttpContext.Current.User == null ||
                    !HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    throw new Exception("The user is not authenticated.");
                }
            });
          

            
        }
        

        protected virtual EndpointHostConfig CreateEndpointHostConfig()
        {
            return new EndpointHostConfig
            {
                DebugMode = true,
                DefaultContentType = ContentType.Json,
                ServiceStackHandlerFactoryPath = "api"
            };
        }
    }
}

