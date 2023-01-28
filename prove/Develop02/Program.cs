using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random md = new Random();
        string[] prompts = {"Who was the most interesting person you interacted today?",
        "What was teh strongest emotion you felt today?",
        "How did you see the hand of the Lord in your life today?",
        "If you had one thing you could do over today, what would it be?"
        };

        while (true)
            {
            
            int choice = ();
            switch (choice)
{
                case 1:
                    Console.WriteLine("1-Write a new entry");
                    int promptIndex = md.Next(prompts.Length);
                    Console.Write("Response:");
                        string response = Console.ReadLine();
                        journal.AddEntry(prompts[promptIndex], response);



                        break;
                case 2:

                    Console.WriteLine("2-Display the journal");
                    journal.DisplayJournal();
                    break;

                case 3:

                    Console.WriteLine("3-Save the journal to a file");
                    Console.Write("Enter a file name");
                    string fileName = Console.ReadLine();
                    journal.SaveJournal(fileName + ".txt");


                    break;
                
                case 4:

                    Console.WriteLine("4-Load the journal from a file");
                    Console.Write("Enter a file name:");
                    fileName = Console.ReadLine();
                    journal.LoadJournal(fileName+".txt");
                    break;

                case 5:


                    Console.WriteLine("5-Exit");
                    return;

                
            
        
           
}
            
            

        
    }
}