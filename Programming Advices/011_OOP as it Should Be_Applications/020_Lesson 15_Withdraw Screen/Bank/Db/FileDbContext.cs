using Lab.Class.Bank;

namespace Labs.Bank.Db
{
    public static class FileDbContext
    {
        public static readonly string ClientsDbConnectionString = "ClientsDB.txt";
        public static readonly string FileRowSeparator = "#//#";
        private static StreamWriter streamWriterMod(bool isAppend = true) =>
            isAppend ? new StreamWriter(ClientsDbConnectionString, append: true) :
            new StreamWriter(ClientsDbConnectionString);

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
        public static List<object> convertFileDataToList(string connectionString, string seperator)
        {
            List<object> list = new List<object>();

            foreach (string lineData in File.ReadLines(connectionString))
                list.Add(BankClient.convertLineToClientObject(lineData, seperator));

            return list;
        }
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