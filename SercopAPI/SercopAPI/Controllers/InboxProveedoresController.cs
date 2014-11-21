using InitiateAPI.Models;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InitiateAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InboxProveedoresController : ApiController
    {
        private ULT_BPMEntities db = new ULT_BPMEntities();

        // GET: api/InboxProveedores
        public IQueryable<vw_InboxProveedores> Getvw_Inbox()
        {
            return db.vw_InboxProveedores;
        }

        // GET: api/InboxProveedores/usuarioProveedor
        public IQueryable<vw_InboxProveedores> Get(string user)
        {
            return db.vw_InboxProveedores.Where(i => i.TASKUSER == user);
        }
    }
}