using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMavera Hesap Makinesi");
            Console.WriteLine("Yapmak istediginiz islemi secin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cikarma");
            Console.WriteLine("3. Carpma");
            Console.WriteLine("4. Bolme");
            Console.WriteLine("5. Kare alma");
            Console.WriteLine("6. Karekok alma");
            Console.WriteLine("7. Geometrik hesaplamalar");
            Console.WriteLine("0. Cikis");

            Console.Write("Seciminiz (0-7): ");
            string secim = Console.ReadLine();

            if (secim == "0")
            {
                Console.WriteLine("Cikiliyor...");
                break;
            }
            else if (secim == "1" || secim == "2" || secim == "3" || secim == "4")
            {
                try
                {
                    Console.Write("\nBirinci sayiyi girin: ");
                    double sayi1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nIkinci sayiyi girin: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());

                    switch (secim)
                    {
                        case "1":
                            Console.WriteLine($"\nSonuc: {sayi1} + {sayi2} = {sayi1 + sayi2}");
                            break;
                        case "2":
                            Console.WriteLine($"\nSonuc: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                            break;
                        case "3":
                            Console.WriteLine($"\nSonuc: {sayi1} * {sayi2} = {sayi1 * sayi2}");
                            break;
                        case "4":
                            if (sayi2 != 0)
                                Console.WriteLine($"\nSonuc: {sayi1} / {sayi2} = {sayi1 / sayi2}");
                            else
                                Console.WriteLine("\nBir sayiyi 0'a bolemezsiniz.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\nLutfen gecerli sayilar girin.");
                }
            }
            else if (secim == "5")
            {
                Console.Write("\nSayiyi girin: ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\n{n}^2 = {n * n}");
            }
            else if (secim == "6")
            {
                Console.Write("\nSayiyi girin: ");
                double n = Convert.ToDouble(Console.ReadLine());
                if (n >= 0)
                    Console.WriteLine($"\nKarekoku: √{n} = {Math.Sqrt(n)}");
                else
                    Console.WriteLine("\nNegatif sayilarin karekoku alinamaz.");
            }
            else if (secim == "7")
            {
                Console.WriteLine("Geometrik Sekiller:");
                Console.WriteLine("a. Daire");
                Console.WriteLine("b. Dikdortgen");
                Console.WriteLine("c. Ucgen (alan)");
                Console.Write("Sekil secin (a/b/c): ");
                string geoSecim = Console.ReadLine().ToLower();

                try
                {
                    if (geoSecim == "a")
                    {
                        Console.Write("\nYaricap girin: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        if (r <= 0){
                            Console.WriteLine("\nGecersiz veri girisi");
                        }
                        else{
                            Console.WriteLine($"\nDaire Alani: {Math.PI * r * r:F2}, Cevresi: {2 * Math.PI * r:F2}");
                        }
                    }
                    else if (geoSecim == "b")
                    {
                        Console.Write("\nKisa kenar: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nUzun kenar: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        if (a > b || a<= 0 || b<=0)
                            Console.WriteLine("\nHatali veri girisi.");
                        else if (a == b)
                            Console.WriteLine("\nBu bir karedir.");
                        else
                            Console.WriteLine($"\nDikdortgen Alani: {a * b}, Cevresi: {2 * (a + b)}");
                    }
                    else if (geoSecim == "c")
                    {
                        Console.Write("\nTaban uzunlugu: ");
                        double taban = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nYukseklik: ");
                        double yukseklik = Convert.ToDouble(Console.ReadLine());
                        if (taban <= 0 || yukseklik <= 0){
                            Console.Write("\nGecersiz veri girisi");
                        }
                        else{
                            Console.WriteLine($"\nUcgen Alani: {(taban * yukseklik) / 2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nGecersiz sekil secimi.");
                    }
                }
                catch
                {
                    Console.WriteLine("\nLutfen gecerli sayilar girin.");
                }
            }
            else
            {
                Console.WriteLine("\nGecersiz secim.");
            }
        }
    }
}

