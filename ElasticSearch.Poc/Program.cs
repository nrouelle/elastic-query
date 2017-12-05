using System;
using Nest;

namespace ElasticSearch.Poc
{
    class Program
    {
        static void Main(string[] args)
        {
            const string urlElasticSearch = "http://server:port";

            var settings = new ConnectionSettings(new Uri(urlElasticSearch))
                .RequestTimeout(TimeSpan.FromMinutes(2)).DefaultIndex("index");

            var elasticClient = new ElasticClient(settings);

            var searchResponse = elasticClient.Search<Personne>(s => s.From(0).Size(20)
                .Query(q => q
                    .Match(m => m
                        .Field(f => f.Id)
                        .Query("1"))));

            var personne = searchResponse.Documents;
        }
    }
}
