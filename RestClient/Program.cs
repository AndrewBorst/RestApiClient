using System;
using RestApiClient.Models.DSCO;
using RestSharp;
using Newtonsoft.Json;

namespace RestApiClient
{
    class Program
    {
        static void Main(string[] args)
        {            
            var client = new RestClient("http://localhost:57375/api");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("Order/5555", Method.GET);
            //request.AddParameter("orderID", "5555"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            //// easily add HTTP Headers
            //request.AddHeader("header", "value");


            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            var order = Newtonsoft.Json.JsonConvert.DeserializeObject<DscoOrder>(response.Content);

            Console.WriteLine(response.Content);

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            //IRestResponse<DscoOrder> order2 = client.Execute<DscoOrder>(request);
            //var name = order.Data.ClientID;

            //// easy async support
            //client.ExecuteAsync(request, response => {
            //    Console.WriteLine(response.Content);
            //});

            //// async with deserialization
            //var asyncHandle = client.ExecuteAsync<Person>(request, response => {
            //    Console.WriteLine(response.Data.Name);
            //});

            //// abort the request on demand
            //asyncHandle.Abort();
        }
    }
}
