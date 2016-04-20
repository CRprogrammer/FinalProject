using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineMellRose
{
    class GlobalParameters
    {
        private static string nombrePelicula = "";
        private static int clasificacionPelicula = 0;
        private static int salaPelicula = 0;
        private static string ubicacionPelicula = "";
        private static string duracionPelicula = "";



        public static string NombrePelicula
        {
            get { return nombrePelicula; }
            set { nombrePelicula = value; }
        }

        public static int ClasificacionPelicula
        {
            get { return clasificacionPelicula; }
            set { clasificacionPelicula = value; }
        }

        public static int SalaPelicula
        {
            get { return salaPelicula; }
            set { salaPelicula = value; }
        }

        public static string UbicacionPelicula
        {
            get { return ubicacionPelicula; }
            set { ubicacionPelicula = value; }
        }

        public static string DuracionPelicula
        {
            get { return duracionPelicula; }
            set { duracionPelicula = value; }
        }

    }
}
