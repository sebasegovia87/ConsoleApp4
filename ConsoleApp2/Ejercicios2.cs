using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Ejercicios2
    {
        List<Fruta> Frutas = new List<Fruta>();
        public void EsribirCount()
        {
            Console.WriteLine("la lista contiene {0} elementos", Frutas.Count);
        }

        public void Agregarfrutas()
        {
            Fruta manzana = new Fruta(1, "manzana", 10, 70.00f);
            Fruta pera = new Fruta(2, "pera", 20, 40.00f);
            Fruta frutilla = new Fruta(3, "frutilla", 30, 100.00f);
            Frutas.Add(manzana);
            Frutas.Add(pera);
            Frutas.Add(frutilla);
            Console.WriteLine("se agregaron las frutas.");

        }
        public void EliminarElementoporindice(int indice)
        {
            Frutas.RemoveAt(indice);
            Console.WriteLine("se eliminaron los elementos con indice {0}", indice);
        }
        public void Mostrarfrutas()
        {
            string Lista = "";
            foreach (Fruta F in Frutas)
            {
                Lista += F.ToString() + System.Environment.NewLine;
            }
            Console.WriteLine(Lista);

        }

    }
}
