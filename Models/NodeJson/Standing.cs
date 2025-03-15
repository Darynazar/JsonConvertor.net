using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Standing
    {
        public int CompetitionId { get; set; }
        public int SeasonNum { get; set; }
        public int StageNum { get; set; }
        public bool IsCurrentStage { get; set; }
        public string DisplayName { get; set; }
        public int CurrentGroupCategory { get; set; }
        public List<Header> Headers { get; set; }
        public List<Row> Rows { get; set; }
        public List<Destination> Destinations { get; set; }
        public List<FilterType> FilterTypes { get; set; }
    }
}
