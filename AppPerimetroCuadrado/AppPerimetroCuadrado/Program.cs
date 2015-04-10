using System;

namespace AppPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado,perimetro;
			string linea;
			Console.WriteLine ("Programa que calcula el perimetro de un cuadrado");
			Console.WriteLine ("Ingrese el tamaño del lado");
			linea=Console.ReadLine ();
			lado = float.Parse (linea);
			perimetro = lado * 4;
			Console.WriteLine ("El perimetro del cuadrado es:" +perimetro);
			Console.ReadKey ();
		}
	}
}
