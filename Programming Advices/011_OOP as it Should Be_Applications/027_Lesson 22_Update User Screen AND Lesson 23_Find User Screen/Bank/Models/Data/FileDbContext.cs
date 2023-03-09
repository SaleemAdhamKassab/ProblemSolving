using Lab.Bank.Screens.ManageUsers;
using Lab.Bank.Shared;
using Lab.Class.Bank;

namespace Lab.Bank.Db
{
    public class FileDbContext : BackEndFunctions
    {
        protected readonly string clientsDbConnectionString = "ClientsDB.txt";
        protected readonly string usersDbConnectionString = "UsersDB.txt";
        protected static readonly string fileRowSeparator = "#//#";
        public enum enConvertLineToObjetTypes { User, Client }
        private List<object> _convertFileToList(string connectionString, string seperator, enConvertLineToObjetTypes objType)
        {
            List<object> list = new List<object>();

            if (objType == enConvertLineToObjetTypes.Client)
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToClientObject(lineData, seperator));
            }
            else
            {
                foreach (string lineData in File.ReadLines(connectionString))
                    list.Add(convertLineToUserObject(lineData, seperator));
            }

            return list;
        }
        private StreamWriter _streamWriterMod(string connectionString, bool isAppend = true) =>
            isAppend ? new StreamWriter(connectionString, append: true) :
            new StreamWriter(connectionString);

        protected List<object> convertFileDataToList(string connectionString, string seperator, enConvertLineToObjetTypes objType) =>
            _convertFileToList(connectionString, seperator, objType);
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
    }
}