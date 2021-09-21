using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Ejercicios1
    {
        public List<Fruta> Frutas = new List<Fruta>();

        public void AgregarFrutas()
        {
            Fruta Manzana = new Fruta(1, "Manzana", 0, 70.00f);
            Fruta Pera = new Fruta(2, "Pera", 30, 90.00f);
            Fruta Frutilla = new Fruta(3, "Frutilla", 40, 50.00f);

            Frutas.Add(Manzana);
            Frutas.Add(Pera);
            Frutas.Add(Frutilla);

            Console.WriteLine("Se agregaron las frutas.");
        }
        public Fruta BuscarFruta(string nombre)
        {
            return Frutas.Find(F => F.Nombre == nombre);

        }
        public void EliminarFruta()
        {
            string nombre;

            Console.Write("ingrese el nombre de la fruta a eliminar: ");
            nombre = Console.ReadLine();
            
            Fruta F = BuscarFruta(nombre);
            
            if (F == null)
            {
                Console.WriteLine("no existe la fruta.");
            }
            else
            {
                Frutas.Remove(F);
                Console.WriteLine("se elimino la fruta {0}", nombre);
            }
        }
        public float Devolvermenorprecio()
        {
            return Frutas.Min(F => F.Precio);
        }
        public float Devolvermayorprecio()
        {
            return Frutas.Max(F => F.Precio);
        }
        public int Obtenercountdestock()
        {
            return Frutas.Count(F => F.Stock > 0);
        }
        public void OrdenadaPorNombreAscStockDesc()//ordeno por 2 formas a la vez nombre y stock
        {
            Frutas = Frutas.OrderBy(F => F.Nombre).ThenByDescending(F => F.Stock).ToList();
        }
        public void MostrarFrutas(List<Fruta> Lista)
        {
            string Acumulador = "";

            foreach (Fruta F in Lista)
            {
                Acumulador += F.ToString() + System.Environment.NewLine;
            }

            Console.WriteLine(Acumulador);
        }
        public void Ordenadaporordenasc()//se va a utilizar
        {
            Frutas = Frutas.OrderBy(F => F.Nombre).ToList();
        }

    }
}
