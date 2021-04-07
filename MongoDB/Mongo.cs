using MDbM.Properties;
using MDbM.UI.Clases;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace MDbM.UI.MongoDB
{
    class Mongo
    {
        private MongoClient conexion;
        private ResourceManager rm = new ResourceManager(typeof(Resources));

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

        internal Image GetImagenUsuario(string NombreUsuario)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("nombre", NombreUsuario);

            BsonDocument document = GetCollection("Usuarios").Find(filter).First();

            //Usuario usuario = new Usuario();
            //usuario.imagenPerfil = (string) document.GetValue("imagenPerfil", "N/A");

            return (Image)rm.GetObject((string)document.GetValue("imagenPerfil", "N/A"));
        }

        internal bool CearUsuario(Usuario Usuario)
        {
            GetCollection("Usuarios").InsertOne(Usuario.ToBsonDocument());
            return true;
        }

        internal bool LoginUsuario(Usuario Usuario)
        {


            return false;
        }

        internal List<Peliculas> GetListaPeliculas()
        {
            List<BsonDocument> lista = GetCollection("Peliculas").Find(new BsonDocument()).ToList();
            List<Peliculas> salida = new List<Peliculas>();
            foreach (BsonDocument bd in lista)
            {
                salida.Add(BsonSerializer.Deserialize<Peliculas>(bd));
            }
            return salida;
        }

        internal List<Reparto> GetListaReparto()
        {
            List<BsonDocument> lista = GetCollection("Reparto").Find(new BsonDocument()).ToList();

            List<Reparto> salida = new List<Reparto>();

            foreach (BsonDocument bd in lista)
            {
                salida.Add(BsonSerializer.Deserialize<Reparto>(bd));
            }

            return salida;
        }

        internal Peliculas GetPelicula(ObjectId id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

            BsonDocument document = GetCollection("Peliculas").Find(filter).First();

            return BsonSerializer.Deserialize<Peliculas>(document);
        }

        internal Reparto GetReparto(ObjectId id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

            BsonDocument document = GetCollection("Reparto").Find(filter).First();

            return BsonSerializer.Deserialize<Reparto>(document);
        }

        internal Reparto GetReparto(string nombre)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("nombre", nombre);

            BsonDocument document = GetCollection("Reparto").Find(filter).First();

            return BsonSerializer.Deserialize<Reparto>(document);
        }

        internal async void ActualizarPelicula(Peliculas pelicula)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", pelicula._id);

            await GetCollection("Peliculas").ReplaceOneAsync(filter, pelicula.ToBsonDocument());
        }

        internal async void CrearPelicula(Peliculas pelicula)
        {
            await GetCollection("Peliculas").InsertOneAsync(pelicula.ToBsonDocument());
        }

    }
}
