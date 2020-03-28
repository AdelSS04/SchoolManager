using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Projet
{
   public class utilisateur
    {
        public int CIN, tlf;
        public string pass, nom, prenom, adress, date_naiss, classe;
        public utilisateur(int CIN, string pass, string nom, string prenom, int tlf, string adress, string date_naiss)
        {
            this.CIN = CIN; this.tlf = tlf;
            this.pass = pass; this.nom = nom; this.prenom = prenom; this.adress = adress; this.date_naiss = date_naiss; 
        }
        static public utilisateur rech (int cin)
        {

            string req4 = "select * from administrateur where cin=" + cin + ";";
            OleDbCommand cmd4 = new OleDbCommand(req4, utile.cn);
            OleDbDataReader rd4 = cmd4.ExecuteReader();
            if (rd4.Read())
            {
                utilisateur n = new utilisateur(int.Parse(rd4["cin"].ToString()), rd4["pass"].ToString(), rd4["nom"].ToString(), rd4["prenom"].ToString(), int.Parse(rd4["tlf"].ToString()), rd4["adress"].ToString(), rd4["date_naiss"].ToString());
                return n;
            }
            else
                return null;
            
        }
        static public bool exis(int cin)
        {
            utile.connect();
            string req6 = "select count(*) from administrateur where cin=" + cin + ";";
            OleDbCommand cmd6 = new OleDbCommand(req6, utile.cn);
            //OleDbDataReader rd6 = cmd6.ExecuteReader();
            if (int.Parse(cmd6.ExecuteScalar().ToString()) == 0)
                return true;
            else
                return false;
        }

    }
}
