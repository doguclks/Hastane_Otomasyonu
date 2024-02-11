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
    public partial class FrmSecreteryDetails : Form
    {
        public FrmSecreteryDetails()
        {
            InitializeComponent();
        }
        //CONNECTION
        sqlbaglantisi connection = new sqlbaglantisi();
        //Variables
        public string SecreteryTcNo;
        private void FrmSecreteryDetails_Load(object sender, EventArgs e)
        {
            //Ad soyad aktarma
            LblNumberTc.Text = SecreteryTcNo;
            string query = "SELECT sekreter_adsoyad FROM Tbl_Sekreterler WHERE sekreter_tc = @p1";
            SqlCommand cmd = new SqlCommand(query, connection.conn());
            cmd.Parameters.AddWithValue("@p1", SecreteryTcNo);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while(dr1.Read())
            {
                LblNameSurname.Text = dr1[0].ToString();
            }
            connection.conn().Close();

            //branslari cekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT brans_ad AS Branch FROM Tbl_Branslar",connection.conn());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktorlari cekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (doktor_ad + ' '+doktor_soyad) AS Doctors,doktor_brans As Branch FROM Tbl_Doktorlar ", connection.conn());
            da2.Fill(dt1);
            dataGridView2.DataSource = dt1;


            //branslari comboboxa ekleme

            string query2 = "SELECT brans_ad FROM Tbl_Branslar ";
            SqlCommand cmd3 = new SqlCommand(query2, connection.conn());
            SqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                CmdBranch.Items.Add(reader[0]);
            }
        }


       

    private void BtnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Tbl_Randevular (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) VALUES (@p1,@p2,@p3,@p4)";
            SqlCommand cmd1 = new SqlCommand(query, connection.conn());
            cmd1.Parameters.AddWithValue("@p1", MskdDate.Text);
            cmd1.Parameters.AddWithValue("@p2", MskdHour.Text);
            cmd1.Parameters.AddWithValue("@p3", CmdBranch.Text);
            cmd1.Parameters.AddWithValue("@p4", CmbDoctor.Text);
            cmd1.ExecuteNonQuery();
            connection.conn().Close();
            MessageBox.Show("Appointment has been created!!","Appointment",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void GrpAppointmentPanel_Enter(object sender, EventArgs e)
        {

        }

        private void CmdBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            string query1 = "SELECT doktor_ad,doktor_soyad FROM Tbl_Doktorlar WHERE doktor_brans = @p1";
            SqlCommand cmd2 = new SqlCommand(query1, connection.conn());
            cmd2.Parameters.AddWithValue("@p1", CmdBranch.Text);
            SqlDataReader dr = cmd2.ExecuteReader();
            while(dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            connection.conn().Close();
        }

        private void BtnAnnounce_Click(object sender, EventArgs e)
        {
            string query2 = "INSERT INTO Tbl_Duyurular (duyuru) VALUES (@p1)";
            SqlCommand cmd3 = new SqlCommand(query2, connection.conn());
            cmd3.Parameters.AddWithValue("@p1", richTextBox1.Text);
            cmd3.ExecuteNonQuery();
            connection.conn().Close();
            MessageBox.Show("Announcement Created!!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frmDoctorPanel = new FrmDoctorPanel();
            frmDoctorPanel.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBranch fr = new FrmBranch();
            fr.Show();
            this.Close();
        }
    }
}
