using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace examensArbete.BusinessLogic
{
    public class RestVerbs
    {



        public static async Task<string> Get(string url, string accessToken)
        {

            var responseBody = "";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);





            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                if (response != null)
                {
                    responseBody = await response.Content.ReadAsStringAsync();

                }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }

            return responseBody;
        }



        public static async Task<string> Post(string url, object payload, string accessToken)
        {
            var client = new HttpClient();

            var stringContent = new StringContent(JsonConvert.SerializeObject(payload));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseBody = "";


            try
            {
                HttpResponseMessage response = await client.PostAsync(url, stringContent);
                response.EnsureSuccessStatusCode();

                if (response != null)
                {
                    responseBody = await response.Content.ReadAsStringAsync();

                }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }

            return responseBody;
        }










        public static async Task<string> Put(string url, object payload, string accessToken)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            var stringContent = new StringContent(JsonConvert.SerializeObject(payload));
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseBody = "";


            try
            {
                HttpResponseMessage response = await client.PutAsync(url, stringContent);
                response.EnsureSuccessStatusCode();

                if (response != null)
                {
                    responseBody = await response.Content.ReadAsStringAsync();

                }

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }

            return responseBody;
        }
    }
}
