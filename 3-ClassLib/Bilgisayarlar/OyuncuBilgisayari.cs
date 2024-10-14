using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class OyuncuBilgisayari :BaseItem
    {
        public Anakart Anakart { get; set; }
        public Cpu Cpu { get; set; } = new Cpu("AMD", "i9",8,5000);
        public List<Ram> Ramlar { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }
        public List<HardDisk> Diskler { get; set; }

        public OyuncuBilgisayari() 
        {
            //Anakart.Marka = "Gigabyte";
            //if (Cpu != null) Cpu.Marka = "AMD"; //12.satırdaki yol daha kolay
        }  
    }
}
