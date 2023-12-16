﻿using BusinessAdvanceManagement.Core.Result;
using BusinessAdvanceManagement.Domain.DTOs.RequestDetail;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core.APIService
{
    public class RequestDetailApiService
    {
        HttpClient _httpClient;

        public RequestDetailApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GeneralReturnType<IEnumerable<ConfirmAdvanceListDTO>>> GetAdvanceRequest(int statuID)
        {
            var path = $"getadvancerequest/{statuID}";
            var result = await  _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<ConfirmAdvanceListDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<GeneralReturnType<IEnumerable<ConfirmAdvanceDetailDTO>>> GetAdvanceRequestDetail(int advanceRequestID)
        {
            var path = $"getadvancerequestdetail/{advanceRequestID}";
            var result = await _httpClient.GetAsync(path);
            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<GeneralReturnType<IEnumerable<ConfirmAdvanceDetailDTO>>>(await result.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}