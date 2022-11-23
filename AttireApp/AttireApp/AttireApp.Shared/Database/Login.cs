using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using AttireApp.Database.DBUser;
using System.Security.Cryptography;

namespace Attire.DataBase
{
    public class Login : User
    {
        
        //main driver funtion for this file. will call all functions below
        public static int ValidateLogin(string username, string password){return 0;}

        //searches DB to see if the user exists
        public bool Find_User(string username){return true;}

        //hashes input password to use in compare_pass and set pass

        public static byte[] hash_pass(string password) 
        {
            using (SHA256 mySHA = SHA256.Create())
            {
                byte[] pass = Encoding.UTF8.GetBytes(password);
                byte[] hashPass = mySHA.ComputeHash(pass);

                return hashPass;
            }
        }

        //compares the user input username and password(post-hash) in order to validate a login
        public bool compare_pass(string username, string hashedPass){return true;}

    }
}