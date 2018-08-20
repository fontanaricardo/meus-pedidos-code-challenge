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
                Error("Invalid number of arguments.");
                return;
            }

            var address = args[0];

            IEnumerable<Customer> customers = null;
            var validFile = false;
            string content = null;

            try
            {
                var uri = service.Parse(address);
                content = service.Load(uri);
            }
            catch (Exception ex)
            {
                Error(ex.Message);
                return;
            }

            validFile = service.TryParseFromJson(content, out customers);

            if (!validFile)
            {
                validFile = service.TryParseFromCsv(content, out customers);
            }

            if (!validFile)
            {
                Error("File not supported, please use CSV or JSON.");
                return;
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

        static void Error(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Usages:");
            Console.WriteLine("\tGroup /tmp/test.csv");
            Console.WriteLine("\tGroup http://tmp/test.csv");
        }
    }
}
