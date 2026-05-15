namespace kas_kelas__2_
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSiswa = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxTampilkanpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kas_kelas__2_.Properties.Resources.ChatGPT_Image_Apr_15__2026__01_44_58_PM;
            this.pictureBox1.Location = new System.Drawing.Point(100, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSiswa
            // 
            this.btnSiswa.Location = new System.Drawing.Point(147, 264);
            this.btnSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new System.Drawing.Size(67, 27);
            this.btnSiswa.TabIndex = 0;
            this.btnSiswa.Text = "Siswa";
            this.btnSiswa.UseVisualStyleBackColor = true;
            this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(220, 264);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(67, 27);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(108, 329);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(216, 22);
            this.txtNama.TabIndex = 2;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(108, 388);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(216, 22);
            this.txtPasword.TabIndex = 3;
            this.txtPasword.TextChanged += new System.EventHandler(this.txtPasword_TextChanged);
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMasuk.Location = new System.Drawing.Point(151, 442);
            this.btnMasuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(112, 45);
            this.btnMasuk.TabIndex = 4;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelCard);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1182, 653);
            this.panelMain.TabIndex = 2;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.checkBoxTampilkanpassword);
            this.panelCard.Controls.Add(this.txtNama);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.txtPasword);
            this.panelCard.Controls.Add(this.btnAdmin);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.Controls.Add(this.btnMasuk);
            this.panelCard.Controls.Add(this.btnSiswa);
            this.panelCard.Location = new System.Drawing.Point(177, 71);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(450, 500);
            this.panelCard.TabIndex = 7;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selamat Datang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "di Kas Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(688, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kelola keuangan kelas dengan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(688, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "mudah, aman, dan transparan";
            // 
            // checkBoxTampilkanpassword
            // 
            this.checkBoxTampilkanpassword.AutoSize = true;
            this.checkBoxTampilkanpassword.Location = new System.Drawing.Point(108, 415);
            this.checkBoxTampilkanpassword.Name = "checkBoxTampilkanpassword";
            this.checkBoxTampilkanpassword.Size = new System.Drawing.Size(155, 20);
            this.checkBoxTampilkanpassword.TabIndex = 7;
            this.checkBoxTampilkanpassword.Text = "Tampilkan password";
            this.checkBoxTampilkanpassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSiswa;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTampilkanpassword;
    }
}

