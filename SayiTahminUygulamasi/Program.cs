using System;
using System.Collections.Generic;

namespace SayiTahmin
{
    class ZorlukSeviyeleri
    {
        int kod;
        string zorluk, aralık, hak, kpuan;
    }
    class Program
    {

        static void Main(string[] args)
        {
            int girilensayi, tahmin = 0, puan = 0, seviye;
            char cvp;
            void Puanlama()
            {

                if (seviye == 1)
                {
                    Console.WriteLine("+10 Puan Kazandınız");
                    puan = puan + 10;
                }
                else if (seviye == 2)
                {
                    puan = puan + 50;
                    Console.WriteLine("+50 Puan Kazandınız");
                }
                else if (seviye == 3)
                {
                    puan = puan + 100;
                    Console.WriteLine("+100 Puan Kazandınız");
                }
            }
            Random rnd = new Random();
            try
            {
                do
                {
                    int sayac = 1;
                    int hak = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(
                                "////////////////////////////////////////////////////\n" +
                                "Kolay[1]: Aralık 1-50 Hak 10 Kazandırdığı puan: 10\n" +
                                "Orta[2] : Aralık 1-100 Hak 7 Kazandırdığı puan: 50\n" +
                                "Zor[3]  : Aralık 1-200 Hak 5 Kazandırdığı puan: 100\n" +
                                "////////////////////////////////////////////////////\n" +
                                "Zorluk Seviyesi Seçiniz:\n" +
                                "Toplam Puanınız:" + puan);
                        seviye = Convert.ToInt32(Console.ReadLine());
                    } while (seviye != 1 && seviye != 2 && seviye != 3);
                    Console.Clear();
                    switch (seviye)
                    {
                        case 1:
                            tahmin = rnd.Next(1, 50);
                            hak = 10;
                            Console.WriteLine("1 ile 50 arası rastgele bir sayı üretildi. 10 hakkınız bulunmakta.");
                            break;
                        case 2:
                            tahmin = rnd.Next(1, 100);
                            hak = 7;
                            Console.WriteLine("1 ile 100 arası rastgele bir sayı üretildi. 7 hakkınız bulunmakta.");
                            break;
                        case 3:
                            tahmin = rnd.Next(1, 200);
                            hak = 5;
                            Console.WriteLine("1 ile 200 arası rastgele bir sayı üretildi. 5 hakkınız bulunmakta.");
                            break;
                    }
                    hak--;
                    Console.WriteLine("Tutulan sayı:" + tahmin);
                    while (hak >= 0)
                    {
                        Console.WriteLine("Lütfen bir sayı giriniz:");
                        girilensayi = int.Parse(Console.ReadLine());
                        if (girilensayi == tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("TEBRİKLER!!!\n" + sayac + ".denemede bildiniz!");
                            if (sayac == 1)
                            {
                                Console.WriteLine("1. Denemede bildiğiniz için +50 Puan kazandınız.");
                                puan = puan + 50;
                            }
                            Puanlama();
                            break;
                        }
                        else if (girilensayi + 5 > tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Çok Yaklaştınız!!!\nAşağı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
                            Puanlama();
                        }
                        else if (girilensayi > tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Aşağı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
                            Puanlama();
                        }
                        else if (girilensayi + 5 < tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Çok Yaklaştınız!!!\nYukarı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
                            Puanlama();
                        }
                        else if (girilensayi < tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Yukarı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
                            Puanlama();
                        }
                        else if (hak == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Kaybettiniz! Hiç hakkınız kalmadı.");
                            break;
                        }
                        sayac++;
                        hak--;
                    }
                    Console.WriteLine("Toplam Puan:" + puan + "\nTekrar Oynamak için E\nÇıkış için herhangi bir tuşa basınız.");
                    if (hak == 0)
                    {
                        puan = 0;
                    }
                    cvp = char.Parse(Console.ReadLine().ToLower());
                } while (cvp == 'e');
            }
            catch (FormatException)
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
        }
    }
}