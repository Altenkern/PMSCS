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
      
        public FormStatistics()
        {
            gr = new GenericRepository();
            InitializeComponent();
            label2.Visible = false;
            label1.Visible = false;
            lbSelectInfo.Text = "";
            dateTimePickerFDDF.Visible = false;
            checkBoxShiftFDDF.Visible = false;
            btnAddEndDate.Text = "Додати кінцеву дату(необов`язково)";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridViewStats.Rows.Clear();
            string date = dateTimePickerFDDS.Value.ToShortDateString();
            int shiftFDDS=checkBoxShiftFDDS.Checked?2:1;
            if (abonent)
            {
               
                if (gr.Select(shiftFDDS, gr.ReplaceDayAndMonth(date)))
                {

                    //dataGridViewStats.DataSource = StaticClass.StoppingsList;
                    for (int i = 0; i < StaticClass.StoppingsList.Count; i++)
                    {
                        dataGridViewStats.Rows.Add();
                        dataGridViewStats.Rows[i].Cells["Column1"].Value = StaticClass.StoppingsList[i].MachineNumber;
                        dataGridViewStats.Rows[i].Cells["Column2"].Value = StaticClass.StoppingsList[i].WorkingTime;
                        dataGridViewStats.Rows[i].Cells["Column3"].Value = StaticClass.StoppingsList[i].PlannedStopingsTime;
                        dataGridViewStats.Rows[i].Cells["Column4"].Value = StaticClass.StoppingsList[i].UnplannedStopingsTime;
                        dataGridViewStats.Rows[i].Cells["Column5"].Value = StaticClass.StoppingsList[i].PlannedStoppings;
                        dataGridViewStats.Rows[i].Cells["Column6"].Value = StaticClass.StoppingsList[i].UnplannedStoppings;
                        dataGridViewStats.Rows[i].Cells["Column7"].Value = StaticClass.StoppingsList[i].MTBF;
                        
                    }
                    lbSelectInfo.Text = "Вибірка взята по такій даті: " + date ;
                };
            }
            else
            {
                if (gr.Select(shiftFDDS, gr.ReplaceDayAndMonth(date), checkBoxShiftFDDF.Checked ? 2 : 1,gr.ReplaceDayAndMonth(dateTimePickerFDDF.Value.ToShortDateString())))
                {

                    for (int i = 0; i < StaticClass.StoppingsList.Count; i++)
                    {
                        dataGridViewStats.Rows.Add();
                        dataGridViewStats.Rows[i].Cells["Column1"].Value = StaticClass.StoppingsList[i].MachineNumber;
                        dataGridViewStats.Rows[i].Cells["Column2"].Value = StaticClass.StoppingsList[i].WorkingTime;
                        dataGridViewStats.Rows[i].Cells["Column3"].Value = StaticClass.StoppingsList[i].PlannedStopingsTime;
                        dataGridViewStats.Rows[i].Cells["Column4"].Value = StaticClass.StoppingsList[i].UnplannedStopingsTime;
                        dataGridViewStats.Rows[i].Cells["Column5"].Value = StaticClass.StoppingsList[i].PlannedStoppings;
                        dataGridViewStats.Rows[i].Cells["Column6"].Value = StaticClass.StoppingsList[i].UnplannedStoppings;
                        dataGridViewStats.Rows[i].Cells["Column7"].Value = StaticClass.StoppingsList[i].MTBF;

                    }
                    if (Convert.ToDateTime(date)<dateTimePickerFDDF.Value)
                    {
                        lbSelectInfo.Text = "Вибірка взята по таким датам: " + date + " ... " + dateTimePickerFDDF.Value.ToShortDateString();
                    }
                    else
                    {
                        lbSelectInfo.Text = "Вибірка взята по таким датам: " + dateTimePickerFDDF.Value.ToShortDateString() + " ... " + date;
                    }
                    
                };
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        static bool abonent=true;//data
        private void btnAddEndDate_Click(object sender, EventArgs e)
        {
            if (abonent) {
                label2.Visible = true;
                label1.Visible = true;
                dateTimePickerFDDF.Visible = true;
                checkBoxShiftFDDF.Visible = true;
                btnAddEndDate.Text = "Прибрати кінцеву дату";
            }
            else
            {
                label2.Visible = false;
                label1.Visible = false;
                dateTimePickerFDDF.Visible = false;
                checkBoxShiftFDDF.Visible = false;
                btnAddEndDate.Text = "Додати кінцеву дату(необов`язково)";
            }
            abonent = !abonent;
        }
    }
}
