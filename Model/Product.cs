using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceCloting.Model
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        [JsonPropertyName("discountPorcentage")]
        public decimal DiscountPorcentage { get; set; }
        [JsonPropertyName("rating")]
        public decimal Rating { get; set; }
        [JsonPropertyName("stock")]
        public int Stock { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("dimensions")]
        public Dimension Dimension { get; set; }
        [JsonPropertyName("warrantyInformation")]
        public string WarrantyInformation { get; set; }
        [JsonPropertyName("shippingInformation")]
        public string ShippingInformation { get; set; }
        [JsonPropertyName("availabilityStatus")]
        public string AvailabilityStatus { get; set; }
        [JsonPropertyName("reviews")]
        public List<Review> Reviews { get; set; }
        [JsonPropertyName("returnPolicy")]
        public string ReturnPolicy { get; set; }
        [JsonPropertyName("minimumOrderQuantity")]
        public int MinimumOrderQuantity { get; set; }
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }


    }
}
