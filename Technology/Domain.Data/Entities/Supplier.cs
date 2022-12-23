﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Data.Entities
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(40)]
        public string? CompanyName { get; set; }

        [MaxLength(30)]
        public string? ContactName { get; set; }

        [MaxLength(30)]
        public string? ContactTitle { get; set; }

        [MaxLength(60)]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? City { get; set; }

        [MaxLength(15)]
        public string? Region { get; set; }

        [MaxLength(10)]
        public string? PostalCode { get; set; }

        [MaxLength(15)]
        public string? Country { get; set; }

        [MaxLength(24)]
        public string? Phone { get; set; }

        [MaxLength(24)]
        public string? Fax { get; set; }

        public string? HomePage { get; set; }
    }
}
