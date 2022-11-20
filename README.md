                                                     Trabajo Practico N° 2
                                                     
Este programa consiste en la creacion del juego de mesa Truco se pueden crear y simular 6 partidas en simultaneo.

Temas Aplicados:

-Excepciones:

Se crearon excepciones personalizadas para los distintos casos de error posible, por ejemplo en la carga de los usuarios (Clase: TRUCOARG linea: 32) el metodo leerUsuarios() lee los usuarios desde un archivo, en caso de error se realiza la carga de una copia que esta en el metodo HardcodearUsuarios().

-Generic:

La clase Serializacion, utiliza genericos para poder leer y escribe distintos tipos de datos en archivos Json.
Por ejemplo: leer un archivo Json y el tipo de dato a leer sea un Usuario o una carta.

-Interfaces

Se creo la interfaz IInformacion que implementa tanto la clase Jugador y Carta, la cual obliga a los que la implementen  usar el metodo MostrarInformacion() y devolver toda la informacion necesaria de la instancia del objeto que la este invocando.

-Archivos Y Serializacion

Se utiliza la escritura de archivos de texto para registrar el ingreso y egreso al programa.

-Pruebas Unitarias

No llegue con el tiempo, perdon :c.

-SQL, Conexion a base de Datos:

Se realizo la clase AccesoBaseDeDatos donde se realizan el ABM de los jugadores, alta y las consultas de las partidas jugadas.

-Expresiones Lambda:

Se utilizan en bastantes partes del programa, por ejemplo en el formulario Menu_Principal linea 30 se utiliza una expresion lambda para indicarle al hilo que metodo debe correr, tambien en la clase Sala linea 88 para cargar en el historial de la partida las cartas quie tiene el jugador.

-Hilos

Se crearon hilos en a creacion de las partidas (Formulario Menu Principal linea 100) donde se crea cada hilo por partida, tambien los botones que muetran el estado de cada sala tiene un hilo para cambiarle el color dependiendo si la partida sigue corriendo, termino, fue cancelada o nunca se instancio.

-Delegados: se creo el delegado PartidaTerminada que retorna void y recibe un string. se utiliza para crear un evento.

-Eventos: se crea el evento PartidaTerminada el cual notifica al usuario cuando una partida fue cancelada.



 
