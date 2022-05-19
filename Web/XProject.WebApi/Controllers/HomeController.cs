using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using XProject.Contract.Repository.Models;
using XProject.Contract.Service.Interface;
using XProject.Core.Constants;

namespace XProject.WebApi.Controllers
{
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWorkingTimeService _workingTimeService;
        private readonly IcemetaryService _cemetaryService;
        public HomeController(IServiceProvider serviceProvider)
        {
            _workingTimeService = serviceProvider.GetRequiredService<IWorkingTimeService>();
            _cemetaryService = serviceProvider.GetRequiredService<IcemetaryService>();
        }
        [HttpPost]
        [Route(Endpoints.HomeEndpoint.BaseEndpoint)]
        public void create(WorkingTime model)
        {
            _workingTimeService.Create(model);


        }
        [HttpPost]
        [Route(Endpoints.HomeEndpoint.create)]
        public void create([FromBody] cemetary model)
        {
            _cemetaryService.Create(model);


        }
        [HttpPost]
        [Route(Endpoints.HomeEndpoint.update)]
        public void update([FromBody] cemetary cemetary, string id) {
            _cemetaryService.Update(cemetary, id);
        }
        [HttpPost]
        [Route(Endpoints.HomeEndpoint.delete)]
        public void delete([FromBody] cemetary cemetary, string id) {
            _cemetaryService.Delete(cemetary, id);
        }
        [HttpGet]
        [Route(Endpoints.HomeEndpoint.getall)]
        public  List<cemetary> GetAll(cemetary model)
        {
            return _cemetaryService.GetALL(model);
        }
        //public List<cemetary> GetAlls()
        //{
        //    return _cemetaryService.GetAlls();
        //}
    }
}
