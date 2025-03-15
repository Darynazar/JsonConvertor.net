using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Competition
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool HasStandings { get; set; }
        public bool HasLiveStandings { get; set; }
        public bool HasStandingsGroups { get; set; }
        public bool HasBrackets { get; set; }
        public string NameForURL { get; set; }
        public int PopularityRank { get; set; }
        public int ImageVersion { get; set; }
        public int CurrentStageType { get; set; }
        public string Color { get; set; }
        public int CompetitorsType { get; set; }
        public int CurrentPhaseNum { get; set; }
        public List<Season> Seasons { get; set; }
        public int CurrentSeasonNum { get; set; }
        public int CurrentStageNum { get; set; }
        public bool HideOnCatalog { get; set; }
        public bool HideOnSearch { get; set; }
        public bool IsInternational { get; set; }
    }
}
