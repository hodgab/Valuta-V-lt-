namespace WindowsFormsApp1
{
    partial class form_ablak
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
            this.pnl_fejlec = new System.Windows.Forms.Panel();
            this.lbl_cim = new System.Windows.Forms.Label();
            this.lbl_errol = new System.Windows.Forms.Label();
            this.cbx_errol = new System.Windows.Forms.ComboBox();
            this.lbl_erre = new System.Windows.Forms.Label();
            this.cbx_erre = new System.Windows.Forms.ComboBox();
            this.btn_atvalt = new System.Windows.Forms.Button();
            this.txt_mennyiseg = new System.Windows.Forms.TextBox();
            this.lbl_mennyiseg = new System.Windows.Forms.Label();
            this.lbl_atvaltott = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_fejlec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_fejlec
            // 
            this.pnl_fejlec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnl_fejlec.Controls.Add(this.button1);
            this.pnl_fejlec.Controls.Add(this.lbl_cim);
            this.pnl_fejlec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_fejlec.Location = new System.Drawing.Point(0, 0);
            this.pnl_fejlec.Name = "pnl_fejlec";
            this.pnl_fejlec.Size = new System.Drawing.Size(358, 52);
            this.pnl_fejlec.TabIndex = 0;
            // 
            // lbl_cim
            // 
            this.lbl_cim.AutoSize = true;
            this.lbl_cim.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.lbl_cim.Location = new System.Drawing.Point(105, 9);
            this.lbl_cim.Name = "lbl_cim";
            this.lbl_cim.Size = new System.Drawing.Size(138, 25);
            this.lbl_cim.TabIndex = 0;
            this.lbl_cim.Text = "Valuta Váltó";
            // 
            // lbl_errol
            // 
            this.lbl_errol.AutoSize = true;
            this.lbl_errol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_errol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.lbl_errol.Location = new System.Drawing.Point(71, 97);
            this.lbl_errol.Name = "lbl_errol";
            this.lbl_errol.Size = new System.Drawing.Size(44, 18);
            this.lbl_errol.TabIndex = 1;
            this.lbl_errol.Text = "Erről:";
            // 
            // cbx_errol
            // 
            this.cbx_errol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_errol.FormattingEnabled = true;
            this.cbx_errol.Items.AddRange(new object[] {
            "EUR",
            "HUF",
            "GBP",
            "CHF"});
            this.cbx_errol.Location = new System.Drawing.Point(122, 94);
            this.cbx_errol.Name = "cbx_errol";
            this.cbx_errol.Size = new System.Drawing.Size(121, 26);
            this.cbx_errol.TabIndex = 2;
            // 
            // lbl_erre
            // 
            this.lbl_erre.AutoSize = true;
            this.lbl_erre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_erre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.lbl_erre.Location = new System.Drawing.Point(72, 159);
            this.lbl_erre.Name = "lbl_erre";
            this.lbl_erre.Size = new System.Drawing.Size(40, 18);
            this.lbl_erre.TabIndex = 1;
            this.lbl_erre.Text = "Erre:";
            // 
            // cbx_erre
            // 
            this.cbx_erre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_erre.FormattingEnabled = true;
            this.cbx_erre.Items.AddRange(new object[] {
            "EUR",
            "HUF",
            "GBP",
            "CHF"});
            this.cbx_erre.Location = new System.Drawing.Point(122, 156);
            this.cbx_erre.Name = "cbx_erre";
            this.cbx_erre.Size = new System.Drawing.Size(121, 26);
            this.cbx_erre.TabIndex = 2;
            // 
            // btn_atvalt
            // 
            this.btn_atvalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atvalt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_atvalt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btn_atvalt.Location = new System.Drawing.Point(122, 268);
            this.btn_atvalt.Name = "btn_atvalt";
            this.btn_atvalt.Size = new System.Drawing.Size(111, 39);
            this.btn_atvalt.TabIndex = 3;
            this.btn_atvalt.Text = "Átváltás";
            this.btn_atvalt.UseVisualStyleBackColor = true;
            this.btn_atvalt.Click += new System.EventHandler(this.btn_atvalt_Click);
            // 
            // txt_mennyiseg
            // 
            this.txt_mennyiseg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_mennyiseg.Location = new System.Drawing.Point(122, 211);
            this.txt_mennyiseg.Name = "txt_mennyiseg";
            this.txt_mennyiseg.Size = new System.Drawing.Size(100, 26);
            this.txt_mennyiseg.TabIndex = 4;
            // 
            // lbl_mennyiseg
            // 
            this.lbl_mennyiseg.AutoSize = true;
            this.lbl_mennyiseg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mennyiseg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.lbl_mennyiseg.Location = new System.Drawing.Point(22, 211);
            this.lbl_mennyiseg.Name = "lbl_mennyiseg";
            this.lbl_mennyiseg.Size = new System.Drawing.Size(93, 18);
            this.lbl_mennyiseg.TabIndex = 1;
            this.lbl_mennyiseg.Text = "Mennyiség:";
            // 
            // lbl_atvaltott
            // 
            this.lbl_atvaltott.AutoSize = true;
            this.lbl_atvaltott.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_atvaltott.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.lbl_atvaltott.Location = new System.Drawing.Point(34, 336);
            this.lbl_atvaltott.Name = "lbl_atvaltott";
            this.lbl_atvaltott.Size = new System.Drawing.Size(0, 18);
            this.lbl_atvaltott.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bezaras_ikon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(321, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.txt_mennyiseg);
            this.Controls.Add(this.btn_atvalt);
            this.Controls.Add(this.cbx_erre);
            this.Controls.Add(this.lbl_atvaltott);
            this.Controls.Add(this.lbl_mennyiseg);
            this.Controls.Add(this.lbl_erre);
            this.Controls.Add(this.cbx_errol);
            this.Controls.Add(this.lbl_errol);
            this.Controls.Add(this.pnl_fejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ablak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valuta Váltó";
            this.pnl_fejlec.ResumeLayout(false);
            this.pnl_fejlec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fejlec;
        private System.Windows.Forms.Label lbl_cim;
        private System.Windows.Forms.Label lbl_errol;
        private System.Windows.Forms.ComboBox cbx_errol;
        private System.Windows.Forms.Label lbl_erre;
        private System.Windows.Forms.ComboBox cbx_erre;
        private System.Windows.Forms.Button btn_atvalt;
        private System.Windows.Forms.TextBox txt_mennyiseg;
        private System.Windows.Forms.Label lbl_mennyiseg;
        private System.Windows.Forms.Label lbl_atvaltott;
        private System.Windows.Forms.Button button1;
    }
}

