using CleanBase.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Validator
{
    public class VouchersValidation : AbstractValidator<Vouchers>
    {
        public VouchersValidation()
        {
            RuleFor(x => x.Vouchers_No).NotEmpty();
            RuleFor(x => x.Vouchers_Type).NotEmpty();
        }
    }
}
