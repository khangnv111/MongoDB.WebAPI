using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDB.WebAPI.Models
{
    public class Comments
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]

        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string UserComment { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public ObjectId movie_id { get; set; }

        [BsonElement("text")]
        public string CommentDetail { get; set; }

        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        //[BsonElement("date")]
        public DateTime date { get; set; }
    }
}
