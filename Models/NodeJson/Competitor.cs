﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Competitor
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public string SymbolicName { get; set; }
        public string NameForURL { get; set; }
        public int Type { get; set; }
        public int PopularityRank { get; set; }
        public int ImageVersion { get; set; }
        public string Color { get; set; }
        public string AwayColor { get; set; }
        public int MainCompetitionId { get; set; }
        public bool HasSquad { get; set; }
        public bool HasTransfers { get; set; }
        public int CompetitorNum { get; set; }
        public bool HideOnSearch { get; set; }
        public bool HideOnCatalog { get; set; }
    }
}
