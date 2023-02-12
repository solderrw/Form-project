namespace Form_kebab.MenuForm
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbltitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentoChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.paneldd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.BtnGot = new FontAwesome.Sharp.IconButton();
            this.BtnStol = new FontAwesome.Sharp.IconButton();
            this.BtnAdminMenu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentoChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gray;
            this.panelTitleBar.Controls.Add(this.lbltitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentoChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(140, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(660, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbltitleChildForm
            // 
            this.lbltitleChildForm.AutoSize = true;
            this.lbltitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lbltitleChildForm.Location = new System.Drawing.Point(44, 22);
            this.lbltitleChildForm.Name = "lbltitleChildForm";
            this.lbltitleChildForm.Size = new System.Drawing.Size(49, 13);
            this.lbltitleChildForm.TabIndex = 1;
            this.lbltitleChildForm.Text = "Главная";
            // 
            // iconCurrentoChildForm
            // 
            this.iconCurrentoChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentoChildForm.ForeColor = System.Drawing.Color.Black;
            this.iconCurrentoChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentoChildForm.IconColor = System.Drawing.Color.Black;
            this.iconCurrentoChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentoChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentoChildForm.Name = "iconCurrentoChildForm";
            this.iconCurrentoChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentoChildForm.TabIndex = 0;
            this.iconCurrentoChildForm.TabStop = false;
            // 
            // paneldd
            // 
            this.paneldd.Location = new System.Drawing.Point(140, 50);
            this.paneldd.Name = "paneldd";
            this.paneldd.Size = new System.Drawing.Size(660, 400);
            this.paneldd.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnHome.IconColor = System.Drawing.Color.White;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.IconSize = 32;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 109);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(146, 39);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Главная";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 32;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 154);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenu.Size = new System.Drawing.Size(146, 39);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Меню";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // BtnGot
            // 
            this.BtnGot.FlatAppearance.BorderSize = 0;
            this.BtnGot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGot.ForeColor = System.Drawing.Color.White;
            this.BtnGot.IconChar = FontAwesome.Sharp.IconChar.CookieBite;
            this.BtnGot.IconColor = System.Drawing.Color.White;
            this.BtnGot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGot.IconSize = 32;
            this.BtnGot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGot.Location = new System.Drawing.Point(0, 199);
            this.BtnGot.Name = "BtnGot";
            this.BtnGot.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGot.Size = new System.Drawing.Size(146, 39);
            this.BtnGot.TabIndex = 2;
            this.BtnGot.Text = "Готовка";
            this.BtnGot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGot.UseVisualStyleBackColor = true;
            this.BtnGot.Click += new System.EventHandler(this.BtnGot_Click);
            // 
            // BtnStol
            // 
            this.BtnStol.FlatAppearance.BorderSize = 0;
            this.BtnStol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStol.ForeColor = System.Drawing.Color.White;
            this.BtnStol.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.BtnStol.IconColor = System.Drawing.Color.White;
            this.BtnStol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStol.IconSize = 32;
            this.BtnStol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStol.Location = new System.Drawing.Point(0, 244);
            this.BtnStol.Name = "BtnStol";
            this.BtnStol.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnStol.Size = new System.Drawing.Size(146, 39);
            this.BtnStol.TabIndex = 3;
            this.BtnStol.Text = "Столы";
            this.BtnStol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStol.UseVisualStyleBackColor = true;
            this.BtnStol.Click += new System.EventHandler(this.BtnStol_Click);
            // 
            // BtnAdminMenu
            // 
            this.BtnAdminMenu.FlatAppearance.BorderSize = 0;
            this.BtnAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminMenu.ForeColor = System.Drawing.Color.White;
            this.BtnAdminMenu.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.BtnAdminMenu.IconColor = System.Drawing.Color.White;
            this.BtnAdminMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdminMenu.IconSize = 32;
            this.BtnAdminMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminMenu.Location = new System.Drawing.Point(0, 289);
            this.BtnAdminMenu.Name = "BtnAdminMenu";
            this.BtnAdminMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAdminMenu.Size = new System.Drawing.Size(146, 39);
            this.BtnAdminMenu.TabIndex = 4;
            this.BtnAdminMenu.Text = "Меню Админа";
            this.BtnAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdminMenu.UseVisualStyleBackColor = true;
            this.BtnAdminMenu.Click += new System.EventHandler(this.BtnAdminMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelDesktop);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 103);
            this.panel2.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(146, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(651, 400);
            this.panelDesktop.TabIndex = 2;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Gray;
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.BtnAdminMenu);
            this.PanelMenu.Controls.Add(this.BtnStol);
            this.PanelMenu.Controls.Add(this.BtnGot);
            this.PanelMenu.Controls.Add(this.btnMenu);
            this.PanelMenu.Controls.Add(this.BtnHome);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(140, 450);
            this.PanelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneldd);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentoChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentoChildForm;
        private System.Windows.Forms.Label lbltitleChildForm;
        private System.Windows.Forms.Panel paneldd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton BtnGot;
        private FontAwesome.Sharp.IconButton BtnStol;
        private FontAwesome.Sharp.IconButton BtnAdminMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button button1;
    }
}