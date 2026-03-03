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
    public partial class frmProduk : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public frmProduk()
        {
            koneksi.Close();
            InitializeComponent();
            kosong();
            nonaktif();
            tampilkanData();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from t_produk",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void nonaktif()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtHarga.Enabled = false;
            txtStok.Enabled = false;

            btnTambah.Enabled = true;
            btnSimpan.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void aktif()
        {
            txtNama.Enabled = true;
            txtHarga.Enabled = true;
            txtStok.Enabled = true;

            btnTambah.Enabled = false;
            btnSimpan.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void cari()
        {
            String sql;
            if(cmbCari.Text == "Nama Produk")
            {
                sql = "select * from t_produk where nama_produk like '%" + txtCari.Text + "%'";
            } else if(cmbCari.Text == "Harga Produk")
            {
                sql = "select * from t_produk where harga like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_produk where id_produk like '%" + txtCari.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void kodeOtomatis()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_produk order by id_produk desc", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if(rs.HasRows)
            {
                String kode = rs["id_produk"].ToString();
                int valkode = int.Parse(kode.Substring(2,3));
                String kodef = (valkode + 1).ToString();

                if(kodef.Length == 1)
                {
                    txtID.Text = "PR00" + kodef;
                }else if(kodef.Length == 2)
                {
                    txtID.Text = "PR0" + kodef;
                }else if(kodef.Length == 3)
                {
                    txtID.Text = "PR" + kodef;
                }
            }
            else
            {
                txtID.Text = "PR001";
            }
            rs.Close();
            cmd.Dispose();
            txtNama.Focus();
            koneksi.Close();
        }

        private void kosong()
        {
            txtID.Clear();
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            cmbCari.SelectedIndex = 0;
        }

        private void ambildata()
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            txtID.Text = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNama.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtStok.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            txtHarga.Text = dgvTampil.Rows[row].Cells[3].Value.ToString();
        }

        private void simpan()
        {
            koneksi.Open();
            cmd = new SqlCommand("insert into t_produk values ('" + txtID.Text + "','" +
                                 txtNama.Text + "','" +
                                 txtStok.Text.Replace(",", "") + "','" +
                                 txtHarga.Text.Replace(",","") + "')", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil disimpan","Informasi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void ubah()
        {
            koneksi.Open();
            cmd = new SqlCommand("update t_produk set nama_produk = '" + txtNama.Text + 
                                 "', stok = '" + txtStok.Text.Replace(",", "") +
                                 "', harga = '" + txtHarga.Text.Replace(",", "") +
                                 "' where id_produk = '" + txtID.Text + "'", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void hapus()
        {
            koneksi.Open();
            cmd = new SqlCommand("delete t_produk where id_produk = '" + txtID.Text + "'", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void dgvTampil_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                int row = dgvTampil.CurrentCell.RowIndex;
                if (e.ColumnIndex == 3 && e.RowIndex >= row)
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

            try
            {
                int row = dgvTampil.CurrentCell.RowIndex;
                if (e.ColumnIndex == 2 && e.RowIndex >= row)
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            aktif();
            kodeOtomatis();
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Silahkan klik tombol tambah terlebih dahulu","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txtNama.Text == "")
            {
                MessageBox.Show("Nama Produk mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtStok.Text == "")
            {
                MessageBox.Show("Stok Produk mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHarga.Text == "")
            {
                MessageBox.Show("Harga Produk mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Yakin data akan disimpan ?", "Simpan data", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ask == DialogResult.Yes) 
                {
                    simpan();
                    kosong();
                    nonaktif();
                }
                tampilkanData();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Yakin data akan diubah ?", "Simpan data", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ask == DialogResult.Yes)
            {
                ubah();
                kosong();
                nonaktif();
            }
            tampilkanData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Yakin data akan dihapus ?", "Simpan data", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ask == DialogResult.Yes)
            {
                hapus();
                kosong();
                nonaktif();
            }
            tampilkanData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            kosong();
            nonaktif();
            tampilkanData();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            cari();
        }

        private void dgvTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aktif();
            ambildata();
            btnSimpan.Enabled = false;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' )
            {
                e.Handled = true;
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtHarga.Text = string.Format("{0:n0}",double.Parse(txtHarga.Text));
                txtHarga.SelectionStart = txtHarga.Text.Length;
            }
            catch(Exception ex)
            {

            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtStok.Text = string.Format("{0:n0}", double.Parse(txtStok.Text));
                txtStok.SelectionStart = txtStok.Text.Length;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
