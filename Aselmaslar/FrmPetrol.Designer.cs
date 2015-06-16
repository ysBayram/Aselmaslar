namespace Aselmaslar
{
    partial class FrmPetrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPetrol));
            this.pnlKonsol = new System.Windows.Forms.Panel();
            this.cmbCIKIS = new System.Windows.Forms.ComboBox();
            this.lblCIKIS = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbTasFrm = new System.Windows.Forms.ComboBox();
            this.cmbPlaka = new System.Windows.Forms.ComboBox();
            this.cmbPetrol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.tbTutar = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.tbFis = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTasFrm = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.dgvPetrol = new System.Windows.Forms.DataGridView();
            this.ssDurum = new System.Windows.Forms.StatusStrip();
            this.tssLblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.tsNavi = new System.Windows.Forms.ToolStrip();
            this.tsNaviLblMiktar = new System.Windows.Forms.ToolStripLabel();
            this.tstbMiktar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblSayfa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsBtnLast = new System.Windows.Forms.ToolStripButton();
            this.tssBtnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnTumu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlKonsol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetrol)).BeginInit();
            this.ssDurum.SuspendLayout();
            this.tsNavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKonsol
            // 
            this.pnlKonsol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlKonsol.Controls.Add(this.cmbCIKIS);
            this.pnlKonsol.Controls.Add(this.lblCIKIS);
            this.pnlKonsol.Controls.Add(this.btnArama);
            this.pnlKonsol.Controls.Add(this.btnKaydet);
            this.pnlKonsol.Controls.Add(this.cmbTasFrm);
            this.pnlKonsol.Controls.Add(this.cmbPlaka);
            this.pnlKonsol.Controls.Add(this.cmbPetrol);
            this.pnlKonsol.Controls.Add(this.label3);
            this.pnlKonsol.Controls.Add(this.lblTarih);
            this.pnlKonsol.Controls.Add(this.dtpTarih2);
            this.pnlKonsol.Controls.Add(this.dtpTarih1);
            this.pnlKonsol.Controls.Add(this.tbAciklama);
            this.pnlKonsol.Controls.Add(this.tbTutar);
            this.pnlKonsol.Controls.Add(this.lblAciklama);
            this.pnlKonsol.Controls.Add(this.tbFis);
            this.pnlKonsol.Controls.Add(this.lblTutar);
            this.pnlKonsol.Controls.Add(this.lblTasFrm);
            this.pnlKonsol.Controls.Add(this.lblPlaka);
            this.pnlKonsol.Controls.Add(this.lblPetrol);
            this.pnlKonsol.Controls.Add(this.lblFisNo);
            this.pnlKonsol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKonsol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlKonsol.Location = new System.Drawing.Point(0, 0);
            this.pnlKonsol.Name = "pnlKonsol";
            this.pnlKonsol.Size = new System.Drawing.Size(1017, 99);
            this.pnlKonsol.TabIndex = 0;
            // 
            // cmbCIKIS
            // 
            this.cmbCIKIS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCIKIS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCIKIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCIKIS.FormattingEnabled = true;
            this.cmbCIKIS.Location = new System.Drawing.Point(459, 61);
            this.cmbCIKIS.Name = "cmbCIKIS";
            this.cmbCIKIS.Size = new System.Drawing.Size(122, 23);
            this.cmbCIKIS.TabIndex = 7;
            // 
            // lblCIKIS
            // 
            this.lblCIKIS.AutoSize = true;
            this.lblCIKIS.Location = new System.Drawing.Point(388, 64);
            this.lblCIKIS.Name = "lblCIKIS";
            this.lblCIKIS.Size = new System.Drawing.Size(38, 15);
            this.lblCIKIS.TabIndex = 9;
            this.lblCIKIS.Text = "Çıkış";
            // 
            // btnArama
            // 
            this.btnArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnArama.Location = new System.Drawing.Point(849, 17);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(75, 66);
            this.btnArama.TabIndex = 9;
            this.btnArama.Text = "Arama";
            this.btnArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnKaydet.Location = new System.Drawing.Point(930, 17);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 66);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbTasFrm
            // 
            this.cmbTasFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTasFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTasFrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTasFrm.FormattingEnabled = true;
            this.cmbTasFrm.Location = new System.Drawing.Point(701, 60);
            this.cmbTasFrm.Name = "cmbTasFrm";
            this.cmbTasFrm.Size = new System.Drawing.Size(122, 23);
            this.cmbTasFrm.TabIndex = 8;
            // 
            // cmbPlaka
            // 
            this.cmbPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPlaka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaka.FormattingEnabled = true;
            this.cmbPlaka.Location = new System.Drawing.Point(250, 60);
            this.cmbPlaka.Name = "cmbPlaka";
            this.cmbPlaka.Size = new System.Drawing.Size(121, 23);
            this.cmbPlaka.TabIndex = 6;
            this.cmbPlaka.Leave += new System.EventHandler(this.cmbPlaka_Leave);
            // 
            // cmbPetrol
            // 
            this.cmbPetrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPetrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPetrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPetrol.FormattingEnabled = true;
            this.cmbPetrol.Location = new System.Drawing.Point(63, 60);
            this.cmbPetrol.Name = "cmbPetrol";
            this.cmbPetrol.Size = new System.Drawing.Size(121, 23);
            this.cmbPetrol.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "-";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(599, 20);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(40, 15);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih";
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih2.Location = new System.Drawing.Point(743, 18);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(80, 20);
            this.dtpTarih2.TabIndex = 4;
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih1.Location = new System.Drawing.Point(645, 17);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(80, 20);
            this.dtpTarih1.TabIndex = 3;
            // 
            // tbAciklama
            // 
            this.tbAciklama.Location = new System.Drawing.Point(459, 17);
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(121, 21);
            this.tbAciklama.TabIndex = 2;
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(250, 17);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(121, 21);
            this.tbTutar.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(388, 20);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(65, 15);
            this.lblAciklama.TabIndex = 0;
            this.lblAciklama.Text = "Açıklama";
            // 
            // tbFis
            // 
            this.tbFis.Location = new System.Drawing.Point(63, 17);
            this.tbFis.Name = "tbFis";
            this.tbFis.Size = new System.Drawing.Size(121, 21);
            this.tbFis.TabIndex = 0;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(204, 20);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(40, 15);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar";
            // 
            // lblTasFrm
            // 
            this.lblTasFrm.AutoSize = true;
            this.lblTasFrm.Location = new System.Drawing.Point(599, 63);
            this.lblTasFrm.Name = "lblTasFrm";
            this.lblTasFrm.Size = new System.Drawing.Size(96, 15);
            this.lblTasFrm.TabIndex = 0;
            this.lblTasFrm.Text = "Taşıyıcı Firma";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(204, 63);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(43, 15);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Location = new System.Drawing.Point(12, 63);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(45, 15);
            this.lblPetrol.TabIndex = 0;
            this.lblPetrol.Text = "Petrol";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.Location = new System.Drawing.Point(12, 20);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(48, 15);
            this.lblFisNo.TabIndex = 0;
            this.lblFisNo.Text = "Fiş No";
            // 
            // dgvPetrol
            // 
            this.dgvPetrol.AllowUserToAddRows = false;
            this.dgvPetrol.AllowUserToDeleteRows = false;
            this.dgvPetrol.AllowUserToResizeColumns = false;
            this.dgvPetrol.AllowUserToResizeRows = false;
            this.dgvPetrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPetrol.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPetrol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPetrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPetrol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPetrol.EnableHeadersVisualStyles = false;
            this.dgvPetrol.Location = new System.Drawing.Point(0, 127);
            this.dgvPetrol.MultiSelect = false;
            this.dgvPetrol.Name = "dgvPetrol";
            this.dgvPetrol.RowHeadersVisible = false;
            this.dgvPetrol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPetrol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPetrol.Size = new System.Drawing.Size(1017, 282);
            this.dgvPetrol.TabIndex = 1;
            this.dgvPetrol.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPetrol_CellDoubleClick);
            this.dgvPetrol.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPetrol_DataBindingComplete);
            // 
            // ssDurum
            // 
            this.ssDurum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDurum});
            this.ssDurum.Location = new System.Drawing.Point(0, 409);
            this.ssDurum.Name = "ssDurum";
            this.ssDurum.Size = new System.Drawing.Size(1017, 25);
            this.ssDurum.TabIndex = 2;
            this.ssDurum.Text = "statusStrip1";
            // 
            // tssLblDurum
            // 
            this.tssLblDurum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tssLblDurum.Name = "tssLblDurum";
            this.tssLblDurum.Size = new System.Drawing.Size(39, 20);
            this.tssLblDurum.Text = "  --- ";
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Dosyası | *.xlsx";
            this.sfdExcel.InitialDirectory = "C:\\\\Users\\\\%USERPROFILE%\\\\Desktop";
            this.sfdExcel.Title = "Lütfen Kayıt Yerini Seçiniz";
            // 
            // tsNavi
            // 
            this.tsNavi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsNavi.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsNavi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNaviLblMiktar,
            this.tstbMiktar,
            this.toolStripSeparator4,
            this.tsBtnFirst,
            this.tsBtnPrev,
            this.toolStripSeparator1,
            this.tsLblSayfa,
            this.toolStripSeparator6,
            this.tsBtnNext,
            this.tsBtnLast,
            this.tssBtnExcel,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.tsBtnTumu,
            this.toolStripSeparator5});
            this.tsNavi.Location = new System.Drawing.Point(0, 99);
            this.tsNavi.Name = "tsNavi";
            this.tsNavi.Size = new System.Drawing.Size(1017, 28);
            this.tsNavi.TabIndex = 3;
            // 
            // tsNaviLblMiktar
            // 
            this.tsNaviLblMiktar.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.tsNaviLblMiktar.Name = "tsNaviLblMiktar";
            this.tsNaviLblMiktar.Size = new System.Drawing.Size(126, 25);
            this.tsNaviLblMiktar.Text = "Sayfa Gösterim Miktarı";
            // 
            // tstbMiktar
            // 
            this.tstbMiktar.Name = "tstbMiktar";
            this.tstbMiktar.Size = new System.Drawing.Size(30, 28);
            this.tstbMiktar.Text = "25";
            this.tstbMiktar.ToolTipText = "Tek Sayfadaki Gösterilecek Olan Kayıt Miktarı";
            this.tstbMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstbMiktar_KeyPress);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // tsBtnFirst
            // 
            this.tsBtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnFirst.Enabled = false;
            this.tsBtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirst.Image")));
            this.tsBtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirst.Name = "tsBtnFirst";
            this.tsBtnFirst.Size = new System.Drawing.Size(73, 25);
            this.tsBtnFirst.Text = "<< İlk Sayfa";
            this.tsBtnFirst.ToolTipText = "İlk Sayfaya Gider";
            this.tsBtnFirst.Click += new System.EventHandler(this.tsBtnFirst_Click);
            // 
            // tsBtnPrev
            // 
            this.tsBtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnPrev.Enabled = false;
            this.tsBtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPrev.Image")));
            this.tsBtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPrev.Name = "tsBtnPrev";
            this.tsBtnPrev.Size = new System.Drawing.Size(90, 25);
            this.tsBtnPrev.Text = "< Önceki Sayfa";
            this.tsBtnPrev.ToolTipText = "Önceki Sayfaya Gider";
            this.tsBtnPrev.Click += new System.EventHandler(this.tsBtnPrev_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsLblSayfa
            // 
            this.tsLblSayfa.Name = "tsLblSayfa";
            this.tsLblSayfa.Size = new System.Drawing.Size(22, 25);
            this.tsLblSayfa.Text = "-/-";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // tsBtnNext
            // 
            this.tsBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnNext.Enabled = false;
            this.tsBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNext.Image")));
            this.tsBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNext.Name = "tsBtnNext";
            this.tsBtnNext.Size = new System.Drawing.Size(92, 25);
            this.tsBtnNext.Text = "Sonraki Sayfa >";
            this.tsBtnNext.ToolTipText = "Sonraki Sayfaya Gider";
            this.tsBtnNext.Click += new System.EventHandler(this.tsBtnNext_Click);
            // 
            // tsBtnLast
            // 
            this.tsBtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnLast.Enabled = false;
            this.tsBtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLast.Image")));
            this.tsBtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLast.Name = "tsBtnLast";
            this.tsBtnLast.Size = new System.Drawing.Size(81, 25);
            this.tsBtnLast.Text = "Son Sayfa >>";
            this.tsBtnLast.ToolTipText = "Son Sayfaya Gider";
            this.tsBtnLast.Click += new System.EventHandler(this.tsBtnLast_Click);
            // 
            // tssBtnExcel
            // 
            this.tssBtnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tssBtnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.tssBtnExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tssBtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("tssBtnExcel.Image")));
            this.tssBtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssBtnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.tssBtnExcel.Name = "tssBtnExcel";
            this.tssBtnExcel.Size = new System.Drawing.Size(119, 24);
            this.tssBtnExcel.Text = "Excel\'e Aktar";
            this.tssBtnExcel.Click += new System.EventHandler(this.tssBtnExcel_ButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsBtnTumu
            // 
            this.tsBtnTumu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnTumu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnTumu.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTumu.Image")));
            this.tsBtnTumu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTumu.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.tsBtnTumu.Name = "tsBtnTumu";
            this.tsBtnTumu.Size = new System.Drawing.Size(109, 25);
            this.tsBtnTumu.Text = "Tüm Kayıtları Getir";
            this.tsBtnTumu.Click += new System.EventHandler(this.tsBtnTumu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmPetrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 434);
            this.Controls.Add(this.dgvPetrol);
            this.Controls.Add(this.tsNavi);
            this.Controls.Add(this.ssDurum);
            this.Controls.Add(this.pnlKonsol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPetrol";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPetrol_FormClosed);
            this.Load += new System.EventHandler(this.FrmPetrol_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPetrol_SizeChanged);
            this.pnlKonsol.ResumeLayout(false);
            this.pnlKonsol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetrol)).EndInit();
            this.ssDurum.ResumeLayout(false);
            this.ssDurum.PerformLayout();
            this.tsNavi.ResumeLayout(false);
            this.tsNavi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKonsol;
        private System.Windows.Forms.DataGridView dgvPetrol;
        private System.Windows.Forms.StatusStrip ssDurum;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.TextBox tbFis;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.TextBox tbTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.ComboBox cmbTasFrm;
        private System.Windows.Forms.ComboBox cmbPlaka;
        private System.Windows.Forms.ComboBox cmbPetrol;
        private System.Windows.Forms.Label lblTasFrm;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.ToolStripStatusLabel tssLblDurum;
        private System.Windows.Forms.ToolStrip tsNavi;
        private System.Windows.Forms.ToolStripButton tsBtnFirst;
        private System.Windows.Forms.ToolStripButton tsBtnPrev;
        private System.Windows.Forms.ToolStripButton tsBtnNext;
        private System.Windows.Forms.ToolStripButton tsBtnLast;
        private System.Windows.Forms.ToolStripLabel tsNaviLblMiktar;
        private System.Windows.Forms.ToolStripTextBox tstbMiktar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tssBtnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnTumu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel tsLblSayfa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbCIKIS;
        private System.Windows.Forms.Label lblCIKIS;
        private System.Windows.Forms.TextBox tbAciklama;
        private System.Windows.Forms.Label lblAciklama;
    }
}