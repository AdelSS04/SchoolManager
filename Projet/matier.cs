using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Projet
{
    class matier
    {
        public int nbr_abs, coef;
        public string type ,nom;
        public matier(int nbr_abs, int coef, string nom,string type)
        {
            this.nbr_abs = nbr_abs; this.coef = coef; this.nom = nom; ;this.type = type;

        }

        public void ajouter()
        {
            utile.connect();
            string cnstrr = "insert into  matiere values ('" + nom + "'," + coef + "," + nbr_abs + ",'"+type+"');";
            OleDbCommand cmd14 = new OleDbCommand(cnstrr, utile.cn);
            cmd14.ExecuteNonQuery();
            utile.closee();

        }

    }
}
