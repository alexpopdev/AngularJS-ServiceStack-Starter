using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ServiceStack.ServiceInterface;

namespace AngularJS_ServiceStack_Starter.Core
{
    public class AnnouncementsService : Service
    {
        public List<Announcement> Get(GetAnnouncementsRequest request)
        {
            Thread.Sleep(2000);
            return new List<Announcement>
            {
               new Announcement{
                   Id = 1, 
                   Content="Server-side Announcement1"
               },
               new Announcement{
                   Id = 2,
                Content = "Server-side Announcement2"
               }
            };
        }
    }
}
