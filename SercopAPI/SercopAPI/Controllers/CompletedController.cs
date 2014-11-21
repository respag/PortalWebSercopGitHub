using InitiateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InitiateAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CompletedController : ApiController
    {
        private ULT_BPMEntities db = new ULT_BPMEntities();

        // GET: api/Inbox
        public IQueryable<vw_Completed> Getvw_Completed()
        {
            return db.vw_Completed;
        }

        // GET: api/Inbox/soce.int/alfresco
        public IQueryable<vw_Completed> Get(string domain, string user)
        {
            var fullUser = domain + "/" + user;
            return db.vw_Completed.Where(i => i.TASKUSER == fullUser);
        }
    }
}
