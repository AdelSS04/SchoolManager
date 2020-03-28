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
    public partial class Gestion_de_matier : Form
    {
        public Gestion_de_matier()
        {
            InitializeComponent();
             fill_class();
            fill_prof();
        }


        void fill_class()
        {
            utile.connect();
            string req1 = "select id from classe ;";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd["id"].ToString();
                checkedListBox1.Items.Add(Cname);

            }
            utile.closee();
        }
        void fill_prof()
        {
            utile.connect();
            string req2 = "select * from prof ;";
            OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                string C1 = rd2["nom"].ToString();
                string C2 = rd2["prenom"].ToString();
                string C3 = rd2["cin"].ToString();
                string C = C1 + " " + C2 + " " + C3;
                checkedListBox2.Items.Add(C);

            }
            utile.closee();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            string[] separateurs = { " " };
            //string[] mots;
           // checkedListBox1.SelectedValue
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        { string tt;
            if (checkedListBox1.CheckedItems.Count != 0 && checkedListBox2.CheckedItems.Count != 0 && bunifuMaterialTextbox1.Text.Length != 0 && bunifuMaterialTextbox2.Text.Length != 0 && bunifuMaterialTextbox3.Text.Length != 0 && (checkBox1.Checked == true || (checkBox2.Checked == true)))
                
                {

                if (checkBox1.Checked == true && checkBox2.Checked == false)
                { tt = "cc"; }
                else if (checkBox2.Checked == true && checkBox1.Checked == false)
                { tt = "tp"; }
                else
                { tt = "tt"; }
                MessageBox.Show(tt);
                matier mat = new matier(int.Parse(bunifuMaterialTextbox3.Text), int.Parse(bunifuMaterialTextbox2.Text), bunifuMaterialTextbox1.Text,tt.ToString());
                mat.ajouter();
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    utile.connect();
                    string cnstr = "insert into ando values ('" + checkedListBox1.CheckedItems[x].ToString() + "','" + bunifuMaterialTextbox1.Text + "');";
                    OleDbCommand cmd1 = new OleDbCommand(cnstr, utile.cn);
                    cmd1.ExecuteNonQuery();
                    utile.closee();
                }

                for (int x = 0; x < checkedListBox2.CheckedItems.Count; x++)
                {

                    string[] separateurs = { " " };
                    string[] mots;
                    mots = checkedListBox2.CheckedItems[x].ToString().Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
                    utile.connect();
                    string cnstre = "insert into assiste values (" + int.Parse(mots[2]) + ",'" + bunifuMaterialTextbox1.Text + "');";
                    OleDbCommand cmd21 = new OleDbCommand(cnstre, utile.cn);
                    cmd21.ExecuteNonQuery();
                    utile.closee();
                }

                utile.pop = "ajouter";
                utile.up();

            

            }
            else { utile.errure_type = "il faut remplier tous les information";
                utile.er_show();
            }
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true; utile.errure_type = "entre des numero seulement";
                utile.er_show();
            }
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true; utile.errure_type = "entre des numero seulement";
                utile.er_show();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}
