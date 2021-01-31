using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using musicServiceApi.Models;

namespace musicServiceApi.Services
{
    public class AlbumService
    {
        private readonly IMongoCollection<Album> albums;

        public AlbumService(IMusicServiceApiDbSettings configuration)
        {
            MongoClient mongoClient = new MongoClient(configuration.ConnectionString);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(configuration.DatabaseName);
            albums = mongoDatabase.GetCollection<Album>("Album");
        }

        public List<Album> getAlbums()
        {
            return albums.Find(album => true).ToList();
        }

        public Album getAlbum(string id)
        {
            return albums.Find<Album>(album => album.AlbumId == id).FirstOrDefault();
        }

        public Album addNewAlbum(Album album)
        {
            albums.InsertOne(album);
            return album;
        }

    }
}
