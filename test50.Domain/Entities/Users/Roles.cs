using test50.Domain.Commons;

namespace test50.Domain.Entities.Users
{
    public class Roles : BaseEntities
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<UsersInRoles> UsersInROles { get; set; }
    }
}
