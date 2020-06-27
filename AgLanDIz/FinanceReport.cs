using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgLanDIz
{
    public partial class FinanceReport : Form
    {
        public FinanceReport()
        {
            InitializeComponent();
            LoadData();
        }

        ClassDataBase db = new ClassDataBase();
        public List<Order> listOrder = new List<Order>();
        string year = DateTime.Now.Year.ToString();
        public void LoadData()
        {

            int yearNow = Convert.ToInt32(year);
            for (int i = 2017; i <= yearNow; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.Text = Convert.ToString(yearNow);
            comboBox2.Items.Add("Январь |1");
            comboBox2.Items.Add("Февраль |2");
            comboBox2.Items.Add("Март |3");
            comboBox2.Items.Add("Апрель |4");
            comboBox2.Items.Add("Май |5");
            comboBox2.Items.Add("Июнь |6");
            comboBox2.Items.Add("Июль |7");
            comboBox2.Items.Add("Авгест |8");
            comboBox2.Items.Add("Сентябрь |9");
            comboBox2.Items.Add("Октябрь |10");
            comboBox2.Items.Add("Ноябрь |11");
            comboBox2.Items.Add("Декабрь |12");
            //string q = @"select id_order, id_cl, footage, date_of_conclusion, expiration_date, order_cost, readyy from orderr;";
            //db.Execute<Order>("ALD_V2.db", q, ref listOrder);
           

        }
        public void Serch()
        {
            string[] val = comboBox2.Text.Split('|');
            double profit = 0;
            string q = @"select id_order, id_cl, footage, date_of_conclusion, expiration_date, order_cost, readyy from orderr where year(expiration_date) = '" + comboBox1.Text + @"'and month(expiration_date) = '" + val[1] + @"'; ";
            db.Execute<Order>("ALD_V2.db", q, ref listOrder);
            for (int i = 0; i < listOrder.Count; i++)
            {
                if (listOrder[i].Readyy == "Выполнено") 
                {
                    dataGridView1.Rows.Add(listOrder[i].Id_order, listOrder[i].Footage, listOrder[i].Date_of_conclusion, listOrder[i].Expiration_date, listOrder[i].Order_cost, listOrder[i].Readyy);
                    profit = profit + listOrder[i].Order_cost; 
                }
            }
            textBox1.Text = Convert.ToString(profit);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Serch();
            listOrder.Clear();

        }
    }
}
