using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.AdvanceRule;
using BusinessAdvanceManagement.Domain.DTOs.PageRole;
using BusinessAdvanceManagement.Domain.DTOs.Project;
using BusinessAdvanceManagement.Domain.DTOs.Role;
using BusinessAdvanceManagement.Domain.DTOs.Unit;
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

        public async Task<GeneralReturnType<IEnumerable<WorkerListDTO>>> GetAllWorker()
        {
            var result =await _httpClient.GetAsync("getallworker");
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<WorkerListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<IEnumerable<PageRoleListDTO>>> GetByIDRolePage(int id)
        {
            var apiUrl = $"getbyrolpage/{id}";
            var result = await _httpClient.GetAsync(apiUrl);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<PageRoleListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<GeneralReturnType<IEnumerable<ProjectListDTO>>> GetAllProject()
        {
            var result = await _httpClient.GetAsync("getallproject");
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<ProjectListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
        public async Task<GeneralReturnType<IEnumerable<AdvanceRuleListDTO>>> GetByRoleIDRule(int roleID)
        {
            var path = $"getbyroleidrule/{roleID}";
            var result = await _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<AdvanceRuleListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
