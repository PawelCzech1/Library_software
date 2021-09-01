using System; 

namespace Books{

class Bookshelf
{
string Title;
    string  Author;
   
    int PublishYear; 

    public Bookshelf(string Title, string Author)
    {
        this.Title = Title; 
        this.Author = Author; 
    }
    public Bookshelf(string Title, string Author, int Year)
    {
        this.Title = Title; 
        this.Author = Author;
        this.PublishYear = Year;
    }
    public string getBook() {
        System.Console.WriteLine("Enter the book's title");
        Console.Write("Title:\t");
        Title = Console.ReadLine(); 
        System.Console.WriteLine("Enter the Author, please");
        Console.Write("Author:\t"); 
        Author = Console.ReadLine(); 

        System.Console.WriteLine($"Title of the book is {Title}.\nAuthor is {Author}");

        return $"{Title} {Author}";
    }
}
} 