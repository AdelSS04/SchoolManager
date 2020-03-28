using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Projet
{
    class etudiant: utilisateur
    {
      // public int CIN, tlf;
        //public string pass, nom, prenom, adress, date_naiss;
        //public string classe;
        public etudiant(int CIN,string pass, string nom, string prenom, int tlf, string adress, string date_naiss, string classe) :base(CIN,pass,nom,prenom,tlf,adress,date_naiss)
        {
             this.classe= classe;
    }
        public void ajouter()
        {
            utile.connect();
            string req111 = "select count(*) from etudiant where classe='" + classe + "';";
            OleDbCommand cmd111 = new OleDbCommand(req111, utile.cn);
            if (int.Parse(cmd111.ExecuteScalar().ToString()) > 20)
            { utile.errure_type = "Classe est plien, Max 20 etudiant"; utile.er_show(); }
            else
            {
              //  DateTime dt = Convert.ToDateTime(date_naiss);
               // string temp = dt.ToShortDateString();
                utile.connect();
                string req1 = "insert into  etudiant values (" +CIN + ",'" + pass + "','" + nom + "','" + prenom + "'," + tlf + ",'" + adress + "','" + date_naiss + "','" + classe + "');";
                //MessageBox.Show(req1);
                OleDbCommand cmd1 = new OleDbCommand(req1, utile.cn);
                cmd1.ExecuteNonQuery();
                utile.closee();
                utile.pop = "Ajoute";
                utile.up();
            }
        }


        public static new Boolean exis(int cin)
        {
            utile.connect();
            
            string req11 = "select count(*) from administrateur where cin=" + cin + ";";
            OleDbCommand cmd11 = new OleDbCommand(req11, utile.cn);
            string req12 = "select count(*) from prof where cin=" + cin + ";";
            OleDbCommand cmd12 = new OleDbCommand(req12, utile.cn);
            string req13 = "select count(*) from etudiant where cin=" + cin + ";";
            OleDbCommand cmd13 = new OleDbCommand(req13, utile.cn);
            string req14 = "select count(*) from chef where cin=" + cin + ";";
            OleDbCommand cmd14 = new OleDbCommand(req14, utile.cn);
            if (int.Parse(cmd11.ExecuteScalar().ToString()) == 1 || int.Parse(cmd12.ExecuteScalar().ToString()) == 1 || int.Parse(cmd13.ExecuteScalar().ToString()) == 1 || int.Parse(cmd14.ExecuteScalar().ToString()) == 1)
            {
                utile.closee();
                return false;
               }
            else { utile.closee();
                return true; }
        }
    }
}
