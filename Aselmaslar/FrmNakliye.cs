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
    public partial class FrmNakliye : Form
    {
        public FrmNakliye()
        {
            InitializeComponent();
        }
        
        public string AnaSql = "SELECT NAKLIYE.ID,SUBSTR(TARIH,9,2)||'-'||SUBSTR(TARIH,6,2)||'-'||SUBSTR(TARIH,1,4) 'TARIH',NAKLIYE.FISNO,NAKLIYE.IRSALIYENO,CIKIS.AD,ALICIFIRMA.AD,GONDRLNYER.AD,URUN.AD,GRUP.AD,PLAKA.AD,TASIYICIFIRMA.AD,NAKLIYE.TONAJ,NAKLIYE.ACIKLAMA FROM NAKLIYE INNER JOIN ALICIFIRMA,TASIYICIFIRMA,PLAKA,GONDRLNYER,GRUP,URUN,CIKIS ON ALICIFIRMA.ID = NAKLIYE.ALICIFRM_ID AND  TASIYICIFIRMA.ID = NAKLIYE.TASYCFRM_ID AND PLAKA.ID = NAKLIYE.PLAKA_ID AND GONDRLNYER.ID = NAKLIYE.GONDRLNYER_ID AND GRUP.ID = NAKLIYE.GRUP_ID AND URUN.ID = NAKLIYE.URUN_ID AND CIKIS.ID = NAKLIYE.CIKIS_ID";

        public string AramaSql = String.Empty;
        private void Arama()
        {
            using (new WaitCursor())
            {
                string TARIH1 = dtpTarih1.MinDate.ToString("yyy-MM-dd");
                string TARIH2 = DateTime.Today.ToString("yyy-MM-dd");
                string ALICIFRM_ID = "LIKE '%%'";
                string TASYCFRM_ID = "LIKE '%%'";
                string GRUP_ID = "LIKE '%%'";
                string URUN_ID = "LIKE '%%'";
                string GONDRLNYER_ID = "LIKE '%%'";
                string PLAKA_ID = "LIKE '%%'";
                string CIKIS_ID = "LIKE '%%'";

                if (cmbAlici.SelectedIndex == -1 || cmbAlici.SelectedIndex == 0) 
                { ALICIFRM_ID = "LIKE '%%'"; }
                else
                {ALICIFRM_ID = cmbAlici.SelectedValue.ToString(); ALICIFRM_ID = "= '" + ALICIFRM_ID + "'";}

                if (cmbTasFrm.SelectedIndex == -1 || cmbTasFrm.SelectedIndex == 0)
                { TASYCFRM_ID = "LIKE '%%'"; }
                else
                { TASYCFRM_ID = cmbTasFrm.SelectedValue.ToString(); TASYCFRM_ID = "= '" + TASYCFRM_ID + "'"; }

                if (cmbGrup.SelectedIndex == -1 || cmbGrup.SelectedIndex == 0)
                { GRUP_ID = "LIKE '%%'"; }
                else
                { GRUP_ID = cmbGrup.SelectedValue.ToString(); GRUP_ID = "= '" + GRUP_ID + "'"; }

                if (cmbUrun.SelectedIndex == -1 || cmbUrun.SelectedIndex == 0)
                { URUN_ID = "LIKE '%%'"; }
                else
                { URUN_ID = cmbUrun.SelectedValue.ToString(); URUN_ID = "= '" + URUN_ID + "'"; }

                if (cmbGondrlnYer.SelectedIndex == -1 || cmbGondrlnYer.SelectedIndex == 0)
                { GONDRLNYER_ID = "LIKE '%%'"; }
                else
                { GONDRLNYER_ID = cmbGondrlnYer.SelectedValue.ToString(); GONDRLNYER_ID = "= '" + GONDRLNYER_ID + "'"; }

                if (cmbPlaka.SelectedIndex == -1 || cmbPlaka.SelectedIndex == 0)
                { PLAKA_ID = "LIKE '%%'"; }
                else
                { PLAKA_ID = cmbPlaka.SelectedValue.ToString(); PLAKA_ID = "= '" + PLAKA_ID + "'"; }

                if (cmbCIKIS.SelectedIndex == -1 || cmbCIKIS.SelectedIndex == 0)
                { CIKIS_ID = "LIKE '%%'"; }
                else
                { CIKIS_ID = cmbCIKIS.SelectedValue.ToString(); CIKIS_ID = "= '" + CIKIS_ID + "'"; }

                if (dtpTarih1.Checked)
                {
                    TARIH1 = dtpTarih1.Value.ToString("yyyy-MM-dd");
                    if (dtpTarih2.Checked)
                    {
                        TARIH2 = dtpTarih2.Value.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        TARIH2 = DateTime.Today.ToString("yyy-MM-dd");
                    }
                }
                else
                {
                    TARIH1 = dtpTarih1.MinDate.ToString("yyy-MM-dd");
                    if (dtpTarih2.Checked)
                    {
                        TARIH2 = dtpTarih2.Value.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        TARIH2 = DateTime.Today.ToString("yyy-MM-dd");
                    }
                }

                AramaSql = AnaSql + " WHERE NAKLIYE.TARIH BETWEEN '" + TARIH1 + "' AND '" + TARIH2 + "' AND NAKLIYE.FISNO LIKE '%" + tbFis.Text + "%' AND NAKLIYE.TONAJ LIKE '%" + tbTonaj.Text + "%' AND NAKLIYE.IRSALIYENO LIKE '%" + tbIrsaliye.Text + "%' AND NAKLIYE.ACIKLAMA LIKE '%" + tbAciklama.Text + "%' AND NAKLIYE.ALICIFRM_ID " + ALICIFRM_ID + "  AND NAKLIYE.TASYCFRM_ID " + TASYCFRM_ID + " AND NAKLIYE.GRUP_ID " + GRUP_ID + " AND NAKLIYE.URUN_ID " + URUN_ID + " AND NAKLIYE.GONDRLNYER_ID " + GONDRLNYER_ID + " AND NAKLIYE.PLAKA_ID " + PLAKA_ID + " AND NAKLIYE.CIKIS_ID " + CIKIS_ID + "";

                tur = "Arama";
                tssLblDurum.Text = " Arama Kriterlerine Uygun Veriler Aktarılıyor...";
                AktifSayfa = 0;
                Sayfala();
            }
        }

        #region Temizle

        public void Temizle()
        {
            using (new WaitCursor())
            {
                if (tur != "Kayit")
                {
                    dtpTarih1.Value = DateTime.Today;
                    dtpTarih2.Value = DateTime.Today;
                }
                dtpTarih2.Enabled = true;
                tbFis.Text = String.Empty;
                tbTonaj.Text = String.Empty;
                tbIrsaliye.Text = String.Empty;
                tbAciklama.Text = String.Empty;
                cmbAlici.SelectedIndex = -1;
                cmbTasFrm.SelectedIndex = -1;
                cmbGrup.SelectedIndex = -1;
                cmbUrun.SelectedIndex = -1;
                cmbGondrlnYer.SelectedIndex = -1;
                cmbPlaka.SelectedIndex = -1;
                errorProvider.Clear();
                dtpTarih1.Focus();
                btnArama.Image = Properties.Resources.search_32;
                btnArama.Text = "Arama";
                btnKaydet.Image = Properties.Resources.save_32;
                btnKaydet.Text = "Kaydet";
                Secilen_id = 0;
                tsBtnFirst.Enabled = false;
                tsBtnNext.Enabled = false;
                tsBtnPrev.Enabled = false;
                tsBtnLast.Enabled = false;
                dgvNakliye.DataSource = null;
            }
        }
        #endregion

        #region Sil

        private void Sil()
        {
            using (new WaitCursor())
            {
                if (MessageBox.Show(Islemler.NAKLIYEIslem.IdyeGoreNAKLIYEGetir(Secilen_id).FISNO + " fiş no lu işlem SİLİNECEK!!! \n Onaylıyor musunuz?", "Nakliye İşlemleri Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Islemler.NAKLIYEIslem.Sil(Secilen_id);
                    Temizle();
                    AktifSayfa = 0;
                    Sayfala();
                }
            }
        }

        #endregion

        #region Buton işlemleri

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FrmNakliyeKayit fr = new FrmNakliyeKayit(this); fr.ShowDialog();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Arama(); } else { Sil(); }
        }
        #endregion

        public static int Secilen_id = 0;
        private void dgvNakliye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Secilen_id = Convert.ToInt32(dgvNakliye.Rows[e.RowIndex].Cells[0].Value);

                btnArama.Image = Properties.Resources.delete_32;
                btnArama.Text = "Sil";
                btnKaydet.Image = Properties.Resources.pencil_32;
                btnKaydet.Text = "Düzenle";
            }
        }

        private void dgvNakliye_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvNakliye.Rows.Count != 0)
            {
                dgvNakliye.Columns["ID"].Visible = false;
                dgvNakliye.Columns[2].HeaderText = "FİŞ NO";
                dgvNakliye.Columns[3].HeaderText = "İRSALİYE NO";
                dgvNakliye.Columns[4].HeaderText = "ÇIKIŞ YERİ";
                dgvNakliye.Columns[5].HeaderText = "ALICI FIRMA";
                dgvNakliye.Columns[6].HeaderText = "TESLIM YERİ";
                dgvNakliye.Columns[7].HeaderText = "URUN";
                dgvNakliye.Columns[8].HeaderText = "GRUP";
                dgvNakliye.Columns[9].HeaderText = "PLAKA";
                dgvNakliye.Columns[10].HeaderText = "TAŞIYICI FIRMA";
                dgvNakliye.Columns[11].HeaderText = "TONAJ";
                dgvNakliye.Columns[12].HeaderText = "AÇIKLAMA";

            }

            if (tur == "Kayit")
            {
                tsBtnFirst.Enabled = false;
                tsBtnNext.Enabled = false;
                tsBtnPrev.Enabled = false;
                tsBtnLast.Enabled = false;
            }
        }

        #region Excel'e Aktar

        DataGridView dgvData;
        private void tssBtnExcel_ButtonClick(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                using (new WaitCursor())
                {
                    tssLblDurum.Text = " Veriler Excel'e Aktarılıyor...";
                    dgvData = dgvNakliye;
                    switch (tur)
                    {
                        case "Arama": dgvData.DataSource = Islemler.NAKLIYEIslem.VeriKumesi(AramaSql); break;
                        default: dgvData.DataSource = Islemler.NAKLIYEIslem.VeriKumesi(AnaSql); break;
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
                    tssLblDurum.Text = " Toplam Veri Miktarı : " + ToplamKayit.ToString() + "   -   Toplam Tonaj Miktarı : " + ToplamTonaj.ToString();
                }
            }
        }

        #endregion

        private void tstbMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceNoGir(e);
        }

        private void tsBtnTumu_Click(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                tur = "Tumu";
                tssLblDurum.Text = " Tüm Kayıtlar Tabloya Aktarılıyor...";
                AktifSayfa = 0;
                Sayfala();
            }
        }

        private void FrmNakliye_SizeChanged(object sender, EventArgs e)
        {
            btnKaydet.Location = new Point(pnlKonsol.Width - 155, 12);
            btnArama.Location = new Point(pnlKonsol.Width - 155, 69);
        }

        private void FrmNakliye_Load(object sender, EventArgs e)
        {            
            using (new WaitCursor())
            {
                tssLblDurum.Text = " Alıcı Firma Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From ALICIFIRMA order by AD", cmbAlici, "AD", "ID");
                cmbAlici.SelectedIndex = -1;
                tssLblDurum.Text = " Taşıyıcı Firma Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From TASIYICIFIRMA order by AD", cmbTasFrm, "AD", "ID");
                cmbTasFrm.SelectedIndex = -1;
                tssLblDurum.Text = " Ürün Grup Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From GRUP order by AD", cmbGrup, "AD", "ID");
                cmbGrup.SelectedIndex = -1;
                tssLblDurum.Text = " Ürün Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From URUN order by AD", cmbUrun, "AD", "ID");
                cmbUrun.SelectedIndex = -1;
                tssLblDurum.Text = " Teslim Yeri Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From GONDRLNYER order by AD", cmbGondrlnYer, "AD", "ID");
                cmbGondrlnYer.SelectedIndex = -1;
                tssLblDurum.Text = " Plaka Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From PLAKA order by AD", cmbPlaka, "AD", "ID");
                cmbPlaka.SelectedIndex = -1;
                tssLblDurum.Text = " ÇIKIŞ Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From CIKIS order by AD", cmbCIKIS, "AD", "ID");
                cmbCIKIS.SelectedIndex = -1;
                tssLblDurum.Text = " İşlemler Başarılı Şekilde Gerçekleştirildi...";
            }
        }

        public string tur = String.Empty;
        public int AktifSayfa = 0;
        public int Kayit_Say;
        string SqlSayfala = String.Empty;
        int SayfaMiktar = 20;
        int ToplamSayfa = 0;
        int ToplamKayit = 0;
        int Offset = 0;
        string ToplamTonaj = String.Empty;
        public void Sayfala()
        {
            using (new WaitCursor())
            {
                tsBtnFirst.Enabled = true;
                tsBtnNext.Enabled = true;
                tsBtnPrev.Enabled = true;
                tsBtnLast.Enabled = true;

                //Toplam Kayıt Hesaplanıyor
                switch (tur)
                {
                    case "Arama": ToplamKayit = Convert.ToInt32(Islemler.NAKLIYEIslem.VeriKumesi(AramaSql.Insert(7, "COUNT(*),")).Rows[0]["COUNT(*)"]); break;
                    case "Kayit": ToplamKayit = Kayit_Say; break;
                    case "Duzenle": ToplamKayit = Convert.ToInt32(Islemler.NAKLIYEIslem.VeriKumesi(AramaSql.Insert(7, "COUNT(*),")).Rows[0]["COUNT(*)"]); break;
                    default: ToplamKayit = Convert.ToInt32(Islemler.NAKLIYEIslem.VeriKumesi(AnaSql.Insert(7, "COUNT(*),")).Rows[0]["COUNT(*)"]); break;
                }

                //Toplam Sayfa Hesaplanıyor
                if (!String.IsNullOrEmpty(tstbMiktar.Text)) { SayfaMiktar = Convert.ToInt32(tstbMiktar.Text); }
                ToplamSayfa = ToplamKayit / SayfaMiktar;
                if ((ToplamKayit % SayfaMiktar) > 0) { ToplamSayfa++; }

                //Geçiş Miktarı Hesaplanıyor
                Offset = AktifSayfa * SayfaMiktar;

                SqlSayfala = String.Empty;
                switch (tur)
                {
                    case "Arama": SqlSayfala = AramaSql + " ORDER BY NAKLIYE.ID DESC LIMIT " + SayfaMiktar.ToString() + " OFFSET " + Offset.ToString(); break;
                    case "Duzenle": SqlSayfala = AramaSql + " ORDER BY NAKLIYE.ID DESC LIMIT " + SayfaMiktar.ToString() + " OFFSET " + Offset.ToString(); break;
                    case "Kayit": SqlSayfala = AnaSql + " ORDER BY NAKLIYE.ID DESC LIMIT " + Kayit_Say.ToString(); ToplamSayfa = 1; break;
                    default: SqlSayfala = AnaSql + " ORDER BY NAKLIYE.ID DESC LIMIT " + SayfaMiktar.ToString() + " OFFSET " + Offset.ToString(); break;
                }

                Tools.gwDoldur(SqlSayfala, dgvNakliye);

                ToplamTonaj = String.Empty;

                switch (tur)
                {
                    case "Arama": ToplamTonaj = Islemler.NAKLIYEIslem.VeriKumesi(AramaSql.Insert(7, "TOTAL(TONAJ),")).Rows[0]["TOTAL(TONAJ)"].ToString(); break;
                    case "Kayit": ToplamTonaj = _ToplamTonaj(); break;
                    case "Duzenle": ToplamTonaj = _ToplamTonaj(); break;
                    default: ToplamTonaj = Islemler.NAKLIYEIslem.VeriKumesi(AnaSql.Insert(7, "TOTAL(TONAJ),")).Rows[0]["TOTAL(TONAJ)"].ToString(); break;
                }

                tssLblDurum.Text = " Toplam Veri Miktarı : " + ToplamKayit.ToString() + "   -   Toplam Tonaj Miktarı : " + ToplamTonaj.ToString();
                tsLblSayfa.Text = (AktifSayfa + 1).ToString() + "/" + ToplamSayfa.ToString();
            }
        }
        
        private string _ToplamTonaj()
        {
            using (new WaitCursor())
            {
                double sonuc = 0.0;
                try
                {
                    for (int i = 0; i < dgvNakliye.Rows.Count; i++)
                    {
                        sonuc += Double.Parse(dgvNakliye.Rows[i].Cells["TONAJ"].Value.ToString().Replace(".", ","));
                    }
                }
                catch (Exception)
                {
                    sonuc = 0.0;
                }

                return sonuc.ToString();
            }
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

        private void FrmNakliye_FormClosed(object sender, FormClosedEventArgs e)
        {
            Temizle();
            this.Owner.Show();
        }

        private void cmbPlaka_Leave(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                if (cmbPlaka.SelectedIndex != -1 && cmbPlaka.SelectedIndex != 0)
                {
                    cmbTasFrm.SelectedValue = Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Convert.ToInt32(cmbPlaka.SelectedValue)).TASYCFRM_ID;
                }
            }
        }

        private void cmbUrun_Leave(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                if (cmbUrun.SelectedIndex != -1 && cmbUrun.SelectedIndex != 0)
                {
                    cmbGrup.SelectedValue = Islemler.URUNIslem.IdyeGoreURUNGetir(Convert.ToInt32(cmbUrun.SelectedValue)).GRUP_ID;
                }
            }
        }      

    }
}
