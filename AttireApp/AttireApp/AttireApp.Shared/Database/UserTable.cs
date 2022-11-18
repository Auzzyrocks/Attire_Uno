﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attire.Database
{
    public class AttireDB
    {
        SQLiteAsyncConnection DB;

        public AttireDB()
        {
        }

        async Task Init()
        {
            if (DB is not null)
                return;

            DB = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await DB.CreateTableAsync<DBUser.User>();
        }
    }
}
