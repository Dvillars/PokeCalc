using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokeCalc.Models;

namespace PokeCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
            //    var client = new RestClient("http://pokeapi.co/api/v2");
            //    var request = new RestRequest("/pokemon/bulbasaur", Method.GET);
            //    var response = new RestResponse();
            //    Task.Run(async () =>
            //    {
            //        response = await GetResponseContentAsync(client, request) as RestResponse;
            //    }).Wait();
            //    JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            //    var moveList = JsonConvert.DeserializeObject<List<Move>>(jsonResponse["moves"].ToString());
            //    foreach (var moveObject in moveList)
            //    {
            //        Console.WriteLine("Name: {0}", moveObject.Name);
            //        //Console.WriteLine("Power: {0}", moveObject.Power);
            //    }
            //    Console.ReadLine();
            //}

            //public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
            //{
            //    var tcs = new TaskCompletionSource<IRestResponse>();
            //    theClient.ExecuteAsync(theRequest, response =>
            //    {

            //        tcs.SetResult(response);
            //    });
            //    return tcs.Task;
        }
    }
}
