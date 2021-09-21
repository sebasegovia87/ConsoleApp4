using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Ejercicio1
    {
        List<string> Nombres = new List<string>();

        public void EsribirCount()
        {
            Console.WriteLine("la lista contiene {0} elementos" , Nombres.Count);
            
        }
        public void Agregarelementos()
        {
            Nombres.Add("mariano");
            Nombres.Add("lucia");
            Nombres.Add("pedro");
            Console.WriteLine("se agregaron los elementos");

        }
        public void EliminarElementoporindice(int indice)
        {
            Nombres.RemoveAt(indice);
            Console.WriteLine("se eliminaron los elementos con indice {0}", indice);
        }
        public void EliminarElementopornombre(string nombre)
        {
            Nombres.Remove(nombre);
            Console.WriteLine("se eliminaron los elementos con nombre {0}", nombre);
        }
        public void Mostrarnombres()//nueva forma de mostrar los resultados
        {
            string Lista = "";
            foreach(string Nombre in Nombres)
            {
                Lista += Nombre + System.Environment.NewLine;
            }
            Console.WriteLine(Lista);

        }
    }
}
