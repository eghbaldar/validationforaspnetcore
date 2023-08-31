using ServiceStack.FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test50.Domain.Commons.Validators;

namespace test50.Domain.Entities.Users
{
    [Validator(typeof(AddressValidator))] // this line could have not been here!
    public class Address
    {
        public int Id { get; set; }
        [AddressValidators]
        public string Country { get; set; }
    }
}
