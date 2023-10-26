
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
			
			
			Encargado encargado = new Encargado("walter", "gonzalez", 41000222, "soy encargado", 120000);
			Evento divorcio = new Evento("divorcio de los padres de flavio" , "divorcio", "3030303", new DateTime(2023, 10, 10));
			Servicio se1 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
				Servicio se2 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
					Servicio se3 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
			
			deFiesta.reservarEvento(divorcio);
			divorcio.agregarServicio(se1);
			divorcio.agregarServicio(se2);
			divorcio.agregarServicio(se3);
			divorcio.EncargadoEvento = encargado;
			
			
			/*________________________________________<<Inicio del menú>>____________________________________________*/
			
		
			
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
	                    			Console.WriteLine("2. Cancelar evento existente");
				                    Console.WriteLine("3. Ver Eventos");
				                    Console.WriteLine("4. Índice evento");
				                    Console.WriteLine("5. Existencia evento");
				                    Console.WriteLine("6. Contar la cantidad de eventos");
				                    
				                    Console.WriteLine("7. Volver Atrás");
				                    
				                    Console.WriteLine("\nElige una opción:\n");
				                    int opcion1 = Convert.ToInt32(Console.ReadLine());
				                    
				                    switch (opcion1) {
				                    		
				                    	case 1: // reservar el salon para un evento
				                    		int opcionA;
				                    		do
				                    		{
				                    			Console.WriteLine("Seleccione Una opción de evento: \n1- Bautismo \n2-Cumpleaños \n3- Fiesta de Quince \n4-Despedida de Soltera/o \n5- Casamiento \n6- Salir");
				                    			opcionA = int.Parse(Console.ReadLine());
				                    			string nombreEv,dniCli;
				                    			int dia, mes;
				                    			int agno = 2023; 
				                    			DateTime fecha = DateTime.MinValue;
												string tipoEv = string.Empty;
				                    			
				                    			switch(opcionA)
				                    			{
				                    				case 1:
				                    					tipoEv = "Bautismo";
				                    					break;
				                    				case 2:
				                    					tipoEv = "Cumpleaños";
				                    					break;
				                    				case 3:
				                    					tipoEv = "Fiesta de Quince";
				                    					break;
				                    				case 4:
				                    					tipoEv = "Despedida de soltero";
				                    					break;
				                    				case 5:
				                    					tipoEv = "Casamiento";
				                    					break;
				                    				case 6:
				                    					opcionA = 0;
				                    					break;
				                    				default:
				                    					Console.WriteLine("Ingrese una opción válida.");
				                    					break;
				                    			}
				                    			if (opcionA == 0)
											    {
											        break;
											    }

				                    			
				                    			Console.WriteLine("¿Para que fecha quiere reservar el evento?");
				                    					
				                    					try
														{
														    Console.Write("Ingrese el mes: ");
														    string inputMes = Console.ReadLine();
														    if (!int.TryParse(inputMes, out mes) || mes < 1 || mes > 12)
														    {
														        throw new FormatException("Mes inválido. Por favor, ingrese un número entero válido entre 1 y 12.");
														    }
														
														    Console.Write("Ingrese el día: ");
														    string inputDia = Console.ReadLine();
														    if (!int.TryParse(inputDia, out dia) || dia < 1 || dia > 31)
														    {
														        throw new FormatException("Día inválido. Por favor, ingrese un número entero válido entre 1 y 31.");
														    }
														
														    fecha = new DateTime(agno, mes, dia);
														    Console.WriteLine("Fecha ingresada correctamente: " + fecha.ToString());
														}
														catch (FormatException e)
														{
														    Console.WriteLine(e.Message);
														}

				                    					
				                    			Console.Write("Ingrese su nombre: ");
				                    			nombreEv = Console.ReadLine();
				                    			Console.Write("Para finalizar, ingrese su DNI.");
				                    			dniCli= Console.ReadLine();
				                    			
				                    			if(dniCli.Length == 8)
				                    			{
				                    				
				                    				Console.WriteLine("El evento se ha agregado con éxito.");
				                    				Evento evento = new Evento(nombreEv, tipoEv, dniCli, fecha);
				                    				deFiesta.reservarEvento(evento);
				                    			}
				                    			
				                    			else
				                    			{
				                    				Console.WriteLine("Ingrese un DNI válido, debe incluir 8 carácteres y ser todos números.");
				                    				dniCli= Console.ReadLine();
				                    			}
				                    			
				                    			
				                    		}
				                    		while (opcionA != 0);
				                    		
				                    		break;
				                    		
				                    	case 2: // cancelar evento existente
				                    		
				                    		deFiesta.cancelarEvento(divorcio);
				                    		
				                    		Console.WriteLine("\nRealizado\n");
				                    		break;
				                    		
				                    	case 3: // ver eventos
				                    		
				                    		deFiesta.verEventos();
				                    		
				                    		Console.WriteLine("si");
				                    		break;
				                    		
				                    	case 4: // indice evento
				                    		
				                    		
				                    		try {
				                    			
				                    			Console.WriteLine("\nque posicion deseas llamar?\n");
				                    			int llamarPos = int.Parse(Console.ReadLine());
				                    		
				                    		
				                    			deFiesta.IndiceEvento(llamarPos);
				                    			
				                    			Console.WriteLine("\nRealizado\n");
				                    						                    			
				                    		} catch (System.ArgumentOutOfRangeException) {
				                    			
				                    			Console.WriteLine("\nNo existe tal posicióon\n");
				                    		}
				                    		
				                    		break;
				                    		
				                    		
				                    	case 5: // ver si existe un evento
				                    		
				                    		deFiesta.ExistenciaEvento(divorcio);
				                    		
				                    		Console.WriteLine("\nRealizado\n");
				                    		break;
				                    		
				                    	case 6: // contar cantidad de Eventos
				                    		
				                    		deFiesta.cantidadEvento();
				                    		
				                    		Console.WriteLine("\nRealizado\n");
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
			set { listaEventos = value; }
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

		public void verEventos()
		{
			foreach (Evento el in listaEventos) {
				Console.WriteLine("\nEvento {0}:\nNombre del evento: {1}\nFecha del evento{2}\nEncargado del evento: {3} {4}", el.ID, el.NombreEvento, el.Fecha,el.EncargadoEvento.Nombre, el.EncargadoEvento.Apellido);
				Console.WriteLine("Lista de servicios: ");
				el.verServicio();
				Console.WriteLine("");
			}
			
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
		private static int contador =0; 						//se autoincrementa asignando un identificador a cada evento agregago.
		private DateTime fecha;
		private string nombreEvento;
		private string tipoEvento;
		private int id; 										//el identificador propio de cada evento.
		private Encargado encargadoEvento;
		
		private string dni;
		private double costoTotal;
		
		private ArrayList listaServicios;
		
		// constructor

		public Evento(string nombreEvento, string tipoEvento,string dni, DateTime fecha)
		{
			this.encargadoEvento = encargadoEvento;
			this.nombreEvento = nombreEvento;
			this.tipoEvento = tipoEvento;
			this.dni= dni;
			this.fecha = fecha;
			this.id = contador++;  								//El id asignado sera el actual de la clase evento, luego se incrementa. En este caso el id, tambien esta relacionado con el indice dentro de la lista de eventos.
		
			listaServicios = new ArrayList();
		}
		
		// propiedades
		public int ID{get{return id;}}
		
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
		
		public string Dni
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
			set { listaServicios = value; }
		}

		
		
        // metodos


        public Boolean existenciaServicio(ArrayList n)
        {
            return this.listaServicios.Contains(n); 
        }

        public void verServicio()
        {
        	int indice =1;
        	foreach (Servicio el in this.listaServicios)
        	{
        		Console.WriteLine( indice +" "+ el.TipoServicio+" - "+ el.NombreServicio);
        		indice++;
        	}
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

class NoINTdetectedException : Exception
{
	
}