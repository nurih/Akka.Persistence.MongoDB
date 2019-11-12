//-----------------------------------------------------------------------
// <copyright file="SnapshotEntry.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using MongoDB.Bson.Serialization.Attributes;

namespace Akka.Persistence.MongoDb.Snapshot
{
    
    public class EntryId
    {
        [BsonElement("p")]
        public string PersistenceId { get; set; }
        [BsonElement("s")]
        public long SequenceNr { get; set; }

        public override string ToString()
        {
            return $@"${PersistenceId}_${SequenceNr}";
        }
    }
}