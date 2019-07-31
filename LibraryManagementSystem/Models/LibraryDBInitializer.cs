using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class LibraryDBInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            Book AliceInWonderland = new Book
            {
                Isbn = 123456,
                Title = "Alice's Adventure In Wonderland",
                Year = 1865,
                Author = "Charles Lutwidge Dodgson",
                ImageUrl = "Content/Images/Aiw.png"
            };
                                          
            Book Dracula = new Book
            { 
                Isbn = 246802,
                Title = "Dracula",
                Year = 1992,
                Author = "Bram Stoker",
                ImageUrl = "Content/Images/Dracula.png"
            };

            Book Frankenstein = new Book
            { 
                Isbn = 369258,
                Title = "Frankenstein",
                Year = 1818,
                Author = "Mary Wollstonecraft",
                ImageUrl = "Content/Images/Frankenstein.png"
            };

            Book PrideAndPrejudice = new Book
            { 
                Isbn = 482604,
                Title = "Pride and Prejudice",
                Year = 1813,
                Author = "Jane Austen",
                ImageUrl = "Content/Images/Pap.png"
            };


            Book SherlockHolmes = new Book
            { 
                Isbn = 505050,
                Title = "The Adventures of Sherlock Holmes",
                Year = 1892,
                Author = "Arthur Conan Doyle",
                ImageUrl = "Content/Images/Sherlock.png"
            };

            Book TomSawyer = new Book
            {
                Isbn = 628406,
                Title = "The Adventures of Tom Sawyer",
                Year = 1876,
                Author = "Mark Twain",
                ImageUrl = "Content/Images/Tom.png"
            };

            LibraryCard GCBC200300001 = new LibraryCard
            {
                FirstName = "Jack",
                LastName = "Jill",
                DateOfBirth = DateTime.Parse("08-22-1955"),
                Phone = "(705) 536 4353",
                Email = "qwerty@gmail.com"
            };

            LibraryCard GCBC200300002 = new LibraryCard
            {
                FirstName = "Bob",
                LastName = "Ross",
                DateOfBirth = DateTime.Parse("05-15-1977"),
                Phone = "(705) 453 8355",
                Email = "asdfgh@gmail.com"
            };

            LibraryCard GCBC200300003 = new LibraryCard
            {
                FirstName = "Suzy",
                LastName = "Sheer",
                DateOfBirth = DateTime.Parse("01-10-2011"),
                Phone = "(705) 365 3452",
                Email = "zxcvbn@hotmail.ca"
            };

            LibraryCard GCBC200300004 = new LibraryCard
            {
                FirstName = "Zack",
                LastName = "Bell",
                DateOfBirth = DateTime.Parse("07-28-2004"),
                Phone = "(705) 257 5856",
                Email = "tgbyhnujm@google.org"
            };

            LibraryBranch BarrieBranch = new LibraryBranch
            {
                Name = "Georgian College, Barrie",
                Address = "1 Georgian Dr, Barrie, ON L4M 3X9",
                Phone = "(705) 728-1968",
                Hours = "8-4:30",
                ImageUrl = "Content/Images/Barrie"
            };

            LibraryBranch OrilliaBranch = new LibraryBranch
            {
                Name = "Georgian College, Orillia",
                Address = "825 Memorial Ave, Orillia, ON L3V 6S2",
                Phone = "(705) 325-2740",
                Hours = "7:30-8",
                ImageUrl = "Content/Images/Orillia"
            };

            LibraryBranch MidlandBranch = new LibraryBranch
            {
                Name = "Midland",
                Address = "649 Prospect Blvd, Midland, ON L4R 4K6",
                Phone = "(705) 526-3666",
                Hours = "8-4",
                ImageUrl = "Content/Images/Midland"
            };

            context.Books.Add(AliceInWonderland);
            context.Books.Add(Dracula);
            context.Books.Add(Frankenstein);
            context.Books.Add(PrideAndPrejudice);
            context.Books.Add(SherlockHolmes);
            context.Books.Add(TomSawyer);

            context.LibraryCards.Add(GCBC200300001);
            context.LibraryCards.Add(GCBC200300002);
            context.LibraryCards.Add(GCBC200300003);
            context.LibraryCards.Add(GCBC200300004);

            context.LibraryBranches.Add(BarrieBranch);
            context.LibraryBranches.Add(OrilliaBranch);
            context.LibraryBranches.Add(MidlandBranch);

            base.Seed(context);
        }
    }
}