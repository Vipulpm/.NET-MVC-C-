using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }


        [Column(TypeName = "nvarchar(12)")]

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string AccountNumber { get; set; }
        [Required]
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string Code { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
