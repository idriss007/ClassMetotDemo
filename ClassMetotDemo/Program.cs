using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { };

            musteri1.Id = 1;
            musteri1.Ad = "Emre";
            musteri1.Soyad = "Topal";

            Musteri musteri2 = new Musteri() { };

            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Ak";

            Musteri musteri3 = new Musteri() { };

            musteri3.Id = 3;
            musteri3.Ad = "Veli";
            musteri3.Soyad = "Kaya";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);

            musteriManager.MusteriListeleme(musteriler);

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);
        }
    }
}
