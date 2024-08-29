using System;

class Program
{
    static void Main()
    {
        // 1. Aşama: 10 adet tam sayı verisi alacak bir dizi tanımla.
        int[] sayilar = new int[10];

        // 2. Aşama: Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdır.
        Random rnd = new Random();
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = rnd.Next(1, 101); // 1 ile 100 arasında rastgele sayılar
        }

        Console.WriteLine("Dizi elemanları:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3. Aşama: Bu diziye kullanıcıdan alınan yeni bir değeri eklenecek (11. eleman olarak)
        Console.Write("Diziye eklemek istediğiniz sayıyı girin: ");
        int yeniSayi = int.Parse(Console.ReadLine());

        // Yeni diziyi tanımla ve eski diziyi kopyala
        int[] yeniSayilar = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniSayilar[i] = sayilar[i];
        }
        yeniSayilar[yeniSayilar.Length - 1] = yeniSayi; // 11. eleman

        // 4. Aşama: Bu diziyi büyükten küçüğe ekrana yazdır.
        Array.Sort(yeniSayilar);
        Array.Reverse(yeniSayilar);

        Console.WriteLine("Dizi büyükten küçüğe sıralanmış:");
        foreach (int sayi in yeniSayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}