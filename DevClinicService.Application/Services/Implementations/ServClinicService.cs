using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Application.ViewModels;
using DevClinicService.Core.Entities;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevClinicService.Application.Services.Implementations
{
    public class ServClinicService : IServClinicService
    {
        private readonly DevClinicServiceContext _context;
        public ServClinicService(DevClinicServiceContext context)
        {
            _context = context;
        }
        public int Create(AddServiceInputModel model)
        {
            var token = Guid.NewGuid().ToString("N").ToUpper()[..6];
            var service = new Service(
                model.IdCLient,
                model.IdDoctor,
                token);
            _context.Services.Add(service);
            _context.SaveChanges();
            return service.Id;
        }

        public void Delete(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);
            service!.Cancel();
            _context.SaveChanges();
        }

        public void Finish(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);
            service!.Finish();
            _context.SaveChanges();
        }

        public List<ServiceViewModel> GetAll(string query)
        {
            var services = _context.Services;
            var serviceViewModel = services
                .Select(s => new ServiceViewModel(s.Id, s.TokenService, s.CreatedAt))
                .ToList();
            return serviceViewModel;
        }

        public ServiceDetailsViewModel GetById(int id)
        {
            var service = _context.Services
                .Include(p => p.Client)
                .Include(p => p.Doctor)
                .SingleOrDefault(p => p.Id == id);
            if(service == null) { return null; }
            var serviceDetailsViewModel = new ServiceDetailsViewModel(
                service.Id,
                service.TokenService,
                service.CreatedAt,
                service.FinishedAt,
                service.Client!.FirstName,
                service.Doctor!.FirstName,
                service.Status.ToString());
            return serviceDetailsViewModel;
        }

        public void Start(int id)
        {
            var service = _context.Services.SingleOrDefault(s => s.Id == id);
            service!.Start();
            _context.SaveChanges();
        }
    }
}
