﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class Cpu : BaseItem
    {
        public int CoreSayisi { get; set; }
        public int Hiz { get; set; }

        public Cpu()
        {
            Marka = "Intel";
            CoreSayisi = 4;
            Hiz = 1000;
        }
        public Cpu(string marka)
        {
            Marka = marka;
        }

        public Cpu(string marka, string model, int coreSayisi)
        {
            Marka=marka;
            Model = model;  
            CoreSayisi = coreSayisi;    

        }
        public Cpu(string marka, string model, int coreSayisi, int hiz)
        {
            Marka = marka;
            Model = model;
            CoreSayisi = coreSayisi;

        }
    }
}
