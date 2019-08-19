using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{                                                                      //Opening Brace (Belongs to namespace)

    class Program
    {                                                                  //Classes goes inside to namespace
        static void Main(string[] args)
        {                                                              //Console = (Cmd Prompt)
            Console.Write("Hello Player! What is your name?\n");       //Output Text    (\n similar to endl in c++)

            int playerScore = 0;
            string playerName = "";
            playerName = Console.ReadLine();                           //Similar to cin in c++


            int add = 0;

            while(playerScore<10)
            {
                Console.Write("Increment Score: ");                    //a cin to add (inputed number)[Add Score]
                add = Convert.ToInt32(Console.ReadLine());             // Converts value from string to an int

                Console.Write("\n");
                playerScore = playerScore + add;
                Console.Write("Current Score: ");
                Console.WriteLine(playerScore);
                Console.Write("\n");
            }


            Console.WriteLine("Score of " + playerName);
            Console.WriteLine(playerScore);
            Console.ReadLine();                                       //Waits for the User to Press ENTER
        }
    }
}
