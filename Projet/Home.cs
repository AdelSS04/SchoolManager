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
    public partial class Home : Form
    {
       

        public Home()
        {
            InitializeComponent();
        }
        

        private void Home_Load(object sender, EventArgs e)
        {
            if (utile.type.CompareTo("etudiant")==0)
            { EspaceEtudiant.Enabled = true; }
            else if (utile.type.CompareTo("prof") == 0) { EspaceProf.Enabled = true; }
            else if (utile.type.CompareTo("chef") == 0) { menuadmin.Enabled = true; }
            else if (utile.type.CompareTo("administrateur") == 0) { menuadmin.Enabled = true;
                espaceAdminToolStripMenuItem.Enabled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void enseignantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lesDesplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mes_absence mma = new mes_absence();
            panel1.Controls.Clear();
            mma.TopLevel = false; panel1.Controls.Add(mma);
            mma.Show();
        }

        private void eleveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuadmin_Click(object sender, EventArgs e)
        {

        }

        private void leClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierLesUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // gerer_les_utilisateurs fr = new gerer_les_utilisateurs() ;
           // this.Hide();
           //     fr.ShowDialog();
            //  gerer_les_utilisateurs a = new gerer_les_utilisateurs();
            panel1.Controls.Clear();
            gerer_les_utilisateurs a = new gerer_les_utilisateurs();
            a.TopLevel = false; panel1.Controls.Add(a);
            a.Show();
        }

        private void creeUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cree_nv_user fr = new cree_nv_user();
            panel1.Controls.Clear();
            fr.TopLevel = false; panel1.Controls.Add(fr);
            fr.Show();
        }

        private void ajouteEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            inscri_etud iss = new inscri_etud();
           
            iss.TopLevel = false; panel1.Controls.Add(iss);
            iss.Show();
        }

        private void gestionDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gestion_des_classes gs = new Gestion_des_classes(); gs.TopLevel = false; panel1.Controls.Add(gs);
            gs.Show();
        }

        private void gestionDesMatieresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gestion_de_matier g = new Gestion_de_matier(); g.TopLevel = false; panel1.Controls.Add(g);
           g.Show();
        }

        private void ajouteDesAbsencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ajouter_abcense a = new ajouter_abcense();
            a.TopLevel = false; panel1.Controls.Add(a);
            a.Show();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouteDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            panel1.Controls.Clear();
            ajt_note na = new ajt_note();
            na.TopLevel = false; panel1.Controls.Add(na);
            na.Show();
           
        }

        private void listeDeClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mes_class mc = new mes_class();
            mc.TopLevel = false; panel1.Controls.Add(mc);
            mc.Show();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mes_note mmn = new mes_note();
            mmn.TopLevel = false; panel1.Controls.Add(mmn);
            mmn.Show();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            About abbb = new About();
            abbb.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 716)
            {
                panel1.Width = 842;
                panel1.Location = new Point(49, 27);
                bunifuTransition1.ShowSync(panel1);


            }
            else
            {
                panel1.Width = 716;
                panel1.Location = new Point(127, 27);
                bunifuTransition1.ShowSync(panel1);
            }
        }
    }
}
