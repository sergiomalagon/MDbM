using MongoDB.Bson;

namespace MDbM.UI.Clases
{
    class Pelicula
    {
        public ObjectId _id { get; set; }

        public int año { get; set; }

        public ObjectId[] director { get; set; }

        public string portada { get; set; }

        public ObjectId[] reparto { get; set; }

        public double valoracion { get; set; }

        public string descripcion { get; set; }

        public string titulo { get; set; }

        public string[] generos { get; set; }

    }
}
