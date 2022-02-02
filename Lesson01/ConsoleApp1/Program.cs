﻿using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Task.WhenAll(getPostId4(), getPostId5(), 
                                      getPostId6(), getPostId7(), 
                                      getPostId8(), getPostId9(), 
                                      getPostId10(), getPostId11(), 
                                      getPostId12(), getPostId13());
         
            var array = result.Result;
            foreach (var item in array)  Console.WriteLine(item);

        }
        HttpClient client = new HttpClient();
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com");



        //static readonly 
        HttpClient httpClient = new HttpClient();

        static async Task<string> getPostId(string id)
        {
            try
            {
                HttpCompletionOption option = new HttpCompletionOption();
                option = HttpCompletionOption.ResponseHeadersRead;
                
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com",);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }






        static async Task<string> getPostId4()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/4");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId5()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/5");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId6()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/6");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId7()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/7");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId8()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/8");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId9()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/9");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId10()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/10");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId11()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/11");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId12()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/12");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
        static async Task<string> getPostId13()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/13");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch
            {
                return null;
            }
        }
    }

}
