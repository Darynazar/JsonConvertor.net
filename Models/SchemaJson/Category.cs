using Json.Models.NodeJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{

    public class Category
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public Sport Sport { get; set; }
        public string Flag { get; set; }
        public string Alpha2 { get; set; }
        public FieldTranslations FieldTranslations { get; set; }
    }
}
