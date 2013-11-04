using AngularJS_ServiceStack_Starter.Core;
using ServiceStack.Logging;
using ServiceStack.WebHost.Endpoints;

namespace AngularJS_ServiceStack_Starter.Web
{
    public class WebAppHost : AppHost
    {
        protected override EndpointHostConfig CreateEndpointHostConfig()
        {
            EndpointHostConfig endpointHostConfig = base.CreateEndpointHostConfig();
            endpointHostConfig.LogFactory = LogManager.LogFactory;

            return endpointHostConfig;
        }
    }
}