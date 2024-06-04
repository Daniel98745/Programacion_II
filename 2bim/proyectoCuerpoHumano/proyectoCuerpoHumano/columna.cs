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
	/// Description of columna.
	/// </summary>
	public class columna
	{
		private double tamaño;
		private int norCostillas;
		private int norVertebras;
		
		public columna()
		{
			tamaño = 60.67;
			norCostillas = 24;
			norVertebras = 30;
			
		}
		
		public void leer(){
			Console.WriteLine("------  datos de columana ------");
			Console.WriteLine(" ingrese columna ");
			tamaño = double.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese el numero de costillas: ");
			norCostillas = int.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese el numero de vertebras: ");
			norVertebras = int.Parse(Console.ReadLine());
		}
		public void mostra(){
			Console.WriteLine("------  Mostrar datos de columna ------");
			Console.WriteLine("tamaño = "+tamaño);
			Console.WriteLine("numero de costillas = "+norCostillas);
			Console.WriteLine("numero de vrtebras = "+norVertebras);
		}
		
		public double gettamano(){
			return tamaño;
		}
		
		public void settipo(double tamaño){
			this.tamaño=tamaño;
		}
		
		public int getnorCostillas(){
			return norCostillas;
		}
		
		public void setnorCostillas(int norCostillas ){
			this.norCostillas=norCostillas;
		}
		
		public int getnorVertebras(){
			return norVertebras;
		}
		
		public void setnorVertebreas(int norVertebras ){
			this.norVertebras=norVertebras;
		}
		
		
	}
}
