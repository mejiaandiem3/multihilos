using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multihilos
{
    class Ejemplo
    {
        public void Proceso1()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Hilo 1="+i);
              
            }
           


        }

        public void Proceso2()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Hilo 2=" + i);

            }

        }

        public void Proceso3()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("Hilo 3=" + i);

            }

        }


    }
}
