using OOPDevam_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDevam_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnYarat_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Isim = "Cagri";
            o.SoyIsim = "Yolyapar";
            LstSonuc.Items.Add(o);
        }

        private void LstSonuc_Click(object sender, EventArgs e)
        {
            //Listbox'ta bir eleman secili olmadıgını SelectedIndex ile de SelectedItem ile de kontrol edebilirsiniz...

            //if(LstSonuc.SelectedIndex > -1) alttaki if kosulunun es anlamlısı gibi düsünebilirsiniz...
            if (LstSonuc.SelectedItem != null)
            {
               LblSonuc.Text = (LstSonuc.SelectedItem as Ogrenci).BilgiGoster(); //Buradaki SelectedItem ListBox'taki secili elemanı yakalamanızı saglar
            }

           
        }
    }
}
