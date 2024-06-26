using reto_dispensables;

class Program
{
    static void Main()
    {
        Restaurante restaurante = new Restaurante { Nombre = "El Buen Sabor", Direccion = "123 Calle Principal" };
        restaurante.AgregarMesero("Juan");
        restaurante.AgregarCocinero("Carlos");
        restaurante.Menu.Add(new Platillo("Pizza", 10));
        restaurante.Menu.Add(new Platillo("Ensalada", 5));

        restaurante.GenerarReporteMeseros();
        restaurante.GenerarReporteCocineros();
        restaurante.GenerarReporteMenu();
    }
}