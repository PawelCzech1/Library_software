using System;
using  System.IO; 
using Books; 
using System.Collections.Generic;
using System.Collections;
namespace Przyklady
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); 
           System.Console.WriteLine("Library software."); 
           System.Console.WriteLine("Choose what you wanna do.");
           System.Console.WriteLine("Select number between 1 and 4 to select the right option");
           Console.Write("Your choice is:\t"); 
           string option = Console.ReadLine(); 
           System.Console.WriteLine();
        //    System.Console.WriteLine(Hash());

		switch (option)
        {
            case "1":
            System.Console.WriteLine("you can add the book to the library");
            break;
            case "2":
            System.Console.WriteLine("You can lend the book");
            break;
            case "3":
            System.Console.WriteLine("You can accept the book back");
            break;
            case "4":
            System.Console.WriteLine("You can delete the book  from library");
            break;
            default:
            System.Console.Error.WriteLine("\n\t*** I don't understand you.\n\tChoose the right option ***\t\n");
            break;
        }
        System.Console.WriteLine(Hash());
        var book1 = new Bookshelf("Rabbit rest", "John Updike"); 
        var cust1 = new Customer("Paweł", "Czechowicz");
        
       
        if(option == "1") {
             System.Console.WriteLine("Add the book to the library, please");
             System.Console.WriteLine($"Give some information about the book");
             book1.getBook(); 
             cust1.setName(); 
        }
        else if(option == "2") {
          System.Console.WriteLine("Lend the book");  
        }
        else if(option == "3") {
            System.Console.WriteLine("Accept the book back");
        }
        else if(option == "4") {
            System.Console.WriteLine("Delete the book  from library");
        }
        else {
            System.Console.Error.WriteLine("\n\t***I don't understand you.\n\tChoose the right option***\t\n");
        }

        }
        List<string> Books = new List<string> ();
        List<string> Title = new List<string> ();
        List<string> Author = new List<string> ();
     

        public static string Hash() 
        {
            return new String('#', 30);
        }
    }

}
