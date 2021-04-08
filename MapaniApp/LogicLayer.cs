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
        public List<ContactNMB> GetContacts(string SearchText = null)
        {
            return _dataAccessLayer.GetContacts(SearchText);
        }
        public List<ContactCuidador> GetCuidadores(string SearchText = null)
        {
            return _dataAccessLayer.GetCuidadores(SearchText);
        }
    }
}
