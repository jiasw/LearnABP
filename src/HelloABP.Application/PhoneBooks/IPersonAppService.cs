using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HelloABP.PhoneBooks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloABP.PhoneBooks
{
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取人的相关信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagePersonAsync(GetPersonInput input);
        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonEditDto> GetPersonByIDAsync(NullableIdDto<long> input);
        /// <summary>
        /// 新增修改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);
        /// <summary>
        /// 删除人员信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto<long> input);
    }
}
