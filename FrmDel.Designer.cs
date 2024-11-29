namespace Daftar_Hadir
{
    partial class FrmDel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonInp = new System.Windows.Forms.Button();
            this.TXTBnm = new System.Windows.Forms.TextBox();
            this.TXTBabs = new System.Windows.Forms.TextBox();
            this.CMBklas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBket = new System.Windows.Forms.ComboBox();
            this.BTNback = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(249, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delete data";
            // 
            // ButtonInp
            // 
            this.ButtonInp.Location = new System.Drawing.Point(159, 198);
            this.ButtonInp.Name = "ButtonInp";
            this.ButtonInp.Size = new System.Drawing.Size(149, 57);
            this.ButtonInp.TabIndex = 1;
            this.ButtonInp.Text = "Delete Data";
            this.ButtonInp.UseVisualStyleBackColor = true;
            this.ButtonInp.Click += new System.EventHandler(this.ButtonInp_Click);
            // 
            // TXTBnm
            // 
            this.TXTBnm.Location = new System.Drawing.Point(99, 17);
            this.TXTBnm.Name = "TXTBnm";
            this.TXTBnm.Size = new System.Drawing.Size(353, 22);
            this.TXTBnm.TabIndex = 3;
            // 
            // TXTBabs
            // 
            this.TXTBabs.Location = new System.Drawing.Point(99, 75);
            this.TXTBabs.Name = "TXTBabs";
            this.TXTBabs.Size = new System.Drawing.Size(353, 22);
            this.TXTBabs.TabIndex = 3;
            // 
            // CMBklas
            // 
            this.CMBklas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMBklas.FormattingEnabled = true;
            this.CMBklas.Location = new System.Drawing.Point(99, 125);
            this.CMBklas.Name = "CMBklas";
            this.CMBklas.Size = new System.Drawing.Size(124, 24);
            this.CMBklas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Absen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(232, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Keterangan";
            // 
            // CMBket
            // 
            this.CMBket.FormattingEnabled = true;
            this.CMBket.Items.AddRange(new object[] {
            "Hadir",
            "Sakit",
            "Izin",
            "Alpha"});
            this.CMBket.Location = new System.Drawing.Point(319, 125);
            this.CMBket.Name = "CMBket";
            this.CMBket.Size = new System.Drawing.Size(133, 24);
            this.CMBket.TabIndex = 7;
            // 
            // BTNback
            // 
            this.BTNback.Location = new System.Drawing.Point(35, 215);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(95, 40);
            this.BTNback.TabIndex = 8;
            this.BTNback.Text = "TUTUP";
            this.BTNback.UseVisualStyleBackColor = true;
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BTNback);
            this.groupBox2.Controls.Add(this.CMBket);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CMBklas);
            this.groupBox2.Controls.Add(this.TXTBabs);
            this.groupBox2.Controls.Add(this.TXTBnm);
            this.groupBox2.Controls.Add(this.ButtonInp);
            this.groupBox2.Location = new System.Drawing.Point(129, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 278);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // FrmDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Daftar_Hadir.Properties.Resources.pixai_1818680557889610399;
            this.ClientSize = new System.Drawing.Size(737, 722);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDel";
            this.Load += new System.EventHandler(this.FrmDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonInp;
        private System.Windows.Forms.TextBox TXTBnm;
        private System.Windows.Forms.TextBox TXTBabs;
        private System.Windows.Forms.ComboBox CMBklas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBket;
        private System.Windows.Forms.Button BTNback;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}