using MDbM.UI.Clases;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace MDbM.UI.MongoDB
{
    class Mongo
    {
        private MongoClient conexion;

        internal MongoClient GetConexion()
        {
            if (this.conexion == null)
            {
                conexion = new MongoClient();
                return conexion;
            }
            return this.conexion;
        }

        internal IMongoDatabase GetDatabase()
        {
            return GetConexion().GetDatabase("MdbM");
        }

        internal IMongoCollection<BsonDocument> GetCollection(string CollectionName)
        {
            return GetDatabase().GetCollection<BsonDocument>(CollectionName);
        }

        internal bool ComprobarExisteUsuario(string NombreUsuario)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("nombre", NombreUsuario);

            IEnumerable<BsonDocument> document = GetCollection("Usuarios").Aggregate().Match(filter).ToList();
            if (document.Count() > 0)
            {
                return true;
            }
            return false;
        }

        internal bool CearUsuario(Usuario Usuario)
        {


            return false;
        }

        internal bool LoginUsuario(Usuario Usuario)
        {


            return false;
        }
    }
}
