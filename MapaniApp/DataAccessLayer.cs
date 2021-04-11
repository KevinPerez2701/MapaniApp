using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase Encargada de la interraccion con la base de datos SQL
/// </summary>
namespace MapaniApp
{
    class DataAccessLayer

    {
        private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-OLASR82");
        #region AGREGAR CONTACTOS
        public void InserContactNMB(ContactNMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaNMB ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto])  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(foto);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public void InserContactCuidador(ContactCuidador contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaCuidador ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono])  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@Telefono)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        public void InserContactMMB(ContactMMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaMMB ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono])  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@Telefono)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
        #endregion
        #region BUSQUEDA DE DATOS EN BDD
        public List<ContactNMB> GetContacts(string Search = null)
        {
            List<ContactNMB> contactsNMB = new List<ContactNMB>();

            try
            {
                Connection.Open();
                string query = @"Select Id,Nombre,Apellido,FechaNacimiento,Direccion,Sexo,foto FROM TablaNMB Where Id=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
             /*   if (!string.IsNullOrEmpty(Search))
                {
                    query += @"WHERE Id=@Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{Search}%"));

                }*/
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactsNMB.Add(new ContactNMB
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento =(DateTime)reader["FechaNacimiento"],
                        Direccion = reader["Direccion"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                       // IdCuidador = int.Parse(reader["IdCuidador"].ToString()),
                        Foto = (byte[])reader["Foto"],
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contactsNMB;
        }
        public List<ContactCuidador> GetContactsCuidador(string Search = null)
        {
            List<ContactCuidador> contactsCuidador = new List<ContactCuidador>();

            try
            {
                Connection.Open();
                string query = @"Select Id,Nombre,Apellido,FechaNacimiento,Direccion,Sexo,foto FROM TablaCuidador Where Id=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                /*   if (!string.IsNullOrEmpty(Search))
                   {
                       query += @"WHERE Id=@Search";
                       command.Parameters.Add(new SqlParameter("@Search", $"%{Search}%"));

                   }*/
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactsCuidador.Add(new ContactCuidador
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Direccion = reader["Direccion"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                        Foto = (byte[])reader["Foto"],
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contactsCuidador;
        }
        public List<ContactMMB> GetContactsMMB(string Search = null)
        {
            List<ContactMMB> contactsMMB = new List<ContactMMB>();

            try
            {
                Connection.Open();
                string query = @"Select Id,Nombre,Apellido,FechaNacimiento,Direccion,Sexo,foto FROM TablaMMB Where Id=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                /*   if (!string.IsNullOrEmpty(Search))
                   {
                       query += @"WHERE Id=@Search";
                       command.Parameters.Add(new SqlParameter("@Search", $"%{Search}%"));

                   }*/
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactsMMB.Add(new ContactMMB
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Direccion = reader["Direccion"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                        Foto = (byte[])reader["Foto"],
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contactsMMB;
        }
        public List<ContactCuidador> GetCuidadores(string Search = null)
        {
            List<ContactCuidador> contacts = new List<ContactCuidador>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Referencia
                                Join TablaCuidador
                                on TablaCuidador.Id = Referencia.Cuidador
                                where Referencia.NMB = @search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new ContactCuidador
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contacts;
        }
        public List<ContactNMB> GetNMB(string Search = null)
        {
            List<ContactNMB> contacts = new List<ContactNMB>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Referencia
                                Join TablaNMB
                                on TablaNMB.Id = Referencia.NMB
                                where Referencia.Cuidador = @search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new ContactNMB
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contacts;
        }
        public List<ContactMMB> GetMMB(string Search = null)
        {
            List<ContactMMB> contacts = new List<ContactMMB>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From ReferenciaMMB
                                Join TablaNMB
                                on TablaNMB.Id = ReferenciaMMB.NMB
                                where ReferenciaMMB.MMB = @search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new ContactMMB
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return contacts;
        }
        public List<HistorialVisitas> GetHistorial (string Search = null)
        {
            List<HistorialVisitas> Historial = new List<HistorialVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Visitas
                                where Visitas.NMB = @Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Historial.Add(new HistorialVisitas
                    {
                        IdNMB = int.Parse(reader["NMB"].ToString()),
                        IdCuidador = int.Parse(reader["Cuidador"].ToString()),
                        Fecha = (DateTime)reader["Fecha"],
                        Departamento = reader["Departamento"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Historial;
        }
        public List<ProximasVisitas> GetProximas(string Search = null)
        {
            List<ProximasVisitas> Proximas = new List<ProximasVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From ProximasVisitas
                                where ProximasVisitas.NMB = @Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Proximas.Add(new ProximasVisitas
                    {
                        IdNMB = int.Parse(reader["NMB"].ToString()),
                        Fecha = (DateTime)reader["Fecha"],
                        Departamento = reader["Departamento"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Proximas;
        }
        public List<ProximasVisitas> GetCitas(string Search = null)
        {
            List<ProximasVisitas> Citas = new List<ProximasVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select NMB,Nombre, Apellido,FechaNacimiento, Fecha,Departamento
                                           From TablaNMB,ProximasVisitas
                               where ProximasVisitas.Fecha =@Search and ProximasVisitas.NMB=TablaNMB.Id";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", Search));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   Citas.Add(new ProximasVisitas
                    {
                        IdNMB = int.Parse(reader["NMB"].ToString()),
                        Nombre= reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Fecha = (DateTime)reader["Fecha"],
                        Departamento = reader["Departamento"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Citas;
        }
        #endregion
    }

}
