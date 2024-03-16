namespace Intro
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Var Tipi
            int x = 123;
            int y = x;

            var a = "Yağız";   //a artık string'e büründü.
            var b = 123;
            #endregion

            #region Object Tipi
            object c = "";
            object d = 124;    //var dinamik bir tiptir.Object ise normal bir değişken tipidir.İçine verilen her değeri alabilir.

            object Eleman = "Yağız";        //Object bir tipe herhangi veri göndermek "BOXING" dir.
            string z = (string)Eleman;    //İçerideki elemanı kendi veri tipiyle dışarı çıkarıyoruz. Buna "UNBOXING" denir.
            #endregion                 
        }
    }
}

