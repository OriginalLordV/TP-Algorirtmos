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
	// Classe servicios
	class Servicio
	{
		private string nombreSevicio;
		private string tipoServicio;
		private string descripcionServicio;
		private int cantidadSolicitada;
		private double costoFinal;
		
		public Servicio(string nombreServicio, string tipoServicio, string descripcionServicio, int cantidadSolicitada, double costoFinal)
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
		
		public double CostoFinal()
		{
			get {return costoFinal;}
			set{this.costoFinal = value;}
		}
	}
	
	
	//Clase de empleado
	class Empleado
	{
		protected string nombre, apellido, descripcionTarea;
		protected int dni, legajo;
		protected double sueldo;
		
		public Empleado(string nombre, string apellido, string descripcionTarea, int dni, int legajo, double sueldo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.descripcionTarea = descripcionTarea;
			this.dni = dni;
			this.legajo = legajo;
			this.sueldo = sueldo;
		}
		
		public string Nombre()
		{
			get{return nombre;}
			set{this.nombre = value;}
		}
		
		public string Apellido()
		{
			get{return apellido;}
			set{this.apellido = value;}
		}
		
		public string Tarea()
		{
			get{return descripcionTarea;}
			set{this.descripcionTarea = value;}
		}
		
		public int DNI()
		{
			get{return dni;}
			set{this.dni = value;}
		}
		
		public int Legajo()
		{
			get{return legajo;}
			set{this.legajo = value;}
		}
		
		public double Sueldo()
		{
			get{return sueldo;}
			set{this.sueldo = value;}
		}
		
		
		
	}
	
	//Clase para el Encargado, solo tenemos en cuenta el plus de su sueldo,
	//	ya que menesteres como su funcion se heredan de la clase empleado
	
	class Encargado : Empleado
	{
		private sueldo;
		
		public Encargado(float sueldo) : base(nombre, apellido, dni, legajo, descripcionTarea, sueldo)
		{
			this.sueldo = sueldo;
		}
	}
}