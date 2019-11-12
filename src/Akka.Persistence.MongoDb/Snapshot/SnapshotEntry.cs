//-----------------------------------------------------------------------
// <copyright file="SnapshotEntry.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using MongoDB.Bson.Serialization.Attributes;

namespace Akka.Persistence.MongoDb.Snapshot
{
    /// <summary>
    /// Class used for storing a Snapshot as BsonDocument
    /// </summary>
    public class SnapshotEntry
    {
        [BsonId]
        public EntryId Id { get; set; }

        [BsonIgnore()]
        public string PersistenceId => Id.PersistenceId;

        [BsonIgnore()]
        public long SequenceNr => Id.SequenceNr;

        [BsonElement("Timestamp")]
        public long Timestamp { get; set; }

        [BsonElement("Snapshot")]
        public object Snapshot { get; set; }

        [BsonElement("Manifest")]
        public string Manifest { get; set; }

        [BsonElement("SerializerId")]
        public int? SerializerId { get; set; }
    }

}