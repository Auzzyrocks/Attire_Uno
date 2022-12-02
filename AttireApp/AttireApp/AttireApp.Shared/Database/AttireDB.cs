﻿using AttireApp.Database.DBUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;

namespace AttireApp.Database
{
    public class AttireDB
    {
        public string StatusMessage { get; private set; }
        public SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Could not obtain a connection to the database. Error {0}", ex.Message);
            }
            return sqlite_conn;
        }

        public void InitializeDB() 
        {
            using var conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            AttireDB data = new();
            if(conn == null)
            {
                //creates a database file
                SQLiteConnection.CreateFile(Constants.DatabasePath);
                conn.Open();
                //creates the default table (user table)
                data.CreateUserTable(conn);
            }
            
            conn.Open();
            data.CreateUserTable(conn);
        }
        public void DropTable(string tablename)
        {
            using var conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            conn.Open();
            using var cmd = new SQLiteCommand(conn);
            cmd.CommandText = "DROP TABLE IF EXISTS " + tablename;
            cmd.ExecuteNonQuery();
        }
        private void CreateUserTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS User (id INTEGER PRIMARY KEY, username TEXT, hashpass TEXT, hashemail TEXT, firstname TEXT, lastname TEXT, location TEXT, tempunit INTEGER);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }
        private void CreateTable(SQLiteConnection conn, string tablename)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE " + tablename + "(id INTEGER PRIMARY KEY ,  INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }
        
        
        //TODO: add functionality to check if user already exists.

        public bool AddNewUser(User user)
        {
            AttireDB data = new();
            using var conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            conn.Open();
            var sqlcommand = new SQLiteCommand(conn);

            sqlcommand.CommandText = "INSERT INTO User(username, hashpass, hashemail, firstname, lastname, location, tempunit) VALUES(@username, @hashpass, @hashemail, @firstname, @lastname, @location, @tempunit)";
            sqlcommand.Parameters.AddWithValue("@username", user.UserName);
            sqlcommand.Parameters.AddWithValue("@hashpass", user.HashPass);
            sqlcommand.Parameters.AddWithValue("@hashemail", user.HashEmail);
            sqlcommand.Parameters.AddWithValue("@firstname", user.FirstName);
            sqlcommand.Parameters.AddWithValue("@lastname", user.LastName);
            sqlcommand.Parameters.AddWithValue("@location", user.Location);
            sqlcommand.Parameters.AddWithValue("@tempunit", user.TempUnit);
            sqlcommand.Prepare();
            sqlcommand.ExecuteNonQuery();


            return true;
        }

        //adds a user with only username password and email fields. Everything else is NULL
        public bool AddTestUser(string username, string pass, string email) 
        {
            AttireDB data = new();
            using var conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            conn.Open();
            var sqlcommand = new SQLiteCommand(conn);

            sqlcommand.CommandText = "INSERT INTO User(username, password, email) VALUES(@username, @password, @email)";
            sqlcommand.Parameters.AddWithValue("@username", username);
            sqlcommand.Parameters.AddWithValue("@password", pass);
            sqlcommand.Parameters.AddWithValue("@email", email);
            sqlcommand.Prepare();
            sqlcommand.ExecuteNonQuery();


            return true; 
        }
        
        //TODO
        public static bool DeleteUser(string username) { return false; }

        //Returns a list of all users in the database (as objects)
        public static List<User> GetAllUsers()
        {
            var conn = new SQLiteConnection("Data Source=" + Constants.DatabasePath);
            conn.Open();
            List<User> usrList = new();
            string stm = "SELECT * FROM User";
            var cmd = new SQLiteCommand(stm, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                User user = new();
                user.UserID = rdr.GetInt32(0);
                user.UserName = rdr.GetString(1) ;
                user.HashPass = rdr.GetString(2);
                user.HashEmail = rdr.GetString(3);
                user.FirstName = rdr.GetString(4);
                user.LastName = rdr.GetString(5);
                user.Location = rdr.GetString(6);
                user.TempUnit = rdr.GetInt32(7);
                usrList.Add(user);
                //users.WarmthPref = rdr.GetInt32(8);
         //     System.Diagnostics.Debug.WriteLine($"ID: {rdr.GetInt32(0)} Username: {rdr.GetString(1)} Password: {rdr.GetString(2)} Email: {rdr.GetString(3)} FirstName: {rdr.GetString(4)}");
            }
            
            //newList.Add()
            return usrList;
        }
    }
}



        /*
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
            */
