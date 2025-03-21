using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceCloting.Model
{
    public class Meta
    {
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }
        [JsonPropertyName("qrCode")]
        public string QrCode { get; set; }
    }
}
