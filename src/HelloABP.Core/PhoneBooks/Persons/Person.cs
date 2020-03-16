using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace HelloABP.PhoneBooks.Persons
{
    [Table("Persons")]
    public class Person:FullAuditedEntity<long>
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(40)]
        public string Address { get; set; }
    }
}
