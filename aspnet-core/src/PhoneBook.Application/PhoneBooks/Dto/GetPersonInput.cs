using Abp.Runtime.Validation;
using PhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.PhoneBooks.Dto
{
    public class GetPersonInput : PageAndSortedInputDto, IShouldNormalize
    {

        /// <summary>
        /// 模糊查询字段
        /// </summary>
        public string FilterText { get; set; }
        /// <summary>
        /// 默认排序
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
