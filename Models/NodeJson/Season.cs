using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Season
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public bool UseName { get; set; }
        public int CompetitionId { get; set; }
        public bool HasStandings { get; set; }
        public List<Stage> Stages { get; set; }
    }
}
