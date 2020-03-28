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
using PagedList;

namespace Projet
{
    public partial class mes_class : Form
    {
        public mes_class()
        {
            InitializeComponent();
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
        void fill_matier()
        {
            //  utile.cin = 12341234;
            utile.connect();
            string req1 = "select NomMatier from assiste where Id_prof=" + utile.cin + ";";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();

            while (rd.Read())
            {
             //   taille = taille + 1;
                string Cname = rd["NomMatier"].ToString();
                ChMat.AddItem(Cname);
                //   Array.Resize(ref Mat, taille);
                // Mat[taille - 1] = Cname;
            }
            utile.closee();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChMat_onItemSelected(object sender, EventArgs e)
        {
            ChClas.Clear();
            fill_classe();
            
        }

        private void ChClas_onItemSelected(object sender, EventArgs e)
        {
            utile.connect();
            string req11 = "select cin,nom,prenom from etudiant where classe='" + ChClas.selectedValue + "';";
            OleDbCommand cmd11 = new OleDbCommand(req11, utile.cn);
            OleDbDataAdapter rd = new OleDbDataAdapter(cmd11);
            DataTable tab = new DataTable();

            rd.Fill(tab);
            dataGridView1.DataSource = tab;
           
            utile.closee();


        }

        private void mes_class_Load(object sender, EventArgs e)
        {
            fill_matier();
        }
        Bitmap bmp;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(5, 5, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
