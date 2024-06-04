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
	/// Description of empleado.
	/// </summary>
	public class empleado
	{
		private string nombre;
			private int CI;
			private string profesion;
			private double sueldo;
			private string turno;
			
		public empleado()
		{
			nombre="juan";
			CI=123;
			profesion="barista";
			sueldo=2000.45;
			turno="tarde";
		}
		
		public void Leer(){
		Console.Write("ingrese el nombre del empleado:::::::");
			nombre=Console.ReadLine();
			Console.Write("ingrese CIr::::");
			CI=int.Parse(Console.ReadLine());
			Console.Write("ingrese profesion");
			profesion=Console.ReadLine();
				Console.Write("ingrese sueldpo");
			sueldo=double.Parse(Console.ReadLine());
			Console.Write("ingrese el turno del empleado:::::::");
			turno=Console.ReadLine();
		}
		
		public void Mostrar(){
			Console.WriteLine("nombre:::::::"+nombre);
			Console.WriteLine("CI:::::::"+CI);
			Console.WriteLine("profesion:::::::"+profesion);
			Console.WriteLine("ingrese el nombre del empleado:::::::"+sueldo);
			Console.WriteLine("ingrese el nombre del empleado:::::::"+turno);
			
		}
			public string getnombre(){
			return nombre;
		}
		
		public void setnombre(string nombre){
			this.nombre=nombre;
		}
			public int getCI(){
			return CI;
		}
		
		public void setCI(int CI){
			this.CI=CI;
		}
		
			public string getprofesion(){
			return profesion;
		}
		
		public void setprofesion(string profesion){
			this.profesion=profesion;
		}
		
			public double setsueldo(){
			return sueldo;
		}
		
		public void setsueldo(double sueldo){
			this.sueldo=sueldo;
		}
		
			public string getturno(){
			return turno;
		}
		
		public void setturno(string turno){
			this.turno=turno;
		}
		
		
		
		//a) segunda forma
		
		public void bucarempleado( int y){//y es el ci
		
		// recibe por parametro y no uno por uno
		//preguntamos
		if(CI.Equals(y)){
			Console.Write("ingrese nuevo turno::::");
			turno=Console.ReadLine();//por falso no mandar nada
			Mostrar();
		}
		}
		
		//c) segunda forma
		public void buscarEmpb(int x){
		//para evitar buscar uno a uno se hace lo siguiente para llegar al indicado
		if(CI.Equals(x)){
			Console.Write("ingrese sueldpo a modificar:::::");
			sueldo=double.Parse(Console.ReadLine());
			Mostrar();
		}
		}
	}
}
