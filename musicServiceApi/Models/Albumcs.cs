using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace musicServiceApi.Models
{
    public class Albumcs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private String albumId;
    }
}
