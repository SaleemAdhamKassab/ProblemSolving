using Lab.Bank.Screens.ManageUsers;
using Lab.Class.Bank;

namespace Lab.Bank.Db
{
    public static class FileDbContext
    {
        public static readonly string ClientsDbConnectionString = "ClientsDB.txt";
        public static readonly string UsersDbConnectionString = "UsersDB.txt";
        public static readonly string FileRowSeparator = "#//#";
        public enum enConvertLineToObjetTypes { User, Client }
        private static StreamWriter streamWriterMod(bool isAppend = true) =>
            isAppend ? new StreamWriter(ClientsDbConnectionString, append: true) :
            new StreamWriter(ClientsDbConnectionString);
        private static BankClient _convertLineToClientObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new BankClient(splitedLineData[0],
                                  splitedLineData[1],
                                  splitedLineData[2],
                                  splitedLineData[3],
                                  splitedLineData[4],
                                  splitedLineData[5],
                                  double.Parse(splitedLineData[6]));
        }
        private static User _convertLineToUserObject(string lineData, string seperator)
        {
            string[] splitedLineData = lineData.Split(seperator);

            return new User(splitedLineData[0],
                                  splitedLineData[1],
                                  splitedLineData[2],
                                  splitedLineData[3],
                                  splitedLineData[4],
                                  splitedLineData[5],
                                  int.Parse(splitedLineData[6]));
        }

        public static bool saveListToFile(List<object> objList, bool isAppend = true)
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
                    file = streamWriterMod();
                else
                    file = streamWriterMod(false);

                foreach (BankClient obj in objList)
                    file.WriteLine(convertClientObjectToRowStringForSaving(obj));

                file.Close();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public static bool saveRowToFile(string row)
        {
            try
            {
                StreamWriter file = streamWriterMod();
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
        private static List<object> _convertFileToList(string connectionString, string seperator, enConvertLineToObjetTypes objType)
        {
            List<object> list = new List<object>();

            if (objType == enConvertLineToObjetTypes.Client)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(_convertLineToClientObject(lineData, seperator));
            }
            else
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(_convertLineToUserObject(lineData, seperator));
            }

            return list;
        }

        public static List<object> convertFileDataToList(string connectionString, string seperator,enConvertLineToObjetTypes objType) =>
            _convertFileToList(connectionString, seperator,objType);

        public static string convertClientObjectToRowStringForSaving(BankClient client) =>
                client.AccountNumber + FileRowSeparator +
                client.PinCode + FileRowSeparator +
                client.FirstName + FileRowSeparator +
                client.LastName + FileRowSeparator +
                client.Email + FileRowSeparator +
                client.Phone + FileRowSeparator +
                client.AccountBalance;
    }
}