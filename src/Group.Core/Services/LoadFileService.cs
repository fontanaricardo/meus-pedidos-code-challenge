using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using CsvHelper;
using Group.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Group.Core.Services
{
    public class LoadFileService : ILoadFileService
    {
        private readonly HttpClient _httpClient;

        public LoadFileService()
        {
            _httpClient = new HttpClient();
        }

        public bool IsLocal(Uri address)
        {
            return address.IsFile;
        }

        public string Load(Uri address)
        {
            string result = string.Empty;
            
            if (IsLocal(address))
            {
                result = File.ReadAllText(address.OriginalString);
            }
            else
            {
                var response = _httpClient.GetAsync(address).Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public bool TryParseFromJson(string content, out IEnumerable<Customer> customers)
        {
            try
            {
                customers = JsonConvert.DeserializeObject<List<Customer>>(content);
                return true;
            }
            catch (JsonException)
            {
                customers = new List<Customer>();
                return false;
            }
        }

        public bool TryParseFromCsv(string content, out IEnumerable<Customer> customers)
        {
            try
            {
                var csv = new CsvReader( new StringReader(content));
                csv.Configuration.RegisterClassMap<CustomerMap>();
                customers = csv.GetRecords<Customer>().ToList();
                return true;
            }
            catch (Exception)
            {
                customers = new List<Customer>();
                return false;
            }
        }

        public Uri Parse(string address)
        {
            Uri uri = null;

            if (string.IsNullOrWhiteSpace(address))
            {
                throw new System.ArgumentNullException("The address param cannot be null.");
            }

            if (!Uri.TryCreate(address, UriKind.Absolute, out uri))
            {
                throw new System.InvalidOperationException("The address must be a valid absolute URL.");
            }

            return uri;
        }
    }
}