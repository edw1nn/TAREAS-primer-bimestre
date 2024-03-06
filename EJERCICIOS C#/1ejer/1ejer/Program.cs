using System;
namespace PromedioVentasVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de cálculo de promedio de ventas por mes");
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Por favor, ingrese su apellido: ");
            string apellido = Console.ReadLine();

            double totalVentas = 0;
            int numMeses = 0;

            for (int a = 1; a <= 12; a++)
            {
                Console.Write($"Ingrese las ventas para el mes {a}: ");
                double ventasMes;
                if (double.TryParse(Console.ReadLine(), out ventasMes))
                {
                    totalVentas += ventasMes;
                    numMeses++;
                }
                else
                {
                    Console.WriteLine("¡Valor inválido! Por favor, ingrese un número válido.");
                    a--;
                }
            }
            double promedioVentas = totalVentas / numMeses;

            Console.WriteLine();
            Console.WriteLine($"Nombre del vendedor: {nombre} {apellido}");
            Console.WriteLine($"Promedio de ventas por mes: {promedioVentas:F2}");

            Console.ReadLine();
        }
    }
}