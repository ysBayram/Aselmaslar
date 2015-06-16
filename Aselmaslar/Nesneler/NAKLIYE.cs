using System;
using System.Collections.Generic;
using System.Text;

namespace Aselmaslar.Nesneler
{
    public class NAKLIYE
    {
        public Int32 ID { get; set; }
        public Int32 ALICIFRM_ID { get; set; }
        public Int32 TASYCFRM_ID { get; set; }
        public Int32 GRUP_ID { get; set; }
        public Int32 URUN_ID { get; set; }
        public Int32 GONDRLNYER_ID { get; set; }
        public Int32 PLAKA_ID { get; set; }
        public Double TONAJ { get; set; }
        public String TARIH { get; set; }
        public String FISNO { get; set; }
        public String IRSALIYENO { get; set; }
        public String ACIKLAMA { get; set; }
        public Int32 CIKIS_ID { get; set; }
    }
}
