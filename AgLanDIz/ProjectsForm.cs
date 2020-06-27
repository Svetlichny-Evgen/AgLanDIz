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
    public partial class ProjectsForm : Form
    {
        public ProjectsForm()
        {
            InitializeComponent();
            LoadData();
            ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<Projects> listProjects = new List<Projects>();

        public List<MProjects> listMProjects = new List<MProjects>();

        public List<Materials> listMaterials = new List<Materials>();

        ClassDataBase db = new ClassDataBase();

        public void LoadData() { 
            string q = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects";
            db.Execute<Projects>("ALD_V2.db",q, ref listProjects);
            for (int i = 0; i < listProjects.Count; i++)
            {
                dgvProj.Rows.Add(listProjects[i].Name_proj, listProjects[i].Cat_proj, listProjects[i].Cost_of_work, listProjects[i].Min_square, listProjects[i].Work_time);
            }
        }

        public void ShowData(){
            for (int i = 0; i < listProjects.Count(); i++) 
            { 
                cbCat.Items.Add(listProjects[i].Cat_proj);
            }
            //cbCat.Text = listProjects[0].Cat_proj;
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aLD_V2DataSet.projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.aLD_V2DataSet.projects);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewProj newForm = new NewProj();
            newForm.Show();
        }

        private void Serch_Click(object sender, EventArgs e)
        {
            dgvProj.Rows.Clear();
            for (int i = 0; i < listProjects.Count; i++)
            {
                if ((cbCat.Text == listProjects[i].Cat_proj) && (Convert.ToDouble(cost1.Text) <= listProjects[i].Cost_of_work) && (Convert.ToDouble(cost2.Text) >= listProjects[i].Cost_of_work) && (Convert.ToInt32(square.Text) <= listProjects[i].Min_square))
                {
                    dgvProj.Rows.Add(listProjects[i].Name_proj, listProjects[i].Cat_proj, listProjects[i].Cost_of_work, listProjects[i].Min_square, listProjects[i].Work_time);
                }
            }
        }
    }
}
