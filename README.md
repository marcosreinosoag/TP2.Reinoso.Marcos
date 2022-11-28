                                                            Trabajo Practico N° 2
                                                     
Este programa consiste en la creacion del juego de mesa Truco, donde se pueden crear y simular 6 partidas en simultaneo.
A continuacion dare un breve instructivo del programa.

Loguin

En el inicio del programa se encuentra el loguin.

![image](https://user-images.githubusercontent.com/68253845/204281252-96e943ec-9490-40da-a9a9-3e6f5b99fb79.png)

Ingresando el usuario y contraseña y seleccionando el boton ingresar usted podra ingresar al programa, caso contrario puede seleccionar el boton Admin para que autocomplete los datos y clickear el boton ingresar.

Munu Pricipal

Una vez que se logueo en el programa visiaulizara la siguiente pestaña:

![image](https://user-images.githubusercontent.com/68253845/204283580-c8bfed9b-0790-416e-8280-4963ae63dba8.png)
 
 A simple vista se pueden ver las salas disponibles, las mismas cuentan con tres estados.
 
 Disponible(color gris)
 
 ![image](https://user-images.githubusercontent.com/68253845/204284849-d9896ccd-e725-4f3d-a612-9be254b19972.png)
 
 Partida inicializada (Color verde)
 
 ![image](https://user-images.githubusercontent.com/68253845/204285206-0e6fdd63-db95-45cb-ae27-f3bd193fff14.png)
 
 Cancelada(Color amarillo)
 ![image](https://user-images.githubusercontent.com/68253845/204284578-0d83b060-9e39-40c0-a194-ac21de5e4f67.png)

Partida finalizada(color azul)

![image](https://user-images.githubusercontent.com/68253845/204285378-f21969eb-f846-46da-9061-5f57960293c8.png)



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

-Eventos: se crea el evento PartidaTerminada en la clase Sala el cual notifica al usuario cuando una partida fue cancelada.



 
