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
    public partial class FrmVeri : Form
    {
        public FrmVeri()
        {
            InitializeComponent();
        }

        #region Arama İşlemleri

        private void Alici_Arama()
        {
            string sql = "Select * From ALICIFIRMA WHERE AD LIKE '%" + tbAlAd.Text + "%' AND SORUMLU LIKE '%" + tbAlSorumlu.Text + "%' AND TEL LIKE '%" + tbAlTel.Text + "%' ORDER BY ID DESC";
            dgvVeriler.Tag = "ALICIFIRMA";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Tasiyici_Arama()
        {
            string sql = "Select * From TASIYICIFIRMA WHERE AD LIKE '%" + tbTasAd.Text + "%' ORDER BY ID DESC";
            dgvVeriler.Tag = "TASIYICIFIRMA";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Plaka_Arama()
        {
            string TFrm = String.Empty;
            if (cbPlTasFrm.SelectedIndex != -1) { TFrm = cbPlTasFrm.SelectedValue.ToString(); }
            string sql = "Select PLAKA.ID,PLAKA.AD,TASIYICIFIRMA.AD From PLAKA INNER JOIN TASIYICIFIRMA ON TASIYICIFIRMA.ID = PLAKA.TASYCFRM_ID WHERE PLAKA.AD LIKE '%" + tbPlAd.Text + "%' and TASYCFRM_ID LIKE '%" + TFrm + "%' ORDER BY PLAKA.ID DESC";
            dgvVeriler.Tag = "PLAKA";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Gondrln_Arama()
        {
            string sql = "Select * from GONDRLNYER where AD like '%" + tbGonAd.Text + "%' order by ID DESC";
            dgvVeriler.Tag = "GONDRLNYER";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Petrol_Arama()
        {
            string sql = "Select * From PETROL WHERE AD LIKE '%" + tbPetAd.Text + "%' AND SORUMLU LIKE '%" + tbPetSorum.Text + "%' AND TEL LIKE '%" + tbPetTel.Text + "%' ORDER BY ID DESC";
            dgvVeriler.Tag = "PETROL";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Grup_Arama()
        {
            string sql = "Select * From GRUP Where AD LIKE '%" + tbGrupAd.Text + "%' order by ID desc";
            dgvVeriler.Tag = "GRUP";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Urun_Arama()
        {
            string UGrup = String.Empty;
            if (cmbUrunGrup.SelectedIndex != -1) { UGrup = cmbUrunGrup.SelectedValue.ToString(); }
            string sql = "Select URUN.ID,URUN.AD,GRUP.AD From URUN INNER JOIN GRUP ON GRUP.ID = URUN.GRUP_ID WHERE URUN.AD LIKE '%" + tbUrunAd.Text + "%' and GRUP_ID LIKE '%" + UGrup + "%' ORDER BY URUN.ID DESC";
            dgvVeriler.Tag = "URUN";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        private void Cikis_Arama()
        {
            string sql = "Select * From CIKIS Where AD LIKE '%" + tbCIKISAd.Text + "%' order by ID desc";
            dgvVeriler.Tag = "CIKIS";
            Tools.gwDoldur(sql, dgvVeriler);
        }

        #endregion

        #region Temizleme İşlemleri

        public void Temizle()
        {
            switch (dgvVeriler.Tag.ToString())
            {
                case "ALICIFIRMA": Alici_Temizle(); break;
                case "TASIYICIFIRMA": Tasiyici_Temizle(); break;
                case "PLAKA": Plaka_Temizle(); break;
                case "GONDRLNYER": Gonderln_Temizle(); break;
                case "PETROL": Petrol_Temizle(); break;
                case "GRUP": Grup_Temizle(); break;
                case "URUN": Urun_Temizle(); break;
                case "CIKIS": CIKIS_Temizle(); break;
            }

            nakliye = -1;
            petrol = -1;
            plaka = -1;
            urun = -1;

            Secilen_id = 0;
            Veri_Etiket = string.Empty;
        }

        private void Alici_Temizle()
        {
            tbAlAd.Text = String.Empty;
            tbAlSorumlu.Text = String.Empty;
            tbAlTel.Text = String.Empty;
            btnAlKayit.Image = Properties.Resources.save_32;
            btnAlKayit.Text = "Kaydet";
            btnAlArama.Image = Properties.Resources.search_32;
            btnAlArama.Text = "Arama";
            Secilen_id = 0;
            tbAlAd.Focus();
            dgvVeriler.DataSource = null;
        }

        private void Tasiyici_Temizle()
        {
            tbTasAd.Text = String.Empty;
            btnTasKayit.Image = Properties.Resources.save_32;
            btnTasKayit.Text = "Kaydet";
            btnTasArama.Image = Properties.Resources.search_32;
            btnTasArama.Text = "Arama";
            Secilen_id = 0;
            tbTasAd.Focus();
            dgvVeriler.DataSource = null;
        }

        private void Plaka_Temizle()
        {
            tbPlAd.Text = String.Empty;
            cbPlTasFrm.SelectedIndex = -1;
            btnPlKayit.Image = Properties.Resources.save_32;
            btnPlKayit.Text = "Kaydet";
            btnPlArama.Image = Properties.Resources.search_32;
            btnPlArama.Text = "Arama";
            Secilen_id = 0;
            tbPlAd.Focus();
            dgvVeriler.DataSource = null;
        }
        private void Gonderln_Temizle()
        {
            tbGonAd.Text = String.Empty;
            btnGonKayit.Image = Properties.Resources.save_32;
            btnGonKayit.Text = "Kaydet";
            btnGonArama.Image = Properties.Resources.search_32;
            btnGonArama.Text = "Arama";
            Secilen_id = 0;
            tbGonAd.Focus();
            dgvVeriler.DataSource = null;
        }

        private void Petrol_Temizle()
        {
            tbPetAd.Text = String.Empty;
            tbPetSorum.Text = String.Empty;
            tbPetTel.Text = String.Empty;
            btnPetKayit.Image = Properties.Resources.save_32;
            btnPetKayit.Text = "Kaydet";
            btnPetArama.Image = Properties.Resources.search_32;
            btnPetArama.Text = "Arama";
            Secilen_id = 0;
            tbPetAd.Focus();
            dgvVeriler.DataSource = null;
        }

        private void Grup_Temizle()
        {
            tbGrupAd.Text = String.Empty;
            btnGrupKayit.Image = Properties.Resources.save_32;
            btnGrupKayit.Text = "Kaydet";
            btnGrupArama.Image = Properties.Resources.search_32;
            btnGrupArama.Text = "Arama";
            Secilen_id = 0;
            tbGrupAd.Focus();
            dgvVeriler.DataSource = null;
        }
        private void Urun_Temizle()
        {
            tbUrunAd.Text = String.Empty;
            cmbUrunGrup.SelectedIndex = -1;
            btnUrunKayit.Image = Properties.Resources.save_32;
            btnUrunKayit.Text = "Kaydet";
            btnUrunArama.Image = Properties.Resources.search_32;
            btnUrunArama.Text = "Arama";
            Secilen_id = 0;
            tbUrunAd.Focus();
            dgvVeriler.DataSource = null;
        }

        private void CIKIS_Temizle()
        {
            tbCIKISAd.Text = String.Empty;
            btnCIKISKayit.Image = Properties.Resources.save_32;
            btnCIKISKayit.Text = "Kaydet";
            btnCIKISArama.Image = Properties.Resources.search_32;
            btnCIKISArama.Text = "Arama";
            Secilen_id = 0;
            tbCIKISAd.Focus();
            dgvVeriler.DataSource = null;
        }

        #endregion

        #region Kayıt İşlemleri

        private void Alici_Kayit()
        {
            //kayıt ve güncelleme için nesne oluşturuyorum
            Nesneler.ALICIFIRMA al = new Nesneler.ALICIFIRMA();
            al.AD = tbAlAd.Text;
            al.SORUMLU = tbAlSorumlu.Text;
            al.TEL = tbAlTel.Text;
            if (!String.IsNullOrEmpty(tbAlAd.Text))
            {
                if (Secilen_id == 0)
                {
                    //oluşturulan nesneyi kayıt ediyorum
                    Islemler.ALICIFIRMAIslem.Kaydet(al);
                }
                else
                {
                    //oluşturulan nesne id ye göre güncelleniyor
                    al.ID = Secilen_id;
                    Islemler.ALICIFIRMAIslem.Guncelle(al);
                }
                errorProvider.Clear();
                //kullanılan formları temizliyorum
                Alici_Temizle();
                dgvVeriler.Tag = "ALICIFIRMA";
                dgvVeriler.DataSource = Islemler.ALICIFIRMAIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Adını Giriniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbAlAd, "Lütfen Müşteri Adını Giriniz!!!");
            }
        }

        private void Tasiyici_Kayit()
        {
            Nesneler.TASIYICIFIRMA tas = new Nesneler.TASIYICIFIRMA();
            tas.AD = tbTasAd.Text;
            if (!String.IsNullOrEmpty(tbTasAd.Text))
            {
                if (Secilen_id == 0)
                {
                    Islemler.TASIYICIFIRMAIslem.Kaydet(tas);
                }
                else
                {
                    tas.ID = Secilen_id; Islemler.TASIYICIFIRMAIslem.Guncelle(tas);
                }
                errorProvider.Clear();
                Tasiyici_Temizle();
                dgvVeriler.Tag = "TASIYICIFIRMA";
                dgvVeriler.DataSource = Islemler.TASIYICIFIRMAIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen Taşıyıcı Firma Adını Giriniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbTasAd, "Lütfen Taşıyıcı Firma Adını Giriniz!!!");
            }
        }

        private void Plaka_Kayit()
        {
            Nesneler.PLAKA pl = new Nesneler.PLAKA();
            pl.AD = tbPlAd.Text;
            pl.TASYCFRM_ID = Convert.ToInt32(cbPlTasFrm.SelectedValue);
            if (!String.IsNullOrEmpty(tbPlAd.Text) && (cbPlTasFrm.SelectedIndex != -1) && cbPlTasFrm.SelectedIndex != 0)
            {
                if (Secilen_id == 0) { Islemler.PLAKAIslem.Kaydet(pl); } else { pl.ID = Secilen_id; Islemler.PLAKAIslem.Guncelle(pl); }
                errorProvider.Clear();
                Plaka_Temizle();
                dgvVeriler.Tag = "PLAKA";
                dgvVeriler.DataSource = Islemler.PLAKAIslem.VeriKumesi("Select PLAKA.ID,PLAKA.AD,TASIYICIFIRMA.AD From PLAKA INNER JOIN TASIYICIFIRMA ON TASIYICIFIRMA.ID = PLAKA.TASYCFRM_ID ORDER BY PLAKA.ID DESC");
            }
            else
            {
                if (String.IsNullOrEmpty(tbPlAd.Text)) { errorProvider.SetError(tbPlAd, "Lütfen Plaka Adını Giriniz!!!"); }
                if ((cbPlTasFrm.SelectedIndex == -1) || cbPlTasFrm.SelectedIndex == 0) { errorProvider.SetError(cbPlTasFrm, "Lütfen Taşıyıcı Firma Seçiniz!!!"); }
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!!!", "Eksik Girdi Hatası");
            }
        }

        private void Gonderln_Kayit()
        {
            Nesneler.GONDRLNYER gon = new Nesneler.GONDRLNYER();
            gon.AD = tbGonAd.Text;
            if (!String.IsNullOrEmpty(tbGonAd.Text))
            {
                if (Secilen_id == 0) { Islemler.GONDRLNYERIslem.Kaydet(gon); } else { gon.ID = Secilen_id; Islemler.GONDRLNYERIslem.Guncelle(gon); }
                errorProvider.Clear();
                Gonderln_Temizle();
                dgvVeriler.Tag = "GONDRLNYER";
                dgvVeriler.DataSource = Islemler.GONDRLNYERIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbGonAd, "Lütfen Teslim Yerini Giriniz!!!");
            }
        }

        private void Petrol_Kayit()
        {
            Nesneler.PETROL pet = new Nesneler.PETROL();
            pet.AD = tbPetAd.Text;
            pet.SORUMLU = tbPetSorum.Text;
            pet.TEL = tbPetTel.Text;
            if (!String.IsNullOrEmpty(tbPetAd.Text))
            {
                if (Secilen_id == 0) { Islemler.PETROLIslem.Kaydet(pet); } else { pet.ID = Secilen_id; Islemler.PETROLIslem.Guncelle(pet); }
                errorProvider.Clear();
                Petrol_Temizle();
                dgvVeriler.Tag = "PETROL";
                dgvVeriler.DataSource = Islemler.PETROLIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbGonAd, "Lütfen Petrol Adını Giriniz!!!");
            }
        }

        private void Grup_Kayit()
        {
            Nesneler.GRUP gr = new Nesneler.GRUP();
            gr.AD = tbGrupAd.Text;
            if (!String.IsNullOrEmpty(tbGrupAd.Text))
            {
                if (Secilen_id == 0) { Islemler.GRUPIslem.Kaydet(gr); } else { gr.ID = Secilen_id; Islemler.GRUPIslem.Guncelle(gr); }
                errorProvider.Clear();
                Grup_Temizle();
                dgvVeriler.Tag = "GRUP";
                dgvVeriler.DataSource = Islemler.GRUPIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbGonAd, "Lütfen Grup Adını Giriniz!!!");
            }
        }

        private void Urun_Kayit()
        {
            Nesneler.URUN ur = new Nesneler.URUN();
            ur.AD = tbUrunAd.Text;
            ur.GRUP_ID = Convert.ToInt32(cmbUrunGrup.SelectedValue);
            if (!String.IsNullOrEmpty(tbUrunAd.Text) && cmbUrunGrup.SelectedIndex != -1 && cmbUrunGrup.SelectedIndex != 0)
            {
                if (Secilen_id == 0) { Islemler.URUNIslem.Kaydet(ur); } else { ur.ID = Secilen_id; Islemler.URUNIslem.Guncelle(ur); }
                errorProvider.Clear();
                Urun_Temizle();
                dgvVeriler.Tag = "URUN";
                dgvVeriler.DataSource = Islemler.URUNIslem.VeriKumesi("Select URUN.ID,URUN.AD,GRUP.AD From URUN INNER JOIN GRUP ON GRUP.ID = URUN.GRUP_ID ORDER BY URUN.ID DESC");
            }
            else
            {
                if (String.IsNullOrEmpty(tbUrunAd.Text)) { errorProvider.SetError(tbUrunAd, "Lütfen Ürün Adını Giriniz!!!"); }
                if ((cmbUrunGrup.SelectedIndex == -1) || cmbUrunGrup.SelectedIndex == 0) { errorProvider.SetError(cmbUrunGrup, "Lütfen Ürün Grubunu Seçiniz!!!"); }
                MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!!!", "Eksik Girdi Hatası");
            }
        }

        private void CIKIS_Kayit()
        {
            Nesneler.CIKIS ck = new Nesneler.CIKIS();
            ck.AD = tbCIKISAd.Text;
            if (!String.IsNullOrEmpty(tbCIKISAd.Text))
            {
                if (Secilen_id == 0)
                {
                    Islemler.CIKISIslem.Kaydet(ck);
                }
                else
                {
                    ck.ID = Secilen_id; Islemler.CIKISIslem.Guncelle(ck);
                }
                errorProvider.Clear();
                CIKIS_Temizle();
                dgvVeriler.Tag = "CIKIS";
                dgvVeriler.DataSource = Islemler.CIKISIslem.TumKayitlar();
            }
            else
            {
                MessageBox.Show("Lütfen ÇIKIŞ Adını Giriniz!!!", "Eksik Girdi Hatası");
                errorProvider.SetError(tbTasAd, "Lütfen ÇIKIŞ Adını Giriniz!!!");
            }
        }

        #endregion

        #region Düzenleme İşlemleri

        private void Alici_Duzenle()
        {
            Nesneler.ALICIFIRMA al = Islemler.ALICIFIRMAIslem.IdyeGoreALICIFIRMAGetir(Secilen_id);
            tbAlAd.Text = al.AD;
            tbAlSorumlu.Text = al.SORUMLU;
            tbAlTel.Text = al.TEL;
            btnAlKayit.Image = Properties.Resources.pencil_32;
            btnAlKayit.Text = "Düzenle";
            btnAlArama.Image = Properties.Resources.delete_32;
            btnAlArama.Text = "Sil";
        }

        private void Tasiyici_Duzenle()
        {
            Nesneler.TASIYICIFIRMA ta = Islemler.TASIYICIFIRMAIslem.IdyeGoreTASIYICIFIRMAGetir(Secilen_id);
            tbTasAd.Text = ta.AD;
            btnTasKayit.Image = Properties.Resources.pencil_32;
            btnTasKayit.Text = "Düzenle";
            btnTasArama.Image = Properties.Resources.delete_32;
            btnTasArama.Text = "Sil";
        }

        private void Plaka_Duzenle()
        {
            Nesneler.PLAKA pl = Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Secilen_id);
            tbPlAd.Text = pl.AD;
            cbPlTasFrm.SelectedValue = pl.TASYCFRM_ID;
            btnPlKayit.Image = Properties.Resources.pencil_32;
            btnPlKayit.Text = "Düzenle";
            btnPlArama.Image = Properties.Resources.delete_32;
            btnPlArama.Text = "Sil";
        }

        private void Gonderln_Duzenle()
        {
            Nesneler.GONDRLNYER gd = Islemler.GONDRLNYERIslem.IdyeGoreGONDRLNYERGetir(Secilen_id);
            tbGonAd.Text = gd.AD;
            btnGonKayit.Image = Properties.Resources.pencil_32;
            btnGonKayit.Text = "Düzenle";
            btnGonArama.Image = Properties.Resources.delete_32;
            btnGonArama.Text = "Sil";
        }

        private void Petrol_Duzenle()
        {
            Nesneler.PETROL pt = Islemler.PETROLIslem.IdyeGorePETROLGetir(Secilen_id);
            tbPetAd.Text = pt.AD;
            tbPetSorum.Text = pt.SORUMLU;
            tbPetTel.Text = pt.TEL;
            btnPetKayit.Image = Properties.Resources.pencil_32;
            btnPetKayit.Text = "Düzenle";
            btnPetArama.Image = Properties.Resources.delete_32;
            btnPetArama.Text = "Sil";
        }

        private void Grup_Duzenle()
        {
            Nesneler.GRUP gr = Islemler.GRUPIslem.IdyeGoreGRUPGetir(Secilen_id);
            tbGrupAd.Text = gr.AD;
            btnGrupKayit.Image = Properties.Resources.pencil_32;
            btnGrupKayit.Text = "Düzenle";
            btnGrupArama.Image = Properties.Resources.delete_32;
            btnGrupArama.Text = "Sil";
        }

        private void Urun_Duzenle()
        {
            Nesneler.URUN ur = Islemler.URUNIslem.IdyeGoreURUNGetir(Secilen_id);
            tbUrunAd.Text = ur.AD;
            cmbUrunGrup.SelectedValue = ur.GRUP_ID;
            btnUrunKayit.Image = Properties.Resources.pencil_32;
            btnUrunKayit.Text = "Düzenle";
            btnUrunArama.Image = Properties.Resources.delete_32;
            btnUrunArama.Text = "Sil";
        }

        private void CIKIS_Duzenle()
        {
            Nesneler.CIKIS ck = Islemler.CIKISIslem.IdyeGoreCIKISGetir(Secilen_id);
            tbCIKISAd.Text = ck.AD;
            btnCIKISKayit.Image = Properties.Resources.pencil_32;
            btnCIKISKayit.Text = "Düzenle";
            btnCIKISArama.Image = Properties.Resources.delete_32;
            btnCIKISArama.Text = "Sil";
        }

        #endregion

        #region Silme İşlemleri

        public static int nakliye = -1;
        public static int petrol = -1;
        public static int plaka = -1;
        public static int urun = -1;

        private void Alici_Sil()
        {
            if (MessageBox.Show(Islemler.ALICIFIRMAIslem.IdyeGoreALICIFIRMAGetir(Secilen_id).AD + " isimli firma SİLİNECEK!!! \n Onaylıyor musunuz?", "Alıcı Firma Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.ALICIFIRMAIslem.VeriKumesi("Select ID from NAKLIYE where ALICIFRM_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0)
                {
                    Islemler.ALICIFIRMAIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Alıcı Firma Üzerinde " + nakliye.ToString() + " nakliye işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Firmayı Silmeyi Deneyin!!!\n\nSilmek istediğiniz Alıcı Firma Üzerindeki işlemleri başka bir Alıcı Firmaya aktarmak\nİster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Alici_Temizle();
            dgvVeriler.Tag = "ALICIFIRMA";
            dgvVeriler.DataSource = Islemler.ALICIFIRMAIslem.TumKayitlar();
        }

        private void Tasiyici_Sil()
        {
            if (MessageBox.Show(Islemler.TASIYICIFIRMAIslem.IdyeGoreTASIYICIFIRMAGetir(Secilen_id).AD + " isimli firma SİLİNECEK!!! \n Onaylıyor musunuz?", "Taşıyıcı Firma Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.TASIYICIFIRMAIslem.VeriKumesi("Select ID from NAKLIYE where TASYCFRM_ID=" + Secilen_id.ToString()).Rows.Count;
                petrol = Islemler.TASIYICIFIRMAIslem.VeriKumesi("Select ID from PETROLISLEMLERI where TASYCFRM_ID=" + Secilen_id.ToString()).Rows.Count;
                plaka = Islemler.TASIYICIFIRMAIslem.VeriKumesi("Select ID from PLAKA where TASYCFRM_ID=" + Secilen_id.ToString())
.Rows.Count;
                if (nakliye == 0 && petrol == 0 && plaka == 0)
                {
                    Islemler.TASIYICIFIRMAIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Taşıyıcı Firma Üzerinde " + nakliye.ToString() + " nakliye , " + petrol.ToString() + " petrol ve " + plaka.ToString() + " plaka işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Firmayı Silmeyi Deneyin!!!\n\nSilmek istediğiniz Taşıyıcı Firma Üzerindeki işlemleri başka bir Taşıyıcı Firmaya aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }

            }
            Tasiyici_Temizle();
            dgvVeriler.Tag = "TASIYICIFIRMA";
            dgvVeriler.DataSource = Islemler.TASIYICIFIRMAIslem.TumKayitlar();
        }

        private void Plaka_Sil()
        {
            if (MessageBox.Show(Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Secilen_id).AD + " plaka SİLİNECEK!!! \n Onaylıyor musunuz?", "Plaka Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.PLAKAIslem.VeriKumesi("Select ID from NAKLIYE where PLAKA_ID=" + Secilen_id.ToString()).Rows.Count;
                petrol = Islemler.PLAKAIslem.VeriKumesi("Select ID from PETROLISLEMLERI where PLAKA_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0 && petrol == 0)
                {
                    Islemler.PLAKAIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Plaka Üzerinde " + nakliye.ToString() + " nakliye ve " + petrol.ToString() + " petrol işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Plakayı Silmeyi Deneyin!!!\n\nSilmek istediğiniz Plaka Üzerindeki işlemleri başka bir Plakaya aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Plaka_Temizle();
            dgvVeriler.Tag = "PLAKA";
            dgvVeriler.DataSource = Islemler.PLAKAIslem.TumKayitlar();
        }

        private void Gondrln_Sil()
        {
            if (MessageBox.Show(Islemler.GONDRLNYERIslem.IdyeGoreGONDRLNYERGetir(Secilen_id).AD + " gönderilen yer SİLİNECEK!!! \n Onaylıyor musunuz?", "Gönderilen Yer Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.GONDRLNYERIslem.VeriKumesi("Select ID from NAKLIYE where GONDRLNYER_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0)
                {
                    Islemler.GONDRLNYERIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Teslim Yeri Üzerinde " + nakliye.ToString() + " nakliye işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Teslim Yerini Silmeyi Deneyin!!!\n\nSilmek istediğiniz Teslim Yeri Üzerindeki işlemleri başka bir Teslim Yerine aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Gonderln_Temizle();
            dgvVeriler.Tag = "GONDRLNYER";
            dgvVeriler.DataSource = Islemler.GONDRLNYERIslem.TumKayitlar();
        }

        private void Petrol_Sil()
        {
            if (MessageBox.Show(Islemler.PETROLIslem.IdyeGorePETROLGetir(Secilen_id).AD + " petrol SİLİNECEK!!! \n Onaylıyor musunuz?", "Petrol Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                petrol = Islemler.PETROLIslem.VeriKumesi("Select ID from PETROLISLEMLERI where PETROL_ID=" + Secilen_id.ToString()).Rows.Count;
                if (petrol == 0)
                {
                    Islemler.PETROLIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Petrol Üzerinde " + petrol.ToString() + " petrol işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Petrolü Silmeyi Deneyin!!!\n\nSilmek istediğiniz Petrol Üzerindeki işlemleri başka bir Petrole aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Petrol_Temizle();
            dgvVeriler.Tag = "PETROL";
            dgvVeriler.DataSource = Islemler.PETROLIslem.TumKayitlar();
        }

        private void Grup_Sil()
        {
            if (MessageBox.Show(Islemler.GRUPIslem.IdyeGoreGRUPGetir(Secilen_id).AD + " grup SİLİNECEK!!! \n Onaylıyor musunuz?", "Grup Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.GRUPIslem.VeriKumesi("Select ID from NAKLIYE where GRUP_ID=" + Secilen_id.ToString()).Rows.Count;
                urun = Islemler.GRUPIslem.VeriKumesi("Select ID from URUN where GRUP_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0 && urun == 0)
                {
                    Islemler.GRUPIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Ürün Grubu Üzerinde " + nakliye.ToString() + " nakliye ve " + urun.ToString() + " urun işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Ürün Grubunu Silmeyi Deneyin!!!\n\nSilmek istediğiniz Ürün Grubunun Üzerindeki işlemleri başka bir Ürün Grubuna aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Grup_Temizle();
            dgvVeriler.Tag = "GRUP";
            dgvVeriler.DataSource = Islemler.GRUPIslem.TumKayitlar();
        }

        private void Urun_Sil()
        {
            if (MessageBox.Show(Islemler.URUNIslem.IdyeGoreURUNGetir(Secilen_id).AD + " ürün SİLİNECEK!!! \n Onaylıyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.URUNIslem.VeriKumesi("Select ID from NAKLIYE where URUN_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0)
                {
                    Islemler.URUNIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz Ürün Üzerinde " + nakliye.ToString() + " nakliye işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra Ürünü Silmeyi Deneyin!!!\n\nSilmek istediğiniz Ürünün Üzerindeki işlemleri başka bir Ürüne aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }
            }
            Urun_Temizle();
            dgvVeriler.Tag = "URUN";
            dgvVeriler.DataSource = Islemler.URUNIslem.TumKayitlar();
        }

        private void CIKIS_Sil()
        {
            if (MessageBox.Show(Islemler.CIKISIslem.IdyeGoreCIKISGetir(Secilen_id).AD + " isimli ÇIKIŞ SİLİNECEK!!! \n Onaylıyor musunuz?", "ÇIKIŞ Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nakliye = Islemler.CIKISIslem.VeriKumesi("Select ID from NAKLIYE where CIKIS_ID=" + Secilen_id.ToString()).Rows.Count;
                petrol = Islemler.TASIYICIFIRMAIslem.VeriKumesi("Select ID from PETROLISLEMLERI where CIKIS_ID=" + Secilen_id.ToString()).Rows.Count;
                if (nakliye == 0 && petrol == 0)
                {
                    Islemler.CIKISIslem.Sil(Secilen_id);
                }
                else
                {
                    if (MessageBox.Show("Silmek istediğiniz ÇIKIŞ Üzerinde " + nakliye.ToString() + " nakliye , " + petrol.ToString() + " petrol işlemi mevcuttur.\n\nLütfen Düzenlemeyi Yaptıktan Sonra ÇIKIŞI Silmeyi Deneyin!!!\n\nSilmek istediğiniz ÇIKIŞ Üzerindeki işlemleri başka bir ÇIKIŞA aktarmak İster misiniz?", "Veri Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmVeriAktar fr = new FrmVeriAktar(this); fr.ShowDialog();
                    }
                }

            }
            Tasiyici_Temizle();
            dgvVeriler.Tag = "CIKIS";
            dgvVeriler.DataSource = Islemler.CIKISIslem.TumKayitlar();
        }

        #endregion

        #region Buton İşlemleri

        private void btnAlArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Alici_Arama(); } else { Alici_Sil(); }
        }

        private void btnAlKayit_Click(object sender, EventArgs e)
        {
            Alici_Kayit();
        }

        private void btnTasArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Tasiyici_Arama(); } else { Tasiyici_Sil(); }
        }

        private void btnTasKayit_Click(object sender, EventArgs e)
        {
            Tasiyici_Kayit();
        }

        private void btnPlArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Plaka_Arama(); } else { Plaka_Sil(); }
        }

        private void btnPlKayit_Click(object sender, EventArgs e)
        {
            Plaka_Kayit();
        }

        private void btnGonArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Gondrln_Arama(); } else { Gondrln_Sil(); }
        }

        private void btnGonKayit_Click(object sender, EventArgs e)
        {
            Gonderln_Kayit();
        }

        private void btnPetArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Petrol_Arama(); } else { Petrol_Sil(); }
        }

        private void btnPetKayit_Click(object sender, EventArgs e)
        {
            Petrol_Kayit();
        }

        private void btnGrupArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Grup_Arama(); } else { Grup_Sil(); }
        }

        private void btnGrupKayit_Click(object sender, EventArgs e)
        {
            Grup_Kayit();
        }

        private void btnUrunArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Urun_Arama(); } else { Urun_Sil(); }
        }

        private void btnUrunKayit_Click(object sender, EventArgs e)
        {
            Urun_Kayit();
        }

        private void btnCIKISArama_Click(object sender, EventArgs e)
        {
            if (Secilen_id == 0) { Cikis_Arama(); } else { CIKIS_Sil(); }
        }

        private void btnCIKISKayit_Click(object sender, EventArgs e)
        {
            CIKIS_Kayit();
        }

        #endregion

        public static int Secilen_id = 0;
        public static string Veri_Etiket = string.Empty;
        private void dgvVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Secilen_id = Convert.ToInt32(dgvVeriler.Rows[e.RowIndex].Cells[0].Value);
            Veri_Etiket = dgvVeriler.Tag.ToString();
            switch (dgvVeriler.Tag.ToString())
            {
                case "ALICIFIRMA": Alici_Duzenle(); break;
                case "TASIYICIFIRMA": Tasiyici_Duzenle(); break;
                case "PLAKA": Plaka_Duzenle(); break;
                case "GONDRLNYER": Gonderln_Duzenle(); break;
                case "PETROL": Petrol_Duzenle(); break;
                case "GRUP": Grup_Duzenle(); break;
                case "URUN": Urun_Duzenle(); break;
                case "CIKIS": CIKIS_Duzenle(); break;
            }
            Sekmede_Kal();
        }

        private void tabcVeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sekmede_Kal();
        }

        private void Sekmede_Kal()
        {
            if (Secilen_id != 0)
            {
                switch (dgvVeriler.Tag.ToString())
                {
                    case "ALICIFIRMA": tabcVeri.SelectedIndex = 0; break;
                    case "TASIYICIFIRMA": tabcVeri.SelectedIndex = 1; break;
                    case "PLAKA": tabcVeri.SelectedIndex = 2; break;
                    case "GONDRLNYER": tabcVeri.SelectedIndex = 3; break;
                    case "PETROL": tabcVeri.SelectedIndex = 4; break;
                    case "GRUP": tabcVeri.SelectedIndex = 5; break;
                    case "URUN": tabcVeri.SelectedIndex = 6; break;
                    case "CIKIS": tabcVeri.SelectedIndex = 7; break;
                }
            }
        }

        private void tssBtnExcel_ButtonClick(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                if (dgvVeriler != null && dgvVeriler.Rows.Count != 0)
                {
                    Tools.ExportToExcel(dgvVeriler, sfdExcel.FileName);
                    if (MessageBox.Show("Excel Dosyası " + sfdExcel.FileName.ToString() + " konumuna kaydedilmiştir. \n Dosyayı Açmak İstiyor musunuz?", "Excel'e Aktar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start(sfdExcel.FileName.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Boş Veri Hatası!!!", "Excel'e Aktar");
                }
                tssLblDurum.Text = " " + dgvVeriler.Rows.Count.ToString() + " veri listelenmiştir.";
            }
        }

        private void dgvVeriler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvVeriler.Columns["ID"].Visible = false;

            string dgvsekme = "Müşteri";
            switch (dgvVeriler.Tag.ToString())
            {
                case "ALICIFIRMA": dgvsekme = "Müşteri"; break;
                case "TASIYICIFIRMA": dgvsekme = "Taşıyıcı Firma"; break;
                case "PLAKA": dgvVeriler.Columns[2].HeaderText = "TAŞIYICI FİRMA"; dgvsekme = "Plaka"; break;
                case "GONDRLNYER": dgvsekme = "Teslim Yeri"; break;
                case "PETROL": dgvsekme = "Petrol"; break;
                case "GRUP": dgvsekme = "Grup"; break;
                case "URUN": dgvVeriler.Columns[2].HeaderText = "ÜRÜN GRUBU"; dgvsekme = "Ürün"; break;
                case "CIKIS": dgvsekme = "ÇIKIŞ"; break;
            }

            tssLblDurum.Text = dgvsekme + " Tablosunda " + dgvVeriler.Rows.Count.ToString() + " veri listelenmiştir. ---> ";
        }

        private void tabPlaka_Enter(object sender, EventArgs e)
        {
            Tools.cmbDoldur("Select * From TASIYICIFIRMA ORDER BY ID DESC", cbPlTasFrm, "AD", "ID");
            cbPlTasFrm.SelectedIndex = -1;
        }

        private void tabUrun_Enter(object sender, EventArgs e)
        {
            Tools.cmbDoldur("Select * From GRUP order by ID desc", cmbUrunGrup, "AD", "ID");
            cmbUrunGrup.SelectedIndex = -1;
        }

        private void FrmVeri_SizeChanged(object sender, EventArgs e)
        {
            Point ptKayit = new Point(tabcVeri.Width - 101, 10);
            Point ptArama = new Point(tabcVeri.Width - 192, 10);
            btnAlKayit.Location = ptKayit;
            btnAlArama.Location = ptArama;
            btnTasKayit.Location = ptKayit;
            btnTasArama.Location = ptArama;
            btnPlKayit.Location = ptKayit;
            btnPlArama.Location = ptArama;
            btnGonKayit.Location = ptKayit;
            btnGonArama.Location = ptArama;
            btnPetKayit.Location = ptKayit;
            btnPetArama.Location = ptArama;
            btnGrupKayit.Location = ptKayit;
            btnGrupArama.Location = ptArama;
            btnUrunKayit.Location = ptKayit;
            btnUrunArama.Location = ptArama;
            btnCIKISKayit.Location = ptKayit;
            btnCIKISArama.Location = ptArama;
        }

        private void FrmVeri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabcVeri.SelectedTab.Name == "tabAlici") { Alici_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabTasyc") { Tasiyici_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabPlaka") { Plaka_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabGondYer") { Gonderln_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabPetrol") { Petrol_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabGrup") { Grup_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabUrun") { Urun_Kayit(); }
                if (tabcVeri.SelectedTab.Name == "tabCIKIS") { CIKIS_Kayit(); }
            }
        }

        private void FrmVeri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }



    }
}
