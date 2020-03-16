using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace HelloABP.PhoneBooks.PhoneNumbers
{
    [Table("PhoneNumber")]
    public class PhoneNumber : IHasCreationTime
    {

        [Required]
        [MaxLength(20)]
        public string Number { get; set; }

        public PhoneType Type { get; set; }

        public long PersonID { get; set; }

        public Persons.Person Person { get; set; }

        public DateTime CreationTime { get ; set; }
    }
}
