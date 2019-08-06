using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class LibraryBranch
    {
        [Required]
        public virtual int LibraryBranchId { get; set; }

        [Required]
        //[RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage ="Only uppercase and lowercase letters are allowed")]
        public virtual string Name { get; set; }

        [Required]
        public virtual string Address { get; set; }
        
        [Required]
        [DataType(DataType.PhoneNumber)]
        public virtual string Phone { get; set; }

        [Required]
        [DisplayName("Open From")]
        public virtual string Hours { get; set; }

        public virtual string ImageUrl { get; set; }
        
    }
}