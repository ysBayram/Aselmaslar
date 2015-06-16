namespace Aselmaslar
{
    partial class FrmVeri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeri));
            this.tabcVeri = new System.Windows.Forms.TabControl();
            this.tabAlici = new System.Windows.Forms.TabPage();
            this.btnAlArama = new System.Windows.Forms.Button();
            this.btnAlKayit = new System.Windows.Forms.Button();
            this.tbAlTel = new System.Windows.Forms.TextBox();
            this.tbAlSorumlu = new System.Windows.Forms.TextBox();
            this.tbAlAd = new System.Windows.Forms.TextBox();
            this.lblAlTel = new System.Windows.Forms.Label();
            this.lblAlSorumlu = new System.Windows.Forms.Label();
            this.lblAlAd = new System.Windows.Forms.Label();
            this.tabTasyc = new System.Windows.Forms.TabPage();
            this.tbTasAd = new System.Windows.Forms.TextBox();
            this.lblTasAd = new System.Windows.Forms.Label();
            this.btnTasArama = new System.Windows.Forms.Button();
            this.btnTasKayit = new System.Windows.Forms.Button();
            this.tabPlaka = new System.Windows.Forms.TabPage();
            this.cbPlTasFrm = new System.Windows.Forms.ComboBox();
            this.tbPlAd = new System.Windows.Forms.TextBox();
            this.lblPlTasFrm = new System.Windows.Forms.Label();
            this.lblPlAd = new System.Windows.Forms.Label();
            this.btnPlArama = new System.Windows.Forms.Button();
            this.btnPlKayit = new System.Windows.Forms.Button();
            this.tabGondYer = new System.Windows.Forms.TabPage();
            this.tbGonAd = new System.Windows.Forms.TextBox();
            this.lblGonAd = new System.Windows.Forms.Label();
            this.btnGonArama = new System.Windows.Forms.Button();
            this.btnGonKayit = new System.Windows.Forms.Button();
            this.tabPetrol = new System.Windows.Forms.TabPage();
            this.btnPetArama = new System.Windows.Forms.Button();
            this.btnPetKayit = new System.Windows.Forms.Button();
            this.tbPetTel = new System.Windows.Forms.TextBox();
            this.tbPetSorum = new System.Windows.Forms.TextBox();
            this.tbPetAd = new System.Windows.Forms.TextBox();
            this.lblPetTel = new System.Windows.Forms.Label();
            this.lblPetSorum = new System.Windows.Forms.Label();
            this.lblPetAd = new System.Windows.Forms.Label();
            this.tabGrup = new System.Windows.Forms.TabPage();
            this.tbGrupAd = new System.Windows.Forms.TextBox();
            this.lblGrupAd = new System.Windows.Forms.Label();
            this.btnGrupArama = new System.Windows.Forms.Button();
            this.btnGrupKayit = new System.Windows.Forms.Button();
            this.tabUrun = new System.Windows.Forms.TabPage();
            this.cmbUrunGrup = new System.Windows.Forms.ComboBox();
            this.tbUrunAd = new System.Windows.Forms.TextBox();
            this.lblUrunGrup = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.btnUrunArama = new System.Windows.Forms.Button();
            this.btnUrunKayit = new System.Windows.Forms.Button();
            this.tabCIKIS = new System.Windows.Forms.TabPage();
            this.tbCIKISAd = new System.Windows.Forms.TextBox();
            this.lblCIKISAd = new System.Windows.Forms.Label();
            this.btnCIKISArama = new System.Windows.Forms.Button();
            this.btnCIKISKayit = new System.Windows.Forms.Button();
            this.dgvVeriler = new System.Windows.Forms.DataGridView();
            this.statusStripVeri = new System.Windows.Forms.StatusStrip();
            this.tssLblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBtnExcel = new System.Windows.Forms.ToolStripSplitButton();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabcVeri.SuspendLayout();
            this.tabAlici.SuspendLayout();
            this.tabTasyc.SuspendLayout();
            this.tabPlaka.SuspendLayout();
            this.tabGondYer.SuspendLayout();
            this.tabPetrol.SuspendLayout();
            this.tabGrup.SuspendLayout();
            this.tabUrun.SuspendLayout();
            this.tabCIKIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).BeginInit();
            this.statusStripVeri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcVeri
            // 
            this.tabcVeri.Controls.Add(this.tabAlici);
            this.tabcVeri.Controls.Add(this.tabTasyc);
            this.tabcVeri.Controls.Add(this.tabPlaka);
            this.tabcVeri.Controls.Add(this.tabGondYer);
            this.tabcVeri.Controls.Add(this.tabPetrol);
            this.tabcVeri.Controls.Add(this.tabGrup);
            this.tabcVeri.Controls.Add(this.tabUrun);
            this.tabcVeri.Controls.Add(this.tabCIKIS);
            this.tabcVeri.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabcVeri.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabcVeri.ItemSize = new System.Drawing.Size(122, 25);
            this.tabcVeri.Location = new System.Drawing.Point(0, 0);
            this.tabcVeri.Name = "tabcVeri";
            this.tabcVeri.SelectedIndex = 0;
            this.tabcVeri.Size = new System.Drawing.Size(949, 111);
            this.tabcVeri.TabIndex = 0;
            this.tabcVeri.SelectedIndexChanged += new System.EventHandler(this.tabcVeri_SelectedIndexChanged);
            // 
            // tabAlici
            // 
            this.tabAlici.Controls.Add(this.btnAlArama);
            this.tabAlici.Controls.Add(this.btnAlKayit);
            this.tabAlici.Controls.Add(this.tbAlTel);
            this.tabAlici.Controls.Add(this.tbAlSorumlu);
            this.tabAlici.Controls.Add(this.tbAlAd);
            this.tabAlici.Controls.Add(this.lblAlTel);
            this.tabAlici.Controls.Add(this.lblAlSorumlu);
            this.tabAlici.Controls.Add(this.lblAlAd);
            this.tabAlici.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabAlici.Location = new System.Drawing.Point(4, 29);
            this.tabAlici.Name = "tabAlici";
            this.tabAlici.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlici.Size = new System.Drawing.Size(941, 78);
            this.tabAlici.TabIndex = 0;
            this.tabAlici.Text = "Müşteri";
            this.tabAlici.UseVisualStyleBackColor = true;
            // 
            // btnAlArama
            // 
            this.btnAlArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnAlArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlArama.Location = new System.Drawing.Point(757, 10);
            this.btnAlArama.Name = "btnAlArama";
            this.btnAlArama.Size = new System.Drawing.Size(85, 58);
            this.btnAlArama.TabIndex = 3;
            this.btnAlArama.Text = "Arama";
            this.btnAlArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlArama.UseVisualStyleBackColor = true;
            this.btnAlArama.Click += new System.EventHandler(this.btnAlArama_Click);
            // 
            // btnAlKayit
            // 
            this.btnAlKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnAlKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlKayit.Location = new System.Drawing.Point(848, 10);
            this.btnAlKayit.Name = "btnAlKayit";
            this.btnAlKayit.Size = new System.Drawing.Size(85, 58);
            this.btnAlKayit.TabIndex = 4;
            this.btnAlKayit.Text = "Kaydet";
            this.btnAlKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlKayit.UseVisualStyleBackColor = true;
            this.btnAlKayit.Click += new System.EventHandler(this.btnAlKayit_Click);
            // 
            // tbAlTel
            // 
            this.tbAlTel.Location = new System.Drawing.Point(385, 15);
            this.tbAlTel.Name = "tbAlTel";
            this.tbAlTel.Size = new System.Drawing.Size(193, 22);
            this.tbAlTel.TabIndex = 1;
            // 
            // tbAlSorumlu
            // 
            this.tbAlSorumlu.Location = new System.Drawing.Point(113, 47);
            this.tbAlSorumlu.Name = "tbAlSorumlu";
            this.tbAlSorumlu.Size = new System.Drawing.Size(193, 22);
            this.tbAlSorumlu.TabIndex = 2;
            // 
            // tbAlAd
            // 
            this.tbAlAd.Location = new System.Drawing.Point(113, 15);
            this.tbAlAd.Name = "tbAlAd";
            this.tbAlAd.Size = new System.Drawing.Size(193, 22);
            this.tbAlAd.TabIndex = 0;
            // 
            // lblAlTel
            // 
            this.lblAlTel.AutoSize = true;
            this.lblAlTel.Location = new System.Drawing.Point(334, 18);
            this.lblAlTel.Name = "lblAlTel";
            this.lblAlTel.Size = new System.Drawing.Size(27, 14);
            this.lblAlTel.TabIndex = 0;
            this.lblAlTel.Text = "Tel";
            // 
            // lblAlSorumlu
            // 
            this.lblAlSorumlu.AutoSize = true;
            this.lblAlSorumlu.Location = new System.Drawing.Point(12, 50);
            this.lblAlSorumlu.Name = "lblAlSorumlu";
            this.lblAlSorumlu.Size = new System.Drawing.Size(64, 14);
            this.lblAlSorumlu.TabIndex = 0;
            this.lblAlSorumlu.Text = "Sorumlu";
            // 
            // lblAlAd
            // 
            this.lblAlAd.AutoSize = true;
            this.lblAlAd.Location = new System.Drawing.Point(12, 18);
            this.lblAlAd.Name = "lblAlAd";
            this.lblAlAd.Size = new System.Drawing.Size(24, 14);
            this.lblAlAd.TabIndex = 0;
            this.lblAlAd.Text = "Ad";
            // 
            // tabTasyc
            // 
            this.tabTasyc.Controls.Add(this.tbTasAd);
            this.tabTasyc.Controls.Add(this.lblTasAd);
            this.tabTasyc.Controls.Add(this.btnTasArama);
            this.tabTasyc.Controls.Add(this.btnTasKayit);
            this.tabTasyc.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabTasyc.Location = new System.Drawing.Point(4, 29);
            this.tabTasyc.Name = "tabTasyc";
            this.tabTasyc.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasyc.Size = new System.Drawing.Size(941, 78);
            this.tabTasyc.TabIndex = 1;
            this.tabTasyc.Text = "Taşıyıcı Firma";
            this.tabTasyc.UseVisualStyleBackColor = true;
            // 
            // tbTasAd
            // 
            this.tbTasAd.Location = new System.Drawing.Point(113, 15);
            this.tbTasAd.Name = "tbTasAd";
            this.tbTasAd.Size = new System.Drawing.Size(193, 22);
            this.tbTasAd.TabIndex = 0;
            // 
            // lblTasAd
            // 
            this.lblTasAd.AutoSize = true;
            this.lblTasAd.Location = new System.Drawing.Point(12, 18);
            this.lblTasAd.Name = "lblTasAd";
            this.lblTasAd.Size = new System.Drawing.Size(24, 14);
            this.lblTasAd.TabIndex = 10;
            this.lblTasAd.Text = "Ad";
            // 
            // btnTasArama
            // 
            this.btnTasArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnTasArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTasArama.Location = new System.Drawing.Point(757, 10);
            this.btnTasArama.Name = "btnTasArama";
            this.btnTasArama.Size = new System.Drawing.Size(85, 58);
            this.btnTasArama.TabIndex = 1;
            this.btnTasArama.Text = "Arama";
            this.btnTasArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTasArama.UseVisualStyleBackColor = true;
            this.btnTasArama.Click += new System.EventHandler(this.btnTasArama_Click);
            // 
            // btnTasKayit
            // 
            this.btnTasKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnTasKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTasKayit.Location = new System.Drawing.Point(848, 10);
            this.btnTasKayit.Name = "btnTasKayit";
            this.btnTasKayit.Size = new System.Drawing.Size(85, 58);
            this.btnTasKayit.TabIndex = 2;
            this.btnTasKayit.Text = "Kaydet";
            this.btnTasKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTasKayit.UseVisualStyleBackColor = true;
            this.btnTasKayit.Click += new System.EventHandler(this.btnTasKayit_Click);
            // 
            // tabPlaka
            // 
            this.tabPlaka.Controls.Add(this.cbPlTasFrm);
            this.tabPlaka.Controls.Add(this.tbPlAd);
            this.tabPlaka.Controls.Add(this.lblPlTasFrm);
            this.tabPlaka.Controls.Add(this.lblPlAd);
            this.tabPlaka.Controls.Add(this.btnPlArama);
            this.tabPlaka.Controls.Add(this.btnPlKayit);
            this.tabPlaka.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPlaka.Location = new System.Drawing.Point(4, 29);
            this.tabPlaka.Name = "tabPlaka";
            this.tabPlaka.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaka.Size = new System.Drawing.Size(941, 78);
            this.tabPlaka.TabIndex = 2;
            this.tabPlaka.Text = "Plaka";
            this.tabPlaka.UseVisualStyleBackColor = true;
            this.tabPlaka.Enter += new System.EventHandler(this.tabPlaka_Enter);
            // 
            // cbPlTasFrm
            // 
            this.cbPlTasFrm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlTasFrm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlTasFrm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlTasFrm.FormattingEnabled = true;
            this.cbPlTasFrm.Location = new System.Drawing.Point(180, 47);
            this.cbPlTasFrm.Name = "cbPlTasFrm";
            this.cbPlTasFrm.Size = new System.Drawing.Size(193, 22);
            this.cbPlTasFrm.TabIndex = 1;
            // 
            // tbPlAd
            // 
            this.tbPlAd.Location = new System.Drawing.Point(180, 15);
            this.tbPlAd.Name = "tbPlAd";
            this.tbPlAd.Size = new System.Drawing.Size(193, 22);
            this.tbPlAd.TabIndex = 0;
            // 
            // lblPlTasFrm
            // 
            this.lblPlTasFrm.AutoSize = true;
            this.lblPlTasFrm.Location = new System.Drawing.Point(12, 50);
            this.lblPlTasFrm.Name = "lblPlTasFrm";
            this.lblPlTasFrm.Size = new System.Drawing.Size(97, 14);
            this.lblPlTasFrm.TabIndex = 14;
            this.lblPlTasFrm.Text = "Taşıyıcı Firma";
            // 
            // lblPlAd
            // 
            this.lblPlAd.AutoSize = true;
            this.lblPlAd.Location = new System.Drawing.Point(12, 18);
            this.lblPlAd.Name = "lblPlAd";
            this.lblPlAd.Size = new System.Drawing.Size(24, 14);
            this.lblPlAd.TabIndex = 14;
            this.lblPlAd.Text = "Ad";
            // 
            // btnPlArama
            // 
            this.btnPlArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnPlArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlArama.Location = new System.Drawing.Point(757, 10);
            this.btnPlArama.Name = "btnPlArama";
            this.btnPlArama.Size = new System.Drawing.Size(85, 58);
            this.btnPlArama.TabIndex = 2;
            this.btnPlArama.Text = "Arama";
            this.btnPlArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlArama.UseVisualStyleBackColor = true;
            this.btnPlArama.Click += new System.EventHandler(this.btnPlArama_Click);
            // 
            // btnPlKayit
            // 
            this.btnPlKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnPlKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlKayit.Location = new System.Drawing.Point(848, 10);
            this.btnPlKayit.Name = "btnPlKayit";
            this.btnPlKayit.Size = new System.Drawing.Size(85, 58);
            this.btnPlKayit.TabIndex = 3;
            this.btnPlKayit.Text = "Kaydet";
            this.btnPlKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlKayit.UseVisualStyleBackColor = true;
            this.btnPlKayit.Click += new System.EventHandler(this.btnPlKayit_Click);
            // 
            // tabGondYer
            // 
            this.tabGondYer.Controls.Add(this.tbGonAd);
            this.tabGondYer.Controls.Add(this.lblGonAd);
            this.tabGondYer.Controls.Add(this.btnGonArama);
            this.tabGondYer.Controls.Add(this.btnGonKayit);
            this.tabGondYer.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.tabGondYer.Location = new System.Drawing.Point(4, 29);
            this.tabGondYer.Name = "tabGondYer";
            this.tabGondYer.Padding = new System.Windows.Forms.Padding(3);
            this.tabGondYer.Size = new System.Drawing.Size(941, 78);
            this.tabGondYer.TabIndex = 3;
            this.tabGondYer.Text = "Teslim Yeri";
            this.tabGondYer.UseVisualStyleBackColor = true;
            // 
            // tbGonAd
            // 
            this.tbGonAd.Location = new System.Drawing.Point(113, 15);
            this.tbGonAd.Name = "tbGonAd";
            this.tbGonAd.Size = new System.Drawing.Size(193, 22);
            this.tbGonAd.TabIndex = 0;
            // 
            // lblGonAd
            // 
            this.lblGonAd.AutoSize = true;
            this.lblGonAd.Location = new System.Drawing.Point(12, 18);
            this.lblGonAd.Name = "lblGonAd";
            this.lblGonAd.Size = new System.Drawing.Size(24, 14);
            this.lblGonAd.TabIndex = 14;
            this.lblGonAd.Text = "Ad";
            // 
            // btnGonArama
            // 
            this.btnGonArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnGonArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGonArama.Location = new System.Drawing.Point(757, 10);
            this.btnGonArama.Name = "btnGonArama";
            this.btnGonArama.Size = new System.Drawing.Size(85, 58);
            this.btnGonArama.TabIndex = 1;
            this.btnGonArama.Text = "Arama";
            this.btnGonArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGonArama.UseVisualStyleBackColor = true;
            this.btnGonArama.Click += new System.EventHandler(this.btnGonArama_Click);
            // 
            // btnGonKayit
            // 
            this.btnGonKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnGonKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGonKayit.Location = new System.Drawing.Point(848, 10);
            this.btnGonKayit.Name = "btnGonKayit";
            this.btnGonKayit.Size = new System.Drawing.Size(85, 58);
            this.btnGonKayit.TabIndex = 2;
            this.btnGonKayit.Text = "Kaydet";
            this.btnGonKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGonKayit.UseVisualStyleBackColor = true;
            this.btnGonKayit.Click += new System.EventHandler(this.btnGonKayit_Click);
            // 
            // tabPetrol
            // 
            this.tabPetrol.Controls.Add(this.btnPetArama);
            this.tabPetrol.Controls.Add(this.btnPetKayit);
            this.tabPetrol.Controls.Add(this.tbPetTel);
            this.tabPetrol.Controls.Add(this.tbPetSorum);
            this.tabPetrol.Controls.Add(this.tbPetAd);
            this.tabPetrol.Controls.Add(this.lblPetTel);
            this.tabPetrol.Controls.Add(this.lblPetSorum);
            this.tabPetrol.Controls.Add(this.lblPetAd);
            this.tabPetrol.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.tabPetrol.Location = new System.Drawing.Point(4, 29);
            this.tabPetrol.Name = "tabPetrol";
            this.tabPetrol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPetrol.Size = new System.Drawing.Size(941, 78);
            this.tabPetrol.TabIndex = 4;
            this.tabPetrol.Text = "Petrol";
            this.tabPetrol.UseVisualStyleBackColor = true;
            // 
            // btnPetArama
            // 
            this.btnPetArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnPetArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPetArama.Location = new System.Drawing.Point(757, 10);
            this.btnPetArama.Name = "btnPetArama";
            this.btnPetArama.Size = new System.Drawing.Size(85, 58);
            this.btnPetArama.TabIndex = 3;
            this.btnPetArama.Text = "Arama";
            this.btnPetArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPetArama.UseVisualStyleBackColor = true;
            this.btnPetArama.Click += new System.EventHandler(this.btnPetArama_Click);
            // 
            // btnPetKayit
            // 
            this.btnPetKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnPetKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPetKayit.Location = new System.Drawing.Point(848, 10);
            this.btnPetKayit.Name = "btnPetKayit";
            this.btnPetKayit.Size = new System.Drawing.Size(85, 58);
            this.btnPetKayit.TabIndex = 4;
            this.btnPetKayit.Text = "Kaydet";
            this.btnPetKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPetKayit.UseVisualStyleBackColor = true;
            this.btnPetKayit.Click += new System.EventHandler(this.btnPetKayit_Click);
            // 
            // tbPetTel
            // 
            this.tbPetTel.Location = new System.Drawing.Point(385, 15);
            this.tbPetTel.Name = "tbPetTel";
            this.tbPetTel.Size = new System.Drawing.Size(193, 22);
            this.tbPetTel.TabIndex = 1;
            // 
            // tbPetSorum
            // 
            this.tbPetSorum.Location = new System.Drawing.Point(113, 47);
            this.tbPetSorum.Name = "tbPetSorum";
            this.tbPetSorum.Size = new System.Drawing.Size(193, 22);
            this.tbPetSorum.TabIndex = 2;
            // 
            // tbPetAd
            // 
            this.tbPetAd.Location = new System.Drawing.Point(113, 15);
            this.tbPetAd.Name = "tbPetAd";
            this.tbPetAd.Size = new System.Drawing.Size(193, 22);
            this.tbPetAd.TabIndex = 0;
            // 
            // lblPetTel
            // 
            this.lblPetTel.AutoSize = true;
            this.lblPetTel.Location = new System.Drawing.Point(334, 18);
            this.lblPetTel.Name = "lblPetTel";
            this.lblPetTel.Size = new System.Drawing.Size(27, 14);
            this.lblPetTel.TabIndex = 6;
            this.lblPetTel.Text = "Tel";
            // 
            // lblPetSorum
            // 
            this.lblPetSorum.AutoSize = true;
            this.lblPetSorum.Location = new System.Drawing.Point(12, 50);
            this.lblPetSorum.Name = "lblPetSorum";
            this.lblPetSorum.Size = new System.Drawing.Size(64, 14);
            this.lblPetSorum.TabIndex = 7;
            this.lblPetSorum.Text = "Sorumlu";
            // 
            // lblPetAd
            // 
            this.lblPetAd.AutoSize = true;
            this.lblPetAd.Location = new System.Drawing.Point(12, 18);
            this.lblPetAd.Name = "lblPetAd";
            this.lblPetAd.Size = new System.Drawing.Size(24, 14);
            this.lblPetAd.TabIndex = 8;
            this.lblPetAd.Text = "Ad";
            // 
            // tabGrup
            // 
            this.tabGrup.Controls.Add(this.tbGrupAd);
            this.tabGrup.Controls.Add(this.lblGrupAd);
            this.tabGrup.Controls.Add(this.btnGrupArama);
            this.tabGrup.Controls.Add(this.btnGrupKayit);
            this.tabGrup.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabGrup.Location = new System.Drawing.Point(4, 29);
            this.tabGrup.Name = "tabGrup";
            this.tabGrup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrup.Size = new System.Drawing.Size(941, 78);
            this.tabGrup.TabIndex = 5;
            this.tabGrup.Text = "Ürün Grup";
            this.tabGrup.UseVisualStyleBackColor = true;
            // 
            // tbGrupAd
            // 
            this.tbGrupAd.Location = new System.Drawing.Point(113, 15);
            this.tbGrupAd.Name = "tbGrupAd";
            this.tbGrupAd.Size = new System.Drawing.Size(193, 22);
            this.tbGrupAd.TabIndex = 0;
            // 
            // lblGrupAd
            // 
            this.lblGrupAd.AutoSize = true;
            this.lblGrupAd.Location = new System.Drawing.Point(12, 18);
            this.lblGrupAd.Name = "lblGrupAd";
            this.lblGrupAd.Size = new System.Drawing.Size(24, 14);
            this.lblGrupAd.TabIndex = 18;
            this.lblGrupAd.Text = "Ad";
            // 
            // btnGrupArama
            // 
            this.btnGrupArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnGrupArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrupArama.Location = new System.Drawing.Point(757, 10);
            this.btnGrupArama.Name = "btnGrupArama";
            this.btnGrupArama.Size = new System.Drawing.Size(85, 58);
            this.btnGrupArama.TabIndex = 1;
            this.btnGrupArama.Text = "Arama";
            this.btnGrupArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupArama.UseVisualStyleBackColor = true;
            this.btnGrupArama.Click += new System.EventHandler(this.btnGrupArama_Click);
            // 
            // btnGrupKayit
            // 
            this.btnGrupKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnGrupKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrupKayit.Location = new System.Drawing.Point(848, 10);
            this.btnGrupKayit.Name = "btnGrupKayit";
            this.btnGrupKayit.Size = new System.Drawing.Size(85, 58);
            this.btnGrupKayit.TabIndex = 2;
            this.btnGrupKayit.Text = "Kaydet";
            this.btnGrupKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupKayit.UseVisualStyleBackColor = true;
            this.btnGrupKayit.Click += new System.EventHandler(this.btnGrupKayit_Click);
            // 
            // tabUrun
            // 
            this.tabUrun.Controls.Add(this.cmbUrunGrup);
            this.tabUrun.Controls.Add(this.tbUrunAd);
            this.tabUrun.Controls.Add(this.lblUrunGrup);
            this.tabUrun.Controls.Add(this.lblUrunAd);
            this.tabUrun.Controls.Add(this.btnUrunArama);
            this.tabUrun.Controls.Add(this.btnUrunKayit);
            this.tabUrun.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabUrun.Location = new System.Drawing.Point(4, 29);
            this.tabUrun.Name = "tabUrun";
            this.tabUrun.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrun.Size = new System.Drawing.Size(941, 78);
            this.tabUrun.TabIndex = 6;
            this.tabUrun.Text = "Ürün";
            this.tabUrun.UseVisualStyleBackColor = true;
            this.tabUrun.Enter += new System.EventHandler(this.tabUrun_Enter);
            // 
            // cmbUrunGrup
            // 
            this.cmbUrunGrup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUrunGrup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUrunGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrup.FormattingEnabled = true;
            this.cmbUrunGrup.Location = new System.Drawing.Point(180, 47);
            this.cmbUrunGrup.Name = "cmbUrunGrup";
            this.cmbUrunGrup.Size = new System.Drawing.Size(193, 22);
            this.cmbUrunGrup.TabIndex = 1;
            // 
            // tbUrunAd
            // 
            this.tbUrunAd.Location = new System.Drawing.Point(180, 15);
            this.tbUrunAd.Name = "tbUrunAd";
            this.tbUrunAd.Size = new System.Drawing.Size(193, 22);
            this.tbUrunAd.TabIndex = 0;
            // 
            // lblUrunGrup
            // 
            this.lblUrunGrup.AutoSize = true;
            this.lblUrunGrup.Location = new System.Drawing.Point(12, 50);
            this.lblUrunGrup.Name = "lblUrunGrup";
            this.lblUrunGrup.Size = new System.Drawing.Size(85, 14);
            this.lblUrunGrup.TabIndex = 19;
            this.lblUrunGrup.Text = "Ürün Grubu";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(12, 18);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(24, 14);
            this.lblUrunAd.TabIndex = 20;
            this.lblUrunAd.Text = "Ad";
            // 
            // btnUrunArama
            // 
            this.btnUrunArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnUrunArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunArama.Location = new System.Drawing.Point(757, 10);
            this.btnUrunArama.Name = "btnUrunArama";
            this.btnUrunArama.Size = new System.Drawing.Size(85, 58);
            this.btnUrunArama.TabIndex = 2;
            this.btnUrunArama.Text = "Arama";
            this.btnUrunArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunArama.UseVisualStyleBackColor = true;
            this.btnUrunArama.Click += new System.EventHandler(this.btnUrunArama_Click);
            // 
            // btnUrunKayit
            // 
            this.btnUrunKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnUrunKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunKayit.Location = new System.Drawing.Point(848, 10);
            this.btnUrunKayit.Name = "btnUrunKayit";
            this.btnUrunKayit.Size = new System.Drawing.Size(85, 58);
            this.btnUrunKayit.TabIndex = 3;
            this.btnUrunKayit.Text = "Kaydet";
            this.btnUrunKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunKayit.UseVisualStyleBackColor = true;
            this.btnUrunKayit.Click += new System.EventHandler(this.btnUrunKayit_Click);
            // 
            // tabCIKIS
            // 
            this.tabCIKIS.Controls.Add(this.tbCIKISAd);
            this.tabCIKIS.Controls.Add(this.lblCIKISAd);
            this.tabCIKIS.Controls.Add(this.btnCIKISArama);
            this.tabCIKIS.Controls.Add(this.btnCIKISKayit);
            this.tabCIKIS.Location = new System.Drawing.Point(4, 29);
            this.tabCIKIS.Name = "tabCIKIS";
            this.tabCIKIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabCIKIS.Size = new System.Drawing.Size(941, 78);
            this.tabCIKIS.TabIndex = 7;
            this.tabCIKIS.Text = "Çıkış";
            this.tabCIKIS.UseVisualStyleBackColor = true;
            // 
            // tbCIKISAd
            // 
            this.tbCIKISAd.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCIKISAd.Location = new System.Drawing.Point(82, 15);
            this.tbCIKISAd.Name = "tbCIKISAd";
            this.tbCIKISAd.Size = new System.Drawing.Size(193, 22);
            this.tbCIKISAd.TabIndex = 0;
            // 
            // lblCIKISAd
            // 
            this.lblCIKISAd.AutoSize = true;
            this.lblCIKISAd.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCIKISAd.Location = new System.Drawing.Point(17, 18);
            this.lblCIKISAd.Name = "lblCIKISAd";
            this.lblCIKISAd.Size = new System.Drawing.Size(24, 14);
            this.lblCIKISAd.TabIndex = 0;
            this.lblCIKISAd.Text = "Ad";
            // 
            // btnCIKISArama
            // 
            this.btnCIKISArama.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCIKISArama.Image = global::Aselmaslar.Properties.Resources.search_32;
            this.btnCIKISArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCIKISArama.Location = new System.Drawing.Point(757, 10);
            this.btnCIKISArama.Name = "btnCIKISArama";
            this.btnCIKISArama.Size = new System.Drawing.Size(85, 58);
            this.btnCIKISArama.TabIndex = 1;
            this.btnCIKISArama.Text = "Arama";
            this.btnCIKISArama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCIKISArama.UseVisualStyleBackColor = true;
            this.btnCIKISArama.Click += new System.EventHandler(this.btnCIKISArama_Click);
            // 
            // btnCIKISKayit
            // 
            this.btnCIKISKayit.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCIKISKayit.Image = global::Aselmaslar.Properties.Resources.save_32;
            this.btnCIKISKayit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCIKISKayit.Location = new System.Drawing.Point(848, 10);
            this.btnCIKISKayit.Name = "btnCIKISKayit";
            this.btnCIKISKayit.Size = new System.Drawing.Size(85, 58);
            this.btnCIKISKayit.TabIndex = 2;
            this.btnCIKISKayit.Text = "Kaydet";
            this.btnCIKISKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCIKISKayit.UseVisualStyleBackColor = true;
            this.btnCIKISKayit.Click += new System.EventHandler(this.btnCIKISKayit_Click);
            // 
            // dgvVeriler
            // 
            this.dgvVeriler.AllowUserToAddRows = false;
            this.dgvVeriler.AllowUserToDeleteRows = false;
            this.dgvVeriler.AllowUserToResizeColumns = false;
            this.dgvVeriler.AllowUserToResizeRows = false;
            this.dgvVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeriler.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVeriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVeriler.EnableHeadersVisualStyles = false;
            this.dgvVeriler.Location = new System.Drawing.Point(0, 111);
            this.dgvVeriler.MultiSelect = false;
            this.dgvVeriler.Name = "dgvVeriler";
            this.dgvVeriler.RowHeadersVisible = false;
            this.dgvVeriler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeriler.Size = new System.Drawing.Size(949, 295);
            this.dgvVeriler.TabIndex = 1;
            this.dgvVeriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeriler_CellDoubleClick);
            this.dgvVeriler.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvVeriler_DataBindingComplete);
            // 
            // statusStripVeri
            // 
            this.statusStripVeri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStripVeri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDurum,
            this.tssBtnExcel});
            this.statusStripVeri.Location = new System.Drawing.Point(0, 406);
            this.statusStripVeri.Name = "statusStripVeri";
            this.statusStripVeri.Size = new System.Drawing.Size(949, 28);
            this.statusStripVeri.TabIndex = 2;
            this.statusStripVeri.Text = "statusStripVeri";
            // 
            // tssLblDurum
            // 
            this.tssLblDurum.Name = "tssLblDurum";
            this.tssLblDurum.Size = new System.Drawing.Size(39, 23);
            this.tssLblDurum.Text = "  --- ";
            // 
            // tssBtnExcel
            // 
            this.tssBtnExcel.DropDownButtonWidth = 0;
            this.tssBtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("tssBtnExcel.Image")));
            this.tssBtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssBtnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.tssBtnExcel.Name = "tssBtnExcel";
            this.tssBtnExcel.Size = new System.Drawing.Size(120, 24);
            this.tssBtnExcel.Text = "Excel\'e Aktar";
            this.tssBtnExcel.ButtonClick += new System.EventHandler(this.tssBtnExcel_ButtonClick);
            // 
            // sfdExcel
            // 
            this.sfdExcel.Filter = "Excel Dosyası | *.xlsx";
            this.sfdExcel.InitialDirectory = "C:\\\\Users\\\\%USERPROFILE%\\\\Desktop";
            this.sfdExcel.Title = "Lütfen Kayıt Yerini Seçiniz";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmVeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 434);
            this.Controls.Add(this.dgvVeriler);
            this.Controls.Add(this.statusStripVeri);
            this.Controls.Add(this.tabcVeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmVeri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veri Tanımlama - Aselmaslar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVeri_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmVeri_SizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmVeri_KeyUp);
            this.tabcVeri.ResumeLayout(false);
            this.tabAlici.ResumeLayout(false);
            this.tabAlici.PerformLayout();
            this.tabTasyc.ResumeLayout(false);
            this.tabTasyc.PerformLayout();
            this.tabPlaka.ResumeLayout(false);
            this.tabPlaka.PerformLayout();
            this.tabGondYer.ResumeLayout(false);
            this.tabGondYer.PerformLayout();
            this.tabPetrol.ResumeLayout(false);
            this.tabPetrol.PerformLayout();
            this.tabGrup.ResumeLayout(false);
            this.tabGrup.PerformLayout();
            this.tabUrun.ResumeLayout(false);
            this.tabUrun.PerformLayout();
            this.tabCIKIS.ResumeLayout(false);
            this.tabCIKIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).EndInit();
            this.statusStripVeri.ResumeLayout(false);
            this.statusStripVeri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcVeri;
        private System.Windows.Forms.TabPage tabAlici;
        private System.Windows.Forms.TabPage tabTasyc;
        private System.Windows.Forms.DataGridView dgvVeriler;
        private System.Windows.Forms.TabPage tabPlaka;
        private System.Windows.Forms.TabPage tabGondYer;
        private System.Windows.Forms.TabPage tabPetrol;
        private System.Windows.Forms.TabPage tabGrup;
        private System.Windows.Forms.TabPage tabUrun;
        private System.Windows.Forms.TextBox tbAlTel;
        private System.Windows.Forms.TextBox tbAlSorumlu;
        private System.Windows.Forms.TextBox tbAlAd;
        private System.Windows.Forms.Label lblAlTel;
        private System.Windows.Forms.Label lblAlSorumlu;
        private System.Windows.Forms.Label lblAlAd;
        private System.Windows.Forms.Button btnAlArama;
        private System.Windows.Forms.Button btnAlKayit;
        private System.Windows.Forms.TextBox tbTasAd;
        private System.Windows.Forms.Label lblTasAd;
        private System.Windows.Forms.Button btnTasArama;
        private System.Windows.Forms.Button btnTasKayit;
        private System.Windows.Forms.ComboBox cbPlTasFrm;
        private System.Windows.Forms.TextBox tbPlAd;
        private System.Windows.Forms.Label lblPlTasFrm;
        private System.Windows.Forms.Label lblPlAd;
        private System.Windows.Forms.Button btnPlArama;
        private System.Windows.Forms.Button btnPlKayit;
        private System.Windows.Forms.TextBox tbGonAd;
        private System.Windows.Forms.Label lblGonAd;
        private System.Windows.Forms.Button btnGonArama;
        private System.Windows.Forms.Button btnGonKayit;
        private System.Windows.Forms.Button btnPetArama;
        private System.Windows.Forms.Button btnPetKayit;
        private System.Windows.Forms.TextBox tbPetTel;
        private System.Windows.Forms.TextBox tbPetSorum;
        private System.Windows.Forms.TextBox tbPetAd;
        private System.Windows.Forms.Label lblPetTel;
        private System.Windows.Forms.Label lblPetSorum;
        private System.Windows.Forms.Label lblPetAd;
        private System.Windows.Forms.TextBox tbGrupAd;
        private System.Windows.Forms.Label lblGrupAd;
        private System.Windows.Forms.Button btnGrupArama;
        private System.Windows.Forms.Button btnGrupKayit;
        private System.Windows.Forms.ComboBox cmbUrunGrup;
        private System.Windows.Forms.TextBox tbUrunAd;
        private System.Windows.Forms.Label lblUrunGrup;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Button btnUrunArama;
        private System.Windows.Forms.Button btnUrunKayit;
        private System.Windows.Forms.StatusStrip statusStripVeri;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
        private System.Windows.Forms.ToolStripSplitButton tssBtnExcel;
        private System.Windows.Forms.ToolStripStatusLabel tssLblDurum;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabPage tabCIKIS;
        private System.Windows.Forms.TextBox tbCIKISAd;
        private System.Windows.Forms.Label lblCIKISAd;
        private System.Windows.Forms.Button btnCIKISArama;
        private System.Windows.Forms.Button btnCIKISKayit;
    }
}