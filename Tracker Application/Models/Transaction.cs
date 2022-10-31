using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker_Application.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
