using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public interface IEmplyee_dataRepository
    {
        IEnumerable<IEmplyee_dataRepository> GetEmplyee_Datas
        {
            get;
        }
        Employee_data getEmployeebyid();
        Employee_data deleteEmployeebyid(int emp_id);
        Employee_data getavailableleave(int emp_id);
    }
}
