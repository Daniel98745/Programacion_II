/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private string nombre;
		private string direccion;
		private long nit;
		private int cant_Admi;
		private Administrativo []Ad;
		private int cant_Op;
		private Operario []Op;
		private int cant_cli;
		private Cliente []Cli;
		
		private Garaje g;
		
		public Empresa(Administrativo a, Operario o, Cliente c){
			nombre="ABC";
			direccion="Av. Circunvalacion";
			nit=123456;
			
			cant_Admi=2;
			Ad=new Administrativo[cant_Admi];
			for(int i=0;i<cant_Admi;i++)
				Ad[i]=a;
			
			cant_Op=1;
			Op = new Operario[cant_Op];
			for(int i=0;i<cant_Op;i++)
				Op[i]=o;
			
			cant_cli=3;
			Cli=new Cliente[cant_cli];
			for(int i=0;i<cant_cli;i++)
				Cli[i]=c;
			
			
			Rueda ru = new Rueda();
		 	Carga car = new Carga();
		 	Camion ca = new Camion(ru,car);
			Vagoneta va = new Vagoneta(ru);
			g = new Garaje(ca,va);
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE EMPRESA --");
			Console.Write("Ingrese nombre de la empresa: ");
			nombre=Console.ReadLine();
			Console.Write("Ingrese direccion: ");
			direccion=Console.ReadLine();
			Console.Write("Ingrese nit: ");
			nit=long.Parse(Console.ReadLine());
			Console.Write("Ingrese cantiad de administrativos: ");
			cant_Admi=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de operarios: ");
			cant_Op=int.Parse(Console.ReadLine());
			Console.Write("Ingrese cantidad de clientes: ");
			cant_cli=int.Parse(Console.ReadLine());
			
			for(int i=0;i<cant_Admi;i++)
				Ad[i].Leer();
			Console.WriteLine("Cant de Operarios: ");
			for(int i=0;i<cant_Op;i++)
				Op[i].Leer();
			Console.WriteLine("Cant de Clientes: ");
			for(int i=0;i<cant_cli;i++)
				Cli[i].Leer();
			g.Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n--MOSTRANDO DATOS DE EMPRESA --");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("NIT= "+nit);
			Console.WriteLine("Cant de Administrativos= "+cant_Admi);
			for(int i=0;i<cant_Admi;i++)
				Ad[i].Mostrar();
			Console.WriteLine("Cant de Operarios= "+cant_Op);
			for(int i=0;i<cant_Op;i++)
				Op[i].Mostrar();
			Console.WriteLine("Cant de Clientes= "+cant_cli);
			for(int i=0;i<cant_cli;i++)
				Cli[i].Mostrar();
			g.Mostrar();
		}
		//a)1ra forma
		public void buscarVagoneta(){
			Console.Write("\n Ingrese placa de la vagoneta a buscar: ");
			string x = Console.ReadLine().ToLower();
			for (int i=0;i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getPlaca().ToLower().Equals(x)){
					Console.WriteLine("Ingrese nuevo modelo: ");
					g.getVAGONETA()[i].setModeloV(short.Parse(Console.ReadLine()));
					g.getVAGONETA()[i].Mostrar();
				}
			}
		}
		//a)2da forma
		public void buscarVagoneta3(){
			g.buscarvagoneta2();
		}
		//b) 1ra forma
		public void cambiarAmbiente(){
			Console.Write("\nIngrese ambiente de la carga a buscar: ");
			string x = Console.ReadLine().ToLower();
			for(int i=0; i<g.getCantCamionetas();i++){
				if(g.getCAMION()[i].getCARGA().getAmbiente().ToLower().Equals(x)){
					Console.Write("\nIngrese nuevo ambiente: ");
					string aux=Console.ReadLine();
					g.getCAMION()[i].getCARGA().setAmbiente(aux);
					g.getCAMION()[i].getCARGA().Mostrar();
				}
			}
		}
		//2da forma
		public void cambiarAmbiente4(){
			g.cambiarAmbiente3();
		}
		//c) 1ra forma
		public void modificarModelo(){
			Console.Write("\nIngrese potencia a buscar: ");
			double x= double.Parse(Console.ReadLine());
			for(int i=0;i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getMOTOR().getPotencia().Equals(x)){
					Console.Write("Ingrese nuevo modelo: ");
					g.getVAGONETA()[i].getMOTOR().setModelo(Console.ReadLine());
					g.getVAGONETA()[i].getMOTOR().Mostrar();
				}
			}
		}
		//c) 2da forma
		public void modificarModelo4(){
			g.modificarModelo3();
		}
		//d) 1ra forma
		public void modificarVehiculos(){
			Console.Write("\nIngrese placa a buscar: ");
			string x =Console.ReadLine().ToUpper();
			for(int i=0; i<g.getCantVagonetas();i++){
				if(g.getVAGONETA()[i].getPlaca().Equals(x)){
					Console.Write("\nIngrese nuevo modelo del motor: ");
					g.getVAGONETA()[i].getMOTOR().setModelo(Console.ReadLine());
					g.getVAGONETA()[i].getMOTOR().Mostrar();
					Console.Write("\nIngrese nuevo modelo del vehiculo: ");
					g.getVAGONETA()[i].setModeloV(short.Parse(Console.ReadLine()));
					g.getVAGONETA()[i].Mostrar();
				}
			}
			for(int i=0; i<g.getCantCamionetas();i++){
				if(g.getCAMION()[i].getPlaca().Equals(x)){
					Console.Write("\nIngrese nuevo modelo del motor: ");
					g.getCAMION()[i].getMOTOR().setModelo(Console.ReadLine());
					g.getCAMION()[i].getMOTOR().Mostrar();
					Console.Write("\nIngrese nuevo modelo del vehiculo: ");
					g.getCAMION()[i].setModeloV(short.Parse(Console.ReadLine()));
					g.getCAMION()[i].Mostrar();
				}
			}
		}
		//d) 2da forma parte 4
		public void buscarPlaca4(){
			g.buscarPlaca3();
		}
	}
}
