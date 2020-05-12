using System;

namespace CommandGamePP1
{
    class Program
    {
        public static int room = 0;
        public static void story()
        {
            switch (room)
            {
                case 0:
                    //Console.WriteLine("Pick a path. 1-6 // room 0//");
                    Console.WriteLine("Oh no! You have found yourself trapped in a maze.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You see multiple doors in front of you. Select from the following:    ");
                    Thread.Sleep(2000);
                    Console.WriteLine("Press 1) to go through the red door.");
                    Thread.Sleep(800);
                    Console.WriteLine("Press 2) to go through the orange door");
                    Thread.Sleep(800);
                    Console.WriteLine("Press 3) to go through the yellow door.");
                    Thread.Sleep(800);
                    Console.WriteLine("Press 4) to go through the green door");
                    Thread.Sleep(800);
                    Console.WriteLine("Press 5) to go through the blue door.");
                    Thread.Sleep(800);
                    Console.WriteLine("Press 6) to go through the purple door");
                    break;
                case 1:
                    Console.WriteLine("Pick a path. 1-6 // room 1//");
                    break;
                case 2:
                    Console.WriteLine("Pick a path. 1-6 // room 2//");
                    break;
                case 3:
                    Console.WriteLine("Pick a path. 1-6 // room 3//");
                    break;
                case 4:
                    Console.WriteLine("Pick a path. 1-6 // room 4//");
                    break;
                case 5:
                    Console.WriteLine("Pick a path. 1-6 // room 5//");
                    break;
                case 6:
                    Console.WriteLine("Pick a path. 1-6 // room 6//");
                    break;
                case 7:
                    Console.WriteLine("Pick a path. 1-6 // room 7//");
                    break;
                case 8:
                    Console.WriteLine("Pick a path. 1-6 // room 8//");
                    break;
                case 9:
                    Console.WriteLine("Pick a path. 1-6 // room 9//");
                    break;
                case 10:
                    Console.WriteLine("Pick a path. 1-6 // room 10//");
                    break;
                case 11:
                    Console.WriteLine("Pick a path. 1-6 // room 11//");
                    break;
                case 12:
                    Console.WriteLine("Pick a path. 1-6 // room 12//");
                    break;
                case 13:
                    Console.WriteLine("Pick a path. 1-6 // room 13//");
                    break;
                case 14:
                    Console.WriteLine("Pick a path. 1-6 // room 14//");
                    break;
                default:
                    Console.WriteLine("Pick a path. 1-6");
                    break;

                    //testing
            }
        }
        public static void choices()
        {

            string[] correctpath = { "6", "4", "6", "4", "4", "3", "4", "5", "4", "2", "3", "1", "2", "4", "4" };
            // 646443454231244 is the maze image path to the end
            string path = Console.ReadLine();
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
            }                 // If you pick the right path you reach the next 'room' in the maze and go again
        }
        static void Main(string[] args)
        {

            do
            {
                story();
                choices();
                Console.WriteLine();
            } while (room < 15);
            // You're struck in this maze until you get the right path to the end.
            Console.WriteLine("You reached the end of the maze");
            Console.ReadLine();
            // In future can ask different questions not just "Pick a path. 1-6" depending on what room you're in
            // also can stop moving to a different room(room++) if you didn't use an item (key or whatever)
        }
    }
}
