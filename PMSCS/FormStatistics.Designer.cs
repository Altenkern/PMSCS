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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddEndDate = new System.Windows.Forms.Button();
            this.lbSelectInfo = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShiftFDDF = new System.Windows.Forms.CheckBox();
            this.checkBoxShiftFDDS = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFDDF = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFDDS = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewStats.Location = new System.Drawing.Point(13, 150);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowTemplate.Height = 24;
            this.dataGridViewStats.Size = new System.Drawing.Size(1408, 497);
            this.dataGridViewStats.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Пакувана машина";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Працювала, хв";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Планові зупинки, хв";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Не планові зупинки, хв";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Кількість планових зупинок";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Кількість непланових зупинок";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "MTBF";
            this.Column7.Name = "Column7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddEndDate);
            this.groupBox2.Controls.Add(this.lbSelectInfo);
            this.groupBox2.Controls.Add(this.buttonShow);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxShiftFDDF);
            this.groupBox2.Controls.Add(this.checkBoxShiftFDDS);
            this.groupBox2.Controls.Add(this.dateTimePickerFDDF);
            this.groupBox2.Controls.Add(this.dateTimePickerFDDS);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1409, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PMSCS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAddEndDate
            // 
            this.btnAddEndDate.Location = new System.Drawing.Point(34, 97);
            this.btnAddEndDate.Name = "btnAddEndDate";
            this.btnAddEndDate.Size = new System.Drawing.Size(356, 24);
            this.btnAddEndDate.TabIndex = 14;
            this.btnAddEndDate.Text = "Додати кінцеву дату(необов`язково)";
            this.btnAddEndDate.UseVisualStyleBackColor = true;
            this.btnAddEndDate.Click += new System.EventHandler(this.btnAddEndDate_Click);
            // 
            // lbSelectInfo
            // 
            this.lbSelectInfo.AutoSize = true;
            this.lbSelectInfo.Location = new System.Drawing.Point(837, 54);
            this.lbSelectInfo.Name = "lbSelectInfo";
            this.lbSelectInfo.Size = new System.Drawing.Size(420, 17);
            this.lbSelectInfo.TabIndex = 13;
            this.lbSelectInfo.Text = "NadiusaYarek pridumae nazvaniedlya wogo ale kogoya obmanuu";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(1263, 32);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(140, 62);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Вивести дані";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Від";
            // 
            // checkBoxShiftFDDF
            // 
            this.checkBoxShiftFDDF.AutoSize = true;
            this.checkBoxShiftFDDF.Location = new System.Drawing.Point(700, 54);
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
            this.checkBoxShiftFDDS.Location = new System.Drawing.Point(280, 58);
            this.checkBoxShiftFDDS.Name = "checkBoxShiftFDDS";
            this.checkBoxShiftFDDS.Size = new System.Drawing.Size(90, 21);
            this.checkBoxShiftFDDS.TabIndex = 9;
            this.checkBoxShiftFDDS.Text = "1-а зміна";
            this.checkBoxShiftFDDS.UseVisualStyleBackColor = true;
            this.checkBoxShiftFDDS.CheckedChanged += new System.EventHandler(this.checkBoxShiftFDDS_CheckedChanged);
            // 
            // dateTimePickerFDDF
            // 
            this.dateTimePickerFDDF.Location = new System.Drawing.Point(494, 54);
            this.dateTimePickerFDDF.Name = "dateTimePickerFDDF";
            this.dateTimePickerFDDF.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFDDF.TabIndex = 5;
            // 
            // dateTimePickerFDDS
            // 
            this.dateTimePickerFDDS.Location = new System.Drawing.Point(74, 57);
            this.dateTimePickerFDDS.Name = "dateTimePickerFDDS";
            this.dateTimePickerFDDS.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFDDS.TabIndex = 4;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 659);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewStats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDDF;
        private System.Windows.Forms.DateTimePicker dateTimePickerFDDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShiftFDDS;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.CheckBox checkBoxShiftFDDF;
        private System.Windows.Forms.Label lbSelectInfo;
        private System.Windows.Forms.Button btnAddEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}