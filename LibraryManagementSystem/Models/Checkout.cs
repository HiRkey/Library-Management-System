using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Checkout
    {
        public virtual int CheckoutId { get; set; }

        public virtual int BookId { get; set; }
        public virtual Book CheckBook { get; set; }

        public virtual int LibraryCardId { get; set; }
        public virtual LibraryCard CheckLibrary { get; set; }

        public virtual DateTime Since { get; set; }
        public virtual DateTime Until { get; set; }

    }
}