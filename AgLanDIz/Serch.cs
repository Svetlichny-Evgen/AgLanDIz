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
    public partial class Serch : Form
    {
        public Serch()
        {
            InitializeComponent();
        }

        ClassDataBase db = new ClassDataBase();
        public List<Order2> listOrder2 = new List<Order2>();

        private void button1_Click(object sender, EventArgs e)
        {
            string s = @"select o.id_order, c.s_cl, c.n_cl, c.p_cl, o.footage, o.date_of_conclusion, o.expiration_date, o.order_cost, o.readyy, e.s_empl, e.n_empl, e.p_empl from employee e natural join order_empl natural join orderr o natural join clientt c  where o.id_order = '"+comboBox1.Text+@"' group by id_order ;";
            db.Execute("ALD_V2.db", s, ref listOrder2);
            ClassSerialiaze.SerialiazeToXml<List<Order2>>(ref listOrder2, "data.xml");

            FormReport frmReport = new FormReport();
            frmReport.ShowDialog();
        }
    }
}
