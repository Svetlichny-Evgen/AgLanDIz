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
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }

        private void bE_Click(object sender, EventArgs e)
        {
                StuffForm newForm = new StuffForm();
                newForm.Show();
        }


        private void bP_Click(object sender, EventArgs e)
        {
            ProjectsForm newForm = new ProjectsForm();
            newForm.Show();
        }

        private void bFFO_Click(object sender, EventArgs e)
        {
            FinanceReport newForm = new FinanceReport();
            newForm.Show();
        }

        private void bFD_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders newForm = new Orders();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat newForm = new Mat();
            newForm.Show();
        }
    }
}
