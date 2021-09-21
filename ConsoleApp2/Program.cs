using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //nombres
            Ejercicio1 E1 = new Ejercicio1();

            E1.EsribirCount();
            E1.Agregarelementos();
            E1.EsribirCount();
            E1.EliminarElementoporindice(0);//indico el indice que quiero borrar.
            E1.EliminarElementopornombre("lucia");//indico el nombre que quiero borrar.
            E1.EsribirCount();
            E1.Mostrarnombres();

            //frutas
            Ejercicios2 E2 = new Ejercicios2();
            E2.EsribirCount();
            E2.Agregarfrutas();
            E2.EliminarElementoporindice(0);
            E2.EsribirCount();
            E2.Mostrarfrutas();
            



            Console.WriteLine("Ingrese enter para salir...");
            Console.ReadLine();

        }
    }
}
