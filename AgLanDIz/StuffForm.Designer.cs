namespace AgLanDIz
{
    partial class StuffForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmpl = new System.Windows.Forms.DataGridView();
            this.semplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLDV2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLD_V2DataSet = new AgLanDIz.ALD_V2DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSE = new System.Windows.Forms.TextBox();
            this.tbPE = new System.Windows.Forms.TextBox();
            this.tbEE = new System.Windows.Forms.TextBox();
            this.tbNE = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new AgLanDIz.ALD_V2DataSetTableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLDV2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpl
            // 
            this.dgvEmpl.AutoGenerateColumns = false;
            this.dgvEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semplDataGridViewTextBoxColumn,
            this.nemplDataGridViewTextBoxColumn,
            this.pemplDataGridViewTextBoxColumn,
            this.experDataGridViewTextBoxColumn});
            this.dgvEmpl.DataSource = this.employeeBindingSource;
            this.dgvEmpl.Location = new System.Drawing.Point(20, 197);
            this.dgvEmpl.Name = "dgvEmpl";
            this.dgvEmpl.RowHeadersWidth = 51;
            this.dgvEmpl.Size = new System.Drawing.Size(555, 227);
            this.dgvEmpl.TabIndex = 0;
            // 
            // semplDataGridViewTextBoxColumn
            // 
            this.semplDataGridViewTextBoxColumn.DataPropertyName = "s_empl";
            this.semplDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.semplDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semplDataGridViewTextBoxColumn.Name = "semplDataGridViewTextBoxColumn";
            this.semplDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemplDataGridViewTextBoxColumn
            // 
            this.nemplDataGridViewTextBoxColumn.DataPropertyName = "n_empl";
            this.nemplDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nemplDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nemplDataGridViewTextBoxColumn.Name = "nemplDataGridViewTextBoxColumn";
            this.nemplDataGridViewTextBoxColumn.Width = 125;
            // 
            // pemplDataGridViewTextBoxColumn
            // 
            this.pemplDataGridViewTextBoxColumn.DataPropertyName = "p_empl";
            this.pemplDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.pemplDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pemplDataGridViewTextBoxColumn.Name = "pemplDataGridViewTextBoxColumn";
            this.pemplDataGridViewTextBoxColumn.Width = 125;
            // 
            // experDataGridViewTextBoxColumn
            // 
            this.experDataGridViewTextBoxColumn.DataPropertyName = "exper";
            this.experDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.experDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experDataGridViewTextBoxColumn.Name = "experDataGridViewTextBoxColumn";
            this.experDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.aLDV2DataSetBindingSource;
            // 
            // aLDV2DataSetBindingSource
            // 
            this.aLDV2DataSetBindingSource.DataSource = this.aLD_V2DataSet;
            this.aLDV2DataSetBindingSource.Position = 0;
            // 
            // aLD_V2DataSet
            // 
            this.aLD_V2DataSet.DataSetName = "ALD_V2DataSet";
            this.aLD_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(798, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(240, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список сотрудников";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSE);
            this.groupBox1.Controls.Add(this.tbPE);
            this.groupBox1.Controls.Add(this.tbEE);
            this.groupBox1.Controls.Add(this.tbNE);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Location = new System.Drawing.Point(599, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить сотрудника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Стаж работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Фамилия";
            // 
            // tbSE
            // 
            this.tbSE.Location = new System.Drawing.Point(96, 37);
            this.tbSE.Name = "tbSE";
            this.tbSE.Size = new System.Drawing.Size(155, 20);
            this.tbSE.TabIndex = 22;
            // 
            // tbPE
            // 
            this.tbPE.Location = new System.Drawing.Point(96, 103);
            this.tbPE.Name = "tbPE";
            this.tbPE.Size = new System.Drawing.Size(155, 20);
            this.tbPE.TabIndex = 21;
            // 
            // tbEE
            // 
            this.tbEE.Location = new System.Drawing.Point(96, 138);
            this.tbEE.Name = "tbEE";
            this.tbEE.Size = new System.Drawing.Size(155, 20);
            this.tbEE.TabIndex = 20;
            // 
            // tbNE
            // 
            this.tbNE.Location = new System.Drawing.Point(96, 71);
            this.tbNE.Name = "tbNE";
            this.tbNE.Size = new System.Drawing.Size(155, 20);
            this.tbNE.TabIndex = 19;
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btAdd.Location = new System.Drawing.Point(176, 169);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // StuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEmpl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StuffForm";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.StuffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLDV2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSE;
        private System.Windows.Forms.TextBox tbPE;
        private System.Windows.Forms.TextBox tbEE;
        private System.Windows.Forms.TextBox tbNE;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.BindingSource aLDV2DataSetBindingSource;
        private ALD_V2DataSet aLD_V2DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ALD_V2DataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn semplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pemplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experDataGridViewTextBoxColumn;
    }
}