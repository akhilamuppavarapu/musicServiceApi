using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace musicServiceApi.Models
{
    public class Album
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private String albumId;

        [BsonElement("AlbumName")]
        [BsonRequired]
        private String albumName { get; set; }

        [BsonElement("AlbumRelease")]
        [BsonRequired]
        private String albumRelease { get; set; }

        [BsonElement("AlbumArtists")]
        [BsonRequired]
        private List<String> albumArtists { get; set; }


        public Album()
        {
            // empty constructor
        }
      
    }
}
