using APILibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.API
{
    public class APIHelper : IAPIHelper
    {
        static private HttpClient _apiClient;
        public APIHelper()
        {
            IntializeClient();
        }

        private void IntializeClient()
        {
            // Need to fix this to get string from appsettings.Json if no
            // work around was usinig a Web.Config and renaming to App.Config for website
            string api = ConfigurationManager.AppSettings.Get("apiAddress");
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        public HttpClient ApiClient
        {
            get { return _apiClient; }
        }

        public async Task<List<User>> GetUsers()
        {
            var response = await _apiClient.GetStringAsync("Users");
            var data = JsonConvert.DeserializeObject<List<User>>(response);
            return data;
        }

        public async Task<User> GetUser(int id)
        {
            var response = await _apiClient.GetStringAsync($"Users/{id}");
            var data = JsonConvert.DeserializeObject<User>(response);
            return data;
        }

        public async Task InsertUser(User user)
        {
            HttpResponseMessage response = await _apiClient.PostAsJsonAsync($"Users/", user);
            response.EnsureSuccessStatusCode();
        }

        public async Task<User> UpdateUser(User user)
        {
            HttpResponseMessage Response = await _apiClient.PutAsJsonAsync($"Users/", user);
            Response.EnsureSuccessStatusCode();
            return user;
        }

        public async Task DeleteUser(int id)
        {
            await _apiClient.DeleteAsync($"Users/{id}");
        }

    }
}
