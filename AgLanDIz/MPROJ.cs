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
    public partial class MPROJ : Form
    {
        public MPROJ()
        {
            InitializeComponent();
            LoadData();
        }

        ClassDataBase db = new ClassDataBase();

        List<MProjects> listMProjects = new List<MProjects>();
        List<Projects> listProjects = new List<Projects>();
        List<Materials> listMaterials = new List<Materials>();

        public void LoadData()
        {
            string q = @"select id_m, name_m, category_m, unit_of_measurement_m, quatnity_m, cost_m from materials";
            db.Execute<Materials>("ALD_V2.db", q, ref listMaterials);
            string l = @"select id_proj, cat_proj, name_proj, cost_of_work, min_square, work_time from projects";
            db.Execute<Projects>("ALD_V2.db", l, ref listProjects);
            for (int i = 0; i < listProjects.Count; i++)
            {
                comboBox1.Items.Add(listProjects[i].Name_proj);
            }
            l = @"select m.id_mat_proj, p.name_proj, ma.name_m, m.quantity_m_min_square from m_projects m join materials ma on ma.id_m = m.id_m join projects p on p.id_proj = m.id_proj";
            db.Execute<MProjects>("ALD_V2.db", l, ref listMProjects);
            for (int i = 0; i < listMProjects.Count; i++)
            {
                dataGridView1.Rows.Add(listMProjects[i].Name_proj, listMProjects[i].Name_m, listMaterials[i].Unit_of_measurement_m, listMProjects[i].Quantity_m_min_square);
            }
        }

        private void MPROJ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listMProjects.Count; i++)
            {
                if (comboBox1.Text == listMProjects[i].Name_proj)
                {
                    dataGridView1.Rows.Add(listMProjects[i].Name_proj, listMProjects[i].Name_m, listMaterials[i].Unit_of_measurement_m, listMProjects[i].Quantity_m_min_square);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
