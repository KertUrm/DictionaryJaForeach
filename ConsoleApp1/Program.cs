using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var koolid = new Dictionary<int, string>
            {
                {1,"Tallinna Tehnikagümnaasium"},
                {2,"Tallinna Arte Gümnaasium"},
                {3,"Tallinna 32. Keskkool"},
            };
            foreach (var kool in koolid)
            {
                Console.WriteLine($"{kool.Key} - {kool.Value}");
            }
        }
    }
}
