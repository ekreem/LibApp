using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
       private static int _id;
       public int Id = 1;
       public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public Book(string name, string authorName, int price) {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorName;
            Price = price;
        }
        public string ShowInfo() {

            return $"{Id} {AuthorName} - {Name} - {Price} ";
        }
        public override string ToString()
        {
            return ShowInfo();
            }
        }
    }
