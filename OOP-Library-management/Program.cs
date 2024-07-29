// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    // Base class for library items
    public abstract class Item
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Item(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract void DisplayInfo();
    }

    // Derived class for books
    public class Book : Item
    {
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn) : base(title, author)
        {
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title} by {Author}, ISBN: {ISBN}");
        }
    }

    // Derived class for magazines
    public class Magazine : Item
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, int issueNumber) : base(title, author)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title} by {Author}, Issue Number: {IssueNumber}");
        }
    }

    // Class to manage the library
    public class Library
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            Console.WriteLine("\nLibrary Catalog:");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create library instance
            Library library = new Library();

            // Add items to the library
            library.AddItem(new Book("The Great Grosery Shop", "Jamila Ergasheva", "989265655"));
            library.AddItem(new Magazine("National Geographic", "J.Rasulov", 202407));

            // Display all items in the library
            library.DisplayAllItems();
        }
    }
}
