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
    public partial class DebugForm : Form
    {
        public GenericRepository grdbg;
        public DebugForm()
        {
            grdbg = new GenericRepository();
            InitializeComponent();
        }
        class test
        {
            public int a;
            public string b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> srtlist = new List<string>();
            for(int i = 0; i<10; i++)
            {
                string tempstring = i.ToString();
                srtlist.Add(tempstring);
            }
            string[,] strarr = new string[ 30,30];
            for(int i = 0; i<20; i++)
            {
                for(int j = 0; j<20; j++)
                {
                    strarr[i, j] = "1";
                }
            }
            List<test> tstlist = new List<test>();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    string temp = j.ToString();
                    tstlist.Add(new test() {a=i,b= temp });
                }
            }
            //dataGridView1.DataSource = srtlist;
            ////dataGridView1.DataSource = strarr;
            int a = 0;
            
        }
        
        private void DebugForm_Load(object sender, EventArgs e)
        {
            grdbg.Select("Stoping");

        }
    }
}
