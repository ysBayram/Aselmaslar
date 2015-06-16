using System;
using System.Collections.Generic;
using System.Text;
using Aselmaslar.Nesneler;
using Aselmaslar.Saglayici;
using System.Data;
using System.Data.SQLite;

namespace Aselmaslar.Islemler
{
    public class PETROLISLEMLERIIslem
    {
        public static void Kaydet(PETROLISLEMLERI p)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("insert into PETROLISLEMLERI(TARIH,FIS_NO,TUTAR,PETROL_ID,PLAKA_ID,TASYCFRM_ID,ACIKLAMA,CIKIS_ID)values (@TARIH,@FIS_NO,@TUTAR,@PETROL_ID,@PLAKA_ID,@TASYCFRM_ID,@ACIKLAMA,@CIKIS_ID)");
            cm.Parameters.AddWithValue("@TARIH", p.TARIH);
            cm.Parameters.AddWithValue("@FIS_NO", p.FIS_NO);
            cm.Parameters.AddWithValue("@TUTAR", p.TUTAR);
            cm.Parameters.AddWithValue("@PETROL_ID", p.PETROL_ID);
            cm.Parameters.AddWithValue("@PLAKA_ID", p.PLAKA_ID);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Parameters.AddWithValue("@ACIKLAMA", p.ACIKLAMA);
            cm.Parameters.AddWithValue("@CIKIS_ID", p.CIKIS_ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Guncelle(PETROLISLEMLERI p)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("update PETROLISLEMLERI set TARIH=@TARIH,FIS_NO=@FIS_NO,TUTAR=@TUTAR,PETROL_ID=@PETROL_ID,PLAKA_ID=@PLAKA_ID,TASYCFRM_ID=@TASYCFRM_ID,ACIKLAMA=@ACIKLAMA,CIKIS_ID=@CIKIS_ID where ID=@ID");
            cm.Parameters.AddWithValue("@TARIH", p.TARIH);
            cm.Parameters.AddWithValue("@FIS_NO", p.FIS_NO);
            cm.Parameters.AddWithValue("@TUTAR", p.TUTAR);
            cm.Parameters.AddWithValue("@PETROL_ID", p.PETROL_ID);
            cm.Parameters.AddWithValue("@PLAKA_ID", p.PLAKA_ID);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Parameters.AddWithValue("@ACIKLAMA", p.ACIKLAMA);
            cm.Parameters.AddWithValue("@CIKIS_ID", p.CIKIS_ID);
            cm.Parameters.AddWithValue("@ID", p.ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Sil(int ID)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("delete from PETROLISLEMLERI where ID=@ID");
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static PETROLISLEMLERI IdyeGorePETROLISLEMLERIGetir(int ID)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from PETROLISLEMLERI where ID=@ID", DBCon.BaglantiYap());
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                PETROLISLEMLERI p = new PETROLISLEMLERI();
                p.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                p.TARIH = Convert.ToString(dt.Rows[0]["TARIH"]);
                p.FIS_NO = Convert.ToString(dt.Rows[0]["FIS_NO"]);
                p.TUTAR = Convert.ToString(dt.Rows[0]["TUTAR"]);
                p.PETROL_ID = Convert.ToInt32(dt.Rows[0]["PETROL_ID"]);
                p.PLAKA_ID = Convert.ToInt32(dt.Rows[0]["PLAKA_ID"]);
                p.TASYCFRM_ID = Convert.ToInt32(dt.Rows[0]["TASYCFRM_ID"]);
                p.ACIKLAMA = Convert.ToString(dt.Rows[0]["ACIKLAMA"]);
                p.CIKIS_ID = Convert.ToInt32(dt.Rows[0]["CIKIS_ID"]);
                return p;
            }
            else { return null; }
        }


        public static DataTable TumKayitlar()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from PETROLISLEMLERI order by ID desc", DBCon.BaglantiYap());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public static DataTable VeriKumesi(string sql)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DBCon.BaglantiYap());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public static void KomutIslet(string sql)
        {
            DBCon.BaglantiYap().Open(); SQLiteCommand cm = DBCon.KomutOlustur(sql);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
        }


    }
}
