using ECommerceCloting.Model;
using ECommerceCloting.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCloting.ViewModel
{
    public class ProductMainViewModel
    {
        private readonly ProductService _productService;
        public ObservableCollection<Product> Products { get; set; }

        public Command LoadProductsCommand { get; set; }

        public ProductMainViewModel(ProductService productService)
        {
            _productService = productService;
            Products = new ObservableCollection<Product>();
            LoadProductsCommand = new Command(async () => await LoadProducts());
        }

        public async Task LoadProducts()
        {
            var products = await _productService.GetProducts();
            foreach (var product in products)
            {
                Products.Add(product);
            }
            
        }
    }
}
