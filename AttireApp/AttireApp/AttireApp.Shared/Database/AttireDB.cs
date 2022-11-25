using AttireApp.Database.DBUser;
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttireApp.Database
{
    public class AttireDB
    {

        public string StatusMessage { get; private set; }

        public AttireDB()
        {
            
        }

        

        public SQLiteConnection DB;
        public async Task InitializeDB()
        {
            if (DB is null) 
            {
                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                await storageFolder.CreateFileAsync("AttireData.db3", Windows.Storage.CreationCollisionOption.ReplaceExisting);
                
            }
                

            DB = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
           DB.CreateTable<User>();
        }

        public async Task AddNewUser(string username, string password)
        {
            int result;
            try {
                await InitializeDB();
                if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
                {
                    throw new Exception("Invalid Username");
                }
                else if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("Password Cannot be Empty");
                }
                //byte[] bytePass =  Encoding.UTF8.GetBytes(password);
                result = DB.Insert(new User(username, password));
                StatusMessage = string.Format("{0} record(s) added [UserName: {1})", result, username);

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", username, ex.Message);
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                await InitializeDB();
                return DB.Table<User>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }
            return new List<User>();
        }
    }
}
