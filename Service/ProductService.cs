using ECommerceCloting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceCloting.Service
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;
        private const string _baseUrl = "https://dummyjson.com/products/category/womens-dresses";
        public ProductService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<ProductResponse>(content).Products;
            }
            return new List<Product>();
        }


    }
    public class ProductResponse
    {
        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }
    }
}
