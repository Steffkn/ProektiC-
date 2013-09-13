// You will need only these two using directives if it's a console:
using System;
// For the pauses, you can use the threading:
using System.Threading;

class ConsoleBeepTest
{
    [STAThread]
    static void Main()
    {

        for (int hz = 14500; hz < 20000; hz+=50)
        {
            Console.WriteLine("Hz: {0}",hz);
            Console.Beep(hz, 1000);
            Thread.Sleep(10);
        }

        // First, let's determine the keys and the corresponding frequencies:
        // I have found these frequency values somewhere on the web with Google,
        // but I don't remember where exactly.
        int C = 264;
        int D = 297;
        int E = 330;
        int F = 352;
        int G = 396;
        int A = 440;
        int Bb = 466;
        int B = 495;
        int C2 = 528;

        // Now, we need to set the tempo for a note, half note, quarter note, and eighth note.
        int note = 1000;
        int half = 1000 / 2;
        int quarter = 1000 / 4;
        int eighth = 1000 / 8;


        // Now we can already "sing" a scale to warm up:
        Console.WriteLine("Warming up the voice ...");
        Thread.Sleep(2000);
        Console.Beep(C, quarter);
        Console.Beep(D, quarter);
        Console.Beep(E, quarter);
        Console.Beep(F, quarter);
        Console.Beep(G, quarter);
        Console.Beep(A, quarter);
        Console.Beep(B, quarter);
        Console.Beep(C2, half);
        Thread.Sleep(quarter);
        Console.Beep(C2, quarter);
        Console.Beep(B, quarter);
        Console.Beep(A, quarter);
        Console.Beep(G, quarter);
        Console.Beep(F, quarter);
        Console.Beep(E, quarter);
        Console.Beep(D, quarter);
        Console.Beep(C, half);

        // Let's sing happy birthday, just because Ged Mead turned 60 some days ago:
        Console.WriteLine("We're warmed up, so then let's sing ...");
        Thread.Sleep(2000);
        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(D, half);
        Thread.Sleep(eighth);
        Console.Beep(C, half);
        Thread.Sleep(eighth);
        Console.Beep(F, half);
        Thread.Sleep(eighth);
        Console.Beep(E, note);
        Thread.Sleep(quarter);

        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(D, half);
        Thread.Sleep(eighth);
        Console.Beep(C, half);
        Thread.Sleep(eighth);
        Console.Beep(G, half);
        Thread.Sleep(eighth);
        Console.Beep(F, note);

        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(quarter);
        Console.Beep(C, eighth);
        Thread.Sleep(eighth);
        Console.Beep(C2, half);
        Thread.Sleep(eighth);
        Console.Beep(A, half);
        Thread.Sleep(eighth);
        Console.Beep(F, quarter);
        Thread.Sleep(eighth);
        Console.Beep(F, eighth);
        Thread.Sleep(eighth);
        Console.Beep(E, half);
        Thread.Sleep(eighth);
        Console.Beep(D, note);

        Thread.Sleep(quarter);
        Console.Beep(Bb, eighth);
        Thread.Sleep(quarter);
        Console.Beep(Bb, eighth);
        Thread.Sleep(eighth);
        Console.Beep(A, half);
        Thread.Sleep(eighth);
        Console.Beep(F, half);
        Thread.Sleep(eighth);
        Console.Beep(G, half);
        Thread.Sleep(eighth);
        Console.Beep(F, note);

        // Some random sounds that should remind you of some old, old games:
        Console.WriteLine("Perhaps you prefer something from the" +
            " late 70's or early 80's ...");
        Thread.Sleep(2000);
        Random randomSounds = new Random();
        for (int index = 0; index < 100; index++)
        {
            Console.Beep(randomSounds.Next(1000) + 100, 100);
        }
    }
}