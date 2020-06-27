using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Employee
    {
        private int id_empl;
        private string n_empl;
        private string s_empl;
        private string p_empl;
        private int exper;

        public int Id_empl
        { get { return id_empl; } }
        public string N_empl { set { n_empl = value; } get { return n_empl; } }
        public string S_empl { set { s_empl = value; } get { return s_empl; } }
        public string P_empl { set { p_empl = value; } get { return p_empl; } }
        public int Exper { set { exper = value; } get { return exper; } }
        public Employee() { id_empl = 0; n_empl = ""; s_empl = ""; p_empl = ""; exper = 0; }
        public Employee(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_empl = Convert.ToInt32(val[0]); n_empl = val[1]; s_empl = val[2]; p_empl = val[3]; exper = Convert.ToInt32(val[4]); }
        }
    }
}
