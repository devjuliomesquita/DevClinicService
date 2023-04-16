using DevClinicService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Core.Entities
{
    public class Service : BaseEntity
    {
        public Service(int idClient, int idDoctor, string tokenService )
        {
            IdClient = idClient;
            IdDoctor = idDoctor;
            TokenService = tokenService;

            CreatedAt = DateTime.Now;
            Status = EnumServiceStatus.Created;

        }
        public DateTime CreatedAt { get; private set; }

        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }
        public int IdClient { get; private set; }
        public User? Client { get; private set; }
        public int IdDoctor { get; private set; }
        public User? Doctor { get; private set; }
        public string TokenService { get; private set; }
        public EnumServiceStatus Status { get; private set; }

        public void Cancel()
        {
            if( Status == EnumServiceStatus.InProgress )
            {
                Status = EnumServiceStatus.Cancelled;
            }
        }
        public void Start()
        {
            if( Status == EnumServiceStatus.Created)
            {
                Status = EnumServiceStatus.InProgress;
                StartedAt = DateTime.Now;
            }
        }
        public void Finish()
        {
            if(Status == EnumServiceStatus.InProgress)
            {
                Status = EnumServiceStatus.Finished;
                FinishedAt = DateTime.Now;
            }
        }
    }

}
