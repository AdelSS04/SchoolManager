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
    public partial class Gestion_des_classes : Form
    {
        public Gestion_des_classes()
        {
            InitializeComponent();
            fill_filer();
            fill_niv();
        }
        void fill_filer()
        {
            utile.connect();
            string req20 = "select * from filier  ;";
            OleDbCommand cmd20 = new OleDbCommand(req20, utile.cn);
            OleDbDataReader rd20 = cmd20.ExecuteReader();
            while (rd20.Read())
            {
                string Cname = rd20["filier"].ToString();
                bunifuDropdown1.AddItem(Cname);

            }
            utile.closee();
        }
        void fill_niv()
        {
            utile.connect();
            string req30 = "select niveau_id from niveau  ;";
            OleDbCommand cmd30 = new OleDbCommand(req30, utile.cn);
            OleDbDataReader rd30 = cmd30.ExecuteReader();
            while (rd30.Read())
            {
                string Cname = rd30["niveau_id"].ToString();
                bunifuDropdown2.AddItem(Cname);

            }
            utile.closee();
        }
        void fill_class()
        {
            utile.connect();
            string req1 = "select id from classe where id_filier='"+ bunifuDropdown1.selectedValue + "' and id_niveau=" +int.Parse(bunifuDropdown2.selectedValue) +" ; ";
            OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
            OleDbDataReader rd = cmd1.ExecuteReader();
            while (rd.Read())
            {
                string Cname = rd["id"].ToString();
                bunifuDropdown3.AddItem(Cname);

            }
            utile.closee();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            utile.connect();
            string req11 = "select cin,nom,prenom from etudiant where classe='" + bunifuDropdown3.selectedValue + "';";
            OleDbCommand cmd11 = new OleDbCommand(req11, utile.cn);
            OleDbDataAdapter rd = new OleDbDataAdapter(cmd11);
            DataTable tab = new DataTable();

            rd.Fill(tab);
            bunifuCustomDataGrid1.DataSource = tab;
            utile.closee();


        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gestion_des_classes_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            bunifuDropdown3.Clear();
            fill_class();
            bunifuFlatButton1.Enabled = true;


            utile.connect();
            string req11 = "select group from classe where id_filier='" + bunifuDropdown1.selectedValue + "' and id_niveau=" + int.Parse(bunifuDropdown2.selectedValue) + " ; ";
            OleDbCommand cmd11 = new OleDbCommand(req11, utile.cn);
            OleDbDataReader rd1 = cmd11.ExecuteReader();
           // string cls = ("abcdef");
            string[] cls1 = {"a", "b", "c", "d", "e", "f"};
            int t =1;
            string[] ca= new string[t];
            int x = 0;
            int c = 0;
            while (rd1.Read())
            { ca[c] = rd1["group"].ToString();
             
                Array.Resize(ref ca, ca.Length + 1);
                c++;
            }
            Array.Sort(ca, StringComparer.InvariantCulture);
            x = ca.Length;


            /* while (rd1.Read() && vr)
             {
                 foreach (char w in cls)
                 {
                     string cc;
                     cc = rd1["group"].ToString();
                    c= cls.IndexOf(cc);
                   //  MessageBox.Show("" + c + "");
                     if (c == -1) { vr = false; }
                     else { x=c; }
                 }

             }
            MessageBox.Show(""+x+"");*/
            bunifuMaterialTextbox7.Text = bunifuDropdown2.selectedValue+bunifuDropdown1.selectedValue+"_"+ cls1[x-1];
            utile.class_grp = cls1[x-1];
            utile.closee();

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            bunifuDropdown2.Enabled=true;
           // bunifuDropdown2.Clear();
            bunifuDropdown3.Clear();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            utile.connect();
            
            string req122 = "insert into classe values ('" + bunifuMaterialTextbox7.Text + "','" + bunifuDropdown1.selectedValue + "'," + int.Parse(bunifuDropdown2.selectedValue) + ",'" + utile.class_grp + "');";
            OleDbCommand cmd122 = new OleDbCommand(req122, utile.cn);
            cmd122.ExecuteNonQuery();
            utile.closee();
            utile.pop = "Ajoute";
            utile.up();
        }
        Bitmap bmp;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int height = bunifuCustomDataGrid1.Height;
            bunifuCustomDataGrid1.Height = bunifuCustomDataGrid1.RowCount * bunifuCustomDataGrid1.RowTemplate.Height *2;
            bmp = new Bitmap(bunifuCustomDataGrid1.Width, bunifuCustomDataGrid1.Height);
            bunifuCustomDataGrid1.DrawToBitmap(bmp, new Rectangle(5, 5, bunifuCustomDataGrid1.Width, bunifuCustomDataGrid1.Height));
            bunifuCustomDataGrid1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
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
