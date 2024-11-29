namespace Daftar_Hadir
{
    partial class MenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.flowAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.flowGuru = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.flowLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.flowInput = new System.Windows.Forms.ToolStripMenuItem();
            this.flowUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.flowDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.stripLainnya = new System.Windows.Forms.ToolStripMenuItem();
            this.flowDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.flowAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLogin,
            this.stripMenu,
            this.stripLainnya});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripLogin
            // 
            this.stripLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowAdmin,
            this.flowGuru,
            this.toolStripMenuItem1,
            this.flowLogout});
            this.stripLogin.Name = "stripLogin";
            this.stripLogin.Size = new System.Drawing.Size(60, 24);
            this.stripLogin.Text = "Login";
            // 
            // flowAdmin
            // 
            this.flowAdmin.Name = "flowAdmin";
            this.flowAdmin.Size = new System.Drawing.Size(145, 26);
            this.flowAdmin.Text = "Admin";
            this.flowAdmin.Click += new System.EventHandler(this.flowAdmin_Click);
            // 
            // flowGuru
            // 
            this.flowGuru.Name = "flowGuru";
            this.flowGuru.Size = new System.Drawing.Size(224, 26);
            this.flowGuru.Text = "Guru";
            this.flowGuru.Click += new System.EventHandler(this.flowGuru_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // flowLogout
            // 
            this.flowLogout.Name = "flowLogout";
            this.flowLogout.Size = new System.Drawing.Size(145, 26);
            this.flowLogout.Text = "Log Out";
            this.flowLogout.Click += new System.EventHandler(this.flowLogout_Click);
            // 
            // stripMenu
            // 
            this.stripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowInput,
            this.flowUpdate,
            this.flowDelete});
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(60, 24);
            this.stripMenu.Text = "Menu";
           
            // flowInput
            // 
            this.flowInput.Name = "flowInput";
            this.flowInput.Size = new System.Drawing.Size(177, 26);
            this.flowInput.Text = "Input Data";
            this.flowInput.Click += new System.EventHandler(this.flowInput_Click);
            // 
            // flowUpdate
            // 
            this.flowUpdate.Name = "flowUpdate";
            this.flowUpdate.Size = new System.Drawing.Size(224, 26);
            this.flowUpdate.Text = "Update Data";
            this.flowUpdate.Click += new System.EventHandler(this.flowUpdate_Click);
            // 
            // flowDelete
            // 
            this.flowDelete.Name = "flowDelete";
            this.flowDelete.Size = new System.Drawing.Size(224, 26);
            this.flowDelete.Text = "Delete Data";
            this.flowDelete.Click += new System.EventHandler(this.flowDelete_Click);
            // 
            // stripLainnya
            // 
            this.stripLainnya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowDisplay,
            this.flowAbout});
            this.stripLainnya.Name = "stripLainnya";
            this.stripLainnya.Size = new System.Drawing.Size(73, 24);
            this.stripLainnya.Text = "Lainnya";
            // 
            // flowDisplay
            // 
            this.flowDisplay.Name = "flowDisplay";
            this.flowDisplay.Size = new System.Drawing.Size(224, 26);
            this.flowDisplay.Text = "Display data";
            this.flowDisplay.Click += new System.EventHandler(this.flowDisplay_Click);
            // 
            // flowAbout
            // 
            this.flowAbout.Name = "flowAbout";
            this.flowAbout.Size = new System.Drawing.Size(224, 26);
            this.flowAbout.Text = "About";
            this.flowAbout.Click += new System.EventHandler(this.flowAbout_Click);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daftar_Hadir.Properties.Resources.pixai_1818681087112992283_3;
            this.ClientSize = new System.Drawing.Size(1132, 733);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUtama";
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem stripLogin;
        public System.Windows.Forms.ToolStripMenuItem stripMenu;
        public System.Windows.Forms.ToolStripMenuItem flowInput;
        public System.Windows.Forms.ToolStripMenuItem flowUpdate;
        public System.Windows.Forms.ToolStripMenuItem stripLainnya;
        public System.Windows.Forms.ToolStripMenuItem flowAdmin;
        public System.Windows.Forms.ToolStripMenuItem flowGuru;
        public System.Windows.Forms.ToolStripMenuItem flowDelete;
        public System.Windows.Forms.ToolStripMenuItem flowDisplay;
        public System.Windows.Forms.ToolStripMenuItem flowAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem flowLogout;
    }
}