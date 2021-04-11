﻿using System;
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
        #endregion
        #region PERMISOS DE BUSQUEDA DE DATOS
        public List<ContactNMB> GetContacts(string SearchText = null)
        {
            return _dataAccessLayer.GetContacts(SearchText);
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
        public List<ContactMMB> GetMMB(string SearchText = null)
        {
            return _dataAccessLayer.GetMMB(SearchText);
        }
        public List<HistorialVisitas> GetHistorial(string SearchText = null)
        {
            return _dataAccessLayer.GetHistorial(SearchText);
        }
        public List<ProximasVisitas> GetProximas(string SearchText = null)
        {
            return _dataAccessLayer.GetProximas(SearchText);
        }
        public List<ProximasVisitas> GetCitas(string SearchText = null)
        {
            return _dataAccessLayer.GetCitas(SearchText);
        }
        #endregion
    }
}
