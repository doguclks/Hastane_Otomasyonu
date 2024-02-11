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
    public partial class FrmEditInformation : Form
    {
        public FrmEditInformation()
        {
            InitializeComponent();
        }
        public string TcNo;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmEditInformation_Load(object sender, EventArgs e)
        {
            MskdNumberTc.Text = TcNo;

            //Isim soyisim telefon sifre cekme
            string query = "SELECT hasta_ad,hasta_soyad,hasta_telefon,hasta_sifre,hasta_cinsiyet FROM Tbl_Hastalar WHERE hasta_tc = @p1";
            SqlCommand command = new SqlCommand(query, bgl.conn());
            command.Parameters.AddWithValue("@p1", TcNo);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text = dr[0].ToString();
                TxtSurname.Text = dr[1].ToString(); 
                MskdPhone.Text = dr[2].ToString();
                TxtPassword.Text = dr[3].ToString();
                CmbGender.Text = dr[4].ToString();
            }
            
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE Tbl_Hastalar SET hasta_ad = @p1,hasta_soyad= @p2,hasta_telefon=@p3,hasta_sifre=@p4,hasta_cinsiyet=@p5 WHERE hasta_tc = @p6";
            SqlCommand command1 = new SqlCommand(query1, bgl.conn());
            command1.Parameters.AddWithValue("@p1", TxtName.Text);
            command1.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command1.Parameters.AddWithValue("@p3",MskdPhone.Text);
            command1.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command1.Parameters.AddWithValue("@p5", CmbGender.Text);
            command1.Parameters.AddWithValue("@p6", MskdNumberTc.Text);
            command1.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("Your Information has been updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
