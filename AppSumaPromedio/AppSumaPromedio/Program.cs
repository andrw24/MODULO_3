using System;

namespace AppSumaPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float a, b, c, d,suma,promedio;
			Console.WriteLine ("Programa que calcula suma y promedio");

			Console.WriteLine ("Introduzca el primer numero");
			a = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el segundo numero");
			b = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el tercer numero");
			c = float.Parse (Console.ReadLine());
			Console.WriteLine ("Introduzca el cuarto numero");
			d = float.Parse (Console.ReadLine());
			suma = a + b + c + d;
			promedio = suma / 4;

			Console.WriteLine ("La suma de los 4 numeros es:"+ suma);
			Console.WriteLine ("El promedio de los 4 numeros es:"+ promedio);

			Console.ReadKey ();

		}
	}
}
