using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Ganti dengan namespace yang sesuai untuk database Anda


namespace Project_Final_Vispro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnbio_Click(object sender, EventArgs e)
        {
            FrmBio formBio = new FrmBio();
            formBio.Show();
        }

        private void btnschedule_Click(object sender, EventArgs e)
        {
            FrmJadwal form2 = new FrmJadwal();
            form2.Show();
        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            FrmNilai form3 = new FrmNilai();
            form3.Show();
        }

        private void btnabsent_Click(object sender, EventArgs e)
        {
            FrmAbsen formAbsen = new FrmAbsen();
            formAbsen.Show();
        }
    }
}
