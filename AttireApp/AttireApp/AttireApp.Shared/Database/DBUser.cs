using System;
using AttireApp.DataBase;

namespace AttireApp.Database.DBUser
{
    //[Table("User")]
    public class User
    {
        //properties of a user object
        //[PrimaryKey, AutoIncrement, Column("userID"), Unique]
        public int UserID { get; set; }

        //[MaxLength(25), Unique, Column("userName")]
        public string UserName { get; set; }

        //[MaxLength(64), Column("hashEmail")]
        public string HashPass { get; set; }

        //[MaxLength(64), Unique, Column("hashEmail")]
        public string HashEmail { get; set; }

        //[MaxLength(20), Column("firstName")]
        public string FirstName { get; set; }

        //[MaxLength(20), Column("lastName")]
        public string LastName { get; set; }

        //[MaxLength(20), Column("Location")]
        public string Location { get; set; }

        //[MaxLength(20), Column("tempUnit")]
        public int TempUnit { get; set; }

        public int WarmthPref { get; set; }

        public static User CurrentUser;
        //default constructor (used in creating db)
        public User() { }

        //this constructor is used to create a new user object, the user object will then be passed to the AddNewUser() function of AttireDB
        //in order to add the user to the database.
        //the UserID will be set automatically once added to the database. once the user is then pulled from the database, the userID will be accessble.
        public User(string username, string password, string email, string firstname, string lastname, string location, int tempunit, int warmthpref)
        {
            if(Accounts.IsUniqueEmail(Accounts.HashEmail(email)) == false || Accounts.IsUniqueUser(username) == false)
            {
                //returns without assigning anything when email or username arent unique 
                System.Diagnostics.Debug.WriteLine("Username or Email is not unique. User not added to database");
                return;
            }
            this.UserName = username;
            this.HashPass = Login.HashPass(password);
            this.HashEmail = Accounts.HashEmail(email);
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Location = location;
            this.TempUnit = tempunit;
            this.WarmthPref = warmthpref;
            AttireDB data = new();
            data.AddNewUser(this);
            System.Diagnostics.Debug.WriteLine("User successfully added to database");
            


        }



       
        //setters for user object. these will call db for info and set it to the class. (will be used in constructor)
        //these will also be used for updating the user's names and preferences.
        public bool UpdateUsername(string NewUserName)
        {
            //add uniqueness checks
            this.UserName = NewUserName;
            return true;
        }

        //not used in production
        //public bool SetFirstName(string NewName)
        //{
        //    this.FirstName = NewName;
        //    return true;
        //}
        //public bool SetLastName(string NewName)
        //{
        //    this.LastName = NewName;
        //    return true;
        //}
        public int UpdatePassword(string currentpass, string newpass, string confirmpass)
        {
            //if current password field does not match the current password in the datbase, return 0
            if (Login.HashPass(currentpass) != CurrentUser.HashPass)
            {
                System.Diagnostics.Debug.WriteLine("The password you entered does not match your current password");
                return 0;
            }
            if (string.IsNullOrEmpty(newpass) || string.IsNullOrEmpty(confirmpass) || string.IsNullOrWhiteSpace(newpass) || string.IsNullOrWhiteSpace(confirmpass))
            {
                System.Diagnostics.Debug.WriteLine("The new password cannot be left blank");
                return -2;
            }
            //if confirm password field is incorrect, return -1
            if (newpass != confirmpass)
            {
                System.Diagnostics.Debug.WriteLine("The new password and confirm password fields do not match");
                return -1;
            }
            //update password and return 1
            AttireDB.UpdateUserPassword(newpass);
            System.Diagnostics.Debug.WriteLine("Password updated");

            return 1;
        }


        public void UpdateLocation(string newloc) {
            //add error handling for this guy
            this.Location = newloc;
            AttireDB.UpdateUserLocation(newloc);

        }


        public void UpdateTempUnit(int TempUnit) 
        { 
            this.TempUnit = TempUnit;
            AttireDB.UpdateUserTempUnit(TempUnit);  

        }

        // BRANDON added this, so changes can be made via settings page
        public void UpdateWarmthPref(int WarmthPref)
        {
            this.WarmthPref = WarmthPref;
            AttireDB.UpdateUserWarmthPref(WarmthPref);
        }

        //getters for user specific weather data from "user weather" and "historic weather" tables
        //these might split into more than two functions
        //public void UserWeatherHistory(string currentWeather) 
        //{
        //    //string w = currentWeather;
        //    return; 
        //}
        //set both firstname and lastname with one call
        //public bool UpdateNames(string fName, string lName) 
        //{
        //    this.FirstName = fName;
        //    this.LastName = lName;
        //    return true; 
        //}
    }
}