namespace SistemBengkel
{
    partial class frmLapTransaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbTglAwal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTglAkhir = new System.Windows.Forms.DateTimePicker();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Form untuk melihat data transaksi secara detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM LAPORAN TRANSAKSI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 100);
            this.panel1.TabIndex = 62;
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampil.Location = new System.Drawing.Point(10, 252);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampil.Size = new System.Drawing.Size(1455, 367);
            this.dgvTampil.TabIndex = 67;
            this.dgvTampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTampil_CellContentClick);
            this.dgvTampil.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTampil_CellFormatting);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(389, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 21);
            this.label16.TabIndex = 69;
            this.label16.Text = "Tanggal Transaksi";
            // 
            // cmbTglAwal
            // 
            this.cmbTglAwal.Location = new System.Drawing.Point(527, 135);
            this.cmbTglAwal.Name = "cmbTglAwal";
            this.cmbTglAwal.Size = new System.Drawing.Size(231, 20);
            this.cmbTglAwal.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(776, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "s.d";
            // 
            // cmbTglAkhir
            // 
            this.cmbTglAkhir.Location = new System.Drawing.Point(822, 135);
            this.cmbTglAkhir.Name = "cmbTglAkhir";
            this.cmbTglAkhir.Size = new System.Drawing.Size(231, 20);
            this.cmbTglAkhir.TabIndex = 72;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(553, 193);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(96, 32);
            this.btnTampilkan.TabIndex = 73;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(687, 193);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(96, 32);
            this.btnBatal.TabIndex = 74;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(822, 193);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(96, 32);
            this.btnKeluar.TabIndex = 75;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 21);
            this.label4.TabIndex = 76;
            this.label4.Text = "Silahkan klik data untuk melihat detail transaksi";
            // 
            // frmLapTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cmbTglAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTglAwal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTampil);
            this.Name = "frmLapTransaksi";
            this.Text = "frmLapTransaksi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTampil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker cmbTglAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker cmbTglAkhir;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label4;
    }
}