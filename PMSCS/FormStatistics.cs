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
    public partial class FormStatistics : Form
    {
        public GenericRepository gr;
        public int shiftFOD = 1;
        

        public FormStatistics()
        {
            gr = new GenericRepository();
            InitializeComponent();
        }
        
        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridViewStats.Update();
            
            string date = dateTimePickerFOD.Value.ToShortDateString();
            date = gr.ReplaceDayAndMonth(date);
            gr.Select(date, shiftFOD);


        }

        private void checkBoxShiftFOD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftFOD.Checked == true)
            {
                checkBoxShiftFOD.Text = "2-га зміна";
                shiftFOD = 2;
            }
            else
            {
                checkBoxShiftFOD.Text = "1-а зміна";
                shiftFOD = 1;
            }
        }

        private void checkBoxShiftFDDS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftFDDS.Checked == true)
            {
                checkBoxShiftFDDS.Text = "2-га зміна";
            }
            else
            {
                checkBoxShiftFDDS.Text = "1-а зміна";
            }
        }

        private void checkBoxShiftFDDF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShiftFDDF.Checked == true)
            {
                checkBoxShiftFDDF.Text = "2-га зміна";
            }
            else
            {
                checkBoxShiftFDDF.Text = "1-а зміна";
            }
        }
    }
}
