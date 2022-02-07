using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var result = Task.WhenAll(Enumerable.Range(4, 13).Select(i => getPostId(i)));

            var array = result.Result;

            string writePath = @"c:\test\result.txt";
            if (File.Exists(writePath)) File.Delete(writePath);

            Post post = new Post();

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            foreach (var item in array)
            {
                post = JsonConvert.DeserializeObject<Post>(item);
                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    sw.WriteLine(post.UserId);
                    sw.WriteLine(post.Id);
                    sw.WriteLine(post.Title);
                    sw.WriteLine(post.Body);
                    sw.WriteLine();
                    sw.Close();
                }

            }

        }

        static Uri Uri = new Uri("https://jsonplaceholder.typicode.com");
        
        static async Task<string> getPostId(int id)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = Uri;
            HttpResponseMessage response = await httpClient.GetAsync($"/posts/{id}");
            string responseBody = await response.Content.ReadAsStringAsync();
            httpClient.Dispose();
            return responseBody;
        }

        class Post
        {
            public string UserId { get; set; }
            public string Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
    }

}
