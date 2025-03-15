using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.Models.SchemaJson
{
    public class StandingSchema
    {
        public Tournament Tournament { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<object> Descriptions { get; set; }
        public TieBreakingRule TieBreakingRule { get; set; }
        public List<RowSchema> Rows { get; set; }
        public int Id { get; set; }
        public long UpdatedAtTimestamp { get; set; }
    }
}
