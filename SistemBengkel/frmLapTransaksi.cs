using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemBengkel
{
    public partial class frmLapTransaksi : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public static string id;
        public frmLapTransaksi()
        {
            koneksi.Close();
            InitializeComponent();
            tampilkanData();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from v_laptransaksi", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void tampil()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from v_laptransaksi where [Tanggal Transaksi] between '" + cmbTglAwal.Value.ToString("yyyy-MM-dd") + "' and '" +
                                                   cmbTglAkhir.Value.ToString("yyyy-MM-dd") + "'",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tampilkanData();
            cmbTglAwal.Value = DateTime.Now;
            cmbTglAkhir.Value = DateTime.Now;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvTampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvTampil.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            frmLapDetailTrans frm = new frmLapDetailTrans();
            frm.ShowDialog();
        }

        private void dgvTampil_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int row = dgvTampil.CurrentCell.RowIndex;
                if (e.ColumnIndex == 9 && e.RowIndex >= row)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                    {
                        e.Value = cellValue.ToString("C");
                        e.FormattingApplied = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
