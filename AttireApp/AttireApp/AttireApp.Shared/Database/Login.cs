using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attire.DataBase
{
    public class login
    {   
        //main driver funtion for this file. will call all functions below
        public int validate_login(string username, string password){return 0;}

        //searches DB to see if the user exists
        public bool find_user(string username){return true;}

        //hashes input password to use in compare_pass
        public string hash_pass(string password){return "s";}

        //compares the user input username and password(post-hash) in order to validate a login
        public bool compare_pass(string username, string hashedPass){return true;}

    }
}