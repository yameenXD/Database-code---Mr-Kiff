using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DBase_Form_App_6
{
    internal class DatabaseConnect
    {
        // Database Connect
        // Must run in Nuget Package Manager
        // PM> Install-Package system.Data.OleDb
        public static DataSet dataConnect(DataSet ds, string SQL)
        {
            // This works with the Access Database being in the debug/net6.0 folder (or similar)'
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=WorldCities.accdb");
            try
            {
                con.Open();

                MessageBox.Show("Connected!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!");
            }
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(SQL, con);

                dataAdapter.Fill(ds, "Population");
                MessageBox.Show("Dataset Connected!");
                return ds;
                //foreach (DataRow pRow in Artists.Tables["Artists"].Rows)
                //{
                //    Console.WriteLine(pRow["artists"]);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dataset Failed!");

                return ds;
            }
            con.Close();
        }
        public static void FireSQL(string SQL)
        {
            // This works with the Access Database being in the debug/net6.0 folder (or similar)'
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source = WorldCities.accdb");
            try
            {
                con.Open();

                MessageBox.Show("Connected!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!");
            }
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = SQL;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed!");
            }
        }
    }
}
