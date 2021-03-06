﻿using examensArbete.Models;
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



        public static async Task<ErrorModel> Get(string url, string accessToken)
        {
            Console.WriteLine("GET: "+url);
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
                Console.WriteLine("URL in GET: " + url);
                Console.WriteLine("Message :{0} ", e.Message);
                return new ErrorModel { ErrorCode = false, Message = e.Message, Object = null };

            }

            return new ErrorModel { ErrorCode = true, Message = null, Object = responseBody };
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
                Console.WriteLine("URL in POST: " + url);

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
                Console.WriteLine("URL in PUT: " + url);

                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }

            return responseBody;
        }
    }
}
