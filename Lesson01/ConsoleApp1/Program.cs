using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Task.WhenAll(getPostId(4), getPostId(5), 
                                      getPostId(6), getPostId(7), 
                                      getPostId(8), getPostId(9), 
                                      getPostId(10), getPostId(11), 
                                      getPostId(12), getPostId(13));

            var array = result.Result;

            string writePath = @"c:\test\result.txt";
            if (File.Exists(writePath)) File.Delete(writePath);

            Post post = new Post();

            foreach (var item in array)
            {
                post = JsonConvert.DeserializeObject<Post>(item);
                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    sw.WriteLine(post.userId);
                    sw.WriteLine(post.id);
                    sw.WriteLine(post.title);
                    sw.WriteLine(post.body);
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

            return responseBody;
        }

        class Post
        {
            public string userId { get; set; }
            public string id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }
    }

}
