using LibraryManagementSystem.Enums;

using System;

namespace LibraryManagementSystem.Models
{
  public class BookItem : Book
  {
    public BookFormat Format;
    public BookStatus Status;
    public DateTime BorrowedDate;
    public DateTime DueDate;


    public bool CheckOut()
    {
      if (Status != BookStatus.Available
        || Status == BookStatus.Lost
        || Status == BookStatus.Reserved)
      {
        return false;
      }
      Status = BookStatus.Loaned;
      return true;
    }

    public Rack PlacedAt;

  }
}
