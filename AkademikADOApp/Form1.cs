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


namespace AkademikADOApp
{
    public partial class DatabaseConnectionForm : Form
    {
        // Use your new server name with DOUBLE backslashes
        string connString = "Data Source=DESKTOP-8BL3MIG\\NIMRA;Initial Catalog=DBAkademikADO;Integrated Security=True";

        // Object SqlConnection
        SqlConnection conn;
        public DatabaseConnectionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // btnConnect opens the SQL connection
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                lblStatus.Text = "Status : Database Connected";
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // btnDisconnect closes the SQL connection
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                lblStatus.Text = "Status : Database Disconnected";
                MessageBox.Show("Disconnected from database!"); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
