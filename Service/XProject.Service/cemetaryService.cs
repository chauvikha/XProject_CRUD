using Invedia.DI.Attributes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Infrastructure;
using XProject.Contract.Repository.Interface;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;

namespace XProject.Service
{
    [ScopedDependency(ServiceType = typeof(IcemetaryService))]
    public class cemetaryService : Base.Service, IcemetaryService
    {
        private readonly IcemetaryRepository _cemetaryDailyRepo;
        private readonly IUnitOfWork _uof;
        public cemetaryService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _cemetaryDailyRepo = serviceProvider.GetRequiredService<IcemetaryRepository>();
            _uof = serviceProvider.GetRequiredService<IUnitOfWork>();
        }

        public void Create(cemetary model)
        {
            _cemetaryDailyRepo.Add(model);
            _uof.SaveChanges();
        }
        public void Delete(cemetary model, string id)
        {
            if (id == model.Id)
            {
                _cemetaryDailyRepo.Delete(model);
                _uof.SaveChanges();
            }
            
        }
        public void Read(cemetary model)
        {
            _cemetaryDailyRepo.Get().ToList();
            _uof.SaveChanges();
        }
        public void Update(cemetary model, string id)
        {
            if(id == model.Id)
            {
                _cemetaryDailyRepo.Delete(model);
                _uof.SaveChanges();
            }
            
        }

        public List<cemetary> GetALL(cemetary model)
        {
            return _cemetaryDailyRepo.Get().ToList();
        }

        
    }
}
