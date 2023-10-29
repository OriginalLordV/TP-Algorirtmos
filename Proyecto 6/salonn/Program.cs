
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
			
			Encargado walter = new Encargado("Walter", "Gonzalez", 41000222, "Propietario", 120000); // encargado default
			
			Empleado em1 = new Empleado("Daiana", "Aguilera", "cocinera", 17235444,  60000); // empleado default

			// Crear eventos
			
	        Evento evento1 = new Evento("Cumpleaños de Juan", "Cumpleaños", walter, 3030303, new DateTime(2023, 11, 15));
	        
	        Evento evento2 = new Evento("Boda de Maria", "Boda", walter, 4040404, new DateTime(2023, 12, 20));
	        
	        Evento evento3 = new Evento("Aniversario de Bodas", "Aniversario", walter, 5050505, new DateTime(2023, 10, 25));
	        
	        Evento evento4 = new Evento("Fiesta de Graduación", "Graduación", walter, 6060606, new DateTime(2023, 11, 5));
	        
	        Evento evento5 = new Evento("Baby Shower", "Baby Shower", walter, 7070707, new DateTime(2023, 11, 30));
	        
			deFiesta.reservarEvento(evento1);
			deFiesta.reservarEvento(evento2);
			deFiesta.reservarEvento(evento3);
			deFiesta.reservarEvento(evento4);
			deFiesta.reservarEvento(evento5);

	        // Agregar servicios a los eventos
	        
	        Servicio catering = new Servicio("Catarina Catering", "Catering", "Ofrecemos deliciosos platos", 15, 2000);

	        Servicio musica = new Servicio("Orquesta en Vivo", "Música", "Banda en vivo para el evento", 1, 5000);

	        Servicio decoracion = new Servicio("Decoración Temática", "Decoración", "Decoración especializada", 1, 3000);

	        Servicio fotografia = new Servicio("Servicio de Fotografía", "Fotografía", "Fotógrafo profesional para el evento", 1, 2500);

	        Servicio barraLibre = new Servicio("Barra Libre de Bebidas", "Bebidas", "Variedad de bebidas para los invitados", 1, 3500);
			
			Servicio se1 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
			
			// metodos que retornan: los que no piden nada se guardan en variable aca para una utilización mas completa (por si quiero cierto valor en el case 1, ya tengo la variable cargada por ejemplo). los que piden condiciones se sentencian en el case determinado
			
			ArrayList eventos = deFiesta.verEventos();
			
			int eventoCantidad = deFiesta.cantidadEvento();

			// Evento eventosPos = deFiesta.IndiceEvento(); // EJEMPLO: se sentencia en dicho case
			
			// Boolean eventosBool = deFiesta.ExistenciaEvento(); // EJEMPLO: se sentencia en dicho case
			
			 
			
			
			bool salir = false;
 
            while (!salir) {
 
                try
                {
                	
                    Console.WriteLine("1. Administrar eventos");
                    Console.WriteLine("2. Administrar servicios");
                    Console.WriteLine("3. Administrar Empleados / Encargado");
                    Console.WriteLine("4. Mostrar datos");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    
 					
                    switch (opcion)
                    {
                    		
                        case 1: // administrar eventos
                    		
                            Console.WriteLine("\nHas elegido la opción 1\n");
                            
                            bool salir1 = false;
                            
                            while (!salir1) {
	                            try {
                            		Console.WriteLine("1. Agregar mi evento");
	                    			Console.WriteLine("2. Cancelar evento existente");
				                    Console.WriteLine("3. Ver Eventos");
				                    Console.WriteLine("4. Ver un Evento en especifico / mas detalles.");
				                    
				                    Console.WriteLine("5. Volver Atras");
				                    
				                    Console.WriteLine("\nElige una opción:\n");
				                    int opcion1 = int.Parse(Console.ReadLine());
				                    
				                    switch (opcion1) {
				                    		
				                    	case 1: // agregar un nuevo evento
				                    		
				                    		Console.WriteLine("\nIndique su nombre como cliente: \n");
   											string nombreCliente = Console.ReadLine();
   											
   											Console.WriteLine("\nIngrese su dni: \n");
   											int dnicliente = int.Parse(Console.ReadLine());
   											
   											Console.WriteLine("\nIngrese el tipo de evento: \n");
   											string tipoEvento = Console.ReadLine();
   											
   											Console.WriteLine("\nIngrese el año de reserva para el evento (AAAA): \n");
   											int fechaAnoCliente = int.Parse(Console.ReadLine());
   											
   											Console.WriteLine("\nIngrese el mes de reserva para el evento (MM): \n");
   											int fechaMesCliente = int.Parse(Console.ReadLine());
   											
   											Console.WriteLine("\nIngrese el dia de reserva para el evento (DD): \n");
   											int fechaDiaCliente = int.Parse(Console.ReadLine());
   											
   														
											Evento eventoCliente = new Evento(nombreCliente, tipoEvento, walter, dnicliente, new DateTime(fechaAnoCliente, fechaMesCliente, fechaDiaCliente));
   											
   											deFiesta.reservarEvento(eventoCliente);

   											
   											Console.WriteLine("\nSe agregó con exito su evento " + eventoCliente.NombreEvento + "\n\n");
				                    		break;
				                    		
				                    	case 2: // eliminar un evento de la lista
				                    		
											    Console.WriteLine("Ingrese el número del evento que desea cancelar:");
											    int numeroEventoCancelar = int.Parse(Console.ReadLine()); 								     // <--- el valor lo decide el usuario.
											
											    if (numeroEventoCancelar >= 1 && numeroEventoCancelar <= deFiesta.cantidadEvento()) 	     // <--- si el numero que puso el usuario es mayor o igual a la posición inicial y menor e igual a la cantidad total de elementos que hay dentro de la lista:           
											    {
											        Evento eventoCancelar = deFiesta.IndiceEvento(numeroEventoCancelar - 1); 				 // <--- el metodo retorna el objeto colocado en la posición determinada por el usuario. en el metodo se ve de esta manera -> return (Evento) this.listaEventos[""numeroEventoCancelar""];           
											        deFiesta.cancelarEvento(eventoCancelar); 												 // <--- elimina el elemento retornado
											        Console.WriteLine("El evento '" + eventoCancelar.NombreEvento + "' ha sido cancelado."); // <--- lo muestra por consola
											    }
											    else
											    {
											        Console.WriteLine("Número de evento inválido. Por favor, ingrese un número válido.");
											    }
				                    		
				                    		break;
				                    		
				                    	case 3: // ver eventos

											int contador = 1;
											
											Console.WriteLine("Lista de Eventos:");
											foreach (Evento evento in eventos)
											{
											    Console.WriteLine("\n\n" + contador + ". Evento de: " + evento.NombreEvento + " - Fecha: " + evento.Fecha.ToString("dd/MM/yyyy") + "\n\n"); // intercambia los valores char por los items dentro del objeto Fecha (tipo DateTime)
											    contador++;
											}
				                    		break;
				                    		
				                    	case 4:  // mostrar posicion de un evento
				                    		try {

										   		Console.WriteLine("\nque posicion deseas llamar? \n");
										   		int llamarPos = int.Parse(Console.ReadLine()); // decide el usuario
										   	
										   		Evento retornarPos = deFiesta.IndiceEvento(llamarPos); // la definición del metodo es: public EVENTO indiceEvento ---> de qué tipo va a ser la variable que guarda el valor retornado? de tipo evento.
										   		
										   		Console.WriteLine("\nEvento de: " + retornarPos.NombreEvento + ". \n\nFecha: " + retornarPos.Fecha.ToString("dd/MM/yyyy") + ". \n\nDNI: " + retornarPos.Dni + ". \n\nEncargado: " + retornarPos.EncargadoEvento.Nombre + ". \n\nTipo de evento: " + retornarPos.TipoEvento + "\n\n");

												
										   	} catch (System.ArgumentOutOfRangeException) {
										   		Console.WriteLine("\nno existe tal posicion \n");
											}
				                    		
				                    		break;
				                    		
				                    	default: // volver atras. (28/10/2023): eliminé case 5 y 6
				                    		
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
 
                        case 2: // administrar servicios.
                            Console.WriteLine("\nHas elegido administrar los servicios.\n\n");
                            
                            bool salir2 = false;
                            
                            while (!salir2) {
                            	// MENU
                            	
                            	try {
	                            	Console.WriteLine("1.");
	                            	Console.WriteLine("2.");
	                            	Console.WriteLine("3.");
	                            	Console.WriteLine("4.");
	                            	Console.WriteLine("5.");

	                            	Console.WriteLine("\nelige una opcion: \n");
                            		int opcion2 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion2) {
                            			case 1:
                            				break;
                            			case 2:
                            				break;
                            			case 3:
                            				break;
                            			case 4:
                            				break;
                            			case 5:
                            				salir2 = true;
                            				break;
                            			
                            			default:
                            				
                            				break;
                            		}
                            	} catch (FormatException e) {
									Console.WriteLine(e.Message);
                            	}

                            }
                            break;
 
                        case 3: // administrar empleados.
                            Console.WriteLine("\nHas elegido administrar los empleados\n\n");
                            
                            bool salir3 = false;
                            
                            while (!salir3) {
                            	// MENU
                            	
                            	try {
	                            	Console.WriteLine("1.");
	                            	Console.WriteLine("2.");
	                            	Console.WriteLine("3.");
	                            	Console.WriteLine("4.");
	                            	Console.WriteLine("5.");

	                            	Console.WriteLine("\nelige una opcion: \n");
                            		int opcion3 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion3) {
                            			case 1:
                            				break;
                            			case 2:
                            				break;
                            			case 3:
                            				break;
                            			case 4:
                            				break;
                            			case 5:
                            				salir3 = true;
                            				break;
                            			
                            			default:
                            				
                            				break;
                            		}
                            	} catch (FormatException e) {
									Console.WriteLine(e.Message);
                            	}

                            }
                            break;
                            
                        case 4: // administrar impresiones.
                            Console.WriteLine("\nHas elegido administrar impresión\n\n");
                            
                            bool salir4 = false;
                            
                            while (!salir4) {
                            	// MENU
                            	
                            	try {
	                            	Console.WriteLine("1.");
	                            	Console.WriteLine("2.");
	                            	Console.WriteLine("3.");
	                            	Console.WriteLine("4.");
	                            	Console.WriteLine("5.");

	                            	Console.WriteLine("\nelige una opcion: \n");
                            		int opcion4 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion4) {
                            			case 1:
                            				break;
                            			case 2:
                            				break;
                            			case 3:
                            				break;
                            			case 4:
                            				break;
                            			case 5:
                            				salir4 = true;
                            				break;
                            			
                            			default:
                            				
                            				break;
                            		}
                            	} catch (FormatException e) {
									Console.WriteLine(e.Message);
                            	}

                            }
                            break;
                            
                        case 5:
                        	Console.WriteLine("\nHas elegido salir de la aplicación");
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
 
			
			
			
			Console.Write("\nPress any key to continue . . . ");
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