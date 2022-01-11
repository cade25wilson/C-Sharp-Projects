using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BankProgram1.Models
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            Transfers = new HashSet<Transfer>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(450)]
        public string AccountOwner { get; set; }
        [Required]
        [StringLength(10)]
        public string AccountType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BeginningBalance { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CurrentBalance { get; set; }

        [ForeignKey(nameof(AccountOwner))]
        [InverseProperty(nameof(AspNetUser.Accounts))]
        public virtual AspNetUser AccountOwnerNavigation { get; set; }
        [InverseProperty(nameof(Transfer.ToAccountNavigation))]
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
