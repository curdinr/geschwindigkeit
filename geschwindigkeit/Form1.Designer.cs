namespace geschwindigkeit
{
    partial class CGeschwindigkeitDlg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.lblGeschwindigkeit = new System.Windows.Forms.Label();
            this.lblStrecke = new System.Windows.Forms.Label();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblKm_h = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.txtGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.txtStrecke = new System.Windows.Forms.TextBox();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(369, 32);
            this.btnBerechnen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(117, 31);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(369, 84);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Werte löschen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(369, 131);
            this.btnSchliessen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(117, 31);
            this.btnSchliessen.TabIndex = 2;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // lblGeschwindigkeit
            // 
            this.lblGeschwindigkeit.AutoSize = true;
            this.lblGeschwindigkeit.Location = new System.Drawing.Point(31, 37);
            this.lblGeschwindigkeit.Name = "lblGeschwindigkeit";
            this.lblGeschwindigkeit.Size = new System.Drawing.Size(138, 20);
            this.lblGeschwindigkeit.TabIndex = 3;
            this.lblGeschwindigkeit.Text = "Geschwindigkeit (v)";
            // 
            // lblStrecke
            // 
            this.lblStrecke.AutoSize = true;
            this.lblStrecke.Location = new System.Drawing.Point(31, 84);
            this.lblStrecke.Name = "lblStrecke";
            this.lblStrecke.Size = new System.Drawing.Size(77, 20);
            this.lblStrecke.TabIndex = 4;
            this.lblStrecke.Text = "Strecke (s)";
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(31, 136);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(54, 20);
            this.lblZeit.TabIndex = 5;
            this.lblZeit.Text = "Zeit (t)";
            // 
            // lblKm_h
            // 
            this.lblKm_h.AutoSize = true;
            this.lblKm_h.Location = new System.Drawing.Point(303, 37);
            this.lblKm_h.Name = "lblKm_h";
            this.lblKm_h.Size = new System.Drawing.Size(43, 20);
            this.lblKm_h.TabIndex = 6;
            this.lblKm_h.Text = "km/h";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(303, 84);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(29, 20);
            this.lblKm.TabIndex = 7;
            this.lblKm.Text = "km";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Location = new System.Drawing.Point(303, 136);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(17, 20);
            this.lblh.TabIndex = 8;
            this.lblh.Text = "h";
            // 
            // txtGeschwindigkeit
            // 
            this.txtGeschwindigkeit.Location = new System.Drawing.Point(165, 32);
            this.txtGeschwindigkeit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGeschwindigkeit.Name = "txtGeschwindigkeit";
            this.txtGeschwindigkeit.Size = new System.Drawing.Size(114, 27);
            this.txtGeschwindigkeit.TabIndex = 9;
            // 
            // txtStrecke
            // 
            this.txtStrecke.Location = new System.Drawing.Point(165, 80);
            this.txtStrecke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStrecke.Name = "txtStrecke";
            this.txtStrecke.Size = new System.Drawing.Size(114, 27);
            this.txtStrecke.TabIndex = 10;
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(165, 131);
            this.txtZeit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(114, 27);
            this.txtZeit.TabIndex = 11;
            // 
            // CGeschwindigkeitDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 191);
            this.Controls.Add(this.txtZeit);
            this.Controls.Add(this.txtStrecke);
            this.Controls.Add(this.txtGeschwindigkeit);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblKm_h);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.lblStrecke);
            this.Controls.Add(this.lblGeschwindigkeit);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBerechnen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CGeschwindigkeitDlg";
            this.Text = "Geschwindigkeit, Strecke, Zeit berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBerechnen;
        private Button btnClear;
        private Button btnSchliessen;
        private Label lblGeschwindigkeit;
        private Label lblStrecke;
        private Label lblZeit;
        private Label lblKm_h;
        private Label lblKm;
        private Label lblh;
        private TextBox txtGeschwindigkeit;
        private TextBox txtStrecke;
        private TextBox txtZeit;
    }
}