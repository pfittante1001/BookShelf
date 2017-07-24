using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
 * When you are building a model in c# you will always want an unique ID
 */
namespace BookShelf.Models
{
    public class Book
    {
        [Key]//Primary Key

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]//foriegn key estalishes a relation with another class or table

        public int CatagoryId { get; set; }
        public virtual Category Category { get; set; }//The first Category is called a navigation property

    }
}