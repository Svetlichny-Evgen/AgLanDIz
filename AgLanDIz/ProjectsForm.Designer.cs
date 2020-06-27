namespace AgLanDIz
{
    partial class ProjectsForm
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
            this.dgvProj = new System.Windows.Forms.DataGridView();
            this.name_proj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_proj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_of_work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aLDV2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLD_V2DataSet = new AgLanDIz.ALD_V2DataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cost2 = new System.Windows.Forms.TextBox();
            this.cost1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Serch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.projectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new AgLanDIz.ALD_V2DataSetTableAdapters.projectsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLDV2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProj
            // 
            this.dgvProj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_proj,
            this.cat_proj,
            this.cost_of_work,
            this.min_square,
            this.work_time});
            this.dgvProj.Location = new System.Drawing.Point(11, 240);
            this.dgvProj.Name = "dgvProj";
            this.dgvProj.RowHeadersWidth = 51;
            this.dgvProj.Size = new System.Drawing.Size(553, 274);
            this.dgvProj.TabIndex = 0;
            // 
            // name_proj
            // 
            this.name_proj.HeaderText = "Название";
            this.name_proj.Name = "name_proj";
            this.name_proj.ReadOnly = true;
            // 
            // cat_proj
            // 
            this.cat_proj.HeaderText = "Категория";
            this.cat_proj.Name = "cat_proj";
            this.cat_proj.ReadOnly = true;
            // 
            // cost_of_work
            // 
            this.cost_of_work.HeaderText = "Стоимость работы";
            this.cost_of_work.Name = "cost_of_work";
            this.cost_of_work.ReadOnly = true;
            // 
            // min_square
            // 
            this.min_square.HeaderText = "Минимальная площадь";
            this.min_square.Name = "min_square";
            // 
            // work_time
            // 
            this.work_time.HeaderText = "Время выполнения";
            this.work_time.Name = "work_time";
            this.work_time.ReadOnly = true;
            // 
            // projectsBindingSource1
            // 
            this.projectsBindingSource1.DataMember = "projects";
            this.projectsBindingSource1.DataSource = this.aLDV2DataSetBindingSource;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(591, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проекты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.square);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cost2);
            this.groupBox2.Controls.Add(this.cost1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Serch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbCat);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(345, 188);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(118, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "от";
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(146, 115);
            this.square.Margin = new System.Windows.Forms.Padding(2);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(76, 20);
            this.square.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(118, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "от";
            // 
            // cost2
            // 
            this.cost2.Location = new System.Drawing.Point(256, 72);
            this.cost2.Margin = new System.Windows.Forms.Padding(2);
            this.cost2.Name = "cost2";
            this.cost2.Size = new System.Drawing.Size(76, 20);
            this.cost2.TabIndex = 26;
            // 
            // cost1
            // 
            this.cost1.Location = new System.Drawing.Point(146, 72);
            this.cost1.Margin = new System.Windows.Forms.Padding(2);
            this.cost1.Name = "cost1";
            this.cost1.Size = new System.Drawing.Size(76, 20);
            this.cost1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Площадь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Стоимость";
            // 
            // Serch
            // 
            this.Serch.Location = new System.Drawing.Point(268, 151);
            this.Serch.Margin = new System.Windows.Forms.Padding(2);
            this.Serch.Name = "Serch";
            this.Serch.Size = new System.Drawing.Size(64, 21);
            this.Serch.TabIndex = 21;
            this.Serch.Text = "Поиск";
            this.Serch.UseVisualStyleBackColor = true;
            this.Serch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Категория";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(146, 25);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(186, 21);
            this.cbCat.TabIndex = 13;
            // 
            // projectsBindingSource2
            // 
            this.projectsBindingSource2.DataMember = "projects";
            this.projectsBindingSource2.DataSource = this.aLDV2DataSetBindingSource;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.aLDV2DataSetBindingSource;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(591, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Добавить проект";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvProj);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectsForm";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLDV2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLD_V2DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Serch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox square;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cost2;
        private System.Windows.Forms.TextBox cost1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource aLDV2DataSetBindingSource;
        private ALD_V2DataSet aLD_V2DataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ALD_V2DataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource projectsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_proj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_proj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_of_work;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_square;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_time;
    }
}