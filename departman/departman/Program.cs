using System;

public class Departman
{
    public string Ad { get; set; }
    public string Lokasyon { get; set; }

    public Departman(string ad, string lokasyon)
    {
        Ad = ad;
        Lokasyon = lokasyon;
    }

    public override string ToString()
    {
        return $"Departman Adı: {Ad}, Lokasyon: {Lokasyon}";
    }
}

public class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public Departman Departman { get; private set; } // Çalışanın bağlı olduğu departman

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }

    public override string ToString()
    {
        return $"Ad: {Ad}, Pozisyon: {Pozisyon}, Departman: {Departman}";
    }
}

class Program
{
    static void Main()
    {
        // Departman örneği oluşturma
        Departman yazilimDepartmani = new Departman("Yazılım", "İstanbul");

        // Çalışan örneği oluşturma
        Calisan calisan1 = new Calisan("Ali Veli", "Yazılım Mühendisi");
        calisan1.DepartmanAtama(yazilimDepartmani);

        // Çalışan ve departman bilgilerini ekrana yazdırma
        Console.WriteLine(calisan1);
    }
}