using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class LibraryCard
    {

        public virtual int LibraryCardId { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual string Phone { get; set; }

        public virtual string Email { get; set; }

        public virtual List<Checkout> Checkouts { get; set; }

    }
}