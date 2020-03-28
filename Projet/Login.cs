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
using Bunifu.Framework.UI;

namespace Projet
{
    public partial class Login : Form
    {
        public Login()
        {
           
            this.BackgroundImage = Properties.Resources.login;
            InitializeComponent();
           
        }
        /*void timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im);
            lisimage.Add(Properties.Resources.rite);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }*/
        private void Login_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            //PassBox.UseSystemPasswordChar = true;
            //bunifuTextbox2.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
        {
           /* if (comboBox1.Text == "administrateur")
            {
                utile.connect();
                string req1 = "select count(*) from administrateur where cin=" + int.Parse(LoginBox.Text) + " and pass='" + PassBox.Text + "';";
                OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                //OleDbDataReader rd = cmd1.ExecuteReader(); //rd.Read();
                if (int.Parse(cmd1.ExecuteScalar().ToString()) == 1)
                {
                    utile.type = comboBox1.Text.ToString();
                    Home fr = new Home();
                    fr.ShowDialog();


                }
                else
                {
                    MessageBox.Show("verifie votre login");

                }
            }
            else if (comboBox1.Text == "prof")
            {
                utile.connect();
                string req2 = "select count(*) from prof where cin=" + int.Parse(LoginBox.Text) + " and pass='" + PassBox.Text + "';";
                OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
                //OleDbDataReader rd2 = cmd2.ExecuteReader(); rd2.Read();
                if (int.Parse(cmd2.ExecuteScalar().ToString()) == 1)
                {
                    utile.type = comboBox1.Text.ToString();
                    Home fr = new Home();
                    fr.ShowDialog();
                    //utile.type = comboBox1.Text.ToString();

                }
                else
                {
                    MessageBox.Show("verifie votre login");

                }
            }
            else if (comboBox1.Text == "chef")
            {
                utile.connect();
                string req3 = "select count(*) from chef where cin=" + int.Parse(LoginBox.Text) + " and pass='" + PassBox.Text + "';";
                OleDbCommand cmd3 = new OleDbCommand(req3, utile.cn);
                //OleDbDataReader rd3 = cmd3.ExecuteReader();  rd3.Read();
                if (int.Parse(cmd3.ExecuteScalar().ToString()) == 1)
                {

                    utile.type = comboBox1.Text.ToString();
                    Home fr = new Home();
                    fr.ShowDialog();
                    //utile.type = comboBox1.Text.ToString();
                }
                else
                {
                    MessageBox.Show("verifie votre login");

                }
            }
            else if (comboBox1.Text == "etudiant")
            {
                utile.connect();
                string req4 = "select count(*) from etudiant where cin=" + int.Parse(LoginBox.Text) + " and pass='" + PassBox.Text + "';";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
               // OleDbDataReader rd4 = cmd4.ExecuteReader(); rd4.Read();
                if (int.Parse(cmd4.ExecuteScalar().ToString()) == 1)
                {
                    utile.type = comboBox1.Text.ToString();
                    Home fr = new Home();
                    fr.ShowDialog();
                    //utile.type = comboBox1.Text.ToString();

                }
                else
                {
                    MessageBox.Show("verifie votre login");

                }
            }

            else { MessageBox.Show("verifie les saisie"); }*/
        } 


        
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true;
                utile.errure_type = "entre des numero seulement";
                utile.er_show();
                // MessageBox.Show("entre des numero seulement"); 
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; utile.errure_type = "entre des numero seulement";
                utile.er_show(); }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

     

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
           if (bunifuDropdown1.selectedValue.ToString() == "administrateur")
            {/* 
                if (bunifuMaterialTextbox2.Text == "" || bunifuMaterialTextbox1.Text == "")
                {
                    bunifuMaterialTextbox2.Text = " ";
                    bunifuMaterialTextbox1.Text = "1";
                }*/

                utile.connect();
                
                    string req1 = "select count(*) from administrateur where cin=" + int.Parse(bunifuMaterialTextbox1.Text) + " and pass='" + bunifuMaterialTextbox2.Text + "';";
                OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                //OleDbDataReader rd = cmd1.ExecuteReader(); //rd.Read();
                if (int.Parse(cmd1.ExecuteScalar().ToString()) == 1)
                {
                    utile.type = bunifuDropdown1.selectedValue.ToString().ToString();
                    utile.cin = int.Parse(bunifuMaterialTextbox1.Text);

                    Home fr = new Home();
                    fr.ShowDialog();


                }
                else
                {
                    utile.errure_type = "verifie votre login";
                    utile.er_show();

                }
            }
            else if (bunifuDropdown1.selectedValue.ToString() == "prof")
            {
                utile.connect();
                string req2 = "select count(*) from prof where cin=" + int.Parse(bunifuMaterialTextbox1.Text) + " and pass='" + bunifuMaterialTextbox2.Text + "';";
                OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
                //OleDbDataReader rd2 = cmd2.ExecuteReader(); rd2.Read();
                if (int.Parse(cmd2.ExecuteScalar().ToString()) == 1)
                {
                    utile.cin = int.Parse(bunifuMaterialTextbox1.Text);
                    utile.type = bunifuDropdown1.selectedValue.ToString().ToString();
                    Home fr = new Home();
                    fr.ShowDialog();
                    utile.cin = int.Parse(bunifuMaterialTextbox1.Text);
                    //utile.type = bunifuDropdown1.selectedValue.ToString().ToString();

                }
                else
                {
                    utile.errure_type = "verifie votre login";
                    utile.er_show();

                }
            }
            else if (bunifuDropdown1.selectedValue.ToString() == "chef")
            {
                utile.connect();
                string req3 = "select count(*) from chef where cin=" + int.Parse(bunifuMaterialTextbox1.Text) + " and pass='" + bunifuMaterialTextbox2.Text + "';";
                OleDbCommand cmd3 = new OleDbCommand(req3, utile.cn);
                //OleDbDataReader rd3 = cmd3.ExecuteReader();  rd3.Read();
                if (int.Parse(cmd3.ExecuteScalar().ToString()) == 1)
                {

                    utile.type = bunifuDropdown1.selectedValue.ToString().ToString();
                    Home fr = new Home();
                    fr.ShowDialog();
                    utile.cin = int.Parse(bunifuMaterialTextbox1.Text);
                    //utile.type = bunifuDropdown1.selectedValue.ToString().ToString();
                }
                else
                {
                    utile.errure_type = "verifie votre login1";
                    utile.er_show();

                }
            }
            else if (bunifuDropdown1.selectedValue.ToString() == "etudiant")
            {
                utile.connect();
                string req4 = "select count(*) from etudiant where cin=" + int.Parse(bunifuMaterialTextbox1.Text) + " and pass='" + bunifuMaterialTextbox2.Text + "';";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                // OleDbDataReader rd4 = cmd4.ExecuteReader(); rd4.Read();
                if (int.Parse(cmd4.ExecuteScalar().ToString()) == 1)
                {
                    utile.cin = int.Parse(bunifuMaterialTextbox1.Text);
                    utile.type = bunifuDropdown1.selectedValue.ToString().ToString();

                    string req1 = "select* from etudiant where cin=" + int.Parse(bunifuMaterialTextbox1.Text) + " and pass='" + bunifuMaterialTextbox2.Text + "';";
                    OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                   
                    OleDbDataReader rd11 = cmd1.ExecuteReader();
                    //   MessageBox.Show(cmd12.ExecuteScalar().ToString());
                    while (rd11.Read())
                    { utile.cl = rd11["classe"].ToString(); }
                        Home fr = new Home();
                    fr.ShowDialog();
                    
                    
                    //utile.type = bunifuDropdown1.selectedValue.ToString().ToString();

                }
                else
                {
                    utile.errure_type = "verifie votre login";
                    utile.er_show();

                }
            }

            else/* if (bunifuDropdown1.selectedValue == -1)*/{
                utile.errure_type = "verifie votre login";
                utile.er_show();
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

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


       

        

        private void bunifuMaterialTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
         //   bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text.Length != 8)
            {
                utile.errure_type = "Il faut entre 8 numero";
                utile.er_show();
                bunifuMaterialTextbox1.Focus();
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            //bunifuMaterialTextbox2.isPassword = true; 


        }

        private void bunifuMaterialTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bunifuMaterialTextbox2.isPassword = true;
            

        }
    }
    }
   

