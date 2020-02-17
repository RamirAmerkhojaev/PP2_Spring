using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBaza
{
    public class Dosje
    {
        public DataSet ds;
        SQLiteConnection soed;
        SQLiteCommand prikaz;
        string path;
        int table_num;
        public Dosje()
        {
            path = @"..\..\..\Bratki.db";
            table_num = 0;
            soed = new SQLiteConnection("Data Source =" + path);
        }

        public void Vypolnyaj(string ukaz)
        {
            soed.Open();
            prikaz = new SQLiteCommand(ukaz, soed);
            prikaz.ExecuteNonQuery();
            soed.Close();
        }

        public DataTable DaiInfu()
        {
            soed.Open();
            string ukaz = "select * from Bratki";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(ukaz, soed);
            adapter.Fill(ds);
            soed.Close();
            return ds.Tables[0];
        } 
    }
}
