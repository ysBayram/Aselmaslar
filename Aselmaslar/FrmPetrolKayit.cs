using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aselmaslar
{
    public partial class FrmPetrolKayit : Form
    {
        private FrmPetrol frm;
        public FrmPetrolKayit(FrmPetrol ParentForm)
        {
            InitializeComponent();
            frm = ParentForm;
        }

        private int Secilen_id = FrmPetrol.Secilen_id;
        private void FrmPetrolKayit_Load(object sender, EventArgs e)
        {
            tssLblDurum.Text = " Taşıyıcı Firma Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From TASIYICIFIRMA order by ID desc", cmbTasFrm, "AD", "ID");
            cmbTasFrm.SelectedIndex = -1;
            tssLblDurum.Text = " Plaka Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From PLAKA order by ID desc", cmbPlaka, "AD", "ID");
            cmbPlaka.SelectedIndex = -1;
            tssLblDurum.Text = " Petrol Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From PETROL order by ID desc", cmbPetrol, "AD", "ID");
            cmbPetrol.SelectedIndex = -1;
            tssLblDurum.Text = " ÇIKIŞ Listeleri Aktarılıyor...";
            Tools.cmbDoldur("Select ID,AD From CIKIS order by ID desc", cmbCIKIS, "AD", "ID");
            cmbCIKIS.SelectedIndex = -1;
            tssLblDurum.Text = " İşlemler Başarılı Şekilde Gerçekleştirildi...";


            if (Secilen_id != 0)
            {
                Nesneler.PETROLISLEMLERI pet = Islemler.PETROLISLEMLERIIslem.IdyeGorePETROLISLEMLERIGetir(Secilen_id);
                dtpTarih1.Value = Convert.ToDateTime(pet.TARIH);
                tbFis.Text = pet.FIS_NO;
                tbTutar.Text = pet.TUTAR;
                tbAciklama.Text = pet.ACIKLAMA;
                cmbTasFrm.SelectedValue = pet.TASYCFRM_ID;
                cmbPetrol.SelectedValue = pet.PETROL_ID;
                cmbPlaka.SelectedValue = pet.PLAKA_ID;
                cmbCIKIS.SelectedValue = pet.CIKIS_ID;
                btnKaydet.Image = Properties.Resources.pencil_32;
                btnKaydet.Text = "Düzenle";
            }
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = string.Empty;
            if (!String.IsNullOrEmpty(tbFis.Text) && !String.IsNullOrEmpty(tbTutar.Text) && cmbTasFrm.SelectedIndex != -1 && cmbTasFrm.SelectedIndex != 0 && cmbPetrol.SelectedIndex != -1 && cmbPetrol.SelectedIndex != 0 && cmbPlaka.SelectedIndex != -1 && cmbPlaka.SelectedIndex != 0 && cmbCIKIS.SelectedIndex != -1 && cmbCIKIS.SelectedIndex != 0)
            {
                Nesneler.PETROLISLEMLERI pt = new Nesneler.PETROLISLEMLERI();
                pt.TARIH = dtpTarih1.Value.ToString("yyyy-MM-dd");
                pt.FIS_NO = tbFis.Text;
                pt.TUTAR = tbTutar.Text;
                pt.ACIKLAMA = tbAciklama.Text;
                pt.TASYCFRM_ID = Convert.ToInt32(cmbTasFrm.SelectedValue);
                pt.PETROL_ID = Convert.ToInt32(cmbPetrol.SelectedValue);
                pt.PLAKA_ID = Convert.ToInt32(cmbPlaka.SelectedValue);
                pt.CIKIS_ID = Convert.ToInt32(cmbCIKIS.SelectedValue);

                if (Secilen_id == 0) { Islemler.PETROLISLEMLERIIslem.Kaydet(pt); sonuc = " Kaydetme"; }
                else { pt.ID = Secilen_id; Islemler.PETROLISLEMLERIIslem.Guncelle(pt); sonuc = "Düzenleme"; }

                dtpTarih1.Value = DateTime.Today;
                tbFis.Text = String.Empty;
                tbTutar.Text = String.Empty;
                tbAciklama.Text = String.Empty;
                cmbTasFrm.SelectedIndex = -1;
                cmbPetrol.SelectedIndex = -1;
                cmbPlaka.SelectedIndex = -1;
                cmbCIKIS.SelectedIndex = -1;
                errorProvider.Clear();
                dtpTarih1.Focus();
                btnKaydet.Image = Properties.Resources.save_32;
                btnKaydet.Text = "Kaydet";
                Secilen_id = 0;

                frm.Sayfala();
                tssLblDurum.Text = sonuc + " İşlemi Başarılı ...";
            }
            else
            {
                errorProvider.Clear();
                string hata = string.Empty;
                if (String.IsNullOrEmpty(tbFis.Text)) { errorProvider.SetError(tbFis, "Lütfen Fiş No Giriniz!!!"); hata += errorProvider.GetError(tbFis) + "\n"; }
                if (String.IsNullOrEmpty(tbTutar.Text)) { errorProvider.SetError(tbTutar, "Lütfen Tutar Giriniz!!!"); hata += errorProvider.GetError(tbTutar) + "\n"; }
                if (cmbTasFrm.SelectedIndex == -1 || cmbTasFrm.SelectedIndex == 0) { errorProvider.SetError(cmbTasFrm, "Lütfen Taşıyıcı Seçiniz!!!"); hata += errorProvider.GetError(cmbTasFrm) + "\n"; }
                if (cmbPetrol.SelectedIndex == -1 || cmbPetrol.SelectedIndex == 0) { errorProvider.SetError(cmbPetrol, "Lütfen Petrol Seçiniz!!!"); hata += errorProvider.GetError(cmbPetrol) + "\n"; }
                if (cmbPlaka.SelectedIndex == -1 || cmbPlaka.SelectedIndex == 0) { errorProvider.SetError(cmbPlaka, "Lütfen Plaka Seçiniz!!!"); hata += errorProvider.GetError(cmbPlaka) + "\n"; }
                if (cmbCIKIS.SelectedIndex == -1 || cmbCIKIS.SelectedIndex == 0) { errorProvider.SetError(cmbCIKIS, "Lütfen Plaka Seçiniz!!!"); hata += errorProvider.GetError(cmbCIKIS) + "\n"; }
                MessageBox.Show(hata + "\n" + "İşlem Yapılamadı.", "Eksik Bilgi Hatası");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPetrolKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Temizle();
            frm.Sayfala();
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
