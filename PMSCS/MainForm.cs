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
        public GenericRepository stoppingRepository ;
        
        public MainForm()
        {
            stoppingRepository = new GenericRepository();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stoppingDBDataSet.Stoping". При необходимости она может быть перемещена или удалена.
            //this.stopingTableAdapter.Fill(this.stoppingDBDataSet.Stoping);
            // dbcon.Open();
            DebugForm deb = new DebugForm();
            deb.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView.Rows.Count - 1;

            string shift;

            if (checkBoxShift.Checked == true)
            {
                shift = "2";
            }
            else
            {
                shift = "1";
            }

            for (int i = 0; i<rowCount; i++)
            {
                var insertText= "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime,Shift)  values ('" 
                + this.dateTimePicker.Value.ToShortDateString() + "','"
                + this.textBoxMachineNumber.Text + "','"
                + dataGridView.Rows[i].Cells[0].Value.ToString() + "','"
                + dataGridView.Rows[i].Cells[1].Value.ToString() + "','"
                + shift
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

        private void checkBoxShift_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShift.Checked == true)
            {
                checkBoxShift.Text = "2-га зміна";
            }
            else
            {
                checkBoxShift.Text = "1-а зміна";
            }
        }

        
    }
}
