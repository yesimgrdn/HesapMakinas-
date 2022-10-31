namespace HesapMakinesi
{
    class HesapMakinesi
    {
        public static double islemYap(double sayi1, double sayi2, string op)
        {

            switch (op)
            {
                case "+": return sayi1 + sayi2;
                case "-": return sayi1 - sayi2;
                case "*": return sayi1 * sayi2;
                case "/":

                    if (sayi2 != 0)
                    {
                        return sayi1 / sayi2;
                    }
                    else
                    {
                        return double.NaN;
                    }
                default: return double.NaN;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            Console.WriteLine("Hesap Makinası \r");
            Console.WriteLine("------------------------\n");

            while (!cikis)
            {
                // Değişkenleri tanımlıyoruz ve boş olarak atıyoruz.
                string sayi1 = "";
                string sayi2 = "";
                double sonuc = 0;

                // Kullanııcıdan birinci sayıyı girmesini istiyoruz
                Console.Write("Birinci Sayıyı Giriniz: ");
                sayi1 = Console.ReadLine();

                double dogruSayi1 = 0;
                while (!double.TryParse(sayi1, out dogruSayi1))
                {
                    Console.Write("Bu geçerli bir sayı değil. Lütfen bir tamsayı giriniz.: ");
                    sayi1 = Console.ReadLine();
                }

                // Kullanııcıdan ikinci sayıyı girmesini istiyoruz
                Console.Write("İkinci Sayıyı Giriniz: ");
                sayi2 = Console.ReadLine();

                double dogruSayi2 = 0;
                while (!double.TryParse(sayi2, out dogruSayi2))
                {
                    Console.Write("Bu geçerli bir sayı değil. Lütfen bir tamsayı giriniz. ");
                    sayi2 = Console.ReadLine();
                }

                // İşlem Seçim Bölümü
                Console.WriteLine("Lütfen Listeden bir işlem seçiniz:");
                Console.WriteLine("\t+ - Toplama");
                Console.WriteLine("\t- - Çıkarma");
                Console.WriteLine("\t* - Çarpma");
                Console.WriteLine("\t/ - Bölme");
                Console.Write("Seçiminiz? ");

                string op = Console.ReadLine();

                try
                {
                    sonuc = HesapMakinesi.islemYap(dogruSayi2, dogruSayi1, op);
                    if (double.IsNaN(sonuc))
                    {
                        Console.WriteLine("Bu işlem matematiksel bir hataya neden oldu.\n");
                    }
                    else Console.WriteLine("Sonucunuz: {0:0.##}\n", sonuc);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sonucu hesaplarken bir istisna oluştu \n: " + e.Message);
                }

                Console.WriteLine("------------------------\n");


                Console.Write("Uygulamadan Çıkmak İçin ESC tuşuna basınız. ");
                if (Console.ReadKey().Key == ConsoleKey.Escape) cikis = true;

                Console.WriteLine("\n");
            }
            Console.WriteLine("Program Bitti Bir tuşa basınız\n");
            Console.ReadKey();
        }
    }

}
