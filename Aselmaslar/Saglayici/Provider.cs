using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
namespace Aselmaslar.Saglayici
{
    public class DBCon
    {
        public static SQLiteConnection BaglantiYap()
        {
            return new SQLiteConnection(@"Data Source=DB.db");
        }
        public static SQLiteCommand KomutOlustur(string cmd)
        {
            return string.IsNullOrEmpty(cmd) ? null : new SQLiteCommand(cmd, BaglantiYap());
        }
    }
}
