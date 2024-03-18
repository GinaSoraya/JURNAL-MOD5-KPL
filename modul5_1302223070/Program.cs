// See https://aka.ms/new-console-template for more information

class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        Console.WriteLine(x + y + z);
    }
    public static void Main(string[] args)
    {
        Penjumlahan.JumlahTigaAngka<long>(13, 02, 22);
    }
}
    
