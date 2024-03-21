namespace Donguler
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for (int i = 0; i < 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            int j;
            for (j = 0; j < 100;j++) 
            {
                Console.WriteLine(j);
            }
            #endregion

            #region While Döngüsü

            for (int i = 0;i < 100;i++) 
            {
                Console.WriteLine("Yağız");
            }

            bool Kosul = true;
            int Sayac = 1;
            while(Kosul)
            {
                if(Sayac <= 100)
                {
                    Console.WriteLine("Yağız");        //Bir sayaç koyup onu arttırma işlemi yapmazsak sonsuza kadar yazdırır.
                }
                else
                {
                    Kosul = false;
                }
                Sayac++;
                                 //Burada bir sayaç girdik ve 1 den başlattık. 100'e kadar artarak gitti ve kurala her uyduğunda ismimizi yazdırdı.
                                 //100'ü aştığı zaman Kosul = false; eşitliği sağladık.
            }
            #endregion

            #region Do While Döngüsü

            bool Kosul2 = false;
            while(Kosul2)
            {
                Console.WriteLine("Yağız");  //Şarta bakıyor ve uymadığı için yazdırmıyor.
            }

            do
            {
                Console.WriteLine("Yağız");  //Bir kere yazdırır sonra şarta bakar.Şartın uymadığını gördüğü için bir daha yazdırmaz.

            } while (Kosul2);
            #endregion
        }
    }
}
