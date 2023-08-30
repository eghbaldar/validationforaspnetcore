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
    public class Roles : BaseEntities
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<UsersInRoles> UsersInROles { get; set; }
    }
    public class UsersInRoles
    {
        public long Id { get; set; }
        public virtual Users Users { get; set; }
        public long UsersId { get; set; }
        public virtual Roles Roles { get; set; }
        public long RolesId { get; set; }
    }
}
