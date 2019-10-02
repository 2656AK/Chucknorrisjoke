using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary
{
    public class Jokesgenerator
    {
        public async Task<string> GetRandomJoke()

        {
            HttpClient client = new HttpClient();
            string randomString = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            var joke = JsonConvert.DeserializeObject<Joke>(randomString);

            return joke.value;
        }


        public async Task<string[]> GetCategories()
        {
            HttpClient client = new HttpClient();

            string categoryJokeString = await client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            var categories = JsonConvert.DeserializeObject<string[]>(categoryJokeString);

            return categories;

        }
    }
}
