
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
  public abstract class Book
  {
    public string ISBN;
    public string Title;
    public string Subject;
    public string Publisher;
    public string Language;
    public int NumberOfPages;
    public List<Author> Authors;

    protected Book() { }

    protected Book(string iSBN, string title, string subject, string publisher, string language, int numberOfPages)
    {
      ISBN = iSBN;
      Title = title;
      Subject = subject;
      Publisher = publisher;
      Language = language;
      NumberOfPages = numberOfPages;
      Authors = new List<Author>();
    }
  }
}
