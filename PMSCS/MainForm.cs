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
        OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.15.0;Data Source=|DataDirectory|\StoppingDB.accdb");
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stoppingDBDataSet.Stoping". При необходимости она может быть перемещена или удалена.
            this.stopingTableAdapter.Fill(this.stoppingDBDataSet.Stoping);
            dbcon.Open();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
