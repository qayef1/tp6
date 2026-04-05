using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul track tidak boleh null.");

        if (title == null)
        {
            throw new ArgumentNullException(nameof(title), "Judul track tidak boleh null.");
        }

        Debug.Assert(title.Length <= 100, "Judul track maksimal 100 karakter.");

        if (title.Length > 100)
        {
            throw new ArgumentException("Judul track maksimal 100 karakter.", nameof(title));
        }

        Random random = new Random();
        id = random.Next(10000, 100000);
        playCount = 0;
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000.");

        if (count > 10000000)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Penambahan play count maksimal 10.000.000.");
        }

        checked
        {
            playCount += count;
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
