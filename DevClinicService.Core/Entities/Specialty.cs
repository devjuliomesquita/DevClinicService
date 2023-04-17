using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class Specialty : BaseEntity
    {
        public Specialty(string description, int idUser)
        {
            Description = description;
            CreatedAt = DateTime.Now;
            IdUser = idUser;
            
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int IdUser { get; private set; }

    }
}
