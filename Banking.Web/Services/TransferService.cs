using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Banking.Web.Models.DTO;
using Newtonsoft.Json;

namespace Banking.Web.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;
        public TransferService(HttpClient apiClient)
        {
            _httpClient = apiClient;
        }
        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "http://localhost:5872/api/Banking";
            var json = JsonConvert.SerializeObject(transferDto);
            var transferContent = new StringContent(json, encoding: Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(uri,transferContent);
            response.EnsureSuccessStatusCode();
            
        }
    }
}
