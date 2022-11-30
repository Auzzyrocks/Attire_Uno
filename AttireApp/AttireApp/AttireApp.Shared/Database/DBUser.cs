using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SQLite;

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

        //default constructor (used in creating db)
        public User() { }
        public User(string UserName, string PassWord)
        {
            using SHA256 mySHA = SHA256.Create();
            byte[] pass = Encoding.UTF8.GetBytes(PassWord);
            this.UserName = UserName;
            this.HashPass = mySHA.ComputeHash(pass).ToString();



        }



        /*	public string get_location(){
                if(location == 0){
                    return "Nanaimo";
                }else if(location == 1){
                    return "Vancouver";
                }else if(location == 2){
                    return "Parksville";
                }else if(location == 3){
                    return "Ladysmith";
                }else{
                    return "No location specified";
                }
            }
            */

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


        //decided against these
        //public void add_user_weather_history(string weather) { return; }
        //public void get_historic_weather(string currentDate) { return; }

    }
}