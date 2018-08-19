using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace Group.Core.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("cidade")]
        public string City { get; set; }

        [JsonProperty("estado")]
        public string State { get; set; }
    }

    public sealed class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Map( m => m.Name ).Name( "nome" );
            Map( m => m.City ).Name( "cidade" );
            Map( m => m.State).Name( "estado" );
        }
    }
}