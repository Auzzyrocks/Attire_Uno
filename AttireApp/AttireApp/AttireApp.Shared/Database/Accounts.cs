using Attire.DataBase;
using AttireApp.Database.DBUser;

namespace AttireApp.DataBase
{
    public class Accounts : Login
    {   
        //main driving function of this file, validates input and creates a user if there is no problem.
        //will return an int to represent where the problem lies (e.g. returned -1 means email is not unique)
        //also uses hash_pass from login.cs
        public int AddAccount(string username, string password, string email, int location){return 0;}
        
        //exact same functionality as hash_pass() but operates on an email
        public static new string HashEmail(string email)
        {
            string Hashmail = Login.HashPass(email);
            return Hashmail;
        }

        //searches DB to see if email exists already
        public bool is_unique_email(string hashEmail){return true;}

        //searches DB to see if username exists already
        public bool is_unique_user(string username){return true;}

        //updates the DB with a new email for the specified user
        //returns true if the email is unique and false if it is already in the db
        public bool update_email(User user, string newEmail){return true;}

        //hashes and updates the DB with a new pass for the specified user
        public void update_pass(User user, string newPass ){return;}
        
        //updates the specified users prefered unit of temp
        public void update_temp(User user, bool tempUnit){return;}

        //updates the db with the specified users new location
        //will need to update the historic weather for that user as well 
        public void update_location(User user, string newLocation){return;}

        //updates the specified users temp to warmth index preferences through a 2D array
        public void update_preferences(int[,] preferences, int userID){return;}
    }
}
