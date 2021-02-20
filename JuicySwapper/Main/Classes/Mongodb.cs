using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JuicySwapper.Main.Classes
{
    public class MongoCRUD
    {
        public static IMongoDatabase db;
        

        public MongoCRUD(string jashd8372194236742398jkasdfhgdasku)
        {
            var client = new MongoClient(ekajsdhfdjkashfdsajk73289723984732894327oaskidhfdkajs48392107743982473289weikofh.iuksadhkjdas8931792832ioedhfjiklsd90832580923hidfwsw.dsukfg7839264sapiudasop730891478329047iodsfjilfsd09832732098398274uidsfhfkjs);
            db = client.GetDatabase(jashd8372194236742398jkasdfhgdasku);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
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

    public class UserModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string HWID { get; set; }
        public string CreatedAt { get; set; }
        public bool paid { get; set; }
        public bool boost { get; set; }
    }
}
