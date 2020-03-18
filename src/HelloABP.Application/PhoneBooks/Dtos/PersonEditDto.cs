using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HelloABP.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloABP.PhoneBooks.Dtos
{
    [AutoMap(typeof(Person))]
    public class PersonEditDto:FullAuditedEntityDto<long>
    {
       
        public string Name { get; set; }
       
        public string Email { get; set; }
       
        public string Address { get; set; }
    }
}
