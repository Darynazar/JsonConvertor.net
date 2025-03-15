using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class DetailedRecentForm
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public int CompetitionId { get; set; }
        public int SeasonNum { get; set; }
        public int StageNum { get; set; }
        public int RoundNum { get; set; }
        public string RoundName { get; set; }
        public string CompetitionDisplayName { get; set; }
        public DateTime StartTime { get; set; }
        public int StatusGroup { get; set; }
        public string StatusText { get; set; }
        public string ShortStatusText { get; set; }
        public int GameTimeAndStatusDisplayType { get; set; }
        public Competitor HomeCompetitor { get; set; }
        public Competitor AwayCompetitor { get; set; }
        public int Outcome { get; set; }
        public int Winner { get; set; }
        public List<double> Scores { get; set; }
        public int HomeAwayTeamOrder { get; set; }
        public bool HasPointByPoint { get; set; }
    }
}
