internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("1-N arası Gireceğiniz İki Sayıya Tam Bölünen Sayıları Listeleme Programı");

        tepe:
        try
        {
        
        Console.Write("N'yi Giriniz : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("1. Sayıyı Giriniz : ");
        int birinci = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");

        Console.Write("2. Sayıyı Giriniz : ");
        int ikinci = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("");
        Console.WriteLine("1 ve "+n +" Arasında " + birinci + " ve " + ikinci + " 'in Tam Bölündüğü Sayılar : ");

            for (int i = 1; i <= n; i++)
        {
            if (i % birinci == 0 && i % ikinci == 0)
            {
                
                Console.WriteLine(i);
            }
        }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
            goto tepe;
        }
        Console.ReadLine();
    }
}
