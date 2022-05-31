using LibraryManagementSystem.Interfaces;

using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
  public class Catalog : ISearch
  {
    public Dictionary<string, List<Book>> BookTitles;
    public Dictionary<string, List<Book>> BookAuthors;
    public Dictionary<string, List<Book>> BookSubjects;
    public Dictionary<DateTime, List<Book>> BookPublicationDates;
    public List<Book> SearchByAuthor(string author)
    {
      throw new NotImplementedException();
    }

    public List<Book> SearchByPublicationDate(DateTime publicationDate)
    {
      throw new NotImplementedException();
    }

    public List<Book> SearchBySubject(string subject)
    {
      throw new NotImplementedException();
    }

    public List<Book> SearchByTitle(string title)
    {
      if (!BookTitles.ContainsKey(title))
      {
        return null;
      }
      return BookTitles[title];
    }
  }
}
