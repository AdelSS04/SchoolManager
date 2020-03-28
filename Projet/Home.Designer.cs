namespace Projet
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EspaceEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.lesDesplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EspaceProf = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteDesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteDesAbsencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuadmin = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesMatieresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espaceAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLesUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creeUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.bunifuTransition1.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EspaceEtudiant,
            this.EspaceProf,
            this.menuadmin,
            this.espaceAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // EspaceEtudiant
            // 
            this.EspaceEtudiant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesDesplineToolStripMenuItem,
            this.lesNotesToolStripMenuItem,
            this.leClasseToolStripMenuItem});
            this.EspaceEtudiant.Enabled = false;
            this.EspaceEtudiant.Name = "EspaceEtudiant";
            this.EspaceEtudiant.Size = new System.Drawing.Size(102, 20);
            this.EspaceEtudiant.Text = "espace etudiant";
            this.EspaceEtudiant.Click += new System.EventHandler(this.eleveToolStripMenuItem_Click);
            // 
            // lesDesplineToolStripMenuItem
            // 
            this.lesDesplineToolStripMenuItem.Name = "lesDesplineToolStripMenuItem";
            this.lesDesplineToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.lesDesplineToolStripMenuItem.Text = "les absences";
            this.lesDesplineToolStripMenuItem.Click += new System.EventHandler(this.lesDesplineToolStripMenuItem_Click);
            // 
            // lesNotesToolStripMenuItem
            // 
            this.lesNotesToolStripMenuItem.Name = "lesNotesToolStripMenuItem";
            this.lesNotesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.lesNotesToolStripMenuItem.Text = "les notes";
            this.lesNotesToolStripMenuItem.Click += new System.EventHandler(this.lesNotesToolStripMenuItem_Click);
            // 
            // leClasseToolStripMenuItem
            // 
            this.leClasseToolStripMenuItem.Name = "leClasseToolStripMenuItem";
            this.leClasseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.leClasseToolStripMenuItem.Text = "le classe";
            this.leClasseToolStripMenuItem.Click += new System.EventHandler(this.leClasseToolStripMenuItem_Click);
            // 
            // EspaceProf
            // 
            this.EspaceProf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDeClassesToolStripMenuItem,
            this.ajouteDesNotesToolStripMenuItem,
            this.ajouteDesAbsencesToolStripMenuItem});
            this.EspaceProf.Enabled = false;
            this.EspaceProf.Name = "EspaceProf";
            this.EspaceProf.Size = new System.Drawing.Size(116, 20);
            this.EspaceProf.Text = "espace enseignant";
            this.EspaceProf.Click += new System.EventHandler(this.enseignantToolStripMenuItem_Click);
            // 
            // listeDeClassesToolStripMenuItem
            // 
            this.listeDeClassesToolStripMenuItem.Name = "listeDeClassesToolStripMenuItem";
            this.listeDeClassesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listeDeClassesToolStripMenuItem.Text = "Liste de Classes";
            this.listeDeClassesToolStripMenuItem.Click += new System.EventHandler(this.listeDeClassesToolStripMenuItem_Click);
            // 
            // ajouteDesNotesToolStripMenuItem
            // 
            this.ajouteDesNotesToolStripMenuItem.Name = "ajouteDesNotesToolStripMenuItem";
            this.ajouteDesNotesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouteDesNotesToolStripMenuItem.Text = "Ajoute des notes";
            this.ajouteDesNotesToolStripMenuItem.Click += new System.EventHandler(this.ajouteDesNotesToolStripMenuItem_Click);
            // 
            // ajouteDesAbsencesToolStripMenuItem
            // 
            this.ajouteDesAbsencesToolStripMenuItem.Name = "ajouteDesAbsencesToolStripMenuItem";
            this.ajouteDesAbsencesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ajouteDesAbsencesToolStripMenuItem.Text = "Ajoute des absences";
            this.ajouteDesAbsencesToolStripMenuItem.Click += new System.EventHandler(this.ajouteDesAbsencesToolStripMenuItem_Click);
            // 
            // menuadmin
            // 
            this.menuadmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouteEtudiantToolStripMenuItem,
            this.gestionDesClassesToolStripMenuItem,
            this.gestionDesMatieresToolStripMenuItem});
            this.menuadmin.Enabled = false;
            this.menuadmin.Name = "menuadmin";
            this.menuadmin.Size = new System.Drawing.Size(81, 20);
            this.menuadmin.Text = "espace chef";
            this.menuadmin.Click += new System.EventHandler(this.menuadmin_Click);
            // 
            // ajouteEtudiantToolStripMenuItem
            // 
            this.ajouteEtudiantToolStripMenuItem.Name = "ajouteEtudiantToolStripMenuItem";
            this.ajouteEtudiantToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ajouteEtudiantToolStripMenuItem.Text = "Ajoute etudiant";
            this.ajouteEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouteEtudiantToolStripMenuItem_Click);
            // 
            // gestionDesClassesToolStripMenuItem
            // 
            this.gestionDesClassesToolStripMenuItem.Name = "gestionDesClassesToolStripMenuItem";
            this.gestionDesClassesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionDesClassesToolStripMenuItem.Text = "Gestion des classes";
            this.gestionDesClassesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClassesToolStripMenuItem_Click);
            // 
            // gestionDesMatieresToolStripMenuItem
            // 
            this.gestionDesMatieresToolStripMenuItem.Name = "gestionDesMatieresToolStripMenuItem";
            this.gestionDesMatieresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionDesMatieresToolStripMenuItem.Text = "Gestion des matieres";
            this.gestionDesMatieresToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMatieresToolStripMenuItem_Click);
            // 
            // espaceAdminToolStripMenuItem
            // 
            this.espaceAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLesUtilisateurToolStripMenuItem,
            this.creeUnUtilisateurToolStripMenuItem});
            this.espaceAdminToolStripMenuItem.Enabled = false;
            this.espaceAdminToolStripMenuItem.Name = "espaceAdminToolStripMenuItem";
            this.espaceAdminToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.espaceAdminToolStripMenuItem.Text = "espace admin";
            // 
            // modifierLesUtilisateurToolStripMenuItem
            // 
            this.modifierLesUtilisateurToolStripMenuItem.Name = "modifierLesUtilisateurToolStripMenuItem";
            this.modifierLesUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modifierLesUtilisateurToolStripMenuItem.Text = "modifier les utilisateur";
            this.modifierLesUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.modifierLesUtilisateurToolStripMenuItem_Click);
            // 
            // creeUnUtilisateurToolStripMenuItem
            // 
            this.creeUnUtilisateurToolStripMenuItem.Name = "creeUnUtilisateurToolStripMenuItem";
            this.creeUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.creeUnUtilisateurToolStripMenuItem.Text = "Cree un utilisateur";
            this.creeUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.creeUnUtilisateurToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 495);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(77, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenu";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(825, 0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(30, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 21;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(861, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 20;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.menuStrip1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EspaceProf;
        private System.Windows.Forms.ToolStripMenuItem lesDesplineToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem EspaceEtudiant;
        private System.Windows.Forms.ToolStripMenuItem listeDeClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouteDesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouteDesAbsencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuadmin;
        private System.Windows.Forms.ToolStripMenuItem ajouteEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMatieresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espaceAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLesUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creeUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}