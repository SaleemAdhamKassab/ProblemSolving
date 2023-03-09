using Lab.Bank.Db;
using Lab.Bank.Screens.ManageUsers;
using Lab.Class.Bank;

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
        protected string convertUserObjectToRowStringForSaving(User user,string rowSeparator) =>
                user.FirstName + rowSeparator +
                user.LastName + rowSeparator +
                user.Email + rowSeparator +
                user.Phone + rowSeparator +
                user.UserName + rowSeparator +
                user.Password + rowSeparator +
                user.Permissions;
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
                                  splitedLineData[5],
                                  int.Parse(splitedLineData[6]));
        }
        
  





       
        //protected static void printMenueOptions(string[] menuOptions)
        //{
        //    for (int i = 0; i < menuOptions.Length; i++)
        //        Console.WriteLine("[{0}] " + menuOptions[i], i + 1);
        //}
        
       
        //protected static string[] mainMenueOptions()
        //{
        //    string[] mainMenueOptions = new string[8];
        //    mainMenueOptions[0] = "Show Clients List";
        //    mainMenueOptions[1] = "Add New Client";
        //    mainMenueOptions[2] = "Delete Client";
        //    mainMenueOptions[3] = "Update Client Info";
        //    mainMenueOptions[4] = "Find Client";
        //    mainMenueOptions[5] = "Transactions";
        //    mainMenueOptions[6] = "Manage Users";
        //    mainMenueOptions[7] = "Logout";

        //    return mainMenueOptions;
        //}
 
   

        //public static User findUser(string userName)
        //{
        //    User user = _getEmptyUserObject();

        //    List<object> usersList = FileDbContext.convertFileDataToList(FileDbContext.UsersDbConnectionString,
        //                                                                   FileDbContext.rowSeparator,
        //                                                                   FileDbContext.enConvertLineToObjetTypes.User);
        //    foreach (User userLine in usersList)
        //        if (userLine.UserName == userName)
        //        {
        //            user = userLine;
        //            return user;
        //        }

        //    return user;
        //}
        //public static bool IsClientExist(string accountNumber) => findClient(accountNumber).AccountNumber != "" ? false : true;
        //public static bool IsUserExist(string userName) => findUser(userName).UserName == userName ? true : false;
    

      
        //public static int userMenuChoose(int to)
        //{
        //    Console.Write("Choose What do you want to do [1 - {0}]: ", to);
        //    int userChoose = int.Parse(Console.ReadLine());

        //    while (userChoose < 1 || userChoose > to)
        //    {
        //        Console.Write("Invalid Menu Number, Please choose between 1 and {0}: ", to);
        //        userChoose = int.Parse(Console.ReadLine());
        //    }

        //    return userChoose;
        //}
    }
}