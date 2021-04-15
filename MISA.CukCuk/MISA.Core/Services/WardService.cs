using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Core.Services
{
    public class WardService : BaseService<Ward>, IWardService
    {
        IWardRepository _wardRepository;
        public WardService(IWardRepository wardRepository) : base(wardRepository)
        {
            _wardRepository = wardRepository;
        }
        public IEnumerable<Ward> GetWardWithDistrict(Guid entityId)
        {
            var entities = _wardRepository.GetWardWithDistrict(entityId);
            return entities;
        }
    }
}
