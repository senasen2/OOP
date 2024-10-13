using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public abstract class BaseItem
    {
        /*
         * Abstract classlardan instance alınamaz. Ancak kalıtım verebilir.
         * Varlık sebebide kalıtım vermektir. Yani base class olarak çalışır.
         */
        public string Marka { get; set; }
        public string Model { get; set; }
        public Double Fiyat { get; set; }
    }
}
