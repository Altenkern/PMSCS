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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void buttonShow_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projects\C#\PMSCS\StoppingDB.mdb;Persist Security Info=False");  //create connection
            con.Open();
            OleDbTransaction trans = con.BeginTransaction();            //begin transaction
                                                                        //create command
            OleDbCommand cmd = new OleDbCommand("select * from Stoping", con, trans);

            //create DataGridView and its DataSource
            
            DataTable tbl = new DataTable("source");
            //fill DataTable
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(tbl);

            dataGridView1.DataSource = tbl;

            //Display DataGridView
            
            //Controls.Add(dataGridView1);
            //dataGridView1.Dock = DockStyle.Fill;
            

            //finaliaze
            trans.Commit();
            con.Close();
        }
    }
}
