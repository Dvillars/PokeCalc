using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using RestSharp;
using RestSharp.Authenticators;

namespace PokeCalc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new RestClient("http://pokeapi.co/api/v2");
            var request = new RestRequest("/pokemon/1", Method.GET);
            //request.AddParameter("pokemon_number", 1);
            //request.AddParameter("pokemon_name", "bulbasaur");
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response);
            });
            Console.ReadLine();
        }
    }
}
