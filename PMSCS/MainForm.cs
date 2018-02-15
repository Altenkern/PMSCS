using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMSCS.DAL;

namespace PMSCS
{
    public partial class MainForm : Form
    {
        public IStoppingRepository stoppingRepository ;
        public static List<Stopping> stoppingList = new List<Stopping>();
        public MainForm()
        {
            stoppingRepository = new StoppingRepository();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stoppingDBDataSet.Stoping". При необходимости она может быть перемещена или удалена.
            //this.stopingTableAdapter.Fill(this.stoppingDBDataSet.Stoping);
           // dbcon.Open();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.Count - 1;
            
            for(int i = 0; i<rowCount; i++)
            {
                var insertText= "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime)  values ('" 
                + this.dateTimePicker.Value.ToShortDateString() + "','"
                + this.textBoxMachineNumber.Text + "','"
                + dataGridView.Rows[i].Cells[0].Value.ToString() + "','"
                + dataGridView.Rows[i].Cells[1].Value.ToString()
                + "');";

                var temp = stoppingRepository.Insert(insertText);
                if(i == rowCount - 1)
                {
                     if (temp == true)
                        {

                        MessageBox.Show("Record Successfuly Added");
                    }
                    else
                    {
                    MessageBox.Show("Record Fail to Added");
                    }
                }
            }

            
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string str = dataGridView.Rows[0].Cells[0].Value.ToString();
        //    string str1 = dataGridView.Rows[1].Cells[1].Value.ToString();
        //    string str2 = dataGridView.Rows[2].Cells[1].Value.ToString();
        //    int index = dataGridView.Rows.Count;
        //}
    }
}
