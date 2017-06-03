using System;

public class BpmCounter
{
    public static void Main()
    {
        int bpm = int.Parse(Console.ReadLine());
        int beats = int.Parse(Console.ReadLine());

        double bars = Math.Round(beats / 4.0, 1);
        double secondsForBeat = 60.0 / bpm;
        double totalSeconds = beats * secondsForBeat;

        int minute = (int)totalSeconds / 60;
        int seconds = (int)totalSeconds % 60;

        Console.WriteLine($"{bars} bars - {minute}m {seconds}s");
    }
}
