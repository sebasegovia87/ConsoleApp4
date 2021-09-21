using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios1 E = new Ejercicios1();
            
            
            E.AgregarFrutas();
            E.EliminarFruta();
            E.MostrarFrutas(E.Frutas);
            Console.WriteLine("el menor precio de la fruta es {0}", E.Devolvermenorprecio());
            Console.WriteLine("el mayor precio de la fruta es {0}", E.Devolvermayorprecio());
            E.Obtenercountdestock();
            E.OrdenadaPorNombreAscStockDesc();
            E.MostrarFrutas(E.Frutas);
            E.Ordenadaporordenasc();
            E.MostrarFrutas(E.Frutas);
            Console.WriteLine("presione enter para salir...");
            Console.ReadLine();
            



        }
    }
}