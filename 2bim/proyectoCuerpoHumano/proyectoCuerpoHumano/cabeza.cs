/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 25/04/2024
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoCuerpoHumano
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class cabeza
	{
		private  string forma;
		private  string colorPelo;
		private  string colorOjos;
		private  string formaNariz;
		public cabeza()
		{
			forma = "redonda";
			colorOjos = "cafe";
			colorPelo = "negro";
			formaNariz = "agileña";
			
		}
		public void leer(){
			Console.WriteLine("------  datos de cabeza ------");
			
			Console.WriteLine(" ingrese forma de cabeza ");
			forma = Console.ReadLine();
			Console.WriteLine(" ingrese el color de pelo: ");
			colorPelo = Console.ReadLine();
			Console.WriteLine(" ingrese el color de ojos: ");
			colorOjos = Console.ReadLine();
			Console.WriteLine(" ingrese la forma de nariz: ");
			formaNariz = Console.ReadLine();
		}
		public void mostra(){
			Console.WriteLine("------  Mostrar datos de cabeza ------");
			
			Console.WriteLine("forma de cabeza  = "+forma);
			Console.WriteLine("color de pelo  = "+colorPelo);
			Console.WriteLine("color de ojos  = "+colorOjos);
			Console.WriteLine("forma de nariz  = "+formaNariz);
		}
		public string getforma(){
			return forma;
		}
		
		public void setforma(string forma){
			this.forma=forma;
		}
		
		public string getcolorOjos(){
			return colorOjos;
		}
		
		public void setcolorOjos(string colorOjos){
			this.colorOjos=colorOjos;
		}
		
		public string getcolorPelo(){
			return colorPelo;
		}
		
		public void setcolorPelo(string colorPelo){
			this.colorPelo=colorPelo;
		}
		
		public string getcofomaNariz(){
			return formaNariz;
		}
		
		public void setformaNariz(string formaNariz){
			this.formaNariz=formaNariz;
		}
		
	}
}
