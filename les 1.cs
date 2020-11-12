using System;

namespace basic_to_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Design(); // om mooier te maken
            Console.WriteLine("Hello World!"); // typt om console
            Console.WriteLine("Vul je naam in"); // typt in console
            string input = Console.ReadLine(); // string word de input van de gebruiker
            if(input == "Mike")     // als inout mike is
            {
                Console.WriteLine("you are a Mike. That's nice."); // dit typt ook tekst
            }else  // anders
            { 
                Console.WriteLine("You are not a Mike.....\nOof.");  //dit is om tekst te typen. 
            }

            // Console.ReadKey();
        }
        
        static void Design()
        {
            Console.Title = "Test";                             //dit is om mooier te maken.
            Console.ForegroundColor = ConsoleColor.Green;       //dit is om mooier te maken. 
            Console.WindowHeight = 40;                          //dit is om mooier te maken. 
        }
    }
}

// string    letters
// int     getal(zonder komma)
// bool    waar/niet waar
// float   ,getal
