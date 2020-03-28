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
    public partial class inscri_etud : Form
    {
        public inscri_etud()
        {
            InitializeComponent();
            fill_class();
            bunifuMaterialTextbox2.isPassword = true;
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
                bunifuDropdown1.AddItem(Cname);

            }
            utile.closee();
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true;
                utile.errure_type = "entre des numero seulement";
                utile.er_show(); }
        }

        private void bunifuMaterialTextbox7_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox7.Text.Length != 8)
            {
                utile.errure_type = "il faut 8 numero";
                utile.er_show();
                bunifuMaterialTextbox7.Focus();
            }
            else if (bunifuMaterialTextbox7.Text.Length == 8 && etudiant.exis(int.Parse(bunifuMaterialTextbox7.Text)) == false)

            { 
                    utile.errure_type = "cin existe"; utile.er_show(); bunifuMaterialTextbox7.Focus();
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            bunifuImageButton4.Enabled = true;
            
            

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            bunifuImageButton5.Visible = false;
            bunifuImageButton1.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = false;
            bunifuImageButton5.Visible = true;
            bunifuImageButton1.Visible = false;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        { 
        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; utile.errure_type = " entre des numero seulement";
                utile.er_show();
              
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
            if (bunifuMaterialTextbox7.Text.Length != 0 && bunifuMaterialTextbox2.Text.Length != 0 && bunifuMaterialTextbox3.Text.Length != 0 && bunifuMaterialTextbox4.Text.Length != 0 && bunifuMaterialTextbox6.Text.Length != 0 && bunifuMaterialTextbox5.Text.Length != 0 && bunifuDropdown1.selectedValue.Length !=0)
            {
                /* string req111 = "select count(*) from etudiant where classe='" + bunifuDropdown1.selectedValue + "';";
                 OleDbCommand cmd111 = new OleDbCommand(req111, utile.cn);
                 if (int.Parse(cmd111.ExecuteScalar().ToString()) >20)
                 { utile.errure_type = "Classe est plien, Max 20 etudiant"; utile.er_show(); }
                 else
                 {
                     DateTime dt = Convert.ToDateTime(bunifuDatepicker2.Value);
                     string temp = dt.ToShortDateString();
                     utile.connect();
                     string req1 = "insert into  etudiant values (" + bunifuMaterialTextbox7.Text + ",'" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "'," + bunifuMaterialTextbox6.Text + ",'" + bunifuMaterialTextbox5.Text + "','" + temp + "','" + bunifuDropdown1.selectedValue + "');";
                     //MessageBox.Show(req1);
                     OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                     cmd1.ExecuteNonQuery();
                     utile.closee();
                     utile.pop = "Ajoute";
                     utile.up();*/
                DateTime dt = Convert.ToDateTime(bunifuDatepicker2.Value);
                string temp = dt.ToShortDateString();
                etudiant etd = new etudiant(int.Parse(bunifuMaterialTextbox7.Text), bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox4.Text, int.Parse(bunifuMaterialTextbox6.Text), bunifuMaterialTextbox5.Text, temp, bunifuDropdown1.selectedValue);
                etd.ajouter();
            }
            
                
            
            else
            {
                utile.errure_type = " il faut remplire tous les information";
                utile.er_show();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
