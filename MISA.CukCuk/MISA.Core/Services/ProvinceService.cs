using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Core.Services
{
    public class ProvinceService : BaseService<Province>, IProvinceService
    {
        public ProvinceService(IProvinceRepository provinceRepository) : base(provinceRepository) { }
    }
}
