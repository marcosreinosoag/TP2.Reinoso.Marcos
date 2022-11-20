using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoBaseDeDatos
    {
        static string connectionString;
        static SqlConnection connection;
        static SqlCommand command;

        static AccesoBaseDeDatos()
        {
            connectionString = @"Server = .\MSSQLSERVER01; Database = TrucoArg_DB; Trusted_Connection=True;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;

            command.CommandType = CommandType.Text;
        }
        public List<Jugador> ObtenerJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();
            if (connection is not null)
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Jugadores ";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    DateTime fechaDeNacimiento = reader.GetDateTime(3);
                    int puntajePartida = reader.GetInt32(4);
                    int partidasGanadas = reader.GetInt32(5);

                    Jugador auxJugador = new Jugador(id, nombre, apellido, fechaDeNacimiento, puntajePartida, partidasGanadas);
                    jugadores.Add(auxJugador);
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return jugadores;
            }
            return jugadores;
        }
        public void AgregarJugador(Jugador jugador)
        {
            if (connection is not null)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO Jugadores VALUES (@Nombre, @Apellido,@FechaDeNacimiento,@PuntajePartida,@PartidasGanadas)";
                    command.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                    command.Parameters.AddWithValue("@Apellido", jugador.Apellido);
                    command.Parameters.AddWithValue("@FechaDeNacimiento", jugador.FechaNacimiento);
                    command.Parameters.AddWithValue("@PuntajePartida", jugador.PuntajePartida);
                    command.Parameters.AddWithValue("@PartidasGanadas", jugador.PartidasGanadas);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void ModificarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();
                command.CommandText = "UPDATE Jugadores Set Nombre = @Nombre, Apellido = @Apellido, FechaDeNacimiento = @FechaDeNacimiento, PuntajePartida = @PuntajePartida, PartidasGanadas = @PartidasGanadas WHERE Id = @Id";

                command.Parameters.AddWithValue("@Id", jugador.Id);
                command.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                command.Parameters.AddWithValue("@Apellido", jugador.Apellido);
                command.Parameters.AddWithValue("@FechaDeNacimiento", jugador.FechaNacimiento);
                command.Parameters.AddWithValue("@PuntajePartida", jugador.PuntajePartida);
                command.Parameters.AddWithValue("@PartidasGanadas", jugador.PartidasGanadas);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void EliminarJugador(Jugador jugador)
        {
            try
            {
                connection.Open();
                command.CommandText = "Delete Jugadores WHERE Id = @id";
                command.Parameters.AddWithValue("@id", jugador.Id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void AgregarSala(Sala sala)
        {
            if (connection is not null)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO Salas VALUES (@Numero, @Descripcion)";
                    command.Parameters.AddWithValue("@Numero", sala.NumeroDeSala);
                    command.Parameters.AddWithValue("@Descripcion", sala.Descripcion);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public void AgregarPartida(Sala sala)
        {
            if (connection is not null)
            {
                try
                {
                    Jugador? jugadorGanador = sala.JugadorGanador;
                    int idJGanador = jugadorGanador.Id;
                    connection.Open();
                    command.CommandText = "INSERT INTO Partidas VALUES (@NumeroDeSala,@IdJugadorUno,@IdJugadorDos,@IdGanador,@Descripcion)";
                    command.Parameters.AddWithValue("@NumeroDeSala", sala.NumeroDeSala);
                    command.Parameters.AddWithValue("@IdJugadorUno", sala.IdJugadorUno);
                    command.Parameters.AddWithValue("@IdJugadorDos", sala.IdJugadorDos);
                    command.Parameters.AddWithValue("@IdGanador", idJGanador);
                    command.Parameters.AddWithValue("@Descripcion", sala.Descripcion);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        public List<string> ObtenerPartidas()
        {
            List<string> jugadores = new List<string>();
            if (connection is not null)
            {
                connection.Open();
                command.CommandText = "SELECT NumeroDeSala, Descripcion, Nombre, Apellido FROM Partidas JOIN Jugadores ON Jugadores.Id = Partidas.IdGanador";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int  numeroSala = reader.GetInt32(0);
                    string descripcion = reader.GetString(1);
                    string nombre = reader.GetString(2);
                    string apellido = reader.GetString(3);

                    string auxPartida = $"{numeroSala}  {descripcion}\t Ganador: {nombre} {apellido}";
                    jugadores.Add(auxPartida);
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return jugadores;
            }
            return jugadores;
        }

    }
}
