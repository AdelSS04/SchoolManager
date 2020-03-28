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
    public partial class erure : Form
    {
        public erure()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void erure_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = utile.errure_type;
        }
    }
}
