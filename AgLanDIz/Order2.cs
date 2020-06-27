using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
     public class Order2
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
        private string n_empl;
        private string s_empl;
        private string p_empl;

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
        public string N_empl { set { n_empl = value; } get { return n_empl; } }
        public string S_empl { set { s_empl = value; } get { return s_empl; } }
        public string P_empl { set { p_empl = value; } get { return p_empl; } }
        public Order2() { id_order = 0; s_cl = ""; n_cl = ""; p_cl = ""; ; footage = 0; date_of_conclusion = ""; expiration_date = ""; order_cost = 0.0; readyy = ""; n_empl = ""; s_empl = ""; p_empl = ""; }
        public Order2(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_order = Convert.ToInt32(val[0]); s_cl = val[1]; n_cl = val[2]; p_cl = val[3]; footage = Convert.ToInt32(val[4]); date_of_conclusion = val[5]; expiration_date = val[6]; order_cost = Convert.ToDouble(val[7]); readyy = val[8]; n_empl = val[9]; s_empl = val[10]; p_empl = val[11]; }
        }
    }
}
