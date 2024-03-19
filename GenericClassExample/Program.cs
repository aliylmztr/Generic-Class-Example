using System;
using System.Collections.Generic;

namespace GenericClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            List<Musteri> musterilerim = repositoryMusteri.getir();

            string cikti1 = repositoryMusteri.ekle(new Musteri());

            Console.WriteLine(cikti1);

            Repository<Urun> repositoryUrun = new Repository<Urun>();
            List<Urun> urunlerim = repositoryUrun.getir();

            string cikti2 = repositoryUrun.ekle(new Urun());

            Console.WriteLine(cikti2);

            Console.ReadLine();
        }
    }
}
