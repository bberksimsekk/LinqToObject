using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //LINQ(Language Integrated Query)
            //Dil ile tümleşik sorgu
            //Veri KOLEKSİYONLARINI sorgulamak, verileri filtrelemek veya dönüştürmek gibi işlemleri kolaylaştıran güçlü bir teknolojidir.
            //.NET 3.0 ile hayatımıza girmiştir.

            //LINQ Kullanımının Ana Başlıkları
            //1- LINQ TO OBJECT
            //2- LINQ TO SQL
            //3- LINQ TO ENTITIES

            #endregion

            #region Lambda Expressions

            ////Lambda expressions koleksiyon üzerinde kullanılabilecek koşulları sorgu olarak ele almamızı sağlayan yapıdır.

            //List<int> Sayılar = new List<int>();
            //Sayılar.AddRange(new int[] { 12, 5, 20, 23, -3, -10, -31, 45, 10 });

            ////Sayılar koleksiyonun içerisindeki negatif sayıları yazdırınız.

            ////for (int i = 0; i < Sayılar.Count; i++)
            ////{
            ////    if (Sayılar[i] < 0)
            ////    {
            ////        Console.WriteLine(Sayılar[i]);
            ////    }
            ////}

            //// Lambda ile Kullanım
            ////=> Lambda Operatörü

            //List<int> Negatifler = Sayılar.Where(x => x < 0).ToList();

            //foreach (var item in Negatifler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            List<int> Sayılar = new List<int>();
            Sayılar.AddRange(new int[] { 12, 5, 20, 23, -3, -10, -31, 45, 10 });

            #region MAX-MIN-AVERAGE-SUM

            Console.WriteLine("En Büyük = " + Sayılar.Max()); //MAX
            Console.WriteLine("En Küçük = " + Sayılar.Min()); //MIN
            Console.WriteLine("Ortalama = " + Sayılar.Average()); //AVERAGE
            Console.WriteLine("Toplam = " + Sayılar.Sum()); //SUM

            #endregion

            #region Where

            //Liste döndürür.
            //List<int> Pozitifler = Sayılar.Where(x => x >= 0).ToList();
            //Console.WriteLine("Pozitiflerin Ortalaması = " + Sayılar.Where(x => x >= 0).Average());

            #endregion

            #region First-Last

            ////Tek bir eleman döndürür.

            //Console.WriteLine("İlk Negatif Elemanı = " + Sayılar.First(x => x < 0));
            //Console.WriteLine("Son Negatif Elemanı = " + Sayılar.Last(x => x < 0));

            //Console.WriteLine("İlk Pozitif Elemanı = " + Sayılar.First(x => x >= 0));
            //Console.WriteLine("Son Pozitif Elemanı = " + Sayılar.Last(x => x >= 0));

            ////Console.WriteLine(Sayılar.First(x => x > 100));//Eğer koşula uygun değer bulunamazsa InvalidOperationException hatası alınır.
            ////Console.WriteLine(Sayılar.FirstOrDefault(x => x > 100));

            #endregion

            #region Count-Contains

            //COUNT
            Console.WriteLine("Eleman Sayısı = " + Sayılar.Count);
            Console.WriteLine("Pozitif Eleman Sayısı = " + Sayılar.Count(x => x >= 0));

            //int Sayı = Sayılar.Count(x => x > 100);
            //if (Sayı > 0)
            //{
            //    Console.WriteLine(Sayılar.First(x => x > 100));
            //}
            //else
            //{
            //    Console.WriteLine("Bulunamadı");
            //}

            //CONTAINS
            //bool varmi = Sayılar.Contains(45);
            //Console.WriteLine("45 Sayısı Var mı ? = " + varmi);

            #endregion

            #region All-Any

            //ALL
            //Console.WriteLine("Tüm Sayılar Pozitif Mi ? = " + Sayılar.All(x => x > 0));
            //Console.WriteLine("Tüm Sayılar Negatif Mi ? = " + Sayılar.All(x => x < 0));

            //ANY
            //Console.WriteLine("Herhangi Bir Sayı 100'den büyük mü ? = " + Sayılar.Any(x => x > 100));
            //Console.WriteLine("Herhangi Bir Sayı 100'den küçük mü ? = " + Sayılar.Any(x => x < 100));

            #endregion

            #region OrderBy-Reverse

            //OrderBy
            //foreach (int item in Sayılar.OrderBy(x => x))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (int item in Sayılar.OrderByDescending(x => x))
            //{
            //    Console.WriteLine(item);
            //}

            //Reverse
            Sayılar.Reverse();
            foreach (int item in Sayılar)
            {
                Console.WriteLine(item);
            }

            #endregion

            List<Personel> Personeller = new List<Personel>();
            Personeller.Add(new Personel() { No = 100, Isim = "Murtaza", Soyisim = "Şuayipoğlu", IseGirisTarihi = Convert.ToDateTime("20/10/2010"), Durum = true });
            Personeller.Add(new Personel() { No = 101, Isim = "Döndü Nur", Soyisim = "Falcıoğlu", IseGirisTarihi = Convert.ToDateTime("10/08/2012"), Durum = true });
            Personeller.Add(new Personel() { No = 102, Isim = "Beyza Nur", Soyisim = "Civrek", IseGirisTarihi = Convert.ToDateTime("12/08/2011"), Durum = true });
            Personeller.Add(new Personel() { No = 103, Isim = "Dilara Gül", Soyisim = "Şalvaroğlu", IseGirisTarihi = Convert.ToDateTime("22/11/2015"), Durum = true });
            Personeller.Add(new Personel() { No = 104, Isim = "Alp", Soyisim = "Sarıkışla", IseGirisTarihi = Convert.ToDateTime("01/01/2008"), Durum = true });
            Personeller.Add(new Personel() { No = 105, Isim = "Volkan", Soyisim = "Şekeroğlu", IseGirisTarihi = Convert.ToDateTime("02/02/2022"), Durum = false });
            Personeller.Add(new Personel() { No = 106, Isim = "Furkan", Soyisim = "Koçakoğlu", IseGirisTarihi = Convert.ToDateTime("03/03/2023"), Durum = false });
            Personeller.Add(new Personel() { No = 107, Isim = "Mevlüt", Soyisim = "Çalışkanoğlu", IseGirisTarihi = Convert.ToDateTime("01/07/2016"), Durum = true });
            Personeller.Add(new Personel() { No = 108, Isim = "Samet", Soyisim = "Hasanoğlu", IseGirisTarihi = Convert.ToDateTime("03/07/2016"), Durum = true });
            Personeller.Add(new Personel() { No = 109, Isim = "Kazuha", Soyisim = "Nakamura", IseGirisTarihi = Convert.ToDateTime("01/01/2020"), Durum = true });
            Personeller.Add(new Personel() { No = 110, Isim = "Sakura", Soyisim = "Miyawaki", IseGirisTarihi = Convert.ToDateTime("01/01/2020"), Durum = true });

            #region Çalışan Personellerin Listesi

            //Personeller.Where(p => p.Durum == true).ToList().ForEach(x => Console.WriteLine(x.No + " " + x.Isim + " " + x.Soyisim));

            //foreach (Personel item in Personeller.Where(p => p.Durum))
            //{
            //    Console.WriteLine(item.No + " " + item.Isim + " " + item.Soyisim);
            //}

            #endregion

            #region 5 Yıl Üstü Çalışan Personel Listesi

            DateTime Tarih = DateTime.Now.AddYears(-5);

            List<Personel> BeşYıllık = Personeller.Where(x => x.IseGirisTarihi < Tarih).ToList();

            foreach (Personel item in BeşYıllık)
            {
                Console.WriteLine(item.No + " " + item.Isim + " " + item.Soyisim);
            }

            #endregion

            #region Select New

            var a = from x in Personeller select new { pers = x.Isim + " " + x.Soyisim + " " + (x.Durum ? "Aktif" : "Pasif") };

            foreach (var item in a)
            {
                Console.WriteLine(item.pers);
            }

            #endregion

        }
    }
}
