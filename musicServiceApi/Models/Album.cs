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
        private string albumId;

        [BsonElement("AlbumName")]
        [BsonRequired]
        private string albumName { get; set; }

        [BsonElement("AlbumRelease")]
        [BsonRequired]
        private string albumRelease { get; set; }

        [BsonElement("AlbumArtists")]
        [BsonRequired]
        private List<string> albumArtists { get; set; }

        [BsonElement("SongsInAlbum")]
        [BsonRequired]
        private List<Song> songsInAlbum { get; set; }



        public Album()
        {
            // empty constructor
        }

        public string AlbumId { get => albumId; set => albumId = value; }

    }
}
