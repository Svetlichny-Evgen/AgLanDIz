using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Projects
    {
        private int id_proj;
        private string cat_proj;
        private string name_proj;
        private double cost_of_work;
        private int min_square;
        private int work_time;
        public int Id_proj
        { get { return id_proj; } }
        public string Cat_proj { set { cat_proj = value; } get { return cat_proj; } }
        public string Name_proj { set { name_proj = value; } get { return name_proj; } }
        public double Cost_of_work { set { cost_of_work = value; } get { return cost_of_work; } }
        public int Min_square { set { min_square = value; } get { return min_square; } }
        public int Work_time { set { work_time = value; } get { return work_time; } }
        public Projects() { id_proj = 0; cat_proj = ""; name_proj = ""; cost_of_work = 0; min_square = 0; work_time = 0; }
        public Projects(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_proj = Convert.ToInt32(val[0]); cat_proj = val[1]; name_proj = val[2]; cost_of_work = Convert.ToDouble(val[3]); min_square = Convert.ToInt32(val[4]); work_time = Convert.ToInt32(val[5]); }
        }
    }
}
