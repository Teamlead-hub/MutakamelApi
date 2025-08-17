using CleanBase.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Validator
{
    internal class V_vouchersValidation : AbstractValidator<V_Vouchers>
    {
        public V_vouchersValidation()
        {
            RuleFor(x => x.Vouchers_No).NotEmpty();
            RuleFor(x => x.Vouchers_Type).NotEmpty();
        }
    }
}
