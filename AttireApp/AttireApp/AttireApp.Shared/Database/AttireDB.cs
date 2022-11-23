using Attire.DataBase;
using AttireApp.Database.DBUser;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttireApp.Database
{
    public class AttireDB
    {

        public string StatusMessage { get; private set; }

        public AttireDB()
        {
            
        }


        public SQLiteAsyncConnection DB;
        public async Task InitializeDB()
        {
            if (DB is null) 
            {
                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                await storageFolder.CreateFileAsync("AttireData.db3", Windows.Storage.CreationCollisionOption.ReplaceExisting);
            }
                

            DB = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await DB.CreateTableAsync<DBUser.User>();
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
                result = await DB.InsertAsync(new User { UserName = username, HashPass = Login.hash_pass(password) });
                StatusMessage = string.Format("{0} record(s) added [UserName: {1})", result, username);

            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", username, ex.Message);
            }
        }
    }
}
