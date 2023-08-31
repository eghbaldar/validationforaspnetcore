using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test50.Domain.Entities.Users;

namespace test50.Domain.Commons.Validators
{
    /// <summary>
    /// /////////////////////////////////////// FluentValidation ////////////////////////////
    /// </summary>
    //NuGet\Install-Package FluentValidation -Version 11.7.1
    public class RoleValidator: AbstractValidator<Roles>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(3);
        }
    }
}
