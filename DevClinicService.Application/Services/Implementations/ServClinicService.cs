﻿using DevClinicService.Application.InputModels;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Application.ViewModels;
using DevClinicService.Infrastructure.Persistence;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Finish(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public ServiceDetailsViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Start(int id)
        {
            throw new NotImplementedException();
        }
    }
}