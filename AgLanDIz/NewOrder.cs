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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            LoadData();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            DateTime date2 = new DateTime();
            string dater2 = date.ToShortDateString();
        }

        public List<Projects> listProjects = new List<Projects>();

        public List<Client> listClient = new List<Client>();

        public List<Order> listOrder = new List<Order>();

        public List<Employee> listEmployee = new List<Employee>();


        ClassDataBase db = new ClassDataBase();

        public void LoadData()
        {
            string q = @"select id_empl, n_empl, s_empl, p_empl, exper from employee;";
            db.Execute<Employee>("ALD_V2.db", q, ref listEmployee);
            string epl = "";
            for (int i = 0; i < listEmployee.Count; i++)
            {
                epl = listEmployee[i].S_empl + " " + listEmployee[i].N_empl + " " + listEmployee[i].P_empl;
                cbEmpl.Items.Add(epl);
            }
        }

        private int GetIDCl(string clN, string clS, string clP)
        {
            for (int i = 0; i < listClient.Count(); i++)
                if (listClient[i].N_cl == clN && listClient[i].S_cl == clS && listClient[i].P_cl == clP)
                { return listClient[i].Id_cl; }
            return -1;
        }

        private int GetIDE(string eee)
        {
            string[] empl = eee.Split(' ');
            for (int i = 0; i < listEmployee.Count(); i++)
                if (listEmployee[i].S_empl == empl[0].Trim() && listEmployee[i].N_empl == empl[1].Trim() && listEmployee[i].P_empl == empl[2].Trim())
                { return listEmployee[i].Id_empl; }
            return -1;
        }

        //private string WR()
        //{
        //    DateTime curr_data = DateTime.Now;
        //    string q = "";
        //    if (dateTimePicker2.Value.Date <= curr_data) { q = @"UPDATE orderr SET ready = '" + "Не выполнено" + @"' WHERE expiration_date<=CURDATE();"; }
        //    else q = @"UPDATE orderr SET readyy = '"+"Выполнено"+ @"' WHERE expiration_date>=CURDATE();";
        //    return q; 
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            double OC = 0;
            string readyy = "Не выполнено";
            ClassDataBase db = new ClassDataBase();
            string qq = @"insert into clientt(s_cl, n_cl, p_cl) values ('" + clF.Text + @"','" + clN.Text + @"','" + clP.Text + @"')";
            db.ExecuteNonQuery("ALD_V2.db", qq, 0);
            string qq2 = @"select id_cl, s_cl, n_cl, p_cl from clientt order by id_cl desc limit 1;";
            db.Execute<Client>("ALD_V2.db", qq2, ref listClient);
            string qqq = @"insert into orderr(id_cl, footage, date_of_conclusion, expiration_date, order_cost, readyy) values (" + listClient[0].Id_cl + @"," + ordSq.Text + @",'" + dateTimePicker1.Text + @"','" + dateTimePicker2.Text + @"'," + OC + @",'" + readyy + @"');";
            db.ExecuteNonQuery("ALD_V2.db", qqq, 0);
            listOrder.Clear();
            string qqq2 = @"select id_order, id_cl, footage, date_of_conclusion, expiration_date, order_cost, readyy from orderr order by id_cl desc limit 1;";
            db.Execute<Order>("ALD_V2.db", qqq2, ref listOrder);
            string qqq3 = @"insert into order_empl(id_order,id_empl) values ('" + listOrder[0].Id_order + @"','" + GetIDE(cbEmpl.Text.Trim()) + @"')";
            db.ExecuteNonQuery("ALD_V2.db", qqq3, 0);
            OrdersProjects newForm = new OrdersProjects();
            newForm.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
