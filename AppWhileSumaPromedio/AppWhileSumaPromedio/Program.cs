using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhileSumaPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad,cont,sum,num,promedio;
            Console.Write("Digite cantidad de valores a ingresar:");
            cantidad = int.Parse(Console.ReadLine());
            cont=1;
            sum=0;

            while(cont<=cantidad)
            {
                Console.WriteLine("Ingrese numero:");
                num=int.Parse(Console.ReadLine());
                sum=sum+num;
                cont=cont+1;
            }

            promedio=sum/cantidad;
            Console.WriteLine("La suma de los valores es: "+sum);
            Console.WriteLine("El promedio de los valores es: "+promedio);
            
            Console.ReadKey();
            }

            
        }
    }

