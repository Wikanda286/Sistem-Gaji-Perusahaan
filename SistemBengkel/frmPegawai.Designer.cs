namespace SistemBengkel
{
    partial class frmPegawai
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
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPengguna = new System.Windows.Forms.TextBox();
            this.txtSandi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAkses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampil.Location = new System.Drawing.Point(472, 121);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampil.Size = new System.Drawing.Size(989, 494);
            this.dgvTampil.TabIndex = 36;
            this.dgvTampil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTampil_CellClick);
            this.dgvTampil.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTampil_CellFormatting);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(377, 549);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(74, 33);
            this.btnKeluar.TabIndex = 35;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(192, 549);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 33);
            this.btnBatal.TabIndex = 34;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(19, 549);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 33);
            this.btnHapus.TabIndex = 33;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(377, 462);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(74, 33);
            this.btnUbah.TabIndex = 32;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(192, 462);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(74, 33);
            this.btnSimpan.TabIndex = 31;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(19, 462);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(74, 33);
            this.btnTambah.TabIndex = 30;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(133, 133);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(333, 20);
            this.txtID.TabIndex = 29;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(133, 174);
            this.txtNama.MaxLength = 30;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(333, 20);
            this.txtNama.TabIndex = 28;
            // 
            // txtPengguna
            // 
            this.txtPengguna.Location = new System.Drawing.Point(133, 214);
            this.txtPengguna.MaxLength = 30;
            this.txtPengguna.Name = "txtPengguna";
            this.txtPengguna.Size = new System.Drawing.Size(333, 20);
            this.txtPengguna.TabIndex = 27;
            // 
            // txtSandi
            // 
            this.txtSandi.Location = new System.Drawing.Point(133, 257);
            this.txtSandi.MaxLength = 30;
            this.txtSandi.Name = "txtSandi";
            this.txtSandi.PasswordChar = '*';
            this.txtSandi.Size = new System.Drawing.Size(333, 20);
            this.txtSandi.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sandi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nama Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID Pegawai";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(161, 26);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(282, 20);
            this.txtCari.TabIndex = 5;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // cmbCari
            // 
            this.cmbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "ID Pegawai",
            "Nama Pegawai",
            "Nama Pengguna"});
            this.cmbCari.Location = new System.Drawing.Point(4, 25);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(151, 21);
            this.cmbCari.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pencarian";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtCari);
            this.panel2.Controls.Add(this.cmbCari);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 63);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form untuk menambah, mengubah, dan menghapus data pegawai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nama Pengguna";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 100);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM PEGAWAI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Akses";
            // 
            // cmbAkses
            // 
            this.cmbAkses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAkses.FormattingEnabled = true;
            this.cmbAkses.Items.AddRange(new object[] {
            "Admin",
            "Pegawai"});
            this.cmbAkses.Location = new System.Drawing.Point(133, 300);
            this.cmbAkses.Name = "cmbAkses";
            this.cmbAkses.Size = new System.Drawing.Size(333, 21);
            this.cmbAkses.TabIndex = 6;
            // 
            // frmPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 621);
            this.Controls.Add(this.cmbAkses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvTampil);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPengguna);
            this.Controls.Add(this.txtSandi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmPegawai";
            this.Text = "frmPegawai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTampil;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPengguna;
        private System.Windows.Forms.TextBox txtSandi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAkses;
    }
}