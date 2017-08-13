using Newtonsoft.Json;
using SmartphoneStoreMobile.Models;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartphoneStoreMobile.Services
{
    class ProductService
    {
        private const string URL = "http://192.168.0.104:3000/api/";
        public async Task<ObservableCollection<Product>> GetProducts()
        {
            ObservableCollection<Product> products;
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(URL + "Products");
                products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(await response.Content.ReadAsStringAsync());
            }
            return products;
        } 
    }
}
