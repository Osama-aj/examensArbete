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



        public static async Task<string> Get(string url)
        {
            var accessToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6IjgzYTczOGUyMWI5MWNlMjRmNDM0ODBmZTZmZWU0MjU4Yzg0ZGI0YzUiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL3NlY3VyZXRva2VuLmdvb2dsZS5jb20vZW50ZWNvbi0yYTBlMyIsImF1ZCI6ImVudGVjb24tMmEwZTMiLCJhdXRoX3RpbWUiOjE1ODU5OTU4MjcsInVzZXJfaWQiOiJBdjRpdk02TE1sUlZ6N1c1WWJnaWxCWFVLNWQyIiwic3ViIjoiQXY0aXZNNkxNbFJWejdXNVliZ2lsQlhVSzVkMiIsImlhdCI6MTU4NTk5NTgyNywiZXhwIjoxNTg1OTk5NDI3LCJlbWFpbCI6Im15Y29vbGVtYWlsbmFtZUBibGFibGEuY29tIiwiZW1haWxfdmVyaWZpZWQiOmZhbHNlLCJmaXJlYmFzZSI6eyJpZGVudGl0aWVzIjp7ImVtYWlsIjpbIm15Y29vbGVtYWlsbmFtZUBibGFibGEuY29tIl19LCJzaWduX2luX3Byb3ZpZGVyIjoiY3VzdG9tIn19.EcsFgwx9obKcKFrj0KZvxFp0I2yk8aS0i9unHwYtzp3i8l4uigORkkdCfosJIbhmgIQWFcN2k8F1v-0ja1R8e5dbSHJXW8lemMxs2M98UVZrzejXJ4F9UUE-peLNfbeijoJ4u_Q9XsMezEqYUIsA4pU73lHTqohEx0QjcpwaKjhTTxGkDLTxSa9mPudk6RvOlv55sD75NA4_ncMyo7ho0XIs-IgRungK83jHoB4hvCfMuk6jb_wXBcWp8h-aKu30Kef14xgKYUWAgKQimAU63d9wJ7yp1s_Dz-sSx8jWbg5mXeEXORXAXIBwG6e0VkunrFbyhOyg8eqRLyQqy6BxKQ";
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














        public static async Task<string> Post(string url, object payload)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(payload));
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseBody = "";


            var client = new HttpClient();
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










        public static async Task<string> Put(string url, object payload)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(payload));
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseBody = "";


            var client = new HttpClient();
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
