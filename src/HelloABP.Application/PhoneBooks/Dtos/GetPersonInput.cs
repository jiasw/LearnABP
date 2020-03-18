using Abp;
using Abp.Runtime.Validation;
using HelloABP.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloABP.PhoneBooks.Dtos
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {

        public string FilterText { get; set; }


        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
