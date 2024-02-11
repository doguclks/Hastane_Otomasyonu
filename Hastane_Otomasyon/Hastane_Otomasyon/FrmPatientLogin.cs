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

namespace Hastane_Otomasyon
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp frm = new FrmPatientSignUp();
            frm.Show();
        }
        //CONNECTION CLASS
        public int userid = 0;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Tbl_Hastalar WHERE hasta_tc = @p1 AND hasta_sifre = @p2";
            SqlCommand command = new SqlCommand(query, bgl.conn());
            command.Parameters.AddWithValue("@p1", MskdNumberTc.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {

                FrmPatientDetails fr = new FrmPatientDetails();
                fr.tc = MskdNumberTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Number or Password!");
            }
            bgl.conn().Close();
        }
    }
}
