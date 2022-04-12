using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class ImprimirTranscripcion : Form
    {

        private ContactNMB _contactNMB = new ContactNMB();
        private ContactMMB _contactMMB = new ContactMMB();
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private LogicLayer _LogicLayer = new LogicLayer();
        private Metodos _metodos = new Metodos();

       
        public ImprimirTranscripcion()
        {
          
            InitializeComponent();
            
        }
        public class Imprimir
        {
       
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Edad { get; set; }
            public DateTime FechaIngreso { get; set; }
            public string Lactancia { get; set; }
            public string Parto { get; set; }
            public string PartidaNacimiento { get; set; }
            public string Discapacidad { get; set; }
            public string TipoDiscapacidad { get; set; }
            public string Ingreso { get; set; }
             public string Vacunas { get; set; }
            public string Direccion { get; set; }
            public string Sexo { get; set; }          
            public string Parroquia { get; set; }
            public string Municipio { get; set; }
            public string Estado { get; set; }
            public string Parentesco { get; set; }
            public int IdCuidador { get; set; }
            public string NombreCuidador { get; set; }
            public string ApellidoCuidador { get; set; }
            public DateTime FechaNacimientoCuidador { get; set; }
            public string EdadCuidador { get; set; }
            public string SexoCuidador { get; set; }
            public string Telefono { get; set; }
            public string EstadoCivil { get; set; }
            public string Cedula { get; set; }
            public string Transporte { get; set; }                       
            public string Ocupacion { get; set; }
            public string IngresosPropios { get; set; }
            public string DiscapacidadCuidador { get; set; }
            public string TipoDiscapacidadCuidador { get; set; }
            public string GrupoEtnico { get; set; }
            public string TipoGrupoEtnico { get; set; }
            public string Movilizacion { get; set; }
            public string CharlaMuac { get; set; }
            public string CharlaLactancia { get; set; }
            public string TieneHijos { get; set; }         
            public string Rango1 { get; set; }
            public string Rango2 { get; set; }
            public string Rango3 { get; set; }

        }
       

        



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //string direccion;
            /*Graphics g = this.CreateGraphics();
             bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
             Graphics mg = Graphics.FromImage(bmp);
             mg.CopyFromScreen(this.Location.X+10, this.Location.Y, 0, 0, this.Size);
             printPreviewDialog1.Show(this);  */
            
            List<ContactNMB> contacts = _LogicLayer.GetContacts(txtIdNMB.Text);
            ContactNMB contact = contacts[0];
            if (labelCuidador.Visible = true)
            {
                List<ContactCuidador> contactsCuidador = _LogicLayer.GetContactsCuidador(txtIdCuidador.Text);
                ContactCuidador contactCuidador = contactsCuidador[0];
                var Imprimir = new List<Imprimir>
            {
            new Imprimir {
          
            Id=int.Parse(txtIdNMB.Text),
            IdCuidador=int.Parse(txtIdCuidador.Text),
            Parto = contact.Parto,
            Vacunas = contact.Vacunas,
            Lactancia = contact.Lactancia,
            Ocupacion = contactCuidador.Ocupacion,
            Transporte = contactCuidador.Transporte,
            CharlaMuac = contactCuidador.CharlaMuac,
            CharlaLactancia = contactCuidador.CharlaLactancia,
            TieneHijos = contactCuidador.TieneHijos,
            Nombre =TxtNombre.Text ,
            Apellido = TxtApellido.Text ,
            FechaNacimiento = FechaNacimientoNMB.Value,
            FechaIngreso = Fecha.Value ,
            Sexo = TxtGenero.Text ,
            Discapacidad =  ComboDiscapacidadNMB.Text ,
            TipoDiscapacidad =  ComboTipoDiscapacidadCuidador.Text ,
            PartidaNacimiento =    txtPartidaNacimiento.Text ,
            Ingreso =   txtTipoIngreso.Text ,
            Direccion =   txtDireccion.Text ,
            Parroquia = txtParroquia.Text ,
            Municipio= txtMunicipio.Text ,
            Estado =   txtEstado.Text ,
            Edad =  txtEdadNMB.Text ,
            Parentesco =    txtParentesco.Text ,
            NombreCuidador=  txtNombreCuidador.Text ,
            ApellidoCuidador =  txtApellidoCuidador.Text ,
            SexoCuidador =   txtGeneroCuidador.Text ,
            Cedula = txtCedula.Text ,
            FechaNacimientoCuidador = dateTimePicker2.Value ,
            EdadCuidador =  txtEdad.Text ,
            EstadoCivil = txtEstadoCivil.Text ,
            Telefono = txtTelefono.Text ,
            IngresosPropios =  txtIngresos.Text ,
            DiscapacidadCuidador= ComboDiscapacidadCuidador.Text ,
            TipoDiscapacidadCuidador = ComboTipoDiscapacidadCuidador.Text ,
            GrupoEtnico = ComboGrupoEtnico.Text ,
            TipoGrupoEtnico =   txtGrupoEtnico.Text ,
            Movilizacion = txtMovilizacion.Text ,
            Rango1 = txtRango1.Text ,
            Rango2 =  txtRango2.Text ,
            Rango3 =  txtRango3.Text ,
        },
            };  
                using (var fd = new FolderBrowserDialog())
                {
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                    {
                       string  direccion = fd.SelectedPath;
                       
                        using (var writer = new StreamWriter(direccion + "\\" + contact.Id + contact.Nombre + contactCuidador.Id+contactCuidador.Nombre+ ".csv",false,Encoding.Default ))
                        {
                           
                            writer.WriteLine("sep=,");
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {
                               
                                csv.WriteRecords(Imprimir);
                            }
                            
                        }
                        

                    }
                }
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (labelMMB.Visible = true)
            {
                List<ContactMMB> contactsCuidador = _LogicLayer.GetContactsMMB(txtIdCuidador.Text);
                ContactMMB contactCuidador = contactsCuidador[0];
                var Imprimir = new List<Imprimir>
                     {
                        new Imprimir 
                        {
                                Id=int.Parse(txtIdNMB.Text),
                                IdCuidador=int.Parse(txtIdCuidador.Text),
                                Parto = contact.Parto,
                                Vacunas = contact.Vacunas,
                                Lactancia = contact.Lactancia,
                                Ocupacion = contactCuidador.Ocupacion,
                                Transporte = contactCuidador.Transporte,
                                CharlaMuac = contactCuidador.CharlaMuac,
                                CharlaLactancia = contactCuidador.CharlaLactancia,
                                TieneHijos = contactCuidador.TieneHijos,
                                Nombre =TxtNombre.Text ,
                                Apellido = TxtApellido.Text ,
                                FechaNacimiento = FechaNacimientoNMB.Value,
                                FechaIngreso = Fecha.Value ,
                                Sexo = TxtGenero.Text ,
                                Discapacidad =  ComboDiscapacidadNMB.Text ,
                                TipoDiscapacidad =  ComboTipoDiscapacidadCuidador.Text ,
                                PartidaNacimiento =    txtPartidaNacimiento.Text ,
                                Ingreso =   txtTipoIngreso.Text ,
                                Direccion =   txtDireccion.Text ,
                                Parroquia = txtParroquia.Text ,
                                Municipio= txtMunicipio.Text ,
                                Estado =   txtEstado.Text ,
                                Edad =  txtEdadNMB.Text ,
                                Parentesco =    txtParentesco.Text ,
                                NombreCuidador=  txtNombreCuidador.Text ,
                                ApellidoCuidador =  txtApellidoCuidador.Text ,
                                SexoCuidador =   txtGeneroCuidador.Text ,
                                Cedula = txtCedula.Text ,
                                FechaNacimientoCuidador = dateTimePicker2.Value ,
                                EdadCuidador =  txtEdad.Text ,
                                EstadoCivil = txtEstadoCivil.Text ,
                                Telefono = txtTelefono.Text ,
                                IngresosPropios =  txtIngresos.Text ,
                                DiscapacidadCuidador= ComboDiscapacidadCuidador.Text ,
                                TipoDiscapacidadCuidador = ComboTipoDiscapacidadCuidador.Text ,
                                GrupoEtnico = ComboGrupoEtnico.Text ,
                                TipoGrupoEtnico =   txtGrupoEtnico.Text ,
                                Movilizacion = txtMovilizacion.Text ,
                                Rango1 = txtRango1.Text ,
                                Rango2 =  txtRango2.Text ,
                                Rango3 =  txtRango3.Text ,
                        },
                 };
                using (var fd = new FolderBrowserDialog())
                {
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                    {
                        string direccion = fd.SelectedPath;
                        using (var writer = new StreamWriter(direccion + "\\" + contact.Id + contact.Nombre + contactCuidador.Id + contactCuidador.Nombre + ".csv",false,Encoding.Default))
                        {
                            writer.WriteLine("sep=,");
                            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                            {
                                csv.WriteRecords(Imprimir);
                            }
                        }
                    }
                }
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
           
        }


        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {
                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                FechaNacimientoNMB.Value = contact.FechaNacimiento.Date;
                Fecha.Value = contact.FechaIngreso.Date;
                TxtGenero.Text = contact.Sexo;
                ComboDiscapacidadNMB.Text = contact.Discapacidad;
                ComboTipoDiscapacidadCuidador.Text = contact.TipoDiscapacidad;
                txtIdNMB.Text = Convert.ToString(contact.Id);
                txtPartidaNacimiento.Text = contact.PartidaNacimiento;
                txtTipoIngreso.Text = contact.Ingreso;
                txtDireccion.Text = contact.Direccion;
                txtParroquia.Text = contact.Parroquia;
                txtMunicipio.Text = contact.Municipio;
                txtEstado.Text = contact.Estado;
                txtEdadNMB.Text = Metodos.ObtenerEdad(contact.FechaNacimiento.Date);
                List<ContactCuidador> Relacion = _LogicLayer.GetCuidadores(contact.Id.ToString());
                txtParentesco.Text = Relacion[0].Parentesco;
            }
           
        }

        public void LoadContactCuidador(ContactCuidador contact)
        {
            _contactCuidador = contact;
            if (contact != null)
            {
                txtIdCuidador.Text = contact.Id.ToString();
                txtNombreCuidador.Text = contact.Nombre;
                txtApellidoCuidador.Text = contact.Apellido;
                txtGeneroCuidador.Text = contact.Sexo;
                txtCedula.Text = contact.Cedula;
                dateTimePicker2.Value = contact.FechaNacimiento.Date;
                txtEdad.Text = Metodos.ObtenerEdad(contact.FechaNacimiento.Date);
                txtEstadoCivil.Text = contact.EstadoCivil;
                txtTelefono.Text = contact.Telefono;
                txtIngresos.Text = contact.IngresosPropios;
                ComboDiscapacidadCuidador.Text = contact.Discapacidad;
                ComboTipoDiscapacidadCuidador.Text = contact.TipoDiscapacidad;
                ComboGrupoEtnico.Text = contact.GrupoEtnico;
                txtGrupoEtnico.Text = contact.TipoGrupoEtnico;
                txtMovilizacion.Text = contact.Movilizacion;
                txtRango1.Text = contact.Rango1;
                txtRango2.Text = contact.Rango2;
                txtRango3.Text = contact.Rango3;
                labelCuidador.Visible = true;
            }


        }
        public void LoadContactMMB(ContactMMB contact)
        {
            _contactMMB = contact;
            if (contact != null)
            {
                txtIdCuidador.Text = contact.Id.ToString();
                txtNombreCuidador.Text = contact.Nombre;
                txtApellidoCuidador.Text = contact.Apellido;
                txtGeneroCuidador.Text = contact.Sexo;
                txtCedula.Text = contact.Cedula;
                dateTimePicker2.Value = contact.FechaNacimiento.Date;
                txtEdad.Text = Metodos.ObtenerEdad(contact.FechaNacimiento.Date);
                txtEstadoCivil.Text = contact.EstadoCivil;
                txtTelefono.Text = contact.Telefono;
                txtIngresos.Text = contact.IngresosPropios;
                ComboDiscapacidadCuidador.Text = contact.Discapacidad;
                ComboTipoDiscapacidadCuidador.Text = contact.TipoDiscapacidad;
                ComboGrupoEtnico.Text = contact.GrupoEtnico;
                txtGrupoEtnico.Text = contact.TipoGrupoEtnico;
                txtMovilizacion.Text = contact.Movilizacion;
                txtRango1.Text = contact.Rango1;
                txtRango2.Text = contact.Rango2;
                txtRango3.Text = contact.Rango3;
                labelMMB.Visible = true;
            }


        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirTranscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}

