using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource test = new Resource("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction");
            test.GetInfo();
            test.UpdateStatus();
            test.GetInfo();
            Book Book = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", "Charlez Petzold", 396);
            Book.GetInfo();
            Periodical p = new Periodical("Wired", "Technology", "Monthly");
            p.UpdateStatus();
            Console.WriteLine(p.Status);
            Video v = new Video("Ex Machina", "Alex Garland", "Sci-Fi", "On-Demand", 108);
            v.GetInfo();
        }
    }
}