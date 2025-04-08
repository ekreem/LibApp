using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
        public string Name;
        Book[] Books = new Book[0];
        public Library(string Name)
        {
            Name = Name;
        }
        public Book CreateBook() {
            Console.WriteLine("Kitab adi yaz:");
            string name = Console.ReadLine();

            Console.WriteLine("Yazicisi kimdir?");
            string authorName = Console.ReadLine();

            Console.WriteLine("kitab qiymeti gir:");
            int price = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(name, authorName, price);
            return book;
        }
        public void AddBook(Book book)
        {

           
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = book;
           
        }
        public void GetBookById(int id)
        {

            for (int i = 0; i <= Books.Length-1; i++)
            {
                if (Books[i].Id == id)
                {
                    Console.WriteLine($"{Books[i].Name}");
                }
                else { Console.WriteLine("Bele bir Id yoxdur!"); }
            }
        }
        

        public void Getbook()
        {
            Console.WriteLine("istediyiniz kitabin  adini yazin");
            string ad = Console.ReadLine();
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == ad)
                {
                    Console.WriteLine(Books[i]);
                    break;
                }
                else { Console.WriteLine("Bele bir kitab yoxdur!"); }
            }
        }
        public void UpdateBook()
        {
            Book createbook = CreateBook();
            Console.WriteLine("istediyiniz Id ni yazin");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Books.Length - 1; i++)
            {
                if (i == id)
                {
                    Books[i] = createbook;
                }
                else { Console.WriteLine("Bele bir Id yoxdur ya da melumatlar sehvdir!"); }
            }
        }
        public void GetAllBooks() {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].ToString();
            }
        }
    }
}
