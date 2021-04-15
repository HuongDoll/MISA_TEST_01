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
        
        IProvinceRepository _provinceRepository;
        public ProvinceService(IProvinceRepository provinceRepository) : base(provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }
        public IEnumerable<Province> GetProvinceWithCountry(Guid entityId)
        {
            var entities = _provinceRepository.GetProvinceWithCountry(entityId);
            return entities;
        }
    }
}
