/*
 * Creado por SharpDevelop.
 * Usuario: Strix
 * Fecha: 02/05/2024
 * Hora: 21:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace empresa
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			// en este caso primero van las calases partes y despues se instancia la clase empresa (todo9
			gerente G=new gerente();
			empleado EM=new empleado();
			proveedor PR=new proveedor();
			empresa E=new empresa(G,EM,PR);
			E.Mostrar();
			//G.Mostrar();
		//	EM.Mostrar();
		//	E.Leer();
		//	E.Mostrar();
			//a)encontrar al empleado con nopmbre de empresa x y de ci y modificar turno
	//	E.modturno(); 77usando metodos get y set
		
		//segunda forma llamando a metodo sin usar set y get en este caso para buscar la empresa
		// para este caso el de la empresa
	
	//	E.buscarnombre();
	//b) buscar al gerente con nombre x y mostrar el celular del gerente y el nombre de la empresa
	//primer metodo
//	E.buscarGerente();
	//segunda forma llamando a metodo
//	E.buscgen2da();
	//C)buscar al empleado de CI x y modificar sdu sueldo y mostrar datos actualizados
	//primera forma
//	E.buscarCIempleado();
	//segiunda forma
	E.buscarCIemp2da();
	

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
		
		}
	}
}