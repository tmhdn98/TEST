using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API_Weather.Common.Models;
using API_Weather.RESTFul;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LsWeatherController
    {
        [HttpGet]
        public ResponseConvertModel Archives()
        {
            try
            {
                HttpResponseMessage obj = new HttpResponseMessage();
                string rs;

                string uri = "http://api.openweathermap.org/data/2.5/group?id=1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc755db1a94caf6d86a9c788a";
                Dictionary<string, string> pHeaders = new Dictionary<string, string>();

                var data = "";
                obj = ServiceClient.Request(HttpMethod.Post, uri, data, pHeaders).Result;
                rs = obj.Content.ReadAsStringAsync().Result;



                JObject rsJoj = JObject.Parse(rs);
                string rsJs = JsonConvert.SerializeObject(rsJoj);
                var responseModel = JsonConvert.DeserializeObject<ResponseModel>(rsJs);

                var lsResultModel = new List<ResultModel>();
                foreach (var item in responseModel.list)
                {
                    var resultModel = new ResultModel();
                    resultModel.cityId = item.id;
                    resultModel.cityName = item.name;
                    resultModel.weatherMain = item.weather.FirstOrDefault().main;
                    resultModel.weatherDescription = item.weather.FirstOrDefault().description;
                    resultModel.weatherIcon = "http://openweathermap.org/img/wn/" + item.weather.FirstOrDefault().icon.ToString() + "@2x.png";
                    resultModel.mainTemp = item.main.temp.ToString();
                    resultModel.mainHumidity = item.main.humidity.ToString();
                    lsResultModel.Add(resultModel);
                }
                ResponseConvertModel dataResponseConver = new ResponseConvertModel();
                dataResponseConver.data = lsResultModel;
                dataResponseConver.message = "Current weather information of cities";
                dataResponseConver.statusCode = 200;
                return dataResponseConver;
            }
            catch (Exception)
            {
                ResponseConvertModel dataResponseConver = new ResponseConvertModel();
                dataResponseConver.data = null;
                dataResponseConver.message = "FAIL";
                dataResponseConver.statusCode = 400;
                return dataResponseConver;
            }


        }
    }
}
