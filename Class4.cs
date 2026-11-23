using System;

public class Class1
{
    string title = "clean code";

    string upperTitle = title.ToUpper();

    Console.WriteLine(title);
Console.WriteLine(upperTitle);



        //Q2 
        string title1 = "Clean Code";
    string title2 = "Clean Code";

    Console.WriteLine(object.ReferenceEquals(title1, title2));

	public Class1()
    {
    }
}
//Q3
using System.Text;

StringBuilder sb = new StringBuilder();

sb.Append("Book List");
sb.Append(" - Updated");

Console.WriteLine(sb.ToString());
//q4
using System.Text;

StringBuilder sb = new StringBuilder();

sb.Append("Book List");
sb.Append(" - Updated");

sb.Replace("Book List", "Library");

Console.WriteLine(sb.ToString());
//q5 
string title = "Clean Code";
int pages = 464;

string result = "Book: " + title + ", Pages: " + pages;

Console.WriteLine(result);

//q6
string title = "Clean Code";
int pages = 464;

string result = $"Book: {title}, Pages: {pages}";

Console.WriteLine(result);

//q7
string title = "Clean Code";
int pages = 464;

string result =
    string.Format("Book: {0}, Pages: {1}", title, pages);

Console.WriteLine(result);

//q8
int pages = 464;

if (pages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}

//q9
int pages = 464;
bool isAvailable = true;

if (pages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}

//q10
string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;

    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;

    default:
        Console.WriteLine("Never heard of it");
        break;
}

//q11
int pages = 464;

string sizeLabel =
    (pages > 300) ? "Long Book" : "Short Book";

Console.WriteLine(sizeLabel);

//Q12 
string[] books =
{
    "Clean Code",
    "The Pragmatic Programmer",
    "Refactoring"
};

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}

//q13
string[] books =
{
    "Clean Code",
    "The Pragmatic Programmer",
    "Refactoring"
};

int i = 0;

while (i < books.Length)
{
    Console.WriteLine(books[i]);
    i++;
}

//Q14
int count = 1;

do
{
    Console.WriteLine("Checking book...");
    count++;
}
while (count <= 3);

//q15
string[] books =
{
    "Clean Code",
    "The Pragmatic Programmer",
    "Refactoring"
};

foreach (string book in books)
{
    Console.WriteLine(book);
}