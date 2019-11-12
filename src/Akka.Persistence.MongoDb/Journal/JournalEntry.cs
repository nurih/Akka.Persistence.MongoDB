﻿//-----------------------------------------------------------------------
// <copyright file="JournalEntry.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using Akka.Persistence.MongoDb.Snapshot;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Akka.Persistence.MongoDb.Journal
{
    /// <summary>
    /// Class used for storing intermediate result of the <see cref="IPersistentRepresentation"/>
    /// as BsonDocument into the MongoDB-Collection
    /// </summary>
    public class JournalEntry
    {
        [BsonId]
        public EntryId Id { get; set; }

        [BsonIgnore]
        public string PersistenceId => Id.PersistenceId;

        [BsonIgnore]
        public long SequenceNr => Id.SequenceNr;

        [BsonElement("IsDeleted")]
        public bool IsDeleted { get; set; }

        [BsonElement("Payload")]
        public object Payload { get; set; }

        [BsonElement("Manifest")]
        public string Manifest { get; set; }

        [BsonElement("Ordering")]
        public BsonTimestamp Ordering { get; set; }

        [BsonElement("Tags")]
        public ICollection<string> Tags { get; set; } = new HashSet<string>();
      
        [BsonElement("SerializerId")]
        public int? SerializerId { get; set; }
    }
}
