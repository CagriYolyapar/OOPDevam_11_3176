﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_1.Models
{
    public class Ogrenci
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string BilgiGoster()
        {
            return $"{Isim} {SoyIsim}";
        }
    }
}
