using Lab.Bank.Db;
using Lab.Bank.Screens.ManageUsers;

namespace Lab.Bank.Controllers
{
    internal class ManageUsersController : FileDbContext
    {
        private static User _getEmptyUserObject() => new User("", "", "", "", "", "", 0);
        private void _swapUsers(User userToUpdate, User newUser)
        {
            userToUpdate.FirstName = newUser.FirstName;
            userToUpdate.LastName = newUser.LastName;
            userToUpdate.Email = newUser.Email;
            userToUpdate.Phone = newUser.Phone;
            userToUpdate.UserName = newUser.UserName;
            userToUpdate.Password = newUser.Password;
            userToUpdate.Permissions = newUser.Permissions;
        }

        public List<Object> Get() => convertFileDataToList(usersDbConnectionString, fileRowSeparator, enConvertLineToObjetTypes.User);
        public User Get(string userName)
        {
            List<object> Users = Get();

            foreach (User user in Users)
            {
                if (user.UserName == userName)
                    return user;
            }
            return _getEmptyUserObject();
        }
        public bool IsUserExsist(string userName) => Get(userName).UserName == "" ? false : true;
        public void Post(User user) => saveRowToFile(usersDbConnectionString, convertUserObjectToRowStringForSaving(user, fileRowSeparator));
        public void Delete(string userName)
        {
            List<object> usersList = Get();
            List<object> usersListAfterDeleteUser = new List<object>();

            foreach (User user in usersList)
                if (user.UserName != userName)
                    usersListAfterDeleteUser.Add(user);

            saveListToFile(usersListAfterDeleteUser, usersDbConnectionString, false);
        }
        public void Update(User user)
        {
            List<object> usersList = Get();
            List<object> usersListAfterUpdateUser = new List<object>();
            User userToUpdate = Get(user.UserName);

            foreach (User u in usersList)
            {
                if (u.UserName == userToUpdate.UserName)
                    _swapUsers(u, user);

                usersListAfterUpdateUser.Add(u);
            }
            saveListToFile(usersListAfterUpdateUser, usersDbConnectionString, false);
        }
    }
}
