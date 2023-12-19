using Blazored.LocalStorage;
using System.Net.Http;

namespace Handball_Shopv1.Client.Services.Statistics_Service
{
    public class Stats_Service : IStats_Service
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly HttpClient _httpClient;
        public Stats_Service(ILocalStorageService localStorageService, HttpClient httpClient)
        {
            _localStorageService = localStorageService;

            _httpClient = httpClient;
        }
        public async Task GetVisits()
        {
            int visits = int.Parse(await _httpClient.GetStringAsync("api/Statistics"));
        }

        public async Task IncrementVisits()
        {
            DateTime? LastUserVisit = await _localStorageService.GetItemAsync<DateTime?>("LastUserVisit");
            if (LastUserVisit == null || ((DateTime)LastUserVisit).Date != DateTime.Now.Date)
            {
                await _localStorageService.SetItemAsync("LastUserVisit", DateTime.Now);
                await _httpClient.PatchAsync("api/Statistics", null);
            }
        }
    }
}
