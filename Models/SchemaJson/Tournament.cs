using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{

    public class Tournament
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public Category Category { get; set; }
        public UniqueTournament UniqueTournament { get; set; }
        public int Priority { get; set; }
        public bool IsGroup { get; set; }
        public bool IsLive { get; set; }
        public int Id { get; set; }
        public FieldTranslations FieldTranslations { get; set; }
    }
}
