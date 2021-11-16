using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CSHARP_DataManipulation_x02
{
    class DataManager
    {
        string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Jeruzael\\Documents\\DataManagement_x01.mdb;Jet OLEDB:Database Password=123";
        string queryStr;

        public DataManager()
        {           
           
        }

        public void checkConn()
        {
            using (OleDbConnection connectionx = new OleDbConnection(conn))
            {
                OleDbCommand com = new OleDbCommand(queryStr, connectionx);

                try
                {
                    connectionx.Open();
                    MessageBox.Show("connected");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void addValue(string queryx)
        {
            queryStr = "INSERT INTO Kirat (Firstname)"+"VALUES ('"+queryStr+"')";
            using (OleDbConnection connectionx = new OleDbConnection(conn))
            {
                OleDbCommand com = new OleDbCommand(queryStr, connectionx);

                try
                {
                    connectionx.Open();
                    com.ExecuteNonQuery();   
                    MessageBox.Show("added");
                    connectionx.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

        }
    }
}
