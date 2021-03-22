using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace multihilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo obj = new Ejemplo();

            //crear hilos

            Thread h1 = new Thread(new ThreadStart(obj.Proceso1));
            Thread h2 = new Thread(new ThreadStart(obj.Proceso2));
            Thread h3 = new Thread(new ThreadStart(obj.Proceso3));

            //inicializar hilo
            h1.Start();
            h2.Start();
            h3.Start();

            //cerrar hilos
            h1.Join();
            h2.Join();
            h3.Join();

            Console.ReadKey();


        }
    }
}
