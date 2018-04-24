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
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据id获取相关用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync();

        /// <summary>
        /// 新增或修改用户信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync();

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync();
    }
}
