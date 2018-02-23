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
        public class Test
        {
            public int a { get; set; }
            public string b { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Test> testlist = new List<Test>();
            testlist.Add(new Test { a = 1, b = "11" });
            testlist.Add(new Test { a = 2, b = "11" });
            testlist.Add(new Test { a = 3, b = "11" });
            testlist.Add(new Test { a = 4, b = "11" });
            testlist.Add(new Test { a = 5, b = "11" });
            testlist.Add(new Test { a = 6, b = "11" });
            testlist.Add(new Test { a = 7, b = "11" });
           // dataGridView1.DataSource = testlist;
           for(int i =0; i< testlist.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Column1"].Value = testlist[i].a;
                dataGridView1.Rows[i].Cells["Column2"].Value = testlist[i].b;
            }
        }
        
        private void DebugForm_Load(object sender, EventArgs e)
        {
            //grdbg.Select("Stoping");
        }
    }
}
