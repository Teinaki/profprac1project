using System;

namespace CommandGamePP1
{
    class Game
    {
        static bool Run = true;
        static int Choice;
        static bool Goal = false;

        public static void Menu()
        {

        }
        public static void Start()
        {

        }
        public static void End()
        {

        }
        public static void Play()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Just testing the updates

            int room = 0;

            string[] correctpath = { "6", "4", "6", "4", "4", "3", "4", "5", "4", "2", "3", "1", "2", "4", "4" };
            // 646443454231244 is the maze image path to the end

            do
            {
                switch (room)
                {
                    case 0:
                        Console.WriteLine("Pick a path. 1-6 // room 0//");
                        break;
                    case 1:
                        Console.WriteLine("Pick a path. 1-6 // room 1//");
                        break;
                }
                string path = Console.ReadLine();
                Console.WriteLine();
                switch (path)
                {
                    case "1":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    case "2":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    case "3":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    case "4":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    case "5":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    case "6":
                        if (path == correctpath[room])
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong Path value try again");
                        break;
                }
                // If you pick the right path you reach the next 'room' in the maze and go again
            } while (room < 15);
            // You're struck in this maze until you get the right path to the end.
            Console.WriteLine("You reached the end of the maze");
            Console.ReadLine();
            // In future can ask different questions not just "Pick a path. 1-6" depending on what room you're in
            // also can stop moving to a different room(room++) if you didn't use an item (key or whatever)
        }
    }
}
