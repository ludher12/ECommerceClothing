using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceCloting.Model
{
    public class Dimension
    {
        [JsonPropertyName("width")]
        public decimal Width { get; set; }
        [JsonPropertyName("height")]
        public decimal Height { get; set; }
        [JsonPropertyName("depth")]
        public decimal Depth { get; set; }
    }
}
