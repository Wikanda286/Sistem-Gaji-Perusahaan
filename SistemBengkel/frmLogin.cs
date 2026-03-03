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
    public partial class frmLogin : Form
    {
        public SqlConnection koneksi = new SqlConnection(SistemBengkel.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public static string id,nama,akses;
        public frmLogin()
        {
            koneksi.Close();
            InitializeComponent();
        }

        private void kosong()
        {
            txtNama.Enabled = false;
            txtSandi.Enabled = false;
        }

        private void masuk()
        {
            if(txtSandi.Text == "" || txtNama.Text == "")
            {
                MessageBox.Show("Nama Pengguna dan Sandi mohon diisi terlebih dahulu","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from t_pegawai where nama_pengguna = '" + txtNama.Text + "' and sandi = '" + txtSandi.Text + "'",koneksi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                    this.Dispose();
                    koneksi.Close();
                }
                else
                {
                    MessageBox.Show("Kombinasi Nama Pengguna dan Sandi tidak tepat silahkan coba lagi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNama.Clear();
                    txtSandi.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            masuk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kosong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void getData()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_pegawai where nama_pengguna = '" + txtNama.Text + "' and sandi = '" + txtSandi.Text + "'",koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();
            
            if(rs.HasRows)
            {
                id = rs["id_pegawai"].ToString();
                nama = rs["nama_pegawai"].ToString();
                akses = rs["akses"].ToString();
            }
            rs.Close();
            cmd.Dispose();
            koneksi.Close();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar ==(char)Keys.Space);
        }
    }
}
