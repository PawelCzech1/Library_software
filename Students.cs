using System; 

class Students {
     
string name; 

public string getName() {
    System.Console.WriteLine("Enter your name, please.");
    Console.Write("Name:\t"); 
    name = Console.ReadLine(); 

    return name; 
}

}

