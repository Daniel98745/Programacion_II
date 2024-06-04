/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 14/05/2024
 * Hora: 20:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Empresa_Herencia_Composicion_Agregacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Persona P = new Persona();
			Cliente C= new Cliente();
			Empleado EM = new Empleado();
			Operario O = new Operario();
			Administrativo A = new Administrativo();
			
			Carga CAR = new Carga();
			Rueda RU = new Rueda();
			Motor MO = new Motor();
			
			Vehiculo V = new Vehiculo(RU);
			Camion CA = new Camion(RU,CAR);
			Vagoneta VA = new Vagoneta(RU);
			
			Garaje G = new Garaje(CA,VA);
			
			Empresa E = new Empresa(A,O,C);
			E.Mostrar();
			//E.Leer();
			//E.Mostrar();
			
			
			//a) Busacar a la vagoneta con placa "x" modificar su modelo 
			//1ra forma (get y set)
			//E.buscarVagoneta();
			//2da forma
			//E.buscarVagoneta3();
			
			//b)Busacar la carga con ambiente "x" modificar por uno nuevo
			//1ra forma
			//E.cambiarAmbiente();
			//2da forma
			//E.cambiarAmbiente4();
			
			//c)Buscar el motor de la vagoneta de potencia "x" y modificar su modelo
			//1ra forma
			//E.modificarModelo();
			//2da forma
			//E.modificarModelo4();
			
			//d)Entre los vehiculos buscar la placa "x", modificar el modelo del motor y modelo del vehiculo. Mostrar datos actualizados
			//1ra forma
			//E.modificarVehiculos();
			//2da forma
			E.buscarPlaca4();
			
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}