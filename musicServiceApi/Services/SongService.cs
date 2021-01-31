using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using musicServiceApi.Models;

namespace musicServiceApi.Services
{
    public class SongService
    {
        private readonly IMongoCollection<Song> songs;

        public SongService(IMusicServiceApiDbSettings configuration)
        {
            MongoClient mongoClient = new MongoClient(configuration.ConnectionString);
            IMongoDatabase mongoDatabase = mongoClient.GetDatabase(configuration.DatabaseName);
            songs = mongoDatabase.GetCollection<Song>("Song");
        }

        public List<Song> getSongs()
        {
            return songs.Find(song => true).ToList();
        }

        public Song getSong(string id)
        {
            return songs.Find<Song>(song => song.SongId == id).FirstOrDefault();
        }

        public Song addNewSong(Song song)
        {
            songs.InsertOne(song);
            return song;
        }

    }
}
