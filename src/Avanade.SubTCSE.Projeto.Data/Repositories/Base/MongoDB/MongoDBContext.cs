using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext

        private readonly IMongoDatabase _mongoDatabase
    {
       public IMongoDBCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings
                .FromUrl(new MongoUrl(""));
            mongoClientSettings.SslSettings =
                new SslSettings()
                {
                    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                }
            MongoClient mongoClient = new MongoClient(settings: mongoClientSettings);

            IMongoDatabase mongoDatabase = mongoClient.GetDatabase("");
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
    _mongoDatabase.GetCollection<TEntity>(nameo: collection);
        }
    }
}
