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
    public partial class ajouter_abcense : Form
    {
        int taille = 0;
        string[] Mat = new string[0];
        
        public ajouter_abcense()
        {
            InitializeComponent();
           
        }
        void fill_matier()
        {
            utile.cin = 12341234;
            utile.connect();
            string req1 = "select NomMatier from assiste where Id_prof="+utile.cin+";";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            
            while (rd.Read())
            {
                taille = taille + 1;
                string Cname = rd["NomMatier"].ToString();
                bunifuDropdown1.AddItem(Cname);
             //   Array.Resize(ref Mat, taille);
               // Mat[taille - 1] = Cname;
            }
            utile.closee();
        }
        void fill_classe()
        {
            utile.connect();
            string req1 = "select id_classe from ando where nom_matier='" + bunifuDropdown1.selectedValue + "';"; 
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd["id_classe"].ToString();
                bunifuDropdown2.AddItem(Cname);

            }
            utile.closee();
        }
        void fill_etd()
        {
            utile.connect();
            string req1 = "select * from etudiant where classe='" + bunifuDropdown2.selectedValue + "';";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd2 = cmd1.ExecuteReader();
            while (rd2.Read())
            {
                string C1 = rd2["nom"].ToString();
                string C2 = rd2["prenom"].ToString();
                string C3 = rd2["cin"].ToString();
                string C = C1 + " " + C2 + " " + C3;
                checkedListBox1.Items.Add(C);

            }
            utile.closee();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ajouter_abcense_Load(object sender, EventArgs e)
        {
            fill_matier();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            bunifuDropdown2.Clear();
            fill_classe();
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            fill_etd();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            utile.connect();
            for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            {
                string[] separateurs = { " " };
                DateTime dt = Convert.ToDateTime(bunifuDatepicker1.Value);
                string temp = dt.ToShortDateString();
                string[] mots;
                mots = checkedListBox1.CheckedItems[x].ToString().Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
                 string cnstr = "insert into Abscence values (" + int.Parse(mots[2])+",'" + bunifuDropdown1.selectedValue + "','" + temp + "');";
                OleDbCommand cmd1 = new OleDbCommand(cnstr, utile.cn);
               cmd1.ExecuteNonQuery();
                
            }
            utile.closee();
            utile.pop = "Ajouter ";
            utile.up();
        }

        private void ajouter_abcense_Activated(object sender, EventArgs e)
        {
            fill_matier();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
