using System;
using System.Threading;

namespace CommandGamePP1
{
    class Program
    {
        public static int room = 0, orangekey = 0, greenkey = 0, redkey = 0, yellowkey = 0;  //rooms 3,5,6,9,10,11,14. need keys, maybe room 6 will lead down long path to nowhere
        public static void story()
        {
            switch (room)
            {
                case 0:
                    Console.WriteLine("Press the corresponding number to go through \n1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.");
                    break;
                case 1:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 2:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 3:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 4:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 5:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 6:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 7:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 8:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 9:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 10:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 11:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 12:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) Go back. ");
                    break;
                case 13:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Search room.  6) go back. ");
                    break;
                case 14:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Gold  door. 2) Gold door. 3) Gold door. 4) Jeff 5) Search room. 6) Go back.");
                    break;
                default:
                    Console.WriteLine("Pick a path. 1-6");
                    break;

            }
        }
        public static void choices()
        {

            string[] correctpath = { "4", "2", "4", "2", "2", "1", "2", "3", "2", "1", "4", "1", "1", "2", "2" };
            // 424221232141122 is the maze image path to the end
            string path = Console.ReadLine();
            switch (path)
            {
                case "1":
                    if (path == correctpath[room])
                    {
                        switch (room)
                        {
                            case 5:
                                if (redkey >= 1)
                                {
                                    Console.WriteLine("You use the redkey to unlock the door and proceed");
                                    room++;
                                    redkey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            case 9:
                                if (redkey >= 1)
                                {
                                    Console.WriteLine("You use the redkey to unlock the door and proceed");
                                    room++;
                                    redkey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            case 11:
                                if (redkey >= 1)
                                {
                                    Console.WriteLine("You use the redkey to unlock the door and proceed");
                                    room++;
                                    redkey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            default:
                                Console.WriteLine("You proceed to the next room");
                                room++;
                                break;
                        }
                    }
                    break;
                case "2":
                    if (path == correctpath[room])
                    {
                        switch (room)
                        {
                            case 3:
                                if (orangekey >= 1)
                                {
                                    Console.WriteLine("You use the orange to unlock the door and proceed");
                                    room++;
                                    orangekey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            case 6:
                                if (orangekey >= 1)
                                {
                                    Console.WriteLine("You use the orange to unlock the door and proceed");
                                    room++;
                                    orangekey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            case 14:
                                if (orangekey >= 1)
                                {
                                    Console.WriteLine("You use the orange to unlock the door and proceed");
                                    room++;
                                    orangekey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            default:
                                Console.WriteLine("You proceed to the next room");
                                room++;
                                break;
                        }
                    }
                    break;
                case "3":
                    if (path == correctpath[room])
                    {
                        Console.WriteLine("You proceed to the next room");
                        room++;
                    }
                    break;
                case "4":
                    if (path == correctpath[room])
                    {
                        switch (room)
                        {
                            case 10:
                                if (greenkey >= 1)
                                {
                                    Console.WriteLine("You use the greenkey to unlock the door");
                                    room++;
                                    redkey--;
                                }
                                else
                                {
                                    Console.WriteLine("Door is locked");
                                }
                                break;
                            default:
                                Console.WriteLine("You proceed to the next room");
                                room++;
                                break;
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("You search the room");
                    switch (room)
                    {
                        case 1:
                            if (orangekey == 0)
                            {
                                Console.WriteLine("You find a orange key");
                                orangekey++;
                            }
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Room was empty");
                            break;
                    }
                    break;
                case "6":
                    Console.WriteLine("You decide to move back a room");
                    room--;
                    break;
                default:
                    Console.WriteLine("Wrong Path value try again");
                    break;
            }                 // If you pick the right path you reach the next 'room' in the maze and go again
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Oh no! You have found yourself trapped in a maze.");
            Thread.Sleep(2000);
            Console.WriteLine("You see multiple doors in front of you. Select from the following:    ");

            do
            {
                story();
                choices();
                Thread.Sleep(2000);
                Console.Clear();
            } while (room < 15);
            // You're struck in this maze until you get the right path to the end.
            Console.WriteLine("You reached the end of the maze");
            Console.ReadLine();
            // In future can ask different questions not just "Pick a path. 1-6" depending on what room you're in
            // also can stop moving to a different room(room++) if you didn't use an item (key or whatever)
        }
    }
}
