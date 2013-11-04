using System;
using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace AngularJS_ServiceStack_Starter.Core
{
    [Route("/announcements", "GET")]
    public class GetAnnouncementsRequest: IReturn<List<string>>
    {
    }
}