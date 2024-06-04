/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 25/04/2024
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoCuerpoHumano
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			cuerpoHumano CH = new cuerpoHumano();
			//CH.mostra();
			//CH.leer();
			//CH.mostra();
			
			
			
			//A) CRUD.- CRIP RERAD UPDATE DELETE
			//a)buscar al cuerpo humano de nombre x modificar el color de ojos
	//		CH.modificarColor_ojo();
			//por llamada a metodo
			//b)buscar 
		//	CH.bucar_tipo();
			//c) buscarquien tenga la la estatura z y modificar  numero de costillass
		//	CH.bucar_estatura();
		CH.buscarestat_lic();
		//(a,b,c es composicion)
		
		//(d,
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}