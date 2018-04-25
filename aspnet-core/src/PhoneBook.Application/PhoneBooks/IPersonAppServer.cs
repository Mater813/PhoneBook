using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoneBook.PhoneBooks.Dto;
using PhoneBook.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.PhoneBooks
{
    public  interface IPersonAppServer: IApplicationService
    {
        /// <summary>
        /// 获取联系人的相关信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据id获取相关联系人信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除联系人信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);

        
    }
}
