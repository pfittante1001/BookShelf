using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//This has a one to many relationship with the book class. Every book will have atleat one catagory
//One catagory can have many books
namespace BookShelf.Models
{
    public class Category
    {
        [Key]

        public int ID { get; set; }
        [Display(Name ="Catagory")]//this changes the title for the property directly below. So name will show as Category not name.
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }//Is a navigation property that sets up a list of books in a category and connect them to the category class.
    }
}