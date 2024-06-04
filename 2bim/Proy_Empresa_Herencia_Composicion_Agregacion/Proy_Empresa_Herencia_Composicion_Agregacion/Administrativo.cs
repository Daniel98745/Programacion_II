/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 16/05/2024
 * Hora: 18:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Administrativo.
	/// </summary>
	public class Administrativo:Empleado
	{
		private string tipo_Admi;
		public Administrativo():base()
		{
			tipo_Admi= "Secretaria";
		}
		public void Leer(){
			base.Leer();
			Console.Write("\n-- DATOS DE ADMINISTRATIVO --");
			Console.WriteLine("Ingrese tipo de administrativo: ");
			tipo_Admi= Console.ReadLine();
		}
		public void Mostrar(){
			base.Mostrar();
			Console.Write("\n-- MOSTRANDO DATOS DE ADMINISTRATIVO --");
			Console.WriteLine("\n Tipo de administrador= "+tipo_Admi);
		}
		public string getTipoAdmi(){
			return tipo_Admi;
		}
		public void setTipoAdmi(string tipo_Admi){
			this.tipo_Admi = tipo_Admi;
		}
	}
}
