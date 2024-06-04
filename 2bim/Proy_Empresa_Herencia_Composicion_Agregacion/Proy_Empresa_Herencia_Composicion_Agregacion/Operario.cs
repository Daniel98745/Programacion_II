/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 16/05/2024
 * Hora: 18:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Operario.
	/// </summary>
	public class Operario:Empleado
	{
		private string turno;
		
		public Operario():base()
		{
			turno = "noche";
		}
		public void Leer(){
			base.Leer();
			Console.Write("\n-- DATOS DE OPERARIO --");
			Console.WriteLine("Ingrese turno de operario: ");
			turno= Console.ReadLine();
		}
		public void Mostrar(){
			base.Mostrar();
			Console.Write("\n-- MOSTRANDO DATOS DE OPERARIO --");
			Console.WriteLine("\nTurno= "+turno);
		}
		public string getTurno(){
			return turno;
		}
		public void setTurno(string turno){
			this.turno = turno;
		}
	}
}
