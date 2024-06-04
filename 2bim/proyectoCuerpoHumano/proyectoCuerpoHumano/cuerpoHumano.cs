/*
 * Created by SharpDevelop.
 * User: LAB_3-PC
 * Date: 25/04/2024
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoCuerpoHumano
{
	/// <summary>
	/// Description of cuerpoHumano.
	/// </summary>
	public class cuerpoHumano
	{
		private char genero;
		private string colorPiel;
		private double peso;
		private double estatura;
		private short edad;
		private string nombre;
		// componemos los siguentes objetos
		
		private cabeza ca = new cabeza();
		private columna co = new columna();
		private extremidad []ex= new extremidad[4];
		public cuerpoHumano()
		{
			genero = 'f';
			colorPiel = "moreno";
			peso = 67.45;
			estatura = 169.43;
			edad = 25;
			nombre = "gerardo";
			for(int i=0;i<ex.Length;i++)
				ex[i] = new extremidad();
			
		}
		
		
		public void leer(){
			Console.WriteLine("------  datos de cuerpo humano ------");
			Console.WriteLine(" ingrese el genero ");
			genero = char.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese el color de piel: ");
			colorPiel = Console.ReadLine();
			Console.WriteLine(" ingrese el peso: ");
			peso = double.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese la estatura: ");
			estatura = double.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese la edad: ");
			edad = short.Parse(Console.ReadLine());
			Console.WriteLine(" ingrese el nombre: ");
			nombre = Console.ReadLine();
			//leemos los objetos que estan compuesto
			ca.leer();// cabeza
			co.leer();//columna
			for(int i=0;i<ex.Length;i++)
				ex[i].leer();
		
		}
		public void mostra(){
			Console.WriteLine("------  Mostrar datos de extremidades ------");
			Console.WriteLine("genoro es = "+genero);
			Console.WriteLine("color de piel = "+colorPiel);
			Console.WriteLine("peso = "+peso);
			Console.WriteLine("estatura = "+estatura);
			Console.WriteLine("edad = "+edad);
			Console.WriteLine("nombre = "+nombre);
			
			ca.mostra();
			co.mostra();
			for(int i=0;i<ex.Length;i++)
				ex[i].mostra();
		}
		
		public char getgenero(){
			return genero;
		}
		
		public void setgenero(char genero ){
			this.genero=genero;
		}
		
		public string getcolorPiel(){
			return colorPiel;
		}
		
		public void setcolorPiel(string colorPiel ){
			this.colorPiel=colorPiel;
		}
		
		public double getpeso(){
			return peso;
		}
		
		public void setPeso(double peso ){
			this.peso=peso;
		}
		
		public double getestatura(){
			return estatura;
		}
		
		public void setEstatura(double estatura ){
			this.estatura=estatura;
		}
		
		
		public short getedad(){
			return edad;
		}
		
		public void setEdad(short edad){
			this.edad=edad;
		}
		
		
		public string getnombre(){
			return nombre;
		}
		
		public void setNombre(string nombre){
			this.nombre=nombre;
		}
		//a)
		public void modificarColor_ojo(){
		
			Console.Write("ingrese noimbre a buscar::");
			string x = Console.ReadLine();
			if(nombre.ToLower().Equals(x.ToLower())){
				Console.Write("ingrese nuevo color de ojos::::");
				// color de ojos esta en cabeza
				ca.setcolorOjos(Console.ReadLine());
				 mostra();//muestra tdo
				 ca.mostra();// muestra solo de la cabeza
				                
			
				}else{
				Console.Write("no se encontro el nombre");
			
			
			}
		
		}
		
		
		
		//b)
		public void bucar_tipo(){
			Console.Write("ingrese tipo de extremidad a buscar:::");
			string x =Console.ReadLine().ToUpper();
			// como es un vector hay que buscar la posision
			for(int i=0;i<ex.Length;i++){
			
				if(x.Equals(ex[i].gettipo().ToUpper())){
				
					Console.Write("ingrese tamaño:::");
					double auxtamano=double.Parse(Console.ReadLine());
					ex[i].settamano(auxtamano);
					ex[i].mostra();
				}
			}
		}
		
		//C)mi metodo
		public void bucar_estatura(){
			Console.Write("ingrese estatura a buscar:::");
			double z =double.Parse(Console.ReadLine());
		
			
			if(z== estatura){
				Console.Write("ingrese numero de costillas::::");
				// numero de costillas esta en columna :co
				co.setnorCostillas(int.Parse(Console.ReadLine()));
			//	 mostra();//muestra tdo
				 co.mostra();// muestra solo de la columna
				                
			
				}else{
				Console.Write("no se encontro la estatura");
			
			
			}
			
		}
		// c) de la lice 
		public void buscarestat_lic(){
		Console.Write("ingrese estatura a buscar:::");
			double x =double.Parse(Console.ReadLine());
			if(estatura.Equals(x)){
				Console.Write("ingrese numero de costillas::::");
				// numero de costillas esta en columna :co
				co.setnorCostillas(int.Parse(Console.ReadLine()));
			//	 mostra();//muestra tdo
				 co.mostra();// muestra solo de la columna
				                
			
				}else{
				Console.Write("no se encontro la estatura");
			
			}
		}
	}
}
