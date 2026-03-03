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
    public partial class frmLapDetailTrans : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public frmLapDetailTrans()
        {
            koneksi.Close();
            InitializeComponent();
            tampilkanData();
            tampilkanDetail();
            tampilkanJasa();
        }
        
        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from v_laptransaksi where [ID Transaksi] = '" + frmLapTransaksi.id + "'", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvKepala.DataSource = ds.Tables[0];
        }

        private void tampilkanDetail()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from v_lapDetailTrans where [ID Transaksi] = '" + frmLapTransaksi.id + "'  and [Jenis Detail Transaksi] = 'Produk'", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvDetail.DataSource = ds.Tables[0];
        }
        private void tampilkanJasa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from v_lapDetailJasa where [ID Transaksi] = '" + frmLapTransaksi.id + "' and [Jenis Detail Transaksi] = 'Jasa'", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvJasa.DataSource = ds.Tables[0];
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLapTransaksi frm = new frmLapTransaksi();
            frm.ShowDialog();
        }

        private void dgvKepala_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int row = dgvKepala.CurrentCell.RowIndex;
                if (e.ColumnIndex == 9 && e.RowIndex >= row)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                    {
                        e.Value = cellValue.ToString("N0");
                        e.FormattingApplied = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int row = dgvDetail.CurrentCell.RowIndex;
                if (e.ColumnIndex == 6 || e.ColumnIndex == 7 && e.RowIndex >= row)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                    {
                        e.Value = cellValue.ToString("N0");
                        e.FormattingApplied = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvJasa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int row = dgvDetail.CurrentCell.RowIndex;
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5 && e.RowIndex >= row)
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double cellValue))
                    {
                        e.Value = cellValue.ToString("N0");
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
