using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace KanyeAndRonSwanson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var client = new HttpClient();
            var quoteGenerator = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(quoteGenerator.KanyeQuote(client));
                Console.WriteLine();
                Console.WriteLine(quoteGenerator.RonSwansonQuote(client));
                Console.WriteLine();
                Console.WriteLine(quoteGenerator.ChuckNorrisJoke(client));
            }   

        }
    }
}
