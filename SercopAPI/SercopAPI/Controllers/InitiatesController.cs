using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Ultimus.WFServer;

namespace InitiateAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InitiatesController : ApiController
    {

        public string GetTaskInitiate(string dominio, string userName)
        {
            var tareas = "";
            string strErr = string.Empty;
            Tasklist oTl = new Tasklist();
            string[] usr = new string[] {dominio +"/" + userName };
            TasklistFilter oTlF = new TasklistFilter();


            oTlF.strArrUserName = usr;
            oTlF.nFiltersMask = Filters.nFilter_Initiate; 
            bool flag = oTl.LoadFilteredTasks(oTlF, out strErr);
            if (flag)
            {
               tareas = "[{ \"InitiateId\" : " + "\"" + (oTl.GetFirstTask()).strTaskId +
                    "\", \"NombreProceso\" : " + "\"" + (oTl.GetFirstTask()).strProcessName +
                    "\", \"VersionProceso\" : " + +(oTl.GetFirstTask()).nProcessVersion +
                    ", \"NombreTarea\" : " + "\"" + (oTl.GetFirstTask()).strStepName +
                     "\", \"Usuario\" : " + "\"" + (oTl.GetFirstTask()).strUser +
                     "\", \"Url\" : " + "\"" + (oTl.GetFirstTask()).strFormUrl +
                    "\"}";
                var cuenta = oTl.GetTasksCount();
                for (int i = 1; i < cuenta; i++)
                {

                    tareas += ",{ \"InitiateId\" : " + "\"" + (oTl.GetAt(i)).strTaskId +
                    "\", \"NombreProceso\" : " + "\"" + (oTl.GetAt(i)).strProcessName +
                    "\", \"VersionProceso\" : " + +(oTl.GetAt(i)).nProcessVersion +
                    ", \"NombreTarea\" : " + "\"" + (oTl.GetAt(i)).strStepName +
                     "\", \"Usuario\" : " + "\"" + (oTl.GetAt(i)).strUser +
                     "\", \"Url\" : " + "\"" + (oTl.GetAt(i)).strFormUrl +
                    "\"}";
                }
                return tareas + "]";
            }
            else
                return "";
        }

        [HttpGet]
        // GET: api/Initiates
        public string Get(string domain, string user)
        {
            return GetTaskInitiate(domain, user);
        }

        // GET: api/Initiates/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Initiates
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Initiates/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Initiates/5
        public void Delete(int id)
        {
        }
    }
}
