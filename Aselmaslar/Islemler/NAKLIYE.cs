using System;
using System.Collections.Generic;
using System.Text;
using Aselmaslar.Nesneler;
using Aselmaslar.Saglayici;
using System.Data;
using System.Data.SQLite;

namespace Aselmaslar.Islemler
{
    public class NAKLIYEIslem
    {
        public static void Kaydet(NAKLIYE p)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("insert into NAKLIYE(ALICIFRM_ID,TASYCFRM_ID,GRUP_ID,URUN_ID,GONDRLNYER_ID,PLAKA_ID,TONAJ,TARIH,FISNO,IRSALIYENO,ACIKLAMA,CIKIS_ID)values (@ALICIFRM_ID,@TASYCFRM_ID,@GRUP_ID,@URUN_ID,@GONDRLNYER_ID,@PLAKA_ID,@TONAJ,@TARIH,@FISNO,@IRSALIYENO,@ACIKLAMA,@CIKIS_ID)");
            cm.Parameters.AddWithValue("@ALICIFRM_ID", p.ALICIFRM_ID);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Parameters.AddWithValue("@GRUP_ID", p.GRUP_ID);
            cm.Parameters.AddWithValue("@URUN_ID", p.URUN_ID);
            cm.Parameters.AddWithValue("@GONDRLNYER_ID", p.GONDRLNYER_ID);
            cm.Parameters.AddWithValue("@PLAKA_ID", p.PLAKA_ID);
            cm.Parameters.AddWithValue("@TONAJ", p.TONAJ);
            cm.Parameters.AddWithValue("@TARIH", p.TARIH);
            cm.Parameters.AddWithValue("@FISNO", p.FISNO);
            cm.Parameters.AddWithValue("@IRSALIYENO", p.IRSALIYENO);
            cm.Parameters.AddWithValue("@ACIKLAMA", p.ACIKLAMA);
            cm.Parameters.AddWithValue("@CIKIS_ID", p.CIKIS_ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Guncelle(NAKLIYE p)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("update NAKLIYE set ALICIFRM_ID=@ALICIFRM_ID,TASYCFRM_ID=@TASYCFRM_ID,GRUP_ID=@GRUP_ID,URUN_ID=@URUN_ID,GONDRLNYER_ID=@GONDRLNYER_ID,PLAKA_ID=@PLAKA_ID,TONAJ=@TONAJ,TARIH=@TARIH,FISNO=@FISNO,IRSALIYENO=@IRSALIYENO,ACIKLAMA=@ACIKLAMA,CIKIS_ID=@CIKIS_ID where ID=@ID");
            cm.Parameters.AddWithValue("@ALICIFRM_ID", p.ALICIFRM_ID);
            cm.Parameters.AddWithValue("@TASYCFRM_ID", p.TASYCFRM_ID);
            cm.Parameters.AddWithValue("@GRUP_ID", p.GRUP_ID);
            cm.Parameters.AddWithValue("@URUN_ID", p.URUN_ID);
            cm.Parameters.AddWithValue("@GONDRLNYER_ID", p.GONDRLNYER_ID);
            cm.Parameters.AddWithValue("@PLAKA_ID", p.PLAKA_ID);
            cm.Parameters.AddWithValue("@TONAJ", p.TONAJ);
            cm.Parameters.AddWithValue("@TARIH", p.TARIH);
            cm.Parameters.AddWithValue("@FISNO", p.FISNO);
            cm.Parameters.AddWithValue("@IRSALIYENO", p.IRSALIYENO);
            cm.Parameters.AddWithValue("@ACIKLAMA", p.ACIKLAMA);
            cm.Parameters.AddWithValue("@CIKIS_ID", p.CIKIS_ID);
            cm.Parameters.AddWithValue("@ID", p.ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static void Sil(int ID)
        {
            SQLiteCommand cm = DBCon.KomutOlustur("delete from NAKLIYE where ID=@ID");
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Connection.Open();
            cm.ExecuteNonQuery();
            cm.Connection.Close();
        }


        public static NAKLIYE IdyeGoreNAKLIYEGetir(int ID)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from NAKLIYE where ID=@ID", DBCon.BaglantiYap());
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                NAKLIYE n = new NAKLIYE();
                n.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
                n.ALICIFRM_ID = Convert.ToInt32(dt.Rows[0]["ALICIFRM_ID"]);
                n.TASYCFRM_ID = Convert.ToInt32(dt.Rows[0]["TASYCFRM_ID"]);
                n.GRUP_ID = Convert.ToInt32(dt.Rows[0]["GRUP_ID"]);
                n.URUN_ID = Convert.ToInt32(dt.Rows[0]["URUN_ID"]);
                n.GONDRLNYER_ID = Convert.ToInt32(dt.Rows[0]["GONDRLNYER_ID"]);
                n.PLAKA_ID = Convert.ToInt32(dt.Rows[0]["PLAKA_ID"]);
                n.TONAJ = Convert.ToDouble(dt.Rows[0]["TONAJ"]);
                n.TARIH = Convert.ToString(dt.Rows[0]["TARIH"]);
                n.FISNO = Convert.ToString(dt.Rows[0]["FISNO"]);
                n.IRSALIYENO = Convert.ToString(dt.Rows[0]["IRSALIYENO"]);
                n.ACIKLAMA = Convert.ToString(dt.Rows[0]["ACIKLAMA"]);
                n.CIKIS_ID = Convert.ToInt32(dt.Rows[0]["CIKIS_ID"]);
                return n;
            }
            else { return null; }
        }


        public static DataTable TumKayitlar()
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from NAKLIYE", DBCon.BaglantiYap());
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
