using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemBengkel
{
    public partial class frmPegawai : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public frmPegawai()
        {
            koneksi.Close();
            InitializeComponent();
            kosong();
            nonaktif();
            tampilkanData();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from t_pegawai", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void nonaktif()
        {
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtPengguna.Enabled = false;
            txtSandi.Enabled = false;
            cmbAkses.Enabled = false;

            btnTambah.Enabled = true;
            btnSimpan.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void aktif()
        {
            txtNama.Enabled = true;
            txtPengguna.Enabled = true;
            txtSandi.Enabled = true;
            cmbAkses .Enabled = true;

            btnTambah.Enabled = false;
            btnSimpan.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
        }

        private void cari()
        {
            String sql;
            if (cmbCari.Text == "Nama Pegawai")
            {
                sql = "select * from t_pegawai where nama_pegawai like '%" + txtCari.Text + "%'";
            }
            else if (cmbCari.Text == "Nama Pengguna")
            {
                sql = "select * from t_pegawai where nama_pengguna like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_pegawai where id_pegawai like '%" + txtCari.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void kodeOtomatis()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_pegawai order by id_pegawai desc", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if (rs.HasRows)
            {
                String kode = rs["id_pegawai"].ToString();
                int valkode = int.Parse(kode.Substring(2, 3));
                String kodef = (valkode + 1).ToString();

                if (kodef.Length == 1)
                {
                    txtID.Text = "PG00" + kodef;
                }
                else if (kodef.Length == 2)
                {
                    txtID.Text = "PG0" + kodef;
                }
                else if (cmbCari.Text.Length == 3)
                {
                    txtID.Text = "PG" + kodef;
                }
            }
            else
            {
                txtID.Text = "PG001";
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
            txtPengguna.Clear();
            txtSandi.Clear();
            cmbAkses.SelectedIndex = 0;
            cmbCari.SelectedIndex = 0;
        }

        private void ambildata()
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            txtID.Text = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNama.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtPengguna.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            txtSandi.Text = dgvTampil.Rows[row].Cells[3].Value.ToString();
            if(dgvTampil.Rows[row].Cells[4].Value.ToString() == "1")
            {
                cmbAkses.Text = "Admin";
            }
            else
            {
                cmbAkses.Text = "Pegawai";
            }
        }

        private void simpan()
        {
            koneksi.Open();
            String akses;
            if(cmbAkses.Text == "Admin")
            {
                akses = "1";
            }
            else
            {
                akses = "2";
            }
            cmd = new SqlCommand("insert into t_pegawai values ('" + txtID.Text + "','" +
                                 txtNama.Text + "','" +
                                 txtPengguna.Text + "','" +
                                 txtSandi.Text + "','" +
                                 akses + "')", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void ubah()
        {
            koneksi.Open();
            String akses;
            if (cmbAkses.Text == "Admin")
            {
                akses = "1";
            }
            else
            {
                akses = "2";
            }
            cmd = new SqlCommand("update t_pegawai set nama_pegawai = '" + txtNama.Text +
                                 "', nama_pengguna = '" + txtPengguna.Text +
                                 "', sandi = '" + txtSandi.Text +
                                 "', akses = '" + akses +
                                 "' where id_pegawai = '" + txtID.Text + "'", koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void hapus()
        {
            koneksi.Open();
            cmd = new SqlCommand("delete t_pegawai where id_pegawai = '" + txtID.Text + "'", koneksi);
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
                MessageBox.Show("Nama Pengguna mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPengguna.Text == "")
            {
                MessageBox.Show("Nama Pengguna mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSandi.Text == "")
            {
                MessageBox.Show("Sandi mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void dgvTampil_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            if(e.ColumnIndex == 3 && e.RowIndex >= row)
            {
                object dataV = dgvTampil.Rows[e.RowIndex].Cells[3].Value;

                if(e.Value != null)
                {
                    string data = dataV.ToString();
                    string md5 = GetMD5Hash(data);
                    e.Value = md5;
                }
            }
        }
    }
}
