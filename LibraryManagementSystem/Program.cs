using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Catalog catalog = new Catalog();
      Member member = new Member(catalog);
      member.SearchBookByTitle("abc");
    }
  }
}
