using HttpClient client = new();

namespace Yaourts
{
    internal class Program
    {
        static async Task ProcessRepositoriesAsync(HttpClient client)
        {
            await ProcessRepositoriesAsync(client);
            var json = await client.GetStringAsync(
                "https://api.devoldere.net/polls/yoghurts/");

            Console.Write(json);
        }
        static void Main(string[] args)
        {

        }
    }
}
