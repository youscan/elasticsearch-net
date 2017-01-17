using System;
using System.Linq;
using Nest252;
using Elasticsearch252.Net;

namespace YsTest191
{

    public class TestDoc
    {
        public string RowKey { get; set; }
        public DateTime Published { get; set; }
        public int Folowers { get; set; }
    }

    class Program
    {
        private static Uri elastic1 = new Uri("http://ys-es-prod-11.yscan.local:9200/");

        static readonly TestDoc doc1 = new TestDoc
        {
            RowKey = "1",
            Published = new DateTime(2016, 12, 25),
            Folowers = 100
        };

        static readonly TestDoc doc2 = new TestDoc
        {
            RowKey = "2",
            Published = new DateTime(2017, 12, 27),
            Folowers = 200
        };

        static readonly TestDoc doc3 = new TestDoc
        {
            RowKey = "3",
            Published = new DateTime(2017, 12, 30),
            Folowers = 300
        };

        const string indexName = "igor_test_compatability";

        static void Main(string[] args)
        {
            var settings = new ConnectionSettings(elastic1)
                .ThrowExceptions()
                .PrettyJson();

            var es = new ElasticClient(settings);

//            if (es.IndexExists(Indices.Index(indexName)).Exists)
//                es.DeleteIndex(Indices.Index(indexName));
//
//            es.CreateIndex(new IndexName() {Name = indexName}, cid => cid.Index(indexName));
////            es.CreateIndex(x => x
////                .Index(indexName)
////                .AddMapping<TestDoc>(m => m.Type<TestDoc>())
////            // .Settings(s => s.)
////            );
//
//            es.Index(doc1, idx => idx.Index(indexName).Id(doc1.RowKey));
//            es.Index(doc2, idx => idx.Index(indexName).Id(doc2.RowKey));
//            es.Index(doc3, idx => idx.Index(indexName).Id(doc3.RowKey));
//
//            es.Refresh(Indices.Index(indexName), rd => rd.Force());
//
//            Console.WriteLine("Index created and initialized . . . ");
//            Console.ReadLine();

            var start = new DateTime(2017, 12, 26);
            var finish = new DateTime(2017, 12, 31);

            var q251 = new QueryContainerDescriptor<TestDoc>()
                .Filtered(cs => cs.Filter(f => f
                    .DateRange(_ => _.Field(x => x.Published).GreaterThanOrEquals(start).LessThan(finish))
                )
            );

            var res251 = es.Search<TestDoc>(s => s.Index(indexName).Query(q => q251));

            Console.WriteLine(res251.Hits.Count());

        }
    }
}
