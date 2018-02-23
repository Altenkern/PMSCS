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
        public GenericRepository(string databeseConnectionString) : base()
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
        public string Select(string date, int shift)
        {          
            string SelectCommand = "SELECT MachineNumber, Reason, StoppingTime FROM Stoping WHERE StDate = #"+ 
                date.Replace('.', '/') +
                "# AND Shift = " + 
                shift.ToString();
            dbcon.Open();
            byte andrey = 228;
            var command = new OleDbCommand(SelectCommand, dbcon);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Stopping stopping = new Stopping();
                stopping.MachineNumber = int.Parse(reader[0].ToString());
                stopping.Reason = int.Parse(reader[1].ToString());
                stopping.StoppingTime = int.Parse(reader[2].ToString());

                StaticClass.StoppingsList.Add(stopping);
            }
            dbcon.Close();

            List<Stopping> st = StaticClass.StoppingsList;
            

            return SelectCommand;
        }
        public string SelectStatementGenerator(string date1, int shift1, string date2, int shift2)
        {
            return null;
        }
        public string ReplaceDayAndMonth(string date)
        {
            char[] dateArr = date.ToCharArray();
            char[] mem = new char[2];
            mem[0] = dateArr[0];
            mem[1] = dateArr[1];
            dateArr[0] = dateArr[3];
            dateArr[1] = dateArr[4];
            dateArr[3] = mem[0];
            dateArr[4] = mem[1];
            string dateRep = new string(dateArr);
            return dateRep;
        }
    }
}
