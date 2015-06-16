using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aselmaslar
{
    public partial class FrmPetrol : Form
    {
        public FrmPetrol()
        {
            InitializeComponent();
        }

        string AnaSql = "Select PETROLISLEMLERI.ID,PETROLISLEMLERI.TARIH,PETROLISLEMLERI.FIS_NO,PETROLISLEMLERI.TUTAR,PETROL.AD,PLAKA.AD,TASIYICIFIRMA.AD,CIKIS.AD,PETROLISLEMLERI.ACIKLAMA FROM PETROLISLEMLERI INNER JOIN PETROL,PLAKA,TASIYICIFIRMA,CIKIS ON PETROL.ID = PETROLISLEMLERI.PETROL_ID AND PLAKA.ID = PETROLISLEMLERI.PLAKA_ID AND TASIYICIFIRMA.ID = PETROLISLEMLERI.TASYCFRM_ID AND CIKIS.ID = PETROLISLEMLERI.CIKIS_ID";
        
        string AramaSql = String.Empty;
        private void Arama()
        {
            string PETROL_ID = String.Empty;
            string PLAKA_ID = String.Empty;
            string TASYCFRM_ID = String.Empty;
            string CIKIS_ID = String.Empty;
            if (cmbPetrol.SelectedIndex != -1) { PETROL_ID = cmbPetrol.SelectedValue.ToString(); }
            if (cmbPlaka.SelectedIndex != -1) { PLAKA_ID = cmbPlaka.SelectedValue.ToString(); }
            if (cmbTasFrm.SelectedIndex != -1) { TASYCFRM_ID = cmbTasFrm.SelectedValue.ToString(); }
            if (cmbCIKIS.SelectedIndex != -1) { CIKIS_ID = cmbCIKIS.SelectedValue.ToString(); }

            AramaSql = AnaSql + " WHERE PETROLISLEMLERI.TARIH BETWEEN '" + dtpTarih1.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpTarih2.Value.ToString("yyyy-MM-dd") + "' AND PETROLISLEMLERI.FIS_NO LIKE '%" + tbFis.Text + "%' AND PETROLISLEMLERI.TUTAR LIKE '%" + tbTutar.Text + "%' AND PETROLISLEMLERI.PETROL_ID LIKE '%" + PETROL_ID + "%' AND PETROLISLEMLERI.PLAKA_ID LIKE '%" + PLAKA_ID + "%' AND PETROLISLEMLERI.TASYCFRM_ID LIKE '%" + TASYCFRM_ID + "%' AND PETROLISLEMLERI.ACIKLAMA LIKE '%" + tbAciklama.Text + "%' AND PETROLISLEMLERI.CIKIS_ID LIKE '%" + CIKIS_ID + "%' ORDER BY PETROLISLEMLERI.ID DESC";
            
            tur = "Arama";
            tssLblDurum.Text = " Arama Kriterlerine Uygun Veriler Aktarılıyor...";
            AktifSayfa = 0;
            Sayfala();
        }

        public void Temizle()
        {
            dtpTarih1.Value = DateTime.Today;
            dtpTarih2.Enabled = true;
            dtpTarih2.Value = DateTime.Today;
            tbFis.Text = String.Empty;
            tbTutar.Text = String.Empty;
            cmbPetrol.SelectedIndex = -1;
            cmbPlaka.SelectedIndex = -1;
            cmbTasFrm.SelectedIndex = -1;
            cmbCIKIS.SelectedIndex = -1;
            errorProvider.Clear();
            tbFis.Focus();
            btnArama.Image = Properties.Resources.search_32;
            btnArama.Text = "Arama";
            btnKaydet.Image = Properties.Resources.save_32;
            btnKaydet.Text = "Kaydet";
            Secilen_id = 0;
            tsBtnFirst.Enabled = false;
            tsBtnNext.Enabled = false;
            tsBtnPrev.Enabled = false;
            tsBtnLast.Enabled = false;
            dgvPetrol.DataSource = null;
        }

        private void Sil()
        {
            if (MessageBox.Show(Islemler.PETROLISLEMLERIIslem.IdyeGorePETROLISLEMLERIGetir(Secilen_id).FIS_NO + " fiş no lu işlem SİLİNECEK!!! \n Onaylıyor musunuz?", "Petrol İşlemleri Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Islemler.PETROLISLEMLERIIslem.Sil(Secilen_id);
                Temizle();
                AktifSayfa = 0;
                Sayfala();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FrmPetrolKayit fr = new FrmPetrolKayit(this); fr.ShowDialog();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Arama(); } else { Sil(); }
        }

        public static int Secilen_id = 0;
        private void dgvPetrol_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Secilen_id = Convert.ToInt32(dgvPetrol.Rows[e.RowIndex].Cells[0].Value);

            btnArama.Image = Properties.Resources.delete_32;
            btnArama.Text = "Sil";
            btnKaydet.Image = Properties.Resources.pencil_32;
            btnKaydet.Text = "Düzenle";
        }

        private void dgvPetrol_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvPetrol.Rows.Count != 0)
            {
                dgvPetrol.Columns["ID"].Visible = false;
                dgvPetrol.Columns[2].HeaderText = "Fiş No";
                dgvPetrol.Columns[4].HeaderText = "PETROL";
                dgvPetrol.Columns[5].HeaderText = "PLAKA";
                dgvPetrol.Columns[6].HeaderText = "Taşıyıcı Firma";
                dgvPetrol.Columns[7].HeaderText = "ÇIKIŞ YERİ";
            }
        }

        DataGridView dgvData;
        private void tssBtnExcel_ButtonClick(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                tssLblDurum.Text = " Veriler Excel'e Aktarılıyor...";
                dgvData = dgvPetrol;
                switch (tur)
                {
                    case "Arama": dgvData.DataSource = Islemler.PETROLISLEMLERIIslem.VeriKumesi(AramaSql); break;
                    default: dgvData.DataSource = Islemler.PETROLISLEMLERIIslem.VeriKumesi(AnaSql); break;
                }
                if (dgvData != null && dgvData.Rows.Count != 0) 
                {
                    Tools.ExportToExcel(dgvData, sfdExcel.FileName);
                    if (MessageBox.Show("Excel Dosyası " + sfdExcel.FileName.ToString() + " konumuna kaydedilmiştir. \n Dosyayı Açmak İstiyor musunuz?", "Excel'e Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start(sfdExcel.FileName.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Boş Veri Hatası!!!", "Excel'e Aktar");
                }
                tssLblDurum.Text = " " + ToplamKayit.ToString() + " veri listelenmiştir.";
            }
        }

        private void tstbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceNoGir(e);
        }
        
        private void tsBtnTumu_Click(object sender, EventArgs e)
        {
            tur = "Tumu";
            tssLblDurum.Text = " Tüm Kayıtlar Tabloya Aktarılıyor..."; 
            AktifSayfa = 0;
            Sayfala();
        }

        private void FrmPetrol_SizeChanged(object sender, EventArgs e)
        {
            btnKaydet.Location = new Point(pnlKonsol.Width - 87, 17);
            btnArama.Location = new Point(pnlKonsol.Width - 168, 17);
        }

        private void FrmPetrol_Load(object sender, EventArgs e)
        {
            tssLblDurum.Text = " Petrol Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From PETROL order by AD", cmbPetrol, "AD", "ID");
            cmbPetrol.SelectedIndex = -1;
            tssLblDurum.Text = " Plaka Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From PLAKA order by AD", cmbPlaka, "AD", "ID");
            cmbPlaka.SelectedIndex = -1;
            tssLblDurum.Text = " Taşıyıcı Firma Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From TASIYICIFIRMA order by AD", cmbTasFrm, "AD", "ID");
            cmbTasFrm.SelectedIndex = -1;
            tssLblDurum.Text = " ÇIKIŞ Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From CIKIS order by AD", cmbCIKIS, "AD", "ID");
            cmbCIKIS.SelectedIndex = -1;
            tssLblDurum.Text = " İşlemler Başarılı Şekilde Gerçekleştirildi...";
        }

        string SqlSayfala = String.Empty;
        int AktifSayfa = 0;
        int SayfaMiktar = 25;
        int ToplamSayfa = 0;
        int ToplamKayit = 0;
        public void Sayfala()
        {
            tsBtnFirst.Enabled = true;
            tsBtnNext.Enabled = true;
            tsBtnPrev.Enabled = true;
            tsBtnLast.Enabled = true;

            //Toplam Kayıt Hesaplanıyor
            switch (tur)
            {
                case "Arama": ToplamKayit = Convert.ToInt32(Islemler.NAKLIYEIslem.VeriKumesi(AramaSql.Insert(7, "COUNT(*),")).Rows[0]["COUNT(*)"]); break;
                default: ToplamKayit = Convert.ToInt32(Islemler.NAKLIYEIslem.VeriKumesi(AnaSql.Insert(7, "COUNT(*),")).Rows[0]["COUNT(*)"]); break;
            }

            //Toplam Sayfa Hesaplanıyor
            if (!String.IsNullOrEmpty(tstbMiktar.Text)) { SayfaMiktar = Convert.ToInt32(tstbMiktar.Text); }
            ToplamSayfa = ToplamKayit / SayfaMiktar;
            if ((ToplamKayit % SayfaMiktar) > 0) { ToplamSayfa++; }

            //Geçiş Miktarı Hesaplanıyor
            int Offset = AktifSayfa * SayfaMiktar;

            switch (tur)
            {
                case "Arama": SqlSayfala = AramaSql + " LIMIT " + SayfaMiktar.ToString() + " OFFSET " + Offset.ToString(); break;
                default: SqlSayfala = AnaSql + " ORDER BY PETROLISLEMLERI.ID DESC LIMIT " + SayfaMiktar.ToString() + " OFFSET " + Offset.ToString(); break;
            }

            Tools.gwDoldur(SqlSayfala, dgvPetrol);

            string ToplamTutar = String.Empty;

            switch (tur)
            {
                case "Arama": ToplamTutar = Islemler.PETROLISLEMLERIIslem.VeriKumesi(AramaSql.Insert(7, "TOTAL(TUTAR),")).Rows[0]["TOTAL(TUTAR)"].ToString(); break;
                default: ToplamTutar = Islemler.PETROLISLEMLERIIslem.VeriKumesi(AnaSql.Insert(7, "TOTAL(TUTAR),")).Rows[0]["TOTAL(TUTAR)"].ToString(); break;
            }

            tssLblDurum.Text = " Toplam Veri Miktarı : " + ToplamKayit.ToString() + "   -   Toplam Tutar Miktarı : " + ToplamTutar.ToString();
            tsLblSayfa.Text = (AktifSayfa + 1).ToString() + "/" + ToplamSayfa.ToString();
        }

        string tur = String.Empty;
        private void AnaIslemler()
        {
            btnKaydet.Enabled = false;
            btnArama.Enabled = false;

            switch (tur)
            {
                case "Tumu": tssLblDurum.Text = "Tüm Kayıtlar Tabloya Aktarılıyor..."; AktifSayfa = 0; Sayfala(); break;
                case "Kayit": tssLblDurum.Text = " Güncel Kayıtlar Tabloya Aktarılıyor..."; AktifSayfa = 0; Sayfala(); break;
                case "Arama": tssLblDurum.Text = " Arama Kriterlerine Uygun Kayıtlar Tabloya Aktarılıyor..."; AktifSayfa = 0; Sayfala(); break;
            }
            btnKaydet.Enabled = true;
            btnArama.Enabled = true;
        }
        
        #region Sayfalama Butonları

        private void tsBtnFirst_Click(object sender, EventArgs e)
        {
            AktifSayfa = 0; Sayfala();
        }

        private void tsBtnPrev_Click(object sender, EventArgs e)
        {
            if (AktifSayfa == ToplamSayfa) { AktifSayfa = ToplamSayfa - 1; }
            AktifSayfa--;
            if (AktifSayfa < 1) { AktifSayfa = 0; }
            Sayfala();
        }

        private void tsBtnNext_Click(object sender, EventArgs e)
        {
            AktifSayfa++;
            if (AktifSayfa > (ToplamSayfa - 1)) { AktifSayfa = ToplamSayfa - 1; }
            Sayfala();
        }

        private void tsBtnLast_Click(object sender, EventArgs e)
        {
            AktifSayfa = ToplamSayfa - 1;
            Sayfala();
        }

        #endregion

        private void FrmPetrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
            this.Owner.Show();
        }

        private void cmbPlaka_Leave(object sender, EventArgs e)
        {
            if (cmbPlaka.SelectedIndex != -1 && cmbPlaka.SelectedIndex != 0)
            {
                cmbTasFrm.SelectedValue = Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Convert.ToInt32(cmbPlaka.SelectedValue)).TASYCFRM_ID;
            }
        }
        
    }
}
