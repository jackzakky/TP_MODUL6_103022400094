using System;

namespace TP_MODUL6_103022400094
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu1 = new SayaMusicTrack("Glory Glory Man United");
            lagu1.IncreasePlayCount(1000000);
            lagu1.PrintTrackDetails();

            SayaMusicTrack lagu2 = new SayaMusicTrack("Test Overflow");
            for (int i = 0; i < 220; i++)
            {
                lagu2.IncreasePlayCount(10000000);
            }
            lagu2.PrintTrackDetails();
        }
    }
}