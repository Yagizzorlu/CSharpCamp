namespace TypeConversion
{
    class Program
    {
        public static void main(String[] args)
        {
            #region Tip Cevrimleri
            //string x = "123";
            //int y = Convert.ToInt32(x);    Methoddur ve içine veri girmemizi istiyor. X'i int hale çevirdi.

            //string a = "12f3";
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b);      Burada çalışma zamanı hatası alırız.

            //double d = 123.2;
            //string c = Convert.ToString(d);
            //Console.WriteLine(c);

            bool e = true;
            string f = Convert.ToString(e);
            Console.WriteLine(f);        //True yazdırır.

            string m = "True";
            bool n = Convert.ToBoolean(m);
            Console.WriteLine(n);      //True yi bool türünde yazdırır.

            //Parse methodu sadece string'e doğru çevirme yapar.
            #endregion

            #region int - char Casting

            char g = 'a';
            int h = Convert.ToInt32(g);
            Console.WriteLine(h);        //ASCII kodlarına karşılık gelir.

            int q = 121;
            int p = Convert.ToChar(q);
            Console.WriteLine(p);
            #endregion

            #region Bilinçsiz Tür Dönüşümü   küçük tip ---> büyük tip
            //byte x = 125;
            //int y = x;
            #endregion

            #region Bilinçli Tür Dönüşümü    büyük tip ---> küçük tip

            //int x = 1255;
            //byte y = (byte)x;   Çalıştırınca 231 yazdırır. Kendi değer alanının modunu alır Byte. Veri kaybı oluyor.
            #endregion

            #region Checked 
            {
                int x = 1255;
                byte y = (byte)x;       //veri kaybı varsa burası hata verir.  
                Console.WriteLine(y);
            }
            #endregion

            #region Unchecked
            {
                int x = 1255;
                byte y = (byte)x;       //veri kaybı varsa burası hata vermez. 
                Console.WriteLine(y);
            }
            #endregion 
        }
    }
}
