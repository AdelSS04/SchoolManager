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
    public partial class cree_nv_user : Form
    {
        public cree_nv_user()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; MessageBox.Show("entre des numero seulement"); }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; MessageBox.Show("entre des numero seulement"); }
        }

       /* private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {if (checkBox1.Checked)
            { textBox2.UseSystemPasswordChar = false; }
        else
            { textBox2.UseSystemPasswordChar = true; }
        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cree_nv_user_Load(object sender, EventArgs e)
        {
          //  textBox2.UseSystemPasswordChar = true;
           /* if (utile.type.CompareTo("etudiant") == 0)
            { EspaceEtudiant.Enabled = true; }
            else if (utile.type.CompareTo("prof") == 0) { EspaceProf.Enabled = true; }
            else if (utile.type.CompareTo("chef") == 0) { menuadmin.Enabled = true; }
            else if (utile.type.CompareTo("administrateur") == 0)
            {
                menuadmin.Enabled = true;
                espaceAdminToolStripMenuItem.Enabled = true;
            }

    */
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

       /* private void textBox1_Leave(object sender, EventArgs e)
        {

            // OleDbDataReader rd11 = cmd11.ExecuteReader(); 
            if (textBox1.Text.Length != 8 && textBox1.ReadOnly==false)
            {
                MessageBox.Show("il faut 8 numero");
                textBox1.Focus();
            }
            else if (textBox1.Text.Length == 8)

            {
                utile.connect();
                string req11 = "select count(*) from administrateur where cin=" + int.Parse(textBox1.Text) + ";";
                OleDbCommand cmd11 = new OleDbCommand(req11, utile.cn);
                string req12 = "select count(*) from prof where cin=" + int.Parse(textBox1.Text) + ";";
                OleDbCommand cmd12 = new OleDbCommand(req12, utile.cn);
                string req13 = "select count(*) from etudiant where cin=" + int.Parse(textBox1.Text) + ";";
                OleDbCommand cmd13 = new OleDbCommand(req13, utile.cn);
                string req14 = "select count(*) from chef where cin=" + int.Parse(textBox1.Text) + ";";
                OleDbCommand cmd14 = new OleDbCommand(req14, utile.cn);
                if (int.Parse(cmd11.ExecuteScalar().ToString()) == 1 || int.Parse(cmd12.ExecuteScalar().ToString()) == 1 || int.Parse(cmd13.ExecuteScalar().ToString()) == 1 || int.Parse(cmd14.ExecuteScalar().ToString()) == 1 )
                {
                    MessageBox.Show("cin existe");
                    textBox1.Focus();
                }
            }

        }
        */
       /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.ReadOnly = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }*/

       /* private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox6.Text.Length != 0 && textBox5.Text.Length != 0)
            {
                utile.connect();
                string req1 = "insert into  " +comboBox1.Text +" values (" + textBox1.Text +",'" +textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + dateTimePicker1.Text + "');";
                OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                cmd1.ExecuteNonQuery();
                utile.closee();
                MessageBox.Show("ajoute !!");
            }
            else
                MessageBox.Show("verifier voytre saise !!");

        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = false;
            bunifuImageButton5.Visible = true;
            bunifuImageButton1.Visible = false;

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            bunifuImageButton5.Visible = false;
            bunifuImageButton1.Visible = true;

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            bunifuImageButton4.Enabled = true;
            bunifuMaterialTextbox1.Enabled = true;
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox6.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox3.Text = "";


        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; MessageBox.Show("entre des numero seulement"); }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.Length != 8 )
            {
                utile.errure_type = "il faut 8 numero"; utile.er_show();
                bunifuMaterialTextbox1.Focus();
            }
            else if (bunifuMaterialTextbox1.Text.Length == 8)

            {
               
                if (!etudiant.exis(int.Parse(bunifuMaterialTextbox1.Text) ))
                {
                    utile.errure_type = "cin existe"; utile.er_show();
                    bunifuMaterialTextbox1.Focus();
                }
            }
            }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; MessageBox.Show("entre des numero seulement"); }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.Length != 0 && bunifuMaterialTextbox2.Text.Length != 0 && bunifuMaterialTextbox3.Text.Length != 0 && bunifuMaterialTextbox4.Text.Length != 0 && bunifuMaterialTextbox6.Text.Length != 0 && bunifuMaterialTextbox5.Text.Length != 0)
            {
                DateTime dt = Convert.ToDateTime(bunifuDatepicker2.Value);
                string temp = dt.ToShortDateString();
                utile.connect();
                string req1 = "insert into  " + bunifuDropdown1.selectedValue + " values (" + bunifuMaterialTextbox1.Text + ",'" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "'," + bunifuMaterialTextbox6.Text + ",'" + bunifuMaterialTextbox5.Text + "','" + temp + "');";
                //MessageBox.Show(req1);
                OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                cmd1.ExecuteNonQuery();
                utile.closee();
                utile.pop = "Ajoute";
                utile.up();
            }
            else
            {
                utile.errure_type = " il faut remplire tous les information";
                utile.er_show();
            }


        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
