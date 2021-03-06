using MDbM.Clases;
using MDbM.Properties;
using MDbM.UI.Clases;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
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

            return Image.FromFile(Path.GetUserPPPath() + document.GetValue("imagenPerfil", "N/A") + ".jpg");
        }

        internal bool CearUsuario(Usuario Usuario)
        {
            GetCollection("Usuarios").InsertOne(Usuario.ToBsonDocument());
            return true;
        }

        internal Usuario LoginUsuario(string nombre, string passw)
        {
            var filterNombre = Builders<BsonDocument>.Filter.Eq("nombre", nombre);

            var filterPassw = Builders<BsonDocument>.Filter.Eq("passw", passw);

            BsonDocument document;
            try
            {
                document = GetCollection("Usuarios").Aggregate().Match(filterNombre).Match(filterPassw).First();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Intento de incio de sesion con usuario no existente");
                return null;
            }

            return BsonSerializer.Deserialize<Usuario>(document);
        }

        internal List<Pelicula> GetListaPeliculas()
        {
            List<BsonDocument> lista = GetCollection("Peliculas").Find(new BsonDocument()).ToList();
            List<Pelicula> salida = new List<Pelicula>();
            foreach (BsonDocument bd in lista)
            {
                salida.Add(BsonSerializer.Deserialize<Pelicula>(bd));
            }
            return salida;
        }

        internal List<Pelicula> GetListaPeliculas(string nombre)
        {
            var filter = new BsonDocument { { "titulo", new BsonDocument { { "$regex", nombre }, { "$options", "i" } } } };

            List<BsonDocument> lista = GetCollection("Peliculas").Find(filter).ToList();
            List<Pelicula> salida = new List<Pelicula>();
            foreach (BsonDocument bd in lista)
            {
                salida.Add(BsonSerializer.Deserialize<Pelicula>(bd));
            }
            return salida;
        }

        internal List<Pelicula> GetListaPeliculasOrdenadas(string ordenKey, int orden)
        {
            SortDefinition<BsonDocument> filterOrder = null;
            switch (orden)
            {
                case (int) Enums.Orden.ASCENDENTE:
                    filterOrder = Builders<BsonDocument>.Sort.Ascending(ordenKey);
                    break;
                case (int) Enums.Orden.DESCENDENTE:
                    filterOrder = Builders<BsonDocument>.Sort.Descending(ordenKey);
                    break;
            }

            var filterExist = Builders<BsonDocument>.Filter.Exists(ordenKey);
            List<BsonDocument> lista = GetCollection("Peliculas").Find(filterExist).Sort(filterOrder).ToList();
            List<Pelicula> salida = new List<Pelicula>();
            foreach (BsonDocument bd in lista)
            {
                salida.Add(BsonSerializer.Deserialize<Pelicula>(bd));
            }
            return salida;
        }

        internal async void ActualizarPelicula(Pelicula pelicula)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", pelicula._id);

            await GetCollection("Peliculas").ReplaceOneAsync(filter, pelicula.ToBsonDocument());
        }

        internal async void ActualizarEstadoPelicula(Usuario usuario, Pelicula pelicula, string estadoOrigen, string estadoDestino)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", usuario._id);

            var updatePull = Builders<BsonDocument>.Update.Pull(estadoOrigen, pelicula._id);
            var updatePush = estadoDestino != "-- no agregada --" ? Builders<BsonDocument>.Update.Push(estadoDestino, pelicula._id) : null;

            await GetCollection("Usuarios").UpdateOneAsync(filter, updatePull);
            if(updatePush != null)
            {
                await GetCollection("Usuarios").UpdateOneAsync(filter, updatePush);
            }
        }

        internal async void CrearPelicula(Pelicula pelicula)
        {
            await GetCollection("Peliculas").InsertOneAsync(pelicula.ToBsonDocument());
        }

        internal Pelicula GetPelicula(ObjectId id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);

            BsonDocument document = GetCollection("Peliculas").Find(filter).First();

            return BsonSerializer.Deserialize<Pelicula>(document);
        }

        internal async void EliminarPelicula(Pelicula pelicula)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", pelicula._id);

            await GetCollection("Peliculas").DeleteOneAsync(filter);
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

        internal Enums.EstadosPelicula GetEstadoPelicula(Usuario usuario, Pelicula pelicula)
        {
            var Userfilter = Builders<BsonDocument>.Filter.Eq("_id", usuario._id);

            var Abandonadafilter = Builders<BsonDocument>.Filter.Eq("abandonada", pelicula._id);
            var Completadafilter = Builders<BsonDocument>.Filter.Eq("completada", pelicula._id);
            var Planeadafilter = Builders<BsonDocument>.Filter.Eq("planeada", pelicula._id);
            var Viendofilter = Builders<BsonDocument>.Filter.Eq("viendo", pelicula._id);

            if (GetCollection("Usuarios").Aggregate().Match(Userfilter).Match(Abandonadafilter).ToEnumerable().Count() > 0)
            {
                return Enums.EstadosPelicula.ABANDONADA;
            }
            else if (GetCollection("Usuarios").Aggregate().Match(Userfilter).Match(Completadafilter).ToEnumerable().Count() > 0)
            {
                return Enums.EstadosPelicula.TERMINADA;
            }
            else if (GetCollection("Usuarios").Aggregate().Match(Userfilter).Match(Planeadafilter).ToEnumerable().Count() > 0)
            {
                return Enums.EstadosPelicula.PLANEADA;
            }
            else if (GetCollection("Usuarios").Aggregate().Match(Userfilter).Match(Viendofilter).ToEnumerable().Count() > 0)
            {
                return Enums.EstadosPelicula.VIENDO;
            }
            else
            {
                return Enums.EstadosPelicula.NO_AGREGADA;
            }
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

        internal async void CrearReparto(Reparto reparto)
        {
            await GetCollection("Reparto").InsertOneAsync(reparto.ToBsonDocument());
        }

        internal async void ActualizarReparto(Reparto reparto)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", reparto._id);

            await GetCollection("Reparto").ReplaceOneAsync(filter, reparto.ToBsonDocument());
        }

        internal async void EliminarReparto(Reparto reparto)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", reparto._id);

            await GetCollection("Reparto").DeleteOneAsync(filter);
        }


    }
}
