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
    public partial class FrmAbsen : Form
    {
        public FrmAbsen()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            FrmMain formBack1 = new FrmMain();
            formBack1.Show();
        }
    }
}
