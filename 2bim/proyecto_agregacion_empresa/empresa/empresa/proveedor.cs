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
	/// Description of proveedor.
	/// </summary>
	public class proveedor
	{
		private string nombre;
		private long NIT;
		private string producto;
		public proveedor()
		{
			nombre="jh";
			NIT=123456;
			producto="mouse";
			
			
		}
		public void Leer(){
			Console.Write("ingrese el nombre del proveedor:::::::");
			nombre=Console.ReadLine();
			Console.Write("ingrese nel nit del proveedor::::");
			NIT=long.Parse(Console.ReadLine());
			Console.Write("ingrese nombre del prosucto");
			producto=Console.ReadLine();
		
		
		}
		
		public void Mostrar(){
			Console.WriteLine("mostrando notas de proveedor:::::::");
				Console.WriteLine("nombre prov:::::::"+nombre);
				Console.WriteLine("NIT:::::::"+NIT);
					Console.WriteLine("producto:::::::"+producto);
		
		}
		
			public string getnombre(){
			return nombre;
		}
		
		public void setnombre(string nombre){
			this.nombre=nombre;
		}
		
		
			public  long getNIT(){
			return NIT;
		}
		
		public void setNIT(long NIT){
			this.NIT=NIT;
		}
		
			public string getproducto(){
			return producto;
		}
		
		public void setproducto(string producto){
			this.producto=producto;
		}
		
	
	}
}
