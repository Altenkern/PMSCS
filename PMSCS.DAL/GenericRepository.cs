using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSCS.DAL
{
    public class GenericRepository : IGenericRepository
    {
        private OleDbConnection dbcon;
        private OleDbCommand dbCmd = new OleDbCommand();
        //parameter from mdsaputra.udl
        private String dbParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projects\C#\PMSCS\StoppingDB.mdb;Persist Security Info=False";
        public GenericRepository()
        {
            dbcon = new OleDbConnection(dbParam);
        }
        public GenericRepository(string databeseConnectionString):base()
        {
            dbParam = databeseConnectionString;
        }
        
        public bool Insert(string insertValue)
        {
            dbcon.Open();
            dbCmd.Connection = dbcon;
            dbCmd.CommandText = insertValue;
            int temp = dbCmd.ExecuteNonQuery();
            dbcon.Close();
            if (temp > 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public object[,] Select(string from1, params string[][] data)
        {

            dbcon.Open();
            dbCmd.Connection = dbcon;
            string command = "SELECT ";
            if (data.Length != 0)
            {
                for (int i = 0; i < data[0].Length; i++)
                {
                    command += data[0][i];
                    if (i < data[0].Length - 1)
                    {
                        command += ",";
                    }
                    else
                    {
                        command += " ";
                    }
                }
            }
            else
            {
                command += "*";
            }
            command += " WHERE ";
            for (int i = 0; i < data[1].Length; i++)
            {
                command += data[1][i];
                if (i < data[1].Length - 1)
                {
                    command += ",";
                }
                else
                {
                    command += " ";
                }
            }
            command += "from " + from1;
            //sdelat viborky
            return null;
        }
    }
}
