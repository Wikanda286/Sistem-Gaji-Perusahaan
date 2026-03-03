namespace SistemBengkel
{
    partial class frmTransaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPlat = new System.Windows.Forms.TextBox();
            this.txtTotalBayar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTglT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPegawai = new System.Windows.Forms.TextBox();
            this.cmbIDP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKet = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbProduk = new System.Windows.Forms.ComboBox();
            this.txtTotalH = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlaP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form untuk menambah data transaksi bengkel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM TRANSAKSI";
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTampil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampil.Location = new System.Drawing.Point(985, 121);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampil.Size = new System.Drawing.Size(482, 494);
            this.dgvTampil.TabIndex = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID HTransaksi";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Jenis Detail Transaksi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Produk";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Keterangan";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah Produk";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Harga";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Harga";
            this.Column6.Name = "Column6";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(683, 521);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(74, 33);
            this.btnKeluar.TabIndex = 54;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(522, 521);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(74, 33);
            this.btnHapus.TabIndex = 52;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(205, 521);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(74, 33);
            this.btnTambah.TabIndex = 49;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 20);
            this.txtID.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "ID Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "ID HTransaksi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 100);
            this.panel1.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJenis);
            this.groupBox2.Controls.Add(this.txtNama);
            this.groupBox2.Controls.Add(this.txtPlat);
            this.groupBox2.Controls.Add(this.txtTotalBayar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbTglT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPegawai);
            this.groupBox2.Controls.Add(this.cmbIDP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 335);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kepala Penjualan";
            // 
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(165, 177);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(251, 20);
            this.txtJenis.TabIndex = 61;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(165, 216);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(251, 20);
            this.txtNama.TabIndex = 60;
            // 
            // txtPlat
            // 
            this.txtPlat.Location = new System.Drawing.Point(165, 259);
            this.txtPlat.MaxLength = 15;
            this.txtPlat.Name = "txtPlat";
            this.txtPlat.Size = new System.Drawing.Size(251, 20);
            this.txtPlat.TabIndex = 59;
            // 
            // txtTotalBayar
            // 
            this.txtTotalBayar.Location = new System.Drawing.Point(165, 300);
            this.txtTotalBayar.Name = "txtTotalBayar";
            this.txtTotalBayar.ReadOnly = true;
            this.txtTotalBayar.Size = new System.Drawing.Size(251, 20);
            this.txtTotalBayar.TabIndex = 58;
            this.txtTotalBayar.TextChanged += new System.EventHandler(this.txtTotalBayar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 21);
            this.label10.TabIndex = 57;
            this.label10.Text = "Total Harga Bayar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 56;
            this.label9.Text = "Plat Nomor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 55;
            this.label8.Text = "Nama Kendaraan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Jenis Kendaraan";
            // 
            // cmbTglT
            // 
            this.cmbTglT.Location = new System.Drawing.Point(165, 135);
            this.cmbTglT.Name = "cmbTglT";
            this.cmbTglT.Size = new System.Drawing.Size(251, 20);
            this.cmbTglT.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tanggal Transaksi";
            // 
            // txtPegawai
            // 
            this.txtPegawai.Location = new System.Drawing.Point(165, 95);
            this.txtPegawai.Name = "txtPegawai";
            this.txtPegawai.Size = new System.Drawing.Size(251, 20);
            this.txtPegawai.TabIndex = 51;
            // 
            // cmbIDP
            // 
            this.cmbIDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDP.FormattingEnabled = true;
            this.cmbIDP.Location = new System.Drawing.Point(165, 55);
            this.cmbIDP.Name = "cmbIDP";
            this.cmbIDP.Size = new System.Drawing.Size(251, 21);
            this.cmbIDP.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "ID Pegawai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKet);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbProduk);
            this.groupBox1.Controls.Add(this.txtTotalH);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.txtJumlaP);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbJenis);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtIDH);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(466, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 335);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Penjualan";
            // 
            // txtKet
            // 
            this.txtKet.Location = new System.Drawing.Point(197, 135);
            this.txtKet.MaxLength = 30;
            this.txtKet.Name = "txtKet";
            this.txtKet.Size = new System.Drawing.Size(251, 20);
            this.txtKet.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 21);
            this.label17.TabIndex = 73;
            this.label17.Text = "Keterangan";
            // 
            // cmbProduk
            // 
            this.cmbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduk.FormattingEnabled = true;
            this.cmbProduk.Location = new System.Drawing.Point(197, 95);
            this.cmbProduk.Name = "cmbProduk";
            this.cmbProduk.Size = new System.Drawing.Size(251, 21);
            this.cmbProduk.TabIndex = 72;
            this.cmbProduk.SelectionChangeCommitted += new System.EventHandler(this.cmbProduk_SelectionChangeCommitted);
            // 
            // txtTotalH
            // 
            this.txtTotalH.Location = new System.Drawing.Point(197, 259);
            this.txtTotalH.Name = "txtTotalH";
            this.txtTotalH.ReadOnly = true;
            this.txtTotalH.Size = new System.Drawing.Size(251, 20);
            this.txtTotalH.TabIndex = 71;
            this.txtTotalH.TextChanged += new System.EventHandler(this.txtTotalH_TextChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(197, 220);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(251, 20);
            this.txtHarga.TabIndex = 70;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // txtJumlaP
            // 
            this.txtJumlaP.Location = new System.Drawing.Point(197, 181);
            this.txtJumlaP.Name = "txtJumlaP";
            this.txtJumlaP.Size = new System.Drawing.Size(251, 20);
            this.txtJumlaP.TabIndex = 69;
            this.txtJumlaP.TextChanged += new System.EventHandler(this.txtJumlaP_TextChanged);
            this.txtJumlaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlaP_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 68;
            this.label16.Text = "Total Harga";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 21);
            this.label15.TabIndex = 67;
            this.label15.Text = "Harga";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 21);
            this.label14.TabIndex = 66;
            this.label14.Text = "Jumlah Produk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "ID Produk";
            // 
            // cmbJenis
            // 
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Produk",
            "Jasa"});
            this.cmbJenis.Location = new System.Drawing.Point(197, 56);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(251, 21);
            this.cmbJenis.TabIndex = 62;
            this.cmbJenis.SelectionChangeCommitted += new System.EventHandler(this.cmbJenis_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 21);
            this.label12.TabIndex = 64;
            this.label12.Text = "Jenis Detail Transaksi";
            // 
            // txtIDH
            // 
            this.txtIDH.Location = new System.Drawing.Point(197, 19);
            this.txtIDH.Name = "txtIDH";
            this.txtIDH.Size = new System.Drawing.Size(158, 20);
            this.txtIDH.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 62;
            this.label11.Text = "ID HTransaksi";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(371, 521);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(74, 33);
            this.btnProses.TabIndex = 61;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 621);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTampil);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmTransaksi";
            this.Text = "frmTransaksi";
            this.Load += new System.EventHandler(this.frmTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTampil;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPlat;
        private System.Windows.Forms.TextBox txtTotalBayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker cmbTglT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPegawai;
        private System.Windows.Forms.ComboBox cmbIDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProduk;
        private System.Windows.Forms.TextBox txtTotalH;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlaP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtKet;
        private System.Windows.Forms.Label label17;
    }
}