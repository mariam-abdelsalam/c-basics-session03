
namespace Assignment1
{
    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public int Pages { get; set; }
        }
        //        #region
        //        static void Main(string[] args)
        //        {
        //            Q1();
        //        }

        //        static void Q1()
        //        {
        //            Book book = new Book
        //            {
        //                Title = "C# Basics",
        //                Pages = 464
        //            };

        //            object obj = book;

        //            Console.WriteLine(obj);
        //        }
        //    }
        //}
        //q2 
        //    static void Q2()
        //    {
        //        Book book = new Book
        //        {
        //            Title = "C# Basics",
        //            Pages = 464
        //        };

        //        Console.WriteLine(book.ToString());
        //        Console.WriteLine(book.Equals(book));
        //        Console.WriteLine(book.GetHashCode());
        //        Console.WriteLine(book.GetType());
        //    }
        //}
        //q3 
        //    static void Q3()
        //    {
        //        int pages = 464;

        //        Console.WriteLine(pages);
        //    }
        //}

        //q4 
        //static void Q4()
        //{
        //    try
        //    {
        //        int x = 10;
        //        int y = 0;

        //        Console.WriteLine(x / y);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Cannot divide by zero");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Done");
        //    }
        //} }

        //q5
        //static void Q5()
        //{
        //    int pages = 300;

        //    double totalPages = pages;

        //    Console.WriteLine(totalPages);
        //}

        //q6
        //static void Q6()
        //{
        //    double price = 49.99;

        //    int newPrice = (int)price;

        //    Console.WriteLine(newPrice);
        //}

        //q7
        //static void Q7()
        //{
        //    string pagesText = "464";

        //    int pages = Convert.ToInt32(pagesText);

        //    Console.WriteLine(pages);
        //}
        //q8
        //static void Q8()
        //{
        //    string yearText = "2023";

        //    int year = int.Parse(yearText);

        //    Console.WriteLine(year);

        //    string badText = "abc";

        //    bool result = int.TryParse(badText, out int number);

        //    if (!result)
        //    {
        //        Console.WriteLine("Invalid number");
        //    }
        //}
        //q9
        //static void Q9()
        //{
        //    int pages = 464;

        //    string pagesText = pages.ToString();

        //    Console.WriteLine(pagesText);
        //    Console.WriteLine(pagesText.GetType());
        //}
        //q10
        static void Q10()
        {
            int copies = 100;

            object obj = copies;

            int newCopies = (int)obj;

            Console.WriteLine(copies);
            Console.WriteLine(newCopies);
        }

        //q11
        static void 
           Q11()
        {
            int? year = null;

            Console.WriteLine(year.HasValue);

            year = 2023;

            Console.WriteLine(year.HasValue);
            Console.WriteLine(year.Value);
        }
        //q12
        static void Q12()
        {
            string? reviewer = null;

            Console.WriteLine(reviewer == null);
        }
        //Q13
        static void Q13()
        {
            Book? book = null;

            string? title = book?.Title;

            Console.WriteLine(title);
        }
        //Q14
        static void Q14()
        {
            string? title = null;

            Console.WriteLine(title ?? "Untitled");

            title ??= "Untitled";

            Console.WriteLine(title);

            string? name = "Ahmed";

            string confirmedName = name!;

            Console.WriteLine(confirmedName);
        }