using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Kilómetros a Metros, Yardas y Varas");
        Console.WriteLine("-----------------------------------------------");
        Console.Write("Ingrese la cantidad en kilómetros: ");

        double kilometros = Convert.ToDouble(Console.ReadLine());   
        
        double metros = kilometros * 1000;    
        double yardas = kilometros * 1093.61;
        double varas = kilometros * 1196.308;
        
        Console.WriteLine("\nResultados:");
        Console.WriteLine("{0} kilómetros equivalen a {1} metros", kilometros, metros);
        Console.WriteLine("{0} kilómetros equivalen a {1} yardas", kilometros, yardas);
        Console.WriteLine("{0} kilómetros equivalen a {1} varas", kilometros, varas);
        Console.ReadLine(); 
    }
}
