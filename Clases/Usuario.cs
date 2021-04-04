using MongoDB.Bson;

namespace MDbM.UI.Clases
{
    public class Usuario
    {
        public ObjectId _id { get; set; }

        public string nombre { get; set; }

        public string imagenPerfil { get; set; }

        public string passw { get; set; }

        public int rol { get; set; }

        public ObjectId[] abandonada { get; set; }

        public ObjectId[] completada { get; set; }

        public ObjectId[] planeada { get; set; }

        public ObjectId[] viendo { get; set; }


    }
}
