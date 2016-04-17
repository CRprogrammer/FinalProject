using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinavieja
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pelicula1 = "Batman v Superman";
            string Pelicula2 = "Divergente : leal";
            string Pelicula3 = "Milagros del Cielo";
            string Pelicula4 = "Zootopia";
            string Pelicula5 = "Kung fu Panda 3";
            string Seleccion = "";
            string Cobrar = "";
            string selecionMenu = "";
            int uno = 5000;
            int dos = 7000;
            int tres = 10000;
            int diaUno = 1000;
            int diaDos =2000;
            int diaTres = 3000;
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("                 Menu");
          
            
          
           
                    Console.WriteLine("//////////////////////////////////////////////");
                    Console.WriteLine("Pelicula                " + "Codigo de pelicula");
                    Console.WriteLine(Pelicula1 + "                1");
                    Console.WriteLine(Pelicula2 + "                2");
                    Console.WriteLine(Pelicula3 + "               3");
                    Console.WriteLine(Pelicula4 + "                         4");
                    Console.WriteLine(Pelicula5 + "                  5");
                    Console.WriteLine("//////////////////////////////////////////////");
                    Console.WriteLine("Tipo de sala    " + "Codigo  " + "Precio");
                    Console.WriteLine("2D                 1     " + uno);
                    Console.WriteLine("3D                 2     " + dos);
                    Console.WriteLine("4D                 3     " + tres);
                    Console.WriteLine("//////////////////////////////////////////////");
                    Console.WriteLine("Seleccione numero de pelicula");
                    Seleccion = Console.ReadLine();
                    Console.WriteLine("Seleccione numero de Tipo de sala");
                    Cobrar = Console.ReadLine();
                    
                
            Console.ReadKey();
        }
    }
}
