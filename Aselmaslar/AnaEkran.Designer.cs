namespace Aselmaslar
{
    partial class FrmAnaEkran
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
            this.btnTanim = new System.Windows.Forms.Button();
            this.btnPetrol = new System.Windows.Forms.Button();
            this.btnNakliye = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ssDurum = new System.Windows.Forms.StatusStrip();
            this.Tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.ssDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTanim
            // 
            this.btnTanim.BackColor = System.Drawing.SystemColors.Control;
            this.btnTanim.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanim.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTanim.Location = new System.Drawing.Point(12, 193);
            this.btnTanim.Name = "btnTanim";
            this.btnTanim.Size = new System.Drawing.Size(188, 87);
            this.btnTanim.TabIndex = 0;
            this.btnTanim.Text = "Veri Tanımlamları";
            this.btnTanim.UseVisualStyleBackColor = false;
            this.btnTanim.Click += new System.EventHandler(this.btnTanim_Click);
            // 
            // btnPetrol
            // 
            this.btnPetrol.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetrol.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPetrol.Location = new System.Drawing.Point(206, 193);
            this.btnPetrol.Name = "btnPetrol";
            this.btnPetrol.Size = new System.Drawing.Size(188, 87);
            this.btnPetrol.TabIndex = 1;
            this.btnPetrol.Text = "Petrol İşlemleri";
            this.btnPetrol.UseVisualStyleBackColor = true;
            this.btnPetrol.Click += new System.EventHandler(this.btnPetrol_Click);
            // 
            // btnNakliye
            // 
            this.btnNakliye.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakliye.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNakliye.Location = new System.Drawing.Point(400, 193);
            this.btnNakliye.Name = "btnNakliye";
            this.btnNakliye.Size = new System.Drawing.Size(188, 87);
            this.btnNakliye.TabIndex = 2;
            this.btnNakliye.Text = "Nakliye İşlemleri";
            this.btnNakliye.UseVisualStyleBackColor = true;
            this.btnNakliye.Click += new System.EventHandler(this.btnNakliye_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::Aselmaslar.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(-175, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(774, 187);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // ssDurum
            // 
            this.ssDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsslbl});
            this.ssDurum.Location = new System.Drawing.Point(0, 287);
            this.ssDurum.Name = "ssDurum";
            this.ssDurum.Size = new System.Drawing.Size(598, 22);
            this.ssDurum.TabIndex = 2;
            this.ssDurum.Text = "Durum Çubuğu";
            // 
            // Tsslbl
            // 
            this.Tsslbl.Name = "Tsslbl";
            this.Tsslbl.Size = new System.Drawing.Size(174, 17);
            this.Tsslbl.Text = "© Aselmaslar Madencilik - 2014";
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 309);
            this.Controls.Add(this.ssDurum);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnNakliye);
            this.Controls.Add(this.btnPetrol);
            this.Controls.Add(this.btnTanim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAnaEkran";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aselmaslar";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ssDurum.ResumeLayout(false);
            this.ssDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTanim;
        private System.Windows.Forms.Button btnPetrol;
        private System.Windows.Forms.Button btnNakliye;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.StatusStrip ssDurum;
        private System.Windows.Forms.ToolStripStatusLabel Tsslbl;
    }
}

