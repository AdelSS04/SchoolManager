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
    public partial class gerer_les_utilisateurs : Form
    {
        public gerer_les_utilisateurs()
        {
            InitializeComponent();
            FillCombo1_etud();
            
        }
       void FillCombo1_etud()
        {
            utile.connect();
            string req1 = "select id from classe ;";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd["id"].ToString();
                bunifuDropdown2.AddItem(Cname);

            }
            utile.closee();
            
        }
        void FillCombo_admin()
            {
            utile.connect();
            
            string req2 = "select * from administrateur ;";
            OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                string Uname = rd2["nom"].ToString();
                string U1name = rd2["prenom"].ToString();
                string U2name = rd2["cin"].ToString();
                string U3 = Uname + ' ' + U1name + ' ' + U2name;
                bunifuDropdown3.AddItem(U3);

            }
            rd2 = null; 
            utile.closee();
        }
        void FillCombo_chef()
        {
            utile.connect();

            string req2 = "select * from chef ;";
            OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                string Uname = rd2["nom"].ToString();
                string U1name = rd2["prenom"].ToString();
                string U2name = rd2["cin"].ToString();
                string U3 = Uname + ' ' + U1name + ' ' + U2name;
                bunifuDropdown3.AddItem(U3);

            }
            rd2 = null;
            utile.closee();
        }
        void FillCombo_prof()
        {
            utile.connect();

            string req2 = "select * from prof ;";
            OleDbCommand cmd2 = new OleDbCommand(req2, utile.cn);
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                string Uname = rd2["nom"].ToString();
                string U1name = rd2["prenom"].ToString();
                string U2name = rd2["cin"].ToString();
                string U3 = Uname + ' ' + U1name + ' ' + U2name;
                bunifuDropdown3.AddItem(U3);

            }
            rd2 = null;
            utile.closee();
        }

        void FillCombo2_etud()
        {
            utile.connect();

            string req3 = "select * from etudiant where classe='" + bunifuDropdown2.selectedValue + "';";
            OleDbCommand cmd3 = new OleDbCommand(req3, utile.cn);
            OleDbDataReader rd3= cmd3.ExecuteReader();
            while (rd3.Read())
            {
                string Vname = rd3["nom"].ToString();
                string V1name = rd3["prenom"].ToString();
                string V2name = rd3["cin"].ToString();
                string V3 = Vname +' ' +  V1name +' '+ V2name;
                bunifuDropdown3.AddItem(V3);

            }
            rd3 = null;
            utile.closee();
        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

      

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(50000000);
        }
        /*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timer1.Start();
            if (this.comboBox1.Text== "etudiant") { this.comboBox2.Visible = true;
                this.label6.Visible = true;
                this.progressBar2.Visible = true;
                this.ChercheButton.Enabled = true;
                this.textBox5.ReadOnly = false;

                this.label7.Visible = false;
                this.label8.Visible = false;
                this.comboBox3.Visible = false;
               // this.textBox5.Visible = false;
              //  this.ChercheButton.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.textBox4.Visible = false;
                this.ModifButoon.Visible = false;
                this.SuppButton.Visible = false;
                this.SauvButton.Visible = false;
                this.SauvButton.Enabled = false;
            }

            else if   (this.comboBox1.Text == "administrateur")
                {
               comboBox3.Items.Clear();
                FillCombo_admin();
                this.ChercheButton.Enabled = true;
                this.textBox5.ReadOnly = false;
                this.label7.Visible = true;
                this.label8.Visible = true;
                this.comboBox3.Visible = true;
                this.textBox5.Visible = true;
                this.ChercheButton.Visible = true;

                this.comboBox2.Visible = false;
                this.label6.Visible = false;
                this.progressBar2.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.textBox4.Visible = false;
                this.ModifButoon.Visible = false;
                this.SuppButton.Visible = false;
                this.SauvButton.Visible = false;
                
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.SauvButton.Enabled = false;
            }
           
            else if (this.comboBox1.Text == "prof")
            {
                comboBox3.Items.Clear();
                FillCombo_prof();
                this.label7.Visible = true;
                this.label8.Visible = true; this.ChercheButton.Enabled = true;
                this.textBox5.ReadOnly = false;
                this.comboBox3.Visible = true;
                this.textBox5.Visible = true;
                this.ChercheButton.Visible = true;

                this.comboBox2.Visible = false;
                this.label6.Visible = false;
                this.progressBar2.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.textBox4.Visible = false;
                this.ModifButoon.Visible = false;
                this.SuppButton.Visible = false;
                this.SauvButton.Visible = false;

                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.SauvButton.Enabled = false;
            }
            else if (this.comboBox1.Text == "chef")
            {
                comboBox3.Items.Clear();
                FillCombo_chef();
                this.label7.Visible = true; this.ChercheButton.Enabled = true;
                this.textBox5.ReadOnly = false;
                this.label8.Visible = true;
                this.comboBox3.Visible = true;
                this.textBox5.Visible = true;
                this.ChercheButton.Visible = true;

                this.comboBox2.Visible = false;
                this.label6.Visible = false;
                this.progressBar2.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.textBox4.Visible = false;
                this.ModifButoon.Visible = false;
                this.SuppButton.Visible = false;
                this.SauvButton.Visible = false;

                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.SauvButton.Enabled = false;
            }
        }
        */
        /*
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          

           this.timer2.Start();
            comboBox3.Items.Clear();
            FillCombo2_etud();
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.comboBox3.Visible = true;
            this.textBox5.Visible = true;
            this.ChercheButton.Visible = true;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.ModifButoon.Visible = false;
            this.SuppButton.Visible = false;
            this.SauvButton.Visible = false;
           
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;
            this.SauvButton.Enabled = false;
        }
        */
        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.progressBar2.Increment(5000);
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        /*
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.ModifButoon.Visible = true;
            this.SuppButton.Visible = true;
            this.SauvButton.Visible = true;
            
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;
            this.SauvButton.Enabled = false;

            string[] separateurs = { " "};
            string[] mots; 
            mots = comboBox3.Text.Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
            utile.connect();
            if (comboBox1.Text == "etudiant")
            {
                string req4 = "select * from etudiant where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    textBox1.Text = rd4["cin"].ToString();
                    textBox2.Text = rd4["pass"].ToString();
                    textBox3.Text = rd4["nom"].ToString();
                    textBox4.Text = rd4["prenom"].ToString();
                }
                utile.closee();
            }
            else if  (comboBox1.Text == "administrateur") {
                string req4 = "select * from administrateur where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    textBox1.Text = rd4["cin"].ToString();
                    textBox2.Text = rd4["pass"].ToString();
                    textBox3.Text = rd4["nom"].ToString();
                    textBox4.Text = rd4["prenom"].ToString();
                }
                utile.closee();
            }
            else if (comboBox1.Text == "prof")
            {
                string req4 = "select * from prof where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    textBox1.Text = rd4["cin"].ToString();
                    textBox2.Text = rd4["pass"].ToString();
                    textBox3.Text = rd4["nom"].ToString();
                    textBox4.Text = rd4["prenom"].ToString();
                }
                utile.closee();
            }
            else if (comboBox1.Text == "chef")
            {
                string req4 = "select * from chef where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    textBox1.Text = rd4["cin"].ToString();
                    textBox2.Text = rd4["pass"].ToString();
                    textBox3.Text = rd4["nom"].ToString();
                    textBox4.Text = rd4["prenom"].ToString();
                }
                utile.closee();
            }
        }
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        
        /*
        private void ChercheButton_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "etudiant")
            {
                utile.connect();
                string req6 = "select count(*) from etudiant where cin=" + textBox5.Text + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {
                    this.label2.Visible = true;
                    this.label3.Visible = true;
                    this.label4.Visible = true;
                    this.label5.Visible = true;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    this.textBox3.Visible = true;
                    this.textBox4.Visible = true;
                    this.ModifButoon.Visible = true;
                    this.SuppButton.Visible = true;
                    this.SauvButton.Visible = true;

                    this.textBox2.ReadOnly = true;
                    this.textBox3.ReadOnly = true;
                    this.textBox4.ReadOnly = true;
                    this.SauvButton.Enabled = false;
                    string req7 = "select * from etudiant where cin=" + int.Parse(textBox5.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        textBox1.Text = rd7["cin"].ToString();
                        textBox2.Text = rd7["pass"].ToString();
                        textBox3.Text = rd7["nom"].ToString();
                        textBox4.Text = rd7["prenom"].ToString();
                    }
                    utile.closee();
                }
                utile.closee();
            }

            if (comboBox1.Text == "administrateur")
            {
                utile.connect();
                string req6 = "select count(*) from administrateur where cin=" + int.Parse(textBox5.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {
                    this.label2.Visible = true;
                    this.label3.Visible = true;
                    this.label4.Visible = true;
                    this.label5.Visible = true;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    this.textBox3.Visible = true;
                    this.textBox4.Visible = true;
                    this.ModifButoon.Visible = true;
                    this.SuppButton.Visible = true;
                    this.SauvButton.Visible = true;

                    this.textBox2.ReadOnly = true;
                    this.textBox3.ReadOnly = true;
                    this.textBox4.ReadOnly = true;
                    this.SauvButton.Enabled = false;
                    string req7 = "select * from administrateur where cin=" + int.Parse(textBox5.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        textBox1.Text = rd7["cin"].ToString();
                        textBox2.Text = rd7["pass"].ToString();
                        textBox3.Text = rd7["nom"].ToString();
                        textBox4.Text = rd7["prenom"].ToString();
                    }
                    utile.closee();
                }
                utile.closee();
            }

            if (comboBox1.Text == "prof")
            {
                utile.connect();
                string req6 = "select count(*) from prof where cin=" + int.Parse(textBox5.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {
                    this.label2.Visible = true;
                    this.label3.Visible = true;
                    this.label4.Visible = true;
                    this.label5.Visible = true;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    this.textBox3.Visible = true;
                    this.textBox4.Visible = true;
                    this.ModifButoon.Visible = true;
                    this.SuppButton.Visible = true;
                    this.SauvButton.Visible = true;

                    this.textBox2.ReadOnly = true;
                    this.textBox3.ReadOnly = true;
                    this.textBox4.ReadOnly = true;
                    this.SauvButton.Enabled = false;
                    string req7 = "select * from prof where cin=" + int.Parse(textBox5.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        textBox1.Text = rd7["cin"].ToString();
                        textBox2.Text = rd7["pass"].ToString();
                        textBox3.Text = rd7["nom"].ToString();
                        textBox4.Text = rd7["prenom"].ToString();
                    }
                    utile.closee();
                }
                utile.closee();
            }

            else if (comboBox1.Text == "chef")
            {
                utile.connect();
                string req6 = "select count(*) from chef where cin=" + int.Parse(textBox5.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {
                    this.label2.Visible = true;
                    this.label3.Visible = true;
                    this.label4.Visible = true;
                    this.label5.Visible = true;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    this.textBox3.Visible = true;
                    this.textBox4.Visible = true;
                    this.ModifButoon.Visible = true;
                    this.SuppButton.Visible = true;
                    this.SauvButton.Visible = true;

                    this.textBox2.ReadOnly = true;
                    this.textBox3.ReadOnly = true;
                    this.textBox4.ReadOnly = true;
                    this.SauvButton.Enabled = false;
                    string req7 = "select * from chef where cin=" + int.Parse(textBox5.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        textBox1.Text = rd7["cin"].ToString();
                        textBox2.Text = rd7["pass"].ToString();
                        textBox3.Text = rd7["nom"].ToString();
                        textBox4.Text = rd7["prenom"].ToString();
                    }
                    utile.closee();
                }
                utile.closee();
            }
        }
        */
       private void gerer_les_utilisateurs_Load(object sender, EventArgs e)
        {
           /* if (utile.type.CompareTo("etudiant") == 0)
            { EspaceEtudiant.Enabled = true; }
            else if (utile.type.CompareTo("prof") == 0) { EspaceProf.Enabled = true; }
            else if (utile.type.CompareTo("chef") == 0) { menuadmin.Enabled = true; }
            else if (utile.type.CompareTo("administrateur") == 0)
            {
                menuadmin.Enabled = true;
                espaceAdminToolStripMenuItem.Enabled = true;
            }*/
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            
            if (this.bunifuDropdown1.selectedValue == "etudiant")
            {
                bunifuDropdown2.Clear();
                bunifuDropdown3.Clear();
                FillCombo1_etud();
                //FillCombo2_etud();
                this.cherch.Enabled = true;
                this.cherchbox.Enabled = true;
                bunifuCustomLabel15.Visible = true;
                bunifuDropdown2.Visible = true;
                this.modif.Visible = false;
                this.supp.Visible = false;
                this.Save.Visible = false;
                this.Save.Enabled = false;
            }

            else if (this.bunifuDropdown1.selectedValue == "administrateur")
            {
                bunifuDropdown3.Clear();
                FillCombo_admin();
                this.cherch.Enabled = true;
                this.cherchbox.Enabled = true;

                this.modif.Visible = false;
                this.supp.Visible = false;
                this.Save.Visible = false;
                this.Save.Enabled = false;

                bunifuCustomLabel10.Visible = true;
                bunifuDropdown3.Visible = true;
                bunifuCustomLabel15.Visible = false;
                bunifuDropdown2.Visible = false;
            }

            else if (this.bunifuDropdown1.selectedValue == "prof")
            {
                bunifuDropdown3.Clear();
                FillCombo_prof();
                this.cherch.Enabled = true;
                this.cherchbox.Enabled = true;

                this.modif.Visible = false;
                this.supp.Visible = false;
                this.Save.Visible = false;
                this.Save.Enabled = false;
                bunifuCustomLabel10.Visible = true;
                bunifuDropdown3.Visible = true;
                bunifuCustomLabel15.Visible = false;
                bunifuDropdown2.Visible = false;
            }
            else if (this.bunifuDropdown1.selectedValue == "chef")
            {
                bunifuDropdown3.Clear();
                FillCombo_chef();
                
               
                this.cherch.Enabled = true;
                this.cherchbox.Enabled = true;

                this.modif.Visible = false;
                this.supp.Visible = false;
                this.Save.Visible = false;
                this.Save.Enabled = false;
                bunifuCustomLabel10.Visible = true;
                bunifuDropdown3.Visible = true;
                bunifuCustomLabel15.Visible = false;
                bunifuDropdown2.Visible = false;
            }
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            bunifuDropdown3.Clear();
            FillCombo2_etud();
            bunifuCustomLabel10.Visible = true;
            bunifuDropdown3.Visible = true;
           
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

        private void cherch_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            if (bunifuDropdown1.selectedValue == "etudiant")
            {
                utile.connect();
                string req6 = "select count(*) from etudiant where cin=" + int.Parse(cherchbox.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {
                    bunifuMaterialTextbox2.isPassword = true;
                    bunifuImageButton1.Visible = true;
                    bunifuCustomLabel14.Visible = true;
                    bunifuCustomLabel13.Visible = true;
                    bunifuCustomLabel12.Visible = true;
                    bunifuCustomLabel9.Visible = true;
                    bunifuCustomLabel7.Visible = true;
                    bunifuCustomLabel8.Visible = true;
                    bunifuCustomLabel5.Visible = true;
                    bunifuMaterialTextbox1.Visible = true;
                    bunifuMaterialTextbox2.Visible = true;
                    bunifuMaterialTextbox3.Visible = true;
                    bunifuMaterialTextbox4.Visible = true;
                    bunifuMaterialTextbox5.Visible = true;
                    bunifuMaterialTextbox6.Visible = true;
                    bunifuDatepicker2.Visible = true;
                    Save.Visible = true;
                    modif.Visible = true;
                    supp.Visible = true;
                    supp.Enabled = true;
                    string req7 = "select * from etudiant where cin=" + int.Parse(cherchbox.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        bunifuMaterialTextbox1.Text = rd7["cin"].ToString();
                        bunifuMaterialTextbox2.Text = rd7["pass"].ToString();
                        bunifuMaterialTextbox3.Text = rd7["nom"].ToString();
                        bunifuMaterialTextbox4.Text = rd7["prenom"].ToString();
                        bunifuMaterialTextbox5.Text = rd7["adress"].ToString();
                        bunifuMaterialTextbox6.Text = rd7["tlf"].ToString();
                        
                        bunifuDatepicker2.Value= Convert.ToDateTime(rd7["date_naiss"].ToString());
                    }
                    utile.closee();
                }
                utile.closee();
            }

            if (bunifuDropdown1.selectedValue == "administrateur")
            {
                utile.connect();
                string req6 = "select count(*) from administrateur where cin=" + int.Parse(cherchbox.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (utilisateur.exis(int.Parse(cherchbox.Text)))
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {

                    bunifuMaterialTextbox2.isPassword = true;
                    bunifuImageButton1.Visible = true;
                    bunifuCustomLabel14.Visible = true;
                    bunifuCustomLabel13.Visible = true;
                    bunifuCustomLabel12.Visible = true;
                    bunifuCustomLabel9.Visible = true;
                    bunifuCustomLabel7.Visible = true;
                    bunifuCustomLabel8.Visible = true;
                    bunifuCustomLabel5.Visible = true;
                    bunifuMaterialTextbox1.Visible = true;
                    bunifuMaterialTextbox2.Visible = true;
                    bunifuMaterialTextbox3.Visible = true;
                    bunifuMaterialTextbox4.Visible = true;
                    bunifuMaterialTextbox5.Visible = true;
                    bunifuMaterialTextbox6.Visible = true;
                    bunifuDatepicker2.Visible = true;
                    Save.Visible = true;
                    modif.Visible = true;
                    supp.Visible = true;
                    supp.Enabled = true;
                    utilisateur n = utilisateur.rech(int.Parse(cherchbox.Text));
                    bunifuMaterialTextbox1.Text = n.CIN.ToString();
                    bunifuMaterialTextbox2.Text = n.pass.ToString();
                    bunifuMaterialTextbox3.Text = n.nom.ToString();

                    bunifuMaterialTextbox4.Text = n.prenom.ToString();
                    bunifuMaterialTextbox5.Text = n.adress.ToString();
                    bunifuMaterialTextbox6.Text = n.tlf.ToString();
                    bunifuDatepicker2.Value = Convert.ToDateTime(n.date_naiss.ToString());

                    utile.closee();
                }
                utile.closee();
            }

            if (bunifuDropdown1.selectedValue == "prof")
            {
                utile.connect();
                string req6 = "select count(*) from prof where cin=" + int.Parse(cherchbox.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {

                    bunifuMaterialTextbox2.isPassword = true;
                    bunifuImageButton1.Visible = true;
                    bunifuCustomLabel14.Visible = true;
                    bunifuCustomLabel13.Visible = true;
                    bunifuCustomLabel12.Visible = true;
                    bunifuCustomLabel9.Visible = true;
                    bunifuCustomLabel7.Visible = true;
                    bunifuCustomLabel8.Visible = true;
                    bunifuCustomLabel5.Visible = true;
                    bunifuMaterialTextbox1.Visible = true;
                    bunifuMaterialTextbox2.Visible = true;
                    bunifuMaterialTextbox3.Visible = true;
                    bunifuMaterialTextbox4.Visible = true;
                    bunifuMaterialTextbox5.Visible = true;
                    bunifuMaterialTextbox6.Visible = true;
                    bunifuDatepicker2.Visible = true;
                    Save.Visible = true;
                    modif.Visible = true;
                    supp.Visible = true;
                    supp.Enabled = true;
                    string req7 = "select * from prof where cin=" + int.Parse(cherchbox.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        bunifuMaterialTextbox1.Text = rd7["cin"].ToString();
                        bunifuMaterialTextbox2.Text = rd7["pass"].ToString();
                        bunifuMaterialTextbox3.Text = rd7["nom"].ToString();
                        bunifuMaterialTextbox4.Text = rd7["prenom"].ToString();
                        bunifuMaterialTextbox5.Text = rd7["adress"].ToString();
                        bunifuMaterialTextbox6.Text = rd7["tlf"].ToString();

                        bunifuDatepicker2.Value = Convert.ToDateTime(rd7["date_naiss"].ToString());
                    }
                    utile.closee();
                }
                utile.closee();
            }

            else if (bunifuDropdown1.selectedValue == "chef")
            {
                utile.connect();
                string req6 = "select count(*) from chef where cin=" + int.Parse(cherchbox.Text) + ";";
                OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
                //OleDbDataReader rd6 = cmd6.ExecuteReader();
                if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                {

                    MessageBox.Show("verifie la cin");
                    utile.closee();
                }
                else
                {

                    bunifuMaterialTextbox2.isPassword = true;
                    bunifuImageButton1.Visible = true;
                    bunifuCustomLabel14.Visible = true;
                    bunifuCustomLabel13.Visible = true;
                    bunifuCustomLabel12.Visible = true;
                    bunifuCustomLabel9.Visible = true;
                    bunifuCustomLabel7.Visible = true;
                    bunifuCustomLabel8.Visible = true;
                    bunifuCustomLabel5.Visible = true;
                    bunifuMaterialTextbox1.Visible = true;
                    bunifuMaterialTextbox2.Visible = true;
                    bunifuMaterialTextbox3.Visible = true;
                    bunifuMaterialTextbox4.Visible = true;
                    bunifuMaterialTextbox5.Visible = true;
                    bunifuMaterialTextbox6.Visible = true;
                    bunifuDatepicker2.Visible = true;
                    Save.Visible = true;
                    modif.Visible = true;
                    supp.Visible = true;
                    supp.Enabled = true;
                    string req7 = "select * from chef where cin=" + int.Parse(cherchbox.Text) + ";";
                    OleDbCommand cmd7 = new OleDbCommand(req7, utile.cn);
                    OleDbDataReader rd7 = cmd7.ExecuteReader();
                    while (rd7.Read())
                    {
                        bunifuMaterialTextbox1.Text = rd7["cin"].ToString();
                        bunifuMaterialTextbox2.Text = rd7["pass"].ToString();
                        bunifuMaterialTextbox3.Text = rd7["nom"].ToString();
                        bunifuMaterialTextbox4.Text = rd7["prenom"].ToString();
                        bunifuMaterialTextbox5.Text = rd7["adress"].ToString();
                        bunifuMaterialTextbox6.Text = rd7["tlf"].ToString();

                        bunifuDatepicker2.Value = Convert.ToDateTime(rd7["date_naiss"].ToString());
                    }
                    utile.closee();
                }
                utile.closee();
            }
        }

        private void ChercheButton_Click(object sender, EventArgs e)
        {

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

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            bunifuImageButton1.Visible = true;
            bunifuCustomLabel14.Visible = true;
            bunifuCustomLabel13.Visible = true;
            bunifuCustomLabel12.Visible = true;
            bunifuCustomLabel9.Visible = true;
            bunifuCustomLabel7.Visible = true;
            bunifuCustomLabel8.Visible = true;
            bunifuCustomLabel5.Visible = true;
            bunifuMaterialTextbox1.Visible = true;
            bunifuMaterialTextbox2.Visible = true;
            bunifuMaterialTextbox3.Visible = true;
            bunifuMaterialTextbox4.Visible = true;
            bunifuMaterialTextbox5.Visible = true;
            bunifuMaterialTextbox6.Visible = true;
            bunifuDatepicker2.Visible = true;
            Save.Visible = true;
            modif.Visible = true;
            supp.Visible = true;
            supp.Enabled = true;
            string[] separateurs = { " " };
            string[] mots;
            mots = bunifuDropdown3.selectedValue.Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
            utile.connect();
            if (bunifuDropdown1.selectedValue == "etudiant")
            {
                string req4 = "select * from etudiant where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    bunifuMaterialTextbox1.Text = rd4["cin"].ToString();
                    bunifuMaterialTextbox2.Text = rd4["pass"].ToString();
                    bunifuMaterialTextbox3.Text = rd4["nom"].ToString();
                    
                    bunifuMaterialTextbox4.Text = rd4["prenom"].ToString();
                    bunifuMaterialTextbox5.Text = rd4["adress"].ToString();
                    bunifuMaterialTextbox6.Text = rd4["tlf"].ToString();
                    bunifuDatepicker2.Value = Convert.ToDateTime(rd4["date_naiss"].ToString());
                }
                utile.closee();
            }
            else if (bunifuDropdown1.selectedValue == "administrateur")
            {

                utilisateur n = utilisateur.rech(int.Parse(mots[2]));
                    bunifuMaterialTextbox1.Text = n.CIN.ToString();
                    bunifuMaterialTextbox2.Text = n.pass.ToString();
                    bunifuMaterialTextbox3.Text = n.nom.ToString();

                    bunifuMaterialTextbox4.Text = n.prenom.ToString();
                    bunifuMaterialTextbox5.Text = n.adress.ToString();
                    bunifuMaterialTextbox6.Text = n.tlf.ToString();
                    bunifuDatepicker2.Value = Convert.ToDateTime(n.date_naiss.ToString());
               
                utile.closee();
            }
            else if (bunifuDropdown1.selectedValue == "prof")
            {
                string req4 = "select * from prof where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    bunifuMaterialTextbox1.Text = rd4["cin"].ToString();
                    bunifuMaterialTextbox2.Text = rd4["pass"].ToString();
                    bunifuMaterialTextbox3.Text = rd4["nom"].ToString();

                    bunifuMaterialTextbox4.Text = rd4["prenom"].ToString();
                    bunifuMaterialTextbox5.Text = rd4["adress"].ToString();
                    bunifuMaterialTextbox6.Text = rd4["tlf"].ToString();
                    bunifuDatepicker2.Value = Convert.ToDateTime(rd4["date_naiss"].ToString());
                }
                utile.closee();
            }
            else if (bunifuDropdown1.selectedValue == "chef")
            {
                string req4 = "select * from chef where nom='" + mots[0] + "' and prenom='" + mots[1] + "' and cin=" + int.Parse(mots[2]) + ";";
                OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
                OleDbDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    bunifuMaterialTextbox1.Text = rd4["cin"].ToString();
                    bunifuMaterialTextbox2.Text = rd4["pass"].ToString();
                    bunifuMaterialTextbox3.Text = rd4["nom"].ToString();

                    bunifuMaterialTextbox4.Text = rd4["prenom"].ToString();
                    bunifuMaterialTextbox5.Text = rd4["adress"].ToString();
                    bunifuMaterialTextbox6.Text = rd4["tlf"].ToString();
                    bunifuDatepicker2.Value = Convert.ToDateTime(rd4["date_naiss"].ToString());
                }
                utile.closee();
            }
        }

        private void modif_Click(object sender, EventArgs e)
        {
            Save.Enabled = true;
            
            bunifuMaterialTextbox2.Enabled = true;
            bunifuMaterialTextbox3.Visible = true;
            bunifuMaterialTextbox4.Enabled = true;
            bunifuMaterialTextbox5.Enabled = true;
            bunifuMaterialTextbox6.Enabled = true;
            bunifuDatepicker2.Enabled = true;
        }

        private void supp_Click(object sender, EventArgs e)
        {
            Save.Enabled = false;
            modif.Enabled = false;
            if (bunifuDropdown1.selectedValue == "etudiant")
            {
                utile.connect();
                string req8 = "DELETE etudiant.* FROM etudiant WHERE cin =" + int.Parse(bunifuMaterialTextbox1.Text) + ";";
                OleDbCommand cmd8 = new OleDbCommand(req8, utile.cn);

                cmd8.ExecuteNonQuery(); utile.closee();
                utile.pop = "Supprime"; utile.up();
                bunifuDropdown3.RemoveItem(bunifuDropdown3.selectedValue);
                

                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox6.Text = "";
                bunifuDatepicker2.Text = "";supp.Enabled = false; Save.Enabled = false;

                utile.closee();
            }
            if (bunifuDropdown1.selectedValue == "administrateur")
            {
                utile.connect();
                string req8 = "DELETE administrateur.* FROM administrateur WHERE cin =" + int.Parse(bunifuMaterialTextbox1.Text) + ";";
                OleDbCommand cmd8 = new OleDbCommand(req8, utile.cn);

                cmd8.ExecuteNonQuery(); utile.closee();
                utile.pop = "Supprime"; utile.up();
                //bunifuDropdown3.RemoveItem(bunifuDropdown3.selectedValue);
                //bunifuDropdown3.Refresh();

                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox6.Text = "";
                bunifuDatepicker2.Text = "";
                supp.Enabled = false; Save.Enabled = false;

                utile.closee();
            }
            if (bunifuDropdown1.selectedValue == "prof")
            {
                utile.connect();
                string req8 = "DELETE prof.* FROM prof WHERE cin =" + int.Parse(bunifuMaterialTextbox1.Text) + ";";
                OleDbCommand cmd8 = new OleDbCommand(req8, utile.cn);

                cmd8.ExecuteNonQuery(); utile.closee();
                bunifuDropdown3.RemoveItem(bunifuDropdown3.selectedValue);
               // bunifuDropdown3.Refresh();
                
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox6.Text = "";
                bunifuDatepicker2.Text = "";
                utile.pop = "Supprime"; utile.up();supp.Enabled = false; Save.Enabled = false;
                utile.closee();
            }
            if (bunifuDropdown1.selectedValue == "chef")
            {
                utile.connect();
                string req8 = "DELETE chef.* FROM chef WHERE cin =" + int.Parse(bunifuMaterialTextbox1.Text) + ";";
                OleDbCommand cmd8 = new OleDbCommand(req8, utile.cn);

                cmd8.ExecuteNonQuery(); utile.closee();
                

                utile.pop = "Supprime"; utile.up();
                bunifuDropdown3.RemoveItem(bunifuDropdown3.selectedValue);
                //bunifuDropdown3.Refresh();

                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox6.Text = "";
                bunifuDatepicker2.Text = "";

                utile.pop = "Supprime";
               
                Save.Enabled = false;
                modif.Enabled = false;
                utile.closee();
            }
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            utile.connect();
            DateTime dt = Convert.ToDateTime(bunifuDatepicker2.Value);
            string temp = dt.ToShortDateString();
            string sav="update "+ bunifuDropdown1.selectedValue +" set pass ='" + bunifuMaterialTextbox2.Text + "',nom ='" + bunifuMaterialTextbox3.Text + "',prenom ='" + bunifuMaterialTextbox4.Text + "',adress ='" + bunifuMaterialTextbox5.Text + "',tlf =" + bunifuMaterialTextbox6.Text +",date_naiss ='" + temp + "' where cin=" + bunifuMaterialTextbox1.Text +"; ";
            OleDbCommand sav1 = new OleDbCommand(sav, utile.cn);
            sav1.ExecuteNonQuery();
            utile.pop = "Modifier";
            utile.up();
            
        
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8) { e.Handled = true; MessageBox.Show("entre des numero seulement"); }
        }
    }
}
