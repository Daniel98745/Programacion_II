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
	/// Description of Camion.
	/// </summary>
	public class Camion:Vehiculo
	{
		protected double tamaño;
		//agregacion
		private Carga Ca;
		//protected string placa;
		public Camion(Rueda r, Carga c):base(r){
			tamaño=12.5;
			//placa="1234";
			Ca=c;
		}
		public void Leer(){
			Console.Write("\n-- DATOS DE CAMION --");
			base.Leer();
			Console.Write("Ingrese tamaño: ");
			tamaño =double.Parse(Console.ReadLine());
			Ca.Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE CAMION --");
			base.Mostrar();
			Console.WriteLine("tamaño= "+tamaño);
			Ca.Mostrar();
		}
		/*public string getPlaca(){
			return placa;
		}
		public void SetPlaca(string placa){
			this.placa = placa;
		}*/
		public double getTamaño(){
			return tamaño;
		}
		public void setModelo(double tamaño){
			this.tamaño = tamaño;
		}
		public Carga getCARGA(){
			return Ca;
		}
		public void setCARGA(Carga Ca){
			this.Ca=Ca;
		}
		//b) 2da forma
		public void cambiarAmbiente2(string x){
			Ca.cambiarAmbiente1(x);
		}
	}
}
