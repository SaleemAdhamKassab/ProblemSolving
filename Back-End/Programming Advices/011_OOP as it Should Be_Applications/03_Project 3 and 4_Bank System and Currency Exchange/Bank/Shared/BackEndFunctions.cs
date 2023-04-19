using Lab.Bank.Models;
using Lab.Classes;

namespace Lab.Bank.Shared
{
    public class BackEndFunctions
    {
        protected string convertClientObjectToRowStringForSaving(Client client, string rowSeparator) =>
              client.AccountNumber + rowSeparator +
              client.PinCode + rowSeparator +
              client.FirstName + rowSeparator +
              client.LastName + rowSeparator +
              client.Email + rowSeparator +
              client.Phone + rowSeparator +
              client.AccountBalance;
        protected string convertUserObjectToRowStringForSaving(User user, string rowSeparator) =>
                user.FirstName + rowSeparator +
                user.LastName + rowSeparator +
                user.Email + rowSeparator +
                user.Phone + rowSeparator +
                user.UserName + rowSeparator +
                SaleemUtil.encryptText(user.Password) + rowSeparator +
                user.Permissions;
        protected string convertClientTransferLogObjectToRowStringForSaving(ClientsTransferLog clientsTransferLog, string rowSeparator) =>
                clientsTransferLog.TransferDate + rowSeparator +
                clientsTransferLog.AccountNumber + rowSeparator +
                clientsTransferLog.ToAccountNumber + rowSeparator +
                clientsTransferLog.TransferAmount + rowSeparator +
                clientsTransferLog.AccountBalanceAfterTransfer + rowSeparator +
                clientsTransferLog.DestinationBalanceAfterTransfer + rowSeparator +
                clientsTransferLog.Name;
        protected string convertCurrencyObjectToRowStringForSaving(clsCurrency currency, string rowSeparator) =>
               currency.Country + rowSeparator +
               currency.Code + rowSeparator +
               currency.Name + rowSeparator +
               currency.ExchangeRateUSD;
        protected Client convertLineToClientObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new Client(splitedLineData[0],
                                  splitedLineData[1],
                                  splitedLineData[2],
                                  splitedLineData[3],
                                  splitedLineData[4],
                                  splitedLineData[5],
                                  int.Parse(splitedLineData[6]));
        }
        protected User convertLineToUserObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new User(splitedLineData[0],
                                splitedLineData[1],
                                splitedLineData[2],
                                splitedLineData[3],
                                splitedLineData[4],
                                SaleemUtil.decryptText(splitedLineData[5]),
                                int.Parse(splitedLineData[6]));
        }
        protected UsersLoginLog convertLineToUserLogObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);
            return new UsersLoginLog(splitedLineData[0],
                                  splitedLineData[1],
                                  splitedLineData[2],
                                  splitedLineData[3],
                                  splitedLineData[4],
                                  splitedLineData[5],
                                  splitedLineData[6],
                                  int.Parse(splitedLineData[7]));
        }
        protected ClientsTransferLog convertLineToClientTransferObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);
            return new ClientsTransferLog(
                                          splitedLineData[0],
                                          splitedLineData[1],
                                          splitedLineData[2],
                                          int.Parse(splitedLineData[3]),
                                          int.Parse(splitedLineData[4]),
                                          int.Parse(splitedLineData[5]),
                                          splitedLineData[6]);
        }
        protected clsCurrency convertLineToCurrencyObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);
            return new clsCurrency(splitedLineData[0],
                                splitedLineData[1],
                                splitedLineData[2],
                                double.Parse(splitedLineData[3]));
        }
    }
}