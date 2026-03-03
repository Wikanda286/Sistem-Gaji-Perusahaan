namespace SistemBengkel
{
    partial class frmLapDetailTrans
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dgvKepala = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvJasa = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKepala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(444, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORM LAPORAN DETAIL TRANSAKSI";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(694, 583);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(96, 32);
            this.btnKeluar.TabIndex = 85;
            this.btnKeluar.Text = "Kembali";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 100);
            this.panel1.TabIndex = 77;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetail.Location = new System.Drawing.Point(9, 251);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1453, 142);
            this.dgvDetail.TabIndex = 78;
            this.dgvDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetail_CellFormatting);
            // 
            // dgvKepala
            // 
            this.dgvKepala.AllowUserToAddRows = false;
            this.dgvKepala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKepala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKepala.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKepala.Location = new System.Drawing.Point(9, 138);
            this.dgvKepala.Name = "dgvKepala";
            this.dgvKepala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKepala.Size = new System.Drawing.Size(1453, 69);
            this.dgvKepala.TabIndex = 86;
            this.dgvKepala.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKepala_CellFormatting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Kepala Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 88;
            this.label3.Text = "Detail Transaksi Produk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Detail Transaksi Jasa";
            // 
            // dgvJasa
            // 
            this.dgvJasa.AllowUserToAddRows = false;
            this.dgvJasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJasa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJasa.Location = new System.Drawing.Point(9, 435);
            this.dgvJasa.Name = "dgvJasa";
            this.dgvJasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJasa.Size = new System.Drawing.Size(1453, 142);
            this.dgvJasa.TabIndex = 89;
            this.dgvJasa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvJasa_CellFormatting);
            // 
            // frmLapDetailTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvJasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvKepala);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDetail);
            this.Name = "frmLapDetailTrans";
            this.Text = "frmLapDetailTrans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKepala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvKepala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvJasa;
    }
}