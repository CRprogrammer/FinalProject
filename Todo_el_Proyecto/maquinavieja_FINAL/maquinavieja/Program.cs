using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace maquinavieja
{
    class Program
    {
        static void Main(string[] args)
        {
            archivo fac = new archivo();
            string cupos = "";
            string Pelicula1 = "Batman v Superman";
            string Pelicula2 = "Divergente : leal";
            string Pelicula3 = "Milagros del Cielo";
            string Pelicula4 = "Zootopia";
            string Pelicula5 = "Kung fu Panda 3";
            string Seleccion = "";
            string Cobrar = "";
            string silla = "";
            string selecionMenu = "";
            int uno = 5000;
            int dos = 7000;
            int tres = 10000;
            int diaUno = 1000;
            int diaDos =2000;
            int diaTres = 3000;
            Filas asientos1 = new Filas();
            asientos1.llenar();
            Filas asientos2 = new Filas();
            asientos2.llenar();
            Filas asientos3 = new Filas();
            asientos3.llenar();
            Filas asientos4 = new Filas();
            asientos4.llenar();
            Filas asientos5 = new Filas();
            asientos5.llenar();
            int pro = 0;
            string sql;
            string conexion = "Data Source=JAMES\\SQLEXPRESS;" +
                              "Initial Catalog=Cinee;" +
                              "Integrated Security=True;"
                               ;
            DataTable dt = new DataTable();
            sql = "select " +
                "pelicula" + " as 'Pédula'," +
                "titulo" + " as Titulo," +
                "duracion" + " as Duracion," +
                "horarios" + " as Horario," +
                "actores" + " as Actores," +
                "categoria" + " as Categoria," +
                 "idioma" + " as Idioma," +
                "sinopsis" + " as 'Sinopsis'" +
                " from " +
                "peliculas";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            Pelicula1 = dt.Rows[0][1].ToString();
            Pelicula2 = dt.Rows[1][1].ToString();
            Pelicula3 = dt.Rows[2][1].ToString();
            Pelicula4 = dt.Rows[3][1].ToString();
            Pelicula5 = dt.Rows[4][1].ToString();
            
            
            
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("                 Menu");
          
            
          
           
                    Console.WriteLine("//////////////////////////////////////////////");
                    Console.WriteLine("Pelicula                " + "Codigo de pelicula");
                    Console.WriteLine(Pelicula1 + "                1");
                    Console.WriteLine(Pelicula2 + "                   2");
                    Console.WriteLine(Pelicula3 + "                3");
                    Console.WriteLine(Pelicula4 + "        4");
                    Console.WriteLine(Pelicula5 + "                          5");
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
            Console.WriteLine("Seleccione asientos");
            switch(Seleccion)
            {
                case "1":
                    for (int i = 1; i <= 321;)
                    {
                        Console.Write(" " + asientos1.fila[i] + " ");
                        i++;
                    }
                    int salir = 0;
                    string afuera = "";
                    while (salir!=1)
                    {
                        Console.WriteLine("Seleccione numero de Tipo de sala");
                        
                        silla = Console.ReadLine();
                        cupos += " " + silla;
                        asientos1.cambiar(int.Parse(silla));
                        Console.WriteLine("pasa salir esbribe salir , si quieres selecionar mas preciona 0");
                        afuera = Console.ReadLine();
                        if(afuera == "salir")
                        {
                            salir = 1;
                        }
                    }
                    
                    fac.GuardarArchivo(Pelicula1 + " " + cupos + "  "+  uno);
                        break;
                case "2":
                    for (int i = 1; i <= 321;)
                    {
                        Console.Write(" " + asientos2.fila[i] + " ");
                        i++;
                    }
                    int salir2 = 0;
                    string afuera2 = "";
                    while (salir2 != 1)
                    {
                        Console.WriteLine("Seleccione numero de Tipo de sala");

                        silla = Console.ReadLine();
                        fac.GuardarArchivo(Pelicula2 + " " + cupos + "  " + uno);
                        asientos2.cambiar(int.Parse(silla));
                        Console.WriteLine("pasa salir esbribe salir , si quieres selecionar mas preciona 0");
                        afuera2 = Console.ReadLine();
                        if (afuera2 == "salir")
                        {
                            salir2 = 1;
                        }
                    }
                    break;
                case "3":
                    for (int i = 1; i <= 321;)
                    {
                        Console.Write(" " + asientos3.fila[i] + " ");
                        i++;
                    }
                    int salir3 = 0;
                    string afuera3 = "";
                    while (salir3 != 1)
                    {
                        Console.WriteLine("Seleccione numero de Tipo de sala");

                        silla = Console.ReadLine();
                        fac.GuardarArchivo(Pelicula3 + " " + cupos + "  " + uno);
                        asientos3.cambiar(int.Parse(silla));
                        Console.WriteLine("pasa salir esbribe salir , si quieres selecionar mas preciona 0");
                        afuera3 = Console.ReadLine();
                        if (afuera3 == "salir")
                        {
                            salir3 = 1;
                        }
                    }
                    break;
                case "4":
                    for (int i = 1; i <= 321;)
                    {
                        Console.Write(" " + asientos4.fila[i] + " ");
                        i++;
                    }
                    int salir4 = 0;
                    string afuera4 = "";
                    while (salir4 != 1)
                    {
                        Console.WriteLine("Seleccione numero de Tipo de sala");

                        silla = Console.ReadLine();
                        fac.GuardarArchivo(Pelicula4 + " " + cupos + "  " + uno);
                        asientos4.cambiar(int.Parse(silla));
                        Console.WriteLine("pasa salir esbribe salir , si quieres selecionar mas preciona 0");
                        afuera4 = Console.ReadLine();
                        if (afuera4 == "salir")
                        {
                            salir4 = 1;
                        }
                    }
                    break;
                case "5":
                    for (int i = 1; i <= 321;)
                    {
                        Console.Write(" " + asientos5.fila[i] + " ");
                        i++;
                    }
                    int salir5 = 0;
                    string afuera5 = "";
                    while (salir5 != 1)
                    {
                        Console.WriteLine("Seleccione numero de Tipo de sala");

                        silla = Console.ReadLine();
                        fac.GuardarArchivo(Pelicula5 + " " + cupos + "  " + uno);
                        asientos5.cambiar(int.Parse(silla));
                        Console.WriteLine("pasa salir esbribe salir , si quieres selecionar mas preciona 0");
                        afuera5 = Console.ReadLine();
                        if (afuera5 == "salir")
                        {
                            salir5 = 1;
                        }
                    }
                    break;
            }
            

           
        
            Console.ReadKey();
        }
}
}