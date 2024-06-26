using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_dispensables
{
    // Clase Restaurante con código duplicado y muerto
    public class Restaurante
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();
        public List<Platillo> Menu { get; set; } = new List<Platillo>();

        // Código duplicado en métodos para agregar meseros y cocineros
        public void AgregarMesero(string nombre)
        {
            Empleados.Add(new Mesero { Nombre = nombre });
        }

        public void AgregarCocinero(string nombre)
        {
            Empleados.Add(new Cocinero { Nombre = nombre });
        }

        // Código duplicado en métodos de generación de reportes
        public void GenerarReporteMeseros()
        {
            Console.WriteLine("Meseros:");
            foreach (var empleado in Empleados)
            {
                if (empleado is Mesero)
                {
                    Console.WriteLine($"- {empleado.Nombre}");
                }
            }
        }

        public void GenerarReporteCocineros()
        {
            Console.WriteLine("Cocineros:");
            foreach (var empleado in Empleados)
            {
                if (empleado is Cocinero)
                {
                    Console.WriteLine($"- {empleado.Nombre}");
                }
            }
        }

        // Especulación innecesaria
        public void MetodoFuturo()
        {
            // Código para una posible futura característica
        }

        // Comentarios excesivos
        public void GenerarReporteMenu()
        {
            // Imprimir el menú del restaurante
            Console.WriteLine("Menú:");
            foreach (var platillo in Menu)
            {
                // Imprimir cada platillo
                Console.WriteLine($"- {platillo.Nombre}: ${platillo.Precio}");
            }
        }
    }
}
