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
    public partial class ajt_note : Form
    { static public int etat;
       // OleDbDataAdapter rd; DataTable tab;
        int taille = 0;
        string[] Mat = new string[0];
        public ajt_note()
        {
            InitializeComponent();
           /* dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "CIN";
            dataGridView1.Columns[1].Name = "note_ds";
            dataGridView1.Columns[2].Name = "note_test";
            dataGridView1.Columns[3].Name = "note_ex";
            dataGridView1.Columns[4].Name = "note_tp";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

      //SELECTION MODE
      dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGridView1.MultiSelect = false;*/
        }
        
        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {


            bunifuDropdown1.Clear();
            FillCombo2_etud();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            ChClas.Clear();
            fill_classe();
            bunifuDropdown1.Clear();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
        void fill_matier()
        {
          //  utile.cin = 12341234;
            utile.connect();
            string req1 = "select NomMatier from assiste where Id_prof=" + utile.cin + ";";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();

            while (rd.Read())
            {
                taille = taille + 1;
                string Cname = rd["NomMatier"].ToString();
                ChMat.AddItem(Cname);
                //   Array.Resize(ref Mat, taille);
                // Mat[taille - 1] = Cname;
            }
            utile.closee();
        }
        void FillCombo2_etud()
        {
            utile.connect();

            string req3 = "select * from etudiant where classe='" + ChClas.selectedValue + "';";
            OleDbCommand cmd3 = new OleDbCommand(req3, utile.cn);
            OleDbDataReader rd3 = cmd3.ExecuteReader();
            while (rd3.Read())
            {
                string Vname = rd3["nom"].ToString();
                string V1name = rd3["prenom"].ToString();
                string V2name = rd3["cin"].ToString();
                string V3 = Vname + ' ' + V1name + ' ' + V2name;
                bunifuDropdown1.AddItem(V3);

            }
            rd3 = null;
            utile.closee();
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ajt_note_Load(object sender, EventArgs e)
        {
           fill_matier();
        }
        void fill_classe()
        {
            utile.connect();
            string req1 = "select id_classe from ando where nom_matier='" + ChMat.selectedValue + "';";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd["id_classe"].ToString();
                ChClas.AddItem(Cname);

            }
            utile.closee();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajt_note_Activated(object sender, EventArgs e)
        {
            //fill_matier();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (etat == 0)
            {
                string[] separateurs = { " " };
                string[] mots;
                mots = bunifuDropdown1.selectedValue.Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
                note no = new note(ChMat.selectedValue, int.Parse(mots[2]), int.Parse(bunifuMaterialTextbox1.Text), int.Parse(bunifuMaterialTextbox2.Text), int.Parse(bunifuMaterialTextbox3.Text),int.Parse(bunifuMaterialTextbox4.Text));
                no.Modif();
                utile.pop = "Modifier";
                utile.up();
                
            }
            if (etat == 1)
            {
                string[] separateurs = { " " };
                string[] mots;
                mots = bunifuDropdown1.selectedValue.Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
                note no = new note(ChMat.selectedValue, int.Parse(mots[2]), int.Parse(bunifuMaterialTextbox1.Text), int.Parse(bunifuMaterialTextbox2.Text), int.Parse(bunifuMaterialTextbox3.Text), int.Parse(bunifuMaterialTextbox4.Text));
                if (utile.type_mat == "tt")
                { no.ajttt(); }
                if (utile.type_mat == "cc")
                { no.ajtcc(); }
                if (utile.type_mat == "tp")
                { no.ajttp(); }
                utile.pop = "Ajoute";
                utile.up();
                utile.closee();
            }

        }
      
       

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected_1(object sender, EventArgs e)
        {
            utile.connect();
            string mom = "select * from matiere where nom='" + ChMat.selectedValue + "';";
            OleDbCommand cmm = new OleDbCommand(mom, utile.cn);
            OleDbDataReader rd101 = cmm.ExecuteReader();

            string[] separateurs = { " " };
            string[] mots;
            mots = bunifuDropdown1.selectedValue.Split(separateurs, StringSplitOptions.RemoveEmptyEntries);
            while (rd101.Read())
            {
                utile.type_mat = rd101["type"].ToString();
            }
            if ( (note.exis(int.Parse(mots[2]), ChMat.selectedValue) == 1))
            { if (utile.type_mat == "cc")
                {
                    note nono = note.rech(int.Parse(mots[2]), ChMat.selectedValue);

                    etat = 0;
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox3.Enabled = true;
                    bunifuMaterialTextbox4.Visible = false;
                    bunifuMaterialTextbox1.Text = nono.ds.ToString();
                    bunifuMaterialTextbox2.Text = nono.test.ToString();
                    bunifuMaterialTextbox3.Text = nono.ex.ToString();
                    bunifuMaterialTextbox4.Text = "00";

                }
                else if (utile.type_mat == "tp")
                {
                    note nono = note.rech(int.Parse(mots[2]), ChMat.selectedValue);

                    etat = 0;
                    bunifuMaterialTextbox1.Visible = false;
                    bunifuMaterialTextbox2.Visible = false;
                    bunifuMaterialTextbox3.Visible = false;
                    bunifuMaterialTextbox4.Enabled = true;
                    bunifuMaterialTextbox1.Text = "00";
                    bunifuMaterialTextbox2.Text = "00";
                    bunifuMaterialTextbox3.Text = "00";
                    bunifuMaterialTextbox4.Text = nono.tp.ToString();

                }
                else
                {
                    note nono = note.rech(int.Parse(mots[2]), ChMat.selectedValue);

                    etat = 0;
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox3.Enabled = true;
                    bunifuMaterialTextbox4.Enabled = true;
                    bunifuMaterialTextbox1.Text = nono.ds.ToString();
                    bunifuMaterialTextbox2.Text = nono.test.ToString();
                    bunifuMaterialTextbox3.Text = nono.ex.ToString();
                    bunifuMaterialTextbox4.Text = nono.tp.ToString();

                }


            }
            else
            {
                if (utile.type_mat == "cc")
                {
                    etat = 1;
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox3.Enabled = true;
                    bunifuMaterialTextbox4.Visible = false;
                    bunifuMaterialTextbox1.Text = "00";
                    bunifuMaterialTextbox2.Text = "00";
                    bunifuMaterialTextbox3.Text = "00";
                    bunifuMaterialTextbox4.Text = "00";

                }
                else if (utile.type_mat == "tp")
                {
                    etat = 1;
                    bunifuMaterialTextbox1.Visible = false;
                    bunifuMaterialTextbox2.Visible = false;
                    bunifuMaterialTextbox3.Visible = false;
                    bunifuMaterialTextbox4.Enabled = true;
                    bunifuMaterialTextbox1.Text = "00";
                    bunifuMaterialTextbox2.Text = "00";
                    bunifuMaterialTextbox3.Text = "00";
                    bunifuMaterialTextbox4.Text = "00";
                }
                else
                {
                    bunifuMaterialTextbox1.Enabled = true;
                    bunifuMaterialTextbox2.Enabled = true;
                    bunifuMaterialTextbox3.Enabled = true;
                    bunifuMaterialTextbox4.Enabled = true;
                    bunifuMaterialTextbox1.Text = "00";
                    bunifuMaterialTextbox2.Text = "00";
                    bunifuMaterialTextbox3.Text = "00";
                    bunifuMaterialTextbox4.Text = "00";

                }



            }
            utile.closee();
        }
    }
}
