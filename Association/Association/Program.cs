class Author
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string Gender {  get; set; }

    public Author()
    {
        
    }

    public Author(string name, string email, string gender)
    {
        this.Name = name;
        this.Email = email;
        this.Gender = gender;
    }

    public override string ToString()
    {
        return $"Authhor : [Name : {this.Name}, Email : {this.Email}, Gender : {this.Gender}]";
    }
}

class Book
{
    public string Name { get; set; }
    public Author aut { get; set; } //Composition (Tight coupling)= new Author { Name = "Zulfiqar", Email = "zip@gmail.com", Gender = "M" };
    public double Price { get; set; }
    public int Qty { get; set; }

    public override string ToString()
    {
        return $"Book : [Name : {this.Name}, {this.aut}, Price : {this.Price}, Quantity : {this.Qty}]";
    }
}

class AssociationApp
{
    public static void Main (string[] args)
    {
        Book b = new Book {Name = "Life of Pi", Price = 120, Qty = 3 };
        Console.WriteLine(b);

        //Aggregation (Loose coupling)
        Author a = new Author { Name = "Zulfiqar", Email = "zip@gmail.com", Gender = "M" };
        b.aut = a;
        Console.WriteLine(b);
    }
}