using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAsService.API
{
    public class CatApiDelete
    {
        public RestClient? Client { get; set; }
        public RestRequest? Request { get; set; }
        public RestResponse? Response { get; set; }

        public void DeleteFavCat(int? catId)
        {
            Client = new RestClient($"https://api.thecatapi.com/v1/favourites/{catId}");
            Request = new RestRequest("", Method.Delete);
            Request.AddHeader("x-api-key", "live_Jp4ur3Aj7KMPbvovjYONN5rEoMbBb2QvfHwqKevAQj3GhDYqZrIaiXTaaqXOBIIe");
            Response = Client.ExecuteAsync(Request).GetAwaiter().GetResult();
        }
    }
}
