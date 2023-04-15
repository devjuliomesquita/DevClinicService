using DevClinicService.Application.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string firstName, string lastName, string email, string cPF, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CPF = cPF;
            Password = password;

            CreatedAt = DateTime.Now;
            Active = true;
            IsSpecialty = false;
            Specialties = new List<UserSpecialty>();
            ClientService = new List<Service>();
            DoctorService = new List<Service>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public bool IsSpecialty { get; private set; }
        public List<UserSpecialty> Specialties { get; private set; }
        public List<Service> ClientService { get; private set; }
        public List<Service> DoctorService { get; private set; }

        public void Update(
        string firstName,
        string lastName,
        string email,
        string cfp,
        string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CPF = cfp;
            Password = password;
        }
        public void IsSpecialtyDoctor()
        {
            IsSpecialty = true;
        }
    }

    
}
