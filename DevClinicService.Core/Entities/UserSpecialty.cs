using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class UserSpecialty : BaseEntity
    {
        public UserSpecialty(int idUser, string description)
        {
            IdUser = idUser;
            Description = description;

            CreatedAt = DateTime.Now;
        }

        public int IdUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Description { get; private set; }
    }
}
