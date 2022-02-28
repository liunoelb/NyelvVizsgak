
namespace NyelvVizsgak
{
    partial class FrmKereso
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
            this.dgvVizsgak = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNyelvek = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVizsgak
            // 
            this.dgvVizsgak.AllowUserToAddRows = false;
            this.dgvVizsgak.AllowUserToDeleteRows = false;
            this.dgvVizsgak.AllowUserToResizeColumns = false;
            this.dgvVizsgak.AllowUserToResizeRows = false;
            this.dgvVizsgak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVizsgak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVizsgak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVizsgak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvVizsgak.Location = new System.Drawing.Point(12, 65);
            this.dgvVizsgak.Name = "dgvVizsgak";
            this.dgvVizsgak.RowHeadersVisible = false;
            this.dgvVizsgak.Size = new System.Drawing.Size(560, 284);
            this.dgvVizsgak.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Időpont";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nyelv";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Szint";
            this.Column3.Name = "Column3";
            // 
            // cbNyelvek
            // 
            this.cbNyelvek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNyelvek.FormattingEnabled = true;
            this.cbNyelvek.Location = new System.Drawing.Point(181, 31);
            this.cbNyelvek.Name = "cbNyelvek";
            this.cbNyelvek.Size = new System.Drawing.Size(245, 28);
            this.cbNyelvek.TabIndex = 2;
            this.cbNyelvek.SelectedIndexChanged += new System.EventHandler(this.CbNyelvek_SelectedIndexChanged);
            // 
            // FrmKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cbNyelvek);
            this.Controls.Add(this.dgvVizsgak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKereso";
            this.Text = "Vizsgakereső";
            this.Load += new System.EventHandler(this.FrmKereso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVizsgak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cbNyelvek;
    }
}