using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PhoneBook.PhoneBooks.Dto;

namespace PhoneBook.PhoneBooks
{
    public class PersonAppServer : PhoneBookAppServiceBase, IPersonAppServer
    {
        public Task CreateOrUpdatePersonAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeletePersonAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            throw new NotImplementedException();
        }

        public Task<PersonListDto> GetPersonByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
