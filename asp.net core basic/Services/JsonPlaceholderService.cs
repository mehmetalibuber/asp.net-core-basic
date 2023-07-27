using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using asp.net_core_basic.Models;

namespace asp.net_core_basic.Services
{
    public class JsonPlaceholderService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://jsonplaceholder.typicode.com";

        public JsonPlaceholderService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Post>> GetPosts()
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}/posts");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Post>>(content);
            }
            return null;
        }
    }


}