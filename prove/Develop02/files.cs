using System;
using System.Collections.Generic;

using System.IO;

namespace MyPrompts

{   class Program
        {static void Main(string[]args)
        
        {   string writeText = "Welcome to your journal!";
            File.WriteAllText("text.txt", writeText);
            
            string readText = File.ReadAllText("text.txt");
            Console.WriteLine (readText);}}}









