using System;
using Cbs.Datameer.Metadata.Adapters;
using Cbs.Datameer.Metadata.Model;
using Gremlin.Net.Driver;

namespace gremlintest
{
    class Program
    {
        static void TestMe() {
            var client = new VariableRepository(new GremlinServer("192.168.99.100"));
            client.Put(new Variable());
            client.Get("adfasdf");
        }
        static void Main(string[] args)
        {
            TestMe();
        }
    }
}
