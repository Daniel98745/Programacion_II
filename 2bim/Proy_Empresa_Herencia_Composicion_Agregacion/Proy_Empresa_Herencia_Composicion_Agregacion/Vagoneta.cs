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
	/// Description of Vagoneta.
	/// </summary>
	public class Vagoneta:Vehiculo
	{
		protected string tipo;
		public Vagoneta(Rueda r):base(r){
			tipo="Todo Terreno";
		}
		public void Leer(){
			Console.Write("\n-- DATOS DE VAGONETA --");
			base.Leer();
			Console.Write("Ingrese tipo: ");
			tipo=Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- MOSTRANDO DATOS DE VAGONETA --");
			base.Mostrar();
			Console.WriteLine("Tipo= "+tipo);
		}
		public string getTipo(){
			return tipo;
		}
		public void setTipo(string tipo){
			this.tipo = tipo;
		}
		//a)2da forma
		public void buscarVagneta1(string x){
			if(placa.ToLower().Equals(x.ToLower())){
				Console.Write("\n Ingrese modelo nuevo: ");
				modelo=short.Parse(Console.ReadLine());
				Mostrar();
			}
		}
	}
}
