namespace YouCatch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.btnChanale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDownloadNow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblMessage);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1078, 57);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "\tβeta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblMessage.Location = new System.Drawing.Point(72, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(268, 38);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "YouCatch Down v1.0\r\n";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1036, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlSlide.Controls.Add(this.btnChanale);
            this.pnlSlide.Controls.Add(this.btnPlaylist);
            this.pnlSlide.Controls.Add(this.btnDownloadNow);
            this.pnlSlide.Controls.Add(this.btnAbout);
            this.pnlSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlide.Location = new System.Drawing.Point(0, 57);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(241, 499);
            this.pnlSlide.TabIndex = 1;
            // 
            // btnChanale
            // 
            this.btnChanale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.btnChanale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnChanale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChanale.BorderRadius = 0;
            this.btnChanale.ButtonText = "                     Download Chanel";
            this.btnChanale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChanale.DisabledColor = System.Drawing.Color.Gray;
            this.btnChanale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChanale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChanale.Iconimage")));
            this.btnChanale.Iconimage_right = null;
            this.btnChanale.Iconimage_right_Selected = null;
            this.btnChanale.Iconimage_Selected = null;
            this.btnChanale.IconMarginLeft = 20;
            this.btnChanale.IconMarginRight = 0;
            this.btnChanale.IconRightVisible = true;
            this.btnChanale.IconRightZoom = 0D;
            this.btnChanale.IconVisible = true;
            this.btnChanale.IconZoom = 70D;
            this.btnChanale.IsTab = true;
            this.btnChanale.Location = new System.Drawing.Point(0, 123);
            this.btnChanale.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnChanale.Name = "btnChanale";
            this.btnChanale.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnChanale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnChanale.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChanale.selected = false;
            this.btnChanale.Size = new System.Drawing.Size(254, 62);
            this.btnChanale.TabIndex = 3;
            this.btnChanale.Text = "                     Download Chanel";
            this.btnChanale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChanale.Textcolor = System.Drawing.Color.White;
            this.btnChanale.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanale.Click += new System.EventHandler(this.btnChanale_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.btnPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaylist.BorderRadius = 0;
            this.btnPlaylist.ButtonText = "                     Download Playlist";
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlaylist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Iconimage")));
            this.btnPlaylist.Iconimage_right = null;
            this.btnPlaylist.Iconimage_right_Selected = null;
            this.btnPlaylist.Iconimage_Selected = null;
            this.btnPlaylist.IconMarginLeft = 20;
            this.btnPlaylist.IconMarginRight = 0;
            this.btnPlaylist.IconRightVisible = true;
            this.btnPlaylist.IconRightZoom = 0D;
            this.btnPlaylist.IconVisible = true;
            this.btnPlaylist.IconZoom = 70D;
            this.btnPlaylist.IsTab = true;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 62);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPlaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPlaylist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlaylist.selected = false;
            this.btnPlaylist.Size = new System.Drawing.Size(254, 62);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Text = "                     Download Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Textcolor = System.Drawing.Color.White;
            this.btnPlaylist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnDownloadNow
            // 
            this.btnDownloadNow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.btnDownloadNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDownloadNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownloadNow.BorderRadius = 0;
            this.btnDownloadNow.ButtonText = "                      Download Now";
            this.btnDownloadNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadNow.DisabledColor = System.Drawing.Color.Gray;
            this.btnDownloadNow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDownloadNow.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDownloadNow.Iconimage")));
            this.btnDownloadNow.Iconimage_right = null;
            this.btnDownloadNow.Iconimage_right_Selected = null;
            this.btnDownloadNow.Iconimage_Selected = null;
            this.btnDownloadNow.IconMarginLeft = 20;
            this.btnDownloadNow.IconMarginRight = 0;
            this.btnDownloadNow.IconRightVisible = true;
            this.btnDownloadNow.IconRightZoom = 0D;
            this.btnDownloadNow.IconVisible = true;
            this.btnDownloadNow.IconZoom = 70D;
            this.btnDownloadNow.IsTab = true;
            this.btnDownloadNow.Location = new System.Drawing.Point(0, 1);
            this.btnDownloadNow.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnDownloadNow.Name = "btnDownloadNow";
            this.btnDownloadNow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDownloadNow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDownloadNow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDownloadNow.selected = false;
            this.btnDownloadNow.Size = new System.Drawing.Size(254, 62);
            this.btnDownloadNow.TabIndex = 1;
            this.btnDownloadNow.Text = "                      Download Now";
            this.btnDownloadNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadNow.Textcolor = System.Drawing.Color.White;
            this.btnDownloadNow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadNow.Click += new System.EventHandler(this.btnDownloadNow_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "                        About";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage")));
            this.btnAbout.Iconimage_right = null;
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 20;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 70D;
            this.btnAbout.IsTab = true;
            this.btnAbout.Location = new System.Drawing.Point(-1, 439);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(5, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(254, 62);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "                        About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.White;
            this.btnAbout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(241, 57);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(837, 499);
            this.pnlMiddle.TabIndex = 2;
            this.pnlMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMiddle_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 556);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouCatch - YouTube Downloader";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlSlide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnChanale;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlaylist;
        private Bunifu.Framework.UI.BunifuFlatButton btnDownloadNow;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
    }
}

