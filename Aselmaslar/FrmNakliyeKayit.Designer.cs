namespace Aselmaslar
{
    partial class FrmNakliyeKayit
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
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.cmbGondrlnYer = new System.Windows.Forms.ComboBox();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.cmbTasFrm = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.tbIrsaliye = new System.Windows.Forms.TextBox();
            this.tbTonaj = new System.Windows.Forms.TextBox();
            this.tbFis = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblIrsaliye = new System.Windows.Forms.Label();
            this.lblGondrlnYer = new System.Windows.Forms.Label();
            this.lblGrup = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblTasFrm = new System.Windows.Forms.Label();
            this.lblTonaj = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.ssDurum = new System.Windows.Forms.StatusStrip();
            this.tssLblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCIKIS = new System.Windows.Forms.ComboBox();
            this.lblCIKIS = new System.Windows.Forms.Label();
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
            this.btnIptal.Location = new System.Drawing.Point(129, 372);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 50);
            this.btnIptal.TabIndex = 13;
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
            this.btnKaydet.Location = new System.Drawing.Point(14, 372);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 50);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbUrun
            // 
            this.cmbUrun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUrun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(108, 183);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbUrun.TabIndex = 6;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbGrup
            // 
            this.cmbGrup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGrup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrup.Enabled = false;
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Location = new System.Drawing.Point(108, 327);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(121, 21);
            this.cmbGrup.TabIndex = 7;
            // 
            // cmbGondrlnYer
            // 
            this.cmbGondrlnYer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGondrlnYer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGondrlnYer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGondrlnYer.FormattingEnabled = true;
            this.cmbGondrlnYer.Location = new System.Drawing.Point(108, 154);
            this.cmbGondrlnYer.Name = "cmbGondrlnYer";
            this.cmbGondrlnYer.Size = new System.Drawing.Size(121, 21);
            this.cmbGondrlnYer.TabIndex = 5;
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.Location = new System.Drawing.Point(108, 212);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaka.TabIndex = 8;
            this.cmbPlaka.SelectedIndexChanged += new System.EventHandler(this.cmbPlaka_SelectedIndexChanged);
            // 
            // cmbTasFrm
            // 
            this.cmbTasFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTasFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTasFrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTasFrm.Enabled = false;
            this.cmbTasFrm.FormattingEnabled = true;
            this.cmbTasFrm.Location = new System.Drawing.Point(108, 299);
            this.cmbTasFrm.Name = "cmbTasFrm";
            this.cmbTasFrm.Size = new System.Drawing.Size(121, 21);
            this.cmbTasFrm.TabIndex = 10;
            // 
            // cmbAlici
            // 
            this.cmbAlici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAlici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Location = new System.Drawing.Point(108, 125);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(121, 21);
            this.cmbAlici.TabIndex = 4;
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.Location = new System.Drawing.Point(12, 19);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(31, 13);
            this.lblTarih1.TabIndex = 0;
            this.lblTarih1.Text = "Tarih";
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpTarih1.CalendarTitleForeColor = System.Drawing.Color.AntiqueWhite;
            this.dtpTarih1.CustomFormat = "";
            this.dtpTarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih1.Location = new System.Drawing.Point(108, 12);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(121, 20);
            this.dtpTarih1.TabIndex = 0;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(108, 270);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(121, 20);
            this.tbAciklama.TabIndex = 11;
            // 
            // tbIrsaliye
            // 
            this.tbIrsaliye.Location = new System.Drawing.Point(108, 68);
            this.tbIrsaliye.Name = "tbIrsaliye";
            this.tbIrsaliye.Size = new System.Drawing.Size(121, 20);
            this.tbIrsaliye.TabIndex = 2;
            this.tbIrsaliye.Leave += new System.EventHandler(this.tbIrsaliye_Leave);
            // 
            // tbTonaj
            // 
            this.tbTonaj.Location = new System.Drawing.Point(108, 241);
            this.tbTonaj.Name = "tbTonaj";
            this.tbTonaj.Size = new System.Drawing.Size(121, 20);
            this.tbTonaj.TabIndex = 9;
            // 
            // tbFis
            // 
            this.tbFis.Location = new System.Drawing.Point(108, 40);
            this.tbFis.Name = "tbFis";
            this.tbFis.Size = new System.Drawing.Size(121, 20);
            this.tbFis.TabIndex = 1;
            this.tbFis.Leave += new System.EventHandler(this.tbFis_Leave);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(12, 273);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(12, 186);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(30, 13);
            this.lblUrun.TabIndex = 0;
            this.lblUrun.Text = "Ürün";
            // 
            // lblIrsaliye
            // 
            this.lblIrsaliye.AutoSize = true;
            this.lblIrsaliye.Location = new System.Drawing.Point(12, 71);
            this.lblIrsaliye.Name = "lblIrsaliye";
            this.lblIrsaliye.Size = new System.Drawing.Size(56, 13);
            this.lblIrsaliye.TabIndex = 0;
            this.lblIrsaliye.Text = "İrsaliye No";
            // 
            // lblGondrlnYer
            // 
            this.lblGondrlnYer.AutoSize = true;
            this.lblGondrlnYer.Location = new System.Drawing.Point(12, 157);
            this.lblGondrlnYer.Name = "lblGondrlnYer";
            this.lblGondrlnYer.Size = new System.Drawing.Size(76, 13);
            this.lblGondrlnYer.TabIndex = 0;
            this.lblGondrlnYer.Text = "Teslim Noktası";
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.Location = new System.Drawing.Point(12, 330);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(56, 13);
            this.lblGrup.TabIndex = 0;
            this.lblGrup.Text = "Ürün Grup";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(12, 215);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblTasFrm
            // 
            this.lblTasFrm.AutoSize = true;
            this.lblTasFrm.Location = new System.Drawing.Point(12, 302);
            this.lblTasFrm.Name = "lblTasFrm";
            this.lblTasFrm.Size = new System.Drawing.Size(70, 13);
            this.lblTasFrm.TabIndex = 0;
            this.lblTasFrm.Text = "Taşıyıcı Firma";
            // 
            // lblTonaj
            // 
            this.lblTonaj.AutoSize = true;
            this.lblTonaj.Location = new System.Drawing.Point(12, 244);
            this.lblTonaj.Name = "lblTonaj";
            this.lblTonaj.Size = new System.Drawing.Size(34, 13);
            this.lblTonaj.TabIndex = 0;
            this.lblTonaj.Text = "Tonaj";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(12, 128);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(54, 13);
            this.lblAlici.TabIndex = 0;
            this.lblAlici.Text = "Alıcı Firma";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.Location = new System.Drawing.Point(12, 43);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(37, 13);
            this.lblFisNo.TabIndex = 0;
            this.lblFisNo.Text = "Fiş No";
            // 
            // ssDurum
            // 
            this.ssDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDurum});
            this.ssDurum.Location = new System.Drawing.Point(0, 429);
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
            this.cmbCIKIS.Location = new System.Drawing.Point(108, 96);
            this.cmbCIKIS.Name = "cmbCIKIS";
            this.cmbCIKIS.Size = new System.Drawing.Size(121, 21);
            this.cmbCIKIS.TabIndex = 3;
            // 
            // lblCIKIS
            // 
            this.lblCIKIS.AutoSize = true;
            this.lblCIKIS.Location = new System.Drawing.Point(12, 99);
            this.lblCIKIS.Name = "lblCIKIS";
            this.lblCIKIS.Size = new System.Drawing.Size(50, 13);
            this.lblCIKIS.TabIndex = 0;
            this.lblCIKIS.Text = "Çıkış Yeri";
            // 
            // FrmNakliyeKayit
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(254, 451);
            this.ControlBox = false;
            this.Controls.Add(this.ssDurum);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbFis);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.cmbGrup);
            this.Controls.Add(this.lblCIKIS);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.cmbGondrlnYer);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.cmbTasFrm);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.cmbPlaka);
            this.Controls.Add(this.tbTonaj);
            this.Controls.Add(this.cmbCIKIS);
            this.Controls.Add(this.cmbAlici);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTasFrm);
            this.Controls.Add(this.lblGondrlnYer);
            this.Controls.Add(this.lblGrup);
            this.Controls.Add(this.lblIrsaliye);
            this.Controls.Add(this.lblTonaj);
            this.Controls.Add(this.tbIrsaliye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmNakliyeKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nakliye Kayit İşlemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNakliyeKayit_FormClosed);
            this.Load += new System.EventHandler(this.FrmNakliyeKayit_Load);
            this.ssDurum.ResumeLayout(false);
            this.ssDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbGrup;
        private System.Windows.Forms.ComboBox cmbGondrlnYer;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.ComboBox cmbTasFrm;
        private System.Windows.Forms.ComboBox cmbAlici;
        private System.Windows.Forms.Label lblTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.TextBox tbIrsaliye;
        private System.Windows.Forms.TextBox tbTonaj;
        private System.Windows.Forms.TextBox tbFis;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblIrsaliye;
        private System.Windows.Forms.Label lblGondrlnYer;
        private System.Windows.Forms.Label lblGrup;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblTasFrm;
        private System.Windows.Forms.Label lblTonaj;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.StatusStrip ssDurum;
        private System.Windows.Forms.ToolStripStatusLabel tssLblDurum;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblCIKIS;
        private System.Windows.Forms.ComboBox cmbCIKIS;
    }
}