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
       // private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-A51VEQA");
       private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-OLASR82");
        #region AGREGAR CONTACTOS
        /// <summary>
        /// Inserta el contacto NMB en la base de datos
        /// </summary>
        /// <param name="contact"></param>
        public void InserContactNMB(ContactNMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaNMB ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],Cedula,FechaIngreso,Discapacidad,Vacunas,LactanciaMaterna,Parto,IngresoPrograma,PartidaNacimiento)  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@cedula,@fechaIngreso,@Discapacidad,@Vacunas,@LactanciaMaterna,@Parto,@ingreso,@PartidaNacimiento)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Cedula = new SqlParameter("@cedula", contact.Cedula);
                SqlParameter FechaIngreso = new SqlParameter("@fechaIngreso", contact.FechaIngreso);
                SqlParameter Discapacidad = new SqlParameter("@Discapacidad", contact.Discapacidad);
                SqlParameter Vacunas = new SqlParameter("@Vacunas", contact.Vacunas);
                SqlParameter Parto = new SqlParameter("@Parto", contact.Parto);
                SqlParameter Ingreso = new SqlParameter("@ingreso", contact.Ingreso);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter LactanciaMaterna = new SqlParameter("@LactanciaMaterna", contact.Lactancia);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter PartidaNacimiento = new SqlParameter("@PartidaNacimiento", contact.PartidaNacimiento);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(foto);
                command.Parameters.Add(FechaIngreso);
                command.Parameters.Add(Parto);
                command.Parameters.Add(Vacunas);
                command.Parameters.Add(LactanciaMaterna);
                command.Parameters.Add(Ingreso);
                command.Parameters.Add(Discapacidad);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(PartidaNacimiento);
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
        /// <summary>
        /// Idem pero Cuidador en TablaCuidador
        /// </summary>
        /// <param name="contact"></param>
        public void InserContactCuidador(ContactCuidador contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaCuidador ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono],EstadoCivil,Cedula,Hijos,Transporte)  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@Telefono,@EstadoCivil,@Cedula,@Hijos,@Transporte)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Hijos = new SqlParameter("@Hijos", contact.CantidadHijos);
                SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.Parameters.Add(EstadoCivil);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(Transporte);
                command.Parameters.Add(Hijos);
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
        /// <summary>
        /// Idem Pero Con MMB, en TablaMMB
        /// </summary>
        /// <param name="contact"></param>
        public void InserContactMMB(ContactMMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaMMB ([Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono],Cedula,Transporte,EstadoCivil,CantidadHijos)  
                                    Values(@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@Telefono,@Cedula,@Transporte,@EstadoCivil,@CantidadHijos)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Hijos = new SqlParameter("@CantidadHijos", contact.CantidadHijos);
                SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.Parameters.Add(EstadoCivil);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(Transporte);
                command.Parameters.Add(Hijos);
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
        /// <summary>
        /// Inserta una cita proxima en la tabla de ProximasVisitas para el NMB
        /// </summary>
        /// <param name="Cita"></param>
        public void InserCita(ProximasVisitas Cita)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into ProximasVisitas ([NMB], [Fecha], [Departamento])  
                                    Values(@IdNMB,@Fecha,@Departamento)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
                SqlParameter Fecha= new SqlParameter("@Fecha", Cita.Fecha);
                SqlParameter Departamento = new SqlParameter("@Departamento", Cita.Departamento);
               
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Departamento);
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
        /// <summary>
        /// Inserta en el Historial de visitas la Cita una vez que fue confirmada, incluyendo el Id de cuidador que lo trajo
        /// </summary>
        /// <param name="Cita"></param>
        public void ConfirmCita(HistorialVisitas Cita)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into Visitas ([NMB], [Cuidador], [Fecha], [Departamento])  
                                    Values(@IdNMB,@IdCuidador,@Fecha,@Departamento)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
                SqlParameter IdCuidador = new SqlParameter("@IdCuidador", Cita.IdCuidador);
                SqlParameter Fecha = new SqlParameter("@Fecha", Cita.Fecha);
                SqlParameter Departamento = new SqlParameter("@Departamento", Cita.Departamento);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(IdCuidador);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Departamento);
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
        /// <summary>
        /// Elimina la Cita de Proximas Visitas una vez que fue confirmada
        /// </summary>
        /// <param name="Cita"></param>
        public void DeleteCita(HistorialVisitas Cita)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Delete From ProximasVisitas  
                                    Where NMB=@IdNMB and Fecha=@Fecha and Departamento=@Departamento";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
 
                SqlParameter Fecha = new SqlParameter("@Fecha", Cita.Fecha);
                SqlParameter Departamento = new SqlParameter("@Departamento", Cita.Departamento);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Departamento);
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
        public void InsertRelacion(string IdNMB,string IdCuidador, string Parentesco)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into Referencia(NMB,Cuidador,Parentesco) 
                                    Values(@IdNMB,@IdCuidador,@Parentesco)";
                SqlParameter NMB = new SqlParameter("@IdNMB",int.Parse(IdNMB));
                SqlParameter Cuidador = new SqlParameter("@IdCuidador", int.Parse(IdCuidador));
                SqlParameter Relacion = new SqlParameter("@Parentesco", Parentesco);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Cuidador);
                command.Parameters.Add(Relacion);

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
        public void InsertRelacionMMB(string IdNMB, string IdMMB, string Parentesco)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into ReferenciaMMB(NMB,MMB,Parentesco) 
                                    Values(@IdNMB,@IdMMB,@Parentesco)";
                SqlParameter NMB = new SqlParameter("@IdNMB", int.Parse(IdNMB));
                SqlParameter MMB = new SqlParameter("@IdMMB", int.Parse(IdMMB));
                SqlParameter Relacion = new SqlParameter("@Parentesco", Parentesco);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(MMB);
                command.Parameters.Add(Relacion);
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
        /// <summary>
        /// Busca en la base de datos el contacto con el Id unico de NMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<ContactNMB> GetContacts(string Search = null)
        {
            List<ContactNMB> contactsNMB = new List<ContactNMB>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaNMB Where Id=@Search";
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
                        FechaIngreso = (DateTime)reader["FechaIngreso"],
                        Direccion = reader["Direccion"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                        Foto = (byte[])reader["Foto"],
                        Cedula = reader["Cedula"].ToString(),
                        Ingreso = reader["IngresoPrograma"].ToString(),
                        Vacunas = reader["Vacunas"].ToString(),
                        Parto = reader["Parto"].ToString(),
                        PartidaNacimiento = reader["PartidaNacimiento"].ToString(),
                        Discapacidad = reader["Discapacidad"].ToString(),
                        Lactancia = reader["LactanciaMaterna"].ToString(),
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
        /// <summary>
        /// Idem pero Buscar el Cuidador por el Id unico
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<ContactCuidador> GetContactsCuidador(string Search = null)
        {
            List<ContactCuidador> contactsCuidador = new List<ContactCuidador>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaCuidador Where Id=@Search";
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
                        Telefono = reader["Telefono"].ToString(),
                        EstadoCivil=reader["EstadoCivil"].ToString(),
                        CantidadHijos = reader["Hijos"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Transporte= reader["Transporte"].ToString(),
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
        /// <summary>
        /// Busqueda del Cuidador Por Cedula para el departamento Transcripcion con parametro Cedula
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<ContactCuidador> GetCedulaCuidador(string Search = null)
        {
            List<ContactCuidador> contactsCuidador = new List<ContactCuidador>();

            try
            {
                Connection.Open();
                string query = @"Select Id,Nombre,Apellido,FechaNacimiento,Direccion,Sexo,foto,Cedula,Telefono,EstadoCivil,Transporte,Hijos FROM TablaCuidador Where Cedula=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", Search));
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
                        Cedula = reader["Cedula"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        EstadoCivil = reader["EstadoCivil"].ToString(),
                        CantidadHijos = reader["Hijos"].ToString(),
                        Transporte = reader["Transporte"].ToString(),
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
        /// <summary>
        /// Idem Pero con MMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<ContactMMB> GetContactsMMB(string Search = null)
        {
            List<ContactMMB> contactsMMB = new List<ContactMMB>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaMMB Where Id=@Search";
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
                        Cedula = reader["Cedula"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        EstadoCivil = reader["EstadoCivil"].ToString(),
                        CantidadHijos = reader["CantidadHijos"].ToString(),
                        Transporte = reader["Transporte"].ToString(),
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
        /// <summary>
        /// Obtiene la lista de cuidadores asociados a un Id de NMB por la tabla de Relacion
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Idem pero en este caso las relaciones de NMB con cuidadores
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Idem pero Obtiene la relacion de las MMB con los NMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Busca en la tabla de Visitas el historial de Citas que ha tenido el NMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Obtiene de la BBDD las Proximas Visitas asociadas al parametro ID del NMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Obtiene las citas a partir del parametro de busqueda de una fecha para las citas del dia
        /// </summary>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        public List<ProximasVisitas> GetCitas(DateTime Fecha )
        {
            List<ProximasVisitas> Citas = new List<ProximasVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select NMB,Fecha,Departamento,Nombre, Apellido,FechaNacimiento
                                           From ProximasVisitas, TablaNMB
                               where ProximasVisitas.Fecha =@Fecha and ProximasVisitas.NMB=TablaNMB.Id"; //and ProximasVisitas.NMB=TablaNMB.Id" Nombre, Apellido,FechaNacimiento,
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Fecha",Fecha));
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
        public string Login(string User,string Password)
        {
            string posicion = "" ;
            try
            {
                Connection.Open();
                string query = @"Select Position
                                From MapaniUsers
                               where MapaniUsers.LoginName=@User and MapaniUsers.Password=@Password"; //and ProximasVisitas.NMB=TablaNMB.Id" Nombre, Apellido,FechaNacimiento,
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@User", User));
                command.Parameters.Add(new SqlParameter("@Password", Password));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posicion = reader["Position"].ToString();
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
            return posicion;
        }
        #endregion
    }

}
