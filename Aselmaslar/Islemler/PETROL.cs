using System;
using System.Collections.Generic;
using System.Text;
using Aselmaslar.Nesneler;
using Aselmaslar.Saglayici;
using System.Data;
using System.Data.SQLite;

namespace Aselmaslar.Islemler
{
public class PETROLIslem
{
public static void Kaydet(PETROL p)
{
SQLiteCommand cm = DBCon.KomutOlustur("insert into PETROL(AD,SORUMLU,TEL)values (@AD,@SORUMLU,@TEL)");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Parameters.AddWithValue("@SORUMLU", p.SORUMLU);
cm.Parameters.AddWithValue("@TEL", p.TEL);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Guncelle(PETROL p)
{
SQLiteCommand cm = DBCon.KomutOlustur("update PETROL set AD=@AD,SORUMLU=@SORUMLU,TEL=@TEL where ID=@ID");
cm.Parameters.AddWithValue("@AD", p.AD);
cm.Parameters.AddWithValue("@SORUMLU", p.SORUMLU);
cm.Parameters.AddWithValue("@TEL", p.TEL);
cm.Parameters.AddWithValue("@ID", p.ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static void Sil(int ID)
{
SQLiteCommand cm = DBCon.KomutOlustur("delete from PETROL where ID=@ID");
cm.Parameters.AddWithValue("@ID", ID);
cm.Connection.Open();
cm.ExecuteNonQuery();
cm.Connection.Close();
}


public static PETROL IdyeGorePETROLGetir(int ID)
{
SQLiteDataAdapter da = new SQLiteDataAdapter("select * from PETROL where ID=@ID",DBCon.BaglantiYap());
da.SelectCommand.Parameters.AddWithValue("@ID", ID);
DataTable dt = new DataTable();
da.Fill(dt);
if (dt.Rows.Count != 0)
{
PETROL p = new PETROL();
p.ID=Convert.ToInt32(dt.Rows[0]["ID"]);
p.AD=Convert.ToString(dt.Rows[0]["AD"]);
p.SORUMLU=Convert.ToString(dt.Rows[0]["SORUMLU"]);
p.TEL=Convert.ToString(dt.Rows[0]["TEL"]);
return p;
}
else { return null; }
}


public static DataTable TumKayitlar()
{
SQLiteDataAdapter da = new SQLiteDataAdapter("select * from PETROL",DBCon.BaglantiYap());
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
DBCon.BaglantiYap().Open();SQLiteCommand cm =  DBCon.KomutOlustur(sql);
cm.Connection.Open();
cm.ExecuteNonQuery();
}


}
}
