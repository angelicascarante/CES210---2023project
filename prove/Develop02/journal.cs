using System; 
using System.Collections.Generic;
using System.IO;


public class Journal


{   
    public string _name;
    public List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompts, string response)

    {   JournalEntry entry = new JournalEntry (prompts, response, DataTime.Now);
        entries.Add(entry);}

        public void Display.Journal()

        {
        
        
            Console.WriteLine("Journal Entries:");
            foreach (JournalEntry entry in entries);
            {   Console.WriteLine("Date:"+ entry.Date);
                Console.WriteLine("Prompt"+EntryPointNotFoundException.Prompt);
                Console.WriteLine("Response:"+EntryPointNotFoundException.Response);

            
            }
        }

    
        Console.WriteLine(":");

        foreach (entry)                                                                                                                              

        {   entry.Display();}
    }
}









}