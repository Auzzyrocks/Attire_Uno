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


        }



       
        //setters for user object. these will call db for info and set it to the class. (will be used in constructor)
        //these will also be used for updating the user's names and preferences.
        public bool SetUsername(string NewUserName)
        {
            //add uniqueness checks
            this.UserName = NewUserName;
            return true;
        }
        public bool SetFirstName(string NewName)
        {
            this.FirstName = NewName;
            return true;
        }
        public bool SetLastName(string NewName)
        {
            this.LastName = NewName;
            return true;
        }

        public bool SetLocation(string loc) {
            //add error handling for this guy
            this.Location = loc;

            Console.WriteLine("Location not found :(");
            Console.WriteLine("Enter new location (0-3)");
            return true;

        }


        public bool SetTempUnit(int TempUnit) 
        { 
            this.TempUnit = TempUnit;
            return true; 
        }

        // BRANDON added this, so changes can be made via settings page
        public bool SetWarmthPref(int WarmthPref)
        {
            this.WarmthPref = WarmthPref;
            return true;
        }

        //getters for user specific weather data from "user weather" and "historic weather" tables
        //these might split into more than two functions
        public void UserWeatherHistory(string currentWeather) 
        {
            //string w = currentWeather;
            return; 
        }
        //set both firstname and lastname with one call
        public bool UpdateNames(string fName, string lName) 
        {
            this.FirstName = fName;
            this.LastName = lName;
            return true; 
        }
    }
}