using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_1.Tools
{
    public class Brans
    {
        public string Isim { get; set; }
        public List<Egitmen> Egitmenler { get; set; }

        //C# Cagri Yolyapar,Fatih Günalp,
        public string TamBilgiGoster()
        {
            string sonuc = Isim;
            for (int i = 0; i < Egitmenler.Count; i++)
            {
                sonuc += $" {Egitmenler[i].IsimSoyIsimGoster()},";
            }
            sonuc = sonuc.TrimEnd(',');

            return sonuc;
        }

    }
}
