using System;
using Models;  // Importa las clases del espacio de nombres Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Cotxe (derivado de Vehicle)
        Cotxe vehicle1 = new Cotxe("Model B", "Ferrari", 2022, 290.0, 2);

        // Mostrar la información del primer vehículo
        vehicle1.MostrarInformacio();

        // Crear otro objeto Cotxe (derivado de Vehicle)
        Cotxe vehicle2 = new Cotxe("Classe S", "Mercedes", 2024, 280.0, 4);
        
        // Mostrar la información del segundo vehículo
        vehicle2.MostrarInformacio();
    }
}

