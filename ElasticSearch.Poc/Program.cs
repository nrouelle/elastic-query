using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;

namespace ElasticSearch.Poc
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlElasticSearch = "";
            string username = "nrouelle";
            string password = "password";

            var settings = new ConnectionConfiguration(new Uri(urlElasticSearch))
                .RequestTimeout(TimeSpan.FromMinutes(2));
            settings.BasicAuthentication(username, password);
            var client = new ElasticLowLevelClient(settings);
        }
    }
}
