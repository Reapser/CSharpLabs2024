using System;



class Title
{
    private string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Назва книги: " + title);
        Console.ResetColor();
    }
}

class Author
{
    private string authorName;

    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Автор: " + authorName);
        Console.ResetColor();
    }
}


class Content
{
    private string content;

    public string ContentText
    {
        get { return content; }
        set { content = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Зміст: " + content);
        Console.ResetColor();
    }
}


class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string bookTitle, string authorName, string contentText)
    {
        title = new Title(bookTitle);
        author = new Author();
        author.AuthorName = authorName;
        content = new Content();
        content.ContentText = contentText;
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }
}

class Program
{
    static void Main(string[] args)

    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Book book = new Book("Тополі", "Баскервілі Ілі", "Фентезійний  пригодницький роман з елементами хоррору, комедії, ");
        book.Show();
        
    }
}
