using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri eklenmiştir.");
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine("----------------");
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri silinmiştir.");
        }
    }
}
