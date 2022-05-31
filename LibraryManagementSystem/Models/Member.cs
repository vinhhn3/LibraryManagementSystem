using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
  public class Member : Account
  {
    public Member(ISearch searchService) : base(searchService)
    {
    }
  }
}
