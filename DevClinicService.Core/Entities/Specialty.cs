using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class Specialty : BaseEntity
    {
        public Specialty(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
