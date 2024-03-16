namespace SwitchCase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 11;
            switch (x)
            {
                case 3:
                    //..
                    break;
                case 13:
                    //..
                    break;
                case 10:
                    Console.WriteLine("Değerimiz 10");
                    break;
                default:
                    Console.WriteLine("her durumda çalışan bloktur.");   //case bloklarından hiçbiri çalışmıyorsa burası çalışır. Ama x = 10; dedik bu yüzden case 10: çalışır.Default çalışmaz.
                    break;
            }
        }
    }
}

