using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgLanDIz
{
    public partial class OrderM : Form
    {
        public OrderM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDataBase db = new ClassDataBase();

            string qq = @"insert into materials(name_m, category_m, unit_of_measurement_m, quatnity_m, cost_m) values ('" + NameM.Text + @"','" + CatM.Text + @"','" + UnitMeasurementM.Text + @"','" + Quantity.Text + @"','" + Cost.Text + @"')";
            db.ExecuteNonQuery("ALD_V2.db", qq, 0);
        }
    }
}
