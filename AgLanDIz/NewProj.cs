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
    public partial class NewProj : Form
    {
        public NewProj()
        {
            InitializeComponent();
        }
        public List<Projects> listProj1 = new List<Projects>();

        public List<Projects> listProj = new List<Projects>();

        public List<MProjects> listMProj = new List<MProjects>();

        public List<Materials> listMat = new List<Materials>();
        ClassDataBase db1 = new ClassDataBase();

        public void MCost()
        {
            for (int i = 0; i < listProj.Count; i++)
            {
                for (int j = 0; j < listMProj.Count; j++)
                {
                    if (listProj[i].Name_proj == listMProj[j].Name_proj)
                    {
                        for (int k = 0; k < listMat.Count; k++)
                            if (listMProj[j].Name_m == listMat[k].Name_m)
                            {
                                listProj[i].Cost_of_work = listMat[k].Cost_m + listProj[i].Cost_of_work;
                                break;
                            }
                    }
                }
            }
        }

        public void LoadData()
        {
            string l = @"select id_m, name_m, category_m, unit_of_measurement_m, quatnity_m, cost_m from materials";
            db1.Execute<Materials>("ALD_V2.db", l, ref listMat);
            for (int i = 0; i < listMat.Count; i++)
            {
                cbNM.Items.Add(listMat[i].Name_m);
            }
            l = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects";
            db1.Execute<Projects>("ALD_V2.db", l, ref listProj);
            l = @"select m.id_mat_proj, p.name_proj, ma.name_m, m.quantity_m_min_square from m_projects m join materials ma on ma.id_m = m.id_m join projects p on p.id_proj = m.id_proj";
            db1.Execute<MProjects>("ALD_V2.db", l, ref listMProj);
        }

        private int GetIDM(string mat)
        {
            for (int i = 0; i < listMat.Count(); i++)
                if (listMat[i].Name_m == mat ) { return listMat[i].Id; }
            return -1;
        }

        private int GetIDP(string proj)
        {
            for (int i = 0; i < listProj.Count(); i++)
                if (listProj[i].Name_proj == proj) { return listProj[i].Id_proj; }
            return -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNameP.Text == "" || tbCatP.Text == "" || tbMinS.Text == "" || tbTimeWork.Text == "" || tbCostWork.Text == "") { MessageBox.Show("Одно из полей не заполнено"); return; }

            ClassDataBase db = new ClassDataBase();

            string qq = @"insert into projects(name_proj, cat_proj, min_square, work_time, cost_of_work) values ('"+ tbNameP.Text+ @"','" + tbCatP.Text +@"','" + tbMinS.Text + @"','" + tbTimeWork.Text + @"','" + tbCostWork.Text + @"')";

            db.ExecuteNonQuery("ALD_V2.db", qq, 0);
            string ll = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects order by id_proj desc limit 1;";
            db1.Execute<Projects>("ALD_V2.db", ll, ref listProj1);
        }

        private void NewProj_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = @"insert into m_projects(id_proj,id_m,quantity_m_min_square) values(" + listProj1[0].Id_proj +@"," + Convert.ToString(GetIDM(cbNM.Text)) + @", " + Convert.ToInt32(tbQuantity.Text) + @")";
            db1.ExecuteNonQuery("ALD_V2.db", q, 0);
            listProj1.Clear();
            string ll = @"select max(id_proj), cat_proj, name_proj, cost_of_work, min_square, work_time from projects;";
            db1.Execute<Projects>("ALD_V2.db", ll, ref listProj1);
            double TCost = 0;
            for (int i = 0; i < listMat.Count; i++) 
            {
                if (listMat[i].Id == GetIDM(cbNM.Text))
                {
                    TCost = listMat[i].Cost_m * Convert.ToInt32(tbQuantity.Text);
                }
            }
            ll = @"UPDATE projects SET cost_of_work = cost_of_work +'" + TCost + @"' WHERE id_proj = '"+ listProj1[0].Id_proj +@"'";
            db1.ExecuteNonQuery("ALD_V2.db", ll, 0);
        }
    }
}
