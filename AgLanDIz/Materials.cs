using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Materials
    {
        private int id_m;
        private string name_m;
        private string category_m;
        private string unit_of_measurement_m;
        private int quatnity_m;
        private double cost_m;
        public int Id
        { get { return id_m; } }
        public string Name_m { set { name_m = value; } get { return name_m; } }
        public string Category_m { set { category_m = value; } get { return category_m; } }
        public string Unit_of_measurement_m { set { unit_of_measurement_m = value; } get { return unit_of_measurement_m; } }
        public int Quatnity_m { set { quatnity_m = value; } get { return quatnity_m; } }
        public double Cost_m { set { cost_m = value; } get { return cost_m; } }
        public Materials() { id_m = 0; name_m = ""; category_m = ""; unit_of_measurement_m = ""; quatnity_m = 0; cost_m = 0; }
        public Materials(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_m = Convert.ToInt32(val[0]); name_m = val[1]; category_m = val[2]; unit_of_measurement_m = val[3]; quatnity_m = Convert.ToInt32(val[4]); cost_m = Convert.ToDouble(val[5]); }
        }
    }
}
