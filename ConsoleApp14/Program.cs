using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using ConsoleApp14.Models;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1
            //string path = @"C:\Users\murad\Desktop\Models\Data";
            string path1 = @"C:\Users\murad\Desktop\Models\Data\jsonData.json";

            //Directory.CreateDirectory(path);



            //if (!File.Exists(path1)) 
            //{
            //    File.Create(path1);

            //}
            //else
            //{
            //    Console.WriteLine("Movcuddur");
            //}
            //string text = "";

            //using (StreamReader stream = new StreamReader(path1))
            //{
            //    text = stream.ReadToEnd();
            //}
            //using (StreamWriter stream = new StreamWriter(path1))
            //{
            //    stream.WriteLine(text);
            //    stream.WriteLine("salam dostlar");

            //}













            //Task2 




            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            //string content = await response.Content.ReadAsStringAsync();
            //List<Post> posts = JsonSerializer.Deserialize<List<Post>>(content);
            //Console.WriteLine(posts[0].Body);
         





        }
    }
}