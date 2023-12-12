using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.Role;
using BusinessAdvanceManagement.Domain.DTOs.Unit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core.APIService
{
    public class GeneralApiService
    {
        HttpClient _httpClient;

        public GeneralApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<IEnumerable<UnitListDTO>>> GetAllUnit()
        {
           var result =await  _httpClient.GetAsync("getallunit");
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<UnitListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<IEnumerable<RoleListDTO>>> GetAllRole()
        {
            var result = await _httpClient.GetAsync("getallrole");
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<RoleListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
