using RestSharp;
using System.Text;
using System.Text.Json;

namespace CatAsService.API
{
    public class CatApiGet
    {
        RestClient? Client { get; set; }
        RestRequest? Request { get; set; }
        RestResponse? Response { get; set; }

        StringBuilder? Json = new StringBuilder();

        public List<Cat> GetCatList()
        {
            Client = new RestClient("https://api.thecatapi.com/v1/breeds/");
            Request = new RestRequest("", Method.Get);
            Response = Client.ExecuteAsync(Request).GetAwaiter().GetResult();

            if (Response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Json?.Append(Response.Content);
                File.WriteAllText("cats.json", Json?.ToString());
            }
            else
            {
                Json?.Append(File.ReadAllText("cats.json"));
            }

            var catList = JsonSerializer.Deserialize<List<Cat>>(Json?.ToString()!);
            return catList!;
        }

        public List<Favorite>? GetCatFavoriteList()
        {
            Client = new RestClient($"https://api.thecatapi.com/v1/favourites/");
            Request = new RestRequest("", Method.Get);
            Request.AddHeader("x-api-key", "live_Jp4ur3Aj7KMPbvovjYONN5rEoMbBb2QvfHwqKevAQj3GhDYqZrIaiXTaaqXOBIIe");
            Response = Client.ExecuteAsync(Request).GetAwaiter().GetResult();

            var favoriteList = new List<Favorite>();

            try
            {
                favoriteList = JsonSerializer.Deserialize<List<Favorite>>(Response.Content!);
                return favoriteList!;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
