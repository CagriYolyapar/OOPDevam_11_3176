using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_1.Tools
{
    public class Egitmen
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public List<Brans> Branslari { get; set; }

        public string IsimSoyIsimGoster()
        {
            return $"{Isim} {SoyIsim}";
        }

        public string TamBilgiGoster()
        {
            string sonuc = IsimSoyIsimGoster();
            for (int i = 0; i < Branslari.Count; i++)
            {
                sonuc += $" {Branslari[i].Isim},"; 
            }

            sonuc = sonuc.TrimEnd(',');

            return sonuc;
        }

    }
}
