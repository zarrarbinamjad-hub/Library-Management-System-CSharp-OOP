using System;
using System.Collections.Generic;
using System.Text;

namespace LIbrary_Managment_System_Demo
{
    public class Book
    {
        public int ID { get; set; }
        public string Title {  get; set; }
        public string Author {  get; set; }
        public double Price {  get; set; }
        public bool IsIssued {  get; set; }
        public Book(int id,string title,string author,double price,bool isissued)
        {
            ID= id; 
            Title = title; 
            Author = author; 
            Price = price; 
            IsIssued = isissued;
        }
        public void DisplayBook()
        {
            Console.WriteLine("Book ID: " + ID);
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Book Author: " + Author);
            Console.WriteLine("Book Price: " + Price);
            Console.WriteLine("Book is Issued: " + IsIssued);

        }
        public void IssueBook()
        {
            IsIssued= true;
            Console.WriteLine("Book is Issued Successfully ");
        }
        public void ReturnBook()
        {
            IsIssued = false;
            Console.WriteLine("Book is Returned Successfully");
         }


    }
}
