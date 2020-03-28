using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet
{
    public partial class mes_absence : Form
    {
        public mes_absence()
        {
            InitializeComponent();
        }

        void fill_matier()
        {
            //  utile.cin = 12341234;

            utile.connect();
            string req1 = "select nom_matier from ando where id_classe='" + utile.cl + "';";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();

            while (rd.Read())
            {
               // taille = taille + 1;
                string Cname = rd["nom_matier"].ToString();
                ChMat.AddItem(Cname);
                //   Array.Resize(ref Mat, taille);
                // Mat[taille - 1] = Cname;
            }
            utile.closee();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChMat_onItemSelected(object sender, EventArgs e)
        {
            utile.connect();
            string req = "select count(*) from Abscence where id_etud=" + utile.cin + " and nom_matiere ='" + ChMat.selectedValue +"' ;";
            OleDbCommand cmd12 = new OleDbCommand(req, utile.cn);
            
            bunifuMaterialTextbox1.Text = cmd12.ExecuteScalar().ToString();
            string req1 = "select *  from matiere where nom ='" + ChMat.selectedValue + "' ;";
            OleDbCommand cmd11 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd11 = cmd11.ExecuteReader();
         //   MessageBox.Show(cmd12.ExecuteScalar().ToString());
            while (rd11.Read())
            { string cc = rd11["Nbr_LimAbs"].ToString();
                if (int.Parse(cc) > int.Parse(cmd12.ExecuteScalar().ToString()))
                { bunifuMaterialTextbox2.Text = "Valide"; }
                else
                    bunifuMaterialTextbox2.Text = "Elimine";

            }
        }

        private void ChMat_Load(object sender, EventArgs e)
        {
            fill_matier();
        }
    }
}
