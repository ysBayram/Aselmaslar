namespace Aselmaslar
{
    partial class FrmPetrolKayit
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
            this.components = new System.ComponentModel.Container();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbPetrol = new System.Windows.Forms.ComboBox();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.cmbTasFrm = new System.Windows.Forms.ComboBox();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.tbFis = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblTasFrm = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.ssDurum = new System.Windows.Forms.StatusStrip();
            this.tssLblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCIKIS = new System.Windows.Forms.ComboBox();
            this.lblCIKIS = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.ssDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::Aselmaslar.Properties.Resources.delete_32;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.Location = new System.Drawing.Point(129, 257);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 50);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İptal ";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(14, 257);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 50);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbPetrol
            // 
            this.cmbPetrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPetrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPetrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPetrol.FormattingEnabled = true;
            this.cmbPetrol.Location = new System.Drawing.Point(108, 155);
            this.cmbPetrol.Name = "cmbPetrol";
            this.cmbPetrol.Size = new System.Drawing.Size(121, 21);
            this.cmbPetrol.TabIndex = 5;
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.Location = new System.Drawing.Point(108, 126);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaka.TabIndex = 4;
            this.cmbPlaka.Leave += new System.EventHandler(this.cmbPlaka_Leave);
            // 
            // cmbTasFrm
            // 
            this.cmbTasFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTasFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTasFrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTasFrm.FormattingEnabled = true;
            this.cmbTasFrm.Location = new System.Drawing.Point(108, 184);
            this.cmbTasFrm.Name = "cmbTasFrm";
            this.cmbTasFrm.Size = new System.Drawing.Size(121, 21);
            this.cmbTasFrm.TabIndex = 6;
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.Location = new System.Drawing.Point(11, 18);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(31, 13);
            this.lblTarih1.TabIndex = 0;
            this.lblTarih1.Text = "Tarih";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih1.Location = new System.Drawing.Point(108, 12);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(121, 20);
            this.dtpTarih1.TabIndex = 0;
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(108, 69);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(121, 20);
            this.tbTutar.TabIndex = 2;
            // 
            // tbFis
            // 
            this.tbFis.Location = new System.Drawing.Point(108, 41);
            this.tbFis.Name = "tbFis";
            this.tbFis.Size = new System.Drawing.Size(121, 20);
            this.tbFis.TabIndex = 1;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(11, 72);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(32, 13);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Location = new System.Drawing.Point(11, 158);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(34, 13);
            this.lblPetrol.TabIndex = 0;
            this.lblPetrol.Text = "Petrol";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(11, 129);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblTasFrm
            // 
            this.lblTasFrm.AutoSize = true;
            this.lblTasFrm.Location = new System.Drawing.Point(11, 187);
            this.lblTasFrm.Name = "lblTasFrm";
            this.lblTasFrm.Size = new System.Drawing.Size(70, 13);
            this.lblTasFrm.TabIndex = 0;
            this.lblTasFrm.Text = "Taşıyıcı Firma";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.Location = new System.Drawing.Point(11, 44);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(37, 13);
            this.lblFisNo.TabIndex = 0;
            this.lblFisNo.Text = "Fiş No";
            // 
            // ssDurum
            // 
            this.ssDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDurum});
            this.ssDurum.Location = new System.Drawing.Point(0, 323);
            this.ssDurum.Name = "ssDurum";
            this.ssDurum.Size = new System.Drawing.Size(254, 22);
            this.ssDurum.TabIndex = 0;
            // 
            // tssLblDurum
            // 
            this.tssLblDurum.Name = "tssLblDurum";
            this.tssLblDurum.Size = new System.Drawing.Size(90, 17);
            this.tssLblDurum.Text = "Durum Çubuğu";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbCIKIS
            // 
            this.cmbCIKIS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCIKIS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCIKIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCIKIS.FormattingEnabled = true;
            this.cmbCIKIS.Location = new System.Drawing.Point(108, 97);
            this.cmbCIKIS.Name = "cmbCIKIS";
            this.cmbCIKIS.Size = new System.Drawing.Size(121, 21);
            this.cmbCIKIS.TabIndex = 3;
            this.cmbCIKIS.Leave += new System.EventHandler(this.cmbPlaka_Leave);
            // 
            // lblCIKIS
            // 
            this.lblCIKIS.AutoSize = true;
            this.lblCIKIS.Location = new System.Drawing.Point(11, 100);
            this.lblCIKIS.Name = "lblCIKIS";
            this.lblCIKIS.Size = new System.Drawing.Size(50, 13);
            this.lblCIKIS.TabIndex = 0;
            this.lblCIKIS.Text = "Çıkış Yeri";
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(108, 211);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(121, 20);
            this.tbAciklama.TabIndex = 7;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(11, 214);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Açıklama";
            // 
            // FrmPetrolKayit
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(254, 345);
            this.ControlBox = false;
            this.Controls.Add(this.ssDurum);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbFis);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.cmbPetrol);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.lblCIKIS);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.cmbTasFrm);
            this.Controls.Add(this.cmbCIKIS);
            this.Controls.Add(this.cmbPlaka);
            this.Controls.Add(this.lblTasFrm);
            this.Controls.Add(this.lblPetrol);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.tbTutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPetrolKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol İşlemleri Kayıt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPetrolKayit_FormClosed);
            this.Load += new System.EventHandler(this.FrmPetrolKayit_Load);
            this.ssDurum.ResumeLayout(false);
            this.ssDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbPetrol;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.ComboBox cmbTasFrm;
        private System.Windows.Forms.Label lblTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.TextBox tbFis;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblTasFrm;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.StatusStrip ssDurum;
        private System.Windows.Forms.ToolStripStatusLabel tssLblDurum;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblCIKIS;
        private System.Windows.Forms.ComboBox cmbCIKIS;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox tbAciklama;
    }
}