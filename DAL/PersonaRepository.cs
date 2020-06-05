using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;
namespace DAL
{
    public class PersonaRepository
    {
            private readonly SqlConnection _connection;

            public PersonaRepository(ConnectionManager connection)
            {
                _connection = connection._conexion;
            }
        public void Guardar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Persona (Identificacion,Nombre,Edad, Sexo,Email,Pulsacion) 
                                        values (@Identificacion,@Nombre,@Edad,@Sexo,@Email,@Pulsacion)";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Sexo", persona.Sexo);
                command.Parameters.AddWithValue("@Edad", persona.Edad);
                command.Parameters.AddWithValue("@Email", persona.Email);
                command.Parameters.AddWithValue("@Pulsacion", persona.Pulsacion);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from persona where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        public List<Persona> ConsultarTodos()
        {
            List<Persona> personas = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Identificacion,Nombre,Edad, Sexo, Email, Pulsacion from persona ";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = DataReaderMapToPerson(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }
        public List<Persona> ConsultarMujer()
        {
            List<Persona> personas = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = " select * from Persona WHERE Sexo='F'";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = DataReaderMapToPerson(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }
        public List<Persona> ConsultarHombre()
        {
            List<Persona> personas = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = " select * from Persona WHERE Sexo='M'";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = DataReaderMapToPerson(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }
        public Persona BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from persona where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }

        public void Modificar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update Persona set Nombre=@Nombre,Edad=@Edad, Sexo=@Sexo,Email=@Email Pulsacion= @Pulsacion 
                                        where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Sexo", persona.Sexo);
                command.Parameters.AddWithValue("@Edad", persona.Edad);
                command.Parameters.AddWithValue("@Email", persona.Email);
                command.Parameters.AddWithValue("@Pulsacion", persona.Pulsacion);
                var filas = command.ExecuteNonQuery();
            }
        }
        private Persona DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Persona persona = new Persona();
            persona.Identificacion = (string)dataReader["Identificacion"];
            persona.Nombre = (string)dataReader["Nombre"];
            persona.Sexo = (string)dataReader["Sexo"];
            persona.Edad = (int)dataReader["Edad"];
            persona.Email = (string)dataReader["Email"];
            persona.Pulsacion = (decimal)dataReader["Pulsacion"];
            return persona;
        }
        public int Totalizar()
        {

            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.Sexo.Equals(tipo)).Count();
        }
    }
}
