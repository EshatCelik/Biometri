using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("get-all/{id}")]
        
        public IActionResult GetAll(string id)
       {


            User demographicData = new User();

            //----------

            var client = new RestClient("Gelecek apideki url" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Key", "ValueDeğeri");

            IRestResponse response = client.Execute(request);

            var content = response.Content; // raw content as string


            //var strData = await client.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<JObject>(response.Content);

            demographicData.Name = jsonObject["data"]["fatherName"].ToString();
            demographicData.LastName = jsonObject["data"]["surname"].ToString();
            demographicData.BirthDate = jsonObject["data"]["birthdate"].ToString();
            demographicData.Email = jsonObject["data"]["email"].ToString();

            //dynamic json = JsonConvert.DeserializeObject(content);

            return Ok(demographicData);




        }

    }
}
