using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class MProjects
    {
        private int id_mat_proj;
        private string name_proj;
        private string name_m;
        private int quantity_m_min_square;
        public int Id_mat_proj { get { return id_mat_proj; } }
        public string Name_proj { set { name_proj = value; } get { return name_proj; } }
        public string Name_m { set { name_m = value; } get { return name_m; } }
        public int Quantity_m_min_square { set { quantity_m_min_square = value; } get { return quantity_m_min_square; } }
        public MProjects() { id_mat_proj = 0; name_proj = ""; name_m = ""; quantity_m_min_square = 0;}
        public MProjects(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_mat_proj = Convert.ToInt32(val[0]); name_proj = val[1]; name_m = val[2]; quantity_m_min_square = Convert.ToInt32(val[3]); }
        }
    }
}
