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
    public partial class FrmBranch : Form
    {
        public FrmBranch()
        {
            InitializeComponent();
        }
        //CONNECTION
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBranch_Load(object sender, EventArgs e)
        {
            TxtBranchId.Enabled = false;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Branslar",bgl.conn());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.conn().Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Tbl_Branslar (brans_ad) VALUES (@p1)";
            SqlCommand command = new SqlCommand(query, bgl.conn());
            command.Parameters.AddWithValue("@p1", TxtBranch.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Branch Added!!");
            bgl.conn().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dataGridView1.SelectedCells[0].RowIndex;
            TxtBranchId.Text = dataGridView1.Rows[temp].Cells[0].Value.ToString();
            TxtBranch.Text = dataGridView1.Rows[temp].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Tbl_Brans WHERE brans_id =@p1";
            SqlCommand command1 = new SqlCommand(query1, bgl.conn());
            command1.Parameters.AddWithValue("@p1", TxtBranchId.Text);
            MessageBox.Show("Branch Deleted!!");
            bgl.conn().Close();
        }
    }
}
