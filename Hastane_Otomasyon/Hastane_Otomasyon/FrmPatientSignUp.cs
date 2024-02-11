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
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }
        //CONNECTION CLASS
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
                //query
            string query = "INSERT INTO Tbl_Hastalar (hasta_ad,hasta_soyad,hasta_tc,hasta_telefon,hasta_sifre,hasta_cinsiyet) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)";
            SqlCommand command = new SqlCommand(query,bgl.conn());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskdNumberTc.Text);
            command.Parameters.AddWithValue("@p4", MskdPhone.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            bgl.conn().Close();
            MessageBox.Show("\r\nYour registration is successful", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
 