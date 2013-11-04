using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceInterface;

namespace AngularJS_ServiceStack_Starter.Core
{
    public class AnnouncementsService : Service
    {
        public string[] Get(GetAnnouncementsRequest request)
        {
            return new[]
            {
                "Server-side Announcement1",
                "Server-side Announcement2"
            };
        }
    }
}
