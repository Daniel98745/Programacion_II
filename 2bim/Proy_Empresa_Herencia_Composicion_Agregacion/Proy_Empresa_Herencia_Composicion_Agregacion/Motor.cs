/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 14/05/2024
 * Hora: 20:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Motor.
	/// </summary>
	public class Motor
	{
		private string modelo;
		private double peso;
		private double potencia;
		public Motor(){
			modelo="F10A";
			peso=350;//en kg
			potencia=50;
		}
		public void Leer(){
			Console.WriteLine("\n-- DATOS DE MOTOR --");
			Console.Write("Ingrese modelo: ");
			modelo=Console.ReadLine();
			Console.Write("Ingrese peso en kg: ");
			peso=double.Parse(Console.ReadLine());
			Console.Write("Ingrese potencia: ");
			potencia=double.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE MOTOR --");
			Console.WriteLine("Modelo= "+modelo);
			Console.WriteLine("Peso= "+peso+" Kg");
			Console.WriteLine("Potencia= "+potencia+" RPM");
		}
		public string getModelo(){
			return modelo;
		}
		public void setModelo(string modelo){
			this.modelo = modelo;
		}
		public double getPeso(){
			return peso;
		}
		public void setPeso(double peso){
			this.peso = peso;
		}
		public double getPotencia(){
			return potencia;
		}
		public void setPotencia(double potencia){
			this.potencia = potencia;
		}
		//c) 2da forma
		public void modificarModelo1(double x){
			Console.Write("\nIngrese nuevo modelo: ");
			modelo=Console.ReadLine();
			Mostrar();
		}
		// d) 2da forma parte 1
		public void buscarPlaca1(string x){
			Console.Write("\nIngrese nuevo modelo: ");
			modelo=Console.ReadLine();
			Mostrar();
		}
	}
}
