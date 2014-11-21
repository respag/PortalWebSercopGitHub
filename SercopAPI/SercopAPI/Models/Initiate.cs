using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitiateAPI.Models
{
    public class Initiate
    {
        public string InitiateId { get; set; }
        public string NombreProceso { get; set; }
        public int VersionProceso { get; set; }
        public string NombreTarea { get; set; }
        public string  Usuario { get; set; }
    }
}