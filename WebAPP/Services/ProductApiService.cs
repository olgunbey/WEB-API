

using WebAPP.Models;

namespace WebAPP.Services
{
    public class ProductApiService
    {
        public HttpClient HttpClient { get; set; }
        public ProductApiService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task<List<Product>> Apis()
        {
           return await HttpClient.GetFromJsonAsync<List<Product>>("Product/ProductListele");
         
        }
    }
}
