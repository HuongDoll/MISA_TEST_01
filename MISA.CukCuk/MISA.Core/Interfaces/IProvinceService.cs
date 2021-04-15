﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;

namespace MISA.Core.Interfaces
{
    public interface IProvinceService : IBaseService<Province>
    {
        IEnumerable<Province> GetProvinceWithCountry(Guid entityId);
    }
}
