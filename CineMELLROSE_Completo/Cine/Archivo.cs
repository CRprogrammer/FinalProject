using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    class Archivo
    {

        
            public void GuardarArchivo(String Texto)
            {
                try
                {

                    string fileName = "C:\\Users\\jesus\\Documents\\Visual Studio 2015\\Projects\\Cine\\Cine\\Facturas.txt";

                   
                    StreamWriter Escribir = File.AppendText(fileName);
                    Escribir.WriteLine(Texto);
                    Escribir.Close();
                }
                catch
                {
                  
                    Console.WriteLine("Error");
                    Console.ReadKey();
                }
            }
        
    }
}
