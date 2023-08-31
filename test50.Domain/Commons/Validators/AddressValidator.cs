using FluentValidation;
using test50.Domain.Entities.Users;

namespace test50.Domain.Commons.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Country)
                .MaximumLength(5)
                .WithMessage("less than 5")
                .MinimumLength(2)
                .WithMessage("more than 2");
        }
    }
}
