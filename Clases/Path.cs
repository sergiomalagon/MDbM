using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDbM.Clases
{
    public static class Path
    {
        public static string GetFilmCoversPath()
        {
            return "..\\..\\Resources\\FilmCovers\\";
        }

        public static string GetPeoplePath()
        {
            return "..\\..\\Resources\\People\\";
        }

        public static string GetUserPPPath()
        {
            return "..\\..\\Resources\\UserPP\\";
        }

        public static string GenerarUrlImagen(string tipo, string nombre)
        {
            string[] aux = nombre.Split(' ');
            StringBuilder sb = new StringBuilder();
            sb.Append(tipo);
            foreach (string a in aux)
            {
                sb.Append("_");
                sb.Append(a.ToLower());
            }
            return sb.ToString();
        }

        public static string GetCover()
        {
            return "cover";
        }

        public static string GetPeople()
        {
            return "people";
        }

        public static string GetUser()
        {
            return "user";
        }
    }
}
