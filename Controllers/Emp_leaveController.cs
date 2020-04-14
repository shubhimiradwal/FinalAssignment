using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finalassign.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Finalassign.Controllers
{
    public class Emp_leaveController : Controller
    {
        // GET: /<controller>/
        private readonly AppDbContext _dbcontext;

        public Emp_leaveController(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IEnumerable<leaveinfo> GetLeaveinfos(int id)
        {
            get{
                return _dbcontext.Empleave;
            };
        }

        public bo grandnewleave(int id)
        {
            get{
                return _dbcontext.Empleave;
            };
        }

    }
}
