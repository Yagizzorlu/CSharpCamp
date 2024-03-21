namespace BreakContinueReturn
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Break
            //Break komutu switch ve döngülerde kullanılır.
            //switch(10)
            //{
            //    case 5:
            //        break;
            //    case 6:
            //        break;
            //    case 10:
            //        break;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    break;               sadece 0'ı yazdırır.Break'i dönünce döngüden çıkar.
            //}

            for (int j = 0;j < 10; j++) 
            {
                Console.WriteLine(j);
                if(j == 5)
                {
                    break;
                }
            }

            //for (int i = 0; i < 10;i++)
            //{
            //    if(true)
            //    {
            //        if(true)
            //        {
            //            if(true)
            //            {
            //                break;     //İçerisinde kullanılan döngüden çıkar.
            //            }
            //        }
            //    }
            //}

            for (int i = 0; i <10; i++) 
            {
                for(int j = 0; j < 10; j++)
                {
                    //break; buraya yazarsak sadece i'ye ait olan döngü döner ve buradaki j döngüsü yazdırılmaz.

                    Console.WriteLine(j + "-j");     //Önce 9-j ye kadar yazdırır sonra 0-i yazar sonra tekrar 9-j ye kadar yazdırıp 1-i yazar.
                                                     //Böyle şekilde 9-i ye kadar devam eder.
                }
                Console.WriteLine(i + "-i");
            }

            #endregion

            #region Continue

            bool Kosul = true;
            int Sayac = 1;

            while(Kosul)
            {
                if(Sayac == 6)
                {
                    Sayac++;    //Sayac 6 olduğunda sayac'ı arttırır ve devam eder. Yani 6'yı yazdırmaz.
                    continue;
                }
                Console.WriteLine(Sayac);
                Sayac++;
                if(Sayac == 15)
                {
                    Kosul = false;    //Sayac++ sonrası 15 olduğu zaman döngüye girer ve false haline gelir. Bu da artık döngünün duracağı anlamına gelir.
                }
            }
            #endregion

            #region Return

            //her yerde kullanılabilir. Compiler,return'ı görünce içerisinde bulunan methoddan çıkmaktadır.
            #endregion
        }
    }
}
