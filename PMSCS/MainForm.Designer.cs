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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stopingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stoppingDBDataSet = new PMSCS.StoppingDBDataSet();
            this.stopingTableAdapter = new PMSCS.StoppingDBDataSetTableAdapters.StopingTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMachineNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReason = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStoppingTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoppingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoppingDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stDateDataGridViewTextBoxColumn,
            this.machineNumberDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.stoppingTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stopingBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stopingBindingSource
            // 
            this.stopingBindingSource.DataMember = "Stoping";
            this.stopingBindingSource.DataSource = this.stoppingDBDataSet;
            // 
            // stoppingDBDataSet
            // 
            this.stoppingDBDataSet.DataSetName = "StoppingDBDataSet";
            this.stoppingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stopingTableAdapter
            // 
            this.stopingTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(727, 445);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxStoppingTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxReason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxMachineNumber);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання новго запису";
            // 
            // textBoxMachineNumber
            // 
            this.textBoxMachineNumber.Location = new System.Drawing.Point(231, 51);
            this.textBoxMachineNumber.Name = "textBoxMachineNumber";
            this.textBoxMachineNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxMachineNumber.TabIndex = 4;
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
            this.label2.Location = new System.Drawing.Point(228, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер машини";
            // 
            // comboBoxReason
            // 
            this.comboBoxReason.FormattingEnabled = true;
            this.comboBoxReason.Items.AddRange(new object[] {
            "Перемога",
            "Тут буде ",
            "Потім ",
            "Список",
            "Причин"});
            this.comboBoxReason.Location = new System.Drawing.Point(354, 51);
            this.comboBoxReason.Name = "comboBoxReason";
            this.comboBoxReason.Size = new System.Drawing.Size(228, 24);
            this.comboBoxReason.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Причина зупинки";
            // 
            // textBoxStoppingTime
            // 
            this.textBoxStoppingTime.Location = new System.Drawing.Point(615, 51);
            this.textBoxStoppingTime.Name = "textBoxStoppingTime";
            this.textBoxStoppingTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxStoppingTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Час зупинки";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер запису";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // stDateDataGridViewTextBoxColumn
            // 
            this.stDateDataGridViewTextBoxColumn.DataPropertyName = "StDate";
            this.stDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.stDateDataGridViewTextBoxColumn.Name = "stDateDataGridViewTextBoxColumn";
            // 
            // machineNumberDataGridViewTextBoxColumn
            // 
            this.machineNumberDataGridViewTextBoxColumn.DataPropertyName = "MachineNumber";
            this.machineNumberDataGridViewTextBoxColumn.HeaderText = "Номер машини";
            this.machineNumberDataGridViewTextBoxColumn.Name = "machineNumberDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина зупинки";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // stoppingTimeDataGridViewTextBoxColumn
            // 
            this.stoppingTimeDataGridViewTextBoxColumn.DataPropertyName = "StoppingTime";
            this.stoppingTimeDataGridViewTextBoxColumn.HeaderText = "Час зупинки";
            this.stoppingTimeDataGridViewTextBoxColumn.Name = "stoppingTimeDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "PMSCS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoppingDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StoppingDBDataSet stoppingDBDataSet;
        private System.Windows.Forms.BindingSource stopingBindingSource;
        private StoppingDBDataSetTableAdapters.StopingTableAdapter stopingTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMachineNumber;
        private System.Windows.Forms.ComboBox comboBoxReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStoppingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoppingTimeDataGridViewTextBoxColumn;
    }
}

