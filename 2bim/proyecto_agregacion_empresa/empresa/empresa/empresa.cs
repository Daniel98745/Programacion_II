/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 02/05/2024
 * Hora: 21:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace empresa
{
	/// <summary>
	/// Description of empresa.
	/// </summary>
	public class empresa
	{
		private string nombre;
		private string direccion;
		private gerente G;
		private int nroEmpleado;
		private empleado[] Em;
		private int nro_proveedores;
		private proveedor[] pro;
		
		public empresa(gerente ge,empleado e,proveedor p)// aqui se pones los objetos agregados los objetos ya vienen instanciados en el contructor
		{
			nombre="ITBM";
			direccion="SENKATA";
			G=ge;
			nroEmpleado=2;
			Em=new empleado[nroEmpleado];
			for(int i=0;i< Em.Length;i++)
				Em[i]=e;
			nro_proveedores=3;
			pro=new proveedor[nro_proveedores];
			for(int j=0;j<pro.Length;j++)
				pro[j]=p;
		}
		public void Leer(){
		
			Console.Write("ingrese nombre de la empresa");
			nombre=Console.ReadLine();
			Console.Write("ingrese njombre de la direccio:::::");
			direccion=Console.ReadLine();
			
			G.Leer();
			for(int i=0;i<Em.Length;i++)
				Em[i].Leer();
			for(int i=0;i<pro.Length;i++)
				pro[i].Leer();
			
		}
		public void Mostrar(){
		
			Console.WriteLine("mostrando datos de la empresa");
			Console.WriteLine("nombre:::::"+nombre);
			Console.WriteLine("direccion::::::"+direccion);
			G.Mostrar();
			for(int i=0;i<Em.Length;i++)
				Em[i].Mostrar();
			for(int i=0;i<pro.Length;i++)
				pro[i].Mostrar();
		
		}
		//a) primera forma:::::buscar asl empleado con nombre de empresa x y ci y modificar su turbo
		
		
		public void modturno(){
			Console.Write("ingrese nombre de la empresa");
			string x=Console.ReadLine().ToUpper();
			if(nombre.ToUpper().Equals(x)){
			
			// hay que buscar al empleado de ci
			Console.Write("ingrese CI del empleado a buscar");
			int z=int.Parse(Console.ReadLine());
			for(int i=0; i<Em.Length;i++){
				if(Em[i].getCI().Equals(z)){
				
					Console.Write("ingrese turno a cambiar");
					Em[i].setturno(Console.ReadLine());
					Em[i].Mostrar();
					
				}
			}
			}
		
		}
		
		//a) segunda forma 
		public void buscarnombre(){
		
		Console.Write("ingrese nombre de la empresa");
			string x=Console.ReadLine().ToUpper();
			if(nombre.ToUpper().Equals(x)){
			
			// hay que buscar al empleado de ci
			Console.Write("ingrese CI del empleado a buscar");
			int z=int.Parse(Console.ReadLine());
			for(int i=0; i<Em.Length;i++){
				Em[i].bucarempleado(z);
			}
			}
		
		}
		
		//b) rprimera forma
		public void buscarGerente(){
			Console.Write("ingrese nombre del gerente a buscar");
			string x=Console.ReadLine();
			if(G.getnombre().ToLower().Equals(x.ToLower())){
				Console.WriteLine("celular:::::"+G.getcel());
				Console.WriteLine("dieeccion de la empresa"+direccion);
			
			}else
				Console.Write("no se encontro datos");
		}
		
		
		public void buscgen2da(){
			if(G.BuscarGerente2da())
				Console.WriteLine("direccion de la empresa"+direccion);
			else
				Console.WriteLine("no se encontro nada");
		}
		//c)primera forma
		public void buscarCIempleado(){
			Console.WriteLine("ingrese el CI del empleado");
			int x=int.Parse(Console.ReadLine());//como es vector buscamos por posicion
			for(int i=0;i<nroEmpleado;i++){
				if(Em[i].getCI().Equals(x)){
					Console.WriteLine("ingrese nuevo sueldo:::::");
					Em[i].setsueldo(double.Parse(Console.ReadLine()));
					Em[i].Mostrar();
				}
			}
			
		}
		//c) segunda forma
		public void buscarCIemp2da(){
			Console.Write("\n ingrese ci del empleado:::");
			int x=int.Parse(Console.ReadLine());
			for(int i=0;i<Em.Length;i++){
				Em[i].buscarEmpb(x);
			}
		}
	}
}
