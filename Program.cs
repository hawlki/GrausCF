using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Escreva uma medida em graus Celsius(°C): ");
            String medida = Console.ReadLine();
            Double Celsius = Convert.ToDouble(medida);
            Double Fahrenheit = Celsius * 1.8 + 32;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Os {Celsius}°C convertido em Fahrenheit é {Fahrenheit}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clique em uma tecla para finalizar este programa");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
