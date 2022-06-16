using DnD.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace DnD.Infrastructure.Models
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator UserModel(User v)
        {
            return new UserModel()
            {
                Id = v.Id,
                UserName = v.UserName,
                FirstName = v.FirstName,
                LastName = v.LastName
            };
        }

        public static implicit operator User(UserModel v)
        {
            return new User()
            {
                Id = v.Id,
                UserName = v.UserName,
                FirstName = v.FirstName,
                LastName = v.LastName
            };
        }
    }
}
