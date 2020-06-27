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
    public partial class Mat : Form
    {
        public Mat()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aLD_V2DataSet.materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.aLD_V2DataSet.materials);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MPROJ newForm = new MPROJ();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderM newForm = new OrderM();
            newForm.Show();
        }
    }
}
