/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 02/05/2024
 * Hora: 21:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of gerente.
	/// </summary>
	public class gerente
	{
		//visiubilidad de los atrib son  private
		private string nombre;
		private char genero;
		private int CI;
		private int celular;
		public gerente()
		{
			nombre="pedro";
			genero='M';
			CI=12345;
			celular=77777777;
		}
		//la visibilidad de los meytodos son publicos
		public void Leer(){
			Console.Write("ingreser nombre:::");
			nombre=Console.ReadLine();
				Console.Write("ingreser genero:::");
				genero=char.Parse(Console.ReadLine());
				
				Console.Write("ingreser cedula de identidad:::");
				CI=int.Parse(Console.ReadLine());
				Console.Write("ingreser numero de clular:::");
				celular=int.Parse(Console.ReadLine());
			
		}
		
		public void Mostrar(){
		Console.WriteLine("mostrando datos de gerente:::");
		Console.WriteLine("nombre:::"+nombre);
		Console.WriteLine("cedula de identidad:::"+CI);
		Console.WriteLine("genero:::"+genero);
		Console.WriteLine("numero de celular:::"+celular);
		
		}
			public string getnombre(){
			return nombre;
		}
		
		public void setnombre(string nombre){
			this.nombre=nombre;
		}
		
			public char getgenero(){
			return genero;
		}
		
		public void setgenero(char genero){
			this.genero=genero;
		}
		
			public  int getCI(){
			return CI;
		}
		
		public void setCI(int CI){
			this.CI=CI;
		}
		
		public  int getcel(){
			return celular;
		}
		
		public void setcel(int celular){
			this.celular=celular;
		}
		
		//b) segunda forma
		public bool BuscarGerente2da(){
			bool aux=false;// como estamos usando el bool cambiar el void por bool
			Console.Write("ingrese el nombre del gerente::::");
			string x=Console.ReadLine().ToLower();
			if(nombre.ToLower().Equals(x)){
				Console.WriteLine("celular del gerente es:::::"+celular);
				aux=true;
			}
			return aux;
			
		}
	}
}
