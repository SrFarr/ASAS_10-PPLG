namespace Daftar_Hadir
{
    partial class FrmUpd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXTBnama = new System.Windows.Forms.TextBox();
            this.TXTBabsen = new System.Windows.Forms.TextBox();
            this.CMBkelas = new System.Windows.Forms.ComboBox();
            this.CMBket = new System.Windows.Forms.ComboBox();
            this.BTNupd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(579, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TXTBnama
            // 
            this.TXTBnama.Location = new System.Drawing.Point(90, 17);
            this.TXTBnama.Name = "TXTBnama";
            this.TXTBnama.Size = new System.Drawing.Size(351, 22);
            this.TXTBnama.TabIndex = 1;
            // 
            // TXTBabsen
            // 
            this.TXTBabsen.Location = new System.Drawing.Point(90, 55);
            this.TXTBabsen.Name = "TXTBabsen";
            this.TXTBabsen.Size = new System.Drawing.Size(351, 22);
            this.TXTBabsen.TabIndex = 1;
            this.TXTBabsen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBabsen_KeyPress);
            // 
            // CMBkelas
            // 
            this.CMBkelas.FormattingEnabled = true;
            this.CMBkelas.Location = new System.Drawing.Point(90, 100);
            this.CMBkelas.Name = "CMBkelas";
            this.CMBkelas.Size = new System.Drawing.Size(120, 24);
            this.CMBkelas.TabIndex = 2;
            // 
            // CMBket
            // 
            this.CMBket.FormattingEnabled = true;
            this.CMBket.Location = new System.Drawing.Point(321, 100);
            this.CMBket.Name = "CMBket";
            this.CMBket.Size = new System.Drawing.Size(120, 24);
            this.CMBket.TabIndex = 2;
            // 
            // BTNupd
            // 
            this.BTNupd.ForeColor = System.Drawing.Color.Black;
            this.BTNupd.Location = new System.Drawing.Point(204, 155);
            this.BTNupd.Name = "BTNupd";
            this.BTNupd.Size = new System.Drawing.Size(89, 55);
            this.BTNupd.TabIndex = 3;
            this.BTNupd.Text = "UPDATE";
            this.BTNupd.UseVisualStyleBackColor = true;
            this.BTNupd.Click += new System.EventHandler(this.BTNupd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BTNupd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CMBket);
            this.groupBox1.Controls.Add(this.CMBkelas);
            this.groupBox1.Controls.Add(this.TXTBabsen);
            this.groupBox1.Controls.Add(this.TXTBnama);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(141, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(90, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "TUTUP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Keterangan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kelas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Absen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(243, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "UPDATE DATA";
            // 
            // FrmUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daftar_Hadir.Properties.Resources.pixai_1817402893252918257_1;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpd";
            this.Load += new System.EventHandler(this.FrmUpd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTBnama;
        private System.Windows.Forms.TextBox TXTBabsen;
        private System.Windows.Forms.ComboBox CMBkelas;
        private System.Windows.Forms.ComboBox CMBket;
        private System.Windows.Forms.Button BTNupd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}