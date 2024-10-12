using _2_ClassOrnekler.Otomotiv;
using _2_ClassOrnekler.Otomotiv.Otomobil;
using _2_ClassOrnekler.Otomotiv.Ticariler.Kamyonlar;

namespace _2_ClassOrnekler
{
    internal class Program
    {
        //structlar stackte tutulurken, classlar heapte tutulur.
       
        static void Main(string[] args)
        {
            #region Class Instance Alma
            //1.YOL
            Kitap kitap = new Kitap();
            kitap.KitapAdi = "İnce Memed";
            kitap.Yazar = "Yaşar Kemal";
            kitap.BaskiYili = new DateOnly(1967,1,1);
            kitap.SayfaSayisi = 360;
            kitap.YayinEvi = "YKB";


            //2.YOL OBJECT INITILATION
            Kitap kitap2 = new Kitap()
            {
                Yazar = "Orhan Pamuk",
                YayinEvi = "YKB",
                KitapAdi = "Yeni Hayat",
                BaskiYili = new DateOnly(2000, 1, 1),
                SayfaSayisi = 250,
                Barkod = "12556357"
                
            };

            //enum içeren classlardan instance alma
            Otomobil otomobil = new Otomobil();
            otomobil.KasaTipi = KasaTipi.Sedan;
            otomobil.YakitTipi = YakitTipi.Dizel;
            otomobil.Cekis = Cekis.OndenCekis;
            otomobil.Marka = "Mercedes";
            otomobil.Model = "A200";

            Kamyon kamyon = new Kamyon();
            kamyon.UstYapi = UstYapi.AcıkKasa;
            //Console.WriteLine(Enum.GetValues(typeof(KasaTipi)));
            //Console.WriteLine(Enum.GetNames(typeof(KasaTipi)));
            #endregion
        }
    }
}
