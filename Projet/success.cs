using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class success : Form
    {
        public success()
        {
            InitializeComponent();
            label2.Text = utile.pop + " avec";
        }

        private void success_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            delayy.Start();
            suc.Enabled = true ;
            
        }

       

        private void delayy_Tick(object sender, EventArgs e)
        {
            suc.Enabled = false;
            delayy.Stop();
            BTok.Visible = true;
        }

        private void BTok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
