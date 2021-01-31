using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace musicServiceApi.Models
{
    public class Playlist
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string playlistId;

        [BsonElement("PlaylistName")]
        [BsonRequired]
        private string playlistName { get; set; }

        [BsonElement("AlbumsInPlaylist")]
        [BsonRequired]
        private List<Album> albumsInPlaylist { get; set; }

        [BsonElement("SongsInPlaylist")]
        [BsonRequired]
        private List<Song> songsInPlaylist { get; set; }

        [BsonElement("PlaylistUser")]
        [BsonRequired]
        private string playlistUser { get; set; }

        public Playlist()
        {

        }

        public string PlaylistId { get => playlistId; set => playlistId = value; }


    }
}
