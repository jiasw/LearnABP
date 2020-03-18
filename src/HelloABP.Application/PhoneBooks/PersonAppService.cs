using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HelloABP.PhoneBooks.Dtos;
using HelloABP.PhoneBooks.Persons;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using AutoMapper;

namespace HelloABP.PhoneBooks
{
    public class PersonAppService : HelloABPAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person,long> _personRepository;
        private readonly IMapper _mapper;

        public PersonAppService(IRepository<Person, long> personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id>0)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }


        protected async Task UpdatePersonAsync(PersonEditDto personEditDto)
        {
            var entity = await _personRepository.GetAsync(personEditDto.Id);
            
            _mapper.Map<PersonEditDto,Person>(personEditDto,entity);

            await _personRepository.UpdateAsync(entity);
        }

        protected async Task CreatePersonAsync(PersonEditDto personEditDto)
        {
            try
            {
                var person = _mapper.Map<Person>(personEditDto);
                await _personRepository.InsertAsync(person);
            }
            catch (Exception ex)
            {

                throw;
            }
            
           
        }
        public async Task DeletePersonAsync(EntityDto<long> input)
        {
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagePersonAsync(GetPersonInput input)
        {
            try
            {
                var query = _personRepository.GetAll();

                var personCount = await query.CountAsync();

                var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

                var dtos = _mapper.Map<List<PersonListDto>>(persons);

                return new PagedResultDto<PersonListDto>(personCount, dtos);
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }

        public async Task<PersonListDto> GetPersonByIDAsync(NullableIdDto<long> input)
        {
          var person=  await _personRepository.GetAsync(input.Id.Value);

            return _mapper.Map<PersonListDto>(person);
        }
    }
}
