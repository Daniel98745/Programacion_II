/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 21/05/2024
 * Hora: 20:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Garaje.
	/// </summary>
	public class Garaje
	{
		private int capacidad;
		private string horario;
		private int cant_Camiones;
		private Camion []C;
		private int cant_Vagonetas;
		private Vagoneta []V;
		public Garaje(Camion c, Vagoneta v){
			capacidad = 10;
			horario = "8:00 a 22:00";
			cant_Camiones=1;
			C = new Camion[cant_Camiones];
			for(int i=0;i<C.Length;i++)
				C[i]=c;
			cant_Vagonetas=1;
			V=new Vagoneta[cant_Vagonetas];
			for(int i=0;i<V.Length;i++)
				V[i]=v;
 		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE GARAJE --");
			Console.WriteLine("ingrese capacidad: ");
			capacidad =int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese horario: ");
			horario =Console.ReadLine();
			Console.WriteLine("Ingrese cantidad de camiones: ");
			cant_Camiones=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Camiones;i++)
				C[i].Leer();
			Console.WriteLine("Ingrese cantidad de vagonetas: ");
			cant_Vagonetas=int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Vagonetas;i++)
				V[i].Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE GARAJE --");
			Console.WriteLine("Capacidad= "+capacidad);
			Console.WriteLine("Horario= "+horario);
			Console.WriteLine("Cantidad de Camiones= "+cant_Camiones);
			for(int i=0;i<cant_Camiones;i++)
				C[i].Mostrar();
			Console.WriteLine("Cantidad de Vagonetas= "+cant_Vagonetas);
			for(int i=0;i<cant_Vagonetas;i++)
				V[i].Mostrar();
		}
		public int getCapacidad(){
			return capacidad;
		}
		public void setCapacidad(int capacidad){
			this.capacidad = capacidad;
		}
		public string getHorario(){
			return horario;
		}
		public void setHorario(string horario){
			this.horario = horario;
		}
		public int getCantCamionetas(){
			return cant_Camiones;
		}
		public void setCantCamionetas(int cant_Camiones){
			this.cant_Camiones = cant_Camiones;
		}
		public int getCantVagonetas(){
			return cant_Vagonetas;
		}
		public void SetCantVagonetas(int cant_Vagonetas){
			this.cant_Vagonetas = cant_Vagonetas;
		}
		public Camion[] getCAMION(){
			return C;
		}
		public void setCAMION(Camion[] C){
			this.C=C;
		}
		public Vagoneta[] getVAGONETA(){
			return V;
		}
		public void setCAMION(Vagoneta[] V){
			this.V=V;
		}
		//a)2da forma
		public void buscarvagoneta2(){
			Console.Write("\n Ingrese placa de la vagoneta a buscar: ");
			string x= Console.ReadLine();
			for(int i=0;i<cant_Vagonetas;i++)
				V[i].buscarVagneta1(x);
		}
		//b) 2da forma
		public void cambiarAmbiente3(){
			Console.Write("\nIngrese ambiente a buscar: ");
			string x=Console.ReadLine();
			for(int i=0;i<cant_Camiones;i++){
				C[i].cambiarAmbiente2(x);
			}
		}
		//c 2da forma
		public void modificarModelo3(){
			Console.Write("\nIngrese potencia a buscar: ");
			double x=double.Parse(Console.ReadLine());
			for(int i=0;i<cant_Vagonetas;i++){
				V[i].modificarModelo2(x);
			}
		}
		//d) 2da forma parte 3
		public void buscarPlaca3(){
			Console.Write("\nIngrese placa a buscar: ");
			string x = Console.ReadLine();
			for(int i=0; i<cant_Vagonetas;i++){
				V[i].buscarPlaca2(x);
			}
			for(int i=0;i<cant_Camiones;i++){
				V[i].buscarPlaca2(x);
			}
		}
	}
}
