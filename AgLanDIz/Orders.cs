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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadData();
        }


        public List<Client> listClient = new List<Client>();
        public List<Order> listOrder = new List<Order>();
        public List<OrderProj> listOrderProj = new List<OrderProj>();
        public List<Employee> listEmployee = new List<Employee>();
        public List<Order_Empl> listOrderEmpl = new List<Order_Empl>();
        public List<Order2> listOrder2 = new List<Order2>();



        ClassDataBase db = new ClassDataBase();

        private void WR()
        {
            DateTime curr_data = DateTime.Now;
            string q = "";
            string q1 = "Не выполнено";
            string q2 = "Выполнено";
            for (int i = 0; i <listOrder.Count; i++)
            {
                if (Convert.ToDateTime(listOrder[i].Expiration_date) > curr_data)
                {
                    q = @"UPDATE orderr SET readyy = '" + q1 + "' WHERE id_order = '"+listOrder[i].Id_order +"'";
                    db.ExecuteNonQuery("ALD_V2.db", q, 0);
                    listOrder[i].Readyy = q1;
                }
                else
                {
                    q = @"UPDATE orderr SET readyy = '" + q2+ "' WHERE id_order = '" + listOrder[i].Id_order + "'";
                    db.ExecuteNonQuery("ALD_V2.db", q, 0);
                    listOrder[i].Readyy = q2;
                }
            }
        }

        public void LoadData()
        {
            string a = @"select id_order, id_empl from order_empl; ";
            db.Execute<Order_Empl>("ALD_V2.db",a, ref listOrderEmpl);
            string z = @"select o.id_order, c.s_cl , c.n_cl , c.p_cl , o.footage, o.date_of_conclusion, o.expiration_date, o.order_cost,  p.id_proj,  p.cat_proj, p.name_proj, p.cost_of_work, p.min_square, p.work_time, o.readyy from projects p natural join orderr o natural join clientt c;";
            db.Execute<OrderProj>("ALD_V2.db", z, ref listOrderProj);
            string q = @"select o.id_order, o.id_cl, o.footage, o.date_of_conclusion, o.expiration_date, o.order_cost, o.readyy from orderr o;";
            db.Execute<Order>("ALD_V2.db", q, ref listOrder);
            string qq1 = @"select id_empl, s_empl, n_empl, p_empl, exper from employee;";
            db.Execute<Employee>("ALD_V2.db", qq1, ref listEmployee);
            string s = @"select o.id_order, c.s_cl, c.n_cl, c.p_cl, o.footage, o.date_of_conclusion, o.expiration_date, o.order_cost, o.readyy, e.s_empl, e.n_empl, e.p_empl from employee e natural join order_empl natural join orderr o natural join clientt c  group by id_order;";
            db.Execute("ALD_V2.db", s, ref listOrder2);
            WR();
            string qq = @"select id_cl, s_cl, n_cl, p_cl from clientt;";
            db.Execute<Client>("ALD_V2.db", qq, ref listClient);
            string client = "";
            string empl = "";
            double qwe = 0;
            for (int i = 0; i < listOrder.Count; i++)
            {
                //qwe = TC(i+1);
                client = listClient[i].S_cl + " " + listClient[i].N_cl + " " + listClient[i].P_cl;
                dgvOR.Rows.Add(listOrder[i].Id_order, client, listOrder[i].Footage, listOrder[i].Date_of_conclusion, listOrder[i].Expiration_date, listOrder[i].Order_cost, listOrder[i].Readyy);
            }
            for (int i = 0; i < listClient.Count; i++)
            {
                comboBox1.Items.Add(client = listClient[i].S_cl + " " + listClient[i].N_cl + " " + listClient[i].P_cl);
            }
            for (int i = 0; i < listOrder.Count; i++)
            {
                comboBox2.Items.Add(listOrder[i].Date_of_conclusion);
            }
            for (int i = 0; i < listEmployee.Count; i++)
            {
                empl = listEmployee[i].S_empl + " " + listEmployee[i].N_empl + " " + listEmployee[i].P_empl;
                comboBox3.Items.Add(empl);
            }
            comboBox4.Items.Add("Выполнено");
            comboBox4.Items.Add("Не выполнено");
        }

        private string GetEMP(int id)
        {
            string empl = "";
            for (int i = 0; i < listEmployee.Count(); i++)
                if (listEmployee[i].Id_empl == id)
                {
                    return empl = listEmployee[i].S_empl + " " + listEmployee[i].N_empl + " " + listEmployee[i].P_empl;
                }
            return "";
        }

        private string GetCL(int id)
        {
            string cl = "";
            for (int i = 0; i < listClient.Count(); i++)
                if (listClient[i].Id_cl == id)
                {
                    return cl = listClient[i].S_cl + " " + listClient[i].N_cl + " " + listClient[i].P_cl;
                }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder newForm = new NewOrder();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvOR.Rows.Clear();
            DateTime q;
            DateTime qq;
            string w;
            string ww;
            for (int i = 0; i < listOrder.Count; i++)
            {
                q = Convert.ToDateTime(comboBox2.Text);
                qq = Convert.ToDateTime(listOrder[i].Date_of_conclusion);
                w = q.Year + " " + q.Month + " " + q.Day;
                ww = qq.Year + " " + qq.Month + " " + qq.Day;
                string client = listClient[i].S_cl + " " + listClient[i].N_cl + " " + listClient[i].P_cl;
                string empl = listEmployee[i].S_empl + " " + listEmployee[i].N_empl + " " + listEmployee[i].P_empl;
                if ((comboBox3.Text == GetEMP(listOrderEmpl[i].Id_empl)) && (w == ww) && (comboBox1.Text == GetCL(listOrder[i].Id_cl)) && (comboBox4.Text == listOrder[i].Readyy))
                {
                    dgvOR.Rows.Add(listOrder[i].Id_order, client, listOrder[i].Footage, listOrder[i].Date_of_conclusion, listOrder[i].Expiration_date, listOrder[i].Order_cost, listOrder[i].Readyy);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Serch newForm = new Serch();
            for (int i = 0; i < dgvOR.Rows.Count-1; i++)
            {
                newForm.comboBox1.Items.Add(dgvOR.Rows[i].Cells[0].Value);
            }
            newForm.Show();
        }
    }
}
