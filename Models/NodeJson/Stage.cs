using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Stage
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public bool UseName { get; set; }
        public bool HasStandings { get; set; }
        public bool IsFinal { get; set; }
        public int StageType { get; set; }
    }
}
