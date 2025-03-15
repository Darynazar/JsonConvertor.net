using Json.Models.NodeJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{

    public class UniqueTournament
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string PrimaryColorHex { get; set; }
        public string SecondaryColorHex { get; set; }
        public Category Category { get; set; }
        public int UserCount { get; set; }
        public bool HasPerformanceGraphFeature { get; set; }
        public int Id { get; set; }
        public Country Country { get; set; }
        public bool DisplayInverseHomeAwayTeams { get; set; }
        public FieldTranslations FieldTranslations { get; set; }
    }
}
