using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RK4_2
{
    /*
    class Kullanici
    {
        /*
        public string Isim { get; set; }
        public string OperatorTuru { get; set; }
        public int InternetKullanım { get; set; }

        public Operator(string name, string tur, int internetKullanım)
        {
            OperatorName = name;
            OperatorTuru = tur;
            InternetKullanım = internetKullanım;
        }
        */
    class Kullanici
    {
        public string Name;
        public string Tarife;
        public double InternetKullanim;

        public Kullanici(string name,string tarife, double internetKullanimi) 
        {
            this.Name = name;
            this.Tarife = tarife;
            this.InternetKullanim = internetKullanimi;

        }


        public void AvantajGoster()
        {
            if (Tarife.ToLower() == "standart")
            {
                StandartTarife standart = new StandartTarife();
                standart.AvantajGoster(InternetKullanim);
            }
            else if (Tarife.ToLower() == "aile")
            {
                AileTarife aile = new AileTarife();
                aile.AvantajGoster(InternetKullanim);
            }
            else if (Tarife.ToLower() == "genç")
            {
                GencTarife genc = new GencTarife();
                genc.AvantajGoster(InternetKullanim);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tarife giriniz.");
            }
        }
    }

    class StandartTarife
    {
        public void AvantajGoster(double internetKullanimi)
        {
            if (internetKullanimi < 10)
            {
                Console.WriteLine("Standart tarife 10 TL indirim kazandınız!");
            }
            else
            {
                Console.WriteLine("Standart tarife 20 TL indirim kazandınız!");
            }
        }
    }

    class AileTarife
    {
        public void AvantajGoster(double internetKullanimi)
        {
            if (internetKullanimi < 10)
            {
                Console.WriteLine("Aile tarife 1000 dakika hediye!");

            }
            else
            {
                Console.WriteLine("Aile tarife sınırsız dakika ve 10 GB ek internet!");
            }
        }
    }

    class GencTarife
    {
        public void AvantajGoster(double internetKullanimi)
        {
            if (internetKullanimi < 10)
            {
                Console.WriteLine("Genç tarife 5 GB sosyal medya interneti hediye!");
            }
            else
            {
                Console.WriteLine("Genç tarife Sınırsız sosyal medya interneti ve 10 TL indirim kazandınız!");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            { 

                //////////// uygulama1/*
                /*onsole.WriteLine("Size nasıl hitap etmemi istersiniz?");
                string name= Console.ReadLine(); 
                
                Console.WriteLine("Lütfen tarifenizi giriniz (Standart, Aile, Genç): ");
                string tarife = Console.ReadLine();

                Console.WriteLine("Lütfen internet kullanımınızı GB cinsinden giriniz: ");
                double internetKullanimi = Convert.ToDouble(Console.ReadLine());

                Kullanici kullanici = new Kullanici(name,tarife, internetKullanimi);
                kullanici.AvantajGoster();
                */


                Console.WriteLine("***Restoran Menüsü***");
                int tutar = 0;

                while (true)
                {
                    Console.WriteLine("1. Pizza - 50 TL");
                    Console.WriteLine("2. Hamburger - 40 TL");
                    Console.WriteLine("3. Salata - 30 TL");
                    Console.WriteLine("4. Makarna - 35 TL");
                    Console.WriteLine("5. Kola - 10 TL");
                    Console.WriteLine("6. Su - 5 TL");
                    Console.WriteLine("7. Çay - 7 TL");
                    Console.WriteLine("8. Çıkış");
                    Console.WriteLine("Lütfen bir seçenek giriniz(1-8)");

                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            tutar += 50;
                            break;
                        case "2":
                            tutar += 40;
                            break;
                        case "3":
                            tutar += 30;
                            break;
                        case "4":
                            tutar += 35;
                            break;
                        case "5":
                            tutar += 10;
                            break;
                        case "6":
                            tutar += 5;
                            break;
                        case "7":
                            tutar += 7;
                            break;
                        case "8":
                            Console.WriteLine($"Toplam tutar: {tutar} TL");
                            Console.WriteLine("Programdan çıkmak için bir tuşa basın...");
                            Console.ReadKey(); 
                            return; 
                        default:
                            Console.WriteLine("Geçersiz seçenek, lütfen tekrar deneyin.");
                            break;
                    }
                }

                Console.WriteLine("Başka bir şey ister misiniz? (evet/hayır)");
                string devam = Console.ReadLine().ToLower();

                if (devam == "hayır")
                {
                    Console.WriteLine($"Toplam tutar: {tutar} TL");
                    Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz");
                    Console.ReadKey();
                }

                Console.ReadLine();
            }
        }
    }
}
