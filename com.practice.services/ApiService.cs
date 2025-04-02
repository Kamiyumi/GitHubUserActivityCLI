using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using GitHubUserActivityCLI.com.practice.models;

namespace GitHubUserActivityCLI.com.practice.services
{
    public class GithubApiService
    {
        private readonly HttpClient _httpClient;

        public GithubApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.github.com/");
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHubUserActivityCLI", "1.0")); // GitHub requires User-Agent
        }

        public async Task<List<GitHubActivity>?> GetUserEventsAsync(string username)
        {
            var response = await _httpClient.GetAsync($"users/{username}/events");

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error fetching events: {response.StatusCode}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<GitHubActivity>>(json, options);
        }
    }
}
