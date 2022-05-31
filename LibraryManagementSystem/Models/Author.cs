
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
  public class Author
  {
    private string _name;
    private string _description;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    public string Description
    {
      get { return _description; }
      set { _description = value; }
    }

    public List<Book> Books;
    protected Author() { }
    public Author(string name, string description)
    {
      _name = name;
      _description = description;
      Books = new List<Book>();
    }

  }
}
