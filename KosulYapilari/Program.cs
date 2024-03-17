namespace KosulYapilari
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 15;

            //if(x > 15)
            //{
            //    //Koşul doğruysa burası çalışır.
            //} 
            //else
            //{
            //   //Koşul yanlışsa burası çalışır.
            //}

            bool Yagmur = true;

            if(Yagmur)
            {
                Console.WriteLine("Şemsiye al");    //Burayı yazdırır.
            }
            else
            {
                Console.WriteLine("Şemsiye alma");
            }
            //Eğer if(!Yagmur) yazarsak Şemsiye alma yazdırır. Çünkü bu Yagmur'un değili anlamına gelir ve sonucu false'dir.

            //If blokları tek satırsa süslü parantez kullanmaya gerek yoktur.
        }
    }
}
