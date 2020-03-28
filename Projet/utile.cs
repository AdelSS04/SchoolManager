using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Projet
{
    class utile
    { 
        static public OleDbConnection cn;
        static public string type;
        static public string pop;
        static public string errure_type, type_mat;
        static public string class_grp;
        static public int cin; static public string cl;

        static public void connect()
        {
            string cnstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =|DataDirectory|\\projet.accdb;";
            cn = new OleDbConnection(cnstr);
            cn.Open();
        }
        static public void up()
        { success sc = new success();
            sc.ShowDialog();
        }

        static public void er_show()
        {
            erure sc = new erure();
            sc.ShowDialog();
        }
        static public void closee()
        {

            cn.Close();

        }
    }
}
