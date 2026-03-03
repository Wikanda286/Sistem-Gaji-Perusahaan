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
    public partial class frmPelanggan : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public frmPelanggan()
        {
            koneksi.Close();
            InitializeComponent();
            kosong();
            nonaktif();
            tampilkanData();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from t_pelanggan", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void nonaktif()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelepon.Enabled = false;
            groupBox1.Enabled = false;

            btnTambah.Enabled = true;
            btnSimpan.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void aktif()
        {
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtTelepon.Enabled = true;
            groupBox1.Enabled = true;

            btnTambah.Enabled = false;
            btnSimpan.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void cari()
        {
            String sql;
            if (cmbCari.Text == "Nama Pelanggan")
            {
                sql = "select * from t_pelanggan where nama_pelanggan like '%" + txtCari.Text + "%'";
            }
            else if (cmbCari.Text == "Alamat")
            {
                sql = "select * from t_pelanggan where alamat_pelanggan like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_pelanggan where id_pelanggan like '%" + txtCari.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void kodeOtomatis()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_pelanggan order by id_pelanggan desc", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if (rs.HasRows)
            {
                String kode = rs["id_pelanggan"].ToString();
                int valkode = int.Parse(kode.Substring(2, 3));
                String kodef = (valkode + 1).ToString();

                if (kodef.Length == 1)
                {
                    txtID.Text = "PL00" + kodef;
                }
                else if (kodef.Length == 2)
                {
                    txtID.Text = "PL0" + kodef;
                }
                else if (cmbCari.Text.Length == 3)
                {
                    txtID.Text = "PL" + kodef;
                }
            }
            else
            {
                txtID.Text = "PL001";
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
            txtAlamat.Clear();
            txtTelepon.Clear();
            rbL.Checked = true;
            cmbCari.SelectedIndex = 0;
        }

        private void ambildata()
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            txtID.Text = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNama.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtAlamat.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            if (dgvTampil.Rows[row].Cells[3].Value.ToString() == "L")
            {
                rbL.Checked = true;
            }
            else
            {
                rbP.Checked = true;
            }

            txtTelepon.Text = dgvTampil.Rows[row].Cells[4].Value.ToString();
        }

        private void simpan()
        {
            koneksi.Open();
            String jk;
            if (rbL.Checked)
            {
                jk = "L";
            }
            else
            {
                jk = "P";
            }
            cmd = new SqlCommand("insert into t_pelanggan values ('" + txtID.Text + "','" +
                                 txtNama.Text + "','" +
                                 txtAlamat.Text + "','" +
                                 jk + "','" +
                                 txtTelepon.Text + "')", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void ubah()
        {
            koneksi.Open();
            String jk;
            if (rbL.Checked)
            {
                jk = "L";
            }
            else
            {
                jk = "P";
            }
            cmd = new SqlCommand("update t_pelanggan set nama_pelanggan = '" + txtNama.Text +
                                 "', alamat_pelanggan = '" + txtAlamat.Text +
                                 "', jenis_kelamin = '" + jk +
                                 "', telepon = '" + txtTelepon.Text +
                                 "' where id_pelanggan = '" + txtID.Text + "'", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void hapus()
        {
            koneksi.Open();
            cmd = new SqlCommand("delete t_pelanggan where id_pelanggan = '" + txtID.Text + "'", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
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
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan klik tombol tambah terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNama.Text == "")
            {
                MessageBox.Show("Nam Pelanggan mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAlamat.Text == "")
            {
                MessageBox.Show("Alamat Pelanggan mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelepon.Text == "")
            {
                MessageBox.Show("No Telepon mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
