using ApiKanyeThoughts.Models;
using System.Linq;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    //List<string> phrases = new List<string>();
    var uniqueQuotes = new HashSet<string>();
    for (int i = 0; i < 50; i++)
    {
        try
        {
            string json = await client.GetStringAsync("https://api.kanye.rest/");
            var kanyeQuotes = JsonSerializer.Deserialize<KanyeQuote>(json)!;

            if (kanyeQuotes != null && !uniqueQuotes.Contains(kanyeQuotes.Quote))
            {
                uniqueQuotes.Add(kanyeQuotes.Quote);
                Console.WriteLine($"♦ {kanyeQuotes.Quote} ♦\n");
            }
            else
            {
                break;
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    Console.WriteLine($"◘ Total quotes at this moment: {uniqueQuotes.Count} ◘");
}