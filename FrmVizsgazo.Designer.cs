
namespace NyelvVizsgak
{
    partial class FrmVizsgazo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSorszam = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSzulido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnUjVizsgazo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorszám:";
            // 
            // tbSorszam
            // 
            this.tbSorszam.Enabled = false;
            this.tbSorszam.Location = new System.Drawing.Point(133, 36);
            this.tbSorszam.Name = "tbSorszam";
            this.tbSorszam.Size = new System.Drawing.Size(74, 26);
            this.tbSorszam.TabIndex = 1;
            // 
            // tbNev
            // 
            this.tbNev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNev.Location = new System.Drawing.Point(133, 96);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(153, 26);
            this.tbNev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTelefon.Location = new System.Drawing.Point(133, 155);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(153, 26);
            this.tbTelefon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // tbSzulido
            // 
            this.tbSzulido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSzulido.Location = new System.Drawing.Point(133, 214);
            this.tbSzulido.Name = "tbSzulido";
            this.tbSzulido.Size = new System.Drawing.Size(153, 26);
            this.tbSzulido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Születési év:";
            // 
            // btnTorles
            // 
            this.btnTorles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTorles.Enabled = false;
            this.btnTorles.Location = new System.Drawing.Point(322, 12);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(100, 75);
            this.btnTorles.TabIndex = 8;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModositas.Enabled = false;
            this.btnModositas.Location = new System.Drawing.Point(322, 127);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(100, 75);
            this.btnModositas.TabIndex = 9;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.BtnModositas_Click);
            // 
            // btnUjVizsgazo
            // 
            this.btnUjVizsgazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUjVizsgazo.Location = new System.Drawing.Point(322, 242);
            this.btnUjVizsgazo.Name = "btnUjVizsgazo";
            this.btnUjVizsgazo.Size = new System.Drawing.Size(100, 75);
            this.btnUjVizsgazo.TabIndex = 10;
            this.btnUjVizsgazo.Text = "Új vizsgázó";
            this.btnUjVizsgazo.UseVisualStyleBackColor = true;
            this.btnUjVizsgazo.Click += new System.EventHandler(this.BtnUjVizsgazo_Click);
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnUjVizsgazo);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.tbSzulido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSorszam);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "FrmVizsgazo";
            this.Text = "Vizsgázó";
            this.Load += new System.EventHandler(this.FrmVizsgazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSorszam;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSzulido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnUjVizsgazo;
    }
}