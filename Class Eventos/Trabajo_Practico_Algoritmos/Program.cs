/*
 * Created by SharpDevelop.
 * User: Walter
 * Date: 03/10/2023
 * Time: 18:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trabajo_Practico_Algoritmos
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Algoritmos!");
			 
			
			
			//Acá debería ir el menú. . .
			
			//Menu
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	//Declaro la clase evento:
	class Evento
	{
		private DateTime fecha;
		private string nombreEvento;
		private int dni;
		private Servicio[] listaServicios;
		
		public Evento(string nombreEvento, int dni, DateTime fecha)
		{
			this.nombreEvento = nombreEvento;
			this.dni= dni;
			this.fecha = fecha;
		}
		
		public DateTime Fecha()
		{
			get{return fecha;}
			set{this.fecha = ValueTuple;}
		}
		
		public int Dni()
		{
			get{return dni;}
			set{this.dni = value;}
		}
		
		public string NombreEvento()
		{
			get{return nombreEvento;}
			set{this.nombreEvento = value;}
		}
		
	}
	
	class Servicio
	{
		private string nombreSevicio;
		private string tipoServicio;
		private string descripcionServicio;
		private int cantidadSolicitada;
		private float costoFinal;
		
		public Servicio(string nombreServicio, string tipoServicio, string descripcionServicio, int cantidadSolicitada, float costoFinal)
		{
			this.nombreSevicio = nombreSevicio;
			this.tipoServicio = tipoServicio;
			this.descripcionServicio = descripcionServicio;
			this.cantidadSolicitada  = cantidadSolicitada;
			this.costoFinal = costoFinal;
		}
		
		public string NombreServicio()
		{
			get {return nombreServicio;}
			set{this.nombreSevicio = value;}
		}
		
		public string TipoServicio()
		{
			get {return tipoServicio;}
			set{this.tipoSevicio = value;}
		}
		
		public string DescripcionServicio()
		{
			get {return descripcionServicio;}
			set{this.descripcionServicio = value;}
		}
		
		public int CantidadSolicitada()
		{
			get {return cantidadSolicitada;}
			set{this.cantidadSolicitada = value;}
		}
		
		public float CostoFinal()
		{
			get {return costoFinal;}
			set{this.costoFinal = value;}
		}
	}
	
}