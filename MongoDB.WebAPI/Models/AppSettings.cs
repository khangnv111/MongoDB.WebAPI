namespace MongoDB.WebAPI.Models
{
    public class AppSettings
    {
    }

    public class ConnectionString
    {
        public string MongoDbConnection { get; set; }
        public MongDataName MongoDbName { get; set; }
        public string MongoDbComments { get; set; }
    }

    public class MongDataName
    {
        public string Analytics { get; set; }
        public string Mflix { get; set; }
    }
}
