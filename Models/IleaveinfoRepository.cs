﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalassign.Models
{
    public interface IleaveinfoRepository
    {
        IEnumerable<leaveinfo> GetLeaveinfos
        {
            get;
        }
    }
}
