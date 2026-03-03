using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemBengkel
{
    public partial class frmTransaksi : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public frmTransaksi()
        {
            koneksi.Close();
            InitializeComponent();
            kodeOtomatis();
            getPelanggan();
            getPegawai();
            getProduk();
        }

        private void nonaktif()
        {
            txtID.Enabled = false;
            txtIDH.Enabled = false;
            txtPegawai.Enabled = false;
            txtHarga.Enabled = false;
            txtTotalH.Enabled = false;
        }

        private void bersih()
        {
            kodeOtomatis();
            cmbIDP.SelectedIndex = 0;
            cmbTglT.Value = DateTime.Now;
            txtJenis.Clear();
            txtNama.Clear();
            txtPlat.Clear();
            txtTotalBayar.Clear();
            cmbJenis.SelectedIndex = 0;
            cmbIDP.SelectedIndex = 0;
            txtKet.Clear();
            txtJumlaP.Clear();
            txtHarga.Clear();
            txtTotalH.Clear();
        }

        private void getHarga() 
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_produk where id_produk = '" + cmbProduk.Text.Substring(0, 5) + "'",koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if(rs.HasRows)
            {
                double harga = double.Parse(rs["harga"].ToString());
                txtHarga.Text = string.Format("{0:n0}", double.Parse(harga.ToString()));
            }
            rs.Close();
            cmd.Dispose();
            koneksi.Close();
        }

        private void getPelanggan()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_pelanggan order by id_pelanggan asc", koneksi);
            rs = cmd.ExecuteReader();

            if(rs.HasRows)
            {
                while(rs.Read())
                {
                    cmbIDP.Items.Add(rs["id_pelanggan"] + " - " + rs["nama_pelanggan"]);
                }
            }
            rs.Close();
            cmd.Dispose();
            cmbIDP.SelectedIndex = 0;
            koneksi.Close();
        }

        private void getProduk()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_produk order by id_produk asc", koneksi);
            rs = cmd.ExecuteReader();

            if (rs.HasRows)
            {
                while (rs.Read())
                {
                    cmbProduk.Items.Add(rs["id_produk"] + " - " + rs["nama_produk"]);
                }
            }
            rs.Close();
            cmd.Dispose();
            cmbProduk.SelectedIndex = 0;
            koneksi.Close();
        }

        private void totalH()
        {
            if (cmbJenis.SelectedIndex == 0)
            {
                try
                {
                    double harga = double.Parse(txtHarga.Text);
                    double jumlahP = double.Parse(txtJumlaP.Text);
                    double total = harga * jumlahP;
                    txtTotalH.Text = total.ToString();
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {
                    if (txtHarga.Text == null)
                    {
                        txtJumlaP.Text = "0";
                    }
                    else
                    {
                        double harga = double.Parse(txtHarga.Text);
                        double total = harga;
                        txtTotalH.Text = total.ToString();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void getPegawai()
        {
            txtPegawai.Enabled = false;/*
            txtPegawai.Text = frmLogin.id.ToString() + " - " + frmLogin.nama.ToString();*/
        }

        private void kodeOtomatis()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_htransaksi order by id_htransaksi desc", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if (rs.HasRows)
            {
                String kode = rs["id_htransaksi"].ToString();
                int valkode = int.Parse(kode.Substring(11, 1));
                String kodef = (valkode + 1).ToString();

                if (kodef.Length == 1)
                {
                    txtID.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".0000" + kodef;
                    txtIDH.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".0000" + kodef;
                }
                else if (kodef.Length == 2)
                {
                    txtID.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".000" + kodef;
                    txtIDH.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".000" + kodef;
                }
                else if (kodef.Length == 3)
                {
                    txtID.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".00" + kodef;
                    txtIDH.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".00" + kodef;
                }
            }
            else
            {
                txtID.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".00001";
                txtIDH.Text = "TR" + cmbTglT.Value.ToString("MMyy") + ".00001";
            }
            rs.Close();
            cmd.Dispose();
            cmbJenis.SelectedIndex = 0;
            txtID.Enabled = false;
            txtIDH.Enabled = false;
            koneksi.Close();
        }

        float tb;
        private void tambah()
        { 
            if (txtHarga.Text == "")
            {
                MessageBox.Show("Harga mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbJenis.SelectedIndex == 0)
                {
                    if (txtJumlaP.Text == "")
                    {
                        MessageBox.Show("Jumlah Produk mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (cmbJenis.Text == "") 
                    {
                        MessageBox.Show("Jenis Transaksi mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtJumlaP.Text == "")
                        {
                            MessageBox.Show("Jumlah Produk mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int row = dgvTampil.Rows.Add();
                            dgvTampil.Rows[row].Cells[0].Value = txtIDH.Text;
                            dgvTampil.Rows[row].Cells[1].Value = cmbJenis.Text;
                            dgvTampil.Rows[row].Cells[2].Value = cmbProduk.Text.Substring(0, 5);
                            dgvTampil.Rows[row].Cells[3].Value = txtKet.Text;
                            dgvTampil.Rows[row].Cells[4].Value = txtJumlaP.Text;
                            dgvTampil.Rows[row].Cells[5].Value = txtHarga.Text;
                            dgvTampil.Rows[row].Cells[6].Value = txtTotalH.Text;

                            float total = float.Parse(txtTotalH.Text.ToString());
                            tb += total;
                            txtTotalBayar.Text = string.Format("{0:n0}", double.Parse(tb.ToString()));
                        }
                    }
                }
                else
                {
                    if (txtKet.Text == "")
                    {
                        MessageBox.Show("Keterangan mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        int row = dgvTampil.Rows.Add();
                        dgvTampil.Rows[row].Cells[0].Value = txtIDH.Text;
                        dgvTampil.Rows[row].Cells[1].Value = cmbJenis.Text;
                        dgvTampil.Rows[row].Cells[2].Value = null;
                        dgvTampil.Rows[row].Cells[3].Value = txtKet.Text;
                        dgvTampil.Rows[row].Cells[4].Value = null;
                        dgvTampil.Rows[row].Cells[5].Value = txtHarga.Text;
                        dgvTampil.Rows[row].Cells[6].Value = txtTotalH.Text;

                        float total = float.Parse(txtTotalH.Text.ToString());
                        tb += total;
                        txtTotalBayar.Text = string.Format("{0:n0}", double.Parse(tb.ToString()));
                    }
                }
            }
        }

        private void proses()
        {
            koneksi.Close();
            koneksi.Open();
            SqlTransaction transaksi = koneksi.BeginTransaction();
                    try
                    {
                        cmd = new SqlCommand("insert into t_htransaksi values ('" + txtID.Text + "','" +
                                             cmbIDP.Text.Substring(0, 5) + "','" +
                                             txtPegawai.Text.Substring(0, 5) + "','" +
                                             cmbTglT.Value.ToString("yyyy-MM-dd") + "','" +
                                             txtJenis.Text + "','" +
                                             txtNama.Text + "','" +
                                             txtPlat.Text + "','" +
                                             txtTotalBayar.Text.Replace(",", "") + "')", koneksi, transaksi);
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i < dgvTampil.Rows.Count; i++)
                        {
                            if (dgvTampil.Rows[i].Cells[1].Value.ToString() == "Produk")
                            {
                                cmd = new SqlCommand("insert into t_dtransaksi1(id_htransaksi,jenis_detail_transaksi,id_produk,ket,jml_produk,harga,total_harga) values ('" +
                                                     dgvTampil.Rows[i].Cells[0].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[1].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[2].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[3].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[4].Value.ToString().Replace(",", "") + "','" +
                                                     dgvTampil.Rows[i].Cells[5].Value.ToString().Replace(",", "") + "','" +
                                                     dgvTampil.Rows[i].Cells[6].Value.ToString().Replace(",", "") + "')", koneksi, transaksi);
                                cmd.ExecuteNonQuery();
                                cmd = new SqlCommand("update t_produk set stok = stok - '" + dgvTampil.Rows[i].Cells[4].Value.ToString().Replace(".", "") + "' where id_produk = '" + dgvTampil.Rows[i].Cells[2].Value.ToString() + "'", koneksi, transaksi);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into t_dtransaksi1(id_htransaksi,jenis_detail_transaksi,ket,harga,total_harga) values ('" +
                                                     dgvTampil.Rows[i].Cells[0].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[1].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[3].Value + "','" +
                                                     dgvTampil.Rows[i].Cells[5].Value.ToString().Replace(",", "") + "','" +
                                                     dgvTampil.Rows[i].Cells[6].Value.ToString().Replace(",", "") + "')", koneksi, transaksi);
                                cmd.ExecuteNonQuery();

                            }
                        }
                        transaksi.Commit();
                        MessageBox.Show("Data berhasil diproses", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTampil.Rows.Clear();
                        dgvTampil.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        transaksi.Rollback();
                        MessageBox.Show(ex.Message);
                    }
            koneksi.Close();
        }

        private void cmbJenis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbJenis.SelectedIndex != 0)
            {
                cmbProduk.Visible = false;
                txtJumlaP.Visible = false;
                txtHarga.Enabled = true;
                txtKet.Enabled = true;
                txtKet.Text = string.Empty;
                txtHarga.Text = string.Empty;
                txtTotalH.Text = string.Empty;
            }
            else
            {
                cmbProduk.Visible = true;
                txtJumlaP.Visible = true;
                txtHarga.Enabled = false;
                txtKet.Enabled = false;
                txtKet.Text = cmbProduk.Text.Substring(8);
                cmbIDP.SelectedIndex = 0;
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtHarga.Text = string.Format("{0:n0}", double.Parse(txtHarga.Text));
                txtHarga.SelectionStart = txtHarga.Text.Length;
                
            }
            catch(Exception ex)
            {

            }

            totalH();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void txtJumlaP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtJumlaP.Text = string.Format("{0:n0}", double.Parse(txtJumlaP.Text));
                txtJumlaP.SelectionStart = txtJumlaP.Text.Length;
            }
            catch
            {

            }

            totalH();
        }

        private void cmbProduk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getHarga();
            txtKet.Text = cmbProduk.Text.Substring(8);
        }

        private void txtTotalH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalH.Text = string.Format("{0:n0}", double.Parse(txtTotalH.Text));
                txtTotalH.SelectionStart = txtTotalH.Text.Length;
            }
            catch
            {

            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            /*koneksi.Open();
            cmd = new SqlCommand("select * from t_produk where id_produk = '" + cmbProduk.Text.Substring(0, 5) + "'", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if (rs.HasRows)
            {
                int stok = int.Parse(rs["stok"].ToString());
                if (int.Parse(txtJumlaP.Text) > stok)
                {
                    MessageBox.Show("Jumlah beli produk melebihi stok produk", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmd = new SqlCommand("select * from t_error", koneksi);
                    cmd.ExecuteNonQuery();
                
                else
                {*/
                    if (txtPegawai.Text == "")
                    {
                        MessageBox.Show("ID Pegawai mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtJenis.Text == "")
                    {
                        MessageBox.Show("Jenis Kendaraan mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNama.Text == "")
                    {
                        MessageBox.Show("Nama Kendaraan mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtPlat.Text == "")
                    {
                        MessageBox.Show("Plat Nomor mohon diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtTotalBayar.Text == "")
                    {
                        MessageBox.Show("Silahkan tambahkan data terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dgvTampil.CurrentCell == null)
                    {
                        MessageBox.Show("Silahkan tambah data produk terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        proses();
                        kodeOtomatis();
                        txtJenis.Clear();
                        txtNama.Clear();
                        txtTotalBayar.Clear();
                        txtJumlaP.Clear();
                        txtPlat.Clear();
                        txtTotalH.Text = txtHarga.Text;
                    }
/*                }
            }
            rs.Close();
            cmd.Dispose();
            koneksi.Close();*/
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmTransaksi_Load(object sender, EventArgs e)
        {
            txtKet.Enabled = false;
            txtHarga.Enabled = false;
            txtTotalH.Enabled = false;
            txtKet.Text = cmbProduk.Text.Substring(8);
            getHarga();
            totalH();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtJumlaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(dgvTampil.CurrentCell == null)
            {
                MessageBox.Show("Silahkan tambah data produk terlebih dahulu","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                float hs = float.Parse(dgvTampil.CurrentRow.Cells[6].Value.ToString());
                tb -= hs;
                txtTotalBayar.Text = tb.ToString();
                dgvTampil.Rows.Remove(dgvTampil.CurrentRow);
            }
        }

        private void txtTotalBayar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
