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

namespace NyelvVizsgak
{
    public partial class FrmKereso : Form
    {
        public FrmKereso()
        {
            InitializeComponent();
        }

        private void FrmKereso_Load(object sender, EventArgs e)
        {
            FillCB();
            FillDGV();
        }

        private void FillCB()
        {
            cbNyelvek.Items.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT nyelv FROM nyelvek",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    cbNyelvek.Items.Add(reader[0]);
                }
            }
        }

        private void FillDGV()
        {
            dgvVizsgak.Rows.Clear();
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT idopont, nyelv, szint " +
                    "FROM vizsgak INNER JOIN nyelvek ON nyelvid = id " +
                   $"WHERE nyelv LIKE '%{cbNyelvek.SelectedItem}%';",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvVizsgak.Rows.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd"), reader[1], reader[2]);
                }
            }
        }

        private void CbNyelvek_SelectedIndexChanged(object sender, EventArgs e)
            => FillDGV();
    }
}
