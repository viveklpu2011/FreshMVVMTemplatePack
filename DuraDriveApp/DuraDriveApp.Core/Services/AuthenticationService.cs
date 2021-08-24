using DuraDriveApp.Core.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuraDriveApp.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpService _httpService;
        public AuthenticationService(HttpService httpService)
        {
            _httpService = httpService;
        }

        //public async Task<Result<BaseApiResponseModel>> ForgotPassword(ForgotPasswordRequestModel request)
        //{
        //    var jsonRequest = JsonConvert.SerializeObject(request);
        //    var response = await _httpService.PostJsonAsync<BaseApiResponseModel>(Urls.BASE_URL + Urls.FORGOT_URL, jsonRequest);
        //    if (response?.ResultType == ResultType.Ok)
        //    {
        //        if (response?.Data != null)
        //        {
        //            //App.Locator.CurrentUser.AppointmentData = response?.Data;
        //        }
        //    }
        //    return response;
        //}

        //public async Task<Result<GetServiceLevelResponseModel>> GetAllServicesLevel()
        //{
        //    var response = await _httpService.GetJsonAsync<GetServiceLevelResponseModel>(Urls.BASE_URL + Urls.GET_SERVICE_LEVEL_URL);
        //    if (response?.ResultType == ResultType.Ok)
        //    {
        //        if (response?.Data != null)
        //        {
        //            //App.Locator.CurrentUser.AppointmentData = response?.Data;
        //        }
        //    }
        //    return response;
        //}

    }
}
