using System;


class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        

        while(!scripture.AllWordsHidden){

            Console.Clear();    
            scripture.Display();
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit"){
                break;
            }
            else{
                scripture.HideRandomWord();
            }
        }

        Console.Clear();
        scripture.DisplayHidden();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}