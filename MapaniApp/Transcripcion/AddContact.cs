using System;
using System.Windows.Forms;

namespace MapaniApp
{
    public partial class AddContact : Form
    {
        private Metodos _metodos;
        private ContactNMB _contactNMB = new ContactNMB();
        private ContactCuidador _contactCuidador = new ContactCuidador();
        private ContactMMB _contactMMB = new ContactMMB();
        private LogicLayer _LogicLayer = new LogicLayer();
        public AddContact()
        {
            InitializeComponent();
            _metodos = new Metodos();
        }
        #region AGREGAR CONTACTOS
        private void SaveContact()
        {
            ContactNMB Contact = new ContactNMB
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value.Date,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Cedula = TxtCedula.Text,
                FechaIngreso = dateTimePicker2.Value.Date,
                Discapacidad = ComboDiscapacidad.Text,
                Lactancia = ComboLactancia.Text,
                Ingreso = ComboIngreso.Text,
                Vacunas = ComboVacunas.Text,
                Parto = ComboParto.Text,
                PartidaNacimiento = ComboPartidaNacimiento.Text,
                Parroquia = txtParroquia.Text,
                Municipio = txtMunicipio.Text,
                Estado = txtEstado.Text,
                Escolaridad = txtEscolaridad.Text,
                NombreEscuela = txtNombreEscuela.Text,
                DireccionEscuela = txtDireccionEscuela.Text,
                TipoDiscapacidad = comboTipoDiscapacidadNMB.Text,
                Id = _contactNMB != null ? _contactNMB.Id : 0
            };
            if (PrimeraVez.Checked == true)
            {
                Contact.Id = int.Parse(textBox2.Text);
            }
            _LogicLayer.SaveContact(Contact,PrimeraVez.Checked);
        }

