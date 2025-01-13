using Kutuphane;

class Program
{
    static void Main()
    {
        Kitap kitap1 = new Kitap("aylin","ayşe kulin",398,"remzi kitabevi");
        Kitap kitap2 = new Kitap();

        Console.WriteLine("\nkitap1 Bilgileri:");
        kitap1.BilgileriYazdir();

        Console.WriteLine("\nkitap2 Bilgileri:");
        kitap2.BilgileriYazdir();






    }
}