using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceCloting.Model
{
    public class Review
    {
        [JsonPropertyName("rating")]
        public int Rating { get; set; }
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("reviewerName")]
        public string ReviewerName { get; set; }
        [JsonPropertyName("reviewerEmail")]
        public string ReviewerEmail { get; set; }

    }
}
