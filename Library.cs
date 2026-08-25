using System;
using System.Collections.Generic;
using System.Text;

namespace LIbrary_Managment_System_Demo
{
    public  class Library
    {



        Book[] books = new Book[5];
        int bookcount = 0;
        public void AddBook(Book book)
        {
            if(bookcount<books.Length)
            {
                books[bookcount] = book;
                bookcount++;
                Console.WriteLine("Book is Added Successfully");
            }
            else
            {
                Console.WriteLine("Library is Full");
            }
            
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < bookcount; i++)
            {
                books[i].DisplayBook();
            }
        }

        public void SearchBook(int id)
        {
            bool found = false;
            for (int i = 0; i < bookcount; i++)

            {
                if (id == books[i].ID)
                {
                   
                    Console.WriteLine("Book found");
                    books[i].DisplayBook();
                    found= true;
                    break;
                }


            }

            if (found==false)
            { Console.WriteLine("Book Not Found"); }
        }
        

        public void UpdateBookPrice(int id, double newPrice)
        {
            bool found=false;
            for (int i = 0; i < bookcount; i++)
            {
                if (id == books[i].ID)
                {
                    books[i].Price = newPrice;
                    Console.WriteLine("Book Price is Updated Successfully");
                    found = true;
                    break;
                }
               

            }
            if(found==false)
            {
                Console.WriteLine("Book not Found");
                }
            
        }



        public void DeleteBook(int id)
        {
            for (int i = 0; i < bookcount; i++)
            {
                if (id== books[i].ID)
                {
                    for (int j = i; j < bookcount-1; j++)
               
                    {
                        books[j] = books[j + 1];

                    }
                    bookcount--;
                    books[bookcount] = null;
                    break;
                }
            
        
            }
        }

        public void CountBooks()
        {
                 
         Console.WriteLine("Total Books: "+bookcount);
            
        }
        
        


        public void MostExpensiveBook()
        {
            if (bookcount == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            double Expensivebook = books[0].Price;
            for (int i = 1; i < bookcount; i++)
            {
                if(books[i].Price > Expensivebook)
                {
                    Expensivebook = books[i].Price;
                  
                }

            }
            Console.WriteLine("The Expensive book Price is : " + Expensivebook);
        }

        public void TotalPriceOfBooks()
        {
            double totalprice = 0;
            for (int i = 0; i < bookcount; i++)
            {
               totalprice=totalprice+ books[i].Price;
               
            }
            Console.WriteLine(totalprice);
        }

        public void IssuedBooks()
        {
            bool found= false;
            for (int i = 0; i < bookcount; i++)
            {
                if (books[i].IsIssued==true)
                {
                    books[i].DisplayBook();
                    found = true;
                    
                }
            }
            if (found == false)
            {
                Console.WriteLine("The book is Not Issued");
            }
        }

        public void AvailableBooks()
        {
            bool found= false;
            for (int i = 0; i < bookcount; i++)
            {
                if(books[i].IsIssued == false)
                {
                    books[i].DisplayBook();
                    found=true;
                }
              
            }
            if (found == false)
            { Console.WriteLine("These books are Not available in Library"); }
        }


    }
}
