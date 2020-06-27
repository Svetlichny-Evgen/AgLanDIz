using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Order_Empl
    {
        private int id_order;
        private int id_empl;
        public int Id_order
        { get { return id_order; } }
        public int Id_empl { set { id_empl = value; } get { return id_empl; } }
        public Order_Empl() { id_order = 0; id_empl = 0; }
        public Order_Empl(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_order = Convert.ToInt32(val[0]); id_empl = Convert.ToInt32(val[1]); }
        }
    }
}
