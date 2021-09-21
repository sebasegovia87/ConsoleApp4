using System;

namespace ConsoleApp1
{
    class Program
    {
        string[,] strclase = new string[100, 4];
        string[,] strdocente = new string[50, 3];
        string[,] strmateriasxtitulo = new string[120, 2];
        //no lo pide el parcial, es solo para tener los datos y probar el ej

        public void Actividaddiaria()
        {
            string fecha;
            int fila;
            int ultimafila = strclase.GetLength(0);
            string listado = "";
            int contador = 0;

            Console.WriteLine("ingrese una fecha");
            fecha = Console.ReadLine();

            for (fila = 0; fila < ultimafila; fila++)
            {
                if (fecha == strclase[fila, 2])
                {
                    contador++;
                    listado += strclase[fila, 1] + System.Environment.NewLine;
                }

            }
            Console.WriteLine("la cantidad total de clases fueron: " + contador + " y los nombres de las materias son: " + listado);
        }

    
    }  
}

