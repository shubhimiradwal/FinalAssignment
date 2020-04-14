using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public interface IEmp_leaveRepository
    {
        IEnumerable<Emp_leave> getleavedetails
        {
            get;
        }
    }
}
