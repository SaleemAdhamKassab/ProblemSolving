using Lab.Bank.Models;
using Lab.Bank.Shared;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab.Bank.Db
{
    public class FileDbContext : BackEndFunctions
    {
        List<object> _convertFileToList(string connectionString, string seperator, enConvertLineToObjetTypes objType)
        {
            List<object> list = new List<object>();

            if (objType == enConvertLineToObjetTypes.Client)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToClientObject(lineData, seperator));
            }
            else if (objType == enConvertLineToObjetTypes.User)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToUserObject(lineData, seperator));
            }
            else if (objType == enConvertLineToObjetTypes.UsersLog)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToUserLogObject(lineData, seperator));
            }
            else if (objType == enConvertLineToObjetTypes.ClientsTransferBalancesLog)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToClientTransferObject(lineData, seperator));
            }
            else if (objType == enConvertLineToObjetTypes.Currency)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToCurrencyObject(lineData, seperator));
            }

            return list;
        }
        StreamWriter _streamWriterMod(string connectionString, bool isAppend = true) => isAppend ? new StreamWriter(connectionString, append: true) : new StreamWriter(connectionString);
        protected static readonly string BankDbConnectionString = "BankDb";
        protected readonly string clientsDbConnectionString = BankDbConnectionString + @"\ClientsDB.txt";
        protected readonly static string usersDbConnectionString = BankDbConnectionString + @"\UsersDB.txt";
        protected readonly string usersLoginRegisterDbConnectionString = BankDbConnectionString + @"\UsersLoginLog.txt";
        protected readonly string clientsTransferAmountsLogDbConnectionString = BankDbConnectionString + @"\ClientsTransferAmountsLog.txt";
        protected readonly string currenciesDbConnectionString = BankDbConnectionString + @"\Currencies.txt";
        protected static readonly string fileRowSeparator = "#//#";
        protected List<object> convertFileDataToList(string connectionString, string seperator, enConvertLineToObjetTypes objType) => _convertFileToList(connectionString, seperator, objType);
        protected void saveListToFile(List<object> objList, string connectionString, bool isAppend = true)
        {
            try
            {
                //if (objList.Count == 0)
                //{
                //    //file.Write("");
                //    file.Close();
                //    return true;
                //}
                StreamWriter file;

                if (isAppend)
                    file = _streamWriterMod(connectionString);
                else
                    file = _streamWriterMod(connectionString, false);

                if (connectionString == clientsDbConnectionString)
                {
                    foreach (Client client in objList)
                        file.WriteLine(convertClientObjectToRowStringForSaving(client, fileRowSeparator));
                }
                else if (connectionString == usersDbConnectionString)
                {
                    foreach (User user in objList)
                        file.WriteLine(convertUserObjectToRowStringForSaving(user, fileRowSeparator));
                }
                else if (connectionString == currenciesDbConnectionString)
                {
                    foreach (clsCurrency currency in objList)
                        file.WriteLine(convertCurrencyObjectToRowStringForSaving(currency, fileRowSeparator));
                }

                file.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        protected bool saveRowToFile(string connectionString, string row)
        {
            try
            {
                StreamWriter file = _streamWriterMod(connectionString);
                file.WriteLine(row);
                file.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public enum enConvertLineToObjetTypes { User, Client, UsersLog, ClientsTransferBalancesLog, Currency }
    }
}