        private void SaveContactCuidador()
        {
            ContactCuidador Contact = new ContactCuidador
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Telefono = TxtTelefono.Text,
                Cedula = TxtCedula.Text,
                EstadoCivil = ComboEstadoCivil.Text,
                Transporte = TxtTransporte.Text,
                Parroquia = txtParroquia.Text,
                Municipio = txtMunicipio.Text,
                Estado = txtEstado.Text,
                Ocupacion = txtOcupacion.Text,
                IngresosPropios = ComboIngresosPropios.Text,
                Discapacidad = ComboDiscapacidadCuidador.Text,
                TipoDiscapacidad = ComboTipoDiscapacidadCuidador.Text,
                GrupoEtnico = ComboGrupoEtnico.Text,
                TipoGrupoEtnico = txtGrupoEtnico.Text,
                Movilizacion = ComboMovilizacion.Text,
                CharlaMuac = ComboMuacRecibido.Text,
                CharlaLactancia = ComboCharlaLactancia.Text,
                TieneHijos = ComboHijosHogar.Text,
                CantidadHijos = TxtHijos.Text,
                Rango1 = txtRango1.Text,
                Rango2 = txtRango2.Text,
                Rango3 = txtRango3.Text,
                Id = _contactCuidador != null ? _contactCuidador.Id : 0
            };
            _LogicLayer.SaveContactCuidador(Contact);
        }
        private void SaveContactMMB()
        {
            ContactMMB Contact = new ContactMMB
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                FechaNacimiento = dateTimePicker1.Value,
                Direccion = TxtDireccion.Text,
                Sexo = ComboSexo.Text,
                Foto = Metodos.ImageToArray(PbFotoNewContact),
                Telefono = TxtTelefono.Text,
                Cedula = TxtCedula.Text,
                EstadoCivil = ComboEstadoCivil.Text,
                CantidadHijos = TxtHijos.Text,
                Transporte = TxtTransporte.Text,
                Parroquia = txtParroquia.Text,
                Municipio = txtMunicipio.Text,
                Estado = txtEstado.Text,
                Ocupacion = txtOcupacion.Text,                
                IngresosPropios = ComboIngresosPropios.Text,
                Discapacidad = ComboDiscapacidadCuidador.Text,
                TipoDiscapacidad = ComboTipoDiscapacidadCuidador.Text,
                GrupoEtnico = ComboGrupoEtnico.Text,
                TipoGrupoEtnico = txtGrupoEtnico.Text,
                Movilizacion = ComboMovilizacion.Text,
                CharlaMuac = ComboMuacRecibido.Text,
                CharlaLactancia = ComboCharlaLactancia.Text,
                TieneHijos = ComboHijosHogar.Text,               
                Rango1 = txtRango1.Text,
                Rango2 = txtRango2.Text,
                Rango3 = txtRango3.Text,
                Id = _contactMMB != null ? _contactMMB.Id : 0
            };
            _LogicLayer.SaveContactMMB(Contact);
        }
        #endregion
        #region METODOS  FORM ADD CONTACTS
        public void LoadContact(ContactNMB contact)
        {
            _contactNMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                dateTimePicker2.Value = contact.FechaIngreso.Date;
                ComboLactancia.Text = contact.Lactancia;
                TxtCedula.Text = contact.Cedula;
                ComboDiscapacidad.Text = contact.Discapacidad;
                ComboParto.Text = contact.Parto;
                ComboVacunas.Text = contact.Vacunas;
                ComboPartidaNacimiento.Text = contact.PartidaNacimiento;
                ComboIngreso.Text = contact.Ingreso;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                txtParroquia.Text = contact.Parroquia;
                txtMunicipio.Text = contact.Municipio;
                txtEstado.Text = contact.Estado;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
                txtEscolaridad.Text = contact.Escolaridad;
                txtDireccionEscuela.Text = contact.DireccionEscuela;
                txtNombreEscuela.Text = contact.NombreEscuela;
                comboTipoDiscapacidadNMB.Text = contact.TipoDiscapacidad;
            }


        }
        public void LoadContactCuidador(ContactCuidador contact)
        {
            _contactCuidador = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                ComboEstadoCivil.Text = contact.EstadoCivil;
                TxtHijos.Text = contact.CantidadHijos;
                TxtCedula.Text = contact.Cedula;
                TxtTelefono.Text = contact.Telefono;
                TxtTransporte.Text = contact.Transporte;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                txtParroquia.Text = contact.Parroquia;
                txtMunicipio.Text = contact.Municipio;
                txtEstado.Text = contact.Estado;
                txtOcupacion.Text = contact.Ocupacion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);
                ComboIngresosPropios.Text = contact.IngresosPropios;
                ComboDiscapacidadCuidador.Text = contact.Discapacidad;
                ComboTipoDiscapacidadCuidador.Text = contact.TipoDiscapacidad;
                ComboGrupoEtnico.Text = contact.GrupoEtnico;
                txtGrupoEtnico.Text = contact.TipoGrupoEtnico;
                ComboMovilizacion.Text = contact.Movilizacion;
                ComboCharlaLactancia.Text = contact.CharlaLactancia;
                ComboMuacRecibido.Text = contact.CharlaMuac;
                ComboHijosHogar.Text = contact.TieneHijos;
                txtRango1.Text = contact.Rango1;
                txtRango2.Text = contact.Rango2;
                txtRango3.Text = contact.Rango3;
            }


        }
        public void LoadContactMMB(ContactMMB contact)
        {
            _contactMMB = contact;
            if (contact != null)
            {

                TxtNombre.Text = contact.Nombre;
                TxtApellido.Text = contact.Apellido;
                dateTimePicker1.Value = contact.FechaNacimiento.Date;
                ComboEstadoCivil.Text = contact.EstadoCivil;
                TxtHijos.Text = contact.CantidadHijos;
                TxtCedula.Text = contact.Cedula;
                TxtTelefono.Text = contact.Telefono;
                TxtTransporte.Text = contact.Transporte;
                ComboSexo.Text = contact.Sexo;
                TxtDireccion.Text = contact.Direccion;
                TxtDireccion.Text = contact.Direccion;
                txtParroquia.Text = contact.Parroquia;
                txtMunicipio.Text = contact.Municipio;
                txtEstado.Text = contact.Estado;
                txtOcupacion.Text = contact.Ocupacion;
                PbFotoNewContact.Image = Metodos.GetImageFromByteArray(contact.Foto);               
                ComboIngresosPropios.Text = contact.IngresosPropios;
                ComboDiscapacidadCuidador.Text = contact.Discapacidad;
                ComboTipoDiscapacidadCuidador.Text = contact.TipoDiscapacidad;
                ComboGrupoEtnico.Text = contact.GrupoEtnico;
                txtGrupoEtnico.Text = contact.TipoGrupoEtnico;
                ComboMovilizacion.Text = contact.Movilizacion;
                ComboCharlaLactancia.Text = contact.CharlaLactancia;
                ComboMuacRecibido.Text = contact.CharlaMuac;
                ComboHijosHogar.Text = contact.TieneHijos;
                txtRango1.Text = contact.Rango1;
                txtRango2.Text = contact.Rango2;
                txtRango3.Text = contact.Rango3;
            }


        }
        public void LoadUser(string Contact, string Id = null)
        {
            textBox1.Text = Contact;
            textBox1.ReadOnly = true;
            textBox2.Text = Id;
            textBox2.ReadOnly = true;
        }
        public void LoadId(string Contact, string Id = null)
        {
            int aux;
            textBox1.Text = Contact;
            textBox1.ReadOnly = true;
            if (Contact == "NMB" && Id == null)
            {
                aux = _LogicLayer.GetMaxID();
                aux++;
                textBox2.Text = aux.ToString();
                textBox2.ReadOnly = true;
            }
            else if (Contact == "NMB" && Id != null)
            {
                textBox2.Text = Id;
                textBox2.ReadOnly = true;
                PrimeraVez.Checked = true;
            }
            else if (Contact == "Cuidador")
            {
                aux = _LogicLayer.GetMaxIDCuidador();
                aux++;
                textBox2.Text = aux.ToString();
                textBox2.ReadOnly = true;
            }
            else if (Contact == "MMB")
            {
                aux = _LogicLayer.GetMaxIDMMB();
                aux++;
                textBox2.Text = aux.ToString();
                textBox2.ReadOnly = true;
            }

        }
        public void EditUser(string Contact, string Id)
        {
            textBox1.Text = Contact;
            textBox1.ReadOnly = true;
            textBox2.Text = Id;
            textBox2.ReadOnly = true;

        }
        public void HideSave()
        {
            BtnSave.Visible = false;
        }
        #endregion
        #region EVENTOS DE BOTONES
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "NMB")
            {
                groupBox2.Visible = false;
                groupNMB.Visible = true;
                groupEscolaridad.Visible = true;
                groupCharla.Visible = false;
            }
            else if (textBox1.Text == "MMB" || textBox1.Text == "Cuidador")
            {
                groupBox2.Visible = true;
                groupNMB.Visible = false;
                groupEscolaridad.Visible = false;
                groupCharla.Visible = true;

            }
        }
        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Metodos.AgregarFoto(PbFotoNewContact);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NMB" )
            {
                SaveContact();
            }
            
            else if (textBox1.Text == "Cuidador")
            {
                SaveContactCuidador();
            }
            else if (textBox1.Text == "MMB")
            {
                SaveContactMMB();

            }
            this.Close();
        }



        #endregion

        private void AddContact_Load(object sender, EventArgs e)
        {

        }
        #region Validacion de Datos
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese un Caracter Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese un Caracter Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ComboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }



        private void ComboEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese una opcion Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }

        private void AddContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(Metodos.GetEdadAnhos(dateTimePicker1.Value)) > 17 && textBox1.Text == "NMB")
            {
                MessageBox.Show("Ingrese una Fecha de Nacimiento Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePicker1.Value = DateTime.Now;
            }
            else if (int.Parse(Metodos.GetEdadAnhos(dateTimePicker1.Value)) < 0 )
            {
                MessageBox.Show("Ingrese una Fecha de Nacimiento Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePicker1.Value = DateTime.Now;
            }
            
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (int.Parse(Metodos.GetEdad(dateTimePicker2.Value, DateTime.Now)) < 0)

            {
                MessageBox.Show("Ingrese una Fecha de visita Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateTimePicker2.Value = DateTime.Now;
            }
        }
        #endregion


    }
}
