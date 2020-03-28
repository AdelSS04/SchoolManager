namespace Projet
{
    partial class erure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(erure));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTok = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1, 127);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(222, 24);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 112);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BTok
            // 
            this.BTok.Activecolor = System.Drawing.Color.Red;
            this.BTok.BackColor = System.Drawing.Color.White;
            this.BTok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTok.BorderRadius = 5;
            this.BTok.ButtonText = "OK !";
            this.BTok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTok.DisabledColor = System.Drawing.Color.Gray;
            this.BTok.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTok.Iconcolor = System.Drawing.Color.Transparent;
            this.BTok.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTok.Iconimage")));
            this.BTok.Iconimage_right = null;
            this.BTok.Iconimage_right_Selected = null;
            this.BTok.Iconimage_Selected = null;
            this.BTok.IconMarginLeft = 0;
            this.BTok.IconMarginRight = 0;
            this.BTok.IconRightVisible = true;
            this.BTok.IconRightZoom = 0D;
            this.BTok.IconVisible = false;
            this.BTok.IconZoom = 90D;
            this.BTok.IsTab = false;
            this.BTok.Location = new System.Drawing.Point(155, 155);
            this.BTok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTok.Name = "BTok";
            this.BTok.Normalcolor = System.Drawing.Color.White;
            this.BTok.OnHovercolor = System.Drawing.Color.Maroon;
            this.BTok.OnHoverTextColor = System.Drawing.Color.White;
            this.BTok.selected = false;
            this.BTok.Size = new System.Drawing.Size(101, 38);
            this.BTok.TabIndex = 20;
            this.BTok.Text = "OK !";
            this.BTok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTok.Textcolor = System.Drawing.Color.Black;
            this.BTok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTok.Click += new System.EventHandler(this.BTok_Click);
            // 
            // erure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(402, 201);
            this.Controls.Add(this.BTok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "erure";
            this.Text = "erure";
            this.Load += new System.EventHandler(this.erure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton BTok;
    }
}