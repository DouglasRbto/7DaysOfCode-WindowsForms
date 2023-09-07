using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CatAsService.API
{
    public class CatApiPost
    {
        public RestClient? Client { get; set; }
        public RestRequest? Request { get; set; }
        public RestResponse? Response { get; set; }

        bool success = true;

        public void Favourite(string catId)
        {
            Client = new RestClient("https://api.thecatapi.com/v1/favourites");
            Request = new RestRequest("", Method.Post);
            Request.AddHeader("x-api-key", "live_Jp4ur3Aj7KMPbvovjYONN5rEoMbBb2QvfHwqKevAQj3GhDYqZrIaiXTaaqXOBIIe");
            Request.AddBody($"{{\"image_id\": \"{catId}\"}}");
            Response = Client.ExecuteAsync(Request).GetAwaiter().GetResult();
        }
        public bool Success()
        {
            if (Response?.StatusCode == System.Net.HttpStatusCode.OK)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
