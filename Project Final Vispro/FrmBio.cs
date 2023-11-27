using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Final_Vispro
{
    public partial class FrmBio : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=db_final;Uid=root;Pwd=;";

        public FrmBio()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadData();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi ke database gagal: " + ex.Message);
            }
        }

        private void LoadData()
        {
            string fullName = "Anjeli"; // Gantilah dengan username yang sesuai
            string query = "SELECT `Full Name`, `Date of Birth`, `Address`, `Gender`, `Religion`, `Phone Number`, `Blood Type`, `NISN` FROM tb_biodata WHERE 'Full Name'=@Full_Name";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Full_Name", fullName);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Menampilkan data ke TextBox
                        tb_nama.Text = reader["Full Name"].ToString();
                        tb_ttl.Text = reader["Date of Birth"].ToString();
                        tb_alamat.Text = reader["Address"].ToString();
                        tb_jk.Text = reader["Gender"].ToString();
                        tb_agama.Text = reader["Religion"].ToString();
                        tb_no.Text = reader["Phone Number"].ToString();
                        tb_gd.Text = reader["Blood Type"].ToString();
                        tb_nisn.Text = reader["NISN"].ToString();
                        // Tambahkan TextBox dan kolom lain sesuai dengan kebutuhan
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.");
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrmMain formBack = new FrmMain();
            formBack.Show();
        }

        // Tambahkan event handler lainnya sesuai kebutuhan Anda

        private void tb_ttl_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_nisn_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_gd_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_no_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_agama_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_jk_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_alamat_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void tb_nama_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }

        private void FrmBio_Load(object sender, EventArgs e)
        {
            // Tambahkan logika yang sesuai
        }
    }
}
