using System;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        playCount = 0;
        this.title = title;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
