using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using AsociacionSantamarta.Modelo;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace AsociacionSantamarta.Logica
{
    public class PersonaLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PersonaLogica _instancia = null;

       

        public static PersonaLogica Instancia
        {
            get 
            {
                    if(_instancia == null)
                    {
                    _instancia = new PersonaLogica();
                    }

                    return _instancia;
            }

        }

        public bool Guardar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                // Primero, verifica si el ID ya existe
                string queryCheck = "SELECT COUNT(*) FROM Persona WHERE Id = @id";
                SQLiteCommand cmdCheck = new SQLiteCommand(queryCheck, conexion);
                cmdCheck.Parameters.Add(new SQLiteParameter("@id", obj.Id));
                cmdCheck.CommandType = System.Data.CommandType.Text;
                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (count > 0)
                {
                    // Si el ID ya existe, muestra un mensaje y cambia la respuesta a false
                    MessageBox.Show("El ID ya está en uso. Por favor, elige otro.");
                    respuesta = false;
                }
                else
                {
                    // Si el ID no existe, procede a insertarlo
                    string query = "INSERT INTO Persona(Id, Nombre, Apellido, Dni) VALUES (@id, @nombre, @apellido, @dni)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", obj.Id));
                    cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@dni", obj.Dni));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }

            return respuesta;
        }

        public List<Persona> Listar()
        {
            List<Persona> oLista = new List<Persona>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select Id, Nombre, Apellido, Dni from Persona";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader()) 
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Persona() 
                        { 
                            Id =Int32.Parse (dr["ID"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Dni =dr["Dni"].ToString(),
                        });
                    }
                }
            }
            return oLista;
        }

        public bool editar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "UPDATE Persona SET Nombre = @nombre, Apellido = @apellido, Dni = @dni WHERE Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.Id));
                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@dni", obj.Dni));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool eliminar(Persona obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "DELETE from Persona WHERE Id = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@id", obj.Id));
               
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}
