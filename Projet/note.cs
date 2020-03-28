using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Projet
{
    class note

    {
        public string matier; public int id; public float ds; public float test; public float ex; public float tp;

        public note (string matier, int id, float ds, float test, float ex,float tp) {
            this.matier = matier;this.id = id;this.ds = ds;this.test = test;this.ex = ex;this.tp = tp;
        }
        public note(string matier, int id,  float tp)
        {
            this.matier = matier; this.id = id; this.tp = tp;
        }
        public note(string matier, int id, float ds, float test, float ex)
        {
            this.matier = matier; this.id = id; this.ds = ds; this.test = test; this.ex = ex; 
        }
        static public int exis(int id , string nom)
        {
            utile.connect();
            string req0001 = "select count(*) from Evaluation where (id_etud=" + id + " and nom_matiere ='" + nom + "') ;";
            OleDbCommand cmd1042 = new OleDbCommand(req0001, utile.cn);
            return (int.Parse(cmd1042.ExecuteScalar().ToString()));
        }

         static public note rech (int id, string nom)
        {
 string req001 = "select * from Evaluation where (id_etud=" + id + " and nom_matiere ='" + nom + "') ;";
            OleDbCommand cmd142 = new OleDbCommand(req001, utile.cn);

            OleDbDataReader rd141 = cmd142.ExecuteReader();
            if (rd141.Read())
            { note n; 
                //int nnn = 0;
                if (utile.type_mat == "cc")
                {  n = new note(rd141["nom_matiere"].ToString(), int.Parse(rd141["id_etud"].ToString()), int.Parse(rd141["note_ds"].ToString()), int.Parse(rd141["note_test"].ToString()), int.Parse(rd141["note_ex"].ToString()) ); }
                else if (utile.type_mat == "tp")
                {  n = new note(rd141["nom_matiere"].ToString(), int.Parse(rd141["id_etud"].ToString()),  int.Parse(rd141["note_tp"].ToString()) ); }
                else
                     n = new note(rd141["nom_matiere"].ToString(), int.Parse(rd141["id_etud"].ToString()), int.Parse(rd141["note_ds"].ToString()), int.Parse(rd141["note_test"].ToString()), int.Parse(rd141["note_ex"].ToString()), int.Parse(rd141["note_tp"].ToString()));
                return n;
            }
            else
                return null;
        }

        public void Modif()
        {
            string ajt;
            utile.connect();
            if (utile.type_mat == "tt")
            {  ajt = "update Evaluation set note_ds=" + ds + ",note_test=" + test + ",note_ex=" + ex + ",note_tp=" + tp + " where nom_matiere='" + matier + "'  and id_etud=" + id + "  ;"; }
            else if (utile.type_mat == "cc")
            {  ajt = "update Evaluation set note_ds=" + ds + ",note_test=" + test + ",note_ex=" + ex + " where nom_matiere='" + matier + "'  and id_etud=" + id + "  ;"; }
           else  
            {  ajt = "update Evaluation set note_tp=" + tp + " where nom_matiere='" + matier + "'  and id_etud=" + id + "  ;"; }
            OleDbCommand sav1 = new OleDbCommand(ajt, utile.cn);
            sav1.ExecuteNonQuery();
            utile.closee();
        }
        public void ajttt()
        {
            utile.connect();
            string ajt1 = "insert into Evaluation values('" + matier + "'," + id + " , " + ds + "," + ex + "," + test + "," + tp + " )  ;";
            OleDbCommand sav11 = new OleDbCommand(ajt1, utile.cn);
            sav11.ExecuteNonQuery();
            utile.closee();
        }
        public void ajttp()
        {
            utile.connect();
            string ajt1 = "insert into Evaluation values(nom_matiere'" + matier + "',id_etud=" + id + " , " + tp + " )  ;";
            OleDbCommand sav11 = new OleDbCommand(ajt1, utile.cn);
            sav11.ExecuteNonQuery();
            utile.closee();
        }
        public void ajtcc()
        {
            utile.connect();
            string ajt1 = "insert into Evaluation (nom_matiere,id_etud,note_ds,note_ex,note_test) values('" + matier + "'," + id + " , " + ds + "," + ex + "," + test + ")  ;";
            OleDbCommand sav11 = new OleDbCommand(ajt1, utile.cn);
            sav11.ExecuteNonQuery();
            utile.closee();
        }
    }

}
