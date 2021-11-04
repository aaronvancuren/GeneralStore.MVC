using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        // Transaction table is a "Joining Table"

        [Key]
        public int TransactionId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }

        // Reflection of the [Key] Property in the Product Table
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        // Navigation to Product Table
        public virtual Product Product { get; set; }

        // Reflection of the [Key] Property in the Product Table
        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        // Navigation to Customer Table
        public virtual Customer Customer { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}