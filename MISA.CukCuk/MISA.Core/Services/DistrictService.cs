using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Core.Services
{
    public class DistrictService : BaseService<District>, IDistrictService
    {
        IDistrictRepository _districtRepository;
        public DistrictService(IDistrictRepository districtRepository) : base(districtRepository)
        {
            _districtRepository = districtRepository;
        }
        public IEnumerable<District> GetDistrictWithProvince(Guid entityId)
        {
            var entities = _districtRepository.GetDistrictWithProvince(entityId);
            return entities;
        }
    }
}
