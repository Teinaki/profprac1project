using System;
using System.Threading;

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
                    Console.WriteLine("Oh no! You have found yourself trapped in a maze.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You see multiple doors in front of you. Select from the following:    ");
                    Console.WriteLine("Press the corresponding number to go through \n1) Red door.  2) Orange door.  3) Yellow door.  4) Green door.  5) Blue door.  6) Purple door.");
                    break;
                case 1:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Black door. 2) White door. 3) Rainbow door. 4) Silver door. 5) Gold door. ");
                    break;
                case 2:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Crimson door. 2) Red-orange door. 3) Maroon door. 4) Scarlet door. 5) Ruby door. 6) Garnet door.");
                    break;
                case 3:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Tangerine door. 2) Marigold door. 3) Rust door. 4)Ginger door. 5) Apricot door. 6) Honey door.");
                    break;
                case 4:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Corn door. 2) Honey door. 3) Pineapple door. 4) Amber door. 5) Canary door. 6) Lemon door.");
                    break;
                case 5:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Olive door. 2) Sage door. 3) Seaweed door. 4) Pickle door. 5) Emerald door. 6) Shamrock door.");
                    break;
                case 6:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Navy door. 2) Indigo door. 3) Cobalt door. 4) Teal door. 5) Sapphire door. 6) Stone door.");
                    break;
                case 7:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Mauve door. 2) Violet door. 3) Grape door. 4) Plum door. 5) Wine door. 6) Lilac door.");
                    break;
                case 8:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Rose door. 2) Peach door. 3) Salmon door. 4) Bubble gum door. 5) Rouge door. 6) Magenta door.");
                    break;
                case 9:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Carbon door. 2) Wood door. 3) Sand door. 4) Clay door. 5) lava door. 6) Gravel door.");
                    break;
                case 10:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Diamond door. 2) Pearl door. Press 3) Quartz door. 4) Glass door. 5) Platinum door. 6) Rhodium door.");
                    break;
                case 11:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Slime door. 2) Snow door. 3) Spiderweb door. 4) Honeycomb door. 5) Leather door. 6) Sponge door.");
                    break;
                case 12:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Ice door. 2)  Diorite door. 3) Basalt door. 4) Wheat door. 5) Oak door. 6) Soil door.");
                    break;
                case 13:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Dandelion door. 2) Poppy door. 3) Azure door. 4) Tulip door. 5) Daisy door. 6) Sunflower door.");
                    break;
                case 14:
                    Console.WriteLine("Select from the following:    ");
                    Console.WriteLine("1) Linen door. 2) Cashmere door. 3) Linen door. 4) Jeff 5) Wool door. 6) Cotton door.");
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
                        if (room != 6)
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
