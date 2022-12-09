using AttireApp.Database;
using AttireApp.Database.DBUser;
using System.Collections.Generic;

namespace AttireApp.DataBase
{
    public class Accounts : Login
    {   

        //exact same functionality as hash_pass() but operates on an email
        public static new string HashEmail(string email)
        {
            string Hashmail = Login.HashPass(email);
            return Hashmail;
        }

        //searches DB to see if email exists already
        public static bool IsUniqueEmail(string hashEmail)
        {
            List<User> users = AttireDB.GetAllUsers();
            foreach (User user in users) 
            {

                if(hashEmail == user.HashEmail)
                {
                    return false;
                }
            }

            return true;
        }

        //searches DB to see if username exists already
        public static bool IsUniqueUser(string username)
        {
            List<User> users = AttireDB.GetAllUsers();
            foreach (User user in users)
            {
                if (username == user.UserName)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
