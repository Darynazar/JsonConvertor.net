using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.NodeJson
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameForURL { get; set; }
        public List<int> SportTypes { get; set; }
        public int ImageVersion { get; set; }
        public bool IsInternational { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string Slug { get; set; }
    }
}
