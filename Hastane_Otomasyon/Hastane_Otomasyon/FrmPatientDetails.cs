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
using System.IO;

namespace Hastane_Otomasyon
{
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        //CONNECTION
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInformation frm = new FrmEditInformation();
            frm.TcNo = LblNumberTc.Text;
            frm.Show();
            this.Hide();
        }
        //VARIABLES
        public string tc;
        private void FrmPatientDetails_Load(object sender, EventArgs e)
        {
            LblNumberTc.Text = tc;
            //Ad soyad cekme
            string query = "SELECT hasta_ad,hasta_soyad FROM Tbl_Hastalar WHERE hasta_tc = @p1";
            SqlCommand command = new SqlCommand(query, bgl.conn());
            command.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            bgl.conn().Close();
            

            //Randevu gecmis
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select randevu_tarih AS Date,randevu_saat AS Hour,randevu_brans AS Branch,randevu_doktor AS Doctor,randevu_durum AS Status From Tbl_Randevular WHERE hasta_tc=" + tc, bgl.conn());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branslari cekme

            string query1 = "SELECT brans_ad FROM Tbl_Branslar";
            SqlCommand command1 = new SqlCommand(query1, bgl.conn());
            SqlDataReader dr2= command1.ExecuteReader();
            while(dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPatientLogin fr1 = new FrmPatientLogin();
            fr1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktorlari cekme
            CmbDoctors.Items.Clear();
            string query2 = "SELECT doktor_ad,doktor_soyad FROM Tbl_Doktorlar WHERE doktor_brans = @p1";
            SqlCommand command2 = new SqlCommand(query2, bgl.conn());
            command2.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr3 = command2.ExecuteReader();
            while (dr3.Read())
            {
                string namesurname = dr3[0] + " " + dr3[1];
                CmbDoctors.Items.Add(namesurname);

            }
        }

        private void CmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  randevu_tarih AS Date,randevu_saat AS Hour,randevu_brans AS Branch,randevu_doktor AS Doctor,randevu_durum AS Status FROM Tbl_Randevular WHERE randevu_brans ='" + CmbBranch.Text + "'", bgl.conn());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }
    }
}
