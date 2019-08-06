using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class LibraryCard
    {

        public virtual int LibraryCardId { get; set; }

        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string LastName { get; set; }

        [Required]
        public virtual DateTime DateOfBirth { get; set; }

        [Phone]
        public virtual string Phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength =5, ErrorMessage = "Your email cannot contain more than 50 characters")]
        [EmailAddress]
        public virtual string Email { get; set; }

        public virtual List<Checkout> Checkouts { get; set; }

    }
}