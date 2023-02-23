using System;

namespace library_demo 
{
    public class PictureBook : Book
    {
      private string _illustrator = "";

      public PictureBook(string author, string title, string illustrator) :base(author, title)
      {

      }

      public string GetIllustrator()
      {
        return _illustrator;
      }

      public void SetIllustrator(string illustrator)
      {
        _illustrator = illustrator;
      }
    }
}