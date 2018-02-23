namespace PMSCS
{
    partial class FormStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShiftFOD = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFOD = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShiftFDDF = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftFDDS = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFDDF = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFDDS = new System.Windows.Forms.DateTimePicker();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStats.Location = new System.Drawing.Point(13, 150);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowTemplate.Height = 24;
            this.dataGridViewStats.Size = new System.Drawing.Size(1408, 497);
            this.dataGridViewStats.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShiftFOD);
            this.groupBox1.Controls.Add(this.dateTimePickerFOD);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обрати дату";
            // 
            // checkBoxShiftFOD
            // 
            this.checkBoxShiftFOD.AutoSize = true;
            this.checkBoxShiftFOD.Location = new System.Drawing.Point(236, 36);
            this.checkBoxShiftFOD.Name = "checkBoxShiftFOD";
            this.checkBoxShiftFOD.Size = new System.Drawing.Size(90, 21);
            this.checkBoxShiftFOD.TabIndex = 8;
            this.checkBoxShiftFOD.Text = "1-а зміна";
            this.checkBoxShiftFOD.UseVisualStyleBackColor = true;
            this.checkBoxShiftFOD.CheckedChanged += new System.EventHandler(this.checkBoxShiftFOD_CheckedChanged);
            // 
            // dateTimePickerFOD
            // 
            this.dateTimePickerFOD.Location = new System.Drawing.Point(30, 36);
            this.dateTimePickerFOD.Name = "dateTimePickerFOD";
            this.dateTimePickerFOD.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFOD.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxShiftFDDF);
            this.groupBox2.Controls.Add(this.checkBoxShiftFDDS);
            this.groupBox2.Controls.Add(this.dateTimePickerFDDF);
            this.groupBox2.Controls.Add(this.dateTimePickerFDDS);
            this.groupBox2.Location = new System.Drawing.Point(1061, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Діапазон дат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Від";
            // 
            // checkBoxShiftFDDF
            // 
            this.checkBoxShiftFDDF.AutoSize = true;
            this.checkBoxShiftFDDF.Location = new System.Drawing.Point(253, 80);
            this.checkBoxShiftFDDF.Name = "checkBoxShiftFDDF";
            this.checkBoxShiftFDDF.Size = new System.Drawing.Size(90, 21);
            this.checkBoxShiftFDDF.TabIndex = 10;
            this.checkBoxShiftFDDF.Text = "1-а зміна";
            this.checkBoxShiftFDDF.UseVisualStyleBackColor = true;
            this.checkBoxShiftFDDF.CheckedChanged += new System.EventHandler(this.checkBoxShiftFDDF_CheckedChanged);
            // 
            // checkBoxShiftFDDS
            // 
            this.checkBoxShiftFDDS.AutoSize = true;
            this.checkBoxShiftFDDS.Location = new System.Drawing.Point(253, 39);
            this.checkBoxShiftFDDS.Name = "checkBoxShiftFDDS";
            this.checkBoxShiftFDDS.Size = new System.Drawing.Size(90, 21);
            this.checkBoxShiftFDDS.TabIndex = 9;
            this.checkBoxShiftFDDS.Text = "1-а зміна";
            this.checkBoxShiftFDDS.UseVisualStyleBackColor = true;
            this.checkBoxShiftFDDS.CheckedChanged += new System.EventHandler(this.checkBoxShiftFDDS_CheckedChanged);
            // 
            // dateTimePickerFDDF
            // 
            this.dateTimePickerFDDF.Location = new System.Drawing.Point(47, 80);
            this.dateTimePickerFDDF.Name = "dateTimePickerFDDF";
            this.dateTimePickerFDDF.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFDDF.TabIndex = 5;
            // 
            // dateTimePickerFDDS
            // 
            this.dateTimePickerFDDS.Location = new System.Drawing.Point(47, 38);
            this.dateTimePickerFDDS.Name = "dateTimePickerFDDS";
            this.dateTimePickerFDDS.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFDDS.TabIndex = 4;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(652, 32);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(140, 62);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Вивести дані";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 659);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewStats);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFOD;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDDF;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDDS;
        private System.Windows.Forms.CheckBox checkBoxShiftFOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShiftFDDF;
        private System.Windows.Forms.CheckBox checkBoxShiftFDDS;
        private System.Windows.Forms.Button buttonShow;
    }
}