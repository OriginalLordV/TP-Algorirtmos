
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Security.Cryptography;

namespace Trabajo_Practico_Algoritmos
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			salon deFiesta = new salon(new ArrayList(), new ArrayList());
			
			Encargado en = new Encargado("Walter", "Gonzalez",  "Propietario",41000222, 120000); // encargado default
			
			Empleado em1 = new Empleado("Daiana", "Aguilera", "Cocinera", 17235444,  60000); // empleado default
			Empleado em2 = new Empleado("Manuel", "Telechea", "Bar tender", 38781313, 15777555);
			Empleado em3 = new Empleado("Flavio", "Gonzalez", "Bachero", 45624032, 20);
			Empleado em4 = new Empleado("Cacho", "Gutierrez", "Cantante", 25322154, 60000);
			Empleado em5 = new Empleado("Maria Jose", "Hernandez", "Tejedora", 35893251, 78787);
			Empleado em6 = new Empleado("Carlos Alberto", "Roberto", "Jefe", 24789112, 2000);

			// Eventos Default
			
	        Evento evento1 = new Evento("Cumpleaños de Juan", "Cumpleaños","3030303", new DateTime(2023, 11, 15));
	        Evento evento2 = new Evento("Boda de Maria", "Boda", "4040404", new DateTime(2023, 12, 20)); 
	        Evento evento3 = new Evento("Aniversario de Bodas", "Aniversario", "5050505", new DateTime(2023, 10, 25)); 
	        Evento evento4 = new Evento("Fiesta de Graduación", "Graduación", "6060606", new DateTime(2023, 11, 5));  
	        Evento evento5 = new Evento("Baby Shower", "Baby Shower", "7070707", new DateTime(2023, 11, 30));
	        
			deFiesta.reservarEvento(evento1);
			deFiesta.reservarEvento(evento2);
			deFiesta.reservarEvento(evento3);
			deFiesta.reservarEvento(evento4);
			deFiesta.reservarEvento(evento5);

	        // Agregar servicios a los eventos
			
			Encargado encargado = new Encargado("walter", "gonzalez","soy encargado", 41000222 , 120000);
			Evento divorcio = new Evento("divorcio de los padres de flavio" , "divorcio", "3030303", new DateTime(2023, 10, 10));
			Servicio se1 = new Servicio("catarina catering", "catering", "hago catering", 15, 2000);
			
			deFiesta.reservarEvento(divorcio);
			
			divorcio.agregarServicio(se1);
			
			divorcio.EncargadoEvento = encargado;
			
			deFiesta.agregarEmpleado(em1);
			deFiesta.agregarEmpleado(em2);
			deFiesta.agregarEmpleado(em3);
			deFiesta.agregarEmpleado(em4);
			deFiesta.agregarEmpleado(em5);
			deFiesta.agregarEmpleado(em6);
			deFiesta.agregarEmpleado(en);
	
			/*________________________________________<<Inicio del menú>>____________________________________________*/

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
                            		Console.WriteLine("\nElige una opción:\n");
                            		Console.WriteLine("1. Agregar mi evento");
	                    			Console.WriteLine("2. Cancelar evento existente");
				                    Console.WriteLine("3. Ver Eventos");
				                    
				                    Console.WriteLine("4. Volver atrás\n");
				                    
				                    
				                    int opcion1 = int.Parse(Console.ReadLine());
				                    
				                    switch (opcion1) {

				                    	case 1: // reservar el salon para un evento
				                    		bool salirEvento = false; // intento
				                    		int opcionA;
				                    		
				                    		do
				                    		{
				                    			Console.WriteLine("Seleccione Una opción de evento: \n1. Bautismo \n2. Cumpleaños \n3. Fiesta de Quince \n4. Despedida de Soltera/o \n5. Casamiento \n6. Volver atrás");
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
														salirEvento = true; // era anteriormente opcionA = 0;
				                    					break;
				                    				default:
				                    					Console.WriteLine("Ingrese una opción válida.");
				                    					break;
				                    			}
				                    			if (opcionA == 6) // anteriormente era opcionA = 0;
											    {
													salirEvento = true; // no estaba xd
											        break;
											    }

				                    			
				                    			Console.WriteLine("¿Para qué fecha quiere reservar el evento?\n");
				                    					
				                    					try
														{
														    Console.Write("Ingrese el mes: ");
														    string inputMes = Console.ReadLine();
														    
														    if (!int.TryParse(inputMes, out mes) || mes < 1 || mes > 12)
														    {
														        throw new FormatException("\nMes inválido. Por favor, ingrese un número entero válido entre 1 y 12.\n\n"); // si ingresas mal salta a la linea 187 y queda como resultado fecha (01/01/0001)
														    }
														
														    Console.Write("Ingrese el día: ");
														    string inputDia = Console.ReadLine();
														    if (!int.TryParse(inputDia, out dia) || dia < 1 || dia > 31)
														    {
														        throw new FormatException("\nDía inválido. Por favor, ingrese un número entero válido entre 1 y 31.\n\n"); // si ingresas mal salta a la linea 187 y queda como resultado fecha (01/01/0001)
														    }
														    
														    														    
														    foreach (Evento evento in deFiesta.verEventos()) { // recorre la lista de eventos de la clase salon
														    	if (!int.TryParse(inputMes, out mes) || mes == evento.Fecha.Month || !int.TryParse(inputDia, out dia) || dia == evento.Fecha.Day) { // si el numero ingresado es igual al mes del objeto datetime e igual al dia del objeto datetime ->
																	Console.WriteLine("\nYa existe un evento para esa fecha\n\n"); 
																	salirEvento = true; // con una variable booleana que defina cuando se termina el while
																	break; // break para cortar el foreach
														    	}
														    }
														    
														    fecha = new DateTime(agno, mes, dia);
														    
														}
														catch (FormatException e)
														{
														    Console.WriteLine(e.Message);
														}

														if (fecha != new DateTime(0001, 1, 1) | !salirEvento) { // lo metí dentro de un if para que se corte el programa en caso de ingresar una fecha igual a otra
															
														    Console.WriteLine("\nFecha ingresada correctamente: " + fecha.ToString() + "\n\n");
															
							                    			Console.Write("\nIngrese su nombre: \n");
							                    			nombreEv = Console.ReadLine();
							                    			Console.Write("\nPara finalizar, ingrese su DNI: \n");
							                    			dniCli= Console.ReadLine();
							                    			
							                    			if(dniCli.Length == 8)
							                    			{
							                    				Console.WriteLine("\nEl evento se ha agregado con éxito. \n\n");
							                    				Evento evento = new Evento(nombreEv, tipoEv, dniCli, fecha);
							                    				deFiesta.reservarEvento(evento);
							                    			}
							                    			
							                    			else
							                    			{
							                    				Console.WriteLine("Ingrese un DNI válido, debe incluir 8 carácteres y ser todos números. \n\n");
							                    				dniCli= Console.ReadLine(); // si no pones nada, se guarda sin ningun valor dentro y sigue funcionando como si nada
							                    				Evento evento = new Evento(nombreEv, tipoEv, dniCli, fecha);
							                    			}
				                    			
				                    					}

				                    			
				                    		}
				                    		while (!salirEvento); // anteriormente opcionA == 0;
				                    		
				                    		break;//FIN DEL CASE 1
				                    		
				                    	case 2: // eliminar un evento de la lista
				                    		
											    Console.WriteLine("\nIngrese el número del evento que desea cancelar: \n");
											    verEventos(deFiesta);
											    int numeroEventoCancelar = int.Parse(Console.ReadLine()); 								     // <--- el valor lo decide el usuario.
											
											    if (numeroEventoCancelar >= 1 && numeroEventoCancelar <= deFiesta.cantidadEvento()) 	     // <--- si el numero que puso el usuario es mayor o igual a la posición inicial y menor e igual a la cantidad total de elementos que hay dentro de la lista:           
											    {
											        Evento eventoCancelar = deFiesta.IndiceEvento(numeroEventoCancelar - 1); 				 // <--- el metodo retorna el objeto colocado en la posición determinada por el usuario. en el metodo se ve de esta manera -> return (Evento) this.listaEventos[""numeroEventoCancelar""];           
											        deFiesta.cancelarEvento(eventoCancelar); 												 // <--- elimina el elemento retornado
											        Console.WriteLine("\nEl evento '" + eventoCancelar.NombreEvento + "' ha sido cancelado.\n\n"); // <--- lo muestra por consola
											    }
											    else
											    {
											        Console.WriteLine("\nNúmero de evento inválido. Por favor, ingrese un número válido.\n\n");
											    }
				                    		
				                    		break; //FIN DEL CASE 2
				                    		
				                    	case 3: // ver eventos
				                    		verEventos(deFiesta);
												
				                    		break; //FIN DEL CASE 3
				                    		

				                    		
				                    	default: // volver atras. (28/10/2023): eliminé case 5 y 6
				                    		
				                			salir1 = true;
				                    		break;
				                    		
				                    } // switch case 1 (opcion1)

	                            } // try
                            
                            		catch (FormatException e)
					                {
					                    Console.WriteLine(e.Message);
					                }
                            	
                            } // while 
                            
                            break; //fin case 1 del MENU PRINCIPAL
 
                        case 2: // administrar servicios. - - - - - - - - - - - - - - - - - - - - - - - - - - - INICIO CASE 2
                            Console.WriteLine("\nHas elegido administrar los servicios.\n\n");
                            
                            bool salir2 = false;
                        
                            while (!salir2) {
                            	
                            	try {
	                            	Console.WriteLine("\n1. Agregar servicio.");
	                            	Console.WriteLine("2. Eliminar servicio.");
	                            	Console.WriteLine("3. Ver servicios.");
	                            	Console.WriteLine("4. Salir.");

	                            	Console.WriteLine("\nelige una opcion: \n");
                            		int opcion2 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion2) {
                            			case 1:
                            				
                            				int seleccionarServicio;
                            				
                            				do {
                            					Console.WriteLine("Seleccione el tipo de servicio: \n1. Catering, costo 300 \n2. Bebida, costo: 500 \n3. Bachero, costo: 1 \n4. Tropical, costo: 400 \n5. Inflables, costo: 1500 \n6. Barra-brava, costo: 2000 \n7. Salir \n\n");
                            					seleccionarServicio = int.Parse(Console.ReadLine());
                            					
                            					string tipoServicio, nombreServicio, DescripcionServicio;
                            					int cantidadServicio;
                            					double costoInicial;
                            					Servicio servicioNuevo;
                            					
                            					switch (seleccionarServicio) {
                            						case 1:
                            							nombreServicio = "Catarina Entertainment";
                            							tipoServicio = "Catering";
                            							costoInicial = 300;
                            							DescripcionServicio = "- Servicio de 'Catarina Entertainment' \n- Empleado: " + em1.Nombre + " " + em1.Apellido + "\n- La empresa proporciona: Veneno para ratas, un guaymallen de la escuela n° 12 y un ibuprofeno 600 \n- al extender la cantidad del servicio, sumaremos la cantidad de empleados que necesitemos.";
                            							Console.WriteLine("Definí la cantidad del servicio que necesitas: ");
                            							cantidadServicio = int.Parse(Console.ReadLine());
                            							
                            							
                            							// aca se agrega el servicio
														servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
														agregarServicio(deFiesta, servicioNuevo);
														
                            							break;
                            							
                            							
                            						case 2:
                            							nombreServicio = "Manuel Barras";
                            							tipoServicio = "Bebida";
                            							costoInicial = 500;
                            							cantidadServicio = 1;
                            							DescripcionServicio = "- Servicio proporcionado por 'Manuel Barras' \n- Empleado: " + em2.Nombre + " " + em2.Apellido + "\n- Cócteles: Gin Lima, Destornillador, Mula de Moscú, Cherry Blossom, Cosmopolitan, Sex on the beach, Permatrago \n- notas del Empleado: les juro que la bebida no contiene ningún tipo de leche.";
                            							
                            							// aca se agrega el servicio
                            							servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
                            							agregarServicio(deFiesta, servicioNuevo);

                            							break;
                            							
                            							
                            						case 3:
                            							nombreServicio = "Restaurante Hierbabuena";
                            							tipoServicio = "Bachero";
                            							costoInicial = 1;
                            							DescripcionServicio = "- Servicio Proporcionado por 'Restaurante Hierbabuena' \n- Empleado: " +  em3.Nombre + " " + em3.Apellido + "\n- al extender la cantidad del servicio, sumaremos la cantidad de empleados que necesitemos.";
                            							Console.WriteLine("Definí la cantidad del servicio que necesitas: ");
                            							cantidadServicio = int.Parse(Console.ReadLine());
                            							
                            							// aca se agrega el servicio
                            							servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
                            							agregarServicio(deFiesta, servicioNuevo);
														
                            							break;
                            							
                            							
                            						case 4:
                            							nombreServicio = "Cacho Mimoso";
                            							tipoServicio = "Tropical";
                            							costoInicial = 400;
                            							cantidadServicio = 1;
                            							DescripcionServicio = "- Servicio Proporcionado por 'Cacho Mimoso' \n- Empleado: " + em4.Nombre + " " + em4.Apellido + "\n- Canciones que toco: \n\n-- 'Yo me enamoré' \n-- 'Te vas a arrepentir' \n-- 'Y Ahota Te Vas' \n-- 'Choque 2' \n-- 'Doble Vida' \n-- 'El Mas Popular' \n-- 'Dios me libre' \n-- 'Amores como el nuestro' \n-- 'Como pude amarla' \n-- 'Loquito por ti'  \n-- 'Como Me Voy A Olvidar' \n-- 'No Me Arrepiento De Este Amor' \n\n- Notas del Cantante: 'Cuando me quedo sin el instrumento empiezo a tararear loco, no me importa nada.'";
                            							
                            							// aca se agrega el servicio
                            							servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
                            							agregarServicio(deFiesta, servicioNuevo);

                            							break;
                            							
                            							
                            						case 5:
                            							nombreServicio = "Sarandí de los inflables";
                            							tipoServicio = "Inflables";
                            							costoInicial = 1500;
                            							DescripcionServicio = "- Servicio Proporcionado por 'Sarandí de los inflables' \n- Empleado: " + em5.Nombre + " " + em5.Apellido + "\n- Material utilizado: Lona, Nailon para las redes, equipo de motor, soplador monofásico y una turbina. \n- Nota: mi hija me rompió el castillo de Anor Londo, por lo que queda deshabilitado temporalmente como opción negociable";
                            							
                            							Console.WriteLine("Definí la cantidad del servicio que necesitas: ");
                            							cantidadServicio = int.Parse(Console.ReadLine());
                            							
                            							// aca se agrega el servicio
                            							servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
                            							agregarServicio(deFiesta, servicioNuevo);

                            							break;
                            							
                            							
                            						case 6:
                            							nombreServicio = "LA BARRA 14";
                            							tipoServicio = "Barra Brava";
                            							costoInicial = 2000;
                            							cantidadServicio = 1;
                            							DescripcionServicio = "- Servicio Proporcionado por 'LA BARRA 14' \n- Empleado: " + em6.Nombre + " " + em6.Apellido + "\n- Condiciones: \n\n1. si so' de banfield te vamo' a buscar. \n\n- Te bancamos el presunto divorcio con las siguientes canciones: \n\n-- 'Alentando me quiero morir' \n-- 'Despacito' \n-- 'Grana, Mi Buen Amigo' \n-- 'La 14 Siempre Va' \n-- 'La Barra 14 siempre es una fiesta' \n-- 'La 14 del Tablón' \n-- 'Que Te Pasa Taladro' \n-- 'Señores Dejo Todo, Que Me Voy A Ver Al Grana' \n-- 'Vamos Vamos Vamos Los Granates' ";
                            							
                            							// aca se agrega el servicio
                            							servicioNuevo = new Servicio(nombreServicio, tipoServicio, DescripcionServicio, cantidadServicio, costoInicial);
                            							agregarServicio(deFiesta, servicioNuevo);

                            							break;
                            							
                            							
                            						case 7:
                            							seleccionarServicio = 0;
                            							break;
                            							
                            							
                            						default:
                            							Console.WriteLine("Ingrese una opción válida.");
                            							break;
                            							
                            					} // switch
                            					
                            				} while (seleccionarServicio != 0); // do-while "agregar servicios"
                            				break;
                            				
                            				
                            			case 2: // eliminar servicio
                            				eliminarServicio(deFiesta);
                            				break;
                            				
                            				
                            			case 3: // ver servicios
                            				Console.WriteLine("seleccione el evento que desea verle los servicios: ");
                            				verEventos(deFiesta);
											
                            				try {
                            					int LlamarPos = int.Parse(Console.ReadLine());
                            					verServicios(deFiesta, LlamarPos);
                            				} catch (System.IndexOutOfRangeException) {
												Console.WriteLine("No existe ese evento, intente de nuevo");
                            					throw;
                            				}

                            				break;

                            			case 4: // salir
                            				salir2 = true;
                            				break;
                            			
                            				
                            			default: // opcion invalida
                            				Console.WriteLine("\nSeleccione una opcion valida.\n");
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
                            		
                            		Console.WriteLine("\nelige una opcion: \n-----------------------------------------------------------------------\n");
                            		
	                            	Console.WriteLine("1. Ver empleados");
	                            	Console.WriteLine("2. Dar de Alta un empleado");
	                            	Console.WriteLine("3. Dar de Baja un empleado");
	                            	Console.WriteLine("4. Ver cantidad de empleados");
	                            	Console.WriteLine("5. Ver empleado por legajo");
	                            	Console.WriteLine("6. Volver atrás");

                            		int opcion3 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion3) {
                            				
                            			case 1:
                            				Console.WriteLine("Opción 1: \n*** VER LISTA DE EMPLEADOS ***");
                            				foreach(Personal em in deFiesta.ListaEmpleados)
                            				{
                            					Console.WriteLine("Empleado: "+ em.Nombre + " " + em.Apellido+". \nDNI: " + em.DNI + "\nDesempeña la tarea: " + em.Tarea+", por la cual cobra un sueldo de $" + em.Sueldo + ". \nLegajo: " + em.Legajo +".\n");
                            				}
                            				break; // Ver empleados
                            				
                            				
                            			case 2:
                            				string nombre, apellido, cargo;
											int dni = 0;
											double sueldo;
											
											Console.WriteLine("Opción 2: \n*** DAR DE ALTA UN EMPLEADO ***\n\nIngrese los datos pedidos a continuación para dar de alta al empleado nuevo.\n");
											Console.WriteLine("Ingrese el nombre del empleado nuevo");
											nombre = Console.ReadLine();
											Console.WriteLine("Ingrese el apellido del empleado nuevo");
											apellido = Console.ReadLine();
											Console.WriteLine("Ingrese la tarea que desempeña el empleado nuevo");
											cargo = Console.ReadLine();
											
											bool dniValido = false;
											
											do
											{
											    Console.WriteLine("Ingrese el DNI del empleado nuevo");
											    string inputdni = Console.ReadLine();
											
											    if (inputdni.Length == 8 && inputdni.All(char.IsDigit))
											    {
											        dni = int.Parse(inputdni);
											        dniValido = true;
											    }
											    else
											    {
											        Console.WriteLine("Ingrese un DNI válido, debe contener 8 dígitos y ser numérico.");
											    }
											
											} while (!dniValido);
											
											bool sueldoVal= false;

											do
											{
											    Console.WriteLine("Ingrese el sueldo del empleado nuevo");
											    string inputSueldo = Console.ReadLine();
											
											    if (double.TryParse(inputSueldo, out sueldo))
											    {
											        sueldoVal = true;
											    }
											    else
											    {
											        Console.WriteLine("Ingrese un sueldo válido, debe ser un número.");
											    }
											
											} while (!sueldoVal);
											
											
											Personal empleado = new Personal(nombre, apellido, cargo, dni, sueldo);
											
											Console.WriteLine("El empleado: " + empleado.Nombre + " " + empleado.Apellido + ". Cargo: " + empleado.Tarea + "\nHa sido agregado con éxito.");
											deFiesta.agregarEmpleado(empleado);
                            				break;// dar de alta
                            				
                            				
                            			case 3:
                            				Console.WriteLine("Opción 3: \n*** DAR DE BAJA UN EMPLEADO ***\n\nA continuación tiene una lista de los empleados que tiene a disposicion. Elija su ID para eliminarlo.\n");
                            				foreach(Personal em in deFiesta.ListaEmpleados)
                            				{
                            					Console.WriteLine("Empleado: "+em.Legajo+"\nNombre:"+ em.Nombre + " " + em.Apellido+"\nDNI: " + em.DNI + "\nTarea: " + em.Tarea+"\nSueldo $" + em.Sueldo +".\n\n");
                            				}
                            				int eleccion=0;
                            				
                            				bool opcionVal= false;

											do
											{
											    Console.WriteLine("Ingrese el legajo del empleado que desea eliminar:");
											    string inputElec = Console.ReadLine();
											
											    if (int.TryParse(inputElec, out eleccion))
											    {
											        opcionVal = true;
											    }
											    else
											    {
											        Console.WriteLine("Ingrese un legajo válido, debe ser un número, sin espacios ni letras.");
											    }
											
											} while (!opcionVal);
											
											foreach(Personal em in deFiesta.ListaEmpleados)
											{
												if(em.Legajo == eleccion)
												{
													Console.WriteLine("El empleado "+ em.Nombre+" "+em.Apellido+" coincide y será eliminado. . .");
													deFiesta.eliminarEmpleado(em);
													
													break;
												}
											}
											
											string texto = "//////////";
											foreach (char c in texto)
									        {
									            Console.Write(texto);
									            Thread.Sleep(100); 
									        }

        									Console.Write("100% . . ."); 
											Console.WriteLine("Empleado eliminado con éxito.");
											
                            				break; //DAR DE BAJA
                            			
                            				
                            			case 4:
                            				Console.WriteLine("Opción 4: \n*** VER CANTIDAD DE EMPLEADOS ***\n Posee a su disposicion: \n");
                            				Console.WriteLine("La cantidad de: "+ deFiesta.cantidadEmpleado() + " Empleados.");
                            				break; // CANTIDAD EMPLEADOS
                            				
                            				
                            			case 5:
                            				Console.WriteLine("Opción 5: \n*** VER EMPLEADOS POR LEGAJO *** \n");
                            				int eleccion2=0;
                            				bool opcionVal2= false;

											do
											{
											    Console.WriteLine("Ingrese el legajo del empleado que desea consultar:");
											    string inputElec = Console.ReadLine();
											
											    if (int.TryParse(inputElec, out eleccion2))
											    {
											        opcionVal2 = true;
											    }
											    else
											    {
											        Console.WriteLine("Ingrese un legajo válido, debe ser un número, sin espacios ni letras.");
											    }
											
											} while (!opcionVal2);
											
											foreach(Personal em in deFiesta.ListaEmpleados)
											{
												if(em.Legajo == eleccion2)
												{
													Console.WriteLine("Empleado:"+deFiesta.IndiceEmpleado(eleccion2).Nombre+"\nApellido: "+ deFiesta.IndiceEmpleado(eleccion2).Apellido +"\nDNI: "+ deFiesta.IndiceEmpleado(eleccion2).DNI+"\nCargo: "+deFiesta.IndiceEmpleado(eleccion2).Tarea+"\nSueldo: "+deFiesta.IndiceEmpleado(eleccion2).Sueldo+"\nLegajo: "+deFiesta.IndiceEmpleado(eleccion2).Legajo);
												}
											}
                            				break; // VER EMPLEADOS
                            				
                            				
                            			case 6:
                          					salir3 = true;
                            				break; // SALIR
                            				
                            				
                            			default:
                            				Console.WriteLine("Ingrese una opción válida. . .");
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
	                            	Console.WriteLine("\n1. Ver eventos");
	                            	Console.WriteLine("2. Ver servicios");
	                            	Console.WriteLine("3. Ver personal");
	                            	Console.WriteLine("4. Ver eventos por mes");
	                            	Console.WriteLine("5. Salir");

	                            	Console.WriteLine("\nElige una opcion: \n");
                            		int opcion4 = int.Parse(Console.ReadLine());
                            		
                            		switch (opcion4) {
                            			case 1:
                            				verEventos(deFiesta);
                            				break;
                            			case 2:
                            				Console.WriteLine("\nseleccione el evento que desea verle los servicios: ");
                            				verEventos(deFiesta);

                            				int LlamarPos = int.Parse(Console.ReadLine());
                            				
                            				verServicios(deFiesta, LlamarPos);
                            				break;
                            			case 3:
                            				Console.WriteLine("Opción 1: \n*** VER LISTA DE EMPLEADOS ***");
                            				foreach(Personal em in deFiesta.ListaEmpleados)
                            				{
                            					Console.WriteLine("Empleado: "+ em.Nombre + " " + em.Apellido+". \nDNI: " + em.DNI + "\nDesempeña la tarea: " + em.Tarea+", por la cual cobra un sueldo de $" + em.Sueldo +".\n");
                            				}
                            				break;
										case 4:
											Console.WriteLine("\nseleccione un numero indicando un mes para ver los eventos designados: \n");
											LlamarPos = int.Parse(Console.ReadLine());
											
											if (LlamarPos >= 1 && LlamarPos <= 12) {
												foreach (Evento evento in deFiesta.verEventos()) {
													if (evento.Fecha.Month == LlamarPos) {
														int contador = 1;
														Console.WriteLine("\n" + contador + ". Evento: " + evento.NombreEvento + " - Cliente: " + evento.Dni + " - Fecha: " + evento.Fecha.ToString("dd/MM/yyyy"));
														contador++;
													} // if
													
												} // foreach
												
											} // if
											
											else {
												Console.WriteLine("\n\ningrese un mes válido. \n\n");
											}
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
		
		// funcion ver Eventos
		
		static void verEventos(salon Salon) {
	        int contador;
			ArrayList lista;
			
			lista = Salon.verEventos();
			contador = 1;
			Console.WriteLine("\nLista de Eventos:\n");
			
			foreach (Evento evento in lista)
			{
				Console.WriteLine(contador + ". Evento: " + evento.NombreEvento + " - Cliente: " + evento.Dni + " - Fecha: " + evento.Fecha.ToString("dd/MM/yyyy") + "- Costo Final: " + evento.costoTotal() + "\n"); // solo aca se usa este nuevo metodo pero sirve para ver el costo final de cada evento
			    contador++;
			}
		}
		
		// funcion ver Servicios

		static void verServicios(salon s, int LlamarPos) {
			
			try {
				int contadorServicio;
	        	Evento eventoSeleccionado;
	    		ArrayList listaServicios;
				
				eventoSeleccionado = s.IndiceEvento(LlamarPos - 1);
				
				listaServicios = eventoSeleccionado.verServicio();
				
				contadorServicio = 1;
				
				if (listaServicios.Count == 0) {
					Console.WriteLine("\n\nEste evento no tiene servicios.\n\n");
				} else {
					
					double costoTotalEvento = 0;

					foreach (Servicio servicio in listaServicios) {
						costoTotalEvento += servicio.CostoFinal;
					}
					
					Console.WriteLine("\nLista de Servicios: \n");
					foreach (Servicio servicio in listaServicios) {
						Console.WriteLine(contadorServicio + ". Descripcion del servicio: \n" + servicio.DescripcionServicio + "\n");
						contadorServicio++;
					}
					
					Console.WriteLine("\n\nCosto total de servicios: $" + costoTotalEvento);
				}
			}
			 catch (Exception) {
				Console.WriteLine("\n\nEl evento seleccionado no existe, intente de nuevo\n\n");
			}
		}
		
		// funcion agregar Servicio
		
		static void agregarServicio(salon s, Servicio serv) {
			
			try {
				int LlamarPos;
				Evento eventoSeleccionado;
				
				Console.WriteLine("Defina con un numero al evento que desea añadirle el servicio: \n");
				verEventos(s);
				LlamarPos = int.Parse(Console.ReadLine());
				eventoSeleccionado = s.IndiceEvento(LlamarPos - 1);
				eventoSeleccionado.agregarServicio(serv);
				
				Console.WriteLine("Servicio Agregado a su evento Correctamente.\n\n");
			} catch (Exception) {
				
				Console.WriteLine("\n\nIntente tomar un evento válido\n\n");
			}

		}
		
		// funcion eliminar Servicio
		
		static void eliminarServicio(salon s) {
			try {
				int LlamarPos;
				int LlamarPosServicio;
				Servicio servicioSeleccionado;
				Evento eventoSeleccionado;
				
				Console.WriteLine("\nDefina con un numero al evento que desea eliminarle el servicio: \n\n");
				verEventos(s);
				LlamarPos = int.Parse(Console.ReadLine());
				eventoSeleccionado = s.IndiceEvento(LlamarPos - 1);
				
				try {
					if (eventoSeleccionado.verServicio().Count == 0) {
						throw new Exception();
					}
					else {
						Console.WriteLine("\nDefina con un numero el servicio que desea eliminar: \n\n");
						verServicios(s, LlamarPos);
						LlamarPosServicio = int.Parse(Console.ReadLine());
						servicioSeleccionado = eventoSeleccionado.indiceServicio(LlamarPosServicio - 1);
						
						eventoSeleccionado.eliminarServicio(servicioSeleccionado);
						
						Console.WriteLine("Servicio de: " + servicioSeleccionado.TipoServicio + " eliminado correctamente.\n\n");
					}
				} catch (Exception) {
					Console.WriteLine("\nEste evento no tiene servicios.\n");
				}
			} catch (Exception) {
				Console.WriteLine("\nEl evento definido no existe.\n");
			}

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

        public void agregarEmpleado(Personal e)
        {
            this.listaEmpleados.Add(e);
        }

		public void eliminarEmpleado(Personal e)
		{
			this.listaEmpleados.Remove(e);
		}

		public Boolean existenciaEmpleado(Personal e)
		{
			return this.listaEmpleados.Contains(e);
		}

		public int cantidadEmpleado()
		{
			return this.listaEmpleados.Count;
		}

		public Personal IndiceEmpleado(int pos)
		{
			return (Personal) listaEmpleados[pos];   
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
			return (Evento) listaEventos[pos];
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
		private static int contador =0; 						// se autoincrementa asignando un identificador a cada evento agregado.
		private DateTime fecha;
		private string nombreEvento;
		private string tipoEvento;
		private int id; 										// el identificador propio de cada evento.
		private Encargado encargadoEvento;
		
		private string dni;
		
		private ArrayList listaServicios;
		
		// constructor

		public Evento(string nombreEvento, string tipoEvento,string dni, DateTime fecha)
		{
			this.encargadoEvento = encargadoEvento;
			this.nombreEvento = nombreEvento;
			this.tipoEvento = tipoEvento;
			this.dni= dni;
			this.fecha = fecha;
			this.id = contador++;  								// El id asignado sera el actual de la clase evento, luego se incrementa. En este caso el id, tambien esta relacionado con el indice dentro de la lista de eventos.
		
			listaServicios = new ArrayList();
		}
		
		// propiedades
		public int ID{get{return id;}}

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
			// set { listaServicios = value; }
		}

		
		
		// metodos
		
		public double costoTotal() { // nuevo metodo genteeeeeeeeeeeeeeeeeeee
        
			double costoTotalEvento = 0;

        	foreach (Servicio servicio in listaServicios)
        	{
            	costoTotalEvento += servicio.CostoFinal;
        	}

        	return costoTotalEvento;
    	}

        public Boolean existenciaServicio(ArrayList n)
        {
            return this.listaServicios.Contains(n); 
        }

        public ArrayList verServicio()
        {
			return this.listaServicios;
        }

		public Servicio indiceServicio(int pos)
		{
			return (Servicio) listaServicios[pos];
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
			
			costoFinal = costoInicial * cantidadSolicitada;
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
	public class Personal
	{
		// variables
		protected string nombre, apellido, descripcionTarea;
		protected int dni, numeroLegajo;
		
		protected static int legajo = 0;
		protected double sueldo;
		
		// constructor

		public Personal(string nombre, string apellido, string descripcionTarea, int dni, double sueldo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.descripcionTarea = descripcionTarea;
			this.dni = dni;
			this.sueldo = sueldo;

			numeroLegajo = legajo ++;
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
		
		public int Legajo
		{
			get{return numeroLegajo;}
		}
		
	}
	
	//Clase para el Encargado, solo tenemos en cuenta el plus de su sueldo,
	//	ya que menesteres como su funcion se heredan de la clase empleado
	
	public class Encargado : Personal
	{
		private double plusSueldo = 0.1; // new para confirmar q estoy cumpliendo con el ocultamiento de la variable
		
		public Encargado(string nombre, string apellido, string descripcionTarea,int dni, double sueldo) : base(nombre, apellido, descripcionTarea, dni, sueldo)
		{
			this.sueldo = sueldo;
		}
		
		public double PLUSSueldo {
			get {
				return sueldo * plusSueldo;
			}
			set {
				sueldo = value;
			}
		}
		
	}
	public class Empleado : Personal
	{
		public Empleado(string nombre, string apellido , string descripcionTarea,int dni, double sueldo) : base(nombre, apellido, descripcionTarea, dni, sueldo)
		{
			
		}
	}
}

class NoINTException : Exception
{
	
}