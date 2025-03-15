using Json.Models.NodeJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{

    public class Team
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string ShortName { get; set; }
        public string Gender { get; set; }
        public Sport Sport { get; set; }
        public int UserCount { get; set; }
        public string NameCode { get; set; }
        public bool Disabled { get; set; }
        public bool National { get; set; }
        public int Type { get; set; }
        public int Id { get; set; }
        public Country Country { get; set; }
        public string EntityType { get; set; }
        public TeamColors TeamColors { get; set; }
        public FieldTranslations FieldTranslations { get; set; }
    }
}
