using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class LibraryBranch
    {
        public virtual int LibraryBranchId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Address { get; set; }

        public virtual string Phone { get; set; }
        
        public virtual string Hours { get; set; }

        public virtual string ImageUrl { get; set; }
        
    }
}