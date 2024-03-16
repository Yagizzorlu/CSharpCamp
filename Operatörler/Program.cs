namespace Operatörler
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetik Operatörler

            //int x = 5;
            //double y = 6;
            //double Sonuc = x + y;    Büyük olanın sonucuna döndürecek.
            //double Sonuc2 = 100 % 5;

            int x = 15;
            //x = x - 1;
            //x--;
            //--x;
            Console.WriteLine(++x);  // 16 yazdırdı. Önce arttırır sonra değeri yazdırır.
            Console.WriteLine(x++);  // 15 yazdırdı. Önce yazdırır sonra değeri arttırır.
                                     //Altında x'i tekrar yazdırmak istersek değeri arttırmış şekilde yazdırır x++ komutu.
            #endregion

            #region Karşılaştırma Operatörleri
            int a = 15;
            int b = 25;

            bool Sonuc = a != b;
            Console.WriteLine(Sonuc);   //sonuc true ya da false döner.
            #endregion

            #region Mantıksal Operatörler
            int sayi1 = 10;
            int sayi2 = 20;
            bool Sonuc2 = (sayi1 > sayi2) && (sayi2 % 5 == 3);      //Bu işaret "ve" anlamına gelir. İki durum da true olmadığı sürece sonuç true gelmez.

            int sayi3 = 10;
            int sayi4 = 20;
            bool Sonuc3 = (sayi1 > sayi2) || (sayi2 % 5 == 3);    //Bu işaret "veya" anlamına gelir. Bir tanesi true gelmesi yeterli.

            #endregion
        }
    }
}
