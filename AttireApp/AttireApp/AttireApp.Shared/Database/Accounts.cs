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
        public bool is_unique_email(string hashEmail)
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
        public bool is_unique_user(string username)
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



        //All the functions below that Update the user do not update the database yet.


        //updates the DB with a new email for the specified user
        //returns true if the email is unique and false if it is already in the db
        public bool update_email(User curUser, string newEmail)
        {
            string newEmailHash = HashEmail(newEmail);
            List<User> users = AttireDB.GetAllUsers();
            foreach (User user in users)
            {
                if(newEmailHash == user.HashEmail)
                {
                    return false;
                }
            }

            curUser.HashEmail = newEmailHash;
            return true;
        }

        //hashes and updates the DB with a new pass for the specified user
        public void update_pass(User user, string newPass )
        {
            user.HashPass = Login.HashPass(newPass);
        }
        
        //updates the specified users prefered unit of temp
        public void update_temp(User user, int tempUnit)
        {
            user.TempUnit = tempUnit;
        }

        //updates the db with the specified users new location
        //will need to update the historic weather for that user as well 
        public void update_location(User user, string newLocation)
        {
            user.Location = newLocation;
        }

        //updates the specified users temp to warmth index preferences through a 2D array
        public void update_preferences(User user, int warmthPref)
        {
            user.WarmthPref = warmthPref;
        }
    }
}
