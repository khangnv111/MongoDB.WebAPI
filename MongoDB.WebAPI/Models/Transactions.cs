using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoDB.WebAPI.Models
{
    [BsonIgnoreExtraElements]
    public class TransactionAnalytics
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("account_id")]
        public int AccountID { get; set; }

        [BsonElement("transaction_count")]
        public int TransactionCount { get; set; }

        [BsonElement("bucket_start_date")]
        public DateTime StartDate { get; set; }

        [BsonElement("bucket_end_date")]
        public DateTime EndDate { get; set; }

        //public List<TrasactionData> transactions { get; set; }
    }

    public class TrasactionData
    {
        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("amount")]
        public int Amount { get;set; }

        [BsonElement("transaction_code")]
        public string TranCode { get; set; }

        [BsonElement("symbol")]
        public string Symbol { get; set; }

        [BsonElement("price")]
        public string Price { get; set; }

        [BsonElement("total")]
        public string Total { get; set; }
    }
}
