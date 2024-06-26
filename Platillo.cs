using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_dispensables
{
    // Clase Platillo
    public class Platillo
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Platillo(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
