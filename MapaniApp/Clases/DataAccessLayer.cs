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
      private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-A51VEQA");
     // private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-OLASR82");
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
        public void UpdateContactNMB(ContactNMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Update TablaNMB Set Nombre=@Nombre, Apellido=@Apellido, [FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@Foto,Cedula=@Cedula,FechaIngreso=@FechaIngreso,Discapacidad=@Discapacidad,Vacunas=@Vacunas,LactanciaMaterna=@LactanciaMaterna,Parto=@Parto,IngresoPrograma=@Ingreso,PartidaNacimiento=@PartidaNacimiento  
                                   where TablaNMB.Id=@Id";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Id = new SqlParameter("@Id", contact.Id);
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
                command.Parameters.Add(Id);
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
        public void UpdateContactCuidador(ContactCuidador contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Update TablaCuidador SET [Nombre]=@Nombre, [Apellido]=@Apellido, [FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@foto,[Telefono]=@Telefono,EstadoCivil=@EstadoCivil,Cedula=@Cedula,Hijos=@Hijos,Transporte=@Transporte  
                                   Where TablaCuidador.Id = @Id";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Id = new SqlParameter("@Id", contact.Id);
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
                command.Parameters.Add(Id);
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
        public void UpdateContactMMB(ContactMMB contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Update TablaMMB SET [Nombre]=@Nombre, [Apellido]=@Apellido, [FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@foto,[Telefono]=@Telefono,EstadoCivil=@EstadoCivil,Cedula=@Cedula,CantidadHijos=@Hijos,Transporte=@Transporte  
                                   Where TablaMMB.Id = @Id";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Id = new SqlParameter("@Id", contact.Id);
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
                command.Parameters.Add(Id);
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
                                    Insert into ProximasVisitas ([NMB], [Fecha], [Departamento],Doctor)  
                                    Values(@IdNMB,@Fecha,@Departamento,@Rol)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
                SqlParameter Fecha= new SqlParameter("@Fecha", Cita.Fecha);
                SqlParameter Departamento = new SqlParameter("@Departamento", Cita.Departamento);
                SqlParameter Rol = new SqlParameter("@Rol", Cita.Rol);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Rol);
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
        /// Inserta La asistencia unica por dia de los integrantes de MapaniUsers.
        /// </summary>
        /// <param name="Asistencia"></param>
        public void InsertAsistencia(List<MapaniUsers> Asistencia)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaAsistencia ([IdTrabajador], [Fecha],Rol,Hora)  
                                    Values(@Id,@Fecha,@Rol,@Hora)";
                SqlParameter IdNMB = new SqlParameter("@Id", Asistencia[0].Id);
                SqlParameter Fecha = new SqlParameter("@Fecha",Asistencia[0].Fecha);
                SqlParameter Rol = new SqlParameter("@Rol", Asistencia[0].Rol);
                SqlParameter Hora = new SqlParameter("@Hora", Asistencia[0].HoraEntrada);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Rol);
                command.Parameters.Add(Hora);
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
        public void Salida(List<MapaniUsers> Asistencia)
        {
            try
            {
                Connection.Open();
                string query = @"                                     
                                    UPDATE TablaAsistencia SET HoraSalida = @Salida 
                                    where TablaAsistencia.IdTrabajador = @Id and TablaAsistencia.Fecha =@Fecha";
                SqlParameter IdNMB = new SqlParameter("@Id", Asistencia[0].Id);
                SqlParameter Fecha = new SqlParameter("@Fecha", Asistencia[0].Fecha);
                SqlParameter Salida = new SqlParameter("@Salida", Asistencia[0].HoraSalida);             
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Salida);        
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
        /// Inserta una Orden de Pediatria o Nutricion en la Base de datos y queda como diferido hasta que se entregue.
        /// </summary>
        /// <param name="Orden"></param>
        public void InsertOrden(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into Ordenes ([IdNMB], [IdProducto], [Nombre],Programa,Fecha,Pediatra,Cantidad)  
                                    Values(@IdNMB,@IdProducto,@Nombre,@Programa,@Fecha,@Pediatra,@Cantidad)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", int.Parse(Orden.IdNMB));
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);
                SqlParameter Nombre = new SqlParameter("@Nombre", Orden.Nombre);
                SqlParameter Programa = new SqlParameter("@Programa", Orden.Programa);
                SqlParameter Pediatra = new SqlParameter("@Pediatra", Orden.Pediatra);
                SqlParameter Fecha = new SqlParameter("@Fecha", Orden.Fecha);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", Orden.Cantidad);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(IdProducto);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Programa);
                command.Parameters.Add(Pediatra);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Cantidad);
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
        /// Inserta en la base de datos el despacho de la orden creada por el pediatra o Nutricionista para entregar. Resta la cantidad del almacen.
        /// </summary>
        /// <param name="Orden"></param>
        public void InsertDespacho(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"   UPDATE Ordenes SET Despachado = 'Si' 
                                    Where (Ordenes.IdNMB = @IdNMB and Ordenes.IdProducto = @IdProducto and Fecha = @Fecha)
                                    ";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", int.Parse(Orden.IdNMB));
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);                        
                SqlParameter Fecha = new SqlParameter("@Fecha", Orden.Fecha);            
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(IdProducto);              
                command.Parameters.Add(Fecha);             
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
        /// Actualiza  los valores del Producto despachado en almacen.
        /// </summary>
        /// <param name="Orden"></param>
        public void UpdateAlmacen(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"    UPDATE TablaAlmacen SET  Diferido = (TablaAlmacen.Diferido - @CantidadDespachada) 
                                     where (TablaAlmacen.IdProducto = @IdProducto)
                                    ";
                SqlParameter CantidadDespachada = new SqlParameter("@CantidadDespachada", Orden.Cantidad);
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);   
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(CantidadDespachada);
                command.Parameters.Add(IdProducto);        
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
        /// Actualiza la cantidad de productos en almacen cuando este recibe Unidades de la Bodega
        /// </summary>
        /// <param name="Orden"></param>
        public void UpdateCantidad(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"    UPDATE TablaAlmacen SET  Cantidad = (TablaAlmacen.Cantidad + @Cantidad) 
                                     where (TablaAlmacen.IdProducto = @IdProducto)
                                     UPDATE TablaBodega SET Cantidad = (TablaBodega.Cantidad - @Cantidad)
                                     where (TablaBodega.IdProducto = @IdProducto)
                                    ";
                SqlParameter CantidadDespachada = new SqlParameter("@Cantidad", Orden.Cantidad);
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(CantidadDespachada);
                command.Parameters.Add(IdProducto);
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
        /// Actualiza los productos en Bodega una vez se trasladan a almacen
        /// </summary>
        /// <param name="Orden"></param>
        public void UpdateCantidadBodega(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"    UPDATE TablaBodega SET  Cantidad = (TablaBodega.Cantidad + @Cantidad) 
                                     where (TablaBodega.IdProducto = @IdProducto)
                                    ";
                SqlParameter CantidadDespachada = new SqlParameter("@Cantidad", Orden.Cantidad);
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(CantidadDespachada);
                command.Parameters.Add(IdProducto);
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
        /// Actualiza el Producto Diferido una vez se hace el despacho.
        /// </summary>
        /// <param name="Orden"></param>
        public void UpdateDiferido(DataAlmacen Orden)
        {
            try
            {
                Connection.Open();
                string query = @"    UPDATE TablaAlmacen SET Cantidad = (TablaAlmacen.Cantidad-@CantidadDiferida),   Diferido = (TablaAlmacen.Diferido + @CantidadDiferida)
                                     where (TablaAlmacen.IdProducto = @IdProducto)
                                    ";
                SqlParameter CantidadDiferida = new SqlParameter("@CantidadDiferida", Orden.Cantidad);
                SqlParameter IdProducto = new SqlParameter("@IdProducto", Orden.IdProducto);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(CantidadDiferida);
                command.Parameters.Add(IdProducto);
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
                                    Insert into Visitas ([NMB], [Cuidador], [Fecha], [Departamento],Motivo,Reagendada)  
                                    Values(@IdNMB,@IdCuidador,@Fecha,@Departamento,@Motivo,@Reagendada)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
                SqlParameter IdCuidador = new SqlParameter("@IdCuidador", Cita.IdCuidador);
                SqlParameter Fecha = new SqlParameter("@Fecha", Cita.Fecha);
                SqlParameter Departamento = new SqlParameter("@Departamento", Cita.Departamento);
                SqlParameter Motivo = new SqlParameter("@Motivo", Cita.Motivo);
                SqlParameter Reagendada = new SqlParameter("@Reagendada", Cita.Reagendo);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(IdCuidador);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Departamento);
                command.Parameters.Add(Motivo);
                command.Parameters.Add(Reagendada);
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
        /// <summary>
        /// Establece una Relacion entre El NMB y el Cuidador, ademas recibe su parentesco.
        /// </summary>
        /// <param name="IdNMB"></param>
        /// <param name="IdCuidador"></param>
        /// <param name="Parentesco"></param>
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
        /// <summary>
        /// Inserta relacion del NMB y MMB para casos especiales.
        /// </summary>
        /// <param name="IdNMB"></param>
        /// <param name="IdMMB"></param>
        /// <param name="Parentesco"></param>
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
        /// <summary>
        /// Inserta los datos Del paciente de una visita a Enfermeria.
        /// </summary>
        /// <param name="contact"></param>
        public void InserCitaEnfermeria(ClaseEnfermeria contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaEnfermeria (NMB, Fecha,Programa,Peso,Talla,CMB,Edema,Observacion,Patologias,Antecedentes,Hb)  
                                    Values(@NMB,@Fecha,@Programa,@Peso,@Talla,@CMB,@Edema,@Observacion,@Patologia,@Antecedentes,@Hb )";
                SqlParameter NMB = new SqlParameter("@NMB", contact.NMB);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter Programa = new SqlParameter("@Programa", contact.Programa);
                SqlParameter Peso = new SqlParameter("@Peso", contact.Peso);
                SqlParameter Talla = new SqlParameter("@Talla", contact.Talla);
                SqlParameter Hb = new SqlParameter("@Hb", contact.Hb);
                // SqlParameter MUAC = new SqlParameter("@Muac", contact.MUAC);
                //SqlParameter CC = new SqlParameter("@CC", contact.CC);
                SqlParameter CMB = new SqlParameter("@CMB", contact.CMB);
                SqlParameter Edema  = new SqlParameter("@Edema", contact.Edema);
                //SqlParameter IMC = new SqlParameter("@IMC", contact.IMC);
                //SqlParameter PZImcEdad = new SqlParameter("@PZImcEdad", contact.PZImcEdad);
                //SqlParameter PZTallaEdad = new SqlParameter("@PZTallaEdad", contact.PZTallaEdad);
                //SqlParameter PZTallaIMC = new SqlParameter("@PZTallaImc", contact.PZTallaImc);
                //SqlParameter PesoNacimiento = new SqlParameter("@PesoNacimiento", contact.PesoNacimiento);
                //SqlParameter Lactancia = new SqlParameter("@Lactancia", contact.Lactancia);
                SqlParameter Observacion = new SqlParameter("@Observacion", contact.Observacion);
                SqlParameter Patologia = new SqlParameter("@Patologia", contact.Patologia);
                SqlParameter Antecedente = new SqlParameter("@Antecedentes", contact.Antecedentes);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Programa);
                command.Parameters.Add(Peso);
                command.Parameters.Add(Talla);
                command.Parameters.Add(Hb);
                // command.Parameters.Add(MUAC);
                //command.Parameters.Add(CC);
                command.Parameters.Add(CMB);
                command.Parameters.Add(Edema);
                //command.Parameters.Add(IMC);
                //command.Parameters.Add(PZImcEdad);
                //command.Parameters.Add(PZTallaEdad);
                //command.Parameters.Add(PZTallaIMC);
                //command.Parameters.Add(PesoNacimiento);
                //command.Parameters.Add(Lactancia);
                command.Parameters.Add(Observacion);
                command.Parameters.Add(Patologia);
                command.Parameters.Add(Antecedente);
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
        /// Agrega un Producto Nuevo a la Tabla Bodega.
        /// </summary>
        /// <param name="contact"></param>
        public void InserProductBodega(DataAlmacen contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaBodega ([Nombre], [Lote], [FechaVencimiento],[Cantidad],[Descripcion],Programa)  
                                    Values(@Nombre,@Lote,@FechaVencimiento,@Cantidad,@Descripcion,@Programa)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
               // SqlParameter Id = new SqlParameter("@IdProducto", contact.IdProducto);
                SqlParameter Lote = new SqlParameter("@Lote", contact.Lote);
                SqlParameter FechaVencimiento = new SqlParameter("@FechaVencimiento", contact.FechaVencimiento);
                SqlParameter Descripcion = new SqlParameter("@Descripcion", contact.Descripcion);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", contact.Cantidad);
                SqlParameter Programa = new SqlParameter("@Programa", contact.Programa);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Lote);
                command.Parameters.Add(FechaVencimiento);
                command.Parameters.Add(Descripcion);
                command.Parameters.Add(Cantidad);
                command.Parameters.Add(Programa);
                //command.Parameters.Add(Id);
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
        /// Inserta un Producto nuevo de la Bodega al Almacen. Actualiza La cantidad de dicho producto en Bodega.
        /// </summary>
        /// <param name="contact"></param>
        public void InserProduct(DataAlmacen contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaAlmacen ([IdProducto],[Nombre], [Lote], [FechaVencimiento],[Cantidad],[Descripcion],Programa)  
                                    Values(@IdProducto,@Nombre,@Lote,@FechaVencimiento,@Cantidad,@Descripcion,@Programa)
                                     UPDATE TablaBodega SET Cantidad = (TablaBodega.Cantidad - @Cantidad)
                                      where (TablaBodega.IdProducto = @IdProducto)   ";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Id = new SqlParameter("@IdProducto", contact.IdProducto);
                SqlParameter Lote = new SqlParameter("@Lote", contact.Lote);
                SqlParameter FechaVencimiento = new SqlParameter("@FechaVencimiento", contact.FechaVencimiento);
                SqlParameter Descripcion = new SqlParameter("@Descripcion", contact.Descripcion);
                SqlParameter Cantidad = new SqlParameter("@Cantidad", contact.Cantidad);
                SqlParameter Programa = new SqlParameter("@Programa", contact.Programa);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Lote);
                command.Parameters.Add(FechaVencimiento);
                command.Parameters.Add(Descripcion);
                command.Parameters.Add(Cantidad);
                command.Parameters.Add(Programa);
                command.Parameters.Add(Id);
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
        public List<MapaniUsers> ShowAsistencia(DateTime Fecha)
        {
            List<MapaniUsers> Asistencia = new List<MapaniUsers>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaAsistencia	
                                Join MapaniUsers
                                on TablaAsistencia.IdTrabajador = MapaniUsers.Id
                                where Fecha = @Fecha";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Asistencia.Add(new MapaniUsers
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["FirstName"].ToString(),
                        Apellido = reader["LastName"].ToString(),
                        Posicion = reader["Position"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        Fecha = (DateTime)reader["Fecha"],
                        HoraEntrada =reader["Hora"].ToString(),
                        HoraSalida = reader["HoraSalida"].ToString(),
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
            return Asistencia;
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
        /// Obtiene los Productos del Almacen.
        /// </summary>
        /// <returns></returns>
        public List<DataAlmacen> GetProductos()
        {
            List<DataAlmacen> contacts = new List<DataAlmacen>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaAlmacen";
                SqlCommand command = new SqlCommand
                {
                    CommandText = query,
                    Connection = Connection
                };
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new DataAlmacen
                    {
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        Lote = reader["Lote"].ToString(),
                        Cantidad = int.Parse(reader["Cantidad"].ToString()),
                        FechaVencimiento = (DateTime)reader["FechaVencimiento"],
                        Descripcion = reader["Descripcion"].ToString(),
                        Diferido = int.Parse(reader["Diferido"].ToString()),
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
        /// Idem pero Productos Bodega
        /// </summary>
        /// <returns></returns>
        public List<DataAlmacen> GetProductosBodega()
        {
            List<DataAlmacen> contacts = new List<DataAlmacen>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaBodega";
                SqlCommand command = new SqlCommand
                {
                    CommandText = query,
                    Connection = Connection
                };
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new DataAlmacen
                    {
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        Lote = reader["Lote"].ToString(),
                        Cantidad = int.Parse(reader["Cantidad"].ToString()),
                        FechaVencimiento = (DateTime)reader["FechaVencimiento"],
                        Descripcion = reader ["Descripcion"].ToString(),
                       
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
        /// Obtiene la Data que fue tomada en Enfermeria del Paciente NMB en la Fecha estipulada.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        public List<ClaseEnfermeria> GetDataEnfermeria(string Id, DateTime Fecha)
        {
            List<ClaseEnfermeria> Data = new List<ClaseEnfermeria>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaEnfermeria
                                Where TablaEnfermeria.NMB=@IdNMB and TablaEnfermeria.Fecha=@Fecha ";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data.Add(new ClaseEnfermeria
                    {
                        Peso = reader["Peso"].ToString(),
                        Talla = reader["Talla"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        CMB = reader["CMB"].ToString(),
                        Edema = reader["Edema"].ToString(),
                        Hb = int.Parse(reader["Hb"].ToString()),
                        Observacion = reader["Observacion"].ToString(),
                        Antecedentes = reader["Antecedentes"].ToString(),
                        Patologia = reader["Patologias"].ToString(),
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
            return Data;
        }
        /// <summary>
        /// Obtiene las ordenes que se realizaorn.
        /// </summary>
        /// <returns></returns>
        public List<DataAlmacen> GetOrdenes()
        {
            List<DataAlmacen> contacts = new List<DataAlmacen>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Ordenes";
                SqlCommand command = new SqlCommand
                {
                    CommandText = query,
                    Connection = Connection
                };
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new DataAlmacen
                    {   IdNMB = reader["IdNMB"].ToString(),
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        Pediatra = reader["Pediatra"].ToString(),
                        Cantidad = int.Parse(reader["Cantidad"].ToString()),
                        Fecha= (DateTime)reader["Fecha"],
                        Despachado = reader["Despachado"].ToString(),
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
        /// obtiene el Historial de las Ordenes que ya Fueron despachadas y quedan asociadas al NMB
        /// </summary>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public List<DataAlmacen> GetHistorialOrdenes(DataAlmacen Orden)
        {
            List<DataAlmacen> contacts = new List<DataAlmacen>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Ordenes
                                Where Ordenes.IdNMB = @IdNMB and Ordenes.Fecha=@Fecha                ";
                SqlCommand command = new SqlCommand
                {
                    CommandText = query,
                    Connection = Connection
                };
                SqlParameter IdNMB = new SqlParameter("@IdNMB", int.Parse(Orden.IdNMB));
                SqlParameter Fecha = new SqlParameter("@Fecha", Orden.Fecha);                                        
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Fecha);               
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new DataAlmacen
                    {
                        IdNMB = reader["IdNMB"].ToString(),
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        Pediatra = reader["Pediatra"].ToString(),
                        Cantidad = int.Parse(reader["Cantidad"].ToString()),
                        Fecha = (DateTime)reader["Fecha"],
                        Despachado = reader["Despachado"].ToString(),
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
                        Reagendo = reader ["Reagendada"].ToString(),
                        Motivo = reader ["Motivo"].ToString(),
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
        /// Obtiene el Historial de las citas para una fecha especifica.
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<HistorialVisitas> GetHistorialCitas(DateTime Search )
        {
            List<HistorialVisitas> Historial = new List<HistorialVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Visitas
                                Where Fecha=@Search
                               ";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", Search));
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
                        Reagendo = reader["Reagendada"].ToString(),
                        Motivo = reader["Motivo"].ToString(),
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
                        Rol = reader["Doctor"].ToString(),
                        Activo = reader["Activo"].ToString(),

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
                string query = @"Select NMB,Fecha,Departamento,Doctor,Activo,Nombre, Apellido,FechaNacimiento
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
                        Rol = reader["Doctor"].ToString(),
                        Activo = reader["Activo"].ToString(),
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
        /// <summary>
        /// Obtiene la Asistencia del usuario.
        /// </summary>
        /// <returns></returns>
        public List<MapaniUsers> GetAsistencia()
        {
            List<MapaniUsers> Asistencias = new List<MapaniUsers>();
            try
            {
                Connection.Open();
                string query = @"Select IdTrabajador, Fecha,Rol
                                 From TablaAsistencia";
                              
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Asistencias.Add(new MapaniUsers
                    {
                        Id = int.Parse(reader["IdTrabajador"].ToString()),
                        Fecha = (DateTime)reader["Fecha"],
                        Rol = reader["Rol"].ToString()
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
            return Asistencias;
        }
        /// <summary>
        /// Funcion para chequear las credenciales de usuario Mapani y mostrar las vistas de acuerdo a su posicion.
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public List<MapaniUsers> Login(string User,string Password)
        {
            List<MapaniUsers> Usuario = new List<MapaniUsers>();
            try
            {
                Connection.Open();
                string query = @"Select *
                                From MapaniUsers
                                where MapaniUsers.LoginName=@User and MapaniUsers.Password=@Password"; //and ProximasVisitas.NMB=TablaNMB.Id" Nombre, Apellido,FechaNacimiento,
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@User", User));
                command.Parameters.Add(new SqlParameter("@Password", Password));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                { Usuario.Add(new MapaniUsers
                    {   Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["FirstName"].ToString(),
                        Posicion = reader["Position"].ToString(),
                        Rol = reader["Rol"].ToString(),
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
            return Usuario;
        }
        #endregion
    }

}
