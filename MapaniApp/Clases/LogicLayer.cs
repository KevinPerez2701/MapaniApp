using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Capa Encargada de la Logica Entre Clases
/// </summary>
namespace MapaniApp
{
    
    class LogicLayer
    {   private DataAccessLayer _dataAccessLayer;
        public LogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        #region PERMISOS DE AGREGAR CONTACTO
        public ContactMMB SaveContactMMB(ContactMMB Contact)
        {
            int flag = Contact.Id;
            if (flag == 0)
            {
                _dataAccessLayer.InserContactMMB(Contact);
            }
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Contact;
        }
        public ContactCuidador SaveContactCuidador(ContactCuidador Contact)
        {
            int flag = Contact.Id;
            if (flag == 0)
            {
                _dataAccessLayer.InserContactCuidador(Contact);
            }
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Contact;
        }

        public ContactNMB SaveContact(ContactNMB Contact)
        { int flag = Contact.Id;
            if ( flag == 0)
            {
                _dataAccessLayer.InserContactNMB(Contact);
            }
            //else
           // {
           //     _dataAccessLayer.UpdateContact(Contact);
           // }
            return Contact;
        }
        public DataAlmacen SaveProductBodega(DataAlmacen Product)
        {
            //int flag = Product.IdProducto;
            //if (flag == 0)
            //{
                _dataAccessLayer.InserProductBodega(Product);
            //}
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Product;
        }
        public DataAlmacen UpdateCantidad(DataAlmacen Product)
        {
            //int flag = Product.IdProducto;
            //if (flag == 0)
            //{
            _dataAccessLayer.UpdateCantidad(Product);
            //}
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Product;
        }
        public DataAlmacen UpdateCantidadBodega(DataAlmacen Product)
        {
            //int flag = Product.IdProducto;
            //if (flag == 0)
            //{
            _dataAccessLayer.UpdateCantidadBodega(Product);
            //}
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Product;
        }
        public ClaseEnfermeria SaveContactEnfermeria(ClaseEnfermeria Contact)
        {
            //int flag = Contact.Id;
            //if (flag == 0)
            //{
                _dataAccessLayer.InserCitaEnfermeria(Contact);
            //}
            //else
            // {
            //     _dataAccessLayer.UpdateContact(Contact);
            // }
            return Contact;
        }
        public  ProximasVisitas SaveCita(ProximasVisitas Cita)
        {
                _dataAccessLayer.InserCita(Cita);
            return Cita;
        }
        public DataAlmacen SaveOrder(DataAlmacen Orden)
        {
            _dataAccessLayer.InsertOrden(Orden);
            _dataAccessLayer.UpdateDiferido(Orden);
            return Orden;
        }
        public DataAlmacen Despacho(DataAlmacen Orden)
        {
            _dataAccessLayer.InsertDespacho(Orden);
            _dataAccessLayer.UpdateAlmacen(Orden);
            return Orden;
        }
        public HistorialVisitas ConfirmCita(HistorialVisitas Cita)
        {
            _dataAccessLayer.ConfirmCita(Cita);
            return Cita;
        }
        public HistorialVisitas DeleteCita(HistorialVisitas Cita)
        {
            _dataAccessLayer.DeleteCita(Cita);
            return Cita;
        }
        #endregion
        #region PERMISOS DE BUSQUEDA DE DATOS
        public List<ContactNMB> GetContacts(string SearchText = null)
        {
            return _dataAccessLayer.GetContacts(SearchText);
        }
        public List<ContactCuidador> GetCedulaCuidador(string SearchText = null)
        {
            return _dataAccessLayer.GetCedulaCuidador(SearchText);
        }
        public List<ContactCuidador> GetContactsCuidador(string SearchText = null)
        {
            return _dataAccessLayer.GetContactsCuidador(SearchText);
        }
        public List<ContactMMB> GetContactsMMB(string SearchText = null)
        {
            return _dataAccessLayer.GetContactsMMB(SearchText);
        }
        public List<ContactCuidador> GetCuidadores(string SearchText = null)
        {
            return _dataAccessLayer.GetCuidadores(SearchText);
        }
        public List<ContactNMB> GetNMB(string SearchText = null)
        {
            return _dataAccessLayer.GetNMB(SearchText);
        }
        public List<DataAlmacen> GetProductos()
        {
            return _dataAccessLayer.GetProductos();
        }
        public List<DataAlmacen> GetProductosBodega()
        {
            return _dataAccessLayer.GetProductosBodega();
        }
        public List<ClaseEnfermeria> GetDataEnfermeria(string Id, DateTime Fecha)
        {
            return _dataAccessLayer.GetDataEnfermeria(Id, Fecha);
        }
        public List<DataAlmacen> GetOrdenes()
        {   
            return _dataAccessLayer.GetOrdenes();
        }
        public List<DataAlmacen> GetHistorialOrdenes(DataAlmacen Historial)
        {
            return _dataAccessLayer.GetHistorialOrdenes(Historial);
        }
        public List<ContactMMB> GetMMB(string SearchText = null)
        {
            return _dataAccessLayer.GetMMB(SearchText);
        }
        public List<HistorialVisitas> GetHistorial(string SearchText = null)
        {
            return _dataAccessLayer.GetHistorial(SearchText);
        }
        public List<HistorialVisitas> GetHistorialCitas(DateTime SearchText)
        {
            return _dataAccessLayer.GetHistorialCitas(SearchText);
        }
        public List<ProximasVisitas> GetProximas(string SearchText = null)
        {
            return _dataAccessLayer.GetProximas(SearchText);
        }
        public List<ProximasVisitas> GetCitas(DateTime SearchText)
        {
            return _dataAccessLayer.GetCitas(SearchText);
        }
        public void InsertRelacion(string IdNMB, string IdCuidador,string parentesco)
        {
            _dataAccessLayer.InsertRelacion(IdNMB, IdCuidador,parentesco);
        }
        public void InsertRelacionMMB(string IdNMB, string IdMMB, string parentesco)
        {
            _dataAccessLayer.InsertRelacionMMB(IdNMB, IdMMB,parentesco);
        }
        public string Login(string User, string Password)
        {
           return _dataAccessLayer.Login(User, Password);
        }
        #endregion
    }
}
