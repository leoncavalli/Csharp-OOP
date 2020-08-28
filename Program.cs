using System;

namespace _3_OOP
{
  public class Ogrenci
    {
        public int ogrNo { get; set; }
        public string adSoyad { get; set; }
        public string sube { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci Cinar = new Ogrenci()
            {
                adSoyad = "Çınar",
                ogrNo = 1290,
                sube = "11/C"
            };
            Ogrenci Hilal = new Ogrenci()
            {
                adSoyad = "Hilal",
                ogrNo = 784,
                sube = "11/A"
            };

            Ogrenci Bunyamin = new Ogrenci()
            {
                adSoyad = "Bünyamin",
                ogrNo = 1140,
                sube = "11/A"
            };


            Ogrenci[] ogrenciler = new Ogrenci[3];
            ogrenciler[0] = Cinar;
            ogrenciler[1] = Hilal;
            ogrenciler[2] = Bunyamin;



            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"öğrenci Adı:{ogrenciler[i].adSoyad}");
                Console.WriteLine($"öğrenci Şube:{ogrenciler[i].sube}");
                Console.WriteLine($"öğrenci Numara:{ogrenciler[i].ogrNo}");
                Console.WriteLine("************************");

            }

            //for and foreach does same thing but in this case foreach seems to better 

            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"öğrenci Adı:{ogrenci.adSoyad}");
                Console.WriteLine($"öğrenci Şube:{ogrenci.sube}");
                Console.WriteLine($"öğrenci Numara:{ogrenci.ogrNo}");
                Console.WriteLine("************************");
            }
           


        }
    }
        
}
