using System;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Charlie XCX - Guess featuring billie eilish");
        track.PrintTrackDetails();
        track.IncreasePlayCount(2);
        track.PrintTrackDetails();

        try
        {
            new SayaMusicTrack(null!);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Precondition title null: {ex.Message}");
        }

        try
        {
            new SayaMusicTrack(new string('A', 101));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Precondition title terlalu panjang: {ex.Message}");
        }

        try
        {
            SayaMusicTrack invalidCountTrack = new SayaMusicTrack("Test Invalid Count");
            invalidCountTrack.IncreasePlayCount(10000001);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Precondition play count: {ex.Message}");
        }

        try
        {
            SayaMusicTrack overflowTrack = new SayaMusicTrack("Test Overflow");

            for (int i = 0; i < 300; i++)
            {
                overflowTrack.IncreasePlayCount(10000000);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Overflow exception: {ex.Message}");
        }
    }
}
