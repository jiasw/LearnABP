using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HelloABP.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloABP.PhoneBooks.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    { 
       public long Id { get; set; }
        public string Name { get; set; }
       
        public string Email { get; set; }
       
        public string Address { get; set; }
    }
}
