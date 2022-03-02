using System;

namespace RPG2
{
    public class Program
    {
        static void Main(string[] args)
        {
            (string proName, string narName) = Start.StartText();
            FirstRoom.AfterIntro(proName, narName);
        }
    }
}