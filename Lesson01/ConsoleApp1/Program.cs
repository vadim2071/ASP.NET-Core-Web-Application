using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getPostId1();
        }
        static async Task getPostId1()
        {
            try
            {
                HttpClient client = new HttpClient();
                var result = client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/todos/1"));
            }
            catch
            {

            }
        }
    }

}
