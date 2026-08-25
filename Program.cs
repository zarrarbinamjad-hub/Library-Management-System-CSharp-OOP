using LIbrary_Managment_System_Demo;

Book b1=new Book(1,"Education","Ali",500,true);
Book b2 = new Book(2,"Democracy","Asif",600,false);
Book b3 = new Book(3,"Universe","Arif",700,true);
Book b4 = new Book(4,"Pollution","Aqib",800,true);
Book b5 = new Book(5,"Global Warming","Ayub",900,false);
b1.IssueBook();
b2.ReturnBook();
b3.DisplayBook();

Library l1 = new Library();
l1.AddBook(b1);
l1.AddBook(b2);
l1.AddBook(b3);
l1.AddBook(b4);
l1.AddBook(b5);
Console.WriteLine();
l1.AvailableBooks();
l1.ShowAllBooks();
l1.UpdateBookPrice(2, 1000);
l1.MostExpensiveBook();
l1.CountBooks();
l1.ShowAllBooks();