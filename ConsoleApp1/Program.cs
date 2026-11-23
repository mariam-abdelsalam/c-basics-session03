using System;

namespace Session2Assignment
{
    // The Book class used by all questions
    class Book
    {
        public string Title { get; set; } = "";
        public int Pages { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Q1(); Q2(); Q3(); Q4(); Q5(); Q6(); Q7();
            Q8(); Q9(); Q10(); Q11(); Q12(); Q13(); Q14(); Q15();
        }

        // Q1: Book object stored in an object variable, then printed
        static void Q1()
        {
            Console.WriteLine("--- Q1 ---");
            object book = new Book { Title = "Clean Code", Pages = 464 };
            Console.WriteLine(book); // prints "Session2Assignment.Book" (default ToString)
        }

        // Q2: ToString, Equals, GetHashCode, GetType
        static void Q2()
        {
            Console.WriteLine("--- Q2 ---");
            Book book = new Book { Title = "Clean Code", Pages = 464 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));   // True
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
        }

        // Q3: Compile-time error. Fix below.
        static void Q3()
        {
            Console.WriteLine("--- Q3 ---");
            // int pages = "464";   // Compile-time error: cannot put a string into an int
            int pages = 464;        // Fixed
            Console.WriteLine(pages);
        }

        // Q4: try / catch / finally
        static void Q4()
        {
            Console.WriteLine("--- Q4 ---");
            try
            {
                int zero = 0;
                int result = 10 / zero; // DivideByZeroException
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }

        // Q5: implicit conversion int -> double (no cast)
        static void Q5()
        {
            Console.WriteLine("--- Q5 ---");
            int pages = 300;
            double pagesDouble = pages;
            Console.WriteLine(pagesDouble);
        }

        // Q6: explicit conversion double -> int (cast, decimals are truncated)
        static void Q6()
        {
            Console.WriteLine("--- Q6 ---");
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt); // 49
        }

        // Q7: Convert class
        static void Q7()
        {
            Console.WriteLine("--- Q7 ---");
            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);
            Console.WriteLine(pages);
        }

        // Q8: int.Parse and int.TryParse
        static void Q8()
        {
            Console.WriteLine("--- Q8 ---");
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            if (int.TryParse(badText, out int result))
                Console.WriteLine(result);
            else
                Console.WriteLine("Invalid number");
        }

        // Q9: int -> string using ToString()
        static void Q9()
        {
            Console.WriteLine("--- Q9 ---");
            int pages = 464;
            string pagesText = pages.ToString();
            Console.WriteLine(pagesText.GetType()); // System.String
        }

        // Q10: Boxing and unboxing
        static void Q10()
        {
            Console.WriteLine("--- Q10 ---");
            int copies = 100;
            object boxed = copies;        // boxing
            int unboxed = (int)boxed;     // unboxing
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
        }

        // Q11: Nullable value type int?
        static void Q11()
        {
            Console.WriteLine("--- Q11 ---");
            int? year = null;
            Console.WriteLine(year.HasValue); // False
            year = 2023;
            Console.WriteLine(year.HasValue); // True
            Console.WriteLine(year.Value);    // 2023
        }

        // Q12: Nullable reference type string?
        static void Q12()
        {
            Console.WriteLine("--- Q12 ---");
            string? reviewer = null;
            Console.WriteLine(reviewer == null); // True
        }

        // Q13: Null-conditional ?.
        static void Q13()
        {
            Console.WriteLine("--- Q13 ---");
            Book? book = null;
            string? title = book?.Title;   
            Console.WriteLine(title == null ? "null" : title);

            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);
        }

        // Q14: Null-forgiving operator !
        static void Q14()
        {
            Console.WriteLine("--- Q14 ---");
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
        }
        static void Q15() { }
    }
}