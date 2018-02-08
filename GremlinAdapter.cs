using Cbs.Datameer.Metadata.Model;
using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Remote;
using Gremlin.Net.Structure;
using Gremlin.Net.Structure.IO.GraphSON;
using Gremlin.Net.Process.Traversal;

using System.Collections;
using System.Collections.Generic;


namespace Cbs.Datameer.Metadata.Adapters
{


    class GremlinAdapter
    {

        public IVariableRepository VariableRepository
        {
            get
            {
                return null;
            }
        }
    }


    class VariableRepository : IVariableRepository
    {
        GremlinServer server;
        GremlinClient client;

        public VariableRepository(GremlinServer server)
        {
            this.server = server;
            var gsreader = new GraphSON2Reader(
                new Dictionary<string, IGraphSONDeserializer>
                {
                    {"RelationIdentifier", new RelationIdentifierDeserializer()}
                }
            );

            client = new GremlinClient(
                gremlinServer: server,
                graphSONReader: gsreader,
                graphSONWriter: new GraphSON2Writer(),
                mimeType: "application/vnd.gremlin-v2.0+json"
            );
        }

        public string Put(Variable variable)
        {

            // Build the string.
            var graph = new Graph();
            var g = graph.Traversal().WithRemote(new DriverRemoteConnection(client));
            var res = g.AddV("person").Property("name", "peter").ToList();
            return "";
            // Construct a variable.
        }

        public Variable Get(string id)
        {
            // Build the string.
            var graph = new Graph();
            var g = graph.Traversal().WithRemote(new DriverRemoteConnection(client));
            var res = g.V().Values<Vertex>().ToList();
            return null;
        }
    }
}