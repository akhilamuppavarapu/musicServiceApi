using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace musicServiceApi.Models
{
    public class Song
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string songId;

        [BsonElement("SongName")]
        [BsonRequired]
        private string songName { get; set; }

        [BsonElement("SongLength")]
        [BsonRequired]
        private double songLength { get; set; }

        [BsonElement("SongRelease")]
        [BsonRequired]
        private int songRelease { get; set; }

        [BsonElement("SongArtitsts")]
        [BsonRequired]
        private List<string> songArtists { get; set; }

        [BsonElement("CoverImageUrl")]
        [BsonRequired]
        private string coverImageUrl { get; set; }

        [BsonElement("PartOfAlbum")]
        [BsonRequired]
        private Boolean partOfAlbum { get; set; }

        [BsonElement("AlbumName")]
        private string albumName { get; set; }

        public Song()
        {

        }

        public string SongId { get => songId; set => songId = value; }



    }
}
