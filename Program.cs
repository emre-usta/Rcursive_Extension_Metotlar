using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli

            //3^4

            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Console.WriteLine("------Rekürsif------");

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            // extension metotlar

            Console.WriteLine("------Extension metotlar------");

            string ifade = "Yunus Emre Usta";
            bool sonuc = ifade.checkSpaces();
            Console.WriteLine(sonuc); 

            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {6,3,8,9,2,4,12,45}; 
            dizi.SortArray();
            dizi.Yazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());
            

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs == 1)
                return sayi;
            return Expo(sayi, üs-1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" "); // boşluk olup olmadığını kontrol etti
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" "); // bu diziyi boşluklarından ayırarak bir diziye al --> split

            return string.Join("", dizi); // string dizisini birleştir whitespaces olmadan
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper(); // Büyük harfe çevir
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower(); // Küçük harfe çevir
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        } 

        public static void Yazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        } 

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        } 

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1); // string karakterleinin 0. indexten 1. indexe kadar olanını yazdır.(1. index dahil değil)(sadece 0. indexteki karakteri bana yazdırır)
        }
    }
}