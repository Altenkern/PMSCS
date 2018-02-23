namespace PMSCS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShift = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMachineNumber = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnErorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStoppingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonStatsForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(359, 643);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShift);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMachineNumber);
            this.groupBox1.Location = new System.Drawing.Point(9, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання нових записів";
            // 
            // checkBoxShift
            // 
            this.checkBoxShift.AutoSize = true;
            this.checkBoxShift.Location = new System.Drawing.Point(368, 46);
            this.checkBoxShift.Name = "checkBoxShift";
            this.checkBoxShift.Size = new System.Drawing.Size(90, 21);
            this.checkBoxShift.TabIndex = 7;
            this.checkBoxShift.Text = "1-а зміна";
            this.checkBoxShift.UseVisualStyleBackColor = true;
            this.checkBoxShift.CheckedChanged += new System.EventHandler(this.checkBoxShift_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер машини";
            // 
            // textBoxMachineNumber
            // 
            this.textBoxMachineNumber.Location = new System.Drawing.Point(233, 46);
            this.textBoxMachineNumber.Name = "textBoxMachineNumber";
            this.textBoxMachineNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxMachineNumber.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnErorCode,
            this.ColumnStoppingTime});
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(471, 528);
            this.dataGridView.TabIndex = 11;
            // 
            // ColumnErorCode
            // 
            this.ColumnErorCode.HeaderText = "Код помилки";
            this.ColumnErorCode.Name = "ColumnErorCode";
            this.ColumnErorCode.Width = 155;
            // 
            // ColumnStoppingTime
            // 
            this.ColumnStoppingTime.HeaderText = "Час зупинки";
            this.ColumnStoppingTime.Name = "ColumnStoppingTime";
            this.ColumnStoppingTime.Width = 155;
            // 
            // buttonStatsForm
            // 
            this.buttonStatsForm.Location = new System.Drawing.Point(9, 643);
            this.buttonStatsForm.Name = "buttonStatsForm";
            this.buttonStatsForm.Size = new System.Drawing.Size(122, 40);
            this.buttonStatsForm.TabIndex = 12;
            this.buttonStatsForm.Text = "Статистика";
            this.buttonStatsForm.UseVisualStyleBackColor = true;
            this.buttonStatsForm.Click += new System.EventHandler(this.buttonStatsForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 695);
            this.Controls.Add(this.buttonStatsForm);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PMSCS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMachineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoppingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBoxShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnErorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoppingTime;
        private System.Windows.Forms.Button buttonStatsForm;
    }
}

