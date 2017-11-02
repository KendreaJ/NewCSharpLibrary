using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._12_Game_Build_Along
{
    class Program
    {
        static void Main(string[] args)
        {
            //this will be used later.  Speeech Synthesizer allows the text on the screen to
            //be heard
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Prompt for player information
            Console.WriteLine("Hello, wandereer...\n"+
                                "What be thy name?");
            string inputName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Nice to meet you, {inputName}.");
            Thread.Sleep(1000);
            Console.WriteLine("\nWhat's your specialization friend?\n" +
                "0: Horse Mange\n" +
                "1: Troll Cat\n" +
                "2: Knight Templator\n" +
                "3: Demogorg\n" +
                "4: Vampire\n" +
                "5: Bovine Frog");
            // Declaring a new integar and then initializing the string that is on the
            //console read line
            // Get value user provided
            int inputSpec = Int32.Parse(Console.ReadLine());

            //Perform explicit cast from
            //int to Specialization enum type.  How to convert an integer to an enmu type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;

            Console.WriteLine($"ahh... a{inputSpecialization}, an interesting choice");


            //Create new player object using the player input
            Player hero = new Player(inputName, inputSpecialization);

            Console.Clear();

            Console.WriteLine($"Your journey begins here {hero.Name}, {hero.Role}");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A shady figure appears...");
            Thread.Sleep(1500);

            Console.WriteLine($"Your're goingin doens {hero.Name}");
            synth.Speak("$You're going down {hero.Name}, the {hero.Role}");
            Thread.Sleep(1000);

            Enemy robot = new Enemy("Jay", hero.Level);
            Console.WriteLine("BATTLE INSTANTIATED!");
            synth.Speak("BATTLE INSTANTIATED");

            //Battle loop-how to make the players fight, using a while loop
            while (hero.IsALive && robot.IsALive)
            {
            Console.Clear();
            Console.WriteLine($"{hero.Name}'s Health: {hero.Health}\n" +
                              $"{robot.Name} Health: {robot.Health}\n\n");
            Console.WriteLine("=======================\n" +
                                  "         ACTIONS   \n" +
                                  "=======================");
            Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
           int inputAction = Int32.Parse(Console.ReadLine()); 
            Player.Action heroAction = (Player.Action)inputAction;

                //Handle hero action using a switchcase.  hit switch tab tab
                switch (heroAction)
                {
                    case Player.Action.Attack:
                        int heroAttack = hero.Attack();
                        int robotAttack = robot.Attack();
                        //Ajust health values
                        hero.Health -= robotAttack;
                        robot.Health -= heroAttack;

                        //Displeay attack stuff in the console
                        Console.Clear();
                        Console.WriteLine("=======================\n" +
                                         $"{hero.Name} Deals {heroAttack} to {robot.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("=======================\n" +
                                         $"{robot.Name} Deals {robotAttack} to {hero.Name}\n" +
                                          "=======================\n");
                        Thread.Sleep(1500);
                        break;

                        break;
                    case Player.Action.Run:
                        break;
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to make a run for it!");
                        Thread.Sleep(1500);
                        synth.Speak("Where do you think you're going?!");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} pulls {hero.Name} back into the fight!");
                        break;
                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to hide...");
                        Thread.Sleep(1500);
                        synth.Speak($"You can't hide from me {hero.Role}");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} found {hero.Name}!");
                        break;
                    default:
                        break;
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("I know I make computers slow, but this is just ridiculous!");
                        break;
                        Thread.Sleep(2000);
                }
                //Check to see if anyone is dead
                if (hero.Health < 0)
                {
                    hero.IsALive = false;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine($"{robot.Name} has defeated {hero.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("Defeating you was exclamation mark difficult. hahahahahahah.");
                }
                if (robot.Health < 0)
                {
                    robot.IsALive = false;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{hero.Name} has defeated {robot.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("What!?!?! NOOOOOOOOOOOOOOOO!");
                }
            }


            //Declaring variables. Type, Name and then value

        }
    }
}
