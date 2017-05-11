using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NuGet.Protocol.Core.v3;

namespace PokeCalc.Models
{
    [Table("Moves")]
    public class Move
    {
        [Key]
        public int MoveId { get; set; }
        public string Name { get; set; }
        //public int Power { get; set; }

        public static JObject GetMoves(string requestString)
        {
            var client = new RestClient("http://pokeapi.co/api/v2");
            var request = new RestRequest("/pokemon/" + requestString, Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JObject result = JsonConvert.DeserializeObject<JObject>(response.Content);
            return result;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response =>
            {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}
