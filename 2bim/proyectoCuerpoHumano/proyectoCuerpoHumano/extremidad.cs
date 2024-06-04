/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 25/04/2024
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoCuerpoHumano
{
	/// <summary>
	/// Description of estremidad.
	/// </summary>
	public class extremidad
	{
		private double tamaño;
		private string tipo;
		public extremidad()
		{
			tamaño = 70.34;
			tipo = "superior derecho";
		}
		public void leer(){
			Console.WriteLine("------  datos de extremidad ------");
			Console.WriteLine(" ingrese tamaño ");
			tamaño = double.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese el tipo: ");
			tipo = Console.ReadLine();
		}
		public void mostra(){
			Console.WriteLine("------  Mostrar datos de extremidades ------");
			Console.WriteLine("tamaño = "+tamaño+" cm ");
			Console.WriteLine("tipo = "+tipo);
		}
		
		public string gettipo(){
			return tipo;
		}
		
		public void settipo(string tipo){
			this.tipo=tipo;
		}
		
		public double gettamano(){
			return tamaño;
		}
		
		public void settamano(double tamaño){
			this.tamaño=tamaño;
		}
		
		
	}
}
