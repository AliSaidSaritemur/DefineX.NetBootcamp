using AjaxOdev.Models;
using System.Text.Json;
using System.Text;
using Bogus;

namespace AjaxOdev.Services
{
    public class UserProduceService : IMockDataUgretilebilir
    {
        private readonly HttpClient _httpClient;

        public UserProduceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<bool> MockDataUretAsync()
        {
            User fakeUser = new Faker<User>()
            .RuleFor(u => u.Id, f => f.Random.Int(1, 1000))
            .RuleFor(u => u.Name, f => f.Name.FirstName())
            .RuleFor(u => u.Surname, f => f.Name.LastName());
            var userJson = JsonSerializer.Serialize(fakeUser);
            var content = new StringContent(userJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7069/Users/Create", content);

            return response.IsSuccessStatusCode;
        }

        public void MockDataUretAsync(int miktar = 1)
        {
            for (int i = 0; i < miktar; i++)
            {
                MockDataUretAsync();
            }
        }
    }
}
