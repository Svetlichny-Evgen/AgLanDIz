using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Order
    {
        private int id_order;
        private int id_cl;
        private int footage;
        private string date_of_conclusion;
        private string expiration_date;
        private double order_cost;
        private string readyy;

        public int Id_order
        { get { return id_order; } }
        public int Id_cl { set { id_cl = value; } get { return id_cl; } }

        public int Footage { set { footage = value; } get { return footage; } }
        public string Date_of_conclusion { set { date_of_conclusion = value; } get { return date_of_conclusion; } }
        public string Expiration_date { set { expiration_date = value; } get { return expiration_date; } }
        public double Order_cost { set { order_cost = value; } get { return order_cost; } }
        public string Readyy { set { readyy = value; } get { return readyy; } }
        public Order() { id_order = 0; id_cl = 0; footage = 0; date_of_conclusion = ""; expiration_date = ""; order_cost = 0.0; readyy = ""; }
        public Order(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_order = Convert.ToInt32(val[0]); id_cl = Convert.ToInt32(val[1]); footage = Convert.ToInt32(val[2]); date_of_conclusion = val[3]; expiration_date = val[4]; order_cost = Convert.ToDouble(val[5]); readyy = val[6]; }
        }
    }
}
