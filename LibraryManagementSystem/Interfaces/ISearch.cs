using LibraryManagementSystem.Models;

using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Interfaces
{
  public interface ISearch
  {
    List<Book> SearchByTitle(string title);
    List<Book> SearchByAuthor(string author);
    List<Book> SearchBySubject(string subject);
    List<Book> SearchByPublicationDate(DateTime publicationDate);

  }
}
