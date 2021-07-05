using Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string colletion)
        {
            throw new System.NotImplementedException();
        }
    }
}
