
using System;
using System.Collections;
using System.Security.Cryptography;

namespace Trabajo_Practico_Algoritmos
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			salon deFiesta = new salon(new ArrayList(), new ArrayList());
			
			Empleado em1 = new Empleado("daiana", "aguilera", "cocinera", 1723544,  60000);
			
			Evento en1 = new Evento("divorcio de los padres de flavio" , "divorcio", new Encargado("walter", "gonzalez", 41000222, "soy encargado", 120000), 3030303, new DateTime(2023, 10, 10));
			
			Servicio se1 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
			
			bool salir = false;
 
            while (!salir) {
 
                try
                {
                    
                    Console.WriteLine("1. Administrar eventos");
                    Console.WriteLine("2. Administrar servicios");
                    Console.WriteLine("3. Administrar Empleados / Encargado");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    
                    int opcion = Convert.ToInt32(Console.ReadLine());
 					
                    switch (opcion)
                    {
                    		
                        case 1: // administrar eventos
                    		
                            Console.WriteLine("\nHas elegido la opción 1\n");
                            
                            bool salir1 = false;
                            
                            while (!salir1) {
	                            try {
                            		
	                            	Console.WriteLine("1. Reservar el salón para un evento");
	                    			Console.WriteLine("2. Agregar servicios");
				                    Console.WriteLine("3. Ver fechas disponibles");
				                    Console.WriteLine("4. Asignar encargado");
				                    Console.WriteLine("5. Volver Atras");
				                    
				                    Console.WriteLine("\nElige una opción:\n");
				                    int opcion1 = Convert.ToInt32(Console.ReadLine());
				                    
				                    switch (opcion1) {
				                    		
				                    	case 1: // reservar el salon para un evento
				                    		break;
				                    		
				                    	case 2: // agregar servicios
				                    		
				                    		break;
				                    		
				                    	case 3: // ver fechas disponibles / ver eventos
				                    		
				                    		break;
				                    		
				                    	case 4: // asignar encargado
				                    		
				                    		break;
				                    		
				                    	default: // volver atras
				                			salir1 = true;
				                    		break;
				                    		
				                    } // switch case 1

	                            } // try
                            
                            		catch (FormatException e)
					                {
					                    Console.WriteLine(e.Message);
					                }
                            	
                            } // while
                            
                            break;
 
                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            break;
 
                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }
 
                }
                
                
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
 
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}



    public class salon
    {
		// variables

        private ArrayList listaEventos;
		private ArrayList listaEmpleados;

        // constructor

		public salon(ArrayList listaEventos, ArrayList listaEmpleados)
		{
			this.listaEventos = listaEventos;
			this.listaEmpleados = listaEmpleados;
			
			listaEventos = new ArrayList();
			listaEmpleados = new ArrayList();
		}

        // propiedades

		public ArrayList ListaEventos
		{
			get { return listaEventos; }
			// set { listaEventos = value; }
		}

		public ArrayList ListaEmpleados
		{
			get { return listaEmpleados;}
			// set { listaEmpleados = value; }
		}

        // metodos

        public void agregarEmpleado(Empleado e)
        {
            this.listaEmpleados.Add(e);
        }

		public void eliminarEmpleado(Empleado e)
		{
			this.listaEmpleados.Remove(e);
		}

		public Boolean existenciaEmpleado(Empleado e)
		{
			return this.listaEmpleados.Contains(e);
		}

		public int cantidadEmpleado()
		{
			return this.listaEmpleados.Count;
		}

		public Empleado IndiceEmpleado(int pos)
		{
			return (Empleado)this.listaEmpleados[pos];
		}



		public void cancelarEvento(Evento ed)
		{
			this.listaEventos.Remove(ed);
		}

		public void reservarEvento(Evento a)
		{
			this.listaEventos.Add(a);
		}

		public ArrayList verEventos()
		{
			return this.listaEventos;
		}

		public Evento IndiceEvento(int pos)
		{
			return (Evento)this.listaEventos[pos];
		}

		public Boolean ExistenciaEvento(Evento existe)
		{
			return this.listaEventos.Contains(existe);
		}

		public int cantidadEvento()
		{
			return this.listaEventos.Count;
		} 
    }

    //Declaro la clase evento:
    public class Evento
	{
		// variables

		private DateTime fecha;
		private string nombreEvento;
		private string tipoEvento;
		
		private Encargado encargadoEvento;
		
		private int dni;
		private double costoTotal;
		
		private ArrayList listaServicios;
		
		// constructor

		public Evento(string nombreEvento, string tipoEvento, Encargado encargadoEvento, int dni, DateTime fecha)
		{
			this.encargadoEvento = encargadoEvento;
			this.nombreEvento = nombreEvento;
			this.tipoEvento = tipoEvento;
			this.dni= dni;
			this.fecha = fecha;
		
			listaServicios = new ArrayList();
		}
		
		// propiedades
		
		public double CostoTotal {
			get {return costoTotal;}
			set {costoTotal = value;}
		}

		public Encargado EncargadoEvento {
			get {return encargadoEvento;}
			set {encargadoEvento = value;}
		}
		
		public string TipoEvento {
			get {return tipoEvento;}
			set {this.tipoEvento = value;}
		}
		
		public DateTime Fecha
		{
			get {return fecha;}
			set {this.fecha = value;}
		}
		
		public int Dni
		{
			get{return dni;}
			set{this.dni = value;}
		}
		
		public string NombreEvento
		{
			get{return nombreEvento;}
			set{this.nombreEvento = value;}
		}

		public ArrayList ListaServicios
		{
			get { return listaServicios; }
			// set { listaServicios = value; }
		}

        // metodos


        public Boolean existenciaServicio(ArrayList n)
        {
            return this.listaServicios.Contains(n); // ok ya lo hice
        }

        public ArrayList verServicio()
        {
			return this.listaServicios;
        }

		public Servicio indiceServicio(int pos)
		{
			return (Servicio) this.listaServicios[pos];
		}

		public void agregarServicio(Servicio a)
		{
			this.listaServicios.Add(a);
		}

		public void eliminarServicio(Servicio a)
		{
			this.listaServicios.Remove(a);
		}
    }

	// Clases servicios
	public class Servicio
	{
		// variables

		private string nombreServicio;
		private string tipoServicio;
		private string descripcionServicio;
		private int cantidadSolicitada;
		private double costoInicial;
		private double costoFinal;
		
		// constructor

		public Servicio(string nombreServicio, string tipoServicio, string descripcionServicio, int cantidadSolicitada, double costoInicial)
		{
			this.costoInicial = costoInicial;
			this.nombreServicio = nombreServicio;
			this.tipoServicio = tipoServicio;
			this.descripcionServicio = descripcionServicio;
			this.cantidadSolicitada  = cantidadSolicitada;
			this.costoFinal = costoInicial * cantidadSolicitada;
		}
		
		// propiedades

		public double CostoInicial {
			get {return costoInicial;}
			set {costoInicial = value;}
		}
		
		public string NombreServicio
		{
			get {return nombreServicio;}
			set {this.nombreServicio = value;}
		}
		
		public string TipoServicio
		{
			get {return tipoServicio;}
			set{this.tipoServicio = value;}
		}
		
		public string DescripcionServicio
		{
			get {return descripcionServicio;}
			set{this.descripcionServicio = value;}
		}
		
		public int CantidadSolicitada
		{
			get {return cantidadSolicitada;}
			set{this.cantidadSolicitada = value;}
		}
		
		public double CostoFinal
		{
			get {return costoFinal;}
			set{this.costoFinal = value;}
		}
	}
	
	
	//Clase de empleado
	public class Empleado
	{
		// variables

		protected string nombre, apellido, descripcionTarea;
		protected int dni, numeroLegajo;

		protected static int legajo = 0;
		protected double sueldo;
		
		// constructor

		public Empleado(string nombre, string apellido, string descripcionTarea, int dni, double sueldo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.descripcionTarea = descripcionTarea;
			this.dni = dni;
			this.sueldo = sueldo;

			numeroLegajo = ++legajo;
		}
		
		// propiedades

		public string Nombre
		{
			get{return nombre;}
			set{this.nombre = value;}
		}
		
		public string Apellido
		{
			get{return apellido;}
			set{this.apellido = value;}
		}
		
		public string Tarea
		{
			get{return descripcionTarea;}
			set{this.descripcionTarea = value;}
		}
		
		public int DNI
		{
			get{return dni;}
			set{this.dni = value;}
		}
		
		public double Sueldo
		{
			get{return sueldo;}
			set{this.sueldo = value;}
		}
		
		
		
	}
	
	//Clase para el Encargado, solo tenemos en cuenta el plus de su sueldo,
	//	ya que menesteres como su funcion se heredan de la clase empleado
	
	public class Encargado : Empleado
	{
		private double sueldo; // new para confirmar q estoy cumpliendo con el ocultamiento de la variable
		
		public Encargado(string nombre, string apellido, int dni, string descripcionTarea, double sueldo) : base(nombre, apellido, descripcionTarea, dni, sueldo)
		{
			this.sueldo = sueldo;
		}
		
		public double Sueldo {
			get {
				return sueldo;
			}
			set {
				sueldo = value;
			}
		}
	}
}