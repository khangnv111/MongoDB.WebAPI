using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.WebAPI.Models
{
    public class BookStore
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string BookName { get; set; }

        [BsonElement("author")]
        public string Author { get; set; }
    }
}
