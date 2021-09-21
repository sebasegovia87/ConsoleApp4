using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Fruta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }

        public Fruta()
        {

        }
        public Fruta(int id, string nombre, int stock, float precio)//escribirlos en minuscula
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;

        }
        public override string ToString()
        {
            //aca le doy el formato de las caracteristicas de la fruta y luego lo completo en ejercicios2
            return string.Format(
                "{0} - {1} - {2} - ${3}",
                Id,
                Nombre,
                Stock,
                Precio);
        }

    }
}
