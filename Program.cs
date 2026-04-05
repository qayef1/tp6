using System;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Charlie XCX - Guess featuring billie eilish");

        track.PrintTrackDetails();
        Console.WriteLine();

        track.IncreasePlayCount(2);
        track.PrintTrackDetails();
        Console.WriteLine();

        track.IncreasePlayCount(1337);
        track.PrintTrackDetails();
    }
}
