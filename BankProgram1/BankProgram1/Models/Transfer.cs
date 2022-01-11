using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BankProgram1.Models
{
    [Table("Transfer")]
    public partial class Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string TransferType { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TransferAmount { get; set; }

        [ForeignKey(nameof(ToAccount))]
        [InverseProperty(nameof(Account.Transfers))]
        public virtual Account ToAccountNavigation { get; set; }
    }
}
