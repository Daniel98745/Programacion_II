/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 16/05/2024
 * Hora: 18:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
		private string apellido;
		private int CI;
		private short edad;
		private char genero;
		private string nacionalidad;
		private int telefono;
		public Persona(){
			nombre="Richard";
			apellido="Perez";
			CI= 888888;
			edad= 35;
			genero= 'M';
			nacionalidad = "Bolivia";
			telefono = 12345;
		}
		public void Leer(){
			Console.Write("\n-- DATOS DE PERSONA --");
			Console.WriteLine("Ingrese nombre: ");
			nombre= Console.ReadLine();
			Console.WriteLine("Ingrese apellido: ");
			apellido= Console.ReadLine();
			Console.WriteLine("Ingrese CI: ");
			CI=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese edad: ");
			edad=short.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese genero: ");
			genero=char.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese nacionalidad: ");
			nacionalidad= Console.ReadLine();
			Console.WriteLine("Ingrese telefono: ");
			telefono=int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.Write("\n-- MOSTRANDO DATOS DE PERSONA --");
			Console.WriteLine("\nNombre= "+nombre);
			Console.WriteLine("Apellido= "+apellido);
			Console.WriteLine("CI= "+CI);
			Console.WriteLine("Edad= "+edad);
			Console.WriteLine("Genero= "+genero);
			Console.WriteLine("Nacionalidad= "+nacionalidad);
			Console.WriteLine("Telefono= "+telefono);
		}
		public string getNombre(){
			return nombre;
		}
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		public string getApellido(){
			return apellido;
		}
		public void setApellido(string apellido){
			this.apellido = apellido;
		}
		public int getCi(){
			return CI;
		}
		public void setCi(int CI){
			this.CI = CI;
		}
		public short getEdad(){
			return edad;
		}
		public void setEdad(short edad){
			this.edad = edad;
		}
		public char getGenero(){
			return genero;
		}
		public void setGenero(char genero){
			this.genero = genero;
		}
		public string getNacionalidad(){
			return nacionalidad;
		}
		public void setNacionalidad(string nacionalidad){
			this.nacionalidad = nacionalidad;
		}
		public int getTelefono(){
			return telefono;
		}
		public void setTelefono(int telefono){
			this.telefono = telefono;
		}
	}
}
