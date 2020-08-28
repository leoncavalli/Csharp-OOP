using System;

namespace _3_OOP
{

    // Ogrenci class
  public class Ogrenci
    {
        public int ogrNo { get; set; }
        public string adSoyad { get; set; }
        public string sube { get; set; }

    }


    // Car Class
public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }

        public void getInfo()
        {

            Console.WriteLine($"Brand: {this.brand} , Model: {this.model} , Color: {this.color}");

        }

        public void start()
        {
            Console.WriteLine("Car started to work.");
        }
        public void stop()
        {
            Console.WriteLine("Car stopped.");
        }
        public void speedUp()
        {
            Console.WriteLine("Car has speed up.");
        }
        public void slowDown()
        {
            Console.WriteLine("Car has slown down.");
        }
        public void Menu()
        {
            this.getInfo();

            string cmd = "";
            do
            {
                Console.WriteLine("Choose:\n 1-Start \n 2-Stop \n 3-Speed Up \n 4-Slow Down \n\n Q-Quit");
                cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "1":
                        this.start();
                        break;
                    case "2":
                        this.stop();
                        break;
                    case "3":
                        this.speedUp();
                        break;
                    case "4":
                        this.slowDown();
                        break;
                    default:
                        break;

                }


            }
            while (cmd != "Q");

        }
    }




    // ****MainProgram*****
    class Program
    {
        static void Main(string[] args)
        {
            
            // ********* Class Structure **********

            // Ogrenci Cinar = new Ogrenci()
            // {
            //     adSoyad = "Çınar",
            //     ogrNo = 1290,
            //     sube = "11/C"
            // };
            // Ogrenci Hilal = new Ogrenci()
            // {
            //     adSoyad = "Hilal",
            //     ogrNo = 784,
            //     sube = "11/A"
            // };

            // Ogrenci Bunyamin = new Ogrenci()
            // {
            //     adSoyad = "Bünyamin",
            //     ogrNo = 1140,
            //     sube = "11/A"
            // };


            // Ogrenci[] ogrenciler = new Ogrenci[3];
            // ogrenciler[0] = Cinar;
            // ogrenciler[1] = Hilal;
            // ogrenciler[2] = Bunyamin;



            // for (int i = 0; i < ogrenciler.Length; i++)
            // {
            //     Console.WriteLine($"öğrenci Adı:{ogrenciler[i].adSoyad}");
            //     Console.WriteLine($"öğrenci Şube:{ogrenciler[i].sube}");
            //     Console.WriteLine($"öğrenci Numara:{ogrenciler[i].ogrNo}");
            //     Console.WriteLine("************************");

            // }

            // //for and foreach does same thing but in this case foreach seems to better 

            // foreach (var ogrenci in ogrenciler)
            // {
            //     Console.WriteLine($"öğrenci Adı:{ogrenci.adSoyad}");
            //     Console.WriteLine($"öğrenci Şube:{ogrenci.sube}");
            //     Console.WriteLine($"öğrenci Numara:{ogrenci.ogrNo}");
            //     Console.WriteLine("************************");
            // }
          
            
            //****** Methods **********

            Car car1 = new Car();
            car1.brand = "BMW";
            car1.model = "320d";
            car1.color = "champagne";

            car1.Menu();


            


        }
    }
}

        





