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
using PMSCS.DAL;

namespace PMSCS
{
    public partial class MainForm : Form
    {
        public IStoppingRepository stoppingRepository ;
        public MainForm()
        {
            stoppingRepository = new StoppingRepository();
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
           var insertText= "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime)  values ('" 
                + this.dateTimePicker.Value.ToShortDateString() + "','"
                + this.textBoxMachineNumber.Text + "','"
                + this.comboBoxReason.Text+ "','"
                + this.textBoxStoppingTime.Text
                + "');";

            var temp = stoppingRepository.Insert(insertText);
            if (temp ==true)
            {
               
                MessageBox.Show("Record Successfuly Added");
            }
            else
            {
                MessageBox.Show("Record Fail to Added");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
