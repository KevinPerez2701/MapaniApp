using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

/// <summary>
/// Clase Encargada de la interraccion con la base de datos SQL
/// </summary>
namespace MapaniApp
{
    class DataAccessLayer

    {
        // private SqlConnection Connection = new SqlConnection("data source=192.168.68.166,1433; initial catalog=MAPANI; user id=kevin; password =Mapani2022;");
        // private SqlConnection Connection = new SqlConnection("data source=192.168.68.118,1433; initial catalog=MAPANI; user id=kevin; password =1234;");
        //  private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-A51VEQA");
        private SqlConnection Connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAPANI;Data Source=DESKTOP-OLASR82");
        #region AGREGAR CONTACTOS y Actualizar Contactos
            #region NMB
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
                                    Insert into TablaNMB (Escolaridad,DireccionEscuela,NombreEscuela,[Nombre], [Apellido], [FechaNacimiento], [Direccion],[sexo],[Foto],Cedula,FechaIngreso,Discapacidad,Vacunas,LactanciaMaterna,Parto,IngresoPrograma,PartidaNacimiento,Parroquia,Municipio,Estado,TipoDiscapacidad)  
                                    Values(@Escolaridad,@DireccionEscuela,@NombreEscuela,@Nombre,@Apellido,@Edad,@Direccion,@Sexo,@foto,@cedula,@fechaIngreso,@Discapacidad,@Vacunas,@LactanciaMaterna,@Parto,@ingreso,@PartidaNacimiento,@Parroquia,@Municipio,@Estado,@TipoDiscapacidad)";
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
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter Escolaridad = new SqlParameter("@Escolaridad", contact.Escolaridad);
                SqlParameter DireccionEscuela = new SqlParameter("@DireccionEscuela", contact.DireccionEscuela);
                SqlParameter NombreEscuela = new SqlParameter("@NombreEscuela", contact.NombreEscuela);
                SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);

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
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(Escolaridad);
                command.Parameters.Add(DireccionEscuela);
                command.Parameters.Add(NombreEscuela);
                command.Parameters.Add(TipoDiscapacidad);
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
                                   Update TablaNMB Set Nombre=@Nombre, Apellido=@Apellido, [FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@Foto,Cedula=@Cedula,FechaIngreso=@FechaIngreso,Discapacidad=@Discapacidad,Vacunas=@Vacunas,LactanciaMaterna=@LactanciaMaterna,Parto=@Parto,IngresoPrograma=@Ingreso,PartidaNacimiento=@PartidaNacimiento, Parroquia=@Parroquia,Municipio=@Municipio,Estado=@Estado,Escolaridad=@Escolaridad,NombreEscuela=@NombreEscuela,DireccionEscuela=@DireccionEscuela,TipoDiscapacidad=@TipoDiscapacidad  
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
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter Escolaridad = new SqlParameter("@Escolaridad", contact.Escolaridad);
                SqlParameter DireccionEscuela = new SqlParameter("@DireccionEscuela", contact.DireccionEscuela);
                SqlParameter NombreEscuela = new SqlParameter("@NombreEscuela", contact.NombreEscuela);
                SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);

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
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(Escolaridad);
                command.Parameters.Add(NombreEscuela);
                command.Parameters.Add(DireccionEscuela);
                command.Parameters.Add(TipoDiscapacidad);
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
            #region Cuidador
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
                                    Insert into TablaCuidador ([Nombre], [Apellido],Ocupacion, [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono],EstadoCivil,Cedula,Hijos,Transporte,Parroquia,Municipio,Estado,IngresosPropios,Discapacidad,TipoDiscapacidad,GrupoEtnico,TipoGrupoEtnico,Movilizacion,CharlaMuac,CharlaLactancia,TieneHijos,Rango1,Rango2,Rango3)  
                                    Values(@Nombre,@Apellido,@Ocupacion, @Edad,@Direccion,@Sexo,@foto,@Telefono,@EstadoCivil,@Cedula,@Hijos,@Transporte,@Parroquia,@Municipio,@Estado,@IngresosPropios,@Discapacidad,@TipoDiscapacidad,@GrupoEtnico,@TipoGrupoEtnico,@Movilizacion,@CharlaMuac,@CharlaLactancia,@TieneHijos,@Rango1,@Rango2,@Rango3)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Ocupacion = new SqlParameter("@Ocupacion", contact.Ocupacion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Hijos = new SqlParameter("@Hijos", contact.CantidadHijos);
                SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter IngresosPropios = new SqlParameter("@IngresosPropios", contact.IngresosPropios);
                SqlParameter Discapacidad = new SqlParameter("@Discapacidad", contact.Discapacidad);
                SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);
                SqlParameter GrupoEtnico = new SqlParameter("@GrupoEtnico", contact.GrupoEtnico);
                SqlParameter TipoGrupoEtnico = new SqlParameter("@TipoGrupoEtnico", contact.TipoGrupoEtnico);
                SqlParameter TieneHijos = new SqlParameter("@TieneHijos", contact.TieneHijos);
                SqlParameter Rango1 = new SqlParameter("@Rango1", contact.Rango1);
                SqlParameter Rango2 = new SqlParameter("@Rango2", contact.Rango2);
                SqlParameter Rango3 = new SqlParameter("@Rango3", contact.Rango3);
                SqlParameter CharlaMuac = new SqlParameter("@CharlaMuac", contact.CharlaMuac);
                SqlParameter CharlaLactancia = new SqlParameter("@CharlaLactancia", contact.CharlaLactancia);
                SqlParameter Movilizacion = new SqlParameter("@Movilizacion", contact.Movilizacion);



