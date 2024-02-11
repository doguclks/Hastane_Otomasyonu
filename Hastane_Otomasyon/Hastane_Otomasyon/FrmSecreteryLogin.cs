using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    public partial class FrmSecreteryLogin : Form
    {
        public FrmSecreteryLogin()
        {
            InitializeComponent();
        }
        //CONNECTION
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tbl_Sekreterler WHERE sekreter_tc = @p1 AND sekreter_sifre = @p2";
            SqlCommand cmd = new SqlCommand(query,bgl.conn());
            cmd.Parameters.AddWithValue("@p1", MskdNumberTc.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmSecreteryDetails frm = new FrmSecreteryDetails();
                frm.SecreteryTcNo = MskdNumberTc.Text;
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong Number or Password!", "WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
