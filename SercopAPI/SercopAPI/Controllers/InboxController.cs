using InitiateAPI.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InitiateAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InboxController : ApiController
    {
        private ULT_BPMEntities db = new ULT_BPMEntities();

        // GET: api/Inbox
        public IQueryable<vw_Inbox> Getvw_Inbox()
        {
            return db.vw_Inbox;
        }

        // GET: api/Inbox/soce.int/alfresco
        public IQueryable<vw_Inbox> Get(string domain, string user)
        {
            var fullUser = domain + "/" + user;
            return db.vw_Inbox.Where(i => i.TASKUSER == fullUser);
        }
    }
}