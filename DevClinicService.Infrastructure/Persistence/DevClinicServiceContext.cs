using DevClinicService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Infrastructure.Persistence
{
    public class DevClinicServiceContext
    {
        public DevClinicServiceContext()
        {
            Users = new List<User>();
            Services = new List<Service>();
            Specialtys = new List<UserSpecialty>();
        }
        public List<User> Users { get; set; }
        public List<Service> Services { get; set; }
        public List<UserSpecialty> Specialtys { get; set; }
    }
}
