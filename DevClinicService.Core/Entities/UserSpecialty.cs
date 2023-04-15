using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class UserSpecialty : BaseEntity
    {
        public UserSpecialty(int idUser, int idSpecialty)
        {
            IdUser = idUser;
            IdSpecialty = idSpecialty;
            
        }

        public int IdUser { get; private set; }
        public int IdSpecialty { get; private set; }
    }
}
