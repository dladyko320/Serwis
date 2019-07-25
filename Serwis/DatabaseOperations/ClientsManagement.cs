using System.Linq;
using System.Windows.Forms;
using Serwis.Models;

namespace Serwis.DatabaseOperations
{
    public class ClientsManagement
    {
        private SerwisContext _serwisContext;
        private static ClientsManagement _instance;

        public ClientsManagement(SerwisContext serwisContext)
        {
            _serwisContext = serwisContext;
        }

        public static ClientsManagement GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ClientsManagement(SerwisContext.GetContext());
            }
            return _instance;
        }

        public void AddClient(string name,string phoneNumber, string email, string annotation)
        {
            if (string.IsNullOrEmpty(email) || email.Contains("@"))
            {
                if (string.IsNullOrWhiteSpace(name) == false)
                {
                    _serwisContext.Clients.Add(new Client { Name = name, PhoneNumber = phoneNumber, Email = email, Annotation = annotation });
                    _serwisContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show(Messages.ClientManagement_EmptyName);
                }
            }
            else
            {
                MessageBox.Show(Messages.ClientManagement_IncorrectEmail);
            }
        }

        public void UpdateClientById(int id,string newName, string newPhoneNumber, string newEmail, string newAnnotation)
        {

            Client currentClient = _serwisContext.Clients.FirstOrDefault(x => x.ClientId == id);
            Client newClient = new Client { ClientId = id, Name = newName, PhoneNumber = newPhoneNumber, Email = newEmail, Annotation = newAnnotation };
            _serwisContext.Entry(currentClient).CurrentValues.SetValues(newClient);
            _serwisContext.SaveChanges();
            MessageBox.Show(Messages.ChangesSaved);

        }

        public void DeleteClient(int id)
        {
            var clientRepairs = _serwisContext.Repairs.Where(x => x.Client.ClientId == id).ToList();
            if (clientRepairs.Count == 0)
            {
                _serwisContext.Clients.Remove(_serwisContext.Clients.Single(a => a.ClientId == id));
                _serwisContext.SaveChanges();
            }
            else
            {
                MessageBox.Show(Messages.ClientsManagement_ClientHaveHistory);
            }
        }

    }
}