                SqlCommand command = new SqlCommand(query, Connection);

                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Ocupacion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.Parameters.Add(EstadoCivil);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(Transporte);
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(Hijos);
                command.Parameters.Add(IngresosPropios);
                command.Parameters.Add(Discapacidad);
                command.Parameters.Add(TipoDiscapacidad);
                command.Parameters.Add(GrupoEtnico);
                command.Parameters.Add(TipoGrupoEtnico);
                command.Parameters.Add(TieneHijos);
                command.Parameters.Add(Rango1);
                command.Parameters.Add(Rango2);
                command.Parameters.Add(Rango3);
                command.Parameters.Add(CharlaMuac);
                command.Parameters.Add(CharlaLactancia);
                command.Parameters.Add(Movilizacion);
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
                                    Update TablaCuidador SET [Nombre]=@Nombre, [Apellido]=@Apellido, Ocupacion=@Ocupacion,[FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@foto,[Telefono]=@Telefono,EstadoCivil=@EstadoCivil,Cedula=@Cedula,Hijos=@Hijos,Transporte=@Transporte ,Parroquia=@Parroquia,Municipio=@Municipio,Estado=@Estado,IngresosPropios=@IngresosPropios,Discapacidad=@Discapacidad,TipoDiscapacidad=@TipoDiscapacidad,GrupoEtnico=@GrupoEtnico,TipoGrupoEtnico=@TipoGrupoEtnico,Movilizacion=@Movilizacion,CharlaMuac=@CharlaMuac,CharlaLactancia=@CharlaLactancia,TieneHijos=@TieneHijos,Rango1=@Rango1,Rango2=@Rango2,Rango3=@Rango3 
                                   Where TablaCuidador.Id = @Id";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Id = new SqlParameter("@Id", contact.Id);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Ocupacion = new SqlParameter("@Ocupacion", contact.Ocupacion);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Hijos = new SqlParameter("@Hijos", contact.CantidadHijos);
                SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter IngresosPropios = new SqlParameter("@IngresosPropios", contact.IngresosPropios);
                SqlParameter Discapacidad = new SqlParameter("@Discapacidad", contact.Discapacidad);
                SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);
                SqlParameter GrupoEtnico = new SqlParameter("@GrupoEtnico", contact.GrupoEtnico);
                SqlParameter TipoGrupoEtnico = new SqlParameter("@TipoGrupoEtnico", contact.TipoGrupoEtnico);
                SqlParameter TieneHijos = new SqlParameter("@TieneHijos", contact.TieneHijos);
                SqlParameter Rango1 = new SqlParameter("@Rango1", contact.Rango1);
                SqlParameter Rango2 = new SqlParameter("@Rango2", contact.Rango2);
                SqlParameter Rango3 = new SqlParameter("@Rango3", contact.Rango3);
                SqlParameter CharlaMuac = new SqlParameter("@CharlaMuac", contact.CharlaMuac);
                SqlParameter CharlaLactancia = new SqlParameter("@CharlaLactancia", contact.CharlaLactancia);
                SqlParameter Movilizacion = new SqlParameter("@Movilizacion", contact.Movilizacion);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Ocupacion);
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
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(IngresosPropios);
                command.Parameters.Add(Discapacidad);
                command.Parameters.Add(TipoDiscapacidad);
                command.Parameters.Add(GrupoEtnico);
                command.Parameters.Add(TipoGrupoEtnico);
                command.Parameters.Add(TieneHijos);
                command.Parameters.Add(Rango1);
                command.Parameters.Add(Rango2);
                command.Parameters.Add(Rango3);
                command.Parameters.Add(CharlaMuac);
                command.Parameters.Add(CharlaLactancia);
                command.Parameters.Add(Movilizacion);
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
            #region MMB
       

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
                                    Insert into TablaMMB ([Nombre], [Apellido],Ocupacion, [FechaNacimiento], [Direccion],[sexo],[Foto],[Telefono],EstadoCivil,Cedula,Hijos,Transporte,Parroquia,Municipio,Estado,IngresosPropios,Discapacidad,TipoDiscapacidad,GrupoEtnico,TipoGrupoEtnico,Movilizacion,CharlaMuac,CharlaLactancia,TieneHijos,Rango1,Rango2,Rango3)  
                                    Values(@Nombre,@Apellido,@Ocupacion, @Edad,@Direccion,@Sexo,@foto,@Telefono,@EstadoCivil,@Cedula,@Hijos,@Transporte,@Parroquia,@Municipio,@Estado,@IngresosPropios,@Discapacidad,@TipoDiscapacidad,@GrupoEtnico,@TipoGrupoEtnico,@Movilizacion,@CharlaMuac,@CharlaLactancia,@TieneHijos,@Rango1,@Rango2,@Rango3)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Ocupacion = new SqlParameter("@Ocupacion", contact.Ocupacion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Hijos = new SqlParameter("@Hijos", contact.CantidadHijos);
                SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter IngresosPropios = new SqlParameter("@IngresosPropios", contact.IngresosPropios);
                SqlParameter Discapacidad = new SqlParameter("@Discapacidad", contact.Discapacidad);
                SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);
                SqlParameter GrupoEtnico = new SqlParameter("@GrupoEtnico", contact.GrupoEtnico);
                SqlParameter TipoGrupoEtnico = new SqlParameter("@TipoGrupoEtnico", contact.TipoGrupoEtnico);
                SqlParameter TieneHijos = new SqlParameter("@TieneHijos", contact.TieneHijos);
                SqlParameter Rango1 = new SqlParameter("@Rango1", contact.Rango1);
                SqlParameter Rango2 = new SqlParameter("@Rango2", contact.Rango2);
                SqlParameter Rango3 = new SqlParameter("@Rango3", contact.Rango3);
                SqlParameter CharlaMuac = new SqlParameter("@CharlaMuac", contact.CharlaMuac);
                SqlParameter CharlaLactancia = new SqlParameter("@CharlaLactancia", contact.CharlaLactancia);
                SqlParameter Movilizacion = new SqlParameter("@Movilizacion", contact.Movilizacion);

                SqlCommand command = new SqlCommand(query, Connection);

                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(FechaNacimiento);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Ocupacion);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(foto);
                command.Parameters.Add(EstadoCivil);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(Transporte);
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(Hijos);
                command.Parameters.Add(IngresosPropios);
                command.Parameters.Add(Discapacidad);
                command.Parameters.Add(TipoDiscapacidad);
                command.Parameters.Add(GrupoEtnico);
                command.Parameters.Add(TipoGrupoEtnico);
                command.Parameters.Add(TieneHijos);
                command.Parameters.Add(Rango1);
                command.Parameters.Add(Rango2);
                command.Parameters.Add(Rango3);
                command.Parameters.Add(CharlaMuac);
                command.Parameters.Add(CharlaLactancia);
                command.Parameters.Add(Movilizacion);
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
                                    Update TablaMMB SET [Nombre]=@Nombre, [Apellido]=@Apellido, Ocupacion=@Ocupacion,[FechaNacimiento]=@Edad, [Direccion]=@Direccion,[sexo]=@Sexo,[Foto]=@foto,[Telefono]=@Telefono,EstadoCivil=@EstadoCivil,Cedula=@Cedula,Hijos=@Hijos,Transporte=@Transporte ,Parroquia=@Parroquia,Municipio=@Municipio,Estado=@Estado,IngresosPropios=@IngresosPropios,Discapacidad=@Discapacidad,TipoDiscapacidad=@TipoDiscapacidad,GrupoEtnico=@GrupoEtnico,TipoGrupoEtnico=@TipoGrupoEtnico,Movilizacion=@Movilizacion,CharlaMuac=@CharlaMuac,CharlaLactancia=@CharlaLactancia,TieneHijos=@TieneHijos,Rango1=@Rango1,Rango2=@Rango2,Rango3=@Rango3 
                                    Where TablaMMB.Id = @Id";
                    SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                    SqlParameter Id = new SqlParameter("@Id", contact.Id);
                    SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                    SqlParameter FechaNacimiento = new SqlParameter("@Edad", contact.FechaNacimiento);
                    SqlParameter Ocupacion = new SqlParameter("@Ocupacion", contact.Ocupacion);
                    SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                    SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                    SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                    SqlParameter foto = new SqlParameter("@foto", contact.Foto);
                    SqlParameter EstadoCivil = new SqlParameter("@EstadoCivil", contact.EstadoCivil);
                    SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                    SqlParameter Hijos = new SqlParameter("@Hijos", contact.CantidadHijos);
                    SqlParameter Transporte = new SqlParameter("@Transporte", contact.Transporte);
                    SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                    SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                    SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                    SqlParameter IngresosPropios = new SqlParameter("@IngresosPropios", contact.IngresosPropios);
                    SqlParameter Discapacidad = new SqlParameter("@Discapacidad", contact.Discapacidad);
                    SqlParameter TipoDiscapacidad = new SqlParameter("@TipoDiscapacidad", contact.TipoDiscapacidad);
                    SqlParameter GrupoEtnico = new SqlParameter("@GrupoEtnico", contact.GrupoEtnico);
                    SqlParameter TipoGrupoEtnico = new SqlParameter("@TipoGrupoEtnico", contact.TipoGrupoEtnico);
                    SqlParameter TieneHijos = new SqlParameter("@TieneHijos", contact.TieneHijos);
                    SqlParameter Rango1 = new SqlParameter("@Rango1", contact.Rango1);
                    SqlParameter Rango2 = new SqlParameter("@Rango2", contact.Rango2);
                    SqlParameter Rango3 = new SqlParameter("@Rango3", contact.Rango3);
                    SqlParameter CharlaMuac = new SqlParameter("@CharlaMuac", contact.CharlaMuac);
                    SqlParameter CharlaLactancia = new SqlParameter("@CharlaLactancia", contact.CharlaLactancia);
                    SqlParameter Movilizacion = new SqlParameter("@Movilizacion", contact.Movilizacion);

                    SqlCommand command = new SqlCommand(query, Connection);
                    command.Parameters.Add(Nombre);
                    command.Parameters.Add(Ocupacion);
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
                    command.Parameters.Add(Parroquia);
                    command.Parameters.Add(Municipio);
                    command.Parameters.Add(Estado);
                    command.Parameters.Add(IngresosPropios);
                    command.Parameters.Add(Discapacidad);
                    command.Parameters.Add(TipoDiscapacidad);
                    command.Parameters.Add(GrupoEtnico);
                    command.Parameters.Add(TipoGrupoEtnico);
                    command.Parameters.Add(TieneHijos);
                    command.Parameters.Add(Rango1);
                    command.Parameters.Add(Rango2);
                    command.Parameters.Add(Rango3);
                    command.Parameters.Add(CharlaMuac);
                    command.Parameters.Add(CharlaLactancia);
                    command.Parameters.Add(Movilizacion);
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
        #region Relaciones
        /// <summary>
        /// Establece una Relacion entre El NMB y el Cuidador, ademas recibe su parentesco.
        /// </summary>
        /// <param name="IdNMB"></param>
        /// <param name="IdCuidador"></param>
        /// <param name="Parentesco"></param>
        public void InsertRelacion(string IdNMB, string IdCuidador, string Parentesco, string Cedulas)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into Referencia(NMB,Cuidador,Parentesco,Cedula) 
                                    Values(@IdNMB,@IdCuidador,@Parentesco,@Cedula)";
                SqlParameter NMB = new SqlParameter("@IdNMB", int.Parse(IdNMB));
                SqlParameter Cuidador = new SqlParameter("@IdCuidador", int.Parse(IdCuidador));
                SqlParameter Relacion = new SqlParameter("@Parentesco", Parentesco);
                SqlParameter Cedula = new SqlParameter("@Cedula", Cedulas);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Cuidador);
                command.Parameters.Add(Relacion);
                command.Parameters.Add(Cedula);
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
        public void InsertRelacionMMB(string IdNMB, string IdMMB, string Parentesco, string Cedulas)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into ReferenciaMMB(NMB,MMB,Parentesco,Cedula) 
                                    Values(@IdNMB,@IdMMB,@Parentesco,@Cedula)";
                SqlParameter NMB = new SqlParameter("@IdNMB", int.Parse(IdNMB));
                SqlParameter MMB = new SqlParameter("@IdMMB", int.Parse(IdMMB));
                SqlParameter Cedula = new SqlParameter("@Cedula", Cedulas);
                SqlParameter Relacion = new SqlParameter("@Parentesco", Parentesco);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(MMB);
                command.Parameters.Add(Cedula);
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
        #region Contactos Asesoria y Psicologia
        public void InsertCitaPsicologia(ContactPsicologia contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Insert into TablaHistorialPsicologia (IdNMB,Fecha,RazonSalud,RazonSeguridad,RazonCuidado,RazonOtro,NoRazon,AccionSalud,AccionSeguridad,AccionCuidado,AccionOtro,NoAccion,Seguimiento)  
                                    Values(@IdNMB,@Fecha,@RazonSalud,@RazonSeguridad,@RazonCuidado,@RazonOtro,@NoRazon,@AccionSalud,@AccionSeguridad,@AccionCuidado,@AccionOtro,@NoAccion,@Seguimiento)
                                     ";
                SqlParameter NMB = new SqlParameter("@IdNMB", int.Parse(contact.IdNMB));
                SqlParameter RazonSalud = new SqlParameter("@RazonSalud", contact.RazonSalud);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter RazonSeguridad = new SqlParameter("@RazonSeguridad", contact.RazonSeguridad);
                SqlParameter RazonCuidado = new SqlParameter("@RazonCuidado", contact.RazonCuidado);
                SqlParameter RazonOtro = new SqlParameter("@RazonOtro", contact.RazonOtro);
                SqlParameter NoRazon = new SqlParameter("@NoRazon", contact.NoRazon);
                SqlParameter AccionSalud = new SqlParameter("@AccionSalud", contact.AccionSalud);
                SqlParameter AccionSeguridad = new SqlParameter("@AccionSeguridad", contact.AccionSeguridad);
                SqlParameter AccionCuidado = new SqlParameter("@AccionCuidado", contact.AccionCuidado);
                SqlParameter AccionOtro = new SqlParameter("@AccionOtro", contact.AccionOtro);
                SqlParameter NoAccion = new SqlParameter("@NoAccion", contact.NoAccion);
                SqlParameter Seguimiento = new SqlParameter("@Seguimiento", contact.Seguimiento);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(NMB);
                command.Parameters.Add(RazonSalud);
                command.Parameters.Add(RazonCuidado);
                command.Parameters.Add(RazonSeguridad);
                command.Parameters.Add(RazonOtro);
                command.Parameters.Add(NoRazon);
                command.Parameters.Add(AccionSalud);
                command.Parameters.Add(AccionSeguridad);
                command.Parameters.Add(AccionCuidado);
                command.Parameters.Add(AccionOtro);
                command.Parameters.Add(NoAccion);
                command.Parameters.Add(Seguimiento);

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
        public void InsertEvaluacionInicial(ContactPsicologia contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Insert into TablaPsicologia (IdNMB,SistemaFamiliar,MotivoConsulta,Antecedentes,Evaluacion,EvaluacionInicial,RazonAlta,RazonMedia,RazonBaja,NoRazon) 
                                    Values(@NMB,@SistemaFamiliar,@MotivoConsulta,@Antecedentes,@Evaluacion,@EvaluacionInicial,@RazonAlta,@RazonMedia,@RazonBaja,@NoRazon)
                                    Update TablaNMB Set Psicologia = 'Si' where TablaNMB.Id = @NMB";

                SqlParameter NMB = new SqlParameter("@NMB", contact.IdNMB);
                SqlParameter SistemaFamiliar = new SqlParameter("@SistemaFamiliar", contact.SistemaFamiliar);
                SqlParameter MotivoConsulta = new SqlParameter("@MotivoConsulta", contact.MotivoConsulta);
                SqlParameter Antecedentes = new SqlParameter("@Antecedentes", contact.Antecedentes);
                SqlParameter Evaluacion = new SqlParameter("@Evaluacion", contact.Evaluacion); 
                SqlParameter EvaluacionInicial = new SqlParameter("@EvaluacionInicial", contact.EvaluacionInicial);
                SqlParameter RazonAlta = new SqlParameter("@RazonAlta", contact.RazonAlta);
                SqlParameter RazonMedia = new SqlParameter("@RazonMedia", contact.RazonMedia);
                SqlParameter RazonBaja = new SqlParameter("@RazonBaja", contact.RazonBajo);
                SqlParameter NoRazon = new SqlParameter("@NoRazon", contact.NoRazon);

                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(SistemaFamiliar);
                command.Parameters.Add(MotivoConsulta);
                command.Parameters.Add(Antecedentes);
                command.Parameters.Add(Evaluacion);
                command.Parameters.Add(EvaluacionInicial);
                command.Parameters.Add(RazonAlta);
                command.Parameters.Add(RazonMedia);
                command.Parameters.Add(RazonBaja);
                command.Parameters.Add(NoRazon);

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
        public void InserCitaAsesoria(ContactAsesoria contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into GestionCasosAsesoria(IdCuidador,Fecha,TipoCaso,TipoAtencion,Seguimiento,Evolucion,Estatus,Observacion)
                                    Values(@IdCuidador, @Fecha, @TipoCaso, @TipoAtencion, @Seguimiento, @Evolucion, @Estatus, @Observacion)";
                SqlParameter IdCuidador = new SqlParameter("@IdCuidador", contact.IdCuidador);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter TipoCaso = new SqlParameter("@TipoCaso", contact.TipoCaso);
                SqlParameter TipoAtencion = new SqlParameter("@TipoAtencion", contact.TipoAtencion);
                SqlParameter Seguimiento = new SqlParameter("@Seguimiento", contact.Seguimiento);
                SqlParameter Evolucion = new SqlParameter("@Evolucion", contact.Evolucion);
                SqlParameter Estatus = new SqlParameter("@Estatus", contact.Estatus);
                SqlParameter Observacion = new SqlParameter("@Observacion", contact.Observacion);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdCuidador);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(TipoAtencion);
                command.Parameters.Add(TipoCaso);
                command.Parameters.Add(Seguimiento);
                command.Parameters.Add(Evolucion);
                command.Parameters.Add(Estatus);
                command.Parameters.Add(Observacion);
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
        public void InserContactAsesoria(ContactAsesoria contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaContactASesoria (Vinculo,IdCuidador,[Nombre], [Apellido], [Cedula], [Direccion],[Ocupacion],[Telefono],Parroquia,Municipio,Estado)  
                                    Values(@Vinculo,@IdCuidador,@Nombre,@Apellido,@Cedula,@Direccion,@Ocupacion,@Telefono,@Parroquia,@Municipio,@Estado)";
                SqlParameter Nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter Apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter Direccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter Ocupacion = new SqlParameter("@Ocupacion", contact.Ocupacion);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter Parroquia = new SqlParameter("@Parroquia", contact.Parroquia);
                SqlParameter Municipio = new SqlParameter("@Municipio", contact.Municipio);
                SqlParameter Estado = new SqlParameter("@Estado", contact.Estado);
                SqlParameter IdCuidador = new SqlParameter("@IdCuidador", contact.IdCuidador);
                SqlParameter Vinculo = new SqlParameter("@Vinculo", contact.Vinculo);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(Apellido);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Ocupacion);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(Parroquia);
                command.Parameters.Add(Municipio);
                command.Parameters.Add(Estado);
                command.Parameters.Add(IdCuidador);
                command.Parameters.Add(Vinculo);
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
        #endregion y Ps
        #region Documentos
        public void InsertDocuments(ContactAsesoria contact)
        {
            try
            {
                Connection.Open();
                string query = @"Insert into TablaDocumentsASesoria (IdCuidador,IdNMB,TipoDocumento,PDF)  
                                    Values(@IdCuidador,@IdNMB,@TipoDocumento,@PDF)
                                   ";

                SqlParameter IdCuidador = new SqlParameter("@IdCuidador", contact.IdCuidador);
                SqlParameter IdNMB = new SqlParameter("@IdNMB", contact.IdNMB);
                SqlParameter Tipo = new SqlParameter("@TipoDocumento", contact.TipoDocumento);
                SqlParameter PDF = new SqlParameter("@PDF", contact.PDF);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(IdCuidador);
                command.Parameters.Add(IdNMB);
                command.Parameters.Add(Tipo);
                command.Parameters.Add(PDF);
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
        /// 
        #endregion
        #region Citas
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
        public void InserCita(ProximasVisitas Cita)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into ProximasVisitas ([NMB], [Fecha], [Departamento],Doctor)  
                                    Values(@IdNMB,@Fecha,@Departamento,@Rol)";
                SqlParameter IdNMB = new SqlParameter("@IdNMB", Cita.IdNMB);
                SqlParameter Fecha = new SqlParameter("@Fecha", Cita.Fecha);
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
        /// 
        #endregion
        #region Modulo Asistencias

        public void InsertAsistencia(List<MapaniUsers> Asistencia)
        {
            try
            {
                Connection.Open();
                string query = @"
                                    Insert into TablaAsistencia ([IdTrabajador], [Fecha],Rol,Hora)  
                                    Values(@Id,@Fecha,@Rol,@Hora)";
                SqlParameter IdNMB = new SqlParameter("@Id", Asistencia[0].Id);
                SqlParameter Fecha = new SqlParameter("@Fecha", Asistencia[0].Fecha);
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
        #endregion
        #region  Modulo Medico
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
                                    Insert into TablaEnfermeria (NMB, Fecha,Programa,Peso,Talla,CMB,Hb,CC)  
                                    Values(@NMB,@Fecha,@Programa,@Peso,@Talla,@CMB,@Hb,@CC )";
                SqlParameter NMB = new SqlParameter("@NMB", contact.NMB);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter Programa = new SqlParameter("@Programa", contact.Programa);
                SqlParameter Peso = new SqlParameter("@Peso", contact.Peso);
                SqlParameter Talla = new SqlParameter("@Talla", contact.Talla);
                SqlParameter Hb = new SqlParameter("@Hb", contact.Hb);
                SqlParameter CMB = new SqlParameter("@CMB", contact.CMB);               
                SqlParameter CC = new SqlParameter("@CC", contact.CC);               
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(Programa);
                command.Parameters.Add(Peso);
                command.Parameters.Add(Talla);
                command.Parameters.Add(Hb);
                command.Parameters.Add(CMB);
                command.Parameters.Add(CC);                
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
        public void InserCitaPediatria(ClaseEnfermeria contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   UPDATE  TablaEnfermeria SET IMC=@IMC, IMCPZ=@IMCPZ,Diagnostico=@Diagnostico,DiagnosticoTalla=@DiagnosticoTalla,Urgencias=@Urgencias,Referido=@Referido,
                                   PZImcEdad=@PZImcEdad,PZTallaEdad=@PZTallaEdad,PZPesoEdad=@PZPesoEdad,PZPesoEdad2006=@PZPesoEdad2006,PZTallaEdad2006=@PZTallaEdad2006,PZPesoTalla=@PZPesoTalla,
                                   Observacion=@Observacion, Patologias=@Patologias,Antecedentes=@Antecedentes
                                   Where TablaEnfermeria.NMB = @NMB and TablaEnfermeria.Fecha = @Fecha";
                SqlParameter NMB = new SqlParameter("@NMB", contact.NMB);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter IMCPZ = new SqlParameter("@IMCPZ", contact.IMCPZ);
                SqlParameter DiagnosticoPeso = new SqlParameter("@Diagnostico", contact.Diagnostico);
                SqlParameter DiagnosticoTalla = new SqlParameter("@DiagnosticoTalla", contact.DiagnosticoTalla);
                SqlParameter Urgencias = new SqlParameter("@Urgencias", contact.Urgencias);
                SqlParameter Referido = new SqlParameter("@Referido", contact.Referido);
                SqlParameter Antecedentes = new SqlParameter("@Antecedentes", contact.Antecedentes);
                SqlParameter Observacion = new SqlParameter("@Observacion", contact.Observacion);
                SqlParameter Patologias = new SqlParameter("@Patologias", contact.Patologia);
                SqlParameter IMC = new SqlParameter("@IMC", contact.IMC);
                SqlParameter PZImcEdad = new SqlParameter("@PZImcEdad", contact.PZImcEdad);
                SqlParameter PZTallaEdad = new SqlParameter("@PZTallaEdad", contact.PZTallaEdad);
                SqlParameter PZPesoEdad = new SqlParameter("@PZPesoEdad", contact.PZPesoEdad);
                SqlParameter PZPesoEdad2006 = new SqlParameter("@PZPesoEdad2006", contact.PZPesoEdad2006);
                SqlParameter PZTallaEdad2006 = new SqlParameter("@PZTallaEdad2006", contact.PZTallaEdad2006);
                SqlParameter PZPesoTalla = new SqlParameter("@PZPesoTalla", contact.PZPesoTalla);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(IMCPZ);
                command.Parameters.Add(DiagnosticoPeso);
                command.Parameters.Add(DiagnosticoTalla);
                command.Parameters.Add(Urgencias);
                command.Parameters.Add(Referido);
                command.Parameters.Add(Antecedentes);
                command.Parameters.Add(Observacion);
                command.Parameters.Add(Patologias);                
                command.Parameters.Add(IMC);
                command.Parameters.Add(PZImcEdad);
                command.Parameters.Add(PZTallaEdad);
                command.Parameters.Add(PZTallaEdad2006);
                command.Parameters.Add(PZPesoEdad);
                command.Parameters.Add(PZPesoEdad2006);
                command.Parameters.Add(PZPesoTalla);
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
        public void InserCitaNutricion(ClaseEnfermeria contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Insert into TablaNutricion (NMB, Fecha,Programa,Peso,Talla,CMB,Hb,CC,Diagnostico,DiagnosticoTalla,Urgencias,Referido,Antecedentes,Observacion,Patologias,Imc,
                                    PZImcEdad,PZTallaEdad,PZPesoEdad,PZPesoEdad2006,PZTallaEdad2006,PZPesoTalla,IMCPZ)  
                                    Values(@NMB,@Fecha,@Programa,@Peso,@Talla,@CMB,@Hb,@CC,@Diagnostico,@DiagnosticoTalla,@Urgencias,@Referido,@Antecedentes,@Observacion,@Patologias,@IMC,
                                    @PZImcEdad,@PZTallaEdad,@PZPesoEdad,@PZPesoEdad2006,@PZTallaEdad2006,@PZPesoTalla,@IMCPZ)";
                SqlParameter NMB = new SqlParameter("@NMB", contact.NMB);
                SqlParameter Fecha = new SqlParameter("@Fecha", contact.Fecha);
                SqlParameter IMCPZ = new SqlParameter("@IMCPZ", contact.IMCPZ);
                SqlParameter DiagnosticoPeso = new SqlParameter("@Diagnostico", contact.Diagnostico);
                SqlParameter DiagnosticoTalla = new SqlParameter("@DiagnosticoTalla", contact.DiagnosticoTalla);
                SqlParameter Urgencias = new SqlParameter("@Urgencias", contact.Urgencias);
                SqlParameter Referido = new SqlParameter("@Referido", contact.Referido);
                SqlParameter Antecedentes = new SqlParameter("@Antecedentes", contact.Antecedentes);
                SqlParameter Observacion = new SqlParameter("@Observacion", contact.Observacion);
                SqlParameter Patologias = new SqlParameter("@Patologias", contact.Patologia);
                SqlParameter Programa = new SqlParameter("@Programa", contact.Programa);
                SqlParameter Peso = new SqlParameter("@Peso", contact.Peso);
                SqlParameter Talla = new SqlParameter("@Talla", contact.Talla);
                SqlParameter IMC = new SqlParameter("@IMC", contact.IMC);
                SqlParameter PZImcEdad = new SqlParameter("@PZImcEdad", contact.PZImcEdad);
                SqlParameter PZTallaEdad = new SqlParameter("@PZTallaEdad", contact.PZTallaEdad);
                SqlParameter PZPesoEdad = new SqlParameter("@PZPesoEdad", contact.PZPesoEdad);
                SqlParameter PZPesoEdad2006 = new SqlParameter("@PZPesoEdad2006", contact.PZPesoEdad2006);
                SqlParameter PZTallaEdad2006 = new SqlParameter("@PZTallaEdad2006", contact.PZTallaEdad2006);
                SqlParameter PZPesoTalla = new SqlParameter("@PZPesoTalla", contact.PZPesoTalla);
                SqlParameter Hb = new SqlParameter("@Hb", contact.Hb);
                SqlParameter CC = new SqlParameter("@CC", contact.CC);
                SqlParameter CMB = new SqlParameter("@CMB", contact.CMB);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(NMB);
                command.Parameters.Add(Fecha);
                command.Parameters.Add(IMCPZ);
                command.Parameters.Add(DiagnosticoPeso);
                command.Parameters.Add(DiagnosticoTalla);
                command.Parameters.Add(Urgencias);
                command.Parameters.Add(Referido);
                command.Parameters.Add(Antecedentes);
                command.Parameters.Add(Observacion);
                command.Parameters.Add(Patologias);
                command.Parameters.Add(Peso);
                command.Parameters.Add(CC);
                command.Parameters.Add(Talla);
                command.Parameters.Add(IMC);
                command.Parameters.Add(PZImcEdad);
                command.Parameters.Add(PZTallaEdad);
                command.Parameters.Add(PZTallaEdad2006);
                command.Parameters.Add(PZPesoEdad);
                command.Parameters.Add(PZPesoEdad2006);
                command.Parameters.Add(PZPesoTalla);
                command.Parameters.Add(Hb);
                command.Parameters.Add(Programa);
                command.Parameters.Add(CMB);
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
        public void InsertHistorialNutricion(ContactNutricion contact)
        {
            try
            {
                Connection.Open();
                string query = @"
                                   Insert into TablaHistorialNutricion (NMB,HoraLevantar,HoraDesayuno,HoraMerienda1,HoraAlmuerzo,HoraMerienda2,HoraCena,Levantar,Desayuno,Merienda1,Almuerzo,Merienda2,Cena,Diario,Semanal,Quincenal,Mensual)  
                                    Values(@NMB,@HoraLevantar,@HoraDesayuno,@HoraMerienda1,@HoraAlmuerzo,@HoraMerienda2,@HoraCena,@Levantar,@Desayuno,@Merienda1,@Almuerzo,@Merienda2,@Cena,@Diario,@Semanal,@Quincenal,@Mensual)
                                     Update TablaNMB Set HistorialNutricional=@Historial where TablaNMB.Id=@NMB ";
                SqlParameter NMB = new SqlParameter("@NMB", contact.NMB);
                SqlParameter HoraLevantar = new SqlParameter("@HoraLevantar", contact.HoraLevantar);
                SqlParameter HoraDesayuno = new SqlParameter("@HoraDesayuno", contact.HoraDesayuno);
                SqlParameter HoraMerienda1 = new SqlParameter("@HoraMerienda1", contact.HoraMerienda1);
                SqlParameter HoraAlmuerzo = new SqlParameter("@HoraAlmuerzo", contact.HoraAlmuerzo);
                SqlParameter HoraMerienda2 = new SqlParameter("@HoraMerienda2", contact.HoraMerienda2);
                SqlParameter HoraCena = new SqlParameter("@HoraCena", contact.HoraCena);
                SqlParameter Levantar = new SqlParameter("@Levantar", contact.Levantar);
                SqlParameter Desayuno = new SqlParameter("@Desayuno", contact.Desayuno);
                SqlParameter Almuerzo = new SqlParameter("@Almuerzo", contact.Almuerzo);
                SqlParameter Merienda1 = new SqlParameter("@Merienda1", contact.Merienda1);
                SqlParameter Merienda2 = new SqlParameter("@Merienda2", contact.Merienda2);
                SqlParameter Cena = new SqlParameter("@Cena", contact.Cena);
                SqlParameter Diario = new SqlParameter("@Diario", contact.Diario);
                SqlParameter Semanal = new SqlParameter("@Semanal", contact.Semanal);
                SqlParameter Quincenal = new SqlParameter("@Quincenal", contact.Quincenal);
                SqlParameter Mensual = new SqlParameter("@Mensual", contact.Mensual);
                SqlParameter Historial = new SqlParameter("@Historial", contact.Historial);
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.Add(Historial);
                command.Parameters.Add(NMB);
                command.Parameters.Add(HoraLevantar);
                command.Parameters.Add(HoraDesayuno);
                command.Parameters.Add(HoraMerienda1);
                command.Parameters.Add(HoraAlmuerzo);
                command.Parameters.Add(HoraMerienda2);
                command.Parameters.Add(HoraCena);
                command.Parameters.Add(Levantar);
                command.Parameters.Add(Desayuno);
                command.Parameters.Add(Merienda1);
                command.Parameters.Add(Almuerzo);
                command.Parameters.Add(Merienda2);
                command.Parameters.Add(Cena);
                command.Parameters.Add(Semanal);
                command.Parameters.Add(Diario);
                command.Parameters.Add(Quincenal);
                command.Parameters.Add(Mensual);
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
        /// 
        #endregion
        #region Modulo Almacen
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
        /// 
        #endregion


        #endregion
        #region BUSQUEDA DE DATOS EN BDD
        #region NMB
        public int GetMaxId()
        {
            int MaxId = 0;
            try
            {
                Connection.Open();
                string query = @"SELECT MAX(Id) MaxId FROM TablaNMB;";

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    MaxId = int.Parse(reader["MaxID"].ToString());

                };

            }
            catch (Exception)
            {

                MaxId = 0;
            }
            finally
            {
                Connection.Close();
            }

            return MaxId;
        }
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
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
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
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        HistorialNutricional = reader["HistorialNutricional"].ToString(),
                        Escolaridad = reader["Escolaridad"].ToString(),
                        NombreEscuela = reader["NombreEscuela"].ToString(),
                        DireccionEscuela = reader["DireccionEscuela"].ToString(),
                        Psicologia = reader["Psicologia"].ToString(),
                        TipoDiscapacidad = reader["TipoDiscapacidad"].ToString(),
                    }); ;
                }

            }
            catch (Exception)
            {
      
                  
            }
            finally
            {
                Connection.Close();
            }
            return contactsNMB;
        }
        #endregion
        #region Cuidador
        public int GetMaxIdCuidador()
        {
            int MaxId = 0;
            try
            {
                Connection.Open();
                string query = @"SELECT MAX(Id) MaxId FROM TablaCuidador;";

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    MaxId = int.Parse(reader["MaxID"].ToString());

                };

            }
            catch (Exception)
            {

                MaxId = 0;
            }
            finally
            {
                Connection.Close();
            }

            return MaxId;
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
                string query = @"Select * FROM TablaCuidador Where Id=@Search or Cedula=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));               
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
                        EstadoCivil = reader["EstadoCivil"].ToString(),
                        CantidadHijos = reader["Hijos"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Transporte = reader["Transporte"].ToString(),
                        Ocupacion = reader["Ocupacion"].ToString(),
                        IngresosPropios = reader["IngresosPropios"].ToString(),
                        Discapacidad = reader["Discapacidad"].ToString(),
                        TipoDiscapacidad = reader["TipoDiscapacidad"].ToString(),
                        GrupoEtnico = reader["GrupoEtnico"].ToString(),
                        TipoGrupoEtnico = reader["TipoGrupoEtnico"].ToString(),
                        Movilizacion = reader["Movilizacion"].ToString(),
                        CharlaMuac = reader["CharlaMuac"].ToString(),
                        CharlaLactancia = reader["CharlaLactancia"].ToString(),
                        TieneHijos = reader["TieneHijos"].ToString(),
                        Rango1 = reader["Rango1"].ToString(),
                        Rango2 = reader["Rango2"].ToString(),
                        Rango3 = reader["Rango3"].ToString(),

                    });
                }

            }
            catch (Exception)
            {

               
            }
            finally
            {
                Connection.Close();
            }
            return contactsCuidador;
        }
        public List<ContactCuidador> GetCedulaCuidador(string Search = null)
        {
            List<ContactCuidador> contactsCuidador = new List<ContactCuidador>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaCuidador Where Cedula=@Search";
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
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
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
        #endregion
        #region MMB
        public int GetMaxIdMMB()
        {
            int MaxId = 0;
            try
            {
                Connection.Open();
                string query = @"SELECT MAX(Id) MaxId FROM TablaMMB;";

                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    MaxId = int.Parse(reader["MaxID"].ToString());

                };

            }
            catch (Exception)
            {

                MaxId = 0;
            }
            finally
            {
                Connection.Close();
            }

            return MaxId;
        }
        public List<ContactMMB> GetContactsMMB(string Search = null)
        {
            List<ContactMMB> contactsMMB = new List<ContactMMB>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaMMB Where Id=@Search or Cedula = @Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));              
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
                        Telefono = reader["Telefono"].ToString(),
                        EstadoCivil = reader["EstadoCivil"].ToString(),
                        CantidadHijos = reader["Hijos"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Transporte = reader["Transporte"].ToString(),
                        Ocupacion = reader["Ocupacion"].ToString(),
                        IngresosPropios = reader["IngresosPropios"].ToString(),
                        Discapacidad = reader["Discapacidad"].ToString(),
                        TipoDiscapacidad = reader["TipoDiscapacidad"].ToString(),
                        GrupoEtnico = reader["GrupoEtnico"].ToString(),
                        TipoGrupoEtnico = reader["TipoGrupoEtnico"].ToString(),
                        Movilizacion = reader["Movilizacion"].ToString(),
                        CharlaMuac = reader["CharlaMuac"].ToString(),
                        CharlaLactancia = reader["CharlaLactancia"].ToString(),
                        TieneHijos = reader["TieneHijos"].ToString(),
                        Rango1 = reader["Rango1"].ToString(),
                        Rango2 = reader["Rango2"].ToString(),
                        Rango3 = reader["Rango3"].ToString(),
                    });
                }

            }
            catch (Exception)
            {

                
            }
            finally
            {
                Connection.Close();
            }
            return contactsMMB;
        }
        #endregion
        #region Relaciones
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
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
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
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Parentesco = reader["Parentesco"].ToString(),
                        Escolaridad = reader["Escolaridad"].ToString(),
                        DireccionEscuela = reader["DireccionEscuela"].ToString(),
                        NombreEscuela = reader["NombreEscuela"].ToString(),
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
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Cedula = reader["Cedula"].ToString(),
                        Parentesco = reader["Parentesco"].ToString(),
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
        public List<ContactNMB> GetRelacion(string Search = null)
        {
            List<ContactNMB> contacts = new List<ContactNMB>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From Referencia
                                Join TablaNMB
                                on TablaNMB.Id = Referencia.NMB
                                where Referencia.Cedula = @search";
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
                        Apellido = reader["Apellido"].ToString(),

                        Parentesco = reader["Parentesco"].ToString(),
                    });
                }
            }
            catch (Exception)
            {

               
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
                        Parentesco = reader["Parentesco"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
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
        #endregion
        #region Asistencia
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
        public List<MapaniUsers> Login(string User, string Password)
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
                {
                    Usuario.Add(new MapaniUsers
                    {
                        Id = int.Parse(reader["Id"].ToString()),
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
                        HoraEntrada = reader["Hora"].ToString(),
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
        #endregion
        #region Asesoria 
        public List<ContactAsesoria> GetHistorialAsesoria(string Search = null)
        {
            List<ContactAsesoria> contactsAsesoria = new List<ContactAsesoria>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM GestionCasosAsesoria Where IdCuidador=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));               
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactsAsesoria.Add(new ContactAsesoria
                    {
                        Fecha = (DateTime)reader["Fecha"],
                        TipoCaso = reader["TipoCaso"].ToString(),
                        TipoAtencion = reader["TipoAtencion"].ToString(),
                        Seguimiento = reader["Seguimiento"].ToString(),
                        Estatus = reader["Estatus"].ToString(),
                        Observacion = reader["Observacion"].ToString(),
                        Evolucion = reader["Evolucion"].ToString(),
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
            return contactsAsesoria;
        }

        public List<ContactAsesoria> GetContactAsesoria(string Search = null)
        {
            List<ContactAsesoria> contactAsesoria = new List<ContactAsesoria>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaContactAsesoria Where IdCuidador=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactAsesoria.Add(new ContactAsesoria
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        //  IdCuidador = int.Parse(reader["IdCuidador"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Ocupacion = reader["Ocupacion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Parroquia = reader["Parroquia"].ToString(),
                        Municipio = reader["Municipio"].ToString(),
                        Estado = reader["Estado"].ToString(),
                        Vinculo = reader["Vinculo"].ToString(),
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
            return contactAsesoria;
        }
        #endregion
        #region Documentos

        public List<ContactAsesoria> GetDocuments(string Search = null)
        {
            List<ContactAsesoria> Documents = new List<ContactAsesoria>();

            try
            {
                Connection.Open();
                string query = @"Select * FROM TablaDocumentsAsesoria Where IdCuidador=@Search";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Search", int.Parse(Search)));             
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Documents.Add(new ContactAsesoria
                    {
                        IdCuidador = int.Parse(reader["IdCuidador"].ToString()),
                        IdNMB = int.Parse(reader["IdNMB"].ToString()),
                        TipoDocumento = reader["TipoDocumento"].ToString(),
                        PDF = (byte[])reader["PDF"],

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
            return Documents;
        }
        #endregion
        #region Almacen
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
                        Descripcion = reader["Descripcion"].ToString(),

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
        #endregion
        #region Modulo Medico


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
                        Hb = (reader["Hb"].ToString()),
                        CC = (reader["CC"].ToString()),
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
        public List<ClaseEnfermeria> GetDataPediatria(string Id)
        {
            List<ClaseEnfermeria> Data = new List<ClaseEnfermeria>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaEnfermeria
                                Where TablaEnfermeria.NMB=@IdNMB";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data.Add(new ClaseEnfermeria
                    {
                        Fecha = (DateTime)reader["Fecha"],
                        Peso = reader["Peso"].ToString(),
                        Talla = reader["Talla"].ToString(),
                        IMC = reader["IMC"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        CMB = reader["CMB"].ToString(),
                        PZImcEdad = reader["PZImcEdad"].ToString(),
                        PZTallaEdad = reader["PZTallaEdad"].ToString(),
                        PZPesoEdad = reader["PZPesoEdad"].ToString(),
                        PZPesoTalla = reader["PZPesoTalla"].ToString(),
                        PZPesoEdad2006 = reader["PZPesoEdad2006"].ToString(),
                        PZTallaEdad2006 = reader["PZTallaEdad2006"].ToString(),
                        IMCPZ = reader["IMCPZ"].ToString(),
                        Urgencias = reader["Urgencias"].ToString(),
                        Referido = reader["Referido"].ToString(),
                        Diagnostico = reader["Diagnostico"].ToString(),
                        DiagnosticoTalla = reader["DiagnosticoTalla"].ToString(),
                        Hb = reader["Hb"].ToString(),
                        CC = reader["CC"].ToString(),
                        Observacion = reader["Observacion"].ToString(),
                        Antecedentes = reader["Antecedentes"].ToString(),
                        Patologia = reader["Patologias"].ToString(),
                        NMB = reader["NMB"].ToString(),
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
        public List<ClaseEnfermeria> GetDataNutricion(string Id)
        {
            List<ClaseEnfermeria> Data = new List<ClaseEnfermeria>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaNutricion
                                Where TablaNutricion.NMB=@IdNMB";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data.Add(new ClaseEnfermeria
                    {
                        Fecha = (DateTime)reader["Fecha"],
                        Peso = reader["Peso"].ToString(),
                        Talla = reader["Talla"].ToString(),
                        IMC = reader["IMC"].ToString(),
                        Programa = reader["Programa"].ToString(),
                        CMB = reader["CMB"].ToString(),
                        PZImcEdad = reader["PZImcEdad"].ToString(),
                        PZTallaEdad = reader["PZTallaEdad"].ToString(),
                        PZPesoEdad = reader["PZPesoEdad"].ToString(),
                        PZPesoTalla = reader["PZPesoTalla"].ToString(),
                        PZPesoEdad2006 = reader["PZPesoEdad2006"].ToString(),
                        PZTallaEdad2006 = reader["PZTallaEdad2006"].ToString(),
                        IMCPZ = reader["IMCPZ"].ToString(),
                        Urgencias = reader["Urgencias"].ToString(),
                        Referido = reader["Referido"].ToString(),
                        Diagnostico = reader["Diagnostico"].ToString(),
                        DiagnosticoTalla = reader["DiagnosticoTalla"].ToString(),
                        Hb = reader["Hb"].ToString(),
                        CC = reader["CC"].ToString(),
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
        public ContactNutricion GetHistorialNutricion(string Id)
        {
            ContactNutricion Data = new ContactNutricion();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaHistorialNutricion
                                Where TablaHistorialNutricion.NMB=@IdNMB";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data = new ContactNutricion
                    {
                        HoraLevantar = DateTime.Parse(reader["HoraLevantar"].ToString()),
                        HoraDesayuno = DateTime.Parse(reader["HoraDesayuno"].ToString()),
                        HoraAlmuerzo = DateTime.Parse(reader["HoraAlmuerzo"].ToString()),
                        HoraMerienda1 = DateTime.Parse(reader["HoraMerienda1"].ToString()),
                        HoraMerienda2 = DateTime.Parse(reader["HoraMerienda2"].ToString()),
                        HoraCena = DateTime.Parse(reader["HoraCena"].ToString()),
                        Levantar = reader["Levantar"].ToString(),
                        Desayuno = reader["Desayuno"].ToString(),
                        Merienda1 = reader["Merienda1"].ToString(),
                        Almuerzo = reader["Almuerzo"].ToString(),
                        Merienda2 = reader["Merienda2"].ToString(),
                        Cena = reader["Cena"].ToString(),
                        Diario = reader["Diario"].ToString(),
                        Semanal = reader["Semanal"].ToString(),
                        Quincenal = reader["Quincenal"].ToString(),
                        Mensual = reader["Mensual"].ToString(),
                    };
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
        #endregion
        #region Psicologia

        public ContactPsicologia GetEvaluacionPsicologia(string Id)
        {
            ContactPsicologia Data = new ContactPsicologia();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaPsicologia
                                Where TablaPsicologia.IdNMB=@IdNMB";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data = new ContactPsicologia
                    {

                        RazonAlta = reader["RazonAlta"].ToString(),
                        RazonMedia = reader["RazonMedia"].ToString(),
                        RazonBajo = reader["RazonBaja"].ToString(),
                        NoRazon = reader["NoRazon"].ToString(),
                        EvaluacionInicial = reader["EvaluacionInicial"].ToString(),
                        Antecedentes = reader["Antecedentes"].ToString(),
                        SistemaFamiliar = reader["SistemaFamiliar"].ToString(),
                        MotivoConsulta = reader["MotivoConsulta"].ToString(),
                        Evaluacion = reader["Evaluacion"].ToString(),

                    };
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
        public List<ContactPsicologia> GetHistorialPsicologia(string Id)
        {
            List<ContactPsicologia> Data = new List<ContactPsicologia>();
            try
            {
                Connection.Open();
                string query = @"Select * 
                                From TablaHIstorialPsicologia
                                Where TablaHistorialPsicologia.IdNMB=@IdNMB";
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@IdNMB", int.Parse(Id)));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Data.Add(new ContactPsicologia
                    {

                        RazonSalud = reader["RazonSalud"].ToString(),
                        RazonSeguridad = reader["RazonSeguridad"].ToString(),
                        RazonCuidado = reader["RazonCuidado"].ToString(),
                        RazonOtro = reader["RazonOtro"].ToString(),
                        NoRazon = reader["NoRazon"].ToString(),
                        AccionSalud = reader["AccionSalud"].ToString(),
                        AccionSeguridad = reader["AccionSeguridad"].ToString(),
                        AccionCuidado = reader["AccionCuidado"].ToString(),
                        AccionOtro = reader["AccionOtro"].ToString(),
                        NoAccion = reader["NoAccion"].ToString(),
                        Fecha = (DateTime)reader["Fecha"],
                        Seguimiento = reader["Seguimiento"].ToString(),

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
        /// 
        #endregion

        #region Recepcion

        /// <summary>
        /// Busca en la tabla de Visitas el historial de Citas que ha tenido el NMB
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<HistorialVisitas> GetHistorial(string Search = null)
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
        /// Obtiene el Historial de las citas para una fecha especifica.
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public List<HistorialVisitas> GetHistorialCitas(DateTime Search)
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
        public List<ProximasVisitas> GetCitas(DateTime Fecha)
        {
            List<ProximasVisitas> Citas = new List<ProximasVisitas>();
            try
            {
                Connection.Open();
                string query = @"Select NMB,Fecha,Departamento,Doctor,Activo,Nombre, Apellido,FechaNacimiento
                                           From ProximasVisitas, TablaNMB
                               where ProximasVisitas.Fecha =@Fecha and ProximasVisitas.NMB=TablaNMB.Id"; //and ProximasVisitas.NMB=TablaNMB.Id" Nombre, Apellido,FechaNacimiento,
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                command.CommandText = query;
                command.Connection = Connection;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Citas.Add(new ProximasVisitas
                    {
                        IdNMB = int.Parse(reader["NMB"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
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
        #endregion
       
      
      


        #endregion
    }

}
