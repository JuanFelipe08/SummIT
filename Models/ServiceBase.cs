using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSummit.Models
{
    public class ServiceBase
    {
        public enum ServiceState { Accepted, Rejected, Aborted }
        public static Dictionary<string, int> Dictionary = new Dictionary<string, int>();
    }
}
