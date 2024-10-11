namespace PreAssignmentInfo_Live.Utils;

using PreAssignmentInfo_Live.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public record Client(string name, string Id);

internal class Library
{
    // Klassvariabler
    List<Book> books;

    // Constructor
    public Library()
    {
        books = new List<Book>(books);
    }

    public void AddBook(string title, string author, int year)
    {

    }

    public void ListBooks()
    {

    }

    public void RemoveBook(string title)
    {

    }


    public Book FindBook(string title)
    {
        return null;
    }

    private void SortBooksByTitle()
    {

    }
}
