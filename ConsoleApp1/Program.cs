namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit=true;
            Library library = new 
             Library("Milli Kitabxana");
            do
            {
                Console.WriteLine("Sec:");
                Console.WriteLine("1. Kitab Elave et");
                Console.WriteLine("2. Id ye gore tap");
                Console.WriteLine("3. Ada gore tap");
                Console.WriteLine("4. Sil");
                Console.WriteLine("5. Update");
                Console.WriteLine("6. Hamisini goster");
                Console.WriteLine("0. Cixgetburdan");
                string input = Console.ReadLine();
                switch (input) { 
                    case "1":
                        Book createbook = library.CreateBook();
                        library.AddBook(createbook);
                        break;
                    case "2":
                        int id = Convert.ToInt32(Console.ReadLine());   
                        library.GetBookById(id);    
                        break;
                    case "3":
                        library.Getbook();
                        break;
                    case "5":
                        library.UpdateBook();
                        break;
                    case "6":
                        library.GetAllBooks();
                        break;
                    case "0":
                        exit = false;
                        break;
                }
            }
            while (exit);
        }
    }
}
