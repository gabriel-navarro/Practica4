using System;
using System.IO;
namespace Practica4
{
	class Main
	{

		public Main(){

		}

		public void convinar_archivos()
		{ 
			StreamReader Captura1;
			string Fichero1;
			StreamReader Captura2;
			string Fichero2;
			StreamReader Directorio;
			string FicheroFinal;
			StreamWriter CreaArchivo1;
			string lFichero1;
			StreamWriter CreaArchivo2;
			string lFichero2;
            StreamWriter CreaArchivoFinal;
			string linea;

			Console.WriteLine("Introduzca el nombre del fichero 1"); 
			Fichero1 = Console.ReadLine();
		    CreaArchivo1=File.CreateText(Fichero1);
			CreaArchivo1.Write ("Hola mundo\nlinea2");

			Console.WriteLine("Introduzca el nombre del fichero 2"); 
			Fichero2 = Console.ReadLine();
			CreaArchivo2=File.CreateText(Fichero2);
			CreaArchivo2.Write ("Programacion 3\nCUTonala");

			CreaArchivo1.Close ();
			CreaArchivo2.Close ();


				Captura1 = File.OpenText(Fichero1); 
				Captura2 = File.OpenText(Fichero2); 

				Console.WriteLine("Introduzca el nombre del fichero Final"); 
				FicheroFinal=Console.ReadLine();
				CreaArchivoFinal=File.CreateText(FicheroFinal);
				do 
				{ 
					lFichero1 = Captura1.ReadLine(); 
					lFichero2 =Captura2.ReadLine();
					if (lFichero1 != null) {
						CreaArchivoFinal.WriteLine(lFichero1); 
					}
					if(lFichero2 != null){
						CreaArchivoFinal.WriteLine(lFichero2); 
					}
				} 
				while (lFichero1 != null && lFichero2 != null );

				Captura1.Close();
				Captura2.Close();
				CreaArchivoFinal.Close ();


			Directorio= File.OpenText(FicheroFinal);
			try 
			{ 
				do{ 
					linea =  Directorio.ReadLine(); 
					if (linea != null) 
						Console.WriteLine( linea ); 
				} 

				while (linea != null);
				Directorio.Close();
			}
			catch ( Exception e)
			{ 
				Console.WriteLine("ERROR! Falto .txt  {0} ",e.Message);
			}

		}


		public static void Principal(){

			Main Codigo= new Main();
			Codigo.convinar_archivos();

		}
	}
}	