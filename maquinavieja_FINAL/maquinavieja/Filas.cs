using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinavieja
{
    class Filas
    {
       public  int[] fila;
        public Filas()
        {
           fila = new int[322];
        }
        public void llenar ()
        {
            for(int i = 1; i<= 321;  )
            {
                fila[i] = i;
                i++;
            }

        }
        public void cambiar(int x)
        {
            for (int i = 1; i <= 321;)
            {
                if(fila[i] == x)
                {
                    fila[i] = 0;
                }
                
                i++;
            }
        }

    }
}
