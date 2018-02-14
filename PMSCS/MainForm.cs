using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace PMSCS
{
    public partial class MainForm : Form
    {
        private OleDbConnection dbcon;
        private OleDbCommand dbCmd = new OleDbCommand();
        //parameter from mdsaputra.udl
        private String dbParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projects\C#\PMSCS\StoppingDB.mdb;Persist Security Info=False";

        public MainForm()
        {
            dbcon = new OleDbConnection(dbParam);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stoppingDBDataSet.Stoping". При необходимости она может быть перемещена или удалена.
            this.stopingTableAdapter.Fill(this.stoppingDBDataSet.Stoping);
           // dbcon.Open();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dbcon.Open();
            dbCmd.Connection = dbcon;
            dbCmd.CommandText = "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime)  values ('" 
                + this.dateTimePicker.Value.ToShortDateString() + "','"
                + this.textBoxMachineNumber.Text + "','"
                + this.comboBoxReason.Text+ "','"
                + this.textBoxStoppingTime.Text
                + "');";
            int temp = dbCmd.ExecuteNonQuery();
            if (temp > 0)
            {
               
                MessageBox.Show("Record Successfuly Added");
            }
            else
            {
                MessageBox.Show("Record Fail to Added");
            }
            dbcon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
