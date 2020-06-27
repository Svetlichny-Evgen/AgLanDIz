using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgLanDIz
{
    public partial class StuffForm : Form
    {
        public StuffForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void StuffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aLD_V2DataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.aLD_V2DataSet.employee);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ClassDataBase db = new ClassDataBase();

            string q = @"insert into employee(s_empl, n_empl, p_empl, exper) values ('"+ tbSE.Text+@"','"+ tbNE.Text+ @"','" + tbPE.Text + @"','" + tbEE.Text + @"')";
            db.ExecuteNonQuery("ALD_V2.db",q,0);
        }
    }
}
