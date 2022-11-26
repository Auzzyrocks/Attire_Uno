using System;
using System.IO;

namespace AttireApp.Database
{
    public static class Constants
    {
        public const string DatabaseFilename = "AttireData.sqlite";
    
       public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
        public const string datasrc = "Data Source=";
        public static string DatabasePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DatabaseFilename);

        }
}