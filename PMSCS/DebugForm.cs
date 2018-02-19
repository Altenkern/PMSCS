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
using System.Data.OleDb;




namespace PMSCS
{
    public partial class DebugForm : Form
    {
        public GenericRepository grdbg;
        public DebugForm()
        {
            grdbg = new GenericRepository();
            InitializeComponent();
        }
        public class test
        {
            public string a { get; set; }
            public string b { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Projects\C#\PMSCS\StoppingDB.mdb;Persist Security Info=False");  //create connection
            con.Open();
            OleDbTransaction trans = con.BeginTransaction();            //begin transaction
                                                                        //create command
            OleDbCommand cmd = new OleDbCommand("select * from Stoping", con, trans);

            //create DataGridView and its DataSource
            DataGridView gv = new DataGridView();
            DataTable tbl = new DataTable("source");
            //fill DataTable
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(tbl);

            gv.DataSource = tbl;

            //Display DataGridView
            Form f = new Form();
            f.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
            f.ShowDialog();

            //finaliaze
            trans.Commit();
            con.Close();
        }
        
        private void DebugForm_Load(object sender, EventArgs e)
        {
            //grdbg.Select("Stoping");
        }
    }
}
