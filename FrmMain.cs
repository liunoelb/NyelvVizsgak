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
    public partial class FrmMain : Form
    {
        public string Sorszam { get; set; }
        public bool DgvClick { get; set; } = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void TsmiVizsgak_Click(object sender, EventArgs e)
            => new FrmKereso().ShowDialog();

        private void TsmiUjVizsgazo_Click(object sender, EventArgs e)
            => new FrmVizsgazo(this, Sorszam).ShowDialog();

        private void FillDGV()
        {
            using (var conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                var reader = new SqlCommand(
                    "SELECT jelentkezesek.sorsz, nev, nyelv, szint " +
                    "FROM jelentkezesek INNER JOIN vizsgak ON vizsga = vizsgak.sorsz " +
                    "INNER JOIN nyelvek ON nyelvid = id;",
                    conn).ExecuteReader();
                while (reader.Read())
                {
                    dgvMain.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                }
            }
        }

        private void DgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvClick = true;
            string Sorszam = dgvMain[0, e.RowIndex].Value.ToString();
            new FrmVizsgazo(this, Sorszam).ShowDialog();
        }
    }
}
