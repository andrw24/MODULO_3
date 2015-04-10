using System;

namespace AppSumaProducto
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float a, b, c, d,suma,producto;
			Console.WriteLine ("Programa que calcula la suma de 2 numeros y el producto de 2 numeros");

			Console.WriteLine ("Introduzca el primer numero");
			a = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el segundo numero");
			b = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el tercer numero");
			c = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el cuarto numero");
			d = float.Parse (Console.ReadLine());
			suma = a + b ;
			producto = c * d;

			Console.WriteLine ("La suma de los 2 primeros numeros es:"+ suma);
			Console.WriteLine ("El producto de los 2 ultimos numeros es:"+ producto);

			Console.ReadKey ();
		}
	}
}
