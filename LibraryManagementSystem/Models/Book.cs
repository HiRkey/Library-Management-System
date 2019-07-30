using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Book
    {

        public virtual int BookId { get; set; }

        public virtual int Isbn { get; set; }

        public virtual string Title { get; set; }

        public virtual int Year { get; set; }

        public virtual string Author { get; set; }

        public virtual string ImageUrl { get; set; }

        public virtual LibraryBranch Location { get; set; }

    }
}