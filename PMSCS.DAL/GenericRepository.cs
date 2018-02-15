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
        private String dbParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\StoppingDB.mdb;Persist Security Info=False";
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
        
    }
}
