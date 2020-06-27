using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class OrderProj
    {
        private int id_order;
        private string s_cl;
        private string n_cl;
        private string p_cl;
        private int footage;
        private string date_of_conclusion;
        private string expiration_date;
        private double order_cost;
        private string readyy;
        private int id_proj;
        private string cat_proj;
        private string name_proj;
        private double cost_of_work;
        private int min_square;
        private int work_time;

        public int Id_order
        { get { return id_order; } }
        public string S_cl { set { s_cl = value; } get { return s_cl; } }
        public string N_cl { set { n_cl = value; } get { return n_cl; } }
        public string P_cl { set { p_cl = value; } get { return p_cl; } }
        public int Footage { set { footage = value; } get { return footage; } }
        public string Date_of_conclusion { set { date_of_conclusion = value; } get { return date_of_conclusion; } }
        public string Expiration_date { set { expiration_date = value; } get { return expiration_date; } }
        public double Order_cost { set { order_cost = value; } get { return order_cost; } }
        public string Readyy { set { readyy = value; } get { return readyy; } }
        public int Id_proj { set { id_proj = value; } get { return id_proj; } }
        public string Cat_proj { set { cat_proj = value; } get { return cat_proj; } }
        public string Name_proj { set { name_proj = value; } get { return name_proj; } }
        public double Cost_of_work { set { cost_of_work = value; } get { return cost_of_work; } }
        public int Min_square { set { min_square = value; } get { return min_square; } }
        public int Work_time { set { work_time = value; } get { return work_time; } }
        public OrderProj() { id_order = 0; s_cl = ""; n_cl = ""; p_cl = ""; footage = 0; date_of_conclusion = ""; expiration_date = ""; order_cost = 0; id_proj = 0; id_proj = 0; cat_proj = ""; name_proj = ""; cost_of_work = 0; min_square = 0; work_time = 0; }
        public OrderProj(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_order = Convert.ToInt32(val[0]); s_cl = val[1]; n_cl = val[2]; p_cl = val[3]; footage = Convert.ToInt32(val[4]); date_of_conclusion = val[5]; expiration_date = val[6]; order_cost = Convert.ToDouble(val[7]); id_proj = Convert.ToInt32(val[8]); cat_proj = val[9]; name_proj = val[10]; cost_of_work = Convert.ToDouble(val[11]); min_square = Convert.ToInt32(val[12]); work_time = Convert.ToInt32(val[13]); readyy = val[14]; }
        }
    }
}
