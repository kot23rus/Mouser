using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("AppKey:");
            var sp = new Mouser.SearchByKeyword
            {
                key = Console.ReadLine()
            };
            Console.Write("Search String:");
            sp.SearchByKeywordRequest = new Mouser.Models.SearchByKeyword()
            {
                keyword = Console.ReadLine()
            };
            sp.Execute();
        }
    }
}
