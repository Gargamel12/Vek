using System;

namespace Vek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 10);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Helo();
            Hello();
            Koridor();
            Console.ReadLine();
        }

        static void Helo()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╔══════════════════╗");
            Console.SetCursorPosition(10, 11);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║   Jste borec     ║");
            Console.SetCursorPosition(10, 12);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╚══════════════════╝");

        }

        static void Hello()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(12, 15);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╔══════════════════╗");
            Console.SetCursorPosition(12, 16);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║   Pepík    ║");
            Console.SetCursorPosition(12, 17);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╚══════════════════╝");
         }
        static void Koridor()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(18, 23);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╔══════════════════╗");
            Console.SetCursorPosition(18, 24);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║   Jindra        ║");
            Console.SetCursorPosition(18, 25);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("╚══════════════════╝");


        }
    }
}

