using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using PhoneBook.PhoneBooks.Dto;
using PhoneBook.PhoneBooks.Persons;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using Abp.AutoMapper;
using Abp.UI;

namespace PhoneBook.PhoneBooks
{
    public class PersonAppServer : PhoneBookAppServiceBase, IPersonAppServer
    {
        private readonly IRepository<Person> _personRepository;
        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("该联系人已消失，无法二次删除。");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var qury = _personRepository.GetAll();
            var personCount = await qury.CountAsync();
            var persons = await qury.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount,dtos);
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();
        } 

        protected async Task UpdatePersonAsync(PersonEditDto input) {
            var entity = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            _personRepository.Insert(input.MapTo<Person>());
        }
    }
}
