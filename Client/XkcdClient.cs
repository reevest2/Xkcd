using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xkcd.Models;
using RestSharp;



namespace xkcd.Client
{
    public class XkcdClient
    {
        public async Task<List<Xkcd>> GetComic()
        {
            var restClient = new RestClient();

            var request = new RestRequest("https://xkcd.com/info.0.json");
            var response = await restClient.ExecuteAsync<List<Xkcd>>(request);
            return response.Data;
        }
    }
}
