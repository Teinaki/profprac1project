using System;
using System.Threading;

namespace CommandGamePP1
{
    class Program
    {
        public static int yellowkey = 0, redkey = 0, orangekey = 0, greenkey = 0;
        public static int room = 0;  //rooms 3,5,6,9,10,11,14. need keys, maybe room 6 will lead down long path to nowhere
        public static void story()
        {
            switch (room)
            {
                case 0:
                    Console.WriteLine("Oh no! You have found yourself trapped in a maze.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You see multiple doors in front of you. Select from the following:    ");
                    Console.WriteLine("Press the corresponding number to go through \n1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door.");
                    break;
                case 1:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 2:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 3:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 4:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 5:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 6:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 7:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 8:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 9:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 10:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 11:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 12:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 13:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door. ");
                    break;
                case 14:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Gold  door. 2) Gold door. 3) Gold door. 4) Jeff 5) Gold door. 6) Gold door.");
                    break;
                default:
                    Console.WriteLine("Pick a path. 1-6");
                    break;

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
                        if (room != 11)
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        else
                        {
                            Console.WriteLine("Door is locked"); //Stuck right now, need to work on key code to progress maze
                        }
                    }
                    break;
                case "2":
                    if (path == correctpath[room])
                    {
                        if (room != 9)
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        else
                        {
                            Console.WriteLine("Door is locked"); //Stuck right now, need to work on key code to progress maze
                        }
                    }
                    break;
                case "3":
                    if (path == correctpath[room])
                    {
                        if (room != 5 && room != 10)
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        else
                        {
                            Console.WriteLine("Door is locked"); //Stuck right now, need to work on key code to progress maze
                        }
                    }
                    break;
                case "4":
                    if (path == correctpath[room])
                    {
                        if (room != 3 && room != 6 && room != 14)
                        {
                            Console.WriteLine("Correct path");
                            room++;
                        }
                        else
                        {
                            Console.WriteLine("Door is locked"); //Stuck right now, need to work on key code to progress maze
                        }
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
        public static void search()
        {
            switch (room)
            {
                case 1:
                    Console.WriteLine("You enter a dimly lit room");
                    Console.WriteLine("Would you like to search the room?");
                    string temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "yes":
                        case "Yes":
                        case "y":
                            Console.WriteLine("You find key or something");
                            // then do yellowkey++ or whatever
                            break;
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {

            do
            {
                search();
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
