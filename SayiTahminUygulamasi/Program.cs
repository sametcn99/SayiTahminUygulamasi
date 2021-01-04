using System;

namespace SayiTahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilensayi;
            int tahmin = 0;
            int sayac = 1;
            int hak = 0;
            int seviye;
            char cvp;
            Random rnd = new Random();
            try
            {

                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(
                                "////////////////////////////\n" +
                                "Kolay[1]: Aralık 1-10 Hak 5\n" +
                                "Orta[2] : Aralık 1-25 Hak 3\n" +
                                "Zor[3]  : Aralık 1-10 Hak 1\n" +
                                "////////////////////////////\n" +
                                "Zorluk Seviyesi Seçiniz:");
                        seviye = Convert.ToInt32(Console.ReadLine());
                    } while (seviye != 1 && seviye != 2 && seviye != 3);
                    Console.Clear();
                    //if (seviye >= 1 && seviye <= 3)
                    //{
                    //    Console.WriteLine("Zorluk seviyesi:" + seviye);
                    //    if (seviye == 1)
                    //    {
                    //        tahmin = rnd.Next(1, 10);
                    //        hak = 4;
                    //        Console.WriteLine("1 ile 10 arası rastgele bir sayı üretildi. 5 hakkınız bulunmakta.");
                    //    }
                    //    else if (seviye == 2)
                    //    {
                    //        tahmin = rnd.Next(1, 25);
                    //        hak = 2;
                    //        Console.WriteLine("1 ile 25 arası rastgele bir sayı üretildi. 3 hakkınız bulunmakta.");
                    //    }
                    //    else if (seviye == 3)
                    //    {
                    //        tahmin = rnd.Next(1, 50);
                    //        hak = 0;
                    //        Console.WriteLine("1 ile 50 arası rastgele bir sayı üretildi. 1 hakkınız bulunmakta.");
                    //    }
                    //}
                    switch (seviye)
                    {
                        case 1:
                            tahmin = rnd.Next(1, 10);
                            hak = 4;
                            Console.WriteLine("1 ile 10 arası rastgele bir sayı üretildi. 5 hakkınız bulunmakta.");
                            break;
                        case 2:
                            tahmin = rnd.Next(1, 25);
                            hak = 2;
                            Console.WriteLine("1 ile 25 arası rastgele bir sayı üretildi. 3 hakkınız bulunmakta.");
                            break;
                        case 3:
                            tahmin = rnd.Next(1, 50);
                            hak = 0;
                            Console.WriteLine("1 ile 50 arası rastgele bir sayı üretildi. 1 hakkınız bulunmakta.");
                            break;
                    }
                    //Console.WriteLine("tutulan sayı:" + tahmin);

                    while (hak >= 0)
                    {
                        Console.WriteLine("Lütfen bir sayı giriniz:");
                        girilensayi = Convert.ToInt32(Console.ReadLine());
                        if (girilensayi == tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("TEBRİKLER!!!\n" + sayac + ".denemede bildiniz!");
                            break;
                        }
                        else if (girilensayi > tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Aşağı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
                        }
                        else if (girilensayi < tahmin)
                        {
                            Console.Clear();
                            Console.WriteLine("Zorluk seviyesi:" + seviye);
                            Console.WriteLine("Yukarı!\n" + sayac + ". hakkınızı kullandınız. Kalan hak:" + hak);
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
                    Console.WriteLine("Tekrar Oynamak için E\nÇıkış için herhangi bir tuşa basınız.");
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