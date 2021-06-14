using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JuicySwapper_Launcher.Main.Classes
{
    public class MongoCRUD
    {
        public static IMongoDatabase db;
        
        public MongoCRUD(string A)
        {
            var URL = JuicySwapper_Encryption.Auth.DataBase.dbURL;

            var client = new MongoClient(JuicySwapper_Encryption.Auth.DataBase.Decrypt(URL, "AdhUOWwOgFSNaNqD7QBuoYCJ3Y8hr91P"));
            db = client.GetDatabase(A);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public long Accounts<T>(string table, bool temp)
        {
            var filter = Builders<AccountInfo>.Filter.Eq("paid", temp);
            var Count = db.GetCollection<AccountInfo>(table).CountDocuments(filter);

            return Count;
        }

        public static List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public static T LoadRecordByID<T>(string table, Guid Id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("id", Id);

            return collection.Find(filter).First();
        }

        public T LoadRecordByUsername<T>(string table, string username)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("username", username);

            return collection.Find(filter).First();
        }

        public T LoadRecordByHwid<T>(string table, string hwid)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("HWID", hwid);

            return collection.Find(filter).First();
        }

        [Obsolete]
        public void UpsertRecord<T>(string table, string username, T record)
        {
            var collection = db.GetCollection<T>(table);

            var results = collection.ReplaceOne(new BsonDocument("username", username),
                record, 
                new UpdateOptions { IsUpsert = true });
        }
    }

    public class Friends
    {
        [BsonId]
        public Guid Id { get; set; }
        public Array Incoming { get; set; }
        public Array Outgoing { get; set; }
        public Array Accepted { get; set; }
    }

    public class AccountCustomization
    {
        public string ProfilePicture { get; set; }
        public string Bio { get; set; }
        public string Discord { get; set; }
        public string FortniteName { get; set; }
    }

    public class AccountInfo
    {
        [BsonId]
        public Guid Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string HWID { get; set; }
        public string CreatedAt { get; set; }
        public string ProfilePicture { get; set; }
        public string Bio { get; set; }
        public string Discord { get; set; }
        public string FortniteName { get; set; }
        public string Status { get; set; }
    }
}
