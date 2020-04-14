using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public class MockleaveinfoRepository : IleaveinfoRepository
    {
        IEnumerable<leaveinfo> IleaveinfoRepository.GetLeaveinfos => throw new NotImplementedException();
    }
}
