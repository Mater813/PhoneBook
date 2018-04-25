using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PhoneBook.PhoneBooks.Persons;

namespace PhoneBook.PhoneBooks.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { get; set; }
    }
}
