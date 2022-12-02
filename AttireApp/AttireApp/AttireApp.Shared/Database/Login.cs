using System.Collections.Generic;
using System.Text;
using AttireApp.Database.DBUser;
using System.Security.Cryptography;
using AttireApp.Database;

namespace AttireApp.DataBase
{
    public class Login : User
    {
        
        //main driver funtion for this file. will call all functions below
        //Will return -1 if user isnt in database, 1 if the username and password match, and 0 if the password is incorrect.
        public static int ValidateLogin(string username, string password)
        {
            User curUser = FindUser(username);
            if(curUser == null)
            {
                System.Diagnostics.Debug.WriteLine("User Not Found In Database");
                return -1;
            }

            string Hpass = HashPass(password);
            System.Diagnostics.Debug.WriteLine("user pass = " + curUser.HashPass);
            System.Diagnostics.Debug.WriteLine("check pass = " + Hpass);


            if (Hpass == curUser.HashPass)
            {
                System.Diagnostics.Debug.WriteLine("Password correct. Access Granted");
                return 1;
            }
            System.Diagnostics.Debug.WriteLine("Incorrect password");
            return 0;
        }

        //searches DB to see if the user exists, returns the user object if it does exist. Otherwise, returns NULL
        //the user object will have all the attributes listed in the database, they can be accesed by "user.FirstName" (if your User object is named user)
        public static User FindUser(string username)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username)) 
            {
                return null;
            }
            List<User> users = new List<User>();
            users = AttireDB.GetAllUsers();

            foreach (User user in users)
            {
                if (user.UserName.ToUpper() == username.ToUpper())
                {
                    return user;
                }
            }
            return null;
        }

        //hashes input password to use in validate login and set pass(user class)

        public static new string HashPass(string password) 
        {
            using (SHA256 mySHA = SHA256.Create())
            {
                byte[] pass = Encoding.UTF8.GetBytes(password);
                string hashPass = Encoding.UTF8.GetString(mySHA.ComputeHash(pass));

                return hashPass;
            }
        }

    }
}