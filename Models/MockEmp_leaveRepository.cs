using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public class MockEmp_leaveRepository : IEmp_leaveRepository
    {
        public IEnumerable<Emp_leave> getleavedetails => throw new NotImplementedException();
    }
}
