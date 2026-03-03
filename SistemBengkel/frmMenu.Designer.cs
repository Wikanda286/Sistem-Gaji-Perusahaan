namespace SistemBengkel
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mASTRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pELANGGANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEGAWAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSAKSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSAKSIPENJUALANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAPORANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAPORANToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kELUARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASTRToolStripMenuItem,
            this.tRANSAKSIToolStripMenuItem,
            this.lAPORANToolStripMenuItem,
            this.kELUARToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mASTRToolStripMenuItem
            // 
            this.mASTRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pELANGGANToolStripMenuItem,
            this.pEGAWAIToolStripMenuItem,
            this.pRODUKToolStripMenuItem});
            this.mASTRToolStripMenuItem.Name = "mASTRToolStripMenuItem";
            this.mASTRToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.mASTRToolStripMenuItem.Text = "MASTER";
            // 
            // pELANGGANToolStripMenuItem
            // 
            this.pELANGGANToolStripMenuItem.Name = "pELANGGANToolStripMenuItem";
            this.pELANGGANToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pELANGGANToolStripMenuItem.Text = "PELANGGAN";
            this.pELANGGANToolStripMenuItem.Click += new System.EventHandler(this.pELANGGANToolStripMenuItem_Click);
            // 
            // pEGAWAIToolStripMenuItem
            // 
            this.pEGAWAIToolStripMenuItem.Name = "pEGAWAIToolStripMenuItem";
            this.pEGAWAIToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pEGAWAIToolStripMenuItem.Text = "PEGAWAI";
            this.pEGAWAIToolStripMenuItem.Click += new System.EventHandler(this.pEGAWAIToolStripMenuItem_Click);
            // 
            // pRODUKToolStripMenuItem
            // 
            this.pRODUKToolStripMenuItem.Name = "pRODUKToolStripMenuItem";
            this.pRODUKToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pRODUKToolStripMenuItem.Text = "PRODUK";
            this.pRODUKToolStripMenuItem.Click += new System.EventHandler(this.pRODUKToolStripMenuItem_Click);
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            this.tRANSAKSIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRANSAKSIPENJUALANToolStripMenuItem});
            this.tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            this.tRANSAKSIToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.tRANSAKSIToolStripMenuItem.Text = "TRANSAKSI";
            // 
            // tRANSAKSIPENJUALANToolStripMenuItem
            // 
            this.tRANSAKSIPENJUALANToolStripMenuItem.Name = "tRANSAKSIPENJUALANToolStripMenuItem";
            this.tRANSAKSIPENJUALANToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.tRANSAKSIPENJUALANToolStripMenuItem.Text = "TRANSAKSI";
            this.tRANSAKSIPENJUALANToolStripMenuItem.Click += new System.EventHandler(this.tRANSAKSIPENJUALANToolStripMenuItem_Click);
            // 
            // lAPORANToolStripMenuItem
            // 
            this.lAPORANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lAPORANToolStripMenuItem1});
            this.lAPORANToolStripMenuItem.Name = "lAPORANToolStripMenuItem";
            this.lAPORANToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.lAPORANToolStripMenuItem.Text = "LAPORAN";
            // 
            // lAPORANToolStripMenuItem1
            // 
            this.lAPORANToolStripMenuItem1.Name = "lAPORANToolStripMenuItem1";
            this.lAPORANToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.lAPORANToolStripMenuItem1.Text = "LAPORAN TRANSAKSI";
            this.lAPORANToolStripMenuItem1.Click += new System.EventHandler(this.lAPORANToolStripMenuItem1_Click);
            // 
            // kELUARToolStripMenuItem
            // 
            this.kELUARToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.kELUARToolStripMenuItem.Name = "kELUARToolStripMenuItem";
            this.kELUARToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.kELUARToolStripMenuItem.Text = "KELUAR";
            this.kELUARToolStripMenuItem.Click += new System.EventHandler(this.kELUARToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mASTRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pELANGGANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEGAWAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSAKSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSAKSIPENJUALANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAPORANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAPORANToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kELUARToolStripMenuItem;
    }
}



