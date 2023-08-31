using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test50.Domain.Commons;
using test50.Domain.Commons.Validators;

namespace test50.Domain.Entities.Users
{
    public class Users : BaseEntities
    {
        public long Id { get; set; }

        [UserValidators("Name")]
        public string Name { get; set; }
    }
}
