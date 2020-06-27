namespace AgLanDIz
{
    partial class OrdersProjects
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
            this.cbCatProj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNameProj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCatProj
            // 
            this.cbCatProj.FormattingEnabled = true;
            this.cbCatProj.Location = new System.Drawing.Point(128, 12);
            this.cbCatProj.Name = "cbCatProj";
            this.cbCatProj.Size = new System.Drawing.Size(158, 21);
            this.cbCatProj.TabIndex = 3;
            this.cbCatProj.SelectedIndexChanged += new System.EventHandler(this.cbCatProj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория";
            // 
            // cbNameProj
            // 
            this.cbNameProj.FormattingEnabled = true;
            this.cbNameProj.Location = new System.Drawing.Point(128, 39);
            this.cbNameProj.Name = "cbNameProj";
            this.cbNameProj.Size = new System.Drawing.Size(158, 21);
            this.cbNameProj.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Проект";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrdersProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbNameProj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCatProj);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrdersProjects";
            this.Text = "Проекты заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCatProj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNameProj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}