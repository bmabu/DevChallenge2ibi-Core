using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevChallenge2ibi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DevChallenge2ibi.Controllers
{
    public class CountiesController : Controller
    {
        string Baseurl = "https://restcountries.com/v3.1/";
        public async Task<IActionResult> Index()
        {
            List<Country> countryInfo = new List<Country>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("all");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                    countryInfo = JsonConvert.DeserializeObject<List<Country>>(EmpResponse);
                }
                //returning the employee list to view
                return View(countryInfo);
            }

            return View();
        }

        public async Task<IActionResult> GetAll()
        {
           // ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            List<Country> countryInfo = new List<Country>();
            using (var client = new HttpClient())
            {
                //Passing service base url
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("all");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list
                   
                    countryInfo = JsonConvert.DeserializeObject<List<Country>>(EmpResponse);
                  //  dt.Where(t=>t.Languages.Keys[0]=)
                }
                countryInfo = countryInfo.OrderBy(s => s.Name.Common).ToList();
                //returning the employee list to view
                return View(countryInfo);
            }

            return View();
        }

        public async Task<IActionResult> GetAllByName(string filterByName)
        {
            if (String.IsNullOrEmpty(filterByName))
            {
                return (RedirectToAction("GetAll"));
            }
            // ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            List<Country> countryInfo = new List<Country>();
            using (var client = new HttpClient())
            {
                //Passing service base url

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("name/"+filterByName);
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list

                    countryInfo = JsonConvert.DeserializeObject<List<Country>>(EmpResponse);
                    //  dt.Where(t=>t.Languages.Keys[0]=)
                }
                countryInfo = countryInfo.OrderBy(s => s.Name.Common).ToList();
                //returning the employee list to view
                return View("GetAll", countryInfo);
            }

            return View();
        }
    }
}
