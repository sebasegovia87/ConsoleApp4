using System;

namespace ConsoleApp3
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

        public Fruta(int id, string nombre, int stock, float precio)
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} - {1} - {2} - ${3}",
                Id,
                Nombre,
                Stock,
                Precio
                );
        }
    }
}

