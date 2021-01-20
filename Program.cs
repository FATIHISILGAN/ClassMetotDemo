using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        class Musteri
        {
           public string isimSoyisim;
            public string uid;
           public string tc;


        }
        class MusteriManager
        {
            public void ekle(Musteri musteriEkle)
            {
                Console.WriteLine("Müşteriniz Sisteme eklenmiştir :" + musteriEkle.isimSoyisim);
            }
            public void listele(Musteri musteriListele)
            {
                Console.WriteLine("Müşterileriniz Listelenmiştir ->" + musteriListele.isimSoyisim + "-" + musteriListele.uid  );
            }
            public void silme(Musteri musteriSil)
            {
                Console.WriteLine("Müşteriniz Sistemden Silinmiştir! :" + musteriSil.isimSoyisim + "-" + musteriSil.uid +"-"+ musteriSil.tc);
            }
        }
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.isimSoyisim = "Osman deneme";
            musteri1.tc = "231232321313";
            musteri1.uid = "osman33212";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.ekle(musteri1);
            musteriManager.listele(musteri1);
            musteriManager.silme(musteri1);





        }
    }
}
