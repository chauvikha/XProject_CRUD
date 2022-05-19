using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XProject.Contract.Repository.Models;

namespace XProject.Contract.Service.Interface
{
    public interface IcemetaryService
    {
        public void Create(cemetary model);
        public void Read(cemetary model);
        public void Delete(cemetary model, string id);
        public void Update(cemetary model, string id);
        List<cemetary> GetALL(cemetary model);
       
    } 
}
