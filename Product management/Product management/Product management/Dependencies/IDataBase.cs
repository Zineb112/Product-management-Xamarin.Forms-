using System;
using System.Collections.Generic;
using System.Text;

namespace Product_management.Dependencies
{
    interface IDataBase
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
