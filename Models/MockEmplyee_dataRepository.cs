using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public class MockEmplyee_dataRepository:IEmplyee_dataRepository
    {
        public IEnumerable<IEmplyee_dataRepository> GetEmplyee_Datas => throw new NotImplementedException();

        public IEnumerable<>
        public Employee_data GetEmployeebyid(int emp_id)
        {
            return details.firstOrDefault(p => p.emp_id == emp_id);
        }
        public Employee_data deleteEmployeebyid(int emp_id)
        {
            

        }
         public int getavailableleave(int emp_id)
        {

        }

    }
}
