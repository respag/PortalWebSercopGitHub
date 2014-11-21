using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using InitiateAPI.Models;
using System.Web.Http.Cors;

namespace InitiateAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CompletedProveedoresController : ApiController
    {
        private ULT_BPMEntities db = new ULT_BPMEntities();

        // GET: api/vw_CompletedProveedores
        //public IQueryable<vw_CompletedProveedores> Getvw_CompletedProveedores()
        //{
        //    return db.vw_CompletedProveedores;
        //}

        // GET: api/InboxProveedores/usuarioProveedor
        public IQueryable<vw_CompletedProveedores> Get(string user)
        {
            return db.vw_CompletedProveedores.Where(i => i.TASKUSER == user);
        }
    }
}