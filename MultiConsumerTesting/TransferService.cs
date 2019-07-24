using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Banking.Web.Models.DTO;
using Newtonsoft.Json;

namespace Banking.Web.Services
{
    public class TransferService
    {
        private readonly HttpClient _httpClient;
        private ReaderWriterLockSlim readerWriterLock = new ReaderWriterLockSlim();
        public TransferService(HttpClient apiClient)
        {
            _httpClient = apiClient;
        }
        public async Task Transfer(TransferDto transferDto)
        {
            try
            {
                readerWriterLock.EnterWriteLock();
                var uri = "http://localhost:6061/api/Banking";
                var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), encoding: Encoding.UTF8, "application/json");
                var response =  _httpClient.PostAsync(uri, transferContent).Result;
                response.EnsureSuccessStatusCode();
            }
            finally
            {
                readerWriterLock.ExitWriteLock();
            }
            
        }
    }
}
