using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core.APIService
{
    public class AdvanceRequestApiService
    {
        HttpClient _httpClient;

        public AdvanceRequestApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<AdvanceRequestAddDTO>> Add(AdvanceRequestAddDTO advanceRequestAddDTO)
        {
            var content = new StringContent(JsonConvert.SerializeObject(advanceRequestAddDTO));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var result = await _httpClient.PostAsync("addadvancerequest",content);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<AdvanceRequestAddDTO>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<IEnumerable<AdvanceRequestListDTO>>> GetByWorker(int workerID)
        {
            var path =$"getbyworkeradvancerequest/{workerID}";
            var result = await _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<AdvanceRequestListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<IEnumerable<OnlyAdvanceRequestListDTO>>> GetByRequestID(int advanceRequestID)
        {
            var path = $"getbyrequestid/{advanceRequestID}";
            var result = await _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<OnlyAdvanceRequestListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

    }
}
