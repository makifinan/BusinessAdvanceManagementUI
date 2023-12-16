using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRequestDetail;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core.APIService
{
    public class AdvanceRequestDetailApiService
    {
        HttpClient _httpClient;

        public AdvanceRequestDetailApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<IEnumerable<AdvanceRequestDetailListDTO>>> GetByRequest(int advanceRequestID)
        {
            var path = $"getbyrequest/{advanceRequestID}";
            var result = await _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<AdvanceRequestDetailListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

    }
}
