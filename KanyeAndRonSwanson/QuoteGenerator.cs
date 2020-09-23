using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;

namespace KanyeAndRonSwanson
{
    public class QuoteGenerator
    {
        private HttpClient _client = new HttpClient();
        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }


     
        public string KanyeQuote(HttpClient client)
        {
            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return $"Kanye: {kanyeQuote}";
        }

        public string RonSwansonQuote(HttpClient client)
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronReponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronReponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim().Replace("\"", "");

            return $"Ron: {ronQuote}";
           
        }

        public string ChuckNorrisJoke(HttpClient client)
        {

            var chuckNorrisURL = "https://api.chucknorris.io/jokes/random";

            var chuckNorrisReponse = client.GetStringAsync(chuckNorrisURL).Result;

            var chuckNorrisQuote = JObject.Parse(chuckNorrisReponse).GetValue("value").ToString();
            
            return $"Chuck Norris {chuckNorrisQuote}";           
        }


    }
}
