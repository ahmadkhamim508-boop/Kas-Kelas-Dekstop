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
            System.Windows.Forms.Panel panelMain;
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.txtloginSiswa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.checkBoxTampilkanpassword = new System.Windows.Forms.CheckBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            panelMain = new System.Windows.Forms.Panel();
            panelMain.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.DeepSkyBlue;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelMain.Controls.Add(this.label6);
            panelMain.Controls.Add(this.label5);
            panelMain.Controls.Add(this.label4);
            panelMain.Controls.Add(this.label3);
            panelMain.Controls.Add(this.panelCard);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1182, 653);
            panelMain.TabIndex = 2;
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
            // panelCard
            // 
            this.panelCard.AllowDrop = true;
            this.panelCard.BackColor = System.Drawing.Color.SkyBlue;
            this.panelCard.Controls.Add(this.txtloginSiswa);
            this.panelCard.Controls.Add(this.pictureBox1);
            this.panelCard.Controls.Add(this.btnMasuk);
            this.panelCard.Controls.Add(this.checkBoxTampilkanpassword);
            this.panelCard.Controls.Add(this.txtNama);
            this.panelCard.Controls.Add(this.label2);
            this.panelCard.Controls.Add(this.txtPasword);
            this.panelCard.Controls.Add(this.label1);
            this.panelCard.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panelCard.Location = new System.Drawing.Point(177, 71);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(450, 500);
            this.panelCard.TabIndex = 7;
            // 
            // txtloginSiswa
            // 
            this.txtloginSiswa.AutoSize = true;
            this.txtloginSiswa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginSiswa.Location = new System.Drawing.Point(252, 464);
            this.txtloginSiswa.Name = "txtloginSiswa";
            this.txtloginSiswa.Size = new System.Drawing.Size(170, 23);
            this.txtloginSiswa.TabIndex = 10;
            this.txtloginSiswa.Text = "Login sebagai Siswa?";
            this.txtloginSiswa.Click += new System.EventHandler(this.txtloginSiswa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kas_kelas__2_.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(99, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMasuk.Location = new System.Drawing.Point(180, 408);
            this.btnMasuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(112, 45);
            this.btnMasuk.TabIndex = 8;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // checkBoxTampilkanpassword
            // 
            this.checkBoxTampilkanpassword.AutoSize = true;
            this.checkBoxTampilkanpassword.Location = new System.Drawing.Point(118, 376);
            this.checkBoxTampilkanpassword.Name = "checkBoxTampilkanpassword";
            this.checkBoxTampilkanpassword.Size = new System.Drawing.Size(202, 27);
            this.checkBoxTampilkanpassword.TabIndex = 7;
            this.checkBoxTampilkanpassword.Text = "Tampilkan password";
            this.checkBoxTampilkanpassword.UseVisualStyleBackColor = true;
            this.checkBoxTampilkanpassword.CheckedChanged += new System.EventHandler(this.checkBoxTampilkanpassword_CheckedChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(120, 290);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(216, 30);
            this.txtNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(118, 349);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(216, 30);
            this.txtPasword.TabIndex = 3;
            this.txtPasword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(panelMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTampilkanpassword;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtloginSiswa;
    }
}

