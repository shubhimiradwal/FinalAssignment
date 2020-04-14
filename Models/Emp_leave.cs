using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public class Emp_leave
    {
        public int emp_id
        {
            get;
            set;
        }
        public int leave_id
        {    get; 

            set; }
        public string leave_start{
            get;

            set;
        }
        public string leave_end
        {
            get;
            set;
        }
        public Employee_data Employee
        {
            get;set;
        }

       
        public leaveinfo leave
        {
            get;set;
        }
   
    }
}
