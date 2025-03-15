using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{

    public class RowSchema
    {
        public Team Team { get; set; }
        public List<object> Descriptions { get; set; }
        public Promotion Promotion { get; set; }
        public int Position { get; set; }
        public int Matches { get; set; }
        public int Wins { get; set; }
        public int ScoresFor { get; set; }
        public int ScoresAgainst { get; set; }
        public int Id { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Points { get; set; }
        public string ScoreDiffFormatted { get; set; }
    }
}
