using OOPDevam_1.Tools;
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
    public partial class Form2 : Form
    {

        //Brans ekle butonuna basıldıgında bir Brans yaratılıp LstBrans'a eklenecek (aynı şekilde LstBrans'a tıklandıgında bir Brans nesnesi seciliyse ben o bransın ismini LblBrans'ta görebileyim)...Egitmen Ekle butonuna basıldıgında ise önce bir brans secilmiş mi diye kontrol edilecek ve eger bir brans secilmişse egitmen yaratılıp o bransa eklenecek ve Egitmen de tabii ki kendi branslarında secilmiş olan Brans'ı barındıracak...Aynı şekilde LstEgitmenler'den bir nesne secilirse LblEgitmen'de Egitmenin ismi soyismi ve bransları gözükecek... Mevcut durumda Egitmen yaratıldıktan sonra o Egitmen'e baska bir brans eklenemiyormus gibi gözükebilir simdilik o canınızı sıkmasın.

        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            Brans b = new Brans();
            b.Isim = TxtBrans.Text;
            b.Egitmenler = new List<Egitmen>();
            LstBranslar.Items.Add(b);
        }

        private void LstBranslar_Click(object sender, EventArgs e)
        {
            if(LstBranslar.SelectedItem != null)
            {
                BransLabelGuncelle();
            }
        }

        private void BtnEgitmenEkle_Click(object sender, EventArgs e)
        {
            if(LstBranslar.SelectedItem != null)
            {
                Egitmen egt = new Egitmen();
                egt.Isim = TxtIsim.Text;
                egt.SoyIsim = TxtSoyIsim.Text;
                egt.Branslari = new List<Brans>();

                (LstBranslar.SelectedItem as Brans).Egitmenler.Add(egt); //ListBox'ta secili olan Brans'a yarattıgımız Egitmen'i ekliyoruz...

                egt.Branslari.Add(LstBranslar.SelectedItem as Brans); //BUrada ise yarattıgımız Egitmen'in Branslar listesine ListBox'ta secili olan Brans'i ekliyoruz...Class'ların birbirlerini tanıdıgı birbirleriyle ilişkiye girdigi bu durumlarda nesneleri tek taraflı ekleyemeyiz...İki tarafta birbirlerini nesne olarak da tanımak zorundadır...

                LstEgitmenler.Items.Add(egt);
                BransLabelGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen Egitmen eklemeden önce bir brans seciniz");
            }
        }

        private void LstEgitmenler_Click(object sender, EventArgs e)
        {
            if(LstEgitmenler.SelectedItem != null)
            {
                EgitmenLabelGuncelle();
            }
        }

        private void EgitmenLabelGuncelle()
        {
            LblEgitmen.Text = (LstEgitmenler.SelectedItem as Egitmen).TamBilgiGoster();
        }

        private void BransLabelGuncelle()
        {
            LblBrans.Text = (LstBranslar.SelectedItem as Brans).TamBilgiGoster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Bu buttonun amacı var olan bir Egitmeni bir Brans'a eklemek olsun...Eger bir Brans'ta aynı egtimen  varsa zaten bu egitmen vardır densin ve eklenemesin
            if(LstBranslar.SelectedItem != null && LstEgitmenler.SelectedItem != null)
            {
                Brans seciliBrans = LstBranslar.SelectedItem as Brans;
                Egitmen seciliEgitmen = LstEgitmenler.SelectedItem as Egitmen;

                if (seciliBrans.Egitmenler.Contains(seciliEgitmen))
                {
                    MessageBox.Show("Bu egitmen zaten bu bransta bulunuyor");
                }
                else
                {
                    seciliBrans.Egitmenler.Add(seciliEgitmen);
                    seciliEgitmen.Branslari.Add(seciliBrans);
                    BransLabelGuncelle();
                    EgitmenLabelGuncelle();
                }
            }
        }
    }
}
