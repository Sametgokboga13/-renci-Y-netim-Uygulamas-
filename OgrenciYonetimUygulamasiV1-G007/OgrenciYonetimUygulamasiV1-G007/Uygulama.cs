using System;
using System.Collections.Generic;


namespace OgrenciYonetimUygulamasiV1_G007
{
    class Uygulama
    {

        List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void Calistir()
        {
            string giris = "";

            switch (giris)
            {
                case "1":
                case "e":
                    OgrenciEkle();
                    break;
                case "2":
                case "s":
                    OgrenciSil();
                    break;

            }






            SahteVeriGir();
            Console.WriteLine();
            OgrenciListele();
            Console.WriteLine();
            OgrenciEkle();
            Console.WriteLine();
            OgrenciListele();
            Console.WriteLine();
            OgrenciSil();
            Console.WriteLine();
            OgrenciListele();
        }


        public void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Ahmet";
            o1.Soyad = "Melik";
            o1.No = 1;
            o1.Sube = "A";
            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Mehmet";
            o2.Soyad = "Yıldırım";
            o2.No = 2;
            o2.Sube = "A";
            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Arif";
            o3.Soyad = "Susam";
            o3.No = 3;
            o3.Sube = "B";

            Ogrenciler.Add(o1);
            Ogrenciler.Add(o2);
            Ogrenciler.Add(o3);

        }














        public void OgrenciEkle()
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("1- Öğrenci Ekle -----------");
            Console.WriteLine("Öğrencinin");
            Console.Write("No: ");
            ogr.No = int.Parse(Console.ReadLine());
            Console.Write("Adı: ");
            ogr.Ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            ogr.Soyad = Console.ReadLine();
            Console.Write("Şubesi: ");
            ogr.Sube = Console.ReadLine();
            Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
            string giris = Console.ReadLine();


            if (giris.ToLower() == "e")
            {
                Ogrenciler.Add(ogr);
            }
        }



        public void OgrenciSil()
        {
            Console.WriteLine("2- Öğrenci Sil----------");
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());
            Ogrenci ogr = null;
            foreach (Ogrenci item in Ogrenciler)
            {
                if (no == item.No)
                {
                    ogr = item;
                    break;
                }
            }

            if (ogr == null)
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı.");
            }
            else
            {
                Console.WriteLine("Adı: " + ogr.Ad);
                Console.WriteLine("Soyadı: " + ogr.Soyad);
                Console.WriteLine("Şubesi: " + ogr.Sube);
                Console.WriteLine();
                Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                string giris = Console.ReadLine().ToLower();
                if (giris == "e")
                {
                    Ogrenciler.Remove(ogr);
                }
            }
        }

        public void OgrenciListele()
        {
            Console.WriteLine("3- Öğrenci Listele---------");
            Console.WriteLine();

            Console.WriteLine("Şube    No    Ad Soyad");
            Console.WriteLine("-----------------------");
            foreach (Ogrenci item in Ogrenciler)
            {
                Console.WriteLine(item.Sube + " " + item.No + " " + item.Ad + " " + item.Soyad);
            }
        }





    }
}
