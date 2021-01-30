using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UnitEndProcessRowNumber:IEntity
    {
        public int Id { get; set; }
        public string unit_code { get; set; }
        public int year { get; set; }
        public int esas_karar_numarasi_verme { get; set; }
        public int degisik_is_dosya_no_verme { get; set; }
        public int degisik_is_karar_numarasi_verme { get; set; }
        public int temyiz_basvuru_sira_numarasi { get; set; }
        public int hakem_dava_dosyasi_karar_no_verme { get; set; }
        public int tevzi_dosyasi_no_verme { get; set; }
        public int talimat_dosyasi_no_verme { get; set; }
        public int tebligat_tevdi_dosyasi_no_verme { get; set; }
        public int esas_no_verme { get; set; }
        public int istinaf_basvuru_sira_no_verme { get; set; }
        public int hakem_dava_dosya_no_verme { get; set; }
    }
}
