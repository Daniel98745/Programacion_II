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
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
	
		protected string marca;
		protected string placa;
		protected short modelo;
		private Motor Mo = new Motor();
		protected short cant_Ruedas;
		private Rueda []Ru;
		public Vehiculo(Rueda r){
			marca = "Toyota";
			placa = "1234HCA";
			modelo = 2024;
			cant_Ruedas = 4;
			Ru=new Rueda[cant_Ruedas];
			for(int i=0;i<cant_Ruedas;i++)
				Ru[i]=r;
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE VEHICULO --");
			Console.WriteLine("Ingrese marca: ");
			marca=Console.ReadLine();
			Console.WriteLine("Ingrese placa: ");
			placa=Console.ReadLine();
			Console.WriteLine("Ingrese modelo: ");
			modelo= short.Parse(Console.ReadLine());
			Mo.Leer();
			Console.WriteLine("Ingrese cantidad de ruedas: ");
			cant_Ruedas= short.Parse(Console.ReadLine());
			for (int i=0; i<cant_Ruedas;i++)
				Ru[i].Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE VEHICULO --");
			Console.WriteLine("Marca= "+marca);
			Console.WriteLine("Placa= "+placa);
			Console.WriteLine("Modelo= "+modelo);
			Mo.Mostrar();
			Console.WriteLine("Cantidad de ruedas= "+cant_Ruedas);
			for (int i=0; i<cant_Ruedas;i++)
				Ru[i].Mostrar();
		}
		public string getMarca(){
			return marca;
		}
		public void setMarca(string marca){
			this.marca = marca;
		}
		public string getPlaca(){
			return placa;
		}
		public void setPlaca(string placa){
			this.placa = placa;
		}
		public short getModeloV(){
			return modelo;
		}
		public void setModeloV(short modelo){
			this.modelo = modelo;
		}
		//retornar el objeto motor
		public Motor getMOTOR(){
			return Mo;
		}
		public void setMOTOR(Motor Mo){
			this.Mo=Mo;
		}
		//retornar el objeto rueda
		public Rueda[] getRUEDA(){
			return Ru;
		}
		public void setRUEDA(Rueda[] Ru){
			this.Ru=Ru;
		}
		//C) 2da forma
		public void modificarModelo2(double x){
			Mo.modificarModelo1(x);
		}
		//d) 2da forma parte 2
		public void buscarPlaca2(string x){
			Mo.buscarPlaca1(x);
 			Console.Write("\nIngrese nuevo modelo del vehiculo: ");
			modelo =short.Parse(Console.ReadLine());
			Mostrar();
		}
	}
}

