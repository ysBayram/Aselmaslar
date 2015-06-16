using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Aselmaslar.Saglayici;

namespace Aselmaslar
{
    public partial class FrmNakliyeKayit : Form
    {
        private FrmNakliye frm;
        public FrmNakliyeKayit(FrmNakliye ParentForm)
        {
            InitializeComponent();
            frm = ParentForm;
        }

        private int Secilen_id = FrmNakliye.Secilen_id;
        private int Kayit_Say;

        private void FrmNakliyeKayit_Load(object sender, EventArgs e)
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
                tssLblDurum.Text = " Çıkış Listeleri Aktarılıyor...";
                Tools.cmbDoldur("Select ID,AD From CIKIS order by AD", cmbCIKIS, "AD", "ID");
                cmbCIKIS.SelectedIndex = -1;
                tssLblDurum.Text = " İşlemler Başarılı Şekilde Gerçekleştirildi...";

                if (Secilen_id != 0)
                {
                    Nesneler.NAKLIYE nak = Islemler.NAKLIYEIslem.IdyeGoreNAKLIYEGetir(Secilen_id);
                    dtpTarih1.Value = Convert.ToDateTime(nak.TARIH);
                    tbFis.Text = nak.FISNO;
                    tbTonaj.Text = nak.TONAJ.ToString();
                    tbIrsaliye.Text = nak.IRSALIYENO;
                    tbAciklama.Text = nak.ACIKLAMA;
                    cmbAlici.SelectedValue = nak.ALICIFRM_ID;
                    cmbTasFrm.SelectedValue = nak.TASYCFRM_ID;
                    cmbGrup.SelectedValue = nak.GRUP_ID;
                    cmbUrun.SelectedValue = nak.URUN_ID;
                    cmbGondrlnYer.SelectedValue = nak.GONDRLNYER_ID;
                    cmbPlaka.SelectedValue = nak.PLAKA_ID;
                    cmbCIKIS.SelectedValue = nak.CIKIS_ID;
                    btnKaydet.Image = Properties.Resources.pencil_32;
                    btnKaydet.Text = "Düzenle";
                }
            }
        }

        string sonuc = string.Empty;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                if (!String.IsNullOrEmpty(tbFis.Text) && !String.IsNullOrEmpty(tbTonaj.Text) && !String.IsNullOrEmpty(tbIrsaliye.Text) && cmbAlici.SelectedIndex != -1 && cmbAlici.SelectedIndex != 0 && cmbTasFrm.SelectedIndex != -1 && cmbTasFrm.SelectedIndex != 0 && cmbGrup.SelectedIndex != -1 && cmbGrup.SelectedIndex != 0 && cmbUrun.SelectedIndex != -1 && cmbUrun.SelectedIndex != 0 && cmbGondrlnYer.SelectedIndex != -1 && cmbGondrlnYer.SelectedIndex != 0 && cmbPlaka.SelectedIndex != -1 && cmbPlaka.SelectedIndex != 0 && cmbCIKIS.SelectedIndex != -1 && cmbCIKIS.SelectedIndex != 0)
                {
                    Nesneler.NAKLIYE nk = new Nesneler.NAKLIYE();
                    nk.TARIH = dtpTarih1.Value.ToString("yyyy-MM-dd");
                    nk.FISNO = tbFis.Text;
                    nk.TONAJ = Double.Parse(tbTonaj.Text);
                    nk.IRSALIYENO = tbIrsaliye.Text;
                    nk.ACIKLAMA = tbAciklama.Text;
                    nk.ALICIFRM_ID = Convert.ToInt32(cmbAlici.SelectedValue);
                    nk.TASYCFRM_ID = Convert.ToInt32(cmbTasFrm.SelectedValue);
                    nk.GRUP_ID = Convert.ToInt32(cmbGrup.SelectedValue);
                    nk.URUN_ID = Convert.ToInt32(cmbUrun.SelectedValue);
                    nk.GONDRLNYER_ID = Convert.ToInt32(cmbGondrlnYer.SelectedValue);
                    nk.PLAKA_ID = Convert.ToInt32(cmbPlaka.SelectedValue);
                    nk.CIKIS_ID = Convert.ToInt32(cmbCIKIS.SelectedValue);

                    if (Secilen_id == 0)
                    {
                        Islemler.NAKLIYEIslem.Kaydet(nk);
                        sonuc = " Kaydetme";
                    }
                    else
                    {
                        nk.ID = Secilen_id; 
                        Islemler.NAKLIYEIslem.Guncelle(nk); 
                        sonuc = "Düzenleme";
                    }

                    //dtpTarih1.Value = DateTime.Today;
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
                    cmbCIKIS.SelectedIndex = -1;
                    errorProvider.Clear();
                    dtpTarih1.Focus();
                    btnKaydet.Image = Properties.Resources.save_32;
                    btnKaydet.Text = "Kaydet";
                    Secilen_id = 0;
                    Kayit_Say++;
                    tssLblDurum.Text = sonuc + " İşlemi Başarılı ...";
                }
                else
                {
                    errorProvider.Clear();
                    string hata = string.Empty;
                    if (String.IsNullOrEmpty(tbFis.Text)) { errorProvider.SetError(tbFis, "Lütfen Fiş No Giriniz!!!"); hata += errorProvider.GetError(tbFis) + "\n"; }
                    if (String.IsNullOrEmpty(tbTonaj.Text)) { errorProvider.SetError(tbTonaj, "Lütfen Tutar Giriniz!!!"); hata += errorProvider.GetError(tbTonaj) + "\n"; }
                    if (String.IsNullOrEmpty(tbIrsaliye.Text)) { errorProvider.SetError(tbIrsaliye, "Lütfen İrsaliye No Giriniz!!!"); hata += errorProvider.GetError(tbIrsaliye) + "\n"; }
                    if (cmbAlici.SelectedIndex == -1 || cmbAlici.SelectedIndex == 0) { errorProvider.SetError(cmbAlici, "Lütfen Alıcı Seçiniz!!!"); hata += errorProvider.GetError(cmbAlici) + "\n"; }
                    if (cmbTasFrm.SelectedIndex == -1 || cmbTasFrm.SelectedIndex == 0) { errorProvider.SetError(cmbTasFrm, "Lütfen Taşıyıcı Seçiniz!!!"); hata += errorProvider.GetError(cmbTasFrm) + "\n"; }
                    if (cmbGrup.SelectedIndex == -1 || cmbGrup.SelectedIndex == 0) { errorProvider.SetError(cmbGrup, "Lütfen Ürün Grubu Seçiniz!!!"); hata += errorProvider.GetError(cmbGrup) + "\n"; }
                    if (cmbUrun.SelectedIndex == -1 || cmbUrun.SelectedIndex == 0) { errorProvider.SetError(cmbUrun, "Lütfen Ürün Seçiniz!!!"); hata += errorProvider.GetError(cmbUrun) + "\n"; }
                    if (cmbGondrlnYer.SelectedIndex == -1 || cmbGondrlnYer.SelectedIndex == 0) { errorProvider.SetError(cmbGondrlnYer, "Lütfen Teslim Yeri Seçiniz!!!"); hata += errorProvider.GetError(cmbGondrlnYer) + "\n"; }
                    if (cmbPlaka.SelectedIndex == -1 || cmbPlaka.SelectedIndex == 0) { errorProvider.SetError(cmbPlaka, "Lütfen Plaka Seçiniz!!!"); hata += errorProvider.GetError(cmbPlaka) + "\n"; }
                    if (cmbCIKIS.SelectedIndex == -1 || cmbCIKIS.SelectedIndex == 0) { errorProvider.SetError(cmbCIKIS, "Lütfen Plaka Seçiniz!!!"); hata += errorProvider.GetError(cmbCIKIS) + "\n"; }
                    MessageBox.Show(hata + "\n" + "İşlem Yapılamadı.", "Eksik Bilgi Hatası");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNakliyeKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (new WaitCursor())
            {
                if (Kayit_Say != 0)
                {
                    if (sonuc != " Kaydetme") { frm.tur = "Duzenle"; } else { frm.tur = "Kayit"; }                    
                    frm.AktifSayfa = 0;
                    frm.Kayit_Say = Kayit_Say;
                    frm.Temizle();
                    frm.Sayfala();
                }
            }
        }
        
        private void tbIrsaliye_Leave(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                errorProvider.Clear();
                try
                {
                    if (!String.IsNullOrEmpty(tbIrsaliye.Text) && Islemler.NAKLIYEIslem.VeriKumesi("select ID from NAKLIYE where IRSALIYENO=" + tbIrsaliye.Text).Rows.Count != 0)
                    {
                        MessageBox.Show("Aynı İrsaliye No Kullanılmaktadır."); errorProvider.SetError(tbIrsaliye, "Aynı İrsaliye No Kullanılmaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı İrsaliye No Girişi!!!"); errorProvider.SetError(tbIrsaliye, "Hatalı İrsaliye No Girişi!!!");
                }
                
            }
        }

        private void tbFis_Leave(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                errorProvider.Clear();
                try
                {
                    if (!String.IsNullOrEmpty(tbFis.Text) && Islemler.NAKLIYEIslem.VeriKumesi("select ID from NAKLIYE where FISNO=" + tbFis.Text).Rows.Count != 0)
                    {
                        MessageBox.Show("Aynı Fiş No Kullanılmaktadır."); errorProvider.SetError(tbIrsaliye, "Aynı Fiş No Kullanılmaktadır.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı Fiş No Girişi!!!"); errorProvider.SetError(tbIrsaliye, "Hatalı Fiş No Girişi!!!");
                }

            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                if (cmbUrun.SelectedIndex != -1 && cmbUrun.SelectedIndex != 0)
                {
                    cmbGrup.SelectedValue = Islemler.URUNIslem.IdyeGoreURUNGetir(Convert.ToInt32(cmbUrun.SelectedValue)).GRUP_ID;
                }
            }
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                if (cmbPlaka.SelectedIndex != -1 && cmbPlaka.SelectedIndex != 0)
                {
                    cmbTasFrm.SelectedValue = Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Convert.ToInt32(cmbPlaka.SelectedValue)).TASYCFRM_ID;
                }
            }
        }

    }
}
