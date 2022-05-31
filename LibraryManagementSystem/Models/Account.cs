using LibraryManagementSystem.Interfaces;

using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
  public abstract class Account
  {
    private ISearch _searchService;
    public Account(ISearch searchService)
    {
      _searchService = searchService;
    }

    public List<Book> SearchBookByTitle(string title)
    {
      return _searchService.SearchByTitle(title);
    }
  }
}
