namespace AgLanDIz
{
    partial class Mat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aLD_V2DataSet = new AgLanDIz.ALD_V2DataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new AgLanDIz.ALD_V2DataSetTableAdapters.materialsTableAdapter();
            this.namemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofmeasurementmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatnitymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namemDataGridViewTextBoxColumn,
            this.categorymDataGridViewTextBoxColumn,
            this.unitofmeasurementmDataGridViewTextBoxColumn,
            this.quatnitymDataGridViewTextBoxColumn,
            this.costmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Материалы проектов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(591, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // aLD_V2DataSet
            // 
            this.aLD_V2DataSet.DataSetName = "ALD_V2DataSet";
            this.aLD_V2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.aLD_V2DataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // namemDataGridViewTextBoxColumn
            // 
            this.namemDataGridViewTextBoxColumn.DataPropertyName = "name_m";
            this.namemDataGridViewTextBoxColumn.HeaderText = "Название";
            this.namemDataGridViewTextBoxColumn.Name = "namemDataGridViewTextBoxColumn";
            // 
            // categorymDataGridViewTextBoxColumn
            // 
            this.categorymDataGridViewTextBoxColumn.DataPropertyName = "category_m";
            this.categorymDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categorymDataGridViewTextBoxColumn.Name = "categorymDataGridViewTextBoxColumn";
            // 
            // unitofmeasurementmDataGridViewTextBoxColumn
            // 
            this.unitofmeasurementmDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement_m";
            this.unitofmeasurementmDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.unitofmeasurementmDataGridViewTextBoxColumn.Name = "unitofmeasurementmDataGridViewTextBoxColumn";
            // 
            // quatnitymDataGridViewTextBoxColumn
            // 
            this.quatnitymDataGridViewTextBoxColumn.DataPropertyName = "quatnity_m";
            this.quatnitymDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quatnitymDataGridViewTextBoxColumn.Name = "quatnitymDataGridViewTextBoxColumn";
            // 
            // costmDataGridViewTextBoxColumn
            // 
            this.costmDataGridViewTextBoxColumn.DataPropertyName = "cost_m";
            this.costmDataGridViewTextBoxColumn.HeaderText = "Стоимость за единицу";
            this.costmDataGridViewTextBoxColumn.Name = "costmDataGridViewTextBoxColumn";
            // 
            // Mat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 320);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mat";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.Mat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ALD_V2DataSet aLD_V2DataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private ALD_V2DataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofmeasurementmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatnitymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costmDataGridViewTextBoxColumn;
    }
}