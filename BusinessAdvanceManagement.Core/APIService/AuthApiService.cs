using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.Worker;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core.APIService
{
    public class AuthApiService
    {
        private readonly HttpClient _httpClient;

        public AuthApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<WorkerAddDTO>> Register(WorkerAddUserDTO workerAddUserDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(workerAddUserDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("addworker",content);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<WorkerAddDTO>>(await result.Content.ReadAsStringAsync());
            }
            return JsonConvert.DeserializeObject<GeneralReturnType<WorkerAddDTO>>(await result.Content.ReadAsStringAsync());
        }


    }
}
