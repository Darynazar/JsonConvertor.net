using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class NodeJson
    {
        public long LastUpdateId { get; set; }
        public long RequestedUpdateId { get; set; }
        public int Ttl { get; set; }
        public List<Standing> Standings { get; set; }
        public List<Sport> Sports { get; set; }
        public List<Country> Countries { get; set; }
        public List<Competition> Competitions { get; set; }
        public List<object> Bookmakers { get; set; }
    }
}
