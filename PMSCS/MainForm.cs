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
            //DebugForm deb = new DebugForm();
            //deb.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxMachineNumber.Text != "")
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

                for (int i = 0; i < rowCount; i++)
                {
                    var insertText = "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime,Shift)  values ('"
                    + this.dateTimePicker.Value.ToShortDateString() + "','"
                    + this.textBoxMachineNumber.Text + "','"
                    + dataGridView.Rows[i].Cells[0].Value.ToString() + "','"
                    + dataGridView.Rows[i].Cells[1].Value.ToString() + "','"
                    + shift
                    + "');";

                    var temp = stoppingRepository.Insert(insertText);
                    if (i == rowCount - 1)
                    {
                        if (temp == true)
                        {

                            MessageBox.Show("Записи успішно додані");
                        }
                        else
                        {
                            MessageBox.Show("Помилка запису!");
                        }
                    }
                }
                dataGridView.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Вкажіть номер машини");
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

        private void buttonStatsForm_Click(object sender, EventArgs e)
        {
            Form frm = new FormStatistics();
            frm.Show();
        }

        private void buttonUnused_Click(object sender, EventArgs e)
        {
            string shift;

            if (checkBoxShift.Checked == true)
            {
                shift = "2";
            }
            else
            {
                shift = "1";
            }
            var insertText = "insert into Stoping (StDate,MachineNumber,Reason,StoppingTime,Shift)  values ('"
                + this.dateTimePicker.Value.ToShortDateString() + "','"
                + this.textBoxMachineNumber.Text + "','"
                + 9.ToString() + "','"
                + 720.ToString() + "','"
                + shift
                + "');";

            var temp = stoppingRepository.Insert(insertText);
            
            
                if (temp == true)
                {

                    MessageBox.Show("Записи успішно додані");
                }
                else
                {
                    MessageBox.Show("Помилка запису!");
                }
            
        }
    }
}
