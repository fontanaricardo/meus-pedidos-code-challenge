using System;
using System.Collections.Generic;
using System.Linq;
using Group.Core.Models;
using Group.Core.Services;

namespace Group
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new LoadFileService();

            if (args.Length != 1)
            {
                Console.WriteLine("Invalid number of arguments.");
                Console.WriteLine("Usages:");
                Console.WriteLine("\tGroup /tmp/test.csv");
                Console.WriteLine("\tGroup http://tmp/test.csv");
                return;
            }

            var address = args[0];
            IEnumerable<Customer> customers = null;
            var validFile = false;

            var uri = service.Parse(address);
            var content = service.Load(uri);

            validFile = service.TryParseFromJson(content, out customers);

            if (!validFile)
            {
                validFile = service.TryParseFromCsv(content, out customers);
            }

            if (!validFile)
            {
                Console.WriteLine("File not supported, please use CSV or JSON.");
            }

            var countByState = customers
                .GroupBy(c => c.State)
                .OrderBy(c => c.Key)
                .Select(c => new {
                    State = c.Key,
                    Count = c.Count()
                });

            foreach (var item in countByState)
            {
                Console.WriteLine($"{item.State}:\t{item.Count}");
            }
        }
    }
}
