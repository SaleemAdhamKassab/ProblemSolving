using Lab.Class.Bank;

namespace Labs.Bank.Db
{
    public static class FileDbContext
    {
        public static readonly string ConnectionString = "ClientsDB.txt";
        public static bool saveListToFile(List<object> objList)
        {
            try
            {
                StreamWriter file = new StreamWriter(ConnectionString);

                if (objList.Count == 0)
                {
                    file.Write("");
                    file.Close();
                    return true;
                }

                foreach (object obj in objList)
                    file.WriteLine(obj);

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
                StreamWriter file = new StreamWriter(ConnectionString, append: true);
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
    }
}
