using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AttireApp.Database.DBUser
{
    [Table("User")]
    public class User
    {
        //properties of a user object
        [PrimaryKey, AutoIncrement, Column("userID"), Unique]
        public int userID { get; set; }

        [MaxLength(25), Unique, Column("userName")]
        public string UserName { get; set; }

        [MaxLength(64), Column("hashEmail")]
        public byte[] HashPass { get; set;}

        [MaxLength(64), Unique, Column("hashEmail")]
        public string hashEmail { get; set; }
        
        [MaxLength(20), Column("firstName")]
        public string firstName { get; set; }

        [MaxLength(20), Column("lastName")]
        public string lastName { get; set; }
        
        [MaxLength(20), Column("Location")]
        public int location { get;  set; }

        [MaxLength(20), Column("tempUnit")]
        public bool tempUnit { get; set; }

        //default constructor (used in creating db)
        public User() { }
        public User(string UserName, string PassWord)
        {
            using (SHA256 mySHA = SHA256.Create())
            {
                byte[] pass = Encoding.UTF8.GetBytes(PassWord);
                this.UserName = UserName;
                this.HashPass = mySHA.ComputeHash(pass);
            }
                
                

        }

        //getters for user object properties
        public int get_UserID()
        {
            return userID;
        }
    

		public string get_first_name(){
            return firstName;
        }

		public string get_last_name(){
            return lastName;
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
        public string set_username(int userID){return "userID";}
		public string set_first_name(int userID){return "userID";}
		public string set_last_name(int userID){return "string";}
		
        public int set_location(){
            while(true){
                string k = "1"; //= Console.ReadLine();
                if(k == "0"){
                    location = 0;
                    Console.WriteLine("Location updated to " + location);
                    return 1;
                }else if(k == "1"){
                    location = 1; 
                    Console.WriteLine("Location updated to " + location);
                    return 1;
                }else if(k == "2"){
                    location = 2;
                    Console.WriteLine("Location updated to " + location);
                    return 1;
                }else if(k == "3"){
                    location = 3;    
                    Console.WriteLine("Location updated to " + location);
                    return 1;
                }
                //location not found
                Console.WriteLine("Location not found :(");
                Console.WriteLine("Enter new location (0-3)");
        
            }
        }

		public string set_temp_unit(int userID){return "string";}
        
        //getters for user specific weather data from "user weather" and "historic weather" tables
        //these might split into more than two functions
        public void get_user_weather_history(string currentWeather){return;}
		public void get_historic_weather(string currentDate){return;}

        //update account info within the class and update database
        public void update_temp_unit(bool tempUnit){return;}
        public void update_location(string newLocation){return;}
        public void update_name(string firstName, string lastName){return;}
        public void add_user_weather_history(string weather){return;}
        

    }
}