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
    public partial class FrmVizsgazo : Form
    {
        public FrmMain FrmMain { get; set; }
        public string Sorszam { get; set; }

        public FrmVizsgazo(FrmMain frmMain, string sorsz)
        {
            FrmMain = frmMain;
            Sorszam = sorsz;
            InitializeComponent();
        }

        private void FrmVizsgazo_Load(object sender, EventArgs e)
        {

            if (FrmMain.DgvClick == true)
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    var reader = new SqlCommand(
                        "SELECT sorsz, nev, mobil, szulev " +
                        "FROM jelentkezesek " +
                       $"WHERE sorsz LIKE '{Sorszam}';", conn).ExecuteReader();
                    reader.Read();
                    tbSorszam.Text = reader[0].ToString();
                    tbNev.Text = reader[1].ToString();
                    tbTelefon.Text = reader[2].ToString();
                    tbSzulido.Text = reader[3].ToString();
                }
            }
            if (!string.IsNullOrEmpty(tbSorszam.Text))
            {
                btnTorles.Enabled = true;
                btnModositas.Enabled = true;
            }
            FrmMain.DgvClick = false;
        }

        private void BtnUjVizsgazo_Click(object sender, EventArgs e)
        {
            string errorMsg = "";

            if (string.IsNullOrEmpty(tbNev.Text))
                errorMsg += "A név mező kitöltése kötelező!\n";
            if (string.IsNullOrEmpty(tbTelefon.Text))
                errorMsg += "A telefonszám kitöltése kötelező!\n";
            if (string.IsNullOrEmpty(tbSzulido.Text))
                errorMsg += "A születési idő kitöltése kötelező!\n";
            if (tbTelefon.Text.Length < 8)
                errorMsg += "A telefonszám hossza túl rövid!\n";
            if (tbTelefon.Text.Length > 8)
                errorMsg += "A telefonszám hossza túl hosszú!\n";
            if (int.Parse(tbSzulido.Text) > DateTime.Now.Year)
                errorMsg += "A születési év nem lehet a mostaninál nagyobb!\n";
            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                MessageBox.Show(
                    caption: "Figyelmeztetés!",
                    text: $"{ errorMsg}",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand(
                        "INSERT INTO jelentkezesek VALUES" +
                       $"((SELECT MAX(sorsz) + 1 FROM jelentkezesek), '{tbNev.Text}', '{tbTelefon.Text}', '{tbSzulido.Text}', NULL);", 
                        conn).ExecuteNonQuery();
                }
                MessageBox.Show("Az új jelentkező rögzítésre került!");
            }
            
        }

        private void BtnModositas_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            string nev = tbNev.Text;
            string telefon = tbTelefon.Text;
            string szulev = tbSzulido.Text;

            if (string.IsNullOrEmpty(nev))
                errorMsg += "A név mező kitöltése kötelező!\n";
            if (string.IsNullOrEmpty(telefon))
                errorMsg += "A telefonszám kitöltése kötelező!\n";
            if (string.IsNullOrEmpty(szulev))
                errorMsg += "A születési idő kitöltése kötelező!\n";
            if (telefon.Length < 8)
                errorMsg += "A telefonszám hossza túl rövid!\n";
            if (telefon.Length > 8)
                errorMsg += "A telefonszám hossza túl hosszú!\n";
            if (!string.IsNullOrWhiteSpace(errorMsg))
            {
                MessageBox.Show(
                    caption: "Figyelmeztetés!",
                    text: $"{ errorMsg}",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show(
                caption: "Figyelmeztetés!",
                text: "Biztosan módosítani szeretné az adatokat?",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var conn = new SqlConnection(Program.ConnectionString))
                    {
                        conn.Open();
                        new SqlCommand(
                            "UPDATE jelentkezesek " +
                           $"SET nev = '{nev}', " +
                           $"mobil = '{telefon}', " +
                           $"szulev = '{szulev}' " +
                           $"WHERE sorsz = {tbSorszam.Text};",
                            conn).ExecuteNonQuery();
                    }
                }
                MessageBox.Show("A módosítás sikeresen végrehajtódott!");
                
            }
            
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "Figyelmeztetés!",
                text: "Biztosan törölni szeretné az adatokat?",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    new SqlCommand(
                       $"DELETE FROM jelentkezesek WHERE sorsz = {tbSorszam.Text};",
                        conn).ExecuteNonQuery();
                }
                MessageBox.Show("A törlés sikeresen végrehajtódott!");
            }
        }
    }
}
