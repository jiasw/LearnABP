using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelloABP.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public int SkipCount { get; set; }
        [Range(0, int.MaxValue)]
        public int MaxResultCount { get; set; }

        [Range(0, 500)]
        public string Sorting { get; set; }
    }
}
