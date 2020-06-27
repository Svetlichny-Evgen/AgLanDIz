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
    public partial class OrdersProjects : Form
    {
        public OrdersProjects()
        {
            InitializeComponent();
            LoadData();
        }

        ClassDataBase db = new ClassDataBase();

        public List<Projects> listProj = new List<Projects>();
        public List<Order> listOrder = new List<Order>();
        public List<Projects> listProjCat = new List<Projects>();
        public List<OrderProj> listOrderProj = new List<OrderProj>();
        public List<Materials> listMaterials = new List<Materials>();

        public void LoadData()
        {
            string q = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects";
            db.Execute<Projects>("ALD_V2.db", q, ref listProj);
            string qq = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects group by cat_proj";
            db.Execute<Projects>("ALD_V2.db", qq, ref listProjCat);
            for (int i = 0; i < listProjCat.Count; i++)
            {
                cbCatProj.Items.Add(listProj[i].Cat_proj);
            }
        }

        private int GetIDP(string proj)
        {
            for (int i = 0; i < listProj.Count(); i++)
                if (listProj[i].Name_proj == proj) { return listProj[i].Id_proj; }
            return -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClassDataBase db = new ClassDataBase();
            double TC = 0;
            string ll = @"select id_order, id_cl, footage, date_of_conclusion, expiration_date, order_cost, readyy from orderr order by id_order desc limit 1;";
            db.Execute<Order>("ALD_V2.db", ll, ref listOrder);
            string ll2 = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects where cat_proj = '" + cbCatProj.Text + @"' and name_proj='" + cbNameProj.Text+ @"'";
            db.Execute<Projects>("ALD_V2.db", ll2, ref listProj);
            //string lll = @"insert into order_proj(id_order, id_proj) values (" + listOrder[0].Id_order + @"," + listProj[0].Id_proj + @")";
            string s = @"INSERT INTO order_proj (id_order, id_proj) VALUES (" + "(select id_order from orderr order by 1  desc limit 1)" + @"," + GetIDP(cbNameProj.Text) + @")";
            //db.Execute<Order>("ALD_V2.db", s, ref listOrder);
            db.ExecuteNonQuery("ALD_V2.db", s, 0);
            string z = @"select o.id_order, c.s_cl , c.n_cl , c.p_cl , o.footage, o.date_of_conclusion, o.expiration_date, o.order_cost,  p.id_proj,  p.cat_proj, p.name_proj, p.cost_of_work, p.min_square, p.work_time, o.readyy from projects p natural join orderr o natural join clientt c;";
            db.Execute<OrderProj>("ALD_V2.db", z, ref listOrderProj);
            for (int i = 0; i < listProj.Count; i++)
            {
                if (listProj[i].Cat_proj == cbCatProj.Text && listProj[i].Name_proj == cbNameProj.Text)
                {
                    TC = TC + listProj[i].Cost_of_work;
                }
            }
            s = @"UPDATE orderr SET order_cost = order_cost +'" + TC + @"' WHERE id_order = '" + listOrder[0].Id_order + @"'";
            db.ExecuteNonQuery("ALD_V2.db", s, 0);
            s = @"UPDATE Materials SET order_cost = order_cost +'" + TC + @"' WHERE id_order = '" + listOrder[0].Id_order + @"'";
            db.ExecuteNonQuery("ALD_V2.db", s, 0);
            Close();
        }

        private void cbCatProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNameProj.Items.Clear();
            for (int i = 0; i < listProj.Count; i++)
            {
                if (cbCatProj.Text == listProj[i].Cat_proj)
                {
                    cbNameProj.Items.Add(listProj[i].Name_proj);
                }
            }
        }
    }
}
