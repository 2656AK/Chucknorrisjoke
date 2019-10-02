using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Jokesgenerator jokeGenerator = new Jokesgenerator();
            string randomJoke = await jokeGenerator.GetRandomJoke();

            Console.WriteLine(randomJoke);

            string[] catergories = await jokeGenerator.GetCategories();

            for (int index = catergories.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(catergories[index]);
            }
        }   
                
    }
}