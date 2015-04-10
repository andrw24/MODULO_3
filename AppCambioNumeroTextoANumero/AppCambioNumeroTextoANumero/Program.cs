using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCambioNumeroTextoANumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("digite numero en letras:");
            numero = Console.ReadLine();
            switch (numero.ToUpper())
            {
                case "UNO":
                    Console.WriteLine("1");
                    break;
                case "DOS":
                    Console.WriteLine("2");
                    break;
                case "TRES":
                    Console.WriteLine("3");
                    break;
                case "CUATRO":
                    Console.WriteLine("4");
                    break;
                case "CINCO":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Número fuera de rango!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
