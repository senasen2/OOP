using _3_ClassLib.Bilgisayarlar;

namespace _4_LibraryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            cpu.Marka = "Intel";

            Anakart anakart = new Anakart();
            
            Bilgisayar bilgisayar = new Bilgisayar();
            OyuncuBilgisayari oyuncu = new ();
            //bilgisayar.Anakart = anakart;
            //bilgisayar.Cpu = cpu;
            //bilgisayar.Ramlar = new List<Ram>();
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "Kingston"});
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "SanDisk" });

            //bilgisayar.Diskler.Add(new HardDisk { DisktTipi = DiskTipi.SSD , Marka = "Seagate"});
            //bilgisayar.EkranKartlari = new List<EkranKarti>();

        }
    }
}
