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
    public partial class mes_note : Form
    {
        public mes_note()
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

            private void ChMat_onItemSelected(object sender, EventArgs e)
        {if (note.exis(utile.cin, ChMat.selectedValue) == 1)
            {
                note nono = note.rech(utile.cin, ChMat.selectedValue);
                if (nono != null)
                {
                    bunifuMaterialTextbox1.Text = nono.ds.ToString();
                    bunifuMaterialTextbox2.Text = nono.ex.ToString();
                    bunifuMaterialTextbox3.Text = nono.test.ToString();
                    bunifuMaterialTextbox4.Text = nono.tp.ToString();
                }
                    
                    // bunifuMaterialTextbox2.Text = "Elimine";

               
                utile.closee();
            }
        else
            {
                bunifuMaterialTextbox1.Text = "NA";
                bunifuMaterialTextbox2.Text = "NA";
                bunifuMaterialTextbox3.Text = "NA";
                bunifuMaterialTextbox4.Text = "NA";
            }

            
        }

        private void mes_note_Load(object sender, EventArgs e)
        {
            fill_matier();
        }
    }
}
