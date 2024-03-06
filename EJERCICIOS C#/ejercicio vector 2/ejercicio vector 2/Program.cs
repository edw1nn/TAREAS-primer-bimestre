using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de descuentos salariales");
        Console.WriteLine("-----------------------------------");

       
        Console.Write("Ingrese el sueldo base del empleado: ");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        if (sueldoBase >= 3300)
        {
           
            double renta = sueldoBase * 0.10; // 10%
            double afp = sueldoBase * 0.07; // 7%
            double seguroSocial = sueldoBase * 0.05; // 5%

          
            double totalDescuentos = renta + afp + seguroSocial;

           
            double sueldoNeto = sueldoBase - totalDescuentos;

           
            Console.WriteLine("\nResumen de descuentos:");
            Console.WriteLine("Renta (10%): ${0}", renta);
            Console.WriteLine("AFP (7%): ${0}", afp);
            Console.WriteLine("Seguro Social (5%): ${0}", seguroSocial);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total de descuentos: ${0}", totalDescuentos);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sueldo neto: ${0}", sueldoNeto);
        }
        else
        {
            Console.WriteLine("El sueldo es menor a $3300, no se aplican descuentos.");
            Console.WriteLine("Sueldo neto: ${0}", sueldoBase);
        }
    }
}
