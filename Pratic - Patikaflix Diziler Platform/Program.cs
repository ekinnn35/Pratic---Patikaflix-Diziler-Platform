using System;
using System.Collections.Generic;
using System.Linq;

class Series
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Platform { get; set; }

    public Series(string title, int year, string genre, string director, string platform)
    {
        Title = title;
        Year = year;
        Genre = genre;
        Director = director;
        Platform = platform;
    }
}

class Program
{
    static void Main()
    {
        // TV dizileri listesi
        List<Series> seriesList = new List<Series>
        {
            new Series("Avrupa Yakası", 2004, "Comedy", "Yüksel Aksu", "Kanal D"),
            new Series("Yalan Dünya", 2012, "Comedy", "Gülseren Buda Başkaya", "Fox TV"),
            new Series("Jet Sosyete", 2018, "Comedy", "Gülseren Buda Başkaya", "TV8"),
            new Series("Dadı", 2006, "Comedy", "Yusuf Pirhasan", "Kanal D"),
            new Series("Belalı Baldız", 2007, "Comedy", "Yüksel Aksu", "Kanal D"),
            new Series("Arka Sokaklar", 2004, "Polisiye, Dram", "Orhan Oğuz", "Kanal D"),
            new Series("Aşk-ı Memnu", 2008, "Dram, Romantik", "Hilal Saral", "Kanal D"),
            new Series("Muhteşem Yüzyıl", 2011, "Tarihi, Dram", "Mercan Çilingiroğlu", "Star TV"),
            new Series("Yaprak Dökümü", 2006, "Dram", "Serdar Akar", "Kanal D")
        };

        // 1. Komedi dizilerini filtreleme
        var comedySeries = seriesList.Where(s => s.Genre.Contains("Comedy")).ToList();

        // 2. Sadece belirli özellikleri içeren yeni bir liste oluşturma
        var filteredList = comedySeries.Select(s => new { s.Title, s.Genre, s.Director }).ToList();

        // 3. Yönetmen ismine göre sıralama
        var sortedList = filteredList.OrderBy(s => s.Director).ToList();

        // 4. Sonuçları ekrana yazdırma
        Console.WriteLine("Filtered Comedy Series List:");
        foreach (var series in sortedList)
        {
            Console.WriteLine($"{series.Title} - {series.Genre} - {series.Director}");
        }
    }
}
