namespace Diziler
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Sınırlılıklar
            //Diziler oluşturulurken eleman sayısını vermek zorundayız.
            //Dizilerdeki sınırlılıkları,performans kayıplarını minimalize etmek için koleksiyonlar vardır.
            #endregion

            #region Dizi Tanımlama

            //int[] Yaslar = new int[25];
            //string[] Isımler = new string[25];
            #endregion

            #region Değer Atama
            Yaslar[3] = 18;
            Yaslar[4] = 19;
            //Yaslar[25] = 21;    25 elemanlı dizide son index 24'tür.Çünkü dizilerde ilk index 0'dan başlar.
            #endregion

            #region Değer Okuma

            Console.WriteLine(Yaslar[3]);
            Console.WriteLine(Yaslar[19]);   //Değer atamadıklarımızı 0 olarak yazdırır.
            #endregion

            #region Döngüyle Dizi İçerisinde Dönme

            //for (int i = 0; i < Yaslar.Length; i++)    Sayıyı yazmak yerine Yaslar.Length demek kolaylık sağlar.
            //{
            //    Yaslar[i] = i * 2;
            //}

            //for (int i = 0; i < Yaslar.Length; i++)    
            //{
            //    Console.WriteLine(Yaslar[i]);
            //}
            #endregion

            #region Varyasyonlar

            int[] x = new int[] { 12, 5, 32, 2, 34, 34, 23, 234, 35, 32, 2, 34, 23, 23, 32, 35, 34, 3, 3 };
            int[] y = { 12, 321, 123 }; 
            #endregion
        }
    }
}
