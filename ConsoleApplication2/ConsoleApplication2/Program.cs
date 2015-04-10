using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.WriteLine("Digite las num 1");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite las num 2");
            num2 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
                Console.WriteLine("La diferencia de los dos numeros es:" + (num1 - num2));
            }
            else
            {
                if ((num2 != 0) && (num1==num2))
                {
                    if (num2 > num1)
                    {
                        Console.WriteLine("La suma de los dos numeros es: " + (num1 * num2));
                        Console.WriteLine("La diferencia de los dos numeros es:" + (num1 / num2));
                    }
                    else
                        Console.WriteLine("los numeros son iguales");
                }
                else
                    Console.WriteLine("El numero " + num1 + " no se puede dividir por " + num2);

            }
            Console.ReadLine();
        }
    }
}
