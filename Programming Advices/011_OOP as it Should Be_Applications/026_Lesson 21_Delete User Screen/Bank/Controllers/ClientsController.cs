using Lab.Bank.Db;
using Lab.Class.Bank;

namespace Lab.Bank.Controllers
{
    public class ClientsController : FileDbContext
    {
        private static Client _getEmptyClientObject() => new Client("", "", "", "", "", "", 0);
        private void _swapClients(Client clientToUpdate, Client newClient)
        {
            clientToUpdate.AccountNumber = newClient.AccountNumber;
            clientToUpdate.PinCode = newClient.PinCode;
            clientToUpdate.FirstName = newClient.FirstName;
            clientToUpdate.LastName = newClient.LastName;
            clientToUpdate.Email = newClient.Email;
            clientToUpdate.Phone = newClient.Phone;
            clientToUpdate.AccountBalance = newClient.AccountBalance;
        }

        public List<Object> Get() => convertFileDataToList(clientsDbConnectionString, fileRowSeparator, enConvertLineToObjetTypes.Client);
        public Client Get(string accountNumber)
        {
            List<object> clients = Get();

            foreach (Client client in clients)
            {
                if (client.AccountNumber == accountNumber)
                    return client;
            }
            return _getEmptyClientObject();
        }
        public bool IsClientExsist(string accountNumber) => Get(accountNumber).AccountNumber == "" ? false : true;
        public void Post(Client client) => saveRowToFile(clientsDbConnectionString, convertClientObjectToRowStringForSaving(client, fileRowSeparator));
        public void Delete(string accountNumber)
        {
            List<object> clientsList = Get();
            List<object> clientsListAfterDeleteClient = new List<object>();

            foreach (Client client in clientsList)
                if (client.AccountNumber != accountNumber)
                    clientsListAfterDeleteClient.Add(client);

            saveListToFile(clientsListAfterDeleteClient, clientsDbConnectionString, false);
        }
        public void Update(Client client)
        {
            List<object> clientsList = Get();
            List<object> clientsListAfterUpdateClient = new List<object>();
            Client clientToUpdate = Get(client.AccountNumber);

            foreach (Client c in clientsList)
            {
                if (c.AccountNumber == clientToUpdate.AccountNumber)
                    _swapClients(c, client);

                clientsListAfterUpdateClient.Add(c);
            }
            saveListToFile(clientsListAfterUpdateClient, clientsDbConnectionString, false);
        }
    }
}
