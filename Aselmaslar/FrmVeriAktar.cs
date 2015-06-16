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
    public partial class FrmVeriAktar : Form
    {
        private FrmVeri frm;
        public FrmVeriAktar(FrmVeri ParentForm)
        {
            InitializeComponent();
            frm = ParentForm;
        }

        private void FrmVeriAktar_Load(object sender, EventArgs e)
        {
            cmbHedef.Focus();
            switch (FrmVeri.Veri_Etiket)
            {
                case "ALICIFIRMA": Tools.cmbDoldur("Select * from ALICIFIRMA", cmbHedef, "AD", "ID"); break;
                case "TASIYICIFIRMA": Tools.cmbDoldur("Select * from TASIYICIFIRMA", cmbHedef, "AD", "ID"); break;
                case "PLAKA": Tools.cmbDoldur("Select * from PLAKA", cmbHedef, "AD", "ID"); break;
                case "GONDRLNYER": Tools.cmbDoldur("Select * from GONDRLNYER", cmbHedef, "AD", "ID"); break;
                case "PETROL": Tools.cmbDoldur("Select * from PETROL", cmbHedef, "AD", "ID"); break;
                case "GRUP": Tools.cmbDoldur("Select * from GRUP", cmbHedef, "AD", "ID"); break;
                case "URUN": Tools.cmbDoldur("Select * from URUN", cmbHedef, "AD", "ID"); break;
                case "CIKIS": Tools.cmbDoldur("Select * from CIKIS", cmbHedef, "AD", "ID"); break;
            }
        }

        int SecilenID = FrmVeri.Secilen_id;
        private void btnVeriAktar_Click(object sender, EventArgs e)
        {
            if (cmbHedef.SelectedIndex != -1 && cmbHedef.SelectedIndex != 0)
            {
                string ekSQL = string.Empty;
                switch (FrmVeri.Veri_Etiket)
                {
                    case "ALICIFIRMA": ekSQL += " where ALICIFRM_ID="; break;
                    case "TASIYICIFIRMA": ekSQL += " where TASYCFRM_ID="; break;
                    case "PLAKA": ekSQL += " where PLAKA_ID="; break;
                    case "GONDRLNYER": ekSQL += " where GONDRLNYER_ID="; break;
                    case "PETROL": ekSQL += " where PETROL_ID="; break;
                    case "GRUP": ekSQL += " where GRUP_ID="; break;
                    case "URUN": ekSQL += " where URUN_ID="; break;
                    case "CIKIS": ekSQL += " where CIKIS_ID="; break;
                }
                DataTable dt;

                if (FrmVeri.Veri_Etiket != "PETROL" && FrmVeri.nakliye != 0)
                {
                    dt = Islemler.NAKLIYEIslem.VeriKumesi("Select ID From NAKLIYE" + ekSQL + SecilenID.ToString());
                    Nesneler.NAKLIYE nk = new Nesneler.NAKLIYE();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        nk = Islemler.NAKLIYEIslem.IdyeGoreNAKLIYEGetir(Convert.ToInt32(dt.Rows[i][0]));
                        switch (FrmVeri.Veri_Etiket)
                        {
                            case "ALICIFIRMA": nk.ALICIFRM_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "TASIYICIFIRMA": nk.TASYCFRM_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "PLAKA": nk.PLAKA_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "GONDRLNYER": nk.GONDRLNYER_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "GRUP": nk.GRUP_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "URUN": nk.URUN_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "CIKIS": nk.CIKIS_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                        }
                        nk.ID = Convert.ToInt32(dt.Rows[i][0]);
                        Islemler.NAKLIYEIslem.Guncelle(nk);
                    }
                }

                if (FrmVeri.Veri_Etiket != "ALICIFIRMA" && FrmVeri.Veri_Etiket != "GONDRLNYER" && FrmVeri.Veri_Etiket != "GRUP" && FrmVeri.Veri_Etiket != "URUN" && FrmVeri.petrol != 0 )
                {
                    dt = Islemler.PETROLISLEMLERIIslem.VeriKumesi("Select ID from PETROLISLEMLERI" + ekSQL + SecilenID.ToString());
                    Nesneler.PETROLISLEMLERI pt = new Nesneler.PETROLISLEMLERI();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        pt = Islemler.PETROLISLEMLERIIslem.IdyeGorePETROLISLEMLERIGetir(Convert.ToInt32(dt.Rows[i][0]));
                        switch (FrmVeri.Veri_Etiket)
                        {
                            case "TASIYICIFIRMA": pt.TASYCFRM_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "PLAKA": pt.PLAKA_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "PETROL": pt.PETROL_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                            case "CIKIS": pt.CIKIS_ID = Convert.ToInt32(cmbHedef.SelectedValue); break;
                        }
                        pt.ID = Convert.ToInt32(dt.Rows[i][0]);
                        Islemler.PETROLISLEMLERIIslem.Guncelle(pt);
                    }
                }

                if (FrmVeri.Veri_Etiket == "TASIYICIFIRMA" && FrmVeri.plaka != 0)
                {
                    dt = Islemler.PLAKAIslem.VeriKumesi("Select ID from PLAKA" + ekSQL + SecilenID.ToString());
                    Nesneler.PLAKA pl = new Nesneler.PLAKA();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        pl = Islemler.PLAKAIslem.IdyeGorePLAKAGetir(Convert.ToInt32(dt.Rows[i][0]));
                        pl.TASYCFRM_ID = Convert.ToInt32(cmbHedef.SelectedValue);
                        pl.ID = Convert.ToInt32(dt.Rows[i][0]);
                        Islemler.PLAKAIslem.Guncelle(pl);
                    }
                }

                if (FrmVeri.Veri_Etiket == "GRUP" && FrmVeri.urun != 0 )
                {
                    dt = Islemler.URUNIslem.VeriKumesi("Select ID from URUN" + ekSQL + SecilenID.ToString());
                    Nesneler.URUN ur = new Nesneler.URUN();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ur = Islemler.URUNIslem.IdyeGoreURUNGetir(Convert.ToInt32(dt.Rows[i][0]));
                        ur.GRUP_ID = Convert.ToInt32(cmbHedef.SelectedValue);
                        ur.ID = Convert.ToInt32(dt.Rows[i][0]);
                        Islemler.URUNIslem.Guncelle(ur);
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hedef Seçiniz!!!", "Boş Hedef Seçimi Hatası");
            }

        }

        private void FrmVeriAktar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Temizle();
        }

    }
}
