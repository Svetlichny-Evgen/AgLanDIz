using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLanDIz
{
    public class Client
    {
        private int id_cl;
        private string s_cl;
        private string n_cl;
        private string p_cl;

        public int Id_cl
        { get { return id_cl; } }
        public string S_cl { set { s_cl = value; } get { return s_cl; } }
        public string N_cl { set { n_cl = value; } get { return n_cl; } }
        public string P_cl { set { p_cl = value; } get { return p_cl; } }
        public Client() { id_cl = 0; s_cl = ""; n_cl = ""; p_cl = ""; }
        public Client(string info)
        {
            info = info.Trim(); if (info.Length > 2) { string[] val = info.Split('!'); id_cl = Convert.ToInt32(val[0]); s_cl = val[1]; n_cl = val[2]; p_cl = val[3]; }
        }
    }
}
