namespace takımörnek1
{
    partial class Form1
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
            this.btnFenerbahce = new System.Windows.Forms.Button();
            this.btnGalatasaray = new System.Windows.Forms.Button();
            this.btnRealmadrid = new System.Windows.Forms.Button();
            this.btnBesiktas = new System.Windows.Forms.Button();
            this.lbltakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFenerbahce
            // 
            this.btnFenerbahce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFenerbahce.Location = new System.Drawing.Point(61, 24);
            this.btnFenerbahce.Name = "btnFenerbahce";
            this.btnFenerbahce.Size = new System.Drawing.Size(174, 56);
            this.btnFenerbahce.TabIndex = 0;
            this.btnFenerbahce.Text = "FENERBAHÇE";
            this.btnFenerbahce.UseVisualStyleBackColor = true;
            this.btnFenerbahce.Click += new System.EventHandler(this.btnFenerbahce_Click);
            // 
            // btnGalatasaray
            // 
            this.btnGalatasaray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGalatasaray.Location = new System.Drawing.Point(61, 210);
            this.btnGalatasaray.Name = "btnGalatasaray";
            this.btnGalatasaray.Size = new System.Drawing.Size(174, 56);
            this.btnGalatasaray.TabIndex = 1;
            this.btnGalatasaray.Text = "GALATASARAY";
            this.btnGalatasaray.UseVisualStyleBackColor = true;
            this.btnGalatasaray.Click += new System.EventHandler(this.btnGalatasaray_Click);
            // 
            // btnRealmadrid
            // 
            this.btnRealmadrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRealmadrid.Location = new System.Drawing.Point(61, 148);
            this.btnRealmadrid.Name = "btnRealmadrid";
            this.btnRealmadrid.Size = new System.Drawing.Size(174, 56);
            this.btnRealmadrid.TabIndex = 2;
            this.btnRealmadrid.Text = "REAL MADRİD";
            this.btnRealmadrid.UseVisualStyleBackColor = true;
            this.btnRealmadrid.Click += new System.EventHandler(this.btnRealmadrid_Click);
            // 
            // btnBesiktas
            // 
            this.btnBesiktas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBesiktas.Location = new System.Drawing.Point(61, 86);
            this.btnBesiktas.Name = "btnBesiktas";
            this.btnBesiktas.Size = new System.Drawing.Size(174, 56);
            this.btnBesiktas.TabIndex = 3;
            this.btnBesiktas.Text = "BEŞİKTAŞ";
            this.btnBesiktas.UseVisualStyleBackColor = true;
            this.btnBesiktas.Click += new System.EventHandler(this.btnBesiktas_Click);
            // 
            // lbltakim
            // 
            this.lbltakim.AutoSize = true;
            this.lbltakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltakim.Location = new System.Drawing.Point(264, 128);
            this.lbltakim.Name = "lbltakim";
            this.lbltakim.Size = new System.Drawing.Size(92, 31);
            this.lbltakim.TabIndex = 4;
            this.lbltakim.Text = "label1";
            this.lbltakim.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 356);
            this.Controls.Add(this.lbltakim);
            this.Controls.Add(this.btnBesiktas);
            this.Controls.Add(this.btnRealmadrid);
            this.Controls.Add(this.btnGalatasaray);
            this.Controls.Add(this.btnFenerbahce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFenerbahce;
        private System.Windows.Forms.Button btnGalatasaray;
        private System.Windows.Forms.Button btnRealmadrid;
        private System.Windows.Forms.Button btnBesiktas;
        private System.Windows.Forms.Label lbltakim;
    }
}

