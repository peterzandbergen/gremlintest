using System;

using Newtonsoft.Json.Linq;
using Gremlin.Net.Structure.IO.GraphSON;
using Gremlin.Net.Structure;

namespace Cbs.Datameer.Metadata.Adapters
{

    public class RelationIdentifierDeserializer : IGraphSONDeserializer
    {
        private Int64 outVertexId;
        private Int64 typeId;
        private Int64 relationId;
        private Int64 inVertexId;

        public dynamic Objectify(JToken graphsonObject, GraphSONReader reader)
        {
            var relID = reader.ToObject(graphsonObject["id"]);
            return new RelationIdentifier(0,0,0,0);
        }

    }

    public class RelationIdentifier 
    {
        private Int64 outVertexId;
        private Int64 typeId;
        private Int64 relationId;
        private Int64 inVertexId;
        public RelationIdentifier(long outVertexId, long typeId, long relationId, long inVertexId) { 
            this.outVertexId = outVertexId;
            this.typeId = typeId;
            this.relationId = relationId;
            this.inVertexId = inVertexId;
        }
    }



}

