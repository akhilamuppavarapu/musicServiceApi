using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using musicServiceApi.Models;

namespace musicServiceApi.Services
{
    public class PlaylistService
    {
        private readonly IMongoCollection<Playlist> playlists;

        public PlaylistService(IMusicServiceApiDbSettings configuration)
        {
            MongoClient mongoClient = new MongoClient(configuration.ConnectionString);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(configuration.DatabaseName);
            playlists = mongoDatabase.GetCollection<Playlist>("Playlist");
        }

        public List<Playlist> getPlaylists()
        {
            return playlists.Find(playlist => true).ToList();
        }

        public Playlist getPlaylist(string id)
        {
            return playlists.Find<Playlist>(playlist => playlist.PlaylistId == id).FirstOrDefault();
        }

        public Playlist addNewPlaylist(Playlist playlist)
        {
            playlists.InsertOne(playlist);
            return playlist;
        }

    }
}
