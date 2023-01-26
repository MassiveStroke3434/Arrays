using System;

namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];
        string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};
        int[] dizi;
        dizi = new int[5];

        // Dizilere Değer Atama ve Erişim

        renkler[0] = "Mavi";        
        dizi[3]=10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle dizi kullanımı
        //Take the length information from user
        Console.WriteLine("Please enter the length of the list:");
        int length_list = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[length_list];
        for (int i = 0; i < length_list; i++)
        {
            Console.WriteLine("Please enter the {0} value.", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());            
        }
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;         
        }
        Console.WriteLine("Ortalama:"+ toplam/length_list); 
    }
}